using System;
using System.Collections.Generic;
using System.IO;

namespace MMBNSaveEditor
{
    /// <summary>A chip entry, which Folders are comprised of.</summary>
    class FolderChip
    {
        public ushort chipID;
        public ushort codeLetterValue;
        
        public static int length { get { return M.game == 1 || M.game >= 4? 2 : 4; } }
        
        /// <summary>Initializes object by reading from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        public FolderChip(int position)
        {
            chipID = M.game == 1 || M.game >= 4? M.saveData.readByte(position) : M.saveData.readUShort(position);
            codeLetterValue = M.game == 1 || M.game >= 4? M.saveData.readByte(position + 1) : M.saveData.readUShort(position + 2);
            
            if (M.game >= 4) // BN4+ stores single byte each for ID and code, but doubles code value so that chip IDs past 255 can add 1 to it from upper byte
            {
                int idUpper = codeLetterValue % 2;
                chipID += (ushort)(256 * idUpper);
                codeLetterValue /= 2;
            }
        }
        
        /// <summary>Initializes object by passing parameters.</summary>
        /// <param name="chipID">The ID of the chip.</param>
        /// <param name="codeLetterValue">The byte value for the letter code.</param>
        public FolderChip(ushort chipID, ushort codeLetterValue)
        {
            this.chipID = chipID;
            this.codeLetterValue = codeLetterValue;
        }
        
        /// <summary>Writes chip data at address.</summary>
        /// <param name="position">The address to write to.</param>
        public void write(int position)
        {
            if (M.game == 1)
            {
                M.saveData.writeByte(position, (byte)chipID);
                M.saveData.writeByte(position + 1, (byte)codeLetterValue);
            }
            else if (M.game < 4)
            {
                M.saveData.writeUShort(position, chipID);
                M.saveData.writeUShort(position + 2, codeLetterValue);
            }
            else
            {
                byte writtenChipID = 0;
                byte writtenCode = (byte)(codeLetterValue * 2);
                if (chipID >= 256)
                {
                    writtenChipID = (byte)(chipID % 256);
                    writtenCode += (byte)(chipID / 256);
                }
                else
                    writtenChipID = (byte)chipID;
                
                M.saveData.writeByte(position, writtenChipID);
                M.saveData.writeByte(position + 1, writtenCode);
            }
        }
        
        /// <summary>Prints chip info to string.</summary>
        /// <param name="writer">The StringWriter to write to.</param>
        /// <param name="isRegular">Whether this chip is set as a Regular Chip.</param>
        public void printChip(StringWriter writer, bool isRegular = false)
        {
            writer.WriteLine(M.saveData.getChipName(chipID) + " "
                           + (codeLetterValue < SaveData.letterCodes.Length? SaveData.letterCodes[codeLetterValue].ToString() : "INVALID CODE #" + codeLetterValue + ")")
                           + (isRegular? " [Regular]" : ""));
        }
    }
    
    /// <summary>Data for each unique chip that contains quantity and Pack position of each code for that chip.</summary>
    class PackChipSet
    {
        int chipID;
        byte[] totalQuantity;
        byte[] packPositions;
        
        static bool showInvalidStarCodes = false; // Whether to show * code when not valid for chip
        static bool showUnobtainableChipCodes = false; // Whether to show valid-but-unobtainable chip codes
        static bool showInvalidChipCodes = false; // Whether to show invalid (unimplemented) chip codes
        static bool showUnobtainedChipCounts = false; // Whether to show all codes or just ones you have some of
        
        public static int length { get { return M.game == 1? 0x10 : M.game == 2 || M.game == 3? 0x12 : 0x0C; } }
        static int codeCount { get { return M.game == 1? 5 : M.game == 2 || M.game == 3? 6 : 4; } }
        
        static Dictionary<int, string> packList;
        
        /// <summary>Initializes object by reading from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="chipID">The ID of the chip this represents.</param>
        public PackChipSet(int position, int chipID)
        {
            this.chipID = chipID;
            int positionsStart = M.game < 4? 0x06 : 0x04;
            totalQuantity = M.saveData.readBytes(position, codeCount);
            packPositions = M.saveData.readBytes(position + positionsStart, codeCount * 2);
        }
        
        /// <summary>Initializes object by passing parameters.</summary>
        /// <param name="chipID">The ID of the chip this represents.</param>
        /// <param name="totalQuantity">The quantity of each code of the chip. If not given, fills with 0s.</param>
        /// <param name="packPositions">The position of each code in the pack. If not given, fills with 0s.</param>
        public PackChipSet(int chipID, byte[] totalQuantity = null, byte[] packPositions = null)
        {
            this.chipID = chipID;
            
            if (totalQuantity != null)
                this.totalQuantity = totalQuantity;
            else
                this.totalQuantity = new byte[codeCount];
            
            if (packPositions != null)
                this.packPositions = packPositions;
            else
            {
                this.packPositions = new byte[codeCount * 2];
                if (M.game <= 3) // Initial pack positions are all FF
                {
                    for (int i = 0; i < this.packPositions.Length; i++)
                        this.packPositions[i] = 0xFF;
                }
            }
        }
        
        /// <summary>Writes chip set data at address.</summary>
        /// <param name="position">The address to write to.</param>
        public void write(int position)
        {
            int positionsStart = M.game < 4? 0x06 : 0x04;
            M.saveData.writeBytes(position, totalQuantity);
            M.saveData.writeBytes(position + positionsStart, packPositions);
        }
        
        /// <summary>Modifies the quantity of a chip in this set.</summary>
        /// <param name="codeIndex">The index of the chip code.</param>
        /// <param name="quantityChange">The quantity to give (positive) or take (negative), or to go up to if upToQuantity is true.</param>
        /// <param name="upToQuantity">Whether to raise the quanttiy up to "quantity" argument.</param>
        /// <param name="packSlotZero">Whether to assign zero to pack slots to match new-game behavior.</param>
        /// <returns>Whether the quantity was changed.</returns>
        public bool modifyQuantity(int codeIndex, int quantityChange = 1, bool upToQuantity = false, bool packSlotZero = false)
        {
            bool changesMade = false;
            
            if (codeIndex < 0 || codeIndex > totalQuantity.Length)
                return changesMade;
            
            if ((!upToQuantity && quantityChange > 0) || (upToQuantity && quantityChange > totalQuantity[codeIndex])) // When adding, put at/move to top of pack
            {
                if (!packSlotZero)
                {
                    ushort nextSlot = M.saveData.nextPackSlotValue;
                    SaveData.writeUShortInByteArray(ref packPositions, codeIndex * 2, nextSlot);
                    M.saveData.nextPackSlotValue--;
                }
                else
                {
                    packPositions[codeIndex * 2] = 0;
                    packPositions[(codeIndex * 2) + 1] = 0;
                }
                changesMade = true;
            }
            
            int previousQuantity = totalQuantity[codeIndex];
            bool countExtraInstances = M.game >= 4;
            byte myMinimum = (byte)M.saveData.getChipInstancesInFolders(chipID, M.saveData.getDefIndex<string>("chipCodes", chipID)[codeIndex], countExtraInstances);
            
            if (!upToQuantity) // Add/subtract from current, staying within minimum and maximum
                totalQuantity[codeIndex] = (byte)Math.Max(Math.Min(totalQuantity[codeIndex] + quantityChange, 99), myMinimum);
            else if (totalQuantity[codeIndex] < quantityChange) // Increase to given value if current quantity is lower
                totalQuantity[codeIndex] = (byte)quantityChange;
            
            if (totalQuantity[codeIndex] < myMinimum)
                totalQuantity[codeIndex] = myMinimum;
           
            if (totalQuantity[codeIndex] != previousQuantity)
                changesMade = true;
            
            // If final quantity is greater than zero, make sure to set library flag and more.
            if (totalQuantity[codeIndex] > 0)
            {
                if (!M.saveData.libraryChipFlags[chipID])
                {
                    M.saveData.setLibraryChipFlag(chipID);
                    changesMade = true;
                }
                
                // Set e-Reader chip data if owned and not set.
                if (M.game == 4)
                {
                    string eReaderID = "";
                    byte graphicsFirstByte = 0xFF;
                    string nameString = "";
                    string descString = "";
                    int nameFullLength = 0;
                    int descFullLength = 0;
                    
                    if (chipID == 311)
                    {
                        eReaderID = "duo";
                        nameString = M.saveData.language == "en"? BN4Definitions.eReaderDuoName : BN4Definitions.eReaderDuoNameJP;
                        descString = M.saveData.language == "en"? BN4Definitions.eReaderDuoDesc : BN4Definitions.eReaderDuoDescJP;
                        nameFullLength = M.saveData.eReaderDataDuoName.Length;
                        descFullLength = M.saveData.eReaderDataDuoDesc.Length;
                        graphicsFirstByte = M.saveData.eReaderDataDuoGraphics[0];
                    }
                    else if (chipID == 312)
                    {
                        eReaderID = "prixpowr";
                        nameString = M.saveData.language == "en"? BN4Definitions.eReaderPrixPowrName : BN4Definitions.eReaderPrixPowrNameJP;
                        descString = M.saveData.language == "en"? BN4Definitions.eReaderPrixPowrDesc : BN4Definitions.eReaderPrixPowrDescJP;
                        nameFullLength = M.saveData.eReaderDataPrixPowrName.Length;
                        descFullLength = M.saveData.eReaderDataPrixPowrDesc.Length;
                        graphicsFirstByte = M.saveData.eReaderDataPrixPowrGraphics[0];
                    }
                    
                    // Text unset, or graphics start with 11 (expected) or 00 (no data)
                    if (eReaderID != "" && (M.saveData.isEReaderStringUnset(eReaderID) || graphicsFirstByte == 0x11 || graphicsFirstByte == 0x00))
                    {
                        byte[] stringStartBytes = new byte[] { 0x02, 0x00 };
                        byte[] stringEndBytes = new byte[] { 0xE5 };
                        byte[] nameBytes = M.saveData.getTableStringBytes(nameString, stringStartBytes, stringEndBytes, nameFullLength);
                        byte[] descBytes = M.saveData.getTableStringBytes(descString, stringStartBytes, stringEndBytes, descFullLength);
                        
                        if (eReaderID == "duo")
                        {
                            M.saveData.eReaderDataDuoName = nameBytes;
                            M.saveData.eReaderDataDuoDesc = descBytes;
                            M.saveData.eReaderDataDuoGraphics = BN4Definitions.eReaderDuoGraphics;
                        }
                        else if (eReaderID == "prixpowr")
                        {
                            M.saveData.eReaderDataPrixPowrName = nameBytes;
                            M.saveData.eReaderDataPrixPowrDesc = descBytes;
                            M.saveData.eReaderDataPrixPowrGraphics = BN4Definitions.eReaderPrixPowrGraphics;
                        }
                    }
                }
            }
            
            return changesMade;
        }
        
        /// <summary>Gets the quantity of a chip in this set.</summary>
        /// <param name="codeIndex">The index of the chip code.</param>
        /// <returns>The quantity of the chip.</returns>
        public byte getQuantity(int codeIndex)
        {
            return totalQuantity[codeIndex];
        }
        
        /// <summary>Initializes pack list, before it is assigned to by printChipQuantities.</summary>
        public static void initPackList()
        {
            packList = new Dictionary<int, string>();
        }
        
        /// <summary>Prints chip set info to string.</summary>
        /// <param name="writer">The StringWriter to write to.</param>
        public bool printChipQuantities(StringWriter writer)
        {
            if (!showUnobtainedChipCounts)
            {
                bool haveAny = false;
                for (int i = 0; i < totalQuantity.Length; i++)
                {
                    if (totalQuantity[i] > 0)
                    {
                        haveAny = true;
                        break;
                    }
                }
                if (!haveAny)
                    return false;
            }
            
            writer.Write(M.saveData.getChipName(chipID) + " ");
            
            string codes = M.saveData.getChipCodes(chipID);
            bool wroteCode = false;
            for (int i = 0; i < totalQuantity.Length; i++)
            {
                char code = codes[i];
                
                bool invalid = code == '-';
                if (showInvalidChipCodes)
                    invalid = false;
                if (showInvalidStarCodes && i == totalQuantity.Length - 1 && totalQuantity[i] > 0) // Game knows last code is *, so it's valid in a sense; show only if you have one
                    invalid = false;
                if (!showUnobtainedChipCounts && totalQuantity[i] == 0)
                    invalid = true;
                if (!showUnobtainableChipCodes && !M.saveData.isChipObtainable(chipID, i))
                    invalid = true;
                if (invalid)
                    continue;
                
                int slot = packPositions[i * 2] + (256 * packPositions[(i * 2) + 1]);
                if (wroteCode)
                    writer.Write(", ");
                writer.Write(code + " x" + totalQuantity[i]
                    + ((slot == 0 || slot == 65535) && totalQuantity[i] > 0? " (all in folder" + (M.game >= 2? "s" : "") + ")" : ""));
                if (totalQuantity[i] > 0 && slot > 0 && slot < 65535)
                    packList[slot] = M.saveData.getChipName(chipID) + " " + code;
                wroteCode = true;
            }
            writer.WriteLine();
            
            return true;
        }
        
        /// <summary>Prints the pack list to string once it's been fully compiled.</summary>
        /// <param name="writer">The StringWriter to write to.</param>
        public static void printPackList(StringWriter writer)
        {
            List<int> packSlots = new List<int>(packList.Keys);
            if (packSlots.Count > 0)
            {
                packSlots.Sort();
                for (int i = 0; i < packSlots.Count; i++)
                    writer.WriteLine(packList[packSlots[i]]);
            }
            else
                writer.WriteLine("N/A");
        }
    }
    
    /// <summary>An item within a shop's inventory, which shop inventories are comprised of.</summary>
    class ShopItem
    {
        byte type = 0;
        byte stock = 0;
        ushort itemID = 0;
        ushort code = 0;
        uint price = 0;
        ushort unused = 0xFFFF; // BN2 only, always FF FF
        
        public static byte T_KEYITEM { get { return 0x01; } }
        public static byte T_CHIP { get { return (byte)(M.game == 1? 0x00 : 0x02); } }
        public static byte T_PROGRAM { get { return (byte)(M.game >= 3? 0x03 : 0xEE); } }
        public static byte T_BLANK  { get { return 0x00; } }
        
        public static int length { get { return M.game == 2? 0xC : 0x8; } }
        
        /// <summary>Initializes object by reading from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        public ShopItem(int position)
        {
            if (M.game == 1)
            {
                type = M.saveData.readByte(position);
                itemID = M.saveData.readByte(position + 1);
                code = M.saveData.readByte(position + 2);
                stock = M.saveData.readByte(position + 3);
                price = M.saveData.readUInt(position + 4);
            }
            else if (M.game == 2)
            {
                type = M.saveData.readByte(position);
                stock = M.saveData.readByte(position + 1);
                unused = M.saveData.readUShort(position + 2);
                itemID = M.saveData.readUShort(position + 4);
                code = M.saveData.readUShort(position + 6);
                price = M.saveData.readUInt(position + 8);
            }
            else if (M.game >= 3)
            {
                type = M.saveData.readByte(position);
                stock = M.saveData.readByte(position + 1);
                itemID = M.saveData.readUShort(position + 2);
                code = M.saveData.readUShort(position + 4);
                price = M.saveData.readUShort(position + 6);
            }
        }
        
        /// <summary>Initializes object by passing parameters.</summary>
        /// <param name="type">The item type: 00 for nothing, 01 for key item, 02 for chip, 03 for program.</param>
        /// <param name="itemID">The ID of the item.</param>
        /// <param name="code">For chips, the letter value for the code. For items, 0xFF.</param>
        /// <param name="price">The price of the item, either in Zennys (divided by 100 in BN3 on) or in BugFrags.</param>
        /// <param name="stock">The number in stock. 0xFF means infinite stock.</param>
        public ShopItem(byte type, ushort itemID, ushort code, uint price, byte stock = 1)
        {
            this.type = type;
            this.stock = stock;
            this.itemID = itemID;
            this.code = code;
            this.price = price;
        }
        
        /// <summary>Initializes object as an blank item for game.</summary>
        public ShopItem()
        {
            if (M.game == 1)
            {
                this.type = 0xFF;
                this.stock = 0xFF;
                this.itemID = 0xFFFF;
                this.code = 0xFFFF;
                this.price = 0xFFFFFFFF;
            }
            else
            {
                this.type = 0x00;
                this.stock = 0x00;
                this.itemID = 0x00;
                this.code = 0x00;
                this.price = 0x00;
            }
        }
        
        /// <summary>Writes item data at address.</summary>
        /// <param name="position">The address to write to.</param>
        public void write(int position)
        {
            if (M.game == 1)
            {
                M.saveData.writeByte(position, type);
                M.saveData.writeByte(position + 1, (byte)itemID);
                M.saveData.writeByte(position + 2, (byte)code);
                M.saveData.writeByte(position + 3, stock);
                M.saveData.writeUInt(position + 4, price);
            }
            else if (M.game == 2)
            {
                M.saveData.writeByte(position, type);
                M.saveData.writeByte(position + 1, stock);
                M.saveData.writeUShort(position + 2, unused);
                M.saveData.writeUShort(position + 4, itemID);
                M.saveData.writeUShort(position + 6, code);
                M.saveData.writeUInt(position + 8, price);
            }
            else if (M.game >= 3)
            {
                M.saveData.writeByte(position, type);
                M.saveData.writeByte(position + 1, stock);
                M.saveData.writeUShort(position + 2, itemID);
                M.saveData.writeUShort(position + 4, code);
                M.saveData.writeUShort(position + 6, (ushort)price);
            }
        }
        
        /// <summary>Override of equality function.</summary>
        /// <param name="item">The item to compare with.</param>
        /// <param name="includingStock">Whether to require that the number in stock also be the same.</param>
        /// <returns>Whether the items are the same.</returns>
        public bool Equals(ShopItem item, bool includingStock = true)
        {
            return type == item.type && (stock == item.stock || !includingStock) && itemID == item.itemID && code == item.code && price == item.price;
        }
        
        /// <summary>Checks if the item is actually an item and not an empty slot.</summary>
        /// <returns>Whether the item is not an empty slot.</returns>
        public bool isItem()
        {
            return type != T_BLANK;
        }
        
        /// <summary>Checks if the item is an HPMemory.</summary>
        /// <returns>Whether the item is an HPMemory.</returns>
        public bool isHPMemory()
        {
            int hpMemoryIndex = (new List<string>(M.saveData.getDef<string[]>("keyItemNames"))).IndexOf("HPMemory");
            return type == T_KEYITEM && itemID == hpMemoryIndex;
        }
        
        /// <summary>Checks if the item is a PowerUP.</summary>
        /// <returns>Whether the item is a PowerUP.</returns>
        public bool isPowerUP()
        {
            int powerUpIndex = (new List<string>(M.saveData.getDef<string[]>("keyItemNames"))).IndexOf("PowerUP");
            return type == T_KEYITEM && itemID == powerUpIndex;
        }
        
        /// <summary>Checks if the item is a key item, with a specific ID if given.</summary>
        /// <param name="keyItemID">The ID of the key item to check for. If not specified, it returns true for any key item.</param>
        /// <returns>Whether the item is a key item, and matches ID if given.</returns>
        public bool isKeyItem(int keyItemID = -1)
        {
            return type == T_KEYITEM && (keyItemID == -1 || itemID == keyItemID);
        }
        
        /// <summary>Returns the item's price variable.</summary>
        /// <returns>The price of the item, either an exact value or a factor-reduced one depending on the game.</returns>
        public uint getPrice()
        {
            return price;
        }
        
        /// <summary>Sets the item's price variable.</summary>
        /// <param name="price">The new price of the item.</param>
        public void setPrice(ushort price)
        {
            this.price = price;
        }
        
        /// <summary>Replaces item ID and code if it matches the given ID and code.</summary>
        /// <param name="matchItemID">The original item ID to look for.</param>
        /// <param name="matchCode">The original item code to look for.</param>
        /// <param name="newItemID">The item ID to replace with if it matches.</param>
        /// <param name="newCode">The item code to replace with if it matches.</param>
        /// <returns>Whether the item was replaced.</returns>
        public bool replaceItem(ushort matchItemID, ushort matchCode, ushort newItemID, ushort newCode)
        {
            if (itemID == matchItemID && code == matchCode)
            {
                itemID = newItemID;
                code = newCode;
                return true;
            }
            return false;
        }
        
        /// <summary>Prints item info to string.</summary>
        /// <param name="writer">The StringWriter to write to.</param>
        /// <param name="bugFrags">Whether the price is in BugFrags rather than Zenny.</param>
        public void printShopItem(StringWriter writer, bool bugFrags = false)
        {
            string itemName = "";
            
            if (type == T_KEYITEM) // Can also include upgrade items and SubChips
                itemName = M.saveData.getKeyItemName(itemID);
            else if (type == T_CHIP)
            {
                string codeStr = code < SaveData.letterCodes.Length? SaveData.letterCodes[code].ToString() : "INVALID CODE #" + code + ")";
                itemName = M.saveData.getChipName(itemID) + " " + codeStr;
            }
            else if (type == T_PROGRAM)
            {
                string color = new string[] { "?", "W", "P", "Y", "R", "B", "G", "O", "Pu", "Gray" }[code];
                itemName = M.saveData.getProgramName(itemID / 4) + " (" + color + ")";
            }
            else if (type != T_BLANK)
                itemName = "Unknown Item Type #" + type + ", ID " + itemID + ", code " + code;
            else // Nothing
                return;
            
            string priceStr = M.game >= 3? (!bugFrags? (price * 100) + "z" : price + "f") : (price + "z");
            writer.WriteLine(itemName + " " + (stock != 255? "x" + stock : "[Infinite]") + " (" + priceStr + ")");
            if (itemName == "")
                Console.WriteLine("type = " + type + ", itemID = " + itemID + " -> " + itemName + " " + (stock != 255? "x" + stock : "[Infinite]") + " (" + priceStr + ")");
        }
        
        /// <summary>Returns a list of values for definition.</summary>
        /// <returns>String of values as a comma-separated array.</returns>
        public string getDefinitionArrayString()
        {
            return "0x" + type.ToString("X2") + ", 0x" + itemID.ToString("X2") + ", 0x" + code.ToString("X2") + ", " + price + ", " + stock;
        }
    }
    
    /// <summary>Data for active NPCs and other interactable map objects.</summary>
    class NPCData
    {
        byte[] bytes;
        
        public static int length { get { return M.game < 3? 0xC0 : M.game == 3? 0xC4 : M.game == 4? 0xD8 : 0; } }
        
        /// <summary>Initializes object by reading from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        public NPCData(int position)
        {
            bytes = M.saveData.readBytes(position, length);
        }
        
        /// <summary>Initializes object with blank data.</summary>
        public NPCData()
        {
            bytes = new byte[length];
        }
        
        /// <summary>Clears NPC data. Useful for initializing NPC slots, or clearing out NPCs from old area when changing location.</summary>
        /// <param name="slotID">Slot value to assign even to empty entries.</param>
        public void clear(int slotID = -1)
        {
            // Clear almost all bytes.
            for (int i = 0; i < bytes.Length; i++)
            {
                if (i == 0x02 || i == 0x03) // Skip slot IDs
                    continue;
                bytes[i] = 0x00;
            }
            
            // NPC data always has a slot ID even before being "filled"; if these aren't set, NPCs will fail to load in.
            if (slotID > -1)
            {
                if (M.game == 1)
                    bytes[0x02] = 0x94;
                else if (M.game == 2 || M.game == 3)
                    bytes[0x02] = 0x92;
                else if (M.game == 4)
                    bytes[0x02] = 0xA2;
                bytes[0x03] = (byte)slotID;
            }
        }
        
        /// <summary>Writes NPC data at address.</summary>
        /// <param name="position">The address to write to.</param>
        public void write(int position)
        {
            M.saveData.writeBytes(position, bytes);
        }
    }
    
    /// <summary>A direct pointer to encounter data which can vary depending on version.</summary>
    class EncounterPointer
    {
        uint readAddress = 0x0;
        public byte area = 0x00;
        public byte subsection = 0x00;
        public int offsetInArea = 0;
        
        /// <summary>Initializes object by reading from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        public EncounterPointer(int position)
        {
            readAddress = M.saveData.readUInt(position);
            area = 0x00;
            subsection = 0x00;
            offsetInArea = 0;
            
            if (readAddress == 0)
                return;
            
            determineOffsetFromReadAddress();
        }
        
        /// <summary>Initializes object with blank data.</summary>
        public EncounterPointer()
        {
            readAddress = 0x0;
            area = 0x00;
            subsection = 0x00;
            offsetInArea = 0;
        }
        
        /// <summary>Try to determine what area the read address belongs to based on current version settings. May be called later if version was read incorrectly at first.</summary>
        public void determineOffsetFromReadAddress()
        {
            BNDefinitions def = SaveData.getGameDef();
           
            // Determine what area pointers readAddress is cloest to (by comparing to base address for subsection 00).
            area = 0x00;
            int closestOffsetToAreaBase = int.MaxValue;
            uint myBaseAddress = 0;
            for (byte checkArea = 0x80; checkArea < 0x9F; checkArea++)
            {
                uint areaBaseAddress = def.getBaseEncounterPointerForArea(checkArea, 0x00, M.saveData.version, M.saveData.language, M.saveData.lc);
                if (areaBaseAddress == 0)
                    continue;
                
                if (readAddress >= areaBaseAddress) // Could be part of this area; check if it's a lower relative offset any others so far
                {
                    int relativeOffset = (int)(readAddress - areaBaseAddress);
                    if (relativeOffset < closestOffsetToAreaBase)
                    {
                        closestOffsetToAreaBase = relativeOffset;
                        area = checkArea;
                        subsection = 0x00;
                        myBaseAddress = areaBaseAddress;
                    }
                }
                else // Passed, so stop searching and stick with current area
                    break;
            }
            
            // Determine what subsection in the selected area readAddress is closest to.
            offsetInArea = int.MaxValue;
            for (byte checkSub = 0x00; checkSub < 0x40; checkSub++)
            {
                uint subsectionAddress = def.getBaseEncounterPointerForArea(area, checkSub, M.saveData.version, M.saveData.language, M.saveData.lc);
                if (subsectionAddress == 0)
                    continue;
                
                if (readAddress >= subsectionAddress) // Could be part of this subsection; check if it's a lower relative offset than any others so far
                {
                    int relativeOffset = (int)(readAddress - subsectionAddress);
                    if (relativeOffset < offsetInArea)
                    {
                        offsetInArea = relativeOffset;
                        subsection = checkSub;
                        myBaseAddress = subsectionAddress;
                    }
                }
            }
            
            if (offsetInArea == int.MaxValue) // Couldn't find a match, so fall back on offset 0
                offsetInArea = 0;
            if (offsetInArea % def.encounterPointerSpacing != 0) // Offset does not match spacing from base, so fall back on offset 0
                offsetInArea = 0;
        }
        
        /// <summary>Gets the "encounter ID," a thing I made up that combines the area number and the offset within that area.</summary>
        /// <returns>An encounter ID indicating area and offset within that area's encounter data.</returns>
        public int getEncounterID()
        {
            if (area == 0x00)
                return 0;
            return (area * 0x10000) + (subsection * 0x100) + offsetInArea;
        }
        
        /// <summary>Sets pointer to the given encounter ID within area.</summary>
        /// <param name="area">The encounter ID. Set to 0 to unset pointer.</param>
        public void setEncounterID(int encounterID)
        {
            if (encounterID == 0)
            {
                area = 0x00;
                subsection = 0x00;
                offsetInArea = 0;
                return;
            }
            
            area = (byte)(encounterID / 0x10000);
            subsection = (byte)((encounterID % 0x10000) / 0x100);
            offsetInArea = encounterID % 0x100;
        }
        
        /// <summary>Writes pointer at address, relative to the proper base address for current version settings.</summary>
        /// <param name="position">The address to write to.</param>
        public void write(int position)
        {
            if (area == 0x00)
            {
                M.saveData.writeUInt(position, 0);
                return;
            }
            
            uint baseAddress = SaveData.getGameDef().getBaseEncounterPointerForArea(area, subsection, M.saveData.version, M.saveData.language, M.saveData.lc);
            M.saveData.writeUInt(position, (uint)(baseAddress + offsetInArea));
        }
    }
    
    /// <summary>A list of effect values influenced by installed programs or other customization.</summary>
    class ProgramEffects
    {
        byte[] originalBytes;
        
        // BN3 effects
        public byte superArmor = 0x00;
        public byte shadowType = 0x00;
        public byte airShoes = 0x00;
        public byte underShirt = 0x00;
        public byte breakBuster = 0x00;
        public byte humor = 0x00;
        public byte attackPlus = 0x00;
        public byte speedPlus = 0x00;
        public byte chargePlus = 0x00;
        public byte weaponLevel = 0x01;
        public byte breakCharge = 0x00;
        public byte shieldType = 0xFF;
        public byte bugEffect = 0x00;
        public byte regularPlus = 0x00;
        public byte startingChips = 0x05;
        public byte megaChipLimit = 0x05;
        public byte gigaChipLimit = 0x01;
        public byte groundType = 0x00;
        public byte fastGauge = 0x00;
        public byte sneakRun = 0x00;
        public byte attractType = 0xFF;
        public byte supportType = 0x00;
        public byte rewardType = 0x00;
        public byte busterMax = 0x00;
        public byte darkLicense = 0x00;
        public byte darkMind = 0x00;
        public byte bugStop = 0x00;
        public byte energyChange = 0x00;
        public byte alpha = 0x00;
        public byte activeStyle = 0x01;
        public byte press = 0x00;
        public byte totalHP = 0x64;
        public byte totalHPByte2 = 0x00;
        
        // New BN4 effects
        public byte unknownBN400 = 0x99;
        public byte floatShoes = 0x00;
        public byte busterAttack = 0x00;
        public byte chargeAttack = 0x01;
        public byte bugEffectAutoMove = 0x00;
        public byte bugEffectHPDrain = 0x00;
        public byte bugEffectCustomHPDrain = 0x00;
        public byte unknownBN410 = 0x20;
        public byte unknownBN411 = 0x04;
        public byte panelChange = 0xFF;
        public byte soulCleanse = 0x00;
        public byte defaultFullSync = 0x00;
        public byte unknownBN420 = 0x01;
        public byte firstBarrier = 0x00;
        public byte permanentSoul = 0x00;
        public byte megaManColor = 0x00;
        public byte allGuard = 0x00;
        public byte unknownBN42A = 0x01;
        public byte unknownBN430 = 0x64;
        public byte unknownBN432 = 0x64;
        public byte unknownBN434 = 0x64;
        public byte karma = 0xF4;
        public byte karmaByte2 = 0x01;
        
        public static int length { get { return M.game == 3? 0x2F : 0x40; } }
        
        /// <summary>Initializes object by reading from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        public ProgramEffects(int position)
        {
            originalBytes = M.saveData.readBytes(position, length);
            
            Dictionary<byte, object[]> effectDefs = SaveData.getGameDef(M.game).programEffectDefs;
            foreach (byte b in effectDefs.Keys)
            {
                if (b >= length) // Not real effect
                    continue;
                try
                {
                    this.GetType().GetField(effectDefs[b][0] as string).SetValue(this, originalBytes[b]);
                }
                catch
                {
                    Console.WriteLine("ProgramEffects field " + effectDefs[b][0] + " not found.");
                }
            }
        }
        
        /// <summary>Initializes object with game-start values (where setting same default value for all games is insufficient).</summary>
        public ProgramEffects()
        {
            originalBytes = new byte[length];
            
            if (M.game == 3)
            {
                shieldType = 0x00;
                attractType = 0xFF;
                totalHP = 0x14;
            }
            else if (M.game == 4)
            {
                shieldType = 0xFF;
                attractType = 0x1F;
                totalHP = 0x64;
            }
        }
        
        /// <summary>Writes program effect values at address.</summary>
        /// <param name="position">The address to write to.</param>
        public void write(int position)
        {
            // Start with the bytes as they were read originally, so that even unrecognized values stay the same instead of being set to 00.
            byte[] bytes = (byte[])originalBytes.Clone();
            
            Dictionary<byte, object[]> effectDefs = SaveData.getGameDef(M.game).programEffectDefs;
            foreach (byte b in effectDefs.Keys)
            {
                if (b > length) // Not real effect
                    continue;
                
                try
                {
                    bytes[b] = (byte)(this.GetType().GetField(effectDefs[b][0] as string).GetValue(this));
                }
                catch
                {
                    Console.WriteLine("ProgramEffects field " + effectDefs[b][0] + " not found.");
                    continue;
                }
            }
            
            M.saveData.writeBytes(position, bytes);
        }
        
        /// <summary>Returns info string listing all active effects.</summary>
        /// <returns>List of active effects.</returns>
        public string getFullInfoString()
        {
            Dictionary<byte, object[]> effectDefs = M.saveData.getDef<Dictionary<byte, object[]>>("programEffectDefs");
            
            string effectsStr = "";
            foreach (byte effectIndex in effectDefs.Keys)
            {
                int effectValue = 0xFF;
                try
                {
                    effectValue = (byte)(this.GetType().GetField(effectDefs[effectIndex][0] as string).GetValue(this));
                }
                catch
                {
                    Console.WriteLine("ProgramEffects field " + effectDefs[effectIndex][0] + " not found.");
                    continue;
                }
                
                if (effectValue != 0x00)
                {
                    string str = getProgramEffectString(effectIndex, true);
                    if (str != "")
                        effectsStr += (effectsStr != ""? Environment.NewLine : "") + str;
                }
            }
            
            if (effectsStr == "")
                return "N/A";
            return effectsStr;
        }
        
        /// <summary>Gets a display string for the given program effect.</summary>
        /// <param name="effettIndex">The index of the effect.</param>
        /// <param name="forSaveInfo">Whether this is for save info rather than menus, which in some cases affects presentation.</param>
        /// <returns>The string to print for this effect.</returns>
        public string getProgramEffectString(byte effectIndex, bool forSaveInfo = false)
        {
            object[] effectDef = M.saveData.getDefKey<byte, object[]>("programEffectDefs", effectIndex);
            if (effectDef == null)
                return "";
            
            byte value = 0xFF;
            try
            {
                value = (byte)(this.GetType().GetField(effectDef[0] as string).GetValue(this));
            }
            catch
            {
                Console.WriteLine("ProgramEffects field " + effectDef[0] + " not found.");
                return "";
            }
            
            string displayName = effectDef.Length > 1? effectDef[1] as string : "";
            
            int firstListIndex = 2;
            string specialMode = "";
            if (effectDef.Length > 2 && effectDef[2] is string) // If string comes after internal name and display name, use special mode
            {
                specialMode = effectDef[2] as string;
                firstListIndex = 3;
                
                if (specialMode == "" && forSaveInfo) // Don't display in save info (but do for options menu)
                    return "";
                else if (specialMode == ">1" && forSaveInfo && value <= 1) // Only display in save info if greater than 1
                    return "";
                else if (specialMode.Equals("zeroOneOrFF")) // Special handling for 00/01 that can also be FF
                {
                    bool isTrue = value == 0x01;
                    if (forSaveInfo) // In save info, if true, just display name; if false, don't display at all
                        return isTrue? displayName : "";
                    else // In menu, display name and true/false
                        return displayName + ": " + isTrue.ToString();
                }
                else if (specialMode.Equals("addedHP")) // Special handling for added HP
                {
                    int totalHP = M.saveData.getTotalHPWithExtras();
                    int baseMaxHP = M.saveData.getBaseHPWithoutExtras();
                    int addedHP = totalHP - baseMaxHP;
                    if (forSaveInfo)
                    {
                        if (addedHP == 0) // Don't show if 0
                            return "";
                        else // Leave out colon and space for "HP+"
                            return displayName + addedHP;
                    }
                    else
                        return displayName + ": " + addedHP;
                }
                else if (specialMode.Equals("karma")) // Special handling for two-byte karma
                {
                    if (!forSaveInfo)
                        return displayName + ": " + (karma + (karmaByte2 * 256));
                    else // Show separately from program effects in save info
                        return "";
                }
                else if (specialMode.StartsWith("%")) // Mod value beforehand
                {
                    int modValue = 0;
                    if (int.TryParse(specialMode.Substring(1), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out modValue))
                        value = (byte)(value % modValue);
                }
            }
            
            if (firstListIndex >= effectDef.Length) // After internal/display names and optional special mode, nothing else defined: Display value directly
            {
                if (forSaveInfo) // These all have format of "+Number", so leave out colon and space
                    return displayName + value;
                else
                    return displayName + ": " + value;
            }
            
            if (firstListIndex + 1 >= effectDef.Length) // Only one value defined in list: Treat as true/false
            {
                bool isTrue = value == Convert.ToByte(effectDef[firstListIndex]);
                if (forSaveInfo) // In save info, if true, just display name; if false, don't display at all
                    return isTrue? displayName : "";
                else // In menu, display name and true/false
                    return displayName + ": " + isTrue.ToString();
            }
            
            // Check value against defined value-string pairs.
            for (int i = firstListIndex; i + 1 < effectDef.Length; i += 2)
            {
                int negativeCheck = 0;
                int.TryParse(effectDef[i].ToString(), out negativeCheck);
                if (negativeCheck == -1) // Terminator for selectable options, but skip over it to check remaining values
                    continue;
                
                if (Convert.ToByte(effectDef[i]) == value)
                {
                    string valueStr = effectDef[i + 1] as string;
                    if (forSaveInfo)
                    {
                        // No need to show that effects are set to default in save info, only in program menu.
                        if (valueStr.Equals("None") || valueStr.Equals("Normal"))
                            return "";
                        
                        // For some effects, value without display name is not clear, so include clarifying text.
                        switch (effectDef[0] as string)
                        {
                            case "shieldType": return "B+Left: " + valueStr;
                            case "bugEffectAutoMove": return "Auto-Move Bug: " + valueStr;
                            
                            case "busterAttack":
                            case "chargeAttack":
                            case "panelChange":
                            case "megaManColor":
                                return displayName + ": " + valueStr;
                        }
                        
                        return valueStr; // Otherwise, just return value for save info
                    }
                    else
                        return displayName + ": " + valueStr;
                }
            }
            
            // If nothing found, display value as unknown
            return displayName + ": Unknown value " + value.ToString("X2");
        }
        
        /// <summary>Returns the total HP with programs.</summary>
        /// <returns>The total HP including HP+ programs.</returns>
        public ushort getTotalHP()
        {
            if (M.game == 3)
                return (ushort)((totalHP + (totalHPByte2 * 256)) * 5);
            else
                return (ushort)(totalHP + (totalHPByte2 * 256));
        }
        
        /// <summary>Sets the total HP with programs.</summary>
        /// <param name="totalHP">The new total HP including HP+ programs (will be rounded down to a multiple of 5 in BN3).</param>
        public void setTotalHP(uint newTotalHP)
        {
            ushort effectiveTotal = M.game == 3? (ushort)(newTotalHP / 5) : (ushort)newTotalHP;
            totalHP = (byte)(effectiveTotal % 256);
            totalHPByte2 = (byte)(effectiveTotal / 256);
        }
        
        /// <summary>Returns the current karma value.</summary>
        /// <returns>MegaMan's karma value.</returns>
        public ushort getKarma()
        {
            return (ushort)(karma + (karmaByte2 * 256));
        }
        
        /// <summary>Sets the karma value.</summary>
        /// <param name="newKarma">MegaMan's new karma value.</param>
        public void setKarma(ushort newKarma)
        {
            karma = (byte)(newKarma % 256);
            karmaByte2 = (byte)(newKarma / 256);
            M.saveData.updateKarmaVerification();
        }
        
        /// <summary>Sets the active style (BN3).</summary>
        /// <param name="styleValue">The new active style.</param>
        public void setActiveStyle(byte styleValue)
        {
            activeStyle = styleValue;
        }
    }
    
    /// <summary>An entry in a list of placed Navi Customizer programs.</summary>
    class PlacedProgram
    {
        ushort programID = 0;
        byte x = 0;
        byte y = 0;
        byte rotation = 0;
        
        public static int length { get { return 8; } }
        
        /// <summary>Initializes object by reading from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        public PlacedProgram(int position)
        {
            programID = M.saveData.readUShort(position);
            x = M.saveData.readByte(position + 2);
            y = M.saveData.readByte(position + 3);
            rotation = M.saveData.readByte(position + 4);
        }
        
        /// <summary>Initializes object by providing arguments.</summary>
        /// <param name="programID">The ID of the placed program.</param>
        /// <param name="x">The X position of the program.</param>
        /// <param name="y">The Y position of the program.</param>
        /// <param name="rotation">The rotation of the program.</param>
        public PlacedProgram(ushort programID, byte x, byte y, byte rotation)
        {
            this.programID = programID;
            this.x = x;
            this.y = y;
            this.rotation = rotation;
        }
        
        /// <summary>Writes program data at address.</summary>
        /// <param name="position">The address to write to.</param>
        public void write(int position)
        {
            M.saveData.writeUShort(position, programID);
            M.saveData.writeByte(position + 2, x);
            M.saveData.writeByte(position + 3, y);
            M.saveData.writeByte(position + 4, rotation);
        }
        
        /// <summary>Check if the program is actually a program and not an empty slot.</summary>
        /// <returns>Whether the program is not an empty slot.</returns>
        public bool isProgram()
        {
            return programID != 0;
        }
        
        /// <summary>Prints program info to string.</summary>
        /// <param name="writer">The StringWriter to write to.</param>
        public void printPlacedProgram(StringWriter writer)
        {
            int programNum = programID / 4;
            int colorIndex = programID % 4;
            string validColors = M.saveData.getDefIndex<string>("programColors", programNum);
            string colorStr = validColors[colorIndex] == 'U'? "Pu" : validColors[colorIndex] == 'D'? "Gray" : validColors[colorIndex].ToString();
            writer.WriteLine(M.saveData.getProgramName(programNum) + " (" + colorStr + ") (" + x + "," + y + ")" + (rotation != 0? " (" + (rotation * 90) + "-degree rotation)" : ""));
        }
    }
    
    /// <summary>An entrant on a MMBN4 tournament board.</summary>
    class TournamentEntrant
    {
        byte entrantID;
        byte advancementFlags;
        byte priority;
        byte unknown04;
        
        public static int length { get { return 4; } }
        
        /// <summary>Initializes object by reading from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        public TournamentEntrant(int position)
        {
            entrantID = M.saveData.readByte(position);
            advancementFlags = M.saveData.readByte(position + 1);
            priority = M.saveData.readByte(position + 2);
            unknown04 = M.saveData.readByte(position + 3);
        }
        
        /// <summary>Initializes object by providing arguments.</summary>
        /// <param name="entrantID">The ID of the competing Navi.</param>
        /// <param name="advancementFlags">Flags for advancement (whether they won their match in rounds 1-3, and whether they're still in the tournament).</param>
        /// <param name="priority">Priority of this Navi winning matches against computer opponents (lower value wins, 50-50 if they're equal).</param>
        /// <param name="unknown04">Unknown value (seems to always be 00).</param>
        public TournamentEntrant(byte entrantID, byte advancementFlags = 0x00, byte priority = 0x00, byte unknown04 = 0x00)
        {
            this.entrantID = entrantID;
            this.advancementFlags = advancementFlags;
            this.priority = priority;
            this.unknown04 = unknown04;
        }
        
        /// <summary>Writes tournament entrant data at address.</summary>
        /// <param name="position">The address to write to.</param>
        public void write(int position)
        {
            M.saveData.writeByte(position, entrantID);
            M.saveData.writeByte(position + 1, advancementFlags);
            M.saveData.writeByte(position + 2, priority);
            M.saveData.writeByte(position + 3, unknown04);
        }
        
        /// <summary>Returns ID of entrant.</summary>
        /// <returns>ID of entrant</returns>
        public byte getEntrantID()
        {
            return entrantID;
        }
        
        /// <summary>Returns how many rounds the entrant has won.</summary>
        /// <returns>How many rounds the entrant has won.</returns>
        public int getRoundsWon()
        {
            if ((advancementFlags & 4) != 0)
                return 3;
            else if ((advancementFlags & 2) != 0)
                return 2;
            else if ((advancementFlags & 1) != 0)
                return 1;
            return 0;
        }
        
        /// <summary>Returns whether entrant is still in the tournament.</summary>
        /// <returns>Whether entrant is still in the tournament.</returns>
        public bool isStillInTournament()
        {
            return (advancementFlags & 64) != 0;
        }
        
        /// <summary>Returns win priority for CPU matches.</summary>
        /// <returns>Win priority for CPU matches.</returns>
        public byte getPriority()
        {
            return priority;
        }
        
        /// <summary>Returns whether this entrant represents MegaMan and Lan.</summary>
        /// <returns>Whether this is MegaMan and Lan.</returns>
        public bool isMegaManAndLan()
        {
            return entrantID == 0x1E;
        }
        
        /// <summary>Sets ID of entrant, and returns whether it changed.</summary>
        /// <param name="entrantID">New entrant ID.</param>
        /// <returns>Whether entrant ID was changed.</returns>
        public bool setEntrantID(byte entrantID)
        {
            bool changed = this.entrantID != entrantID;
            this.entrantID = entrantID;
            return changed;
        }
        
        /// <summary>Sets how many rounds the entrant has won, and returns whether it changed.</summary>
        /// <param name="rounds">How many rounds the entrant has won.</returns>
        /// <returns>Whether rounds won were changed.</returns>
        public bool setRoundsWon(int rounds)
        {
            byte oldAdvacement = advancementFlags;
            byte inTournamentValue = (byte)((advancementFlags & 64) != 0? 64 : 0);
            advancementFlags = (byte)(inTournamentValue + (rounds > 0? 1 : 0) + (rounds > 1? 2 : 0) + (rounds > 2? 4 : 0));
            return advancementFlags != oldAdvacement;
        }
        
        /// <summary>Sets whether entrant is still in the tournament, and returns whether it changed.</summary>
        /// <param name="stillIn">New tournament status.</param>
        /// <returns>Whether status was changed.</returns>
        public bool setStillInTournament(bool stillIn)
        {
            byte oldAdvacement = advancementFlags;
            byte roundsValue = (byte)((advancementFlags & 64) != 0? advancementFlags - 64 : advancementFlags);
            advancementFlags = (byte)(roundsValue + (stillIn? 64 : 0));
            return advancementFlags != oldAdvacement;
        }
        
        /// <summary>Sets win priority for CPU matches, and returns whether it changed.</summary>
        /// <param name="priority">New win priority.</returns>
        /// <returns>Whether priority was changed.</returns>
        public bool setPriority(byte priority)
        {
            bool changed = this.priority != priority;
            this.priority = priority;
            return changed;
        }
       
        /// <summary>Checks whether the entrant (and thus board) is still uninitialized.</summary>
        /// <returns>Whether the entrant has an uninitialized ID.</returns>
        public bool isUninitialized()
        {
            return entrantID == 0xFF;
        }
        
        /// <summary>Gets string represenation of the current bytes.</summary>
        /// <returns>A hex string of the bytes for current values.</returns>
        public string getBytesString()
        {
            return entrantID.ToString("X2") + " " + advancementFlags.ToString("X2") + " " + priority.ToString("X2") + " " + unknown04.ToString("X2");
        }
    }
    
    /// <summary>Chip definition data from the ROM.</summary>
    class ROMChipData
    {
        public int index;
        int game;
        int startAddress;
        
        public byte[] chipCodes;
        public byte chipClass;
        public ushort idOrder;
        public ushort alphabetOrder;
        public byte element;
        public byte elementIcon;
        public byte memorySize;
        public byte rarity;
        public ushort attackPower;
        public byte chipEffectFlags;
        public byte counterType;
        public byte attackFamily;
        public byte attackSubfamily;
        public byte darkSoulUsage;
        public byte attackParam1;
        public byte attackParam2;
        public byte attackParam3;
        public byte attackParam4;
        public byte usageDelayFrames;
        public byte karmaRequirement;
        public byte libraryFlags;
        public byte gateUsageLimit;
        public uint chipIcon;
        public uint chipImage;
        public uint chipPalette;
        public short[] unknowns;
        
        static List<byte>[] knownValues;
        
        static bool alwaysWriteUnknowns = true;
        
        /// <summary>Loads chip data from bytes.</summary>
        /// <param name="index">The index of the chip in the internal list.</param>
        /// <param name="bytes">The bytes for the chip data.</param>
        /// <param name="startAddress">The address in the ROM where this chip data is located.</param>
        public ROMChipData(int index, byte[] bytes, int startAddress = -1)
        {
            this.index = index;
            this.startAddress = startAddress;
            game = M.game;
            
            chipCodes = new byte[game == 1? 5 : game == 2 || game == 3? 6 : game >= 4? 4 : 0];
            unknowns = new short[bytes.Length];
            for (int i = 0; i < bytes.Length; i++)
                unknowns[i] = -1;
            
            for (int i = 0; i < bytes.Length; i++)
            {
                byte b = bytes[i];
                byte b2 = i + 1 < bytes.Length? bytes[i + 1] : (byte)0;
                byte b3 = i + 2 < bytes.Length? bytes[i + 2] : (byte)0;
                byte b4 = i + 3 < bytes.Length? bytes[i + 3] : (byte)0;
                ushort sh = BitConverter.ToUInt16(new byte[] { b, b2 }, 0);
                uint it = BitConverter.ToUInt32(new byte[] { b, b2, b3, b4 }, 0);
                
                bool known = true;
                if (game == 1)
                {
                    switch (i)
                    {
                        case 0x00:
                        case 0x01:
                        case 0x02:
                        case 0x03:
                        case 0x04: chipCodes[i] = b; break;
                        case 0x05: element = b; break;
                        // 06 unknown, seems related to attack type
                        // 07 unknown
                        case 0x08: rarity = b; break;
                        case 0x09: idOrder = b; break;
                        case 0x0A: alphabetOrder = sh; i++; break;
                        case 0x0C: attackPower = sh; i++; break;
                        // 0E unknown; only values are 00, 99, and CC
                        // 0F unknown
                        case 0x10: chipIcon = it; i += 3; break;
                        case 0x14: chipImage = it; i += 3; break;
                        case 0x18: chipPalette = it; i += 3; break;
                        default: known = false; break;
                    }
                }
                else if (game == 2)
                {
                    switch (i)
                    {
                        case 0x00:
                        case 0x01:
                        case 0x02:
                        case 0x03:
                        case 0x04:
                        case 0x05: chipCodes[i] = b; break;
                        // 06 unknown
                        // 07 unknown
                        // 08 unknown
                        case 0x09: rarity = b; break;
                        case 0x0A: memorySize = b; break;
                        // 0B unknown
                        case 0x0C: attackPower = sh; i++; break;
                        case 0x0E: idOrder = sh; i++; break;
                        case 0x10: alphabetOrder = sh; i++; break;
                        // 12 unknown
                        // 13 unknown
                        case 0x14: chipIcon = it; i += 3; break;
                        case 0x18: chipImage = it; i += 3; break;
                        case 0x1C: chipPalette = it; i += 3; break;
                        default: known = false; break;
                    }
                }
                else if (game == 3)
                {
                    switch (i)
                    {
                        case 0x00:
                        case 0x01:
                        case 0x02:
                        case 0x03:
                        case 0x04:
                        case 0x05: chipCodes[i] = b; break;
                        case 0x06: element = b; break;
                        // 07 can be many values from 01 to 3D
                        // 08 can be many values from 00 to 64, plus a stray 96
                        case 0x09: rarity = b; break;
                        case 0x0A: memorySize = b; break;
                        // 0B can be various values
                        case 0x0C: attackPower = sh; i++; break;
                        case 0x0E: idOrder = sh; i++; break;
                        case 0x10: alphabetOrder = sh; i++; break;
                        // 12 is a value from 00 to 07; loosely "ability type," as there are groups for shields, barriers, recovery, panel break, hiding, swords...
                        // 13 can be various values
                        case 0x14: chipIcon = it; i += 3; break;
                        case 0x18: chipImage = it; i += 3; break;
                        case 0x1C: chipPalette = it; i += 3; break;
                        default: known = false; break;
                    }
                }
                else if (game == 4)
                {
                    switch (i)
                    {
                        case 0x00:
                        case 0x01:
                        case 0x02:
                        case 0x03: chipCodes[i] = b; break;
                        case 0x04: element = b; break;
                        case 0x05: rarity = b; break;
                        case 0x06: memorySize = b; break;
                        case 0x07: elementIcon = b; break;
                        case 0x08: chipClass = b; break;
                        case 0x09: chipEffectFlags = b; break;
                        case 0x0A: counterType = b; break;
                        case 0x0B: attackFamily = b; break;
                        case 0x0C: attackSubfamily = b; break;
                        case 0x0D: darkSoulUsage = b; break;
                        // 0E unknown
                        // 0F unknown
                        case 0x10: attackParam1 = b; break;
                        case 0x11: attackParam2 = b; break;
                        case 0x12: attackParam3 = b; break;
                        case 0x13: attackParam4 = b; break;
                        case 0x14: usageDelayFrames = b; break;
                        case 0x15: karmaRequirement = b; break;
                        case 0x16: libraryFlags = b; break;
                        // 17 unknown
                        case 0x18: alphabetOrder = sh; i++; break;
                        case 0x1A: attackPower = sh; i++; break;
                        case 0x1C: idOrder = sh; i++; break;
                        case 0x1E: gateUsageLimit = b; break;
                        // 1F unknown
                        case 0x20: chipIcon = it; i += 3; break;
                        case 0x24: chipImage = it; i += 3; break;
                        case 0x28: chipPalette = it; i += 3; break;
                        default: known = false; break;
                    }
                }
                
                if (!known)
                {
                    if (knownValues == null)
                        knownValues = new List<byte>[bytes.Length];
                    if (knownValues[i] == null)
                        knownValues[i] = new List<byte>();
                    if (!knownValues[i].Contains(b))
                        knownValues[i].Add(b);
                    
                    unknowns[i] = b;
                }
            }
        }
        
        /// <summary>Prints all recognized bytes.</summary>
        public static void printKnownValues()
        {
            if (knownValues == null)
                return;
            
            for (int i = 0; i < knownValues.Length; i++)
            {
                if (knownValues[i] != null)
                {
                    knownValues[i].Sort();
                    Console.Write(i.ToString("X2") + ":");
                    foreach (byte value in knownValues[i])
                        Console.Write(" " + value.ToString("X2"));
                    Console.WriteLine();
                }
            }
        }
        
        /// <summary>Gets the byte length of a single chip entry for the given game.</summary>
        /// <param name="game">The game the chip data is from.</param>
        /// <returns>The entry byte length.</returns>
        public static int getLength(int game)
        {
            return game == 1? 0x1C : game == 2 || game == 3? 0x20 : game >= 4? 0x2C : 0;
        }
        
        /// <summary>Returns a string summarizing the chip data.</summary>
        /// <param name="showUnknownOverride">Forces unidentified byte values to be listed as well.</param>
        /// <returns>A string representation of the chip data.</returns>
        public string getString(bool showUnknownOverride = false)
        {
            string chipName = M.saveData.getDefIndex<string>("chipNames", index);
            string codeLetters = getCodesString();
            
            StringWriter writer = new StringWriter();
            
            writer.Write((startAddress != -1? "[0x" + startAddress.ToString("X2") + "] " : "")
                + chipName + ": ID " + idOrder
                + ", Alphabet #" + alphabetOrder
                + ", Codes " + codeLetters
                + (game >= 3? ", Class " + chipClass : "")
                + ", Power " + attackPower
                + ", Element " + element
                + (game >= 2? ", Size " + memorySize : "")
                + ", Rarity " + rarity);
            
            if (alwaysWriteUnknowns || showUnknownOverride)
            {
                for (int i = 0; i < unknowns.Length; i++)
                {
                    if (unknowns[i] != -1)
                        writer.Write(" [" + i.ToString("X2") + "] " + unknowns[i].ToString("X2"));
                }
            }
            
            return writer.ToString();
        }
        
        /// <summary>Returns the letter codes defined for this chip in the data.</summary>
        /// <returns>A string of letter codes.</returns>
        public string getCodesString()
        {
            string codeLetters = "";
            foreach (byte codeValue in chipCodes)
                codeLetters += codeValue != 0xFF? SaveData.letterCodes[codeValue] : '-';
            return codeLetters;
        }
        
        /// <summary>Converts the chip data back to bytes.</summary>
        /// <returns>A byte array of the (potentially modified) chip data.</returns>
        public byte[] getBytes()
        {
            byte[] bytes = new byte[getLength(game)];
            
            if (game == 1)
            {
                Array.Copy(chipCodes, 0, bytes, 0, chipCodes.Length);
                bytes[0x05] = element;
                bytes[0x08] = rarity;
                bytes[0x09] = (byte)idOrder;
                Array.Copy(BitConverter.GetBytes(alphabetOrder), 0, bytes, 0x0A, 2);
                Array.Copy(BitConverter.GetBytes(attackPower), 0, bytes, 0x0C, 2);
                Array.Copy(BitConverter.GetBytes(chipIcon), 0, bytes, 0x10, 4);
                Array.Copy(BitConverter.GetBytes(chipImage), 0, bytes, 0x14, 4);
                Array.Copy(BitConverter.GetBytes(chipPalette), 0, bytes, 0x18, 4);
            }
            else if (game == 2)
            {
                Array.Copy(chipCodes, 0, bytes, 0, chipCodes.Length);
                bytes[0x0A] = memorySize;
                Array.Copy(BitConverter.GetBytes(attackPower), 0, bytes, 0x0C, 2);
                Array.Copy(BitConverter.GetBytes(idOrder), 0, bytes, 0x0E, 2);
                Array.Copy(BitConverter.GetBytes(alphabetOrder), 0, bytes, 0x10, 2);
                Array.Copy(BitConverter.GetBytes(chipIcon), 0, bytes, 0x14, 4);
                Array.Copy(BitConverter.GetBytes(chipImage), 0, bytes, 0x18, 4);
                Array.Copy(BitConverter.GetBytes(chipPalette), 0, bytes, 0x1C, 4);
            }
            else if (game == 3)
            {
                Array.Copy(chipCodes, 0, bytes, 0, chipCodes.Length);
                bytes[0x06] = element;
                bytes[0x09] = rarity;
                bytes[0x0A] = memorySize;
                Array.Copy(BitConverter.GetBytes(attackPower), 0, bytes, 0x0C, 2);
                Array.Copy(BitConverter.GetBytes(idOrder), 0, bytes, 0x0E, 2);
                Array.Copy(BitConverter.GetBytes(alphabetOrder), 0, bytes, 0x10, 2);
                Array.Copy(BitConverter.GetBytes(chipIcon), 0, bytes, 0x14, 4);
                Array.Copy(BitConverter.GetBytes(chipImage), 0, bytes, 0x18, 4);
                Array.Copy(BitConverter.GetBytes(chipPalette), 0, bytes, 0x1C, 4);
            }
            else if (game == 4)
            {
                Array.Copy(chipCodes, 0, bytes, 0, chipCodes.Length);
                bytes[0x04] = element;
                bytes[0x05] = rarity;
                bytes[0x06] = memorySize;
                bytes[0x07] = elementIcon;
                bytes[0x08] = chipClass;
                bytes[0x09] = chipEffectFlags;
                bytes[0x0A] = counterType;
                bytes[0x0B] = attackFamily;
                bytes[0x0C] = attackSubfamily;
                bytes[0x0D] = darkSoulUsage;
                bytes[0x10] = attackParam1;
                bytes[0x11] = attackParam2;
                bytes[0x12] = attackParam3;
                bytes[0x13] = attackParam4;
                bytes[0x14] = usageDelayFrames;
                bytes[0x15] = karmaRequirement;
                bytes[0x16] = libraryFlags;
                Array.Copy(BitConverter.GetBytes(alphabetOrder), 0, bytes, 0x18, 2);
                Array.Copy(BitConverter.GetBytes(attackPower), 0, bytes, 0x1A, 2);
                Array.Copy(BitConverter.GetBytes(idOrder), 0, bytes, 0x1C, 2);
                bytes[0x1E] = gateUsageLimit;
                Array.Copy(BitConverter.GetBytes(chipIcon), 0, bytes, 0x20, 4);
                Array.Copy(BitConverter.GetBytes(chipImage), 0, bytes, 0x24, 4);
                Array.Copy(BitConverter.GetBytes(chipPalette), 0, bytes, 0x28, 4);
            }
            
            for (int i = 0; i < unknowns.Length; i++)
                if (unknowns[i] != -1)
                    bytes[i] = (byte)unknowns[i];
            
            return bytes;
        }
    }
}
