using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MMBNSaveEditor
{
    /// <summary>Stores and manages save data.</summary>
    class SaveData
    {
        public byte[] fileBytes;
        
        public int game = 0;
        public char version = '\0';
        public string language = "";
        public bool lc = false;
        public string gbaSaveFormat = "sav";
        
        public bool fileIsLC = false;
        public bool generatedFromScratch = false;
        bool throwFileExceptions = false;
        bool onlyLoadingSteamID = false;
        
        List<DataField> fields;
        
        // Save Variables
        public bool[] flags = null;
        public bool[] libraryChipFlags = null;
        public bool[] libraryPAFlags = null;
        public bool[] librarySharedChipFlags = null;
        public bool[] librarySharedPAFlags = null;
        public FolderChip[] folderSlot1 = null;
        public PackChipSet[] pack = null;
        public ShopItem[][] shopInventories = null;
        public NPCData[] npcData = null;
        public bool[] npcFlags = null;
        public byte[] keyItemQuantities = null;
        public byte[] upgradeItemQuantities = null;
        public byte[] emailList = null;
        public byte area = 0;
        public byte subarea = 0;
        public short playerX = 0;
        public short playerY = 0;
        public short playerZ = 0;
        public byte playerFacingDir = 0;
        public byte jackInArea = 0;
        public byte jackInSubarea = 0;
        public short jackInX = 0;
        public short jackInY = 0;
        public short jackInZ = 0;
        public byte jackInFacingDir = 0;
        public byte currentMode = 0x1C;
        public byte chapter = 0;
        public byte currentMusic = 0;
        public ushort currentHP = 100;
        public ushort maxHP = 100;
        public uint zenny = 0;
        public uint playTime = 0;
        public uint timeInBattles = 0;
        public uint countdownTimer = 0;
        public ushort multiplayerBattleRecord = 0;
        public ushort multiplayerWinRecord = 0;
        public uint emailCount = 0;
        public int stepsWithoutEncounter = 0;
        public ushort nextPackSlotValue = 0x8000;
        public string titleString = "";
        
        public uint saveChecksum = 0;
        public uint steamID = 0;
        
        // BN2 onward
        public FolderChip[] folderSlot2 = null;
        public FolderChip[] folderSlot3 = null;
        public uint bugFrags = 0;
        public byte folderCount = 1;
        public byte equippedFolder = 0;
        public byte regularMemory = 0;
        public byte equippedFolderRegularChip = 0xFF;
        public byte folderSlot1RegularChip = 0xFF;
        public byte folderSlot2RegularChip = 0xFF;
        public byte folderSlot3RegularChip = 0xFF;
        public int[] bbsPostCounts = null;
        public byte[] bbsPostLists = null;
        public byte[] subchipQuantities = null;
        public int sneakRunStepsRemaining = 0;
        public int locEnemyStepsRemaining = 0;
        public EncounterPointer locEnemyEncounterPointer = null;
        
        // BN3 onward
        public byte spriteScaleX = 0x40;
        public byte spriteScaleY = 0x40;
        public byte mysteryLibraryCheckByte = 0xFF;
        public ProgramEffects programEffects = null;
        public PlacedProgram[] placedPrograms = null;
        public byte[] programQuantities = null;
        public bool[] programCompressedFlags = null;
        public byte[] programNumOnGridSquare = null;
        public ShopItem[] chipOrderInventory = null;
        public bool[] numberTraderFlags = null;
        
        // BN4 onward
        public uint saveEncryptionXOR = 0;
        public ushort memoryOffsetValue = 0;
        public uint zennyVerificationBase = 0;
        public uint bugFragsVerificationBase = 0;
        public ushort baseMaxHP = 100;
        public ushort overallMaxHP = 100;
        public ushort totalAddedHP = 0;
        public byte folderSlot1ID = 0x00;
        public byte folderSlot2ID = 0xFF;
        public byte folderSlot3ID = 0xFF;
        public byte unusedFolderSlot4ID = 0xFF;
        public short multiplayerVSVersionRecord = 0;
        public byte[] programColorsList = null;
        public byte[] itemVerificationSource = null;
        public byte[] itemVerificationBytes = null;
        public byte[] libraryFlagVerificationSource = null;
        public byte[] libraryFlagVerificationBytes = null;
        public byte[] librarySharedVerificationSource = null;
        public byte[] librarySharedVerificationBytes = null;
        
        // BN1, BN2 only
        public byte attackUpgrades = 0;
        public byte rapidUpgrades = 0;
        public byte chargeUpgrades = 0;
        
        // BN2, BN3 only
        public byte activeStyle = 0;
        
        // BN1 only
        public byte activeArmor = 0;
        public byte powerPlantBattery = 10;
        public ushort stepsShort = 0;
        public uint[] unknownBN1Pointers1 = null;
        public uint[] unknownBN1Pointers2 = null;
        
        // BN2 only
        public byte[] registeredStyles = null;
        public uint battlesSinceStyleChangeInt = 0;
        public uint[] styleProgressInts = null;
        
        // BN3 only
        public byte extraFolderID = 0xFF;
        public byte registeredStyle = 0;
        public byte styleLevel = 0;
        public byte styleAdvancementMode = 0;
        public ushort battlesSinceStyleChangeShort = 0;
        public byte[] styleProgressBytes = null;
        public byte[] errorCodesSavedBytes = null;
        public byte[] virusFoodDistribution = null;
        public uint[] timeTrialRecords = null;
        public uint libraryChecksum = 0;
        
        // BN4 only
        public byte playthroughNumber = 0;
        public byte battlePoints = 0;
        public string playerName = "———";
        public uint tournamentRandomSeed = 0;
        public uint karmaVerificationBase = 0;
        public uint karmaVerificationValue = 0;
        public TournamentEntrant[][] tournamentBoards = null;
        public byte[] possibleTournamentEntrants = null;
        public byte[] waitingRoomData = null;
        public byte[] waitingRoomDataB = null;
        public string[] waitingRoomNames = null;
        public ProgramEffects[] waitingRoomNaviProgramEffects = null;
        public ushort[] myNaviRecords = null;
        public ushort[] bestNaviRecords = null;
        public string[] naviRecordHolderNames = null;
        public byte[] mysteryDataLocationAndContents = null;
        public byte[] patchCardData = null;
        public byte firstActivePatchCard = 0;
        public byte[] patchCardVerificationSource = null;
        public byte[] patchCardVerificationBytes = null;
        public byte[] eReaderDataDuoName = null;
        public byte[] eReaderDataDuoDesc = null;
        public byte[] eReaderDataDuoGraphics = null;
        public byte[] eReaderDataPrixPowrName = null;
        public byte[] eReaderDataPrixPowrDesc = null;
        public byte[] eReaderDataPrixPowrGraphics = null;
        public byte[] eReaderDataPrixPowrIcon = null;
        public byte[] eReaderDataPatchCard0A = null;
        public byte[] eReaderDataPatchCard0B = null;
        public byte[] eReaderDataPatchCard0C = null;
        public byte[] eReaderDataPatchCard0D = null;
        public byte[] eReaderDataPatchCard0E = null;
        public byte[] eReaderDataPatchCard0F = null;
        
        // Data Types
        const byte T_BYTE = 0;
        const byte T_BYTES = 1;
        const byte T_USHORT = 2;
        const byte T_USHORTS = 3;
        const byte T_SHORT = 4;
        const byte T_SHORTS = 5;
        const byte T_UINT = 6;
        const byte T_UINTS = 7;
        const byte T_INT = 8;
        const byte T_INTS = 9;
        const byte T_FLAGS = 10;
        const byte T_ASCIISTRING = 11;
        const byte T_TABLESTRING = 12;
        const byte T_TABLESTRINGS = 13;
        const byte T_1BYTETABLESTRING = 14;
        const byte T_1BYTETABLESTRINGS = 15;
        const byte T_FOLDERCHIPS = 20;
        const byte T_PACKCHIPSETS = 21;
        const byte T_SHOPINVENTORY = 22;
        const byte T_SHOPINVENTORIES = 23;
        const byte T_ENCOUNTERPOINTER = 24;
        const byte T_PROGRAMEFFECTS = 25;
        const byte T_PROGRAMEFFECTSARRAY = 26;
        const byte T_PLACEDPROGRAMS = 27;
        const byte T_NPCS = 30;
        const byte T_TOURNAMENTBOARDS = 40;
        const byte T_SAVECHECKSUM = 50;
        const byte T_LIBRARYCHECKSUM = 51;
        
        // Per-Game Definitions (loaded from BNDefinitions classes)
        public static char[] letterCodes = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                             'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '*' };
        
        static Dictionary<int, string[]> chipNames;
        static Dictionary<int, string[]> paNames;
        static Dictionary<int, Dictionary<string, string[]>> chipAliases;
        static Dictionary<int, string[]> chipCodes;
        static Dictionary<int, Dictionary<int, byte[]>> unobtainableCodes;
        static Dictionary<int, int[]> chipSizes;
        
        static Dictionary<int, int[]> gameOrderStandardChips;
        static Dictionary<int, int[]> gameOrderMegaChipsMain;
        static Dictionary<int, int[]> gameOrderMegaChipsSub;
        static Dictionary<int, int[]> gameOrderMegaChipsAll;
        static Dictionary<int, int[]> gameOrderGigaChipsMain;
        static Dictionary<int, int[]> gameOrderGigaChipsSub;
        static Dictionary<int, int[]> gameOrderGigaChipsAll;
        static Dictionary<int, int[]> gameOrderSecretChipsMain;
        static Dictionary<int, int[]> gameOrderSecretChipsSub;
        static Dictionary<int, int[]> gameOrderSecretChipsAll;
        static Dictionary<int, int[]> gameOrderPAs;
        
        static Dictionary<int, string[]> keyItemNames;
        static Dictionary<int, string[]> upgradeItemNames;
        static Dictionary<int, int[][]> upgradeItemFlags;
        static Dictionary<int, string[]> subchipNames;
        static Dictionary<int, int[][]> shopInventoryAddresses;
        static Dictionary<int, int> upgradeItemIndexInKeyItems;
        static Dictionary<int, int> subchipIndexInKeyItems;
        static Dictionary<int, Dictionary<int, int[]>> shopHPMemoryPrices;
        static Dictionary<int, Dictionary<int, int[]>> shopPowerUpPrices;
        static Dictionary<int, Dictionary<int, int[]>> shopKeyItemPrices;
        static Dictionary<int, int[][]> libraryFlagRanges;
        
        static Dictionary<int, string[]> presetFolderNames;
        static Dictionary<int, Dictionary<string, string[]>> presetFolders;
        
        static Dictionary<int, string[]> programNames;
        static Dictionary<int, string[]> programColors;
        static Dictionary<int, Dictionary<byte, object[]>> programEffectDefs;
        
        static Dictionary<int, string[]> numberTraderCodes;
        
        static Dictionary<int, string[]> bbsNames;
        static Dictionary<int, string[]> styleTypes;
        
        static Dictionary<int, string[]> timeTrialNames;
        
        static Dictionary<int, Dictionary<byte, object[]>> patchCardDefs;
        
        static Dictionary<int, Dictionary<string, byte>> stringByteTable;
        static Dictionary<int, Dictionary<byte, string>> byteStringTable;
        
        static Dictionary<int, object[]> safeLocationLansRoom;
        static Dictionary<int, object[]> startLocationForFreshSave;
        static Dictionary<int, object[]> uninitializedJackInLocation;
        
        /// <summary>Constructor that takes in bytes from the save file.</summary>
        /// <param name="fileBytes">Bytes from the save file.</param>
        /// <param name="lc">Whether the save file is in Legacy Collection format.</param>
        /// <param name="extension">The extension of the save file, which determines save format for GBA.</param>
        /// <param name="onlyLoadSteamID">Whether this is a temporary save meant only for grabbing Steam ID.</param>
        public SaveData(byte[] fileBytes, bool lc = false, string extension = ".sav", bool onlyLoadSteamID = false)
        {
            this.fileBytes = fileBytes;
            this.lc = lc;
            this.fileIsLC = lc;
            this.onlyLoadingSteamID = onlyLoadSteamID;
            
            gbaSaveFormat = extension.Replace(".", "");
            if (gbaSaveFormat == "xps") // Treat xps the same as sps, because format-wise they seem to be
                gbaSaveFormat = "sps";
            
            // For non-SRAM saves, get only the raw save in fileBytes.
            string romName = "";
            if (gbaSaveFormat == "sps")
                romName = processSharkPortSave();
            else if (gbaSaveFormat == "gsv")
                romName = processGameSharkSPSave();
            
            // If cart name was given by special format save, determine game, version, and language from it.
            if (romName != "")
                determineGameFromCartName(romName);
           
            if (chipNames == null)
                initGameDefDictionaries();
        }
        
        /// <summary>Constructor that creates a fresh save for game, version, and language.</summary>
        /// <param name="game">The game number.</param>
        /// <param name="version">The game version.</param>
        /// <param name="language">The game language.</param>
        /// <param name="lc">Whether it's a Legacy Collection save or not.</param>
        public SaveData(int game, char version = 'M', string language = "en", bool lc = false)
        {
            this.game = game;
            this.version = version;
            this.language = language;
            this.lc = lc;
            generatedFromScratch = true;
            reformatFileBytes();
            
            if (chipNames == null)
                initGameDefDictionaries();
        }
        
        /// <summary>Converts fileBytes for a SharkPort-format save (.sps/xps) to raw SRAM format.</summary>
        /// <return>The internal cart name, which can be used to determine game, version, and language.</return>
        string processSharkPortSave()
        {
            try
            {
                int position = 0;
                throwFileExceptions = true;
                
                uint headerStringLength = readUInt(position);
                position += 4;
                string headerString = readASCIIString(position, (int)headerStringLength); // SharkPortSave
                if (!headerString.Equals("SharkPortSave"))
                    throw new Exception();
                position += (int)headerStringLength;
                
                position += 4; // 00 00 0F 00
                
                uint gameNameLength = readUInt(position);
                position += 4;
                string gameName = readASCIIString(position, (int)gameNameLength);
                position += (int)gameNameLength;
                
                uint saveNameLength = readUInt(position);
                position += 4;
                string saveName = readASCIIString(position, (int)saveNameLength);
                position += (int)saveNameLength;
                
                uint descriptionLength = readUInt(position);
                position += 4;
                string description = readASCIIString(position, (int)descriptionLength);
                position += (int)descriptionLength;
                
                uint contentsLength = readUInt(position);
                position += 4;
                
                string romName = readASCIIString(position, 12);
                position += 12;
                string romID = readASCIIString(position, 4);
                position += 4;
                
                position += 2; // Usually 00 00
                
                byte cartChecksum = readByte(position);
                position++;
                byte maker = readByte(position);
                position++;
                
                position += 8; // 01 00 00 00 00 00 00 00
                
                byte[] rawSaveFileBytes = readBytes(position, (int)contentsLength - 0x1C);
                position += (int)contentsLength - 0x1C;
                
                uint checksum = readUInt(position);
                
                fileBytes = rawSaveFileBytes;
                throwFileExceptions = false;
                return romName;
            }
            catch
            {
                Console.WriteLine("Failed to read SharkPort format save.");
                throw new Exception();
            }
        }
        
        /// <summary>Converts fileBytes for a GameShark SP-format save (.gsv) to raw SRAM format.</summary>
        /// <return>The internal cart name, which can be used to determine game, version, and language.</return>
        string processGameSharkSPSave()
        {
            try
            {
                int position = 0;
                throwFileExceptions = true;
                
                string headerString = readASCIIString(position, 8); // ADVSAVEG
                if (!headerString.Equals("ADVSAVEG"))
                    throw new Exception();
                position += 8;
                
                uint checksum = readUInt(position);
                position += 4;
                
                string romName = readASCIIString(position, 12);
                position += 12;
                
                uint padding = readUInt(position);
                position += 4;
                uint type = readUInt(position);
                position += 4;
                uint unknown1 = readUInt(position);
                position += 4;
                uint contentsLength = readUInt(position);
                position += 4;
                uint unknown2 = readUInt(position);
                position += 4;
                
                string description = readASCIIString(position, 0x400);
                position += 0x400;
                
                position += 4; // Footer (78 56 34 12)
                
                byte[] rawSaveFileBytes = readBytes(position, (int)contentsLength);
                
                fileBytes = rawSaveFileBytes;
                throwFileExceptions = false;
                return romName;
            }
            catch
            {
                Console.WriteLine("Failed to read GameShark SP format save.");
                throw new Exception();
            }
        }
        
        /// <summary>Packages standard save bytes into SharkPort format for export.</summary>
        /// <param name="contentBytes">The main content bytes. Unlike fileBytes, these already have XOR encoding applied if necessary.</param>
        /// <returns>The bytes for a SharkPort-format save.</returns>
        byte[] getBytesForSharkPort(byte[] contentBytes)
        {
            List<byte> formatBytes = new List<byte>();
            object[] cartInfo = getCartInfo();
            
            writeUIntToBytes(formatBytes, 0x0D);
            writeASCIIStringToBytes(formatBytes, "SharkPortSave");
            
            writeUIntToBytes(formatBytes, 0x000F0000);
            
            string gameName = cartInfo[0] as string;
            writeUIntToBytes(formatBytes, (uint)gameName.Length);
            writeASCIIStringToBytes(formatBytes, gameName);
            
            string saveName = DateTime.Now.ToString("M/d/yyyy h:m:s tt");
            writeUIntToBytes(formatBytes, (uint)saveName.Length);
            writeASCIIStringToBytes(formatBytes, saveName);
            
            writeUIntToBytes(formatBytes, 0); // No description
            
            writeUIntToBytes(formatBytes, (uint)(contentBytes.Length + 0x1C));
           
            int checksumAreaStart = formatBytes.Count; // Checksum is calculated from all bytes between here and end
            
            writeASCIIStringToBytes(formatBytes, gameName);
            for (int i = gameName.Length; i < 12; i++) // Pad length out to 12 bytes
                formatBytes.Add(0x00);
            string cartID = cartInfo[1] as string;
            writeASCIIStringToBytes(formatBytes, cartID);
            for (int i = cartID.Length; i < 4; i++) // Pad length out to 4 bytes (shouldn't be necessary, but just in case)
                formatBytes.Add(0x00);
            
            formatBytes.Add(0x00);
            formatBytes.Add(0x00);
            
            byte cartChecksum = (byte)cartInfo[2];
            formatBytes.Add(cartChecksum);
            byte maker = (byte)cartInfo[3];
            formatBytes.Add(maker);
            
            writeUIntToBytes(formatBytes, 1);
            writeUIntToBytes(formatBytes, 0);
            
            formatBytes.AddRange(contentBytes);
            
            UInt32 checksum = 0;
            for (int checksumIndex = checksumAreaStart; checksumIndex < formatBytes.Count; checksumIndex++)
            {
                byte shiftAmount = (byte)(checksum % 24);
                checksum += (UInt32)(formatBytes[checksumIndex] << shiftAmount);
            }
            
            writeUIntToBytes(formatBytes, checksum);
            
            return formatBytes.ToArray();
        }
        
        /// <summary>Packages standard save bytes into GameShark SP format for export.</summary>
        /// <param name="contentBytes">The main content bytes. Unlike fileBytes, these already have XOR encoding applied if necessary.</param>
        /// <returns>The bytes for a GameShark SP-format save.</returns>
        byte[] getBytesForGameSharkSP(byte[] contentBytes)
        {
            List<byte> formatBytes = new List<byte>();
            object[] cartInfo = getCartInfo();
            
            writeASCIIStringToBytes(formatBytes, "ADVSAVEG");
            
            writeUIntToBytes(formatBytes, 0xFFFF); // Unknown 2-byte checksum, use FFs as placeholder
            
            string gameName = cartInfo[0] as string;
            writeASCIIStringToBytes(formatBytes, gameName);
            for (int i = gameName.Length; i < 12; i++) // Pad length out to 12 bytes
                formatBytes.Add(0x00);
            
            writeUIntToBytes(formatBytes, 0); // Padding
            writeUIntToBytes(formatBytes, 2); // Type
            writeUIntToBytes(formatBytes, 0xFFFF); // Another unknown 2-byte checksum, use FFs as placeholder
            writeUIntToBytes(formatBytes, (uint)contentBytes.Length);
            writeUIntToBytes(formatBytes, 0); // Unknown
            
            for (int i = 0; i < 0x400; i++)
                formatBytes.Add(0x00); // Blank description
            
            writeUIntToBytes(formatBytes, 0x12345678);
            
            formatBytes.AddRange(contentBytes);
            
            return formatBytes.ToArray();
        }
        
        /// <summary>Gets the title, ID, checksum, and maker values for current/given game and language's cart, for use in GameShark saves.</summary>
        /// <param name="myGame">Specified game number.</param>
        /// <param name="myVersion">Specified version.</param>
        /// <param name="myLanguage">Specified language.</param>
        /// <returns>An object array with title string, ID string, checksum byte, and maker byte.</returns>
        object[] getCartInfo(int myGame = -1, char myVersion = '\0', string myLanguage = "")
        {
            if (myGame == -1)
                myGame = game;
            if (myVersion == '\0')
                myVersion = version;
            if (myLanguage == "")
                myLanguage = language;
            
            string title = "";
            string id = "";
            byte checksum = 0x00;
            byte maker = 0x30; // Seems to be the same for almost all carts
            
            switch (myGame)
            {
                case 1:
                    switch (myLanguage)
                    {
                        case "en": title = "MEGAMAN_BN"; id = "AREE"; checksum = 0xE7; break;
                        case "jp": title = "ROCKMAN_EXE"; id = "�AREJ"; checksum = 0x7B; break;
                    }
                    break;
                
                case 2:
                    switch (myLanguage)
                    {
                        case "en": title = "MEGAMAN_EXE2"; id = "AE2E"; checksum = 0x83; break;
                        case "jp": title = "ROCKMAN_EXE2"; id = "AE2J"; checksum = 0x69; break;
                        case "eu": title = "MEGAMANBN2"; id = "AM2P"; checksum = 0x24; maker = 0x34; break;
                    }
                    break;
                
                case 3:
                    switch (myVersion)
                    {
                        case 'M': // EN Blue / JP Black
                            switch (myLanguage)
                            {
                                case "en": title = "MEGA_EXE3_BL"; id = "A3XE"; checksum = 0x5D; break;
                                case "jp": title = "ROCK_EXE3_BK"; id = "A3XJ"; checksum = 0x43; break;
                            }
                            break;
                        
                        case 'S': // EN White / JP unlabeled
                            switch (myLanguage)
                            {
                                case "en": title = "MEGA_EXE3_WH"; id = "A6BE"; checksum = 0x5F; break;
                                case "jp": title = "ROCKMAN_EXE3"; id = "A6BJ"; checksum = 0x67; break;
                            }
                            break;
                    }
                    break;
                
                case 4:
                    switch (myVersion)
                    {
                        case 'M': // Red Sun
                            switch (myLanguage)
                            {
                                case "en": title = "MEGAMANBN4RS"; id = "B4WE"; checksum = 0x78; break;
                                case "jp": title = "ROCK_EXE4_RS"; id = "B4WJ"; checksum = 0x2A; break;
                            }
                            break;
                        
                        case 'S': // Blue Moon
                            switch (myLanguage)
                            {
                                case "en": title = "MEGAMANBN4BM"; id = "B4BE"; checksum = 0xA3; break;
                                case "jp": title = "ROCK_EXE4_BM"; id = "B4BJ"; checksum = 0x55; break;
                            }
                            break;
                    }
                    break;
            }
            
            return new object[] { title, id, checksum, maker };
        }
        
        /// <summary>Checks cart name against cart info to determine game, version, and language.</summary>
        /// <param name="romName">The internal cart name.</param>
        void determineGameFromCartName(string romName)
        {
            for (int gameCheck = 1; gameCheck <= 6; gameCheck++)
            {
                for (int versionCheck = 0; versionCheck < 2; versionCheck++)
                {
                    if (gameCheck < 3 && versionCheck > 0) // Only one version
                        break;
                    
                    for (int languageCheck = 0; languageCheck < 2; languageCheck++)
                    {
                        char myVersion = versionCheck == 0? 'M' : 'S';
                        string myLanguage = languageCheck == 0? "en" : "jp";
                        
                        object[] info = getCartInfo(gameCheck, myVersion, myLanguage);
                        if ((info[0] as string).Equals(romName))
                        {
                            game = gameCheck;
                            version = myVersion;
                            language = myLanguage;
                            return;
                        }
                    }
                }
            }
        }
        
        /// <summary>Initializes game-based definitions using BNDefinitions objects.</summary>
        static void initGameDefDictionaries()
        {
            chipNames = new Dictionary<int, string[]>();
            paNames = new Dictionary<int, string[]>();
            chipAliases = new Dictionary<int, Dictionary<string, string[]>>();
            chipCodes = new Dictionary<int, string[]>();
            unobtainableCodes = new Dictionary<int, Dictionary<int, byte[]>>();
            chipSizes = new Dictionary<int, int[]>();
            
            gameOrderStandardChips = new Dictionary<int, int[]>();
            gameOrderMegaChipsMain = new Dictionary<int, int[]>();
            gameOrderMegaChipsSub = new Dictionary<int, int[]>();
            gameOrderMegaChipsAll = new Dictionary<int, int[]>();
            gameOrderGigaChipsMain = new Dictionary<int, int[]>();
            gameOrderGigaChipsSub = new Dictionary<int, int[]>();
            gameOrderGigaChipsAll = new Dictionary<int, int[]>();
            gameOrderSecretChipsMain = new Dictionary<int, int[]>();
            gameOrderSecretChipsSub = new Dictionary<int, int[]>();
            gameOrderSecretChipsAll = new Dictionary<int, int[]>();
            gameOrderPAs = new Dictionary<int, int[]>();
            
            keyItemNames = new Dictionary<int, string[]>();
            upgradeItemNames = new Dictionary<int, string[]>();
            upgradeItemFlags = new Dictionary<int, int[][]>();
            subchipNames = new Dictionary<int, string[]>();
            shopInventoryAddresses = new Dictionary<int, int[][]>();
            upgradeItemIndexInKeyItems = new Dictionary<int, int>();
            subchipIndexInKeyItems = new Dictionary<int, int>();
            shopHPMemoryPrices = new Dictionary<int, Dictionary<int, int[]>>();
            shopPowerUpPrices = new Dictionary<int, Dictionary<int, int[]>>();
            shopKeyItemPrices = new Dictionary<int, Dictionary<int, int[]>>();
            libraryFlagRanges = new Dictionary<int, int[][]>();
            
            presetFolderNames = new Dictionary<int, string[]>();
            presetFolders = new Dictionary<int, Dictionary<string, string[]>>();
            
            programNames = new Dictionary<int, string[]>();
            programColors = new Dictionary<int, string[]>();
            programEffectDefs = new Dictionary<int, Dictionary<byte, object[]>>();
            
            numberTraderCodes = new Dictionary<int, string[]>();
            
            bbsNames = new Dictionary<int, string[]>();
            styleTypes = new Dictionary<int, string[]>();
            
            timeTrialNames = new Dictionary<int, string[]>();
            
            patchCardDefs = new Dictionary<int,Dictionary<byte, object[]>>();
            
            stringByteTable = new Dictionary<int, Dictionary<string, byte>>();
            byteStringTable = new Dictionary<int, Dictionary<byte, string>>();
            
            safeLocationLansRoom = new Dictionary<int, object[]>();
            startLocationForFreshSave = new Dictionary<int, object[]>();
            uninitializedJackInLocation = new Dictionary<int, object[]>();
            
            BNDefinitions[] gameDefs = new BNDefinitions[6];
            for (int g = 1; g <= gameDefs.Length; g++)
            {
                gameDefs[g - 1] = getGameDef(g);
                if (gameDefs[g - 1] == null)
                    continue;
                
                BNDefinitions def = gameDefs[g - 1];
                
                chipNames[g] = def.chipNames;
                paNames[g] = def.paNames;
                chipAliases[g] = def.chipAliases;
                chipCodes[g] = def.chipCodes;
                unobtainableCodes[g] = def.unobtainableCodes;
                chipSizes[g] = def.chipSizes;
                
                gameOrderStandardChips[g] = def.gameOrderStandardChips;
                gameOrderMegaChipsMain[g] = def.gameOrderMegaChipsMain;
                gameOrderMegaChipsSub[g] = def.gameOrderMegaChipsSub;
                gameOrderMegaChipsAll[g] = def.gameOrderMegaChipsAll;
                gameOrderGigaChipsMain[g] = def.gameOrderGigaChipsMain;
                gameOrderGigaChipsSub[g] = def.gameOrderGigaChipsSub;
                gameOrderGigaChipsAll[g] = def.gameOrderGigaChipsAll;
                gameOrderSecretChipsMain[g] = def.gameOrderSecretChipsMain;
                gameOrderSecretChipsSub[g] = def.gameOrderSecretChipsSub;
                gameOrderSecretChipsAll[g] = def.gameOrderSecretChipsAll;
                gameOrderPAs[g] = def.gameOrderPAs;
                
                keyItemNames[g] = def.keyItemNames;
                upgradeItemNames[g] = def.upgradeItemNames;
                upgradeItemFlags[g] = def.upgradeItemFlags;
                subchipNames[g] = def.subchipNames;
                shopInventoryAddresses[g] = def.shopInventoryAddresses;
                shopHPMemoryPrices[g] = def.shopHPMemoryPrices;
                shopPowerUpPrices[g] = def.shopPowerUpPrices;
                shopKeyItemPrices[g] = def.shopKeyItemPrices;
                libraryFlagRanges[g] = def.libraryFlagRanges;
                
                presetFolderNames[g] = def.presetFolderNames;
                presetFolders[g] = def.presetFolders;
                
                programNames[g] = def.programNames;
                programColors[g] = def.programColors;
                programEffectDefs[g] = def.programEffectDefs;
                
                numberTraderCodes[g] = def.numberTraderCodes;
                
                bbsNames[g] = def.bbsNames;
                styleTypes[g] = def.styleTypes;
                
                timeTrialNames[g] = def.timeTrialNames;
                
                patchCardDefs[g] = def.patchCardDefs;
                
                safeLocationLansRoom[g] = def.safeLocationLansRoom;
                startLocationForFreshSave[g] = def.startLocationForFreshSave;
                uninitializedJackInLocation[g] = def.uninitializedJackInLocation;
            }
        }
        
        /// <summary>Initializes save data for a loaded save, loading fields from file bytes.</summary>
        /// <param name="versionUncertain">Reference for whether game version could not be conclusively determined.</param>
        /// <param name="languageUncertain">Reference for whether language could not be conclusively determined.</param>
        /// <param name="skipChecksumCheck">Whether to ignore checksum, usually because it was loaded from memory bytes with no checksum or an outdated one.</param>
        /// <returns>Whether the save was loaded or created successfully.</returns>
        public bool initSaveData(ref bool versionUncertain, ref bool languageUncertain, bool skipChecksumCheck = false)
        {
            bool gameRecognized = false;
            
            // Identify game by looking for title string for GBA, or checking file length for LC.
            if ((!lc && checkString(0x3FC, "ROCKMAN EXE")) || (lc && fileBytes.Length == getGameDef(1).saveFileSizeLC))
            {
                game = 1;
                gameRecognized = true;
            }
            else if ((!lc && checkString(0x1198, "ROCKMANEXE2")) || (lc && fileBytes.Length == getGameDef(2).saveFileSizeLC))
            {
                game = 2;
                gameRecognized = true;
            }
            else if ((!lc && checkString(0x1E00, "ROCKMANEXE3")) || (lc && fileBytes.Length == getGameDef(3).saveFileSizeLC))
            {
                game = 3;
                gameRecognized = true;
            }
            else if ((!lc && checkString(0x2208, "ROCKMANEXE4", getGameDef(4))) || (lc && fileBytes.Length == getGameDef(4).saveFileSizeLC))
            {
                game = 4;
                gameRecognized = true;
            }
            
            if (!gameRecognized)
            {
                Console.WriteLine("File does not match any supported game.");
                
                // Check if all bytes are the same (usually FF), making the reason be that it's not a valid file at all.
                bool isUninitialized = true;
                for (int i = 1; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] != fileBytes[0])
                    {
                        isUninitialized = false;
                        break;
                    }
                }
                
                if (isUninitialized)
                {
                    Console.WriteLine("It seems to be an uninitialized save with no actual data.");
                    Console.WriteLine();
                }
                
                if (!isUninitialized && M.loadedFilename != "" && M.debugSaveUnXORedFileOnFailure > 0)
                {
                    fileBytes = xorBytes(fileBytes, !lc? getGameDef(M.debugSaveUnXORedFileOnFailure).saveEncryptXORAddressGBA : getGameDef(M.debugSaveUnXORedFileOnFailure).saveEncryptXORAddressLC);
                    try
                    {
                        string savxPath = M.loadedFilename.Replace(Path.GetExtension(M.loadedFilename), ".savx");
                        File.WriteAllBytes(savxPath, fileBytes);
                    }
                    catch { }
                    Console.WriteLine("Wrote decoded .savx (assuming BN" + M.debugSaveUnXORedFileOnFailure + ") for examination.");
                }
                
                return false;
            }
            
            versionUncertain = version == '\0'; // If version was already assigned using header from special save type, it's not uncertain
            languageUncertain = !lc && language == ""; // If language was already assigned using header from special save type, it's not uncertain
            language = "en"; // Default language in case it can't be determined
            
            if (game >= 4) // For BN4+, must decode save bytes
            {
                BNDefinitions def = getGameDef();
                fileBytes = xorBytes(fileBytes, !lc? def.saveEncryptXORAddressGBA : def.saveEncryptXORAddressLC);
                if (M.debugSaveUnXORedFile)
                {
                    try
                    {
                        string savxPath = M.loadedFilename.Replace(Path.GetExtension(M.loadedFilename), ".savx");
                        File.WriteAllBytes(savxPath, fileBytes);
                    }
                    catch { }
                }
            }
            
            defineFieldsForGame();
            readFieldsFromSave(true);
            
            // Determine version/language based on loaded data.
            if (game == 1)
            {
                if (languageUncertain)
                {
                    language = titleString.Contains("20010727")? "en" : "jp"; // JP has build date of 20010120 instead
                    languageUncertain = false;
                }
            }
            else if (game == 3)
            {
                if (!lc)
                {
                    version = flags[4702]? 'M' : 'S';
                    versionUncertain = false;
                }
                else
                {
                    version = titleString.StartsWith("3B")? 'M' : 'S';
                    versionUncertain = false;
                }
            }
            else if (game == 4)
            {
                if (!lc)
                {
                    // If possibleTournamentEntrants is defined, should be able to determine version based on the SoulNavis in first two slots.
                    for (int i = 0; i < 2; i++)
                    {
                        switch (possibleTournamentEntrants[i])
                        {
                            case 0x00: case 0x01: // GutsMan or FireMan
                                version = 'M';
                                versionUncertain = false;
                                break;
                            case 0x02: case 0x03: // NumberMan or AquaMan
                                version = 'S';
                                versionUncertain = false;
                                break;
                        }
                    }
                    
                    // If that didn't work, compare library flags to verification bytes using each version's XOR value.
                    if (versionUncertain)
                    {
                        byte redSunLibraryXOR = 0x64;
                        byte blueMoonLibraryXOR = 0x47;
                        for (int i = 0; i < libraryChipFlags.Length; i++)
                        {
                            if (!libraryChipFlags[i]) // Can't determine based on a flag that isn't set
                                continue;
                            
                            byte trueValueForRS = (byte)(libraryFlagVerificationSource[i] ^ redSunLibraryXOR);
                            byte trueValueForBM = (byte)(libraryFlagVerificationSource[i] ^ blueMoonLibraryXOR);
                            if (trueValueForRS == trueValueForBM) // Don't think this should happen, but if it does, obviously not conclusive
                                continue;
                            
                            if (libraryFlagVerificationBytes[i] == trueValueForRS)
                            {
                                version = 'M';
                                versionUncertain = false;
                                break;
                            }
                            else if (libraryFlagVerificationBytes[i] == trueValueForBM)
                            {
                                version = 'S';
                                versionUncertain = false;
                                break;
                            }
                        }
                    }
                    
                    if (versionUncertain) // Still couldn't determine version, so assume Red Sun at first then silently switch based on checksum
                        version = 'M';
                }
                else
                {
                    version = titleString.StartsWith("4R")? 'M' : 'S';
                    versionUncertain = false;
                }
            }
            
            // If language is still uncertain, try to determine from strings if applicable for game.
            if (languageUncertain)
                languageUncertain = !determineLanguageFromStrings();
            
            if (!onlyLoadingSteamID)
            {
                if (M.loadedFilename != "")
                    Console.WriteLine(Path.GetFileName(M.loadedFilename) + " loaded.");
                else
                    Console.WriteLine("Loaded bytes from clipboard.");
                
                if (game < 4) // For BN4+, don't write what it was initially detected as until after checksum check
                {
                    string langStr = language == "en"? "English" : "Japanese";
                    Console.WriteLine("Save detected as Battle Network " + game + (game >= 3 && version != '\0'? " " + getVersionName(version) : "") + (lc? " LC" : " " + langStr) + ".");
                    Console.WriteLine();
                }
            }
            
            // Confirm checksum (though don't strictly require it to be correct).
            DataField checksumField = getFieldDefByName("saveChecksum");
            DataField steamIDField = getFieldDefByName("steamID");
            if (!skipChecksumCheck && checksumField != null)
            {
                int myAddress = checksumField.getAddress(lc);
                uint calculated = calculateSaveChecksum(myAddress, steamIDField.getAddress(true));
                uint original = readUInt(myAddress);
                
                if (calculated != original)
                {
                    int myOffset = getChecksumOffsetForVersion(version, lc);
                    uint calcuatedMinusOffset = (uint)(calculated - myOffset);
                    
                    char otherVersion = version == 'M'? 'S' : 'M';
                    int otherVersionOffset = getChecksumOffsetForVersion(otherVersion, lc);
                    
                    bool versionDiffMatch = (original == calcuatedMinusOffset + otherVersionOffset);
                    
                    if (!versionDiffMatch || game < 4 || lc) // Don't print this if version can be swapped to correct one for BN4+ (but always do for BN1-3 and LC)
                    {
                        if (game >= 4) // Can now write detected save info for BN4+
                        {
                            Console.WriteLine("Save detected as Battle Network " + game + (lc? " LC" : "") + ", but version not certain.");
                            Console.WriteLine();
                        }
                        ConsoleC.WriteLineHL("{WARNING:} Calculated checksum does not match!", "red");
                        Console.WriteLine("Calculated checksum: " + calculated);
                        Console.WriteLine("Checksum in save: " + original);
                        Console.WriteLine();
                    }
                    
                    if (game >= 3 && !lc && versionDiffMatch) // Checksum would match for a different version than initial assumption
                    {
                        if (game >= 4) // For games where there's no other clear indicator, silently switch to version that fits checksum
                        {
                            version = otherVersion;
                            versionUncertain = false;
                            
                            string langStr = language == "en"? "English" : "Japanese";
                            Console.WriteLine("Save detected as Battle Network " + game + (game >= 3 && version != '\0'? " " + getVersionName(version) : "") + (lc? " LC" : " " + langStr) + ".");
                        }
                        else // If there is another indicator that proved wrong, prompt to switch
                        {
                            bool checksumSaysMain = original > calculated;
                            string main = getVersionName('M');
                            string sub = getVersionName('S');
                            
                            Console.WriteLine("This checksum difference indicates a possible game version mix-up.");
                            Console.WriteLine("For GBA BN" + game + " saves, the game version is most easily identifiable by a flag.");
                            Console.WriteLine("However, the two versions also calculate their checksums differently.");
                            Console.WriteLine("So while the version flag indicates " + (checksumSaysMain? sub : main) + ", it may be a " + (checksumSaysMain? main : sub) + " save.");
                            Console.WriteLine();
                            
                            Console.WriteLine("Switch version flag to " + (checksumSaysMain? main : sub) + "? (Y/N)");
                            string switchPrompt = M.getTypedInput().ToUpper();
                            if (switchPrompt == "Y")
                            {
                                updateGameVersion(checksumSaysMain? 'M' : 'S');
                                Console.WriteLine("Version flag switched to " + (checksumSaysMain? main : sub) + ".");
                                versionUncertain = false;
                            }
                        }
                    }
                    else // Checksum is just wrong with no clear explanation
                    {
                        Console.WriteLine("Either save is invalid and won't load in-game, or calculations are incorrect.");
                        Console.WriteLine("This program will load it regardless, and redo checksum upon saving.");
                        Console.WriteLine("(Version assumed to be " + getVersionName(version) + (!lc? " " + (language == "en"? "English" : "Japanese") : "") + ".)");
                    }
                    Console.WriteLine();
                }
                else if (game >= 4) // Checksum matched with initial assumption, can now print it
                {
                    versionUncertain = false;
                    string langStr = language == "en"? "English" : "Japanese";
                    Console.WriteLine("Save detected as Battle Network " + game + (game >= 3 && version != '\0'? " " + getVersionName(version) : "") + (lc? " LC" : " " + langStr) + ".");
                    Console.WriteLine();
                }
            }
            
            // Read fields that depend on version/language after determining.
            readFieldsFromSave(onlyVersionDependent: true);
            
            if (M.userSettings["SteamID"] != 0) // If defined in user settings, automatically use provided Steam ID
                steamID = (uint)M.userSettings["SteamID"];
            
            listAddressesDebug();
            
            return true;
        }
        
        /// <summary>Initializes save data from scratch for a fresh save, initializing fields to game-start values.</summary>
        public void initFreshSaveData()
        {
            defineFieldsForGame();
            
            if (game >= 4 && M.debugForcedFieldValues != null) // Before initializing fields, set forced values (which may be referenced for initialization)
            {
                foreach (string fieldName in M.debugForcedFieldValues.Keys)
                {
                    if (fieldName.Contains("|")) // Includes type override (with default being uint)
                    {
                        string[] split = fieldName.Split('|');
                        string type = split[0];
                        string realFieldName = split[1];
                        if (type.Equals("ushort"))
                            this.GetType().GetField(realFieldName).SetValue(this, (ushort)M.debugForcedFieldValues[fieldName]);
                        else
                            this.GetType().GetField(realFieldName).SetValue(this, M.debugForcedFieldValues[fieldName]);
                    }
                    else
                        this.GetType().GetField(fieldName).SetValue(this, M.debugForcedFieldValues[fieldName]);
                }
            }
            
            initFieldsForFreshSave();
            listAddressesDebug();
            
            if (M.userSettings["SteamID"] != 0) // If defined in user settings, automatically use provided Steam ID
                steamID = (uint)M.userSettings["SteamID"];
        }
        
        /// <summary>Attempt to determine language based on table string fields having bytes that are valid for one language but not the other.</summary>
        /// <returns>Whether the language could be determined.</returns>
        bool determineLanguageFromStrings()
        {
            if (game < 4)
                return false;
            
            foreach (DataField field in fields)
            {
                if (field.dataType < T_TABLESTRING || field.dataType > T_1BYTETABLESTRINGS)
                    continue;
                
                string fieldName = field.fieldName;
                int address = field.getAddress(lc);
                int param = field.param;
                int param2 = field.param2;
                
                string subset = fieldName.Equals("playerName") || fieldName.Equals("waitingRoomNames")? "playerName"
                              : fieldName.Equals("naviRecordHolderNames")? "naviRecordHolderNames" : "";
                
                if (address == -1) // Undefined or unused in version
                    continue;
                
                if (field.dataType == T_TABLESTRING || field.dataType == T_1BYTETABLESTRING)
                {
                    string enResult = readTableString(address, param, myLanguage: "en", subset: subset, blankIfInvalid: true, oneByteMode: field.dataType == T_1BYTETABLESTRING);
                    string jpResult = readTableString(address, param, myLanguage: "jp", subset: subset, blankIfInvalid: true, oneByteMode: field.dataType == T_1BYTETABLESTRING);
                    
                    if (enResult != "" && jpResult == "")
                    {
                        language = "en";
                        return true;
                    }
                    else if (jpResult != "" && enResult == "")
                    {
                        language = "jp";
                        return true;
                    }
                }
                else if (field.dataType == T_TABLESTRINGS || field.dataType == T_1BYTETABLESTRINGS)
                {
                    string[] enResults = readTableStrings(address, param, param2, "en", subset, true, field.dataType == T_1BYTETABLESTRINGS);
                    string[] jpResults = readTableStrings(address, param, param2, "jp", subset, true, field.dataType == T_1BYTETABLESTRINGS);
                    
                    for (int i = 0; i < enResults.Length && i < jpResults.Length; i++)
                    {
                        if (enResults[i] != "" && jpResults[i] == "")
                        {
                            language = "en";
                            return true;
                        }
                        else if (jpResults[i] != "" && enResults[i] == "")
                        {
                            language = "jp";
                            return true;
                        }
                    }
                }
            }
            
            // Note that I could check strings within e-Reader data as well, but the above seems reliable enough for this to not be necessary.
            
            return false;
        }
        
        /* DATA FIELDS */
        
        /// <summary>Defines all data fields for the current game.</summary>
        void defineFieldsForGame()
        {
            fields = new List<DataField>();
            
            if (game == 1)
            {
                defineField("flags", T_FLAGS, 0x0, 0x1060, 0x8C); // Includes library chip flags within, so edits to one must be mirrored to other
                defineField("libraryChipFlags", T_FLAGS, 0x20, 0x1080, 0x19);
                
                defineField("shopInventories", T_SHOPINVENTORIES, 0x90, 0x10F0, 8, 18); // Note: Actually uses defined addresses for scattered (in GBA) shops (though LC moves them together)
                
                defineField("folderSlot1", T_FOLDERCHIPS, 0x1C0, 0x120);
                
                defineField("emailCount", T_UINT, 0x200, 0x2210);
                
                defineField("currentMode", T_BYTE, 0x210, 0x0);
                defineField("area", T_BYTE, 0x214, 0x4, gbaAddress2: 0x21C, lcAddress2: 0xC);
                defineField("subarea", T_BYTE, 0x215, 0x5, gbaAddress2: 0x21D, lcAddress2: 0xD);
                defineField("chapter", T_BYTE, 0x216, 0x6);
                
                defineField("attackUpgrades", T_BYTE, 0x224, 0x14);
                defineField("rapidUpgrades", T_BYTE, 0x225, 0x15);
                defineField("chargeUpgrades", T_BYTE, 0x226, 0x16);
                defineField("activeArmor", T_BYTE, 0x227, 0x17);
                defineField("currentMusic", T_BYTE, 0x228, 0x18);
                defineField("currentHP", T_USHORT, 0x22C, 0x1C);
                defineField("maxHP", T_USHORT, 0x22E, 0x1E);
                defineField("playerX", T_SHORT, 0x24A, 0x3A);
                defineField("playerY", T_SHORT, 0x24E, 0x3E);
                defineField("playerZ", T_SHORT, 0x252, 0x42);
                defineField("playerFacingDir", T_BYTE, 0x254, 0x44);
                defineField("jackInX", T_SHORT, 0x25A, 0x4A);
                defineField("jackInY", T_SHORT, 0x25E, 0x4E);
                defineField("jackInZ", T_SHORT, 0x262, 0x52);
                defineField("jackInFacingDir", T_BYTE, 0x264, 0x54);
                defineField("jackInArea", T_BYTE, 0x268, 0x58);
                defineField("jackInSubarea", T_BYTE, 0x269, 0x59);
                defineField("zenny", T_UINT, 0x284, 0x74);
                
                defineField("unknownBN1Pointers1", T_UINTS, 0x290, -1, 16); // LC unknown but probably not important
                
                defineField("keyItemQuantities", T_BYTES, 0x2D0, 0xC0, 0x48);
                defineField("upgradeItemQuantities", T_BYTES, 0x310, 0x100, 2);
                
                defineField("powerPlantBattery", T_BYTE, 0x3D5, 0x85);
                defineField("stepsShort", T_USHORT, 0x3E0, 0x90);
                defineField("multiplayerBattleRecord", T_USHORT, 0x3E4, 0x94);
                defineField("multiplayerWinRecord", T_USHORT, 0x3E6, 0x96);
                defineField("playTime", T_UINT, 0x3E8, 0x98);
                defineField("timeInBattles", T_UINT, 0x3EC, 0x9C);
                defineField("saveChecksum", T_SAVECHECKSUM, 0x3F0, 0xA0);
                defineField("stepsWithoutEncounter", T_INT, 0x3F4, 0xA4);
                
                defineField("titleString", T_ASCIISTRING, 0x3FC, -1, 0x14); // GBA only
                
                defineField("pack", T_PACKCHIPSETS, 0x4A0, 0x160, 240);
                
                defineField("npcData", T_NPCS, 0x13A0, 0x1540, 16);
                
                defineField("emailList", T_BYTES, 0x1FA0, 0x21D0, 0x40);
                
                defineField("unknownBN1Pointers2", T_UINTS, 0x2110, -1, 16); // LC unknown but probably not important
                
                defineField("nextPackSlotValue", T_USHORT, 0x2150, 0x22CC, 0xFF); // In LC, this exceeds file length, so only lower byte is written; pass param to indicate this
                
                defineField("steamID", T_UINT, -1, 0xBC); // LC only
            }
            else if (game == 2)
            {
                defineField("flags", T_FLAGS, 0x0, 0x1630, 0x1A0); // Includes library chip/PA flags within, so edits to one must be mirrored to other
                defineField("libraryChipFlags", T_FLAGS, 0x60, 0x1690, 0x22);
                defineField("libraryPAFlags", T_FLAGS, 0x9C, 0x16CC, 0x04);
                
                defineField("bbsPostCounts", T_INTS, 0xA90, 0x26F0, 8);
                
                defineField("folderSlot1", T_FOLDERCHIPS, 0xAB0, 0x1B0);
                defineField("folderSlot2", T_FOLDERCHIPS, 0xB28, 0x228);
                defineField("folderSlot3", T_FOLDERCHIPS, 0xBA0, 0x2A0);
                
                defineField("emailCount", T_UINT, 0xC1C, 0x24E0);
                
                defineField("currentMode", T_BYTE, 0xDC0, 0x0);
                defineField("activeStyle", T_BYTE, 0xDC1, 0x1);
                defineField("equippedFolder", T_BYTE, 0xDC2, 0x2);
                
                defineField("area", T_BYTE, 0xDC4, 0x4, gbaAddress2: 0xDCC, lcAddress2: 0xC);
                defineField("subarea", T_BYTE, 0xDC5, 0x5, gbaAddress2: 0xDCD, lcAddress2: 0xD);
                defineField("chapter", T_BYTE, 0xDC6, 0x6);
                
                defineField("regularMemory", T_BYTE, 0xDD7, 0x17);
                defineField("currentMusic", T_BYTE, 0xDD8, 0x18);
                defineField("equippedFolderRegularChip", T_BYTE, 0xDDC, 0x1C);
                defineField("folderSlot1RegularChip", T_BYTE, 0xDDD, 0x1D);
                defineField("folderSlot2RegularChip", T_BYTE, 0xDDE, 0x1E);
                defineField("folderSlot3RegularChip", T_BYTE, 0xDDF, 0x1F);
                defineField("currentHP", T_USHORT, 0x1130, 0x8C, gbaAddress2: 0xDE0, lcAddress2: 0x20); // Address 1 is "base" HP, address 2 is "effective" HP
                defineField("maxHP", T_USHORT, 0x1132, 0x8E, gbaAddress2: 0xDE2, lcAddress2: 0x22); // Address 1 is "base" HP, address 2 is "effective" HP
                defineField("battlesSinceStyleChangeInt", T_UINT, 0xDE4, 0x24);
                defineField("playerX", T_SHORT, 0xDFA, 0x3A);
                defineField("playerY", T_SHORT, 0xDFE, 0x3E);
                defineField("playerZ", T_SHORT, 0xE02, 0x42);
                defineField("playerFacingDir", T_BYTE, 0xE04, 0x44);
                defineField("jackInX", T_SHORT, 0xE0A, 0x4A);
                defineField("jackInY", T_SHORT, 0xE0E, 0x4E);
                defineField("jackInZ", T_SHORT, 0xE12, 0x52);
                defineField("jackInFacingDir", T_BYTE, 0xE14, 0x54);
                defineField("jackInArea", T_BYTE, 0xE18, 0x58);
                defineField("jackInSubarea", T_BYTE, 0xE19, 0x59);
                defineField("zenny", T_UINT, 0xE34, 0x74);
                
                defineField("keyItemQuantities", T_BYTES, 0xE80, 0x110, 0x60);
                defineField("upgradeItemQuantities", T_BYTES, 0xEE0, 0x170, 6);
                defineField("subchipQuantities", T_BYTES, 0xEF0, 0x180, 6);
                
                defineField("registeredStyles", T_BYTES, 0xF00, 0x190, 0x1A);
                
                defineField("bbsPostLists", T_BYTES, 0xF20, 0x24F0, 0x200);
                
                defineField("folderCount", T_BYTE, 0x1126, 0x82);
                defineField("attackUpgrades", T_BYTE, 0x1128, 0x84);
                defineField("rapidUpgrades", T_BYTE, 0x1129, 0x85);
                defineField("chargeUpgrades", T_BYTE, 0x112A, 0x86);
                
                defineField("stepsShort", T_USHORT, 0x113C, 0x98);
                defineField("multiplayerBattleRecord", T_USHORT, 0x1140, 0x9C);
                defineField("multiplayerWinRecord", T_USHORT, 0x1142, 0x9E);
                defineField("playTime", T_UINT, 0x1144, 0xA0);
                defineField("timeInBattles", T_UINT, 0x1148, 0xA4);
                defineField("saveChecksum", T_SAVECHECKSUM, 0x114C, 0xA8);
                defineField("stepsWithoutEncounter", T_INT, 0x1150, 0xAC);
                defineField("locEnemyStepsRemaining", T_INT, 0x117C, 0xD8);
                defineField("locEnemyEncounterPointer", T_ENCOUNTERPOINTER, 0x1180, 0xDC);
                
                defineField("titleString", T_ASCIISTRING, 0x1198, -1, 0x14); // GBA only
                
                defineField("pack", T_PACKCHIPSETS, 0x11B0, 0x318, 271);
                
                defineField("shopInventories", T_SHOPINVENTORIES, 0x24C0, 0x2740, 23, 8);
                
                defineField("npcData", T_NPCS, 0x2D80, 0x17D0, 16);
                
                defineField("emailList", T_BYTES, 0x3980, 0x2460, 0x80);
                
                defineField("nextPackSlotValue", T_USHORT, 0x3A40, 0x2710);
                
                defineField("styleProgressInts", T_UINTS, 0x3A68, 0x3A60, 4);
                
                defineField("steamID", T_UINT, -1, 0x104); // LC only
            }
            else if (game == 3)
            {
                defineField("virusFoodDistribution", T_BYTES, 0x0, 0x52B8, 0x28);
                
                defineField("flags", T_FLAGS, 0x30, 0x1A80, 0x2E0);
                defineField("programCompressedFlags", T_FLAGS, 0x310, 0x1D60, 0x20);
                defineField("libraryChipFlags", T_FLAGS, 0x330, 0x1D80, 0x28);
                defineField("libraryPAFlags", T_FLAGS, 0x358, 0x1DA8, 0x18);
                defineField("librarySharedChipFlags", T_FLAGS, 0x370, 0x1DC0, 0x28);
                defineField("librarySharedPAFlags", T_FLAGS, 0x398, 0x1DE8, 0x18);
                defineField("numberTraderFlags", T_FLAGS, 0x430, 0x1E80, 0x8);
                defineField("errorCodesSavedBytes", T_BYTES, 0x440, 0x4E30, 0x20);
                
                defineField("styleProgressBytes", T_BYTES, 0xE60, 0x4D30, 8);
                
                defineField("timeTrialRecords", T_UINTS, 0x1280, 0x5740, 30);
                
                defineField("spriteScaleX", T_BYTE, 0x12F8, 0x4D38);
                defineField("spriteScaleY", T_BYTE, 0x12F9, 0x4D39);
                
                defineField("placedPrograms", T_PLACEDPROGRAMS, 0x1300, 0x4D40, 25);
                
                defineField("bbsPostCounts", T_INTS, 0x13D0, 0x3360, 8);
                
                defineField("folderSlot1", T_FOLDERCHIPS, 0x1410, 0x290);
                defineField("folderSlot2", T_FOLDERCHIPS, 0x1488, 0x308); // Extra Folder
                defineField("folderSlot3", T_FOLDERCHIPS, 0x1500, 0x380); // Folder 2
                
                defineField("npcFlags", T_FLAGS, 0x157A, 0x2AD2, 2, 1);
                defineField("emailCount", T_UINT, 0x157C, 0x3150);
                
                defineField("currentMode", T_BYTE, 0x1880, 0x0);
                defineField("activeStyle", T_BYTE, 0x1881, 0x1);
                defineField("equippedFolder", T_BYTE, 0x1882, 0x2);
                
                defineField("area", T_BYTE, 0x1884, 0x4, gbaAddress2: 0x188C, lcAddress2: 0xC);
                defineField("subarea", T_BYTE, 0x1885, 0x5, gbaAddress2: 0x188D, lcAddress2: 0xD);
                defineField("chapter", T_BYTE, 0x1886, 0x6);
                
                defineField("registeredStyle", T_BYTE, 0x1894, 0x14);
                defineField("styleLevel", T_BYTE, 0x1895, 0x15);
                defineField("styleAdvancementMode", T_BYTE, 0x1896, 0x16);
                defineField("regularMemory", T_BYTE, 0x1897, 0x17);
                defineField("currentMusic", T_BYTE, 0x1898, 0x18);
                defineField("equippedFolderRegularChip", T_BYTE, 0x189C, 0x1C);
                defineField("folderSlot1RegularChip", T_BYTE, 0x189D, 0x1D);
                defineField("folderSlot2RegularChip", T_BYTE, 0x189E, 0x1E);
                defineField("folderSlot3RegularChip", T_BYTE, 0x189F, 0x1F);
                defineField("currentHP", T_USHORT, 0x18A0, 0x20, gbaAddress2: 0x1DC4, lcAddress2: 0x94);
                defineField("maxHP", T_USHORT, 0x18A2, 0x22);
                defineField("playerX", T_SHORT, 0x18BA, 0x3A);
                defineField("playerY", T_SHORT, 0x18BE, 0x3E);
                defineField("playerZ", T_SHORT, 0x18C2, 0x42);
                defineField("playerFacingDir", T_BYTE, 0x18C4, 0x44);
                defineField("jackInX", T_SHORT, 0x18CA, 0x4A);
                defineField("jackInY", T_SHORT, 0x18CE, 0x4E);
                defineField("jackInZ", T_SHORT, 0x18D2, 0x52);
                defineField("jackInFacingDir", T_BYTE, 0x18D4, 0x54);
                defineField("jackInArea", T_BYTE, 0x18D8, 0x58);
                defineField("jackInSubarea", T_BYTE, 0x18D9, 0x59);
                defineField("zenny", T_UINT, 0x18F4, 0x74);
                defineField("bugFrags", T_UINT, 0x18F8, 0x78);
                
                defineField("libraryChecksum", T_LIBRARYCHECKSUM, 0x19B0, 0x5430);
                
                defineField("keyItemQuantities", T_BYTES, 0x19C0, 0xF0, 0x60);
                defineField("upgradeItemQuantities", T_BYTES, 0x1A20, 0x150, 6);
                defineField("subchipQuantities", T_BYTES, 0x1A30, 0x160, 6);
                defineField("programQuantities", T_BYTES, 0x1A80, 0x1B0, 0xCC);
                
                defineField("bbsPostLists", T_BYTES, 0x1B70, 0x3160, 0x200);
                
                defineField("programNumOnGridSquare", T_BYTES, 0x1D90, 0x4E10, 25);
                
                defineField("folderCount", T_BYTE, 0x1DB6, 0x86);
                defineField("extraFolderID", T_BYTE, 0x1DC1, 0x91);
                defineField("mysteryLibraryCheckByte", T_BYTE, 0x1DC3, 0x93); // Seems to be 00 instead of FF in LC for some reason?
                defineField("battlesSinceStyleChangeShort", T_USHORT, 0x1DCA, 0x9A);
                defineField("multiplayerBattleRecord", T_USHORT, 0x1DCC, 0x9C);
                defineField("multiplayerWinRecord", T_USHORT, 0x1DCE, 0x9E);
                defineField("playTime", T_UINT, 0x1DD0, 0xA0);
                defineField("timeInBattles", T_UINT, 0x1DD4, 0xA4);
                defineField("saveChecksum", T_SAVECHECKSUM, 0x1DD8, 0xA8);
                defineField("stepsWithoutEncounter", T_INT, 0x1DDC, 0xAC);
                defineField("sneakRunStepsRemaining", T_INT, 0x1DEC, 0xBC);
                defineField("locEnemyStepsRemaining", T_INT, 0x1DF0, 0xC0);
                defineField("locEnemyEncounterPointer", T_ENCOUNTERPOINTER, 0x1DF4, 0xC4);
                defineField("countdownTimer", T_UINT, 0x1DF8, 0xC8);
                defineField("titleString", T_ASCIISTRING, 0x1E00, 0xD0, !lc? 0x14 : 0x2); // Different length for GBA/LC
                
                defineField("pack", T_PACKCHIPSETS, 0x1F60, 0x400, 320);
                
                defineField("shopInventories", T_SHOPINVENTORIES, 0x35E0, 0x33B0, 22, 8);
                defineField("chipOrderInventory", T_SHOPINVENTORY, 0x3B60, 0x3930, 320);
                
                defineField("npcData", T_NPCS, 0x4560, 0x1E90, 16);
                
                defineField("emailList", T_BYTES, 0x51A0, 0x3110, 0x40);
                
                defineField("nextPackSlotValue", T_USHORT, 0x5760, 0x33A0);
                
                defineField("programEffects", T_PROGRAMEFFECTS, 0x5770, 0x4E60, 0x2F);
                
                defineField("steamID", T_UINT, -1, 0xE0); // LC only
            }
            else if (game == 4)
            {
                defineField("zennyVerificationBase", T_UINT, 0x180, 0x1750);
                
                defineField("programColorsList", T_BYTES, 0x190, 0x3300, 25); // If LC address is correct, oddly seems like it might just write all 00s instead of a list?
                
                defineField("naviRecordHolderNames", T_1BYTETABLESTRINGS, 0x1E0, 0x1C30, 0x4, 22);
                
                defineField("itemVerificationSource", T_BYTES, 0x240, 0x11C0, 0x190);
                defineField("patchCardVerificationSource", T_BYTES, 0x3D0, 0x1760, 0x100);
                
                defineField("eReaderDataDuoDesc", T_BYTES, 0x520, 0x2F90, 0x20);
                defineField("eReaderDataPrixPowrDesc", T_BYTES, 0x57C, 0x2FEC, 0x20);
                
                defineField("libraryFlagVerificationSource", T_BYTES, 0x670, 0x1350, 0x200);
                
                defineField("spriteScaleX", T_BYTE, 0x890, 0xD84);
                defineField("spriteScaleY", T_BYTE, 0x891, 0xD85);
                
                defineField("eReaderDataDuoGraphics", T_BYTES, 0x8A0, 0x23D0, 0x5E0);
                defineField("eReaderDataPrixPowrGraphics", T_BYTES, 0xE80, 0x29B0, 0x5E0);
                
                defineField("tournamentBoards", T_TOURNAMENTBOARDS, 0x1460, 0xDA0, 4, 8);
                
                defineField("waitingRoomDataB", T_BYTES, 0x14F0, 0xE60, 0xE);
                
                defineField("bbsPostCounts", T_INTS, 0x1500, 0x1130, 8);
                
                defineField("memoryOffsetValue", T_USHORT, 0x1550, 0x3320);
                defineField("saveEncryptionXOR", T_UINT, 0x1554, 0x3324);
                
                defineField("emailCount", T_UINT, 0x1600, 0xF20);
                
                defineField("bestNaviRecords", T_USHORTS, 0x1610, 0x1970, 20);
                
                defineField("eReaderDataDuoName", T_BYTES, 0x1770, 0x3050, 0x10);
                defineField("eReaderDataPrixPowrName", T_BYTES, 0x1780, 0x3060, 0x10);
                
                defineField("bbsPostLists", T_BYTES, 0x17A0, 0xF30, 0x200);
                
                defineField("librarySharedVerificationSource", T_BYTES, 0x19A0, 0x1550, 0x200);
                
                defineField("karmaVerificationBase", T_UINT, 0x1BA0, 0x1860);
                defineField("bugFragsVerificationBase", T_UINT, 0x1E94, 0x1754);
                defineField("tournamentRandomSeed", T_UINT, 0x1E98, 0xE2C);
                
                defineField("folderSlot1ID", T_BYTE, 0x1E9C, 0xD90);
                defineField("folderSlot2ID", T_BYTE, 0x1E9D, 0xD91); // Can be either Extra Folder or Folder 2
                defineField("folderSlot3ID", T_BYTE, 0x1E9E, 0xD92); // Normally Extra Folder
                defineField("unusedFolderSlot4ID", T_BYTE, 0x1E9F, 0xD93);
                
                defineField("eReaderDataPatchCard0A", T_BYTES, 0x1EA0, 0x3070, 0x5C);
                defineField("eReaderDataPatchCard0B", T_BYTES, 0x1EFC, 0x30CC, 0x5C);
                defineField("eReaderDataPatchCard0C", T_BYTES, 0x1F58, 0x3128, 0x5C);
                defineField("eReaderDataPatchCard0D", T_BYTES, 0x1FB4, 0x3184, 0x5C);
                defineField("eReaderDataPatchCard0E", T_BYTES, 0x2010, 0x31E0, 0x5C);
                defineField("eReaderDataPatchCard0F", T_BYTES, 0x206C, 0x323C, 0x5C);
                
                // Shifted addresses begin here (notably, the entire shifted section seems to keep same arrangement in LC, so can just add +1270 from GBA)
                
                defineField("equippedFolder", T_BYTE, 0x2132, 0x33A2, shifts: true);
                
                defineField("area", T_BYTE, 0x2134, 0x33A4, gbaAddress2: 0x213C, lcAddress2: 0x33AC, shifts: true);
                defineField("subarea", T_BYTE, 0x2135, 0x33A5, gbaAddress2: 0x213D, lcAddress2: 0x33AD, shifts: true);
                defineField("chapter", T_BYTE, 0x2136, 0x33A6, shifts: true);
                
                defineField("regularMemory", T_BYTE, 0x2148, 0x33B8, shifts: true);
                defineField("currentMusic", T_BYTE, 0x2149, 0x33B9, shifts: true);
                defineField("equippedFolderRegularChip", T_BYTE, 0x214C, 0x33BC, shifts: true);
                defineField("folderSlot1RegularChip", T_BYTE, 0x214D, 0x33BD, shifts: true);
                defineField("folderSlot2RegularChip", T_BYTE, 0x214E, 0x33BE, shifts: true);
                defineField("folderSlot3RegularChip", T_BYTE, 0x214F, 0x33BF, shifts: true);
                defineField("currentHP", T_USHORT, 0x2150, 0x33C0, shifts: true);
                defineField("maxHP", T_USHORT, 0x2152, 0x33C2, shifts: true);
                defineField("playerX", T_SHORT, 0x216A, 0x33DA, shifts: true);
                defineField("playerY", T_SHORT, 0x216E, 0x33DE, shifts: true);
                defineField("playerZ", T_SHORT, 0x2172, 0x33E2, shifts: true);
                defineField("playerFacingDir", T_BYTE, 0x2174, 0x33E4, shifts: true);
                defineField("jackInX", T_SHORT, 0x217A, 0x33EA, shifts: true);
                defineField("jackInY", T_SHORT, 0x217E, 0x33EE, shifts: true);
                defineField("jackInZ", T_SHORT, 0x2182, 0x33F2, shifts: true);
                defineField("jackInFacingDir", T_BYTE, 0x2184, 0x33F4, shifts: true);
                defineField("jackInArea", T_BYTE, 0x2188, 0x33F8, shifts: true);
                defineField("jackInSubarea", T_BYTE, 0x2189, 0x33F9, shifts: true);
                defineField("zenny", T_UINT, 0x21A4, 0x3414, gbaAddress2: 0x5D04, lcAddress2: 0x6F74, shifts: true);
                defineField("bugFrags", T_UINT, 0x21A8, 0x3418, gbaAddress2: 0x5D0C, lcAddress2: 0x6F7C, shifts: true);
                
                defineField("folderCount", T_BYTE, 0x21BA, 0x342A, shifts: true);
                defineField("battlePoints", T_BYTE, 0x21BC, 0x342C, shifts: true);
                defineField("playthroughNumber", T_BYTE, 0x21C1, 0x3431, shifts: true);
                defineField("overallMaxHP", T_USHORT, 0x21C8, 0x3438, shifts: true);
                defineField("baseMaxHP", T_USHORT, 0x21CA, 0x343A, shifts: true);
                defineField("multiplayerBattleRecord", T_USHORT, 0x21D0, 0x3440, shifts: true);
                defineField("multiplayerWinRecord", T_USHORT, 0x21D2, 0x3442, shifts: true);
                defineField("multiplayerVSVersionRecord", T_SHORT, 0x21D6, 0x3446, shifts: true);
                defineField("stepsWithoutEncounter", T_INT, 0x21DA, 0x344A, shifts: true);
                defineField("playTime", T_UINT, 0x21E0, 0x3450, shifts: true);
                defineField("saveChecksum", T_SAVECHECKSUM, 0x21E8, 0x3458, shifts: true);
                defineField("sneakRunStepsRemaining", T_INT, 0x21F4, 0x3464, shifts: true);
                defineField("locEnemyStepsRemaining", T_INT, 0x21F8, 0x3468, shifts: true);
                defineField("locEnemyEncounterPointer", T_ENCOUNTERPOINTER, 0x21FC, 0x346C, shifts: true);
                
                defineField("titleString", T_ASCIISTRING, 0x2208, 0x3478, !lc? 0x14 : 0x2, shifts: true); // Different length for GBA/LC
                defineField("playerName", T_1BYTETABLESTRING, 0x2224, 0x3494, 0x3, shifts: true);
                defineField("waitingRoomNames", T_1BYTETABLESTRINGS, 0x2228, 0x3498, 0x4, 7, shifts: true);
                
                defineField("flags", T_FLAGS, 0x2248, 0x34B8, 0x2D8, shifts: true);
                defineField("libraryChipFlags", T_FLAGS, 0x2520, 0x3790, 0x28, shifts: true);
                defineField("libraryPAFlags", T_FLAGS, 0x2548, 0x37B8, 0x04, shifts: true);
                defineField("librarySharedChipFlags", T_FLAGS, 0x2560, 0x37D0, 0x2C, shifts: true);
                defineField("librarySharedPAFlags", T_FLAGS, 0x2588, 0x37F8, 0x04, shifts: true);
                defineField("numberTraderFlags", T_FLAGS, 0x2620, 0x3890, 0x8, shifts: true);
                
                defineField("folderSlot1", T_FOLDERCHIPS, 0x262C, 0x389C, shifts: true);
                defineField("folderSlot2", T_FOLDERCHIPS, 0x2668, 0x38D8, shifts: true);
                defineField("folderSlot3", T_FOLDERCHIPS, 0x26A4, 0x3914, shifts: true);
                
                defineField("pack", T_PACKCHIPSETS, 0x26E4, 0x3954, 320, shifts: true);
                
                defineField("keyItemQuantities", T_BYTES, 0x35E8, 0x4858, 0xA0, shifts: true);
                defineField("upgradeItemQuantities", T_BYTES, 0x3688, 0x48F8, 6, shifts: true);
                defineField("subchipQuantities", T_BYTES, 0x3698, 0x4908, 6, shifts: true);
                defineField("programQuantities", T_BYTES, 0x36A8, 0x4918, 0xBC, shifts: true);
                
                defineField("shopInventories", T_SHOPINVENTORIES, 0x377C, 0x49EC, 16, 8, shifts: true);
                defineField("chipOrderInventory", T_SHOPINVENTORY, 0x3B7C, 0x4DEC, 266, shifts: true);
                
                defineField("programNumOnGridSquare", T_BYTES, 0x4540, 0x57B0, 25, shifts: true);
                defineField("placedPrograms", T_PLACEDPROGRAMS, 0x4564, 0x57D4, 25, shifts: true);
                
                defineField("firstActivePatchCard", T_BYTE, 0x4644, 0x58B4, shifts: true);
                defineField("totalAddedHP", T_USHORT, 0x4648, 0x58B8, shifts: true);
                defineField("patchCardData", T_BYTES, 0x464C, 0x58BC, 14, shifts: true);
                
                defineField("mysteryDataLocationAndContents", T_BYTES, 0x465C, 0x58CC, 0x800, shifts: true);
                
                defineField("programEffects", T_PROGRAMEFFECTS, 0x4E60, 0x60D0, shifts: true);
                defineField("waitingRoomNaviProgramEffects", T_PROGRAMEFFECTSARRAY, 0x4EA0, 0x6110, 7, shifts: true);
                
                defineField("itemVerificationBytes", T_BYTES, 0x5768, 0x69D8, 0x190, shifts: true);
                defineField("libraryFlagVerificationBytes", T_BYTES, 0x58FC, 0x6B6C, 0x200, shifts: true);
                defineField("librarySharedVerificationBytes", T_BYTES, 0x5B00, 0x6D70, 0x200, shifts: true);
                defineField("patchCardVerificationBytes", T_BYTES, 0x5D14, 0x6F84, 0x100, shifts: true);
                
                defineField("karmaVerificationValue", T_UINT, 0x5E18, 0x7088, shifts: true);
                
                // Shifted addresses end here
                
                defineField("npcData", T_NPCS, 0x6140, 0x0, 16);
                
                defineField("emailList", T_BYTES, 0x6EC0, 0xEA0, 0x80);
                
                defineField("waitingRoomData", T_BYTES, 0x6F40, 0xE50, 0xE);
                
                defineField("myNaviRecords", T_USHORTS, 0x7230, 0x1AD0, 20);
                
                defineField("possibleTournamentEntrants", T_BYTES, 0x73A0, 0xE70, 0x30);
                
                defineField("nextPackSlotValue", T_USHORT, 0x73D0, 0xD8E);
                
                defineField("steamID", T_UINT, -1, 0x3488, shifts: true); // LC only
            }
        }
        
        /// <summary>Initializes values for defined fields that aren't simple initializations.</summary>
        void initFieldsForFreshSave()
        {
            bool locationSet = false;
            bool jackInSet = false;
            bool emailsSet = false;
            bool bbsPostsSet = false;
            BNDefinitions def = getGameDef();
            
            List<object[]> itemsToVerifyObtained = new List<object[]>();
            byte[] bn4UnknownNameBytes = getTableStringBytes(BN4Definitions.eReaderUnknownNameAndDesc, new byte[] { 0x02, 0x00 }, new byte[] { 0xE5 });
            
            foreach (DataField field in fields)
            {
                string fieldName = field.fieldName;
                int param = field.param;
                int param2 = field.param2;
                
                // First, check if there's a direct handling for field.
                bool handled = true; // Assume true for if any defined case is reached, but set to false if it goes to default case
                switch (fieldName)
                {
                    case "area":
                    case "subarea":
                    case "playerX":
                    case "playerY":
                    case "playerZ":
                    case "playerFacingDir":
                        if (!locationSet)
                        {
                            object[] startLocation = getDef<object[]>("startLocationForFreshSave");
                            area = Convert.ToByte(startLocation[0]);
                            subarea = Convert.ToByte(startLocation[1]);
                            playerX = Convert.ToInt16(startLocation[2]);
                            playerY = Convert.ToInt16(startLocation[3]);
                            playerZ = Convert.ToInt16(startLocation[4]);
                            playerFacingDir = Convert.ToByte(startLocation[5]);
                            locationSet = true;
                        }
                        break;
                    
                    case "jackInArea":
                    case "jackInSubarea":
                    case "jackInX":
                    case "jackInY":
                    case "jackInZ":
                    case "jackInFacingDir":
                        if (!jackInSet)
                        {
                            object[] defaultLocation = getDef<object[]>("uninitializedJackInLocation");
                            jackInArea = Convert.ToByte(defaultLocation[0]);
                            jackInSubarea = Convert.ToByte(defaultLocation[1]);
                            jackInX = Convert.ToInt16(defaultLocation[2]);
                            jackInY = Convert.ToInt16(defaultLocation[3]);
                            jackInZ = Convert.ToInt16(defaultLocation[4]);
                            jackInFacingDir = Convert.ToByte(defaultLocation[5]);
                            jackInSet = true;
                        }
                        break;
                    
                    case "flags":
                        flags = new bool[param * 8];
                        int[] startFlags = def.getGameStartFlags(version);
                        foreach (int flagNum in startFlags)
                            flags[flagNum] = true;
                        break;
                    
                    case "shopInventories":
                        shopInventories = def.getInitialShopInventories(version);
                        break;
                    
                    case "chipOrderInventory":
                        chipOrderInventory = def.getInitialChipOrderInventory(version);
                        break;
                    
                    case "bbsPostLists":
                    case "bbsPostCounts":
                        if (!bbsPostsSet)
                        {
                            bbsPostLists = def.getInitialBBSPostsList();
                            bbsPostCounts = new int[8];
                            for (int bbsIndex = 0; bbsIndex < bbsPostCounts.Length; bbsIndex++)
                            {
                                int totalPosts = 0;
                                for (int postIndex = 0; postIndex < 64; postIndex++)
                                {
                                    int truePostIndex = (bbsIndex * 0x40) + postIndex;
                                    if (truePostIndex >= bbsPostLists.Length || bbsPostLists[truePostIndex] == 0x40)
                                        break;
                                    totalPosts++;
                                }
                                bbsPostCounts[bbsIndex] = totalPosts;
                            }
                            bbsPostsSet = true;
                        }
                        break;
                    
                    case "keyItemQuantities":
                        keyItemQuantities = new byte[param];
                        keyItemQuantities[0x00] = 1; // PET
                        itemsToVerifyObtained.Add(new object[] { 0x00, "" });
                        break;
                    
                    case "upgradeItemQuantities":
                        upgradeItemQuantities = new byte[param];
                        if (game >= 2)
                            upgradeItemQuantities[0x05] = 4; // SubMem
                        // No verified flag; though SubMem starts at a non-zero quantity, its flag (at least in BN4) is not set until getting an actual upgrade
                        break;
                    
                    case "regularMemory":
                        regularMemory = (byte)(game == 3? 4 : 0);
                        break;
                    
                    case "emailList":
                        if (!emailsSet)
                        {
                            emailList = new byte[param];
                            for (int i = 0; i < emailList.Length; i++)
                                emailList[i] = (byte)(game == 1? 0x40 : 0x80);
                            
                            if (game == 1)
                            {
                                emailList[0] = 0x00;
                                emailList[1] = 0x01;
                                emailCount = 2;
                            }
                            else if (game == 4)
                            {
                                emailList[0] = 0x09;
                                emailCount = 1;
                            }
                            else
                                emailCount = 0;
                            
                            emailsSet = true;
                        }
                        break;
                    
                    case "registeredStyles":
                        registeredStyles = new byte[param];
                        registeredStyles[0] = 0x01; // NormStyl registered
                        break;
                    
                    case "timeTrialRecords":
                        timeTrialRecords = new uint[param];
                        uint[] serenadeRecords = new uint[] { 0x258, 0x708, 0x960, 0xA8C, 0x960, 0x960, 0xA8C, 0x384, 0x4B0, 0x960, 0xA8C, 0xA8C, 0x960, 0xA8C, 0xE10 };
                        for (int i = 0; i < timeTrialRecords.Length; i += 2)
                        {
                            timeTrialRecords[i] = serenadeRecords[i / 2];
                            timeTrialRecords[i + 1] = 0xEC; // Record holder = Serenade
                        }
                        break;
                    
                    case "playerName":
                        playerName = !lc? (language == "en"? "———" : "ーーー") : "---"; // 0x49 dashes in English, 0x82 dashes in Japanese, 0x40 dashes in LC
                        break;
                    
                    case "myNaviRecords":
                        myNaviRecords = new ushort[param];
                        for (int i = 0; i < myNaviRecords.Length; i++)
                            myNaviRecords[i] = 0xFFFF;
                        break;
                    
                    case "bestNaviRecords":
                        bestNaviRecords = new ushort[param];
                        for (int i = 0; i < bestNaviRecords.Length; i++)
                            bestNaviRecords[i] = 0xFFFF;
                        break;
                    
                    case "waitingRoomData":
                        waitingRoomData = new byte[param];
                        for (int i = 0; i < waitingRoomData.Length; i++)
                            waitingRoomData[i] = 0xFF;
                        break;
                    
                    case "waitingRoomDataB":
                        waitingRoomDataB = new byte[param];
                        for (int i = 0; i < waitingRoomDataB.Length; i++)
                            waitingRoomDataB[i] = 0xFF;
                        break;
                    
                    case "waitingRoomNames":
                        waitingRoomNames = new string[param2];
                        for (int i = 0; i < waitingRoomNames.Length; i++)
                            waitingRoomNames[i] = !lc? (language == "en"? "———" : "ーーー") : "---"; // 0x49 dashes in English, 0x82 dashes in Japanese, 0x40 dashes in LC
                        break;
                    
                    case "naviRecordHolderNames":
                        naviRecordHolderNames = new string[param2];
                        for (int i = 0; i < naviRecordHolderNames.Length; i++)
                            naviRecordHolderNames[i] = "ーーー"; // 0x82 dashes in all versions
                        break;
                    
                    case "possibleTournamentEntrants":
                        possibleTournamentEntrants = new byte[param];
                        for (int i = 0; i < possibleTournamentEntrants.Length; i++)
                            possibleTournamentEntrants[i] = 0xFF;
                        break;
                    
                    case "patchCardData":
                        patchCardData = new byte[param];
                        for (int i = 0; i < patchCardData.Length; i++)
                            patchCardData[i] = 0xFF;
                        break;
                    
                    case "eReaderDataDuoName":
                        eReaderDataDuoName = new byte[param];
                        for (int i = 0; i < bn4UnknownNameBytes.Length; i++)
                            eReaderDataDuoName[i] = bn4UnknownNameBytes[i];
                        break;
                    
                    case "eReaderDataDuoDesc":
                        eReaderDataDuoDesc = new byte[param];
                        for (int i = 0; i < bn4UnknownNameBytes.Length; i++)
                            eReaderDataDuoDesc[i] = bn4UnknownNameBytes[i];
                        break;
                    
                    case "eReaderDataDuoGraphics":
                        eReaderDataDuoGraphics = new byte[0x5E0];
                        for (int i = 0x00; i < 0x540; i++) // First 0x540 bytes for blank chip art are just 11, so didn't want to bother storing
                            eReaderDataDuoGraphics[i] = 0x11;
                        for (int i = 0; i < BN4Definitions.eReaderBlankIconGraphics.Length; i++)
                            eReaderDataDuoGraphics[i + 0x540] = BN4Definitions.eReaderBlankIconGraphics[i];
                        break;
                    
                    case "eReaderDataPrixPowrName":
                        eReaderDataPrixPowrName = new byte[param];
                        for (int i = 0; i < bn4UnknownNameBytes.Length; i++)
                            eReaderDataPrixPowrName[i] = bn4UnknownNameBytes[i];
                        break;
                    
                    case "eReaderDataPrixPowrDesc":
                        eReaderDataPrixPowrDesc = new byte[param];
                        for (int i = 0; i < bn4UnknownNameBytes.Length; i++)
                            eReaderDataPrixPowrDesc[i] = bn4UnknownNameBytes[i];
                        break;
                    
                    case "eReaderDataPrixPowrGraphics":
                        eReaderDataPrixPowrGraphics = new byte[0x5E0];
                        for (int i = 0x00; i < 0x540; i++) // First 0x540 bytes for blank chip art are just 11, so didn't want to bother storing
                            eReaderDataPrixPowrGraphics[i] = 0x11;
                        for (int i = 0; i < BN4Definitions.eReaderBlankIconGraphics.Length; i++)
                            eReaderDataPrixPowrGraphics[i + 0x540] = BN4Definitions.eReaderBlankIconGraphics[i];
                        break;
                    
                    default:
                        handled = false;
                        break;
                }
                
                // If field is not specifically handled, do a more generic handling for arrays and other data types.
                if (!handled)
                {
                    switch (field.dataType)
                    {
                        case T_BYTES: setField(fieldName, new byte[param]); break;
                        case T_USHORTS: setField(fieldName, new ushort[param]); break;
                        case T_SHORTS: setField(fieldName, new short[param]); break;
                        case T_UINTS: setField(fieldName, new uint[param]); break;
                        case T_INTS: setField(fieldName, new int[param]); break;
                        case T_FLAGS:
                            bool[] flags = new bool[param * 8];
                            setField(fieldName, flags);
                            break;
                        
                        case T_FOLDERCHIPS:
                            FolderChip[] folderChips = new FolderChip[30];
                            for (int i = 0; i < folderChips.Length; i++)
                                folderChips[i] = new FolderChip(0x00, 0x00);
                            setField(fieldName, folderChips);
                            break;
                        
                        case T_PACKCHIPSETS:
                            PackChipSet[] packChipSets = new PackChipSet[param];
                            for (int i = 0; i < packChipSets.Length; i++)
                                packChipSets[i] = new PackChipSet(i);
                            setField(fieldName, packChipSets);
                            break;
                        
                        case T_SHOPINVENTORY:
                            ShopItem[] shopInventory = new ShopItem[param];
                            for (int i = 0; i < shopInventory.Length; i++)
                                shopInventory[i] = new ShopItem();
                            setField(fieldName, shopInventory);
                            break;
                        
                        case T_SHOPINVENTORIES:
                            ShopItem[][] shopInventories = new ShopItem[param][];
                            for (int i = 0; i < shopInventories.Length; i++)
                            {
                                shopInventories[i] = new ShopItem[param2];
                                for (int j = 0; j < shopInventories[i].Length; j++)
                                    shopInventories[i][j] = new ShopItem();
                            }
                            setField(fieldName, shopInventories);
                            break;
                        
                        case T_ENCOUNTERPOINTER:
                            setField(fieldName, new EncounterPointer());
                            break;
                        
                        case T_PROGRAMEFFECTS:
                            setField(fieldName, new ProgramEffects());
                            break;
                        
                        case T_PROGRAMEFFECTSARRAY:
                            ProgramEffects[] effectsArray = new ProgramEffects[param];
                            for (int i = 0; i < effectsArray.Length; i++)
                                effectsArray[i] = new ProgramEffects();
                            setField(fieldName, effectsArray);
                            break;
                        
                        case T_PLACEDPROGRAMS:
                            PlacedProgram[] placedPrograms = new PlacedProgram[param];
                            for (int i = 0; i < placedPrograms.Length; i++)
                                placedPrograms[i] = new PlacedProgram(0x00, 0, 0, 0);
                            setField(fieldName, placedPrograms);
                            break;
                        
                        case T_NPCS:
                            NPCData[] npcData = new NPCData[param];
                            for (int i = 0; i < npcData.Length; i++)
                            {
                                npcData[i] = new NPCData();
                                npcData[i].clear(i);
                            }
                            setField(fieldName, npcData);
                            break;
                        
                        case T_TOURNAMENTBOARDS:
                            TournamentEntrant[][] tournamentBoards = new TournamentEntrant[param][];
                            for (int i = 0; i < tournamentBoards.Length; i++)
                            {
                                tournamentBoards[i] = new TournamentEntrant[param2];
                                for (int j = 0; j < tournamentBoards[i].Length; j++)
                                    tournamentBoards[i][j] = new TournamentEntrant(0xFF, 0xFF, 0xFF, 0xFF);
                            }
                            setField(fieldName, tournamentBoards);
                            break;
                    }
                }
            }
            
            // Some tasks must until after other variables have been initialized.
            
            // Set starting folder. (Library flags for starting chips will also be set in the process.)
            setFolderContentsToPreset(ref folderSlot1, "Fldr1", true);
            
            // Set item obtained flags after verification bytes have been initialized.
            if (game >= 4)
            {
                foreach (object[] verifyObtained in itemsToVerifyObtained)
                    setItemVerifiedObtained((int)verifyObtained[0], verifyObtained[1] as string);
            }
            
            // Update karma verification value after programEffets have been initialized (although it's actually set for karma of 0, weirdly).
            if (game >= 4)
                updateKarmaVerification(true);
        }
        
        /// <summary>Reads values of defined fields from file bytes.</summary>
        /// <param name="skipVersionDependent">Whether to skip fields that depend on version/language, which might not be determined yet.</param>
        /// <param name="onlyVersionDependent">Whether to only read fields that depend on version/language, after they have been determined.</param>
        void readFieldsFromSave(bool skipVersionDependent = false, bool onlyVersionDependent = false)
        {
            foreach (DataField field in fields)
            {
                bool isVersionDependent = (field.dataType >= T_TABLESTRING && field.dataType <= T_1BYTETABLESTRINGS) || field.dataType == T_ENCOUNTERPOINTER;
                if ((isVersionDependent && skipVersionDependent) || (!isVersionDependent && onlyVersionDependent))
                    continue;
                
                string fieldName = field.fieldName;
                int address = field.getAddress(lc);
                int param = field.param;
                int param2 = field.param2;
                
                if (address == -1) // Undefined or unused in version; for arrays, set up a blank array
                {
                    switch (field.dataType)
                    {
                        case T_BYTES: setField(fieldName, new byte[param]); break;
                        case T_USHORTS: setField(fieldName, new ushort[param]); break;
                        case T_SHORTS: setField(fieldName, new short[param]); break;
                        case T_UINTS: setField(fieldName, new uint[param]); break;
                        case T_INTS: setField(fieldName, new int[param]); break;
                        case T_FLAGS: setField(fieldName, new bool[param * 8]); break;
                        case T_FOLDERCHIPS: setField(fieldName, new FolderChip[0]); break;
                        case T_PACKCHIPSETS: setField(fieldName, new PackChipSet[0]); break;
                        case T_SHOPINVENTORY: setField(fieldName, new ShopItem[0]); break;
                        case T_SHOPINVENTORIES: setField(fieldName, new ShopItem[0][]); break;
                        case T_ENCOUNTERPOINTER: setField(fieldName, new EncounterPointer()); break;
                        case T_PROGRAMEFFECTS: setField(fieldName, new ProgramEffects()); break;
                        case T_PROGRAMEFFECTSARRAY: setField(fieldName, new ProgramEffects[0]); break;
                        case T_PLACEDPROGRAMS: setField(fieldName, new PlacedProgram[0]); break;
                        case T_NPCS: setField(fieldName, new NPCData[0]); break;
                        case T_TOURNAMENTBOARDS: setField(fieldName, new TournamentEntrant[0][]); break;
                    }
                    continue;
                }
                
                switch (field.dataType)
                {
                    case T_BYTE:
                        setField(fieldName, readByte(address));
                        break;
                    case T_BYTES:
                        setField(fieldName, readBytes(address, param));
                        break;
                    case T_USHORT:
                        setField(fieldName, readUShort(address, param == 0xFF));
                        break;
                    case T_USHORTS:
                        setField(fieldName, readUShorts(address, param));
                        break;
                    case T_SHORT:
                        setField(fieldName, readShort(address));
                        break;
                    case T_SHORTS:
                        setField(fieldName, readShorts(address, param));
                        break;
                    case T_UINT:
                        setField(fieldName, readUInt(address));
                        break;
                    case T_UINTS:
                        setField(fieldName, readUInts(address, param));
                        break;
                    case T_INT:
                        setField(fieldName, readInt(address));
                        break;
                    case T_INTS:
                        setField(fieldName, readInts(address, param));
                        break;
                    case T_FLAGS:
                        setField(fieldName, readFlags(address, param, param2 == 1));
                        break;
                    case T_ASCIISTRING:
                        setField(fieldName, readASCIIString(address, param));
                        break;
                    case T_TABLESTRING:
                        setField(fieldName, readTableString(address, param));
                        break;
                    case T_TABLESTRINGS:
                        setField(fieldName, readTableStrings(address, param, param2));
                        break;
                    case T_1BYTETABLESTRING:
                        setField(fieldName, readTableString(address, param, oneByteMode: true));
                        break;
                    case T_1BYTETABLESTRINGS:
                        setField(fieldName, readTableStrings(address, param, param2, oneByteMode: true));
                        break;
                    case T_FOLDERCHIPS:
                        setField(fieldName, readFolderChips(address, param == -1? 30 : param));
                        break;
                    case T_PACKCHIPSETS:
                        setField(fieldName, readPackChipSets(address, param));
                        break;
                    case T_SHOPINVENTORY:
                        setField(fieldName, readShopInventory(address, param));
                        break;
                    case T_SHOPINVENTORIES:
                        setField(fieldName, readShopInventories(address, param, param2));
                        break;
                    case T_ENCOUNTERPOINTER:
                        setField(fieldName, readEncounterPointer(address));
                        break;
                    case T_PROGRAMEFFECTS:
                        setField(fieldName, readProgramEffects(address));
                        break;
                    case T_PROGRAMEFFECTSARRAY:
                        setField(fieldName, readProgramEffectsArray(address, param));
                        break;
                    case T_PLACEDPROGRAMS:
                        setField(fieldName, readPlacedPrograms(address, param));
                        break;
                    case T_NPCS:
                        setField(fieldName, readNPCs(address, param));
                        break;
                    case T_TOURNAMENTBOARDS:
                        setField(fieldName, readTournamentBoards(address, param, param2));
                        break;
                }
            }
        }
        
        /// <summary>Writes values for defined fields to file bytes, including updating checksums afterward and blanking unused area at end.</summary>
        /// <param name="skipChecksumCompare">Whether to not show checksum text even if option is enabled (usually because it was shown already).</param>
        public void writeFieldsToBytes(bool skipChecksumCompare = false)
        {
            int gbaLibraryStart = 0, gbaLibraryEnd = 0, lcLibraryStart = 0, lcLibraryEnd = 0, lcSteamIDAddress = 0;
            
            foreach (DataField field in fields)
            {
                int[] addresses = { field.getAddress(lc), field.getAddress2(lc) };
                object value = getField(field.fieldName);
                
                if (field.fieldName.Equals("libraryChipFlags"))
                {
                    gbaLibraryStart = field.getAddress(false);
                    lcLibraryStart = field.getAddress(true);
                }
                else if (field.fieldName.Equals("libraryPAFlags"))
                {
                    gbaLibraryEnd = field.getAddress(false) + field.param - 1;
                    lcLibraryEnd = field.getAddress(true) + field.param - 1;
                }
                else if (field.fieldName.Equals("steamID"))
                    lcSteamIDAddress = field.getAddress(true);
                
                for (int addressIndex = 0; addressIndex < addresses.Length; addressIndex++)
                {
                    int myAddress = addresses[addressIndex];
                    if (myAddress == -1)
                        continue;
                    
                    if (addressIndex > 0) // Special treatment for certain secondary addresses
                    {
                        if (game == 2) // When writing second HP values (effective HP), halve if HubStyle is equipped
                        {
                            if ((field.fieldName.Equals("currentHP") || field.fieldName.Equals("maxHP")) && activeStyle % 0x40 == 0x28) // HubStyle
                                value = (ushort)((ushort)value / 2);
                        }
                        else if (game == 4) // When writing second Zenny and BugFrag values, XOR them with the respective source value
                        {
                            if (field.fieldName.Equals("zenny"))
                                value = (uint)value ^ zennyVerificationBase;
                            else if (field.fieldName.Equals("bugFrags"))
                                value = (uint)value ^ bugFragsVerificationBase;
                        }
                    }
                    
                    switch (field.dataType)
                    {
                        case T_BYTE:
                            writeByte(myAddress, (byte)value);
                            break;
                        case T_BYTES:
                            writeBytes(myAddress, (byte[])value);
                            break;
                        case T_USHORT:
                            writeUShort(myAddress, (ushort)value, field.param == 0xFF);
                            break;
                        case T_USHORTS:
                            writeUShorts(myAddress, (ushort[])value);
                            break;
                        case T_SHORT:
                            writeShort(myAddress, (short)value);
                            break;
                        case T_SHORTS:
                            writeShorts(myAddress, (short[])value);
                            break;
                        case T_UINT:
                            writeUInt(myAddress, (uint)value);
                            break;
                        case T_UINTS:
                            writeUInts(myAddress, (uint[])value);
                            break;
                        case T_INT:
                            writeInt(myAddress, (int)value);
                            break;
                        case T_INTS:
                            writeInts(myAddress, (int[])value);
                            break;
                        case T_FLAGS:
                            writeFlags(myAddress, (bool[])value, field.param2 == 1);
                            break;
                        case T_ASCIISTRING:
                            writeASCIIString(myAddress, (string)value);
                            break;
                        case T_TABLESTRING:
                            writeTableString(myAddress, (string)value);
                            break;
                        case T_TABLESTRINGS:
                            writeTableStrings(myAddress, (string[])value, field.param, field.param2);
                            break;
                        case T_1BYTETABLESTRING:
                            writeTableString(myAddress, (string)value, true);
                            break;
                        case T_1BYTETABLESTRINGS:
                            writeTableStrings(myAddress, (string[])value, field.param, field.param2, true);
                            break;
                        case T_FOLDERCHIPS:
                            writeFolderChips(myAddress, (FolderChip[])value);
                            break;
                        case T_PACKCHIPSETS:
                            writePackChipSets(myAddress, (PackChipSet[])value);
                            break;
                        case T_SHOPINVENTORY:
                            writeShopInventory(myAddress, (ShopItem[])value);
                            break;
                        case T_SHOPINVENTORIES:
                            writeShopInventories(myAddress, (ShopItem[][])value);
                            break;
                        case T_ENCOUNTERPOINTER:
                            writeEncounterPointer(myAddress, (EncounterPointer)value);
                            break;
                        case T_PROGRAMEFFECTS:
                            writeProgramEffects(myAddress, (ProgramEffects)value);
                            break;
                        case T_PROGRAMEFFECTSARRAY:
                            writeProgramEffectsArray(myAddress, (ProgramEffects[])value);
                            break;
                        case T_PLACEDPROGRAMS:
                            writePlacedPrograms(myAddress, (PlacedProgram[])value);
                            break;
                        case T_NPCS:
                            writeNPCs(myAddress, (NPCData[])value);
                            break;
                        case T_TOURNAMENTBOARDS:
                            writeTournamentBoards(myAddress, (TournamentEntrant[][])value);
                            break;
                    }
                }
            }
            
            // After updating all bytes, update checksum(s).
            foreach (DataField field in fields)
            {
                int myAddress = field.getAddress(lc);
                if (myAddress == -1)
                    continue;
                
                switch (field.dataType)
                {
                    case T_LIBRARYCHECKSUM:
                        int myStart = !lc? gbaLibraryStart : lcLibraryStart, myEnd = !lc? gbaLibraryEnd : lcLibraryEnd;
                        ushort libraryChecksum = (ushort)(0x10000 - sumOfBytes(myStart, myEnd) - mysteryLibraryCheckByte);
                        if (M.debugPrintChecksumsOnSave && !skipChecksumCompare)
                        {
                            Console.WriteLine("Original library checksum: " + readUShort(myAddress));
                            Console.WriteLine("Calculated library checksum: " + libraryChecksum);
                            Console.WriteLine("Difference: " + (libraryChecksum - readUShort(myAddress)));
                            Console.WriteLine();
                        }
                        writeUShort(myAddress, libraryChecksum);
                        break;
                    
                    case T_SAVECHECKSUM:
                        uint sum = calculateSaveChecksum(myAddress, lcSteamIDAddress);
                        if (M.debugPrintChecksumsOnSave && !skipChecksumCompare)
                        {
                            Console.WriteLine("Original save checksum: " + readUInt(myAddress));
                            Console.WriteLine("Calculated save checksum: " + sum);
                            Console.WriteLine("Difference: " + (readUInt(myAddress) - sum));
                            Console.WriteLine();
                        }
                        writeUInt(myAddress, sum);
                        break;
                }
            }
            
            // Finally, blank unused area at end to FFs in GBA saves.
            if (!lc)
            {
                for (int i = getGameDef().saveAreaLengthGBA; i < fileBytes.Length; i++)
                    fileBytes[i] = 0xFF;
                if (game == 2) // Strangely, last 4 bytes in BN2 GBA are 01 00 00 00, which causes cursor to default to Continue
                    writeUInt(0x7FFC, 1);
            }
        }
        
        /// <summary>Adds up file bytes to get the save checksum.</summary>
        /// <param name="checksumAddress">The address of the checksum itself, so it can be omitted.</param>
        /// <param name="steamIDAddress">The address of the Steam ID, so it can eb omitted.</param>
        /// <param name="forLoading">Whether this is for loading or saving.</param>
        /// <returns>The save checksum.</returns>
        uint calculateSaveChecksum(int checksumAddress, int steamIDAddress = -1)
        {
            List<int> excludeRanges = new List<int>(new int[] { checksumAddress, checksumAddress + 3 });
            if (!lc) // Unused area at end that gets blanked with FFs not counted in checksum
                excludeRanges.AddRange(new int[] { getGameDef().saveAreaLengthGBA, fileBytes.Length });
            else if (steamIDAddress != -1) // Exclude Steam ID in LC
                excludeRanges.AddRange(new int[] { steamIDAddress, steamIDAddress + 3 });
            
            uint sum = sumOfBytes(excludeRanges: excludeRanges.ToArray());
            sum = (uint)(sum + getChecksumOffsetForVersion(version, lc));
            
            return sum;
        }
        
        /// <summary>Gets the checksum offset for the given combination of version parameters.</summary>
        /// <param name="myVersion">The game version.</param>
        /// <param name="myLC">Whether it's Legacy Collection or GBA.</param>
        /// <returns>The corresponding checksum offset.</returns>
        public int getChecksumOffsetForVersion(char myVersion, bool myLC)
        {
            int offset = 0;
            if (!myLC) // GBA-only offsets
            {
                // "First" versions: BN1, BN2, BN3 White, BN4 Red Sun
                if (game == 1 || game == 2 || (game == 3 && myVersion == 'S') || (game == 4 && myVersion == 'M'))
                    offset = 0x16;
                // "Second" versions: BN3 Blue, BN4 Blue Moon
                else if ((game == 3 && myVersion == 'M') || (game == 4 && myVersion == 'S'))
                    offset = 0x22;
            }
            
            return offset;
        }
        
        /// <summary>Defines a field for the current game. Defined fields are automatically read from and written to file, based on the rules of their data type.</summary>
        /// <param name="fieldName">The name of the field in SaveData.</param>
        /// <param name="dataType">The data type, using T_ constants.</param>
        /// <param name="gbaAddress">The (starting) address for this field in the GBA save file.</param>
        /// <param name="lcAddress">The (starting) address for this field in the Legacy Collection save file.</param>
        /// <param name="param">An additional parameter for the data type, often a count.</param>
        /// <param name="param2">An additional parameter for the data type, often a count.</param>
        /// <param name="gbaAddress2">The address of a redundancy for this field in the GBA save file.</param>
        /// <param name="lcAddress2">The address of a redundancy for this field in the Legacy Collection save file.</param>
        /// <param name="shifts">Whether the addresses are affected by memory shift.</param>
        void defineField(string fieldName, byte dataType, int gbaAddress, int lcAddress, int param = -1, int param2 = -1, int gbaAddress2 = -1, int lcAddress2 = -1, bool shifts = false)
        {
            if (onlyLoadingSteamID && fieldName != "steamID")
                return;
            
            try
            {
                this.GetType().GetField(fieldName);
            }
            catch
            {
                Console.WriteLine("ERROR: Field " + fieldName + " not found.");
                return;
            }
            
            foreach (DataField field in fields)
            {
                if (field.fieldName.Equals(fieldName))
                {
                    Console.WriteLine("ERROR: Field " + fieldName + " already defined.");
                    return;
                }
            }
            
            fields.Add(new DataField(fieldName, dataType, gbaAddress, lcAddress, param, param2, gbaAddress2, lcAddress2, shifts));
        }
        
        /// <summary>Sets the given field in SaveData</summary>
        /// <param name="fieldName">The name of the field in SaveData.</param>
        /// <param name="value">The value to assign.</param>
        void setField(string fieldName, object value)
        {
            try
            {
                this.GetType().GetField(fieldName).SetValue(this, value);
            }
            catch
            {
                Console.WriteLine("ERROR: Field " + fieldName + " not found.");
                return;
            }
        }
        
        /// <summary>Gets the given field in SaveData</summary>
        /// <param name="fieldName">The name of the field in SaveData.</param>
        /// <returns>The value of the field. null if not found.</returns>
        object getField(string fieldName)
        {
            try
            {
                return this.GetType().GetField(fieldName).GetValue(this);
            }
            catch
            {
                Console.WriteLine("ERROR: Field " + fieldName + " not found.");
                return null;
            }
        }
        
        /// <summary>Gets the field definition object for the given field name.</summary>
        /// <param name="name">The name of the field in SaveData.</param>
        /// <returns>The field definition object. null if not found.</returns>
        DataField getFieldDefByName(string name)
        {
            foreach (DataField field in fields)
                if (field.fieldName == name)
                    return field;
            return null;
        }
        
        /// <summary>Shifts an address according to the memory offset in the save file if necessary for current game.</summary>
        /// <param name="baseAddress">The base address.</param>
        /// <returns>The shifted address.</returns>
        public int getShiftedAddress(int baseAddress)
        {
            if (baseAddress < 0)
                return baseAddress;
            
            BNDefinitions def = getGameDef();
            if ((!lc && def.memoryShiftAddressGBA == -1) || (lc && def.memoryShiftAddressLC == -1))
                return baseAddress;
            
            return baseAddress + readUShort(!lc? def.memoryShiftAddressGBA : def.memoryShiftAddressLC);
        }
        
        /// <summary>Checks for and lists differences between previous file bytes and current file bytes.</summary>
        /// <param name="originalBytes">The previous file bytes.</param>
        public void checkFileByteChangesDebug(byte[] originalBytes)
        {
            bool equal = true;
            for (int i = 0; i < originalBytes.Length; i++)
            {
                if (originalBytes[i] != fileBytes[i])
                {
                    if (equal && game >= 4) // Before printint first line, display memory offset in games that use it as reference
                        Console.WriteLine("Memory offset: " + memoryOffsetValue.ToString("X2"));
                    equal = false;
                    Console.WriteLine(i.ToString("X2") + ": " + originalBytes[i].ToString("X2") + " -> " + fileBytes[i].ToString("X2"));
                }
            }
            if (equal)
                Console.WriteLine("All bytes match!");
        }
        
        /// <summary>If debug variable is enabled, lists addresses for defined fields.</summary>
        void listAddressesDebug()
        {
            if (M.debugListAddresses == 0)
                return;
            
            Dictionary<int, DataField> fieldsByAddress = new Dictionary<int, DataField>();
            List<DataField> fieldsWithoutAddress = new List<DataField>();
            foreach (DataField field in fields)
            {
                int address = M.debugListAddresses == 1? field.gbaAddress : field.lcAddress;
                if (address >= 0)
                    fieldsByAddress[address] = field;
                else
                    fieldsWithoutAddress.Add(field);
                    
                address = M.debugListAddresses == 1? field.gbaAddress2 : field.lcAddress2;
                if (address >= 0)
                    fieldsByAddress[address] = field;
            }
            
            List<int> sortedAddresses = new List<int>(fieldsByAddress.Keys);
            sortedAddresses.Sort();
            
            foreach (int address in sortedAddresses)
            {
                DataField field = fieldsByAddress[address];
                int param = field.param;
                int param2 = field.param2;
                
                int length = 1;
                switch (field.dataType)
                {
                    case T_BYTE: length = 1; break;
                    case T_BYTES: case T_FLAGS: length = param; break;
                    case T_USHORT: case T_SHORT: length = 2; break;
                    case T_USHORTS: case T_SHORTS: length = 2 * param; break;
                    case T_UINT: case T_INT: case T_LIBRARYCHECKSUM: case T_SAVECHECKSUM: length = 4; break;
                    case T_UINTS: case T_INTS: length = 4 * param; break;
                    case T_FOLDERCHIPS: length = FolderChip.length * (param != -1? param : 30); break;
                    case T_PACKCHIPSETS: length = PackChipSet.length * param; break;
                    case T_SHOPINVENTORY: length = ShopItem.length * param; break;
                    case T_SHOPINVENTORIES: length = ShopItem.length * param * param2; break;
                    case T_ENCOUNTERPOINTER: length = 4; break;
                    case T_PROGRAMEFFECTS: length = ProgramEffects.length; break;
                    case T_PROGRAMEFFECTSARRAY: length = ProgramEffects.length * param; break;
                    case T_PLACEDPROGRAMS: length = PlacedProgram.length * param; break;
                    case T_NPCS: length = NPCData.length * param; break;
                    case T_TOURNAMENTBOARDS: length = TournamentEntrant.length * param * param2; break;
                }
                
                string addressStr = "0x" + address.ToString("X1");
                if (length > 1)
                    addressStr += "-0x" + (address + length - 1).ToString("X1");
                Console.WriteLine(addressStr + ": " + fieldsByAddress[address].fieldName);
            }
            
            foreach (DataField field in fieldsWithoutAddress)
                Console.WriteLine("N/A: " + field.fieldName);
        }
        
        /* INFO STRING FUNCTIONS */
        
        /// <summary>Prints all information from current fields as text, and puts it on the clipboard.</summary>
        public void printSaveInfoToClipboard()
        {
            StringWriter writer = new StringWriter(new StringBuilder());
            
            if (lc)
            {
                printFieldInfo(writer, "steamID");
                writer.WriteLine();
            }
            
            printFieldInfo(writer, "currentAndMaxHP");
            printFieldInfo(writer, "zenny");
            if (game >= 3)
                printFieldInfo(writer, "bugFrags");
            if (game >= 2)
                printFieldInfo(writer, "regularMemory");
            if (game == 3)
            {
                printFieldInfo(writer, "startingChipSlots");
                printFieldInfo(writer, "megaChipLimit");
                printFieldInfo(writer, "gigaChipLimit");
            }
            writer.WriteLine();
            
            if (game == 1)
                printFieldInfo(writer, "activeArmor");
            
            if (game == 1 || game == 2)
            {
                printFieldInfo(writer, "attackLevel");
                printFieldInfo(writer, "rapidLevel");
                printFieldInfo(writer, "chargeLevel");
            }
            
            if (game == 2)
                writer.WriteLine();
            
            if (game == 2 || game == 3)
            {
                printFieldInfo(writer, "activeStyle");
                
                if (game == 2)
                    printFieldInfo(writer, "registeredStyles");
                else if (game == 3)
                    printFieldInfo(writer, "registeredStyle");
                
                if (game == 3)
                {
                    printFieldInfo(writer, "styleLevel");
                    printFieldInfo(writer, "styleAdvancementMode");
                }
                
                printFieldInfo(writer, "battlesSinceStyleChange");
                
                printFieldInfo(writer, "styleProgress");
            }
            
            if (game >= 1 && game <= 3)
                writer.WriteLine();
            
            printFieldInfo(writer, "area");
            printFieldInfo(writer, "subarea");
            printFieldInfo(writer, "playerPosition");
            printFieldInfo(writer, "jackInArea");
            printFieldInfo(writer, "jackInSubarea");
            printFieldInfo(writer, "jackInPosition");
            printFieldInfo(writer, "currentMusic");
            printFieldInfo(writer, "chapter");
            if (game == 4)
                printFieldInfo(writer, "playthroughNumber");
            writer.WriteLine();
            
            printFieldInfo(writer, "playTime");
            if (game < 4)
                printFieldInfo(writer, "timeInBattles");
            if (game == 4)
            {
                printFieldInfo(writer, "playerName");
                printFieldInfo(writer, "karma");
                printFieldInfo(writer, "battlePoints");
            }
            printFieldInfo(writer, "multiplayerRecord");
            writer.WriteLine();
            
            if (upgradeItemQuantities != null)
            {
                writer.WriteLine("Upgrade items:");
                for (int i = 0; i < upgradeItemQuantities.Length; i++)
                {
                    string itemName = getUpgradeItemName(i, false);
                    if (itemName != "")
                        writer.WriteLine(itemName + " x" + upgradeItemQuantities[i]);
                }
                writer.WriteLine();
            }
            
            if (game >= 2 && subchipQuantities != null)
            {
                writer.WriteLine("SubChips:");
                for (int i = 0; i < subchipQuantities.Length; i++)
                    writer.WriteLine(getSubchipName(i) + " x" + subchipQuantities[i]);
                writer.WriteLine();
            }
            
            if (game >= 2)
            {
                printFieldInfo(writer, "locEnemyEncounter");
                writer.WriteLine();
            }
            
            if (keyItemQuantities != null)
            {
                writer.WriteLine("Key items:");
                for (int i = 0; i < keyItemQuantities.Length; i++)
                {
                    string itemName = getKeyItemName(i, false);
                    if (itemName != "")
                        writer.WriteLine(itemName + " x" + keyItemQuantities[i]);
                }
                writer.WriteLine();
            }
            
            if (game >= 3 && programQuantities != null)
            {
                writer.WriteLine("Programs:");
                string[] programColors = getDef<string[]>("programColors");
                for (int i = 0; i < programColors.Length && i * 4 < programQuantities.Length; i++)
                {
                    string validColors = programColors[i];
                    for (int k = 0; k < 4; k++)
                    {
                        if (validColors[k] == '-')
                            continue;
                        string colorStr = " (" + (validColors[k] == 'U'? "Pu" : validColors[k] == 'D'? "Gray" : validColors[k].ToString()) + ")";
                        bool compressed = programCompressedFlags != null? programCompressedFlags[(i * 4) + k] : false;
                        writer.WriteLine(getProgramName(i) + colorStr + " x" + programQuantities[(i * 4) + k] + (compressed? " [Compressed]" :""));
                    }
                }
                writer.WriteLine();
                
                if (placedPrograms != null)
                {
                    writer.WriteLine("Placed programs:");
                    bool wrotePlacedProgram = false;
                    foreach (PlacedProgram program in placedPrograms)
                    {
                        if (program.isProgram())
                        {
                            program.printPlacedProgram(writer);
                            wrotePlacedProgram = true;
                        }
                    }
                    if (!wrotePlacedProgram)
                        writer.WriteLine("N/A");
                    writer.WriteLine();
                }
                
                if (programEffectDefs != null)
                {
                    writer.WriteLine("Equipped program effects:");
                    printFieldInfo(writer, "programEffects");
                    writer.WriteLine();
                }
                
                if (game == 3 && errorCodesSavedBytes != null)
                {
                    writer.WriteLine("Saved error codes:");
                    bool wroteSavedError = false;
                    for (int i = 0; i < errorCodesSavedBytes.Length; i++)
                    {
                        if (BN3Definitions.errorCodeSaveBytes[i] == 0x00) // Unused slot
                            continue;
                        writer.WriteLine(BN3Definitions.getErrorCodeName(i) + ": " + (errorCodesSavedBytes[i] == BN3Definitions.errorCodeSaveBytes[i]));
                        wroteSavedError= true;
                    }
                    if (!wroteSavedError)
                        writer.WriteLine("N/A");
                    writer.WriteLine();
                }
            }
            
            if (game == 4)
            {
                writer.WriteLine("Tournament boards:");
                for (int tournamentNum = 0; tournamentNum < 3; tournamentNum++)
                {
                    TournamentEntrant[] board = tournamentBoards[tournamentNum];
                    string tournamentName = tournamentNum == 0? "Den/City Battle" : tournamentNum == 1? "Eagle/Hawk" : "Red Sun/Blue Moon";
                    writer.WriteLine("[" + tournamentName + " Tournament]");
                    
                    bool isUninitialized = board[0].isUninitialized();
                    if (isUninitialized)
                        writer.WriteLine("(This board has not been iniitalized.)");
                    else
                        writer.WriteLine(getTournamentBoardChart(board));
                    writer.WriteLine();
                    
                    int possibleEntrantsOffset = tournamentNum * 0xC;
                    if (possibleEntrantsOffset < possibleTournamentEntrants.Length && possibleTournamentEntrants[possibleEntrantsOffset] != 0xFF)
                    {
                        byte previousSoulNavi = possibleTournamentEntrants[possibleEntrantsOffset];
                        byte previousUniqueNavi = possibleTournamentEntrants[possibleEntrantsOffset + 2];
                        writer.WriteLine("SoulNavi selected previously: " + getTournamentEntrantString(previousSoulNavi, "navi") + " (next loop will usually pick the other)");
                        writer.WriteLine("Other unique Navi selected previously: " + getTournamentEntrantString(previousUniqueNavi, "navi") + " (deprioritized next loop)");
                        writer.WriteLine();
                    }
                }
            }
            
            if (folderSlot1 != null)
            {
                writer.WriteLine("Folder" + (game >= 2? " 1" + (isFolderEquipped("folder1")? " [Equipped]" : "") : "") + ":");
                for (int i = 0; i < folderSlot1.Length; i++)
                    folderSlot1[i].printChip(writer, i == folderSlot1RegularChip);
                writer.WriteLine();
            }
            
            FolderChip[] myFolder2 = getFolderByString("folder2");
            if (isFolderObtained("folder2") && myFolder2 != null)
            {
                byte myRegChip = getFolderRegChipByString("folder2");
                writer.WriteLine("Folder 2" + (isFolderEquipped("folder2")? " [Equipped]" : "") + ":");
                for (int i = 0; i < myFolder2.Length; i++)
                    myFolder2[i].printChip(writer, i == myRegChip);
                writer.WriteLine();
            }
            
            FolderChip[] myFolder3 = getFolderByString("folder3");
            if (isFolderObtained("folder3") && myFolder3 != null)
            {
                byte myRegChip = getFolderRegChipByString("folder3");
                writer.WriteLine("Folder 3" + (isFolderEquipped("folder3")? " [Equipped]" : "") + ":");
                for (int i = 0; i < myFolder3.Length; i++)
                    myFolder3[i].printChip(writer, i == myRegChip);
                writer.WriteLine();
            }
            
            FolderChip[] myExtraFolder = getFolderByString("extraFolder");
            if (isFolderObtained("extraFolder") && myExtraFolder != null)
            {
                byte myRegChip = getFolderRegChipByString("extraFolder");
                writer.WriteLine("Extra Folder (" + getPresetFolderName(getExtraFolderID()) + ")" + (isFolderEquipped("extraFolder")? " [Equipped]" : "") + ":");
                for (int i = 0; i < myExtraFolder.Length; i++)
                    myExtraFolder[i].printChip(writer, i == myRegChip);
                writer.WriteLine();
            }
            
            int[] gameOrderStandardChips = getDef<int[]>("gameOrderStandardChips");
            int[] gameOrderMegaChipsMain = getDef<int[]>("gameOrderMegaChipsMain");
            int[] gameOrderMegaChipsSub = getDef<int[]>("gameOrderMegaChipsSub");
            int[] gameOrderMegaChipsAll = getDef<int[]>("gameOrderMegaChipsAll");
            int[] gameOrderGigaChipsMain = getDef<int[]>("gameOrderGigaChipsMain");
            int[] gameOrderGigaChipsSub = getDef<int[]>("gameOrderGigaChipsSub");
            int[] gameOrderGigaChipsAll = getDef<int[]>("gameOrderGigaChipsAll");
            int[] gameOrderSecretChipsMain = getDef<int[]>("gameOrderSecretChipsMain");
            int[] gameOrderSecretChipsSub = getDef<int[]>("gameOrderSecretChipsSub");
            int[] gameOrderSecretChipsAll = getDef<int[]>("gameOrderSecretChipsAll");
            
            if (libraryChipFlags != null)
            {
                writer.WriteLine("Library chip flags:");
                if (game >= 3)
                    writer.WriteLine("[Standard Chips]");
                for (int i = 0; i < gameOrderStandardChips.Length; i++)
                    printLibraryChipFlag(writer, i, gameOrderStandardChips[i]);
                writer.WriteLine();
                
                if (gameOrderMegaChipsMain.Length == 0) // No version differences in MegaChips
                {
                    if (gameOrderMegaChipsAll.Length > 0)
                    {
                        writer.WriteLine("[MegaChips]");
                        for (int i = 0; i < gameOrderMegaChipsAll.Length; i++)
                            printLibraryChipFlag(writer, i, gameOrderMegaChipsAll[i]);
                        writer.WriteLine();
                    }
                }
                else
                {
                    writer.WriteLine("[MegaChips (" + getVersionName('M') + ")]");
                    for (int i = 0; i < gameOrderMegaChipsMain.Length; i++)
                        printLibraryChipFlag(writer, i, gameOrderMegaChipsMain[i]);
                    writer.WriteLine();
                    
                    writer.WriteLine("[MegaChips (" + getVersionName('S') + ")]");
                    for (int i = 0; i < gameOrderMegaChipsSub.Length; i++)
                        printLibraryChipFlag(writer, i, gameOrderMegaChipsSub[i]);
                    writer.WriteLine();
                }
                
                if (gameOrderGigaChipsMain.Length == 0) // No version differences in GigaChips
                {
                    if (gameOrderGigaChipsAll.Length > 0)
                    {
                        writer.WriteLine("[GigaChips]");
                        for (int i = 0; i < gameOrderGigaChipsAll.Length; i++)
                            printLibraryChipFlag(writer, i, gameOrderGigaChipsAll[i]);
                        writer.WriteLine();
                    }
                }
                else
                {
                    writer.WriteLine("[GigaChips (" + getVersionName('M') + ")]");
                    for (int i = 0; i < gameOrderGigaChipsMain.Length; i++)
                        printLibraryChipFlag(writer, i, gameOrderGigaChipsMain[i]);
                    writer.WriteLine();
                    
                    writer.WriteLine("[GigaChips (" + getVersionName('S') + ")]");
                    for (int i = 0; i < gameOrderGigaChipsSub.Length; i++)
                        printLibraryChipFlag(writer, i, gameOrderGigaChipsSub[i]);
                    writer.WriteLine();
                }
                
                if (gameOrderSecretChipsMain.Length == 0) // No version differences in Secret Chips
                {
                    if (gameOrderSecretChipsAll.Length > 0)
                    {
                        writer.WriteLine("[Secret Chips]");
                        for (int i = 0; i < gameOrderSecretChipsAll.Length; i++)
                            printLibraryChipFlag(writer, i, gameOrderSecretChipsAll[i]);
                        writer.WriteLine();
                    }
                }
                else
                {
                    writer.WriteLine("[Secret Chips (" + getVersionName('M') + ")]");
                    for (int i = 0; i < gameOrderSecretChipsMain.Length; i++)
                        printLibraryChipFlag(writer, i, gameOrderSecretChipsMain[i]);
                    writer.WriteLine();
                    
                    writer.WriteLine("[Secret Chips (" + getVersionName('S') + ")]");
                    for (int i = 0; i < gameOrderSecretChipsSub.Length; i++)
                        printLibraryChipFlag(writer, i, gameOrderSecretChipsSub[i]);
                    writer.WriteLine();
                }
            }
            
            if (game >= 2 && libraryPAFlags != null)
            {
                writer.WriteLine("Library PA flags:");
                int[] gameOrderPAs = getDef<int[]>("gameOrderPAs");
                for (int i = 0; i < gameOrderPAs.Length; i++)
                {
                    int paID = gameOrderPAs[i];
                    bool obtained = paID < libraryPAFlags.Length? libraryPAFlags[paID] : false;
                    bool shared = librarySharedPAFlags != null && paID < librarySharedPAFlags.Length? librarySharedPAFlags[paID] : false;
                    writer.WriteLine("[" + (i + 1) + ": " + getPAName(paID) + "] " + (obtained || !shared? obtained.ToString() : "Shared"));
                }
                writer.WriteLine();
            }
            
            if (pack != null)
            {
                PackChipSet.initPackList(); // Initialize pack list, which is added to with each call of printChipQuantities
                
                writer.WriteLine("Total chips possessed in each code:");
                if (game >= 3)
                    writer.WriteLine("[Standard Chips]");
                bool wroteChip = false;
                for (int i = 0; i < gameOrderStandardChips.Length; i++)
                {
                    if (pack[gameOrderStandardChips[i]].printChipQuantities(writer))
                        wroteChip = true;
                }
                if (!wroteChip)
                    writer.WriteLine("N/A");
                writer.WriteLine();
                
                if (gameOrderMegaChipsAll.Length > 0)
                {
                    writer.WriteLine("[MegaChips]");
                    wroteChip = false;
                    for (int i = 0; i < gameOrderMegaChipsAll.Length; i++)
                    {
                        if (pack[gameOrderMegaChipsAll[i]].printChipQuantities(writer))
                            wroteChip = true;
                    }
                    if (!wroteChip)
                        writer.WriteLine("N/A");
                    writer.WriteLine();
                }
                
                if (gameOrderGigaChipsAll.Length > 0)
                {
                    writer.WriteLine("[GigaChips]");
                    wroteChip = false;
                    for (int i = 0; i < gameOrderGigaChipsAll.Length; i++)
                    {
                        if (pack[gameOrderGigaChipsAll[i]].printChipQuantities(writer))
                            wroteChip = true;
                    }
                    if (!wroteChip)
                        writer.WriteLine("N/A");
                    writer.WriteLine();
                }
                
                if (gameOrderSecretChipsAll.Length > 0)
                {
                    writer.WriteLine("[Secret Chips]");
                    wroteChip = false;
                    for (int i = 0; i < gameOrderSecretChipsAll.Length; i++)
                    {
                        if (pack[gameOrderSecretChipsAll[i]].printChipQuantities(writer))
                            wroteChip = true;
                    }
                    if (!wroteChip)
                        writer.WriteLine("N/A");
                    writer.WriteLine();
                }
                
                writer.WriteLine("List of Pack chips:");
                PackChipSet.printPackList(writer);
                writer.WriteLine();
            }
            
            if (game == 3)
            {
                writer.WriteLine("Time trial records:");
                writer.WriteLine(M.printStringList(getBN3TimeTrialList()));
                writer.WriteLine();
                
                writer.WriteLine("Virus food distribution:");
                string[] virusBreederNames = BN3Definitions.virusBreederNames;
                for (int i = 0; i < virusBreederNames.Length && i < virusFoodDistribution.Length; i++)
                    writer.WriteLine(virusBreederNames[i] + ": " + virusFoodDistribution[i]);
                writer.WriteLine();
            }
            
            if (game == 4)
            {
                writer.WriteLine("Mystery Data collection counts in past loops:");
                for (int flag = 3328; flag <= 4254; flag++)
                {
                    string[] contents = BN4Definitions.getMysteryDataLoopContents(flag);
                    if (contents.Length > 2) // Don't include GMDs without defined content
                        writer.WriteLine(getFlagDesc(flag) + " x" + getBN4MysteryDataContentsIndex(flag));
                }
                writer.WriteLine();
                
                writer.WriteLine("Navi deletion time records:");
                writer.WriteLine(M.printStringList(getBN4NaviRecordsList()));
                writer.WriteLine();
                
                writer.WriteLine("WaitingRoom Navis:");
                writer.WriteLine(M.printStringList(getWaitingRoomOccupantsList()));
                writer.WriteLine();
                
                writer.WriteLine("Patch Card slots:");
                writer.WriteLine(M.printStringList(getPatchCardSlotList()));
                writer.WriteLine();
            }
            
            if (game >= 3 && numberTraderFlags != null)
            {
                writer.WriteLine("Number Trader codes used:");
                string[] numberTraderCodes = getDef<string[]>("numberTraderCodes");
                for (int i = 0; i < numberTraderCodes.Length; i++)
                    writer.WriteLine("[" + (i + 1) + "] " + numberTraderCodes[i] + ": " + numberTraderFlags[i]);
                writer.WriteLine();
            }
            
            if (shopInventories != null)
            {
                for (int i = 0; i < shopInventories.Length; i++)
                {
                    writer.WriteLine(getShopName(i) + " inventory:");
                    bool wroteItem = false;
                    for (int k = 0; k < shopInventories[i].Length; k++)
                    {
                        if (shopInventories[i][k].isItem())
                        {
                            shopInventories[i][k].printShopItem(writer, isBugFragShop(i));
                            wroteItem = true;
                        }
                        else // Non-items are used to terminate list in some games
                            break;
                    }
                    if (!wroteItem)
                        writer.WriteLine("N/A");
                    writer.WriteLine();
                }
            }
            
            if (game >= 3 && chipOrderInventory != null)
            {
                writer.WriteLine(getChipOrderShopName() + " inventory:");
                for (int i = 0; i < chipOrderInventory.Length; i++)
                    chipOrderInventory[i].printShopItem(writer);
                writer.WriteLine();
            }
            
            if (emailList != null)
            {
                writer.WriteLine("Emails received:");
                bool wroteEmail = false;
                for (int i = 0; i < emailList.Length && i < emailCount; i++)
                {
                    if (emailList[i] != 0x80 && emailList[i] != 0x40)
                    {
                        writer.WriteLine(getEmailName(emailList[i]));
                        wroteEmail = true;
                    }
                }
                if (!wroteEmail)
                    writer.WriteLine("N/A");
                writer.WriteLine();
            }
            
            if (game >= 2 && bbsPostLists != null)
            {
                writer.WriteLine("Posts on BBSes:");
                string[] bbsNames = getDef<string[]>("bbsNames");
                bool wroteBBSPost = false;
                for (int i = 0; i < bbsPostLists.Length; i++)
                {
                    if (i / 64 >= bbsNames.Length) // Skip unused BBSes past named ones
                        break;
                    
                    if (i % 64 == 0)
                    {
                        if (i > 0)
                        {
                            if (!wroteBBSPost)
                                writer.WriteLine("N/A");
                            writer.WriteLine();
                        }
                        writer.WriteLine("[" + bbsNames[i / 64] + "]");
                        wroteBBSPost = false;
                    }
                    if (bbsPostLists[i] != 0x40)
                    {
                        writer.WriteLine(getBBSPost(i / 64, bbsPostLists[i]));
                        wroteBBSPost = true;
                    }
                }
                if (!wroteBBSPost)
                    writer.WriteLine("N/A");
                writer.WriteLine();
            }
            
            if (flags != null)
            {
                writer.WriteLine("Flags:");
                for (int i = 0; i < flags.Length; i++)
                {
                    string desc = getFlagDesc(i);
                    writer.WriteLine("[" + i + "] " + flags[i] + (desc != ""? " | " + desc : ""));
                }
            }
            
            Clipboard.SetText(writer.ToString());
            
            Console.WriteLine();
            Console.WriteLine("Save info put on clipboard.");
        }
        
        /// <summary>Gets a display string summarizing the current value/etc. of something in the save file, usable for info summary or editor menus.</summary>
        /// <param name="fieldName">Name of the field. This may not be an exact variable name in cases where a combination or variant is desired.</param>
        /// <returns>The display string.</returns>
        public string getFieldDisplayString(string fieldName)
        {
            switch (fieldName)
            {
                // More-or-less standard display strings
                case "currentHP": return getInfoString("Current HP", currentHP);
                case "maxHP": return getInfoString("Max HP", getTotalHPWithExtras());
                case "zenny": return getInfoString("Zenny", zenny);
                case "bugFrags": return getInfoString("BugFrags", bugFrags);
                case "regularMemory": return getInfoString("Regular Memory", regularMemory + (game >= 4? 4 : 0), "MB"); // Initial +4 not included in BN4+
                case "startingChipSlots": return getInfoString("Starting Chip Slots", getStartingChipSlots());
                case "megaChipLimit": return getInfoString("MegaChip Folder Limit", getMegaChipLimit());
                case "gigaChipLimit": return getInfoString("GigaChip Folder Limit", getGigaChipLimit());
                case "attackUpgrades": return getInfoString("Attack Upgrades", attackUpgrades);
                case "rapidUpgrades": return getInfoString("Rapid Upgrades", rapidUpgrades);
                case "chargeUpgrades": return getInfoString("Charge Upgrades", chargeUpgrades);
                case "styleLevel": return getInfoString("Style Level", styleLevel);
                case "battlesSinceStyleChange": return getInfoString("Battles Since Last Style Change", game == 2? battlesSinceStyleChangeInt : battlesSinceStyleChangeShort);
                case "steamID": return getInfoString("Steam ID", steamID);
                case "attackLevel": return getInfoString("Attack Level", attackUpgrades + 1);
                case "rapidLevel": return getInfoString("Rapid Level", rapidUpgrades + 1);
                case "chargeLevel": return getInfoString("Charge Level", chargeUpgrades + 1);
                case "playthroughNumber": return getInfoString("Playthrough Number", playthroughNumber + 1);
                case "playerName": return getInfoString("Player Name", playerName.Replace("ー", "-").Replace("—", "-")); // Convert non-ASCII dash symbols for display
                case "karma": return getInfoString("Karma Level", programEffects.getKarma());
                case "battlePoints": return getInfoString("BattlePoints", battlePoints);
                
                // Cases that call name definition or other display function for a number value
                case "activeArmor": return getInfoString("Active Armor", getStyleName(activeArmor));
                case "activeStyle": return getInfoString("Active Style", getStyleName(activeStyle));
                case "registeredStyle": return getInfoString("Registered Style", getStyleName(registeredStyle));
                case "area": return getInfoString("Area", getAreaName(area));
                case "subarea": return getInfoString("Sub-Area", getSubareaName(area, subarea));
                case "jackInArea": return getInfoString("Last Jack-In Area", getAreaName(jackInArea));
                case "jackInSubarea": return getInfoString("Last Jack-In Sub-Area", getSubareaName(jackInArea, jackInSubarea));
                case "currentMusic": return getInfoString("Current Music", getMusicName(currentMusic));
                case "chapter": return getInfoString("Story Chapter", getChapterDesc(chapter));
                case "playTime": return getInfoString("Playtime", formatFrameTime(playTime));
                case "timeInBattles": return getInfoString("Time Spent In Battles", formatFrameTime(timeInBattles));
                
                // Cases that show manually-defined strings depending on value
                case "styleAdvancementMode": return getInfoString("Style Advancement Mode", styleAdvancementMode == 1? "Leveling current style" : "Searching for new style");
                
                // Cases that present multiple fields in one string
                case "currentAndMaxHP": return getInfoString("HP", currentHP + "/" + maxHP);
                case "playerPosition": return getInfoString("Player Position", "(" + playerX + "," + playerY + "," + playerZ + ")");
                case "jackInPosition": return getInfoString("Last Jack-In Position", "(" + jackInX + "," + jackInY + "," + jackInZ + ")");
                case "location": return getInfoString("Player Location", getSubareaName(area, subarea) + " (" + playerX + "," + playerY + "," + playerZ + ")");
                case "jackInLocation": return getInfoString("Last Jack-In Location", getSubareaName(jackInArea, jackInSubarea) + " (" + jackInX + "," + jackInY + "," + jackInZ + ")");
                case "multiplayerRecord": return getInfoString("Multiplayer Record", multiplayerBattleRecord + " Battles / " + multiplayerWinRecord + " Wins"
                    + (game == 4? " / " + multiplayerVSVersionRecord + " VS RS/BM Wins" : ""));
                
                // Other more complex cases
                case "registeredStyles":
                    return getInfoString("Registered Styles", M.printStringList(getBN2RegisteredStylesList(), true));
                
                case "styleProgress":
                    return M.printStringList(getStyleProgressList(true));
                
                case "locEnemyEncounter":
                    Dictionary<int, string> definedEncounters = getGameDef().getDefinedEncounters();
                    string encounterDisplay = "N/A";
                    int encounterID = locEnemyEncounterPointer.getEncounterID();
                    if (isLocEnemyActive() && encounterID != 0)
                    {
                        if (definedEncounters.ContainsKey(encounterID)) // Use name from defined encounter list if it matches one
                            encounterDisplay = definedEncounters[encounterID];
                        else // Otherwise, show a name based on area and offset
                        {
                            if (getGameDef().encountersUsingSubsections) // Game that uses subsections
                            {
                                byte encounterArea = locEnemyEncounterPointer.area;
                                byte rawSubarea = (byte)(locEnemyEncounterPointer.subsection % 0x10);
                                byte specialLevel = (byte)(locEnemyEncounterPointer.subsection / 0x10);
                                string specialStr = specialLevel == 1? " (Special)" : specialLevel > 1? " (Special " + (specialLevel + 1) + ")" : "";
                                encounterDisplay = getSubareaName(encounterArea, rawSubarea) + specialStr + " +" + locEnemyEncounterPointer.offsetInArea.ToString("X2");
                            }
                            else // Game that bases everything from area only
                                encounterDisplay = getAreaName(locEnemyEncounterPointer.area) + " +" + locEnemyEncounterPointer.offsetInArea.ToString("X2");
                        }
                    }
                    return getInfoString("LocEnemy Target", encounterDisplay);
                
                case "programEffects":
                    return programEffects.getFullInfoString();
            }
            
            return "<" + fieldName + ">";
        }
        
        /// <summary>Gets a standard-format info display string for simple cases of "Field Name: value."</summary>
        /// <param name="displayName">The display name to use for the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="suffix">An optional suffix to put after the value.</param>
        /// <returns>Standard display string combining name with value.</returns>
        string getInfoString(string displayName, object value, string suffix = "")
        {
            return displayName + ": " + value.ToString() + suffix;
        }
        
        /// <summary>Writes to a StringWriter the result of getFieldDisplayString for the given field. Will not write if result is blank.</summary>
        /// <param name="writer">The StringWriter to write to.</param>
        /// <param name="fieldName">Name of the field. This may not be an exact variable name in cases where a combination or variant is desired.</param>
        public void printFieldInfo(StringWriter writer, string fieldName)
        {
            string result = getFieldDisplayString(fieldName);
            if (result != "")
                writer.WriteLine(result);
        }
        
        /// <summary>Aids printSaveInfoToClipboard in writing a library chip flag.</summary>
        /// <param name="writer">The StringWriter to write to.</param>
        /// <param name="index">The index of the chip in the list.</param>
        /// <param name="chipID">The internal ID of the chip.</param>
        void printLibraryChipFlag(StringWriter writer, int index, int chipID)
        {
            bool obtained = libraryChipFlags != null && chipID < libraryChipFlags.Length? libraryChipFlags[chipID] : false;
            bool shared = librarySharedChipFlags != null && chipID < librarySharedChipFlags.Length? librarySharedChipFlags[chipID] : false;
            writer.WriteLine("[" + (index + 1) + ": " + getChipName(chipID) + "] " + (obtained || !shared? obtained.ToString() : "Shared"));
        }
        
        /// <summary>Gets a string for a visaully chart representation of a BN4 tournament board.</summary>
        /// <param name="board">The array of TournamentEntrants making up the board.</param>
        /// <param name="includeHighlights">Whether to include highlight brackets for in-program display.</param>
        /// <param name="bottomRowOnly">Whether to only show the bottom row, which is sensible when showing a new board with no advancements.</param>
        /// <return>The chart string.</return>
        public static string getTournamentBoardChart(TournamentEntrant[] board, bool includeHighlights = false, bool bottomRowOnly = false)
        {
            // Example of board display:
            //                                    [MegaMan]
            //                     -------------- [  Lan  ] ---------------
            //                     |                                      |
            //                [MegaMan]                               NormlNavi
            //          ----- [  Lan  ] -----                   ----- JackBombr -----
            //          |                   |                   |                   |
            //      [MegaMan]           NormlNavi           NormlNavi           NormlNavi
            //      [  Lan  ]           JackBombr           JackBombr           JackBombr
            //     |         |         |         |         |         |         |         |
            // [MegaMan] NormlNavi NormlNavi NormlNavi NormlNavi NormlNavi NormlNavi NormlNavi
            // [  Lan  ] JackBombr JackBombr JackBombr JackBombr JackBombr JackBombr JackBombr
            
            bool hasConflicts = false;
            
            string[][] round1Names = new string[8][];
            
            string[][] round2Names = new string[4][];
            for (int i = 0; i < round2Names.Length; i++)
            {
                round2Names[i] = new string[2];
                round2Names[i][0] = "   ???   ";
                round2Names[i][1] = "   ???   ";
            }
            
            string[][] round3Names = new string[2][];
            for (int i = 0; i < round3Names.Length; i++)
            {
                round3Names[i] = new string[2];
                round3Names[i][0] = "   ???   ";
                round3Names[i][1] = "   ???   ";
            }
            
            string[] winnerNames = new string[2];
            winnerNames[0] = "   ???   ";
            winnerNames[1] = "   ???   ";
            
            for (int i = 0; i < board.Length; i++)
            {
                int id = board[i].getEntrantID();
                int roundsWon = board[i].getRoundsWon();
               
                string naviName = getTournamentEntrantString(id, "navishort");
                string operatorName = getTournamentEntrantString(id, "operatorshort");
                
                bool addLeftSpace = true;
                while (naviName.Length < 9)
                {
                    if (addLeftSpace)
                        naviName = " " + naviName;
                    else
                        naviName = naviName + " ";
                    addLeftSpace = !addLeftSpace;
                }
                
                addLeftSpace = true;
                while (operatorName.Length < 9)
                {
                    if (addLeftSpace)
                        operatorName = " " + operatorName;
                    else
                        operatorName = operatorName + " ";
                    addLeftSpace = !addLeftSpace;
                }
                
                if (includeHighlights)
                {
                    if (id == 0x1E) // Put curly braces around MegaMan to display in yellow
                    {
                        naviName = "{" + naviName + "}";
                        operatorName = "{" + operatorName + "}";
                    }
                    else if (!board[i].isStillInTournament()) // Put angle brackets around those who have lost to display in dark gray
                    {
                        naviName = "<" + naviName + ">";
                        operatorName = "<" + operatorName + ">";
                    }
                }
                
                round1Names[i] = new string[2];
                round1Names[i][0] = naviName;
                round1Names[i][1] = operatorName;
                
                if (roundsWon >= 1)
                {
                    if (round2Names[i / 2][0] != "   ???   ")
                        hasConflicts = true;
                    round2Names[i / 2][0] = naviName;
                    round2Names[i / 2][1] = operatorName;
                }
                
                if (roundsWon >= 2)
                {
                    if (round3Names[i / 4][0] != "   ???   ")
                        hasConflicts = true;
                    round3Names[i / 4][0] = naviName;
                    round3Names[i / 4][1] = operatorName;
                }
                
                if (roundsWon >= 3)
                {
                    if (winnerNames[0] != "   ???   ")
                        hasConflicts = true;
                    winnerNames[0] = naviName;
                    winnerNames[1] = operatorName;
                }
            }
            
            StringWriter writer = new StringWriter();
            
            if (!bottomRowOnly)
            {
                writer.WriteLine("                                   " + winnerNames[0] + "\n"
                               + "                    -------------- " + winnerNames[1] + " ---------------\n"
                               + "                    |              " +         "                        |");
                
                for (int spaceCount = 0; spaceCount < 15; spaceCount++)
                    writer.Write(" ");
                for (int i = 0; i < round3Names.Length; i++)
                {
                    writer.Write(round3Names[i][0]);
                    if (i + 1 < round3Names.Length)
                    {
                        for (int spaceCount = 0; spaceCount < 31; spaceCount++)
                            writer.Write(" ");
                    }
                }
                writer.WriteLine();
                
                for (int spaceCount = 0; spaceCount < 9; spaceCount++)
                    writer.Write(" ");
                for (int i = 0; i < round3Names.Length; i++)
                {
                    for (int dashCount = 0; dashCount < 5; dashCount++)
                        writer.Write("-");
                    writer.Write(" " + round3Names[i][1] + " ");
                    for (int dashCount = 0; dashCount < 5; dashCount++)
                        writer.Write("-");
                    if (i + 1 < round3Names.Length)
                    {
                        for (int spaceCount = 0; spaceCount < 19; spaceCount++)
                            writer.Write(" ");
                    }
                }
                writer.WriteLine();
                
                writer.WriteLine("         |                   |                   |                   |");
                
                for (int spaceCount = 0; spaceCount < 5; spaceCount++)
                    writer.Write(" ");
                for (int i = 0; i < round2Names.Length; i++)
                {
                    writer.Write(round2Names[i][0]);
                    if (i + 1 < round2Names.Length)
                    {
                        for (int spaceCount = 0; spaceCount < 11; spaceCount++)
                            writer.Write(" ");
                    }
                }
                writer.WriteLine();
                
                for (int spaceCount = 0; spaceCount < 5; spaceCount++)
                    writer.Write(" ");
                for (int i = 0; i < round2Names.Length; i++)
                {
                    writer.Write(round2Names[i][1]);
                    if (i + 1 < round2Names.Length)
                    {
                        for (int spaceCount = 0; spaceCount < 11; spaceCount++)
                            writer.Write(" ");
                    }
                }
                writer.WriteLine();
                
                writer.WriteLine("    |         |         |         |         |         |         |         |");
            }
            
            for (int i = 0; i < round1Names.Length; i++)
            {
                writer.Write(round1Names[i][0]);
                if (i + 1 < round1Names.Length)
                    writer.Write(" ");
            }
            writer.WriteLine();
            
            for (int i = 0; i < round1Names.Length; i++)
            {
                writer.Write(round1Names[i][1]);
                if (i + 1 < round1Names.Length)
                    writer.Write(" ");
            }
            
            if (hasConflicts)
                writer.Write("\n(Board contains conflicting, illogical advancement info.)");
            
            return writer.ToString();
        }
        
        /// <summary>Gets display string for a potential tournament entrant.</summary>
        /// <param name="entrantID">The ID of the entrant.</param>
        /// <param name="type"><para>What type of display string to return.</para>
        /// <para>"" (default): Full-length "Navi / Operator" string.</para>
        /// <para>"navi": Full-length version of Navi name.</para>
        /// <para>"navishort": Short version (max 9 characters) of Navi name.</para>
        /// <para>"operatorshort": Short version (max 9 characters) of operator name.</para></param>
        /// <param name="includeVerSoul">Whether to include parenthetical info about being an exclusive Soul Navi.</param>
        /// <param name="includeCategory">Whether to note opponent's category (Soul/Unique/etc.).</param>
        /// <returns>The entrant name string.</returns>
        public static string getTournamentEntrantString(int entrantID, string type = "", bool includeVerSoul = false, bool includeCategory = false)
        {
            if (entrantID >= BN4Definitions.tournamentEntrantData.Length)
                return "???";
            
            string[] entrantData = BN4Definitions.tournamentEntrantData[entrantID];
            
            string str = "";
            if (type == "")
                str = entrantData[0] + " & " + entrantData[1];
            else if (type == "navi")
                str = entrantData[0];
            else if (type == "navishort")
                str = entrantData[2] != ""? entrantData[2] : entrantData[0];
            else if (type == "operatorshort")
                str = entrantData[3] != ""? entrantData[3] : entrantData[1];
            
            if (includeVerSoul && entrantData.Length > 5) // Include RS/BM Soul if defined
                str += " (" + entrantData[5] + ")";
            
            if (includeCategory)
            {
                if (entrantData.Length > 5 && entrantData[5].Equals(M.saveData.version == 'M'? "RS Soul" : "BM Soul"))
                    str += " [SoulNavi]";
                else if (entrantID < 0x14)
                    str += " [Unique Navi]";
                else if (entrantID % 2 == 0)
                    str += " [NormalNavi]";
                else if (entrantID != 0x1E)
                    str += " [HeelNavi]";
            }
            
            return str;
        }
        
        /// <summary>Gets display string for an entrant on given tournament board.</summary>
        /// <param name="board">The board data for the tournament.</param>
        /// <param name="index">The index of the entrant.</param>
        /// <param name="type"><para>What type of display string to return.</para>
        /// <para>"" (default): Full-length "Navi / Operator" string.</para>
        /// <para>"navi": Full-length version of Navi name.</para>
        /// <para>"navishort": Short version (max 9 characters) of Navi name.</para>
        /// <para>"operatorshort": Short version (max 9 characters) of operator name.</para></param>
        /// <param name="includeVerSoul">Whether to include parenthetical info about being an exclusive Soul Navi.</param>
        /// <param name="includeCategory">Whether to note opponent's category (SoulNavi or Unique Navi).</param>
        /// <param name="showPriority">Whether to include priority number in parentheses.</param>
        /// <returns>The entrant name string.</returns>
        public static string getTournamentEntrantString(TournamentEntrant[] board, int index, string type = "", bool includeVerSoul = false, bool includeCategory = false, bool showPriority = false)
        {
            string str = getTournamentEntrantString(board[index].getEntrantID(), type, includeVerSoul, includeCategory);
            
            if (showPriority)
                str += " (Priority " + board[index].getPriority() + ")";
            
            return str;
        }
        
        /// <summary>Checks whether a string can be fully represented by the game's string table.</summary>
        /// <param name="str">The string to check.</param>
        /// <param name="subset">Restricts table to a certain limited set of characters.</param>
        /// <param name="myLanguage">Which language's string table to use, currently-set language by default.</param>
        /// <returns>Whether the string is valid.</returns>
        public bool verifyTableString(string str, string subset = "", string myLanguage = "")
        {
            Dictionary<string, ushort> stringByteTable = getGameDef().getStringByteTable(myLanguage != ""? myLanguage : language, lc, subset);
            foreach (char c in str)
            {
                string charStr = c.ToString();
                if (!stringByteTable.ContainsKey(charStr))
                {
                    Console.WriteLine("String contains invalid character: " + charStr);
                    return false;
                }
            }
            return true;
        }
        
        /* SAVE UPDATE HELPERS */
        
        /// <summary>Reformats file bytes to match current game, version, and platform.</summary>
        public void reformatFileBytes()
        {
            if (!lc) // GBA saves always same total size, but unused area at end is blanked
                fileBytes = new byte[0x8000];
            else // LC saves are only as big as necessary
                fileBytes = new byte[getGameDef(game).saveFileSizeLC];
            
            updateTitleString();
            fileIsLC = lc;
        }
        
        /// <summary>Sets game version and updates other variables as necessary.</summary>
        /// <param name="newVersion">The new game version.</param>
        /// <param name="switchOnLoad">Whether this is being called to switch to correct version before getting into the editor.</param>
        public void updateGameVersion(char newVersion, bool switchOnLoad = false)
        {
            // If changed during initial load, recalculate pointers.
            if (game >= 2 && switchOnLoad)
                locEnemyEncounterPointer.determineOffsetFromReadAddress();
            
            if (game == 3)
            {
                // Set version flag.
                if (flags != null && flags.Length > 4702)
                    flags[4702] = newVersion == 'M'; // "Is Blue version" flag
               
                // Switch inventories for differing shops to new version.
                ShopItem[][] prevVersionShops = getGameDef().getInitialShopInventories(version);
                ShopItem[][] newVersionShops = getGameDef().getInitialShopInventories(newVersion);
                for (int shopIndex = 0; shopIndex < shopInventories.Length; shopIndex++)
                {
                    bool sameShop = true;
                    for (int itemIndex = 0; itemIndex < shopInventories[shopIndex].Length; itemIndex++)
                    {
                        if (!prevVersionShops[shopIndex][itemIndex].Equals(newVersionShops[shopIndex][itemIndex]))
                        {
                            sameShop = false;
                            break;
                        }
                    }
                    
                    if (sameShop)
                        continue;
                    
                    int hpMemoriesBought = getHPMemoriesBought(shopIndex); // Get the current number of HPMemories bought
                    shopInventories[shopIndex] = newVersionShops[shopIndex]; // Set to initial stock for new version
                    setHPMemoriesBought(shopIndex, hpMemoriesBought); // Adjust number of HPMemories in stock
                }
                
                // Switch the version-exclusive chips in Chip Order.
                if (chipOrderInventory != null)
                {
                    ShopItem[] blueExclusives = new ShopItem[] { new ShopItem(0x02, 0x12E, 0x19, 300, 0), new ShopItem(0x02, 0x12F, 0x1A, 300, 0),
                        new ShopItem(0x02, 0x135, 0x00, 400, 0), new ShopItem(0x02, 0x136, 0x15, 500, 0), new ShopItem(0x02, 0x137, 0x17, 400, 0) };
                    ShopItem[] whiteExclusives = new ShopItem[] { new ShopItem(0x02, 0x130, 0x1A, 300, 0), new ShopItem(0x02, 0x131, 0x15, 500, 0),
                        new ShopItem(0x02, 0x132, 0x17, 400, 0), new ShopItem(0x02, 0x133, 0x12, 400, 0), new ShopItem(0x02, 0x134, 0x18, 300, 0) };
                    
                    ShopItem[] oldExclusives = version == 'M'? blueExclusives : whiteExclusives;
                    ShopItem[] newExclusives = newVersion == 'M'? blueExclusives : whiteExclusives;
                    
                    for (int itemIndex = 0; itemIndex < chipOrderInventory.Length; itemIndex++) // Check if each item matches any of the exclusives
                    {
                        for (int exclusiveIndex = 0; exclusiveIndex < blueExclusives.Length; exclusiveIndex++) // Check each exclusive
                        {
                            if (chipOrderInventory[itemIndex].Equals(oldExclusives[exclusiveIndex], false)) // If match found (ignoring stock), replace item and move on to next item
                            {
                                chipOrderInventory[itemIndex] = newExclusives[exclusiveIndex];
                                break;
                            }
                        }
                    }
                }
            }
            
            if (game == 4)
            {
                // Switch the one version-exclusive shop item.
                if (shopInventories.Length >= 13 && shopInventories[13] != null)
                {
                    ushort origItemID = (ushort)(this.version == 'M'? 0x133 : 0x131); // HolyDrem in RS, SignlRed in BM
                    ushort origItemCode = (ushort)(this.version == 'M'? 0x07 : 0x12); // H in RS, S in BM
                    ushort newItemID = (ushort)(newVersion == 'M'? 0x133 : 0x131);
                    ushort newItemCode = (ushort)(newVersion == 'M'? 0x07 : 0x12);
                    
                    for (int i = 0; i < shopInventories[13].Length; i++)
                    {
                        if (shopInventories[13][i].replaceItem(origItemID, origItemCode, newItemID, newItemCode))
                            break;
                    }
                }
                
                // Update verification sections, based solely on the sections themselves, to use XOR values for new version.
                byte originalItemXOR = (byte)(this.version == 'M'? 0x2C : 0x71);
                byte newItemXOR = (byte)(newVersion == 'M'? 0x2C : 0x71);
                updateXORVerificationBytes(ref itemVerificationBytes, itemVerificationSource, originalItemXOR, newItemXOR);
                
                byte originalLibraryXOR = (byte)(this.version == 'M'? 0x64 : 0x47);
                byte newLibraryXOR = (byte)(newVersion == 'M'? 0x64 : 0x47);
                updateXORVerificationBytes(ref libraryFlagVerificationBytes, libraryFlagVerificationSource, originalLibraryXOR, newLibraryXOR);
                
                byte originalSharedXOR = (byte)(this.version == 'M'? 0x38 : 0x8E);
                byte newSharedXOR = (byte)(newVersion == 'M'? 0x38 : 0x8E);
                updateXORVerificationBytes(ref librarySharedVerificationBytes, librarySharedVerificationSource, originalSharedXOR, newSharedXOR);
                
                byte originalPatchCardXOR = (byte)(this.version == 'M'? 0x43 : 0x31);
                byte newPatchCardXOR = (byte)(newVersion == 'M'? 0x43 : 0x31);
                updateXORVerificationBytes(ref patchCardVerificationBytes, patchCardVerificationSource, originalPatchCardXOR, newPatchCardXOR);
            }
            
            this.version = newVersion;
            updateTitleString();
        }
        
        /// <summary>Update a XOR-based verification byte array to switch from using one XOR value to another, retaining the same "true" bytes.</summary>
        /// <param name="verificationBytes">The array of verification bytes.</param>
        /// <param name="sourceBytes">The array of source bytes.</param>
        /// <param name="originalXOR">The XOR value that was used to decide the bytes previously.</param>
        /// <param name="newXOR">The new XOR value to use.</param>
        void updateXORVerificationBytes(ref byte[] verificationBytes, byte[] sourceBytes, byte originalXOR, byte newXOR)
        {
            for (int i = 0; i < verificationBytes.Length; i++)
            {
                byte verifyValue = verificationBytes[i];
                byte sourceValue = sourceBytes[i];
                byte originalTrueValue = (byte)(sourceValue ^ originalXOR);
                bool valueIsTrue = verifyValue == originalTrueValue;
                
                byte newTrueValue = (byte)(sourceValue ^ newXOR);
                byte newFalseValue = (byte)(255 - sourceValue);
                verificationBytes[i] = valueIsTrue? newTrueValue : newFalseValue;
            }
        }
        
        /// <summary>Sets game language and updates other variables as necessary.</summary>
        /// <param name="newLanguage">The new language.</param>
        /// <param name="switchOnLoad">Whether this is being called to switch to correct language before getting into the editor.</param>
        public void updateLanguage(string newLanguage, bool switchOnLoad = false)
        {
            this.language = newLanguage;
            
            // If changed during initial load, recalculate pointers.
            if (game >= 2 && switchOnLoad)
                locEnemyEncounterPointer.determineOffsetFromReadAddress();
            
            // Update language-dependent strings for new language.
            if (game >= 4)
            {
                if (!switchOnLoad) // Under normal circumstances, just update loaded strings as necessary
                    updateTableStrings();
                else // If language switched before getting into editor, reload strings directly from bytes using new language
                    readFieldsFromSave(onlyVersionDependent: true);
            }
            
            updateTitleString();
        }
        
        /// <summary>Sets game release type (GBA or Legacy Collection) and updates other variables as necessary.</summary>
        /// <param name="lc">The new Legacy Collection setting.</param>
        public void updateGBAorLC(bool lc)
        {
            this.lc = lc;
            
            updateTableStrings();
        }
        
        /// <summary>Updates table strings for game when language or LC setting changes.</summary>
        void updateTableStrings()
        {
            if (game == 4)
            {
                byte[] stringStartBytes = new byte[] { 0x02, 0x00 };
                byte[] stringEndBytes = new byte[] { 0xE5 };
                
                if (!isEReaderStringUnset("duo")) // Update Duo text for language if it's been set
                {
                    string nameString = language == "en"? BN4Definitions.eReaderDuoName : BN4Definitions.eReaderDuoNameJP;
                    string descString = language == "en"? BN4Definitions.eReaderDuoDesc : BN4Definitions.eReaderDuoDescJP;
                    int nameFullLength = eReaderDataDuoName.Length;
                    int descFullLength = eReaderDataDuoDesc.Length;
                    eReaderDataDuoName = getTableStringBytes(nameString, stringStartBytes, stringEndBytes, nameFullLength);
                    eReaderDataDuoDesc = getTableStringBytes(descString, stringStartBytes, stringEndBytes, descFullLength);
                }
                
                if (!isEReaderStringUnset("prixpowr")) // Update PrixPowr text for language if it's been set
                {
                    string nameString = language == "en"? BN4Definitions.eReaderPrixPowrName : BN4Definitions.eReaderPrixPowrNameJP;
                    string descString = language == "en"? BN4Definitions.eReaderPrixPowrDesc : BN4Definitions.eReaderPrixPowrDescJP;
                    int nameFullLength = eReaderDataPrixPowrName.Length;
                    int descFullLength = eReaderDataPrixPowrDesc.Length;
                    eReaderDataPrixPowrName = getTableStringBytes(nameString, stringStartBytes, stringEndBytes, nameFullLength);
                    eReaderDataPrixPowrDesc = getTableStringBytes(descString, stringStartBytes, stringEndBytes, descFullLength);
                }
                
                // Update Patch Card descriptions for language.
                for (byte slotIndex = 0; slotIndex < 6; slotIndex++)
                    updatePatchCardDescription(slotIndex);
                
                // Make sure any unset names are using the proper dashes for language (which are useful for determining language of saves).
                if (playerName == "———" || playerName == "ーーー" || playerName == "---")
                    playerName = !lc? (language == "en"? "———" : "ーーー") : "---"; // 0x49 dashes in English, 0x82 dashes in Japanese, 0x40 dashes in LC
                
                for (int i = 0; i < waitingRoomNames.Length; i++)
                {
                    if (waitingRoomNames[i] == "———" || waitingRoomNames[i] == "ーーー" || waitingRoomNames[i] == "---")
                        waitingRoomNames[i] = !lc? (language == "en"? "———" : "ーーー") : "---"; // 0x49 dashes in English, 0x82 dashes in Japanese, 0x40 dashes in LC
                }
                
                // naviRecordHolderNames uses 0x82 dashes in both languages, so no need to change those.
            }
        }
        
        /// <summary>Updates title string to match current game, version, language, and platform.</summary>
        void updateTitleString()
        {
            if (game == 1)
            {
                if (!lc)
                    titleString = language == "en"? "ROCKMAN EXE 20010727" : "ROCKMAN EXE 20010120";
                else
                    titleString = "";
            }
            else if (game == 2)
            {
                if (!lc)
                    titleString = "ROCKMANEXE2 20011016";
                else
                    titleString = "";
            }
            else if (game == 3)
            {
                if (!lc)
                    titleString = "ROCKMANEXE3 20021002";
                else
                {
                    if (version == 'M') // Blue
                        titleString = "3B";
                    else // White
                        titleString = "3W";
                }
            }
            else if (game == 4)
            {
                if (!lc)
                    titleString = "ROCKMANEXE4 20031022";
                else
                {
                    if (version == 'M') // Red Sun
                        titleString = "4R";
                    else // Blue Moon
                        titleString = "4B";
                }
            }
        }
        
        /// <summary>Updates various other variables if current map is changed.</summary>
        public void updateOnMapChange()
        {
            // Update "currently in Cyberworld" flag (if one exists for game) to match current area.
            int cyberworldFlag = game == 1? 1026 : game == 3? 9 : -1;
            int cyberAreaThreshold = 0x80;
            
            if (cyberworldFlag != -1)
                flags[cyberworldFlag] = area >= cyberAreaThreshold;
            
            if (area >= cyberAreaThreshold)
            {
                // Fix weird uninitialized BN1 pointers that get referenced in Cyberworld areas - it's fine if they're 0s, but FFs cause crash.
                if (game == 1)
                {
                    for (int i = 0; i < unknownBN1Pointers1.Length; i++)
                    {
                        if (unknownBN1Pointers1[i] == 0xFFFFFFFF)
                            unknownBN1Pointers1[i] = 0;
                    }
                    for (int i = 0; i < unknownBN1Pointers2.Length; i++)
                    {
                        if (unknownBN1Pointers2[i] == 0xFFFFFFFF)
                            unknownBN1Pointers2[i] = 0;
                    }
                }
                
                // If in Cyberworld and jack-in point is still an invalid value from game start, set it to a better default location (Lan's room).
                object[] defaultLocation = getDef<object[]>("uninitializedJackInLocation");
                if (defaultLocation != null && defaultLocation.Length > 5
                 && jackInArea == Convert.ToByte(defaultLocation[0])
                 && jackInSubarea == Convert.ToByte(defaultLocation[1])
                 && jackInX == Convert.ToInt16(defaultLocation[2])
                 && jackInY == Convert.ToInt16(defaultLocation[3])
                 && jackInZ == Convert.ToInt16(defaultLocation[4]))
                {
                    object[] safeLocation = getDef<object[]>("safeLocationLansRoom");
                    jackInArea = Convert.ToByte(safeLocation[0]);
                    jackInSubarea = Convert.ToByte(safeLocation[1]);
                    jackInX = Convert.ToInt16(safeLocation[2]);
                    jackInY = Convert.ToInt16(safeLocation[3]);
                    jackInZ = Convert.ToInt16(safeLocation[4]);
                    jackInFacingDir = Convert.ToByte(safeLocation[5]);
                }
            }
            
            // Clear NPC data from previous map.
            if (npcData != null)
            {
                foreach (NPCData npc in npcData)
                    npc.clear();
            }
        }
        
        /* CHIP AND FOLDER HELPERS */
        
        /// <summary>Returns a string identifier for the currently equipped folder, independent of different internal numbering between games.</summary>
        /// <returns>A string indicating the current equipped folder: "folder1", "folder2", "folder3", or "extraFolder".</returns>
        public string getEquippedFolderString()
        {
            if (game == 1)
                return "folder1";
            else if (game == 2)
                return equippedFolder <= 2? "folder" + (equippedFolder + 1) : "";
            else if (game == 3)
                return equippedFolder == 0? "folder1" : equippedFolder == 1? "extraFolder" : equippedFolder == 2? "folder2" : "";
            else if (game >= 4)
                return equippedFolder == 0? "folder1"
                     : equippedFolder == 1? (folderSlot2ID / 0x10 == 1? "folder2" : "extraFolder")
                     : equippedFolder == 2? (folderSlot3ID / 0x10 == 1? "folder2" : "extraFolder")
                     : "";
            return "";
        }
        
        /// <summary>Returns the internal (0-based) number for the folder indicated by the string.</summary>
        /// <param name="folderStr">A string indicating the folder: "folder1", "folder2", "folder3", or "extraFolder".</param>
        /// <returns>The internal number of the folder (0-based). -1 if not found.</returns>
        public int getFolderSlotByString(string folderStr)
        {
            if (game == 1)
                return folderStr == "folder1"? 0 : -1;
            else if (game == 2)
                return folderStr == "folder1"? 0
                     : folderStr == "folder2"? 1
                     : folderStr == "folder3"? 2
                                             : -1;
            else if (game == 3)
                return folderStr == "folder1"? 0
                     : folderStr == "extraFolder"? 1
                     : folderStr == "folder2"? 2
                                             : -1;
            else if (game >= 4)
                return folderStr == "folder1"? 0
                     : folderStr == "folder2"? (folderSlot2ID / 0x10 == 1? 1 : folderSlot3ID / 0x10 == 1? 2 : -1)
                     : folderStr == "extraFolder"? (folderSlot2ID / 0x10 == 2? 1 : folderSlot3ID / 0x10 == 2? 2 : -1)
                                                 : -1;
            return -1;
        }
        
        /// <summary>Returns the contents of the folder indicated by the string.</summary>
        /// <param name="folderStr">A string indicating the folder: "folder1", "folder2", "folder3", or "extraFolder".</param>
        /// <returns>The array of FolderChips that make up the folder. Returns null if not found.</returns>
        public FolderChip[] getFolderByString(string folderStr)
        {
            int slot = getFolderSlotByString(folderStr);
            if (slot == 0)
                return folderSlot1;
            else if (slot == 1)
                return folderSlot2;
            else if (slot == 2)
                return folderSlot3;
            return null;
        }
        
        /// <summary>Returns the Regular Chip for the folder indicated by the string.</summary>
        /// <param name="folderStr">A string indicating the folder: "folder1", "folder2", "folder3", or "extraFolder".</param>
        /// <returns>The Regular Chip index set for the folder. Returns FF if not found or assigned.</returns>
        public byte getFolderRegChipByString(string folderStr)
        {
            int slot = getFolderSlotByString(folderStr);
            if (slot == 1)
                return folderSlot1RegularChip;
            else if (slot == 2)
                return folderSlot2RegularChip;
            else if (slot == 3)
                return folderSlot3RegularChip;
            return 0xFF;
        }
        
        /// <summary>Returns the ID of the current Extra Folder.</summary>
        /// <param name="noLeadingIdentifier">Whether to include the leading 0x2_ identifier in BN4+.</param>
        /// <returns>The ID of the Extra Folder. FF if not found.</returns>
        public byte getExtraFolderID(bool noLeadingIdentifier = true)
        {
            if (game == 3)
                return extraFolderID;
            
            int extraSlot = getFolderSlotByString("extraFolder");
            if (extraSlot == 1)
                return (byte)(noLeadingIdentifier? folderSlot2ID % 0x10 : folderSlot2ID);
            else if (extraSlot == 2)
                return (byte)(noLeadingIdentifier? folderSlot3ID % 0x10 : folderSlot3ID);
            return 0xFF;
        }
        
        /// <summary>Creates a deep copy of the given folder that will not be affected by changes to the original.</summary>
        /// <param name="folder">The folder to copy.</param>
        /// <returns>The copied folder.</returns>
        public FolderChip[] getFolderDeepCopy(FolderChip[] folder)
        {
            FolderChip[] folderClone = new FolderChip[folder.Length];
            for (int i = 0; i < folder.Length; i++)
                folderClone[i] = new FolderChip(folder[i].chipID, folder[i].codeLetterValue);
            return folderClone;
        }
        
        /// <summary>Sets the equipped folder to the folder indicated by the string, provided it is valid.</summary>
        /// <param name="toEquip">A string indicating the folder to equip: "folder1", "folder2", "folder3", or "extraFolder".</param>
        /// <returns>Whether the folder was equipped, and was not the folder that was already equipped.</returns>
        public bool setEquippedFolder(string toEquip)
        {
            if (toEquip == "")
                return false;
            
            string equippedStr = getEquippedFolderString();
            if (!toEquip.Equals(equippedStr))
            {
                if (!isFolderValid(getFolderByString(toEquip), getFolderRegChipByString(toEquip)))
                {
                    Console.WriteLine("Folder is not valid by rules of game; cannot switch to it.");
                    M.waitForEnter();
                    return false;
                }
                
                equippedFolder = (byte)getFolderSlotByString(toEquip);
                equippedFolderRegularChip = getFolderRegChipByString(toEquip);
                return true;
            }
            return false;
        }
        
        /// <summary>Sets given folder to match the named preset in presetFolders.</summary>
        /// <param name="folder">The folder to modify.</param>
        /// <param name="presetName">The name of the preset.</param>
        /// <param name="packSlotZero">Whether to assign zero to pack slots to match new-game behavior.</param>
        public void setFolderContentsToPreset(ref FolderChip[] folder, string presetName, bool packSlotZero = false)
        {
            string[] presetFolder = getPresetFolder(presetName);
            if (presetFolder.Length == 0)
                return;
            
            string[] chipNames = getDef<string[]>("chipNames");
            
            if (folder == null || folder.Length != 30)
                folder = new FolderChip[30];
            
            for (int folderIndex = 0; folderIndex < folder.Length; folderIndex++)
            {
                if (folder[folderIndex] == null)
                    folder[folderIndex] = new FolderChip(0x00, 0x00);
                
                string[] chipSplit = presetFolder[folderIndex].Split(' ');
                string chipName = chipSplit[0];
                string chipLetter = chipSplit[1];
                for (ushort findChipIndex = 0; findChipIndex < chipNames.Length; findChipIndex++)
                {
                    if (chipNames[findChipIndex] == chipName)
                    {
                        ushort chipID = findChipIndex;
                        ushort chipCode = 0;
                        if (chipLetter == "*")
                            chipCode = 26;
                        else
                            chipCode = (ushort)((int)chipLetter[0] - (int)'A');
                        folder[folderIndex].chipID = chipID;
                        folder[folderIndex].codeLetterValue = chipCode;
                        break;
                    }
                }
                
                if (folder[folderIndex].chipID == 0x00)
                {
                    ConsoleC.WriteLineHL("{WARNING:} Invalid chip " + chipName + " given in preset folder " + presetName + ".", "red");
                    M.waitForEnter();
                }
            }
            
            matchPackToFolders(packSlotZero);
        }
        
        /// <summary>Sets given folder slot to match the named preset in presetFolders.</summary>
        /// <param name="slot">The folder slot to overwrite.</param>
        /// <param name="presetName">The name of the preset.</param>
        /// <param name="packSlotZero">Whether to assign zero to pack slots to match new-game behavior.</param>
        public void setFolderSlotToPreset(int slot, string presetName, bool packSlotZero = false)
        {
            if (slot == 0)
            {
                setFolderContentsToPreset(ref folderSlot1, presetName);
                folderSlot1RegularChip = 0xFF;
            }
            else if (slot == 1)
            {
                setFolderContentsToPreset(ref folderSlot2, presetName);
                folderSlot2RegularChip = 0xFF;
            }
            else if (slot == 2)
            {
                setFolderContentsToPreset(ref folderSlot3, presetName);
                folderSlot3RegularChip = 0xFF;
            }
        }
        
        /// <summary>Sets Extra Folder to a given preset.</summary>
        /// <param name="presetNum">The value for the preset folder.</param>
        public void setExtraFolderToPreset(byte presetNum)
        {
            if (game == 3)
            {
                extraFolderID = presetNum;
                setFolderSlotToPreset(2, getPresetFolderName(presetNum));
            }
            else if (game >= 4)
            {
                int extraSlot = getFolderSlotByString("extraFolder");
                if (extraSlot == 1)
                    folderSlot2ID = (byte)(0x20 + presetNum);
                else if (extraSlot == 2)
                    folderSlot3ID = (byte)(0x20 + presetNum);
                setFolderSlotToPreset(extraSlot, getPresetFolderName(presetNum));
                
                // In BN4+, when Extra Folder is in slot 2, slot 3 also contains its data.
                if (extraSlot == 1)
                {
                    folderSlot3 = getFolderDeepCopy(folderSlot2);
                    folderSlot3RegularChip = folderSlot2RegularChip;
                }
            }
        }
        
        /// <summary>Updates number of unlocked folders and sets them to defaults as necessary.</summary>
        /// <param name="newUnlockCount">The new number of unlocked folders.</param>
        /// <param name="secondSlotExtra">For BN4+, whether second slot should be Extra Folder rather than Folder 2.</param>
        /// <returns>Whether changes were made.</returns>
        public bool setUnlockedFolders(byte newUnlockCount, bool secondSlotExtra = false)
        {
            bool changesMade = false;
            
            if (folderCount != newUnlockCount)
            {
                folderCount = newUnlockCount;
                changesMade = true;
            }
            
            if (isFolderBlank(folderSlot1)) // Slot 1 = Fldr1 in all games
            {
                setFolderContentsToPreset(ref folderSlot1, "Fldr1");
                if (game >= 2)
                {
                    folderSlot1RegularChip = 0xFF;
                    if (equippedFolder == 0)
                        equippedFolderRegularChip = 0xFF;
                }
                if (game >= 4)
                    folderSlot1ID = 0x00;
                changesMade = true;
            }
            
            if (game == 2) // Slot 2 = Fldr2, Slot 3 = Fldr3
            {
                if (folderCount >= 2 && isFolderBlank(folderSlot2))
                {
                    setFolderContentsToPreset(ref folderSlot2, "Fldr2");
                    folderSlot2RegularChip = 0xFF;
                    if (equippedFolder == 1)
                        equippedFolderRegularChip = 0xFF;
                    changesMade = true;
                }
                if (folderCount >= 3 && isFolderBlank(folderSlot3))
                {
                    setFolderContentsToPreset(ref folderSlot3, "Fldr3");
                    folderSlot3RegularChip = 0xFF;
                    if (equippedFolder == 2)
                        equippedFolderRegularChip = 0xFF;
                    changesMade = true;
                }
            }
            else if (game == 3) // Slot 2 = Extra, Slot 3 = Fldr2
            {
                if (folderCount >= 2 && isFolderBlank(folderSlot2))
                {
                    extraFolderID = 0x0A;
                    setFolderContentsToPreset(ref folderSlot2, "XtraFldr");
                    folderSlot2RegularChip = 0xFF;
                    if (equippedFolder == 1)
                        equippedFolderRegularChip = 0xFF;
                    changesMade = true;
                }
                if (folderCount >= 3 && isFolderBlank(folderSlot3))
                {
                    setFolderContentsToPreset(ref folderSlot3, "Fldr2");
                    folderSlot3RegularChip = 0xFF;
                    if (equippedFolder == 2)
                        equippedFolderRegularChip = 0xFF;
                    changesMade = true;
                }
            }
            else if (game >= 4) // Slot 2 = Extra or Fldr2, Slot 3 = Extra
            {
                if (secondSlotExtra) // Should only be true in case of folder count 2
                {
                    int slot2Type = folderSlot2ID / 0x10;
                    
                    if (folderCount >= 2 && (isFolderBlank(folderSlot2) || slot2Type != 2)) // Blank or non-Extra ID
                    {
                        folderSlot2ID = 0x23;
                        setFolderContentsToPreset(ref folderSlot2, "XtraFldr");
                        folderSlot2RegularChip = 0xFF;
                        if (equippedFolder == 1)
                            equippedFolderRegularChip = 0xFF;
                    }
                    
                    folderSlot3ID = 0xFF;
                    folderSlot3 = getFolderDeepCopy(folderSlot2); // Both slots 2 and 3 contain Extra Folder data in this circumstance
                    folderSlot3RegularChip = folderSlot2RegularChip;
                    changesMade = true;
                }
                else
                {
                    int slot2Type = folderSlot2ID / 0x10;
                    int slot3Type = folderSlot3ID / 0x10;
                    
                    if (folderCount >= 2 && (isFolderBlank(folderSlot2) || slot2Type != 1)) // Blank or non-Fldr2 ID
                    {
                        folderSlot2ID = 0x11;
                        setFolderContentsToPreset(ref folderSlot2, "Fldr2");
                        folderSlot2RegularChip = 0xFF;
                        if (equippedFolder == 1)
                            equippedFolderRegularChip = 0xFF;
                        changesMade = true;
                    }
                    if (folderCount >= 3 && (isFolderBlank(folderSlot3) || slot3Type != 2)) // Blank or non-Extra ID
                    {
                        folderSlot3ID = 0x23;
                        setFolderContentsToPreset(ref folderSlot3, "XtraFldr");
                        folderSlot3RegularChip = 0xFF;
                        if (equippedFolder == 2)
                            equippedFolderRegularChip = 0xFF;
                        changesMade = true;
                    }
                    
                    if (folderCount < 2)
                    {
                        folderSlot2ID = 0xFF;
                        makeFolderBlank(ref folderSlot2);
                        folderSlot2RegularChip = 0xFF;
                        changesMade = true;
                    }
                    if (folderCount < 3)
                    {
                        folderSlot3ID = 0xFF;
                        makeFolderBlank(ref folderSlot3);
                        folderSlot3RegularChip = 0xFF;
                        changesMade = true;
                    }
                }
            }
            
            if (!isFolderObtained(getEquippedFolderString())) // If previous equipped folder is no longer available, equip Folder 1
            {
                equippedFolder = 0;
                equippedFolderRegularChip = folderSlot1RegularChip;
                changesMade = true;
                
                if (!isFolderValid(folderSlot1, folderSlot1RegularChip, false)) // If Folder 1 is not valid, prompt for what to do
                {
                    Console.WriteLine("\nTried to switch to Folder 1, but it is not valid.");
                    Console.WriteLine("Revert Folder 1 to starting folder, putting chips back in Pack? (Y/N)");
                    Console.WriteLine("(Otherwise, will switch to Extra Folder.)");
                    string revertPrompt = M.getTypedInput();
                    
                    if (revertPrompt.ToUpper() == "Y") // Keep Folder 1 equipped and revert it to default
                    {
                        setFolderContentsToPreset(ref folderSlot1, "Fldr1");
                        folderSlot1RegularChip = 0xFF;
                        equippedFolderRegularChip = 0xFF;
                    }
                    else // Switch to Extra Folder
                        switchEquippedFolderIfInvalid(true);
                }
            }
            
            return changesMade;
        }
        
        /// <summary>Gets the number of instances of a chip across all folders.</summary>
        /// <param name="chipID">The ID of the chip.</param>
        /// <param name="code">The letter code of the chip. By default, all codes of the chip are counted.</param>
        /// <param name="includeExtra">Whether to include Extra Folders, which should count for library but not for owned quantities.</param>
        /// <returns>The number of instances of the chip.</returns>
        public int getChipInstancesInFolders(int chipID, char code = '\0', bool includeExtra = false)
        {
            List<FolderChip[]> folders = new List<FolderChip[]>();
            folders.Add(getFolderByString("folder1"));
            folders.Add(getFolderByString("folder2"));
            folders.Add(getFolderByString("folder3"));
            if (includeExtra)
                folders.Add(getFolderByString("extraFolder"));
            
            int total = 0;
            foreach (FolderChip[] folder in folders)
            {
                if (folder == null)
                    continue;
                
                foreach (FolderChip chip in folder)
                {
                    if (chip.chipID == chipID && chip.codeLetterValue < letterCodes.Length && (letterCodes[chip.codeLetterValue] == code || code == '\0'))
                        total++;
                }
            }
            
            return total;
        }
        
        /// <summary>Replaces all instances of a chip in folders with the given replacement.</summary>
        /// <param name="chipID">The ID of the chip to replace.</param>
        /// <param name="replacementID">The ID of the replacement chip.</param>
        /// <param name="codeLetterValue">The value for the letter code of the replacement chip.</param>
        /// <returns>Whether the replacement was made and did not result in invalid folders.</returns>
        public bool replaceInFolders(int chipID, int replacementID, int codeLetterValue)
        {
            List<FolderChip[]> folders = new List<FolderChip[]>();
            folders.Add(folderSlot1);
            folders.Add(folderSlot2);
            folders.Add(folderSlot3);
            
            for (int i = 0; i < folders.Count; i++)
            {
                FolderChip[] folder = folders[i];
                if (folder == null)
                    continue;
                
                List<ushort[]> chipBackup = new List<ushort[]>();
                
                for (ushort k = 0; k < folder.Length; k++)
                {
                    FolderChip chip = folder[k];
                    if (chip.chipID == chipID)
                    {
                        chipBackup.Add(new ushort[] { k, chip.chipID, chip.codeLetterValue });
                        chip.chipID = (ushort)replacementID;
                        chip.codeLetterValue = (ushort)codeLetterValue;
                    }
                }
                
                byte regularIndex = i == 0? folderSlot1RegularChip : i == 1? folderSlot2RegularChip : folderSlot3RegularChip;
                
                if (!isFolderValid(folder, regularIndex)) // If folder became invalid, revert to backup and abort
                {
                    foreach (ushort[] backup in chipBackup)
                    {
                        folder[backup[0]].chipID = backup[1];
                        folder[backup[0]].codeLetterValue = backup[2];
                    }
                    return false;
                }
                else // In case isFolderValid changed Regular Chip to fix validity, reflect changes to actual variables
                {
                    if (i == 0)
                        folderSlot1RegularChip = regularIndex;
                    else if (i == 1)
                        folderSlot2RegularChip = regularIndex;
                    else if (i == 2)
                        folderSlot3RegularChip = regularIndex;
                    
                    if (equippedFolder == i)
                        equippedFolderRegularChip = regularIndex;
                }
            }
            
            return true;
        }
        
        /// <summary>Checks the counts of chips used in folders, and ensures that owned chip quantities are at least enough to match.</summary>
        /// <param name="packSlotZero">Whether to assign zero to pack slots to match new-game behavior.</param>
        public void matchPackToFolders(bool packSlotZero = false)
        {
            // Add every folder and just have loop skip over ones that are null for current game.
            List<FolderChip[]> folders = new List<FolderChip[]>();
            folders.Add(getFolderByString("folder1"));
            folders.Add(getFolderByString("folder2"));
            folders.Add(getFolderByString("folder3"));
            if (game >= 4) // Extra Folder only counted toward Pack quantities in BN4+
                folders.Add(getFolderByString("extraFolder"));
            
            foreach (FolderChip[] folder in folders)
            {
                if (folder == null)
                    continue;
                
                foreach (FolderChip chip in folder)
                {
                    int chipID = chip.chipID;
                    if (chipID == 0)
                        continue;
                    char letterCode = letterCodes[chip.codeLetterValue];
                    
                    string myCodes = getDefIndex<string>("chipCodes", chipID);
                    int codeIndex = 0;
                    for (int i = 0; i < myCodes.Length; i++)
                    {
                        if (myCodes[i] == letterCode)
                        {
                            codeIndex = i;
                            break;
                        }
                    }
                    
                    pack[chipID].modifyQuantity(codeIndex, 0, true, packSlotZero); // Passes 0 to not change quantity, just enforce minimum based on count in folders
                }
            }
            
            // In BN3, Extra Folder chips don't affect your pack quantities, so only set library flags.
            if (game == 3)
            {
                FolderChip[] myExtraFolder = getFolderByString("extraFolder");
                if (myExtraFolder != null)
                {
                    foreach (FolderChip chip in myExtraFolder)
                    {
                        if (chip.chipID == 0)
                            continue;
                        setLibraryChipFlag(chip.chipID);
                    }
                }
            }
        }
        
        /// <summary>Returns whether the folder indicated by the string has been obtained.</summary>
        /// <param name="folderStr">A string indicating the folder: "folder1", "folder2", "folder3", or "extraFolder".</param>
        /// <returns>Whether the given folder has been obtained.</returns>
        public bool isFolderObtained(string folderStr)
        {
            if (game == 1)
                return folderStr == "folder1"? true : false;
            else if (game == 2)
                return folderStr == "folder1"? folderCount >= 1
                     : folderStr == "folder2"? folderCount >= 2
                     : folderStr == "folder3"? folderCount >= 3
                                             : false;
            else if (game == 3)
                return folderStr == "folder1"? folderCount >= 1
                     : folderStr == "extraFolder"? folderCount >= 2
                     : folderStr == "folder2"? folderCount >= 3
                                             : false;
            else if (game >= 4)
                return folderStr == "folder1"? folderCount >= 1
                     : folderStr == "folder2"? (folderCount >= 2 && folderSlot2ID / 0x10 == 1) || (folderCount >= 3 && folderSlot3ID / 0x10 == 1) // 0x1X ID
                     : folderStr == "extraFolder"? (folderCount >= 2 && folderSlot2ID / 0x10 == 2) || (folderCount >= 3 && folderSlot3ID / 0x10 == 2) // 0x2X ID
                                                 : false;
            return false;
        }
        
        /// <summary>Returns whether the folder indicated by the string is equipped.</summary>
        /// <param name="folderStr">A string indicating the folder: "folder1", "folder2", "folder3", or "extraFolder".</param>
        /// <returns>Whether the given folder is equipped.</returns>
        public bool isFolderEquipped(string folderStr)
        {
            return getEquippedFolderString().Equals(folderStr);
        }
        
        /// <summary>Checks if the given folder contains blank slots (or is null) and is thus unobtained.</summary>
        /// <param name="folder">The folder to check.</param>
        /// <returns>Whether the folder is blank.</returns>
        public bool isFolderBlank(FolderChip[] folder)
        {
            if (folder == null)
                return true;
            
            foreach (FolderChip chip in folder)
            {
                if (chip.chipID == 0x00)
                    return true;
            }
            return false;
        }
        
        /// <summary>Blanks the given folder.</summary>
        /// <param name="folder">The folder to blank.</param>
        public void makeFolderBlank(ref FolderChip[] folder)
        {
            foreach (FolderChip chip in folder)
            {
                chip.chipID = 0x00;
                chip.codeLetterValue = 0x00;
            }
        }
        
        /// <summary>If a change was made that invalidated equipped folder, replicate in-game behavior of switching to Extra Folder.</summary>
        /// <param name="forReducedCountSwitch">Being called after folder count is reduced to switch to a valid Extra Folder, so don't show messages.</param>
        public void switchEquippedFolderIfInvalid(bool forReducedCountSwitch = false)
        {
            if (game < 3)
                return;
            
            string equippedStr = getEquippedFolderString();
            byte regularChip = getFolderRegChipByString(equippedStr);
            if (isFolderValid(getFolderByString(equippedStr), regularChip, false))
                return;
            
            if (!forReducedCountSwitch)
                Console.WriteLine("\nEquipped folder has been made invalid.");
            
            // If no Extra Folder, give default Extra Folder and equip it.
            if (!isFolderObtained("extraFolder") || isFolderBlank(getFolderByString("extraFolder")))
            {
                if (game == 3) // Add in slot 2
                {
                    if (folderCount < 2)
                        folderCount = 2;
                    extraFolderID = 0x0A;
                    setFolderContentsToPreset(ref folderSlot2, "XtraFldr");
                    equippedFolder = 1;
                    folderSlot2RegularChip = 0xFF;
                    equippedFolderRegularChip = 0xFF;
                }
                else if (game >= 4)
                {
                    if (isFolderObtained("folder2")) // Add in slot 3
                    {
                        folderCount = 3;
                        folderSlot3ID = 0x23;
                        setFolderContentsToPreset(ref folderSlot3, "XtraFldr");
                        equippedFolder = 2;
                        folderSlot3RegularChip = 0xFF;
                        equippedFolderRegularChip = 0xFF;
                    }
                    else // Add in slot 2
                    {
                        folderCount = 2;
                        folderSlot2ID = 0x23;
                        setFolderContentsToPreset(ref folderSlot2, "XtraFldr");
                        equippedFolder = 1;
                        folderSlot2RegularChip = 0xFF;
                        equippedFolderRegularChip = 0xFF;
                    }
                }
                if (!forReducedCountSwitch)
                    Console.WriteLine("Giving default Extra Folder and switching to it.");
            }
            else // If you do have an Extra Folder, ensure that it is itself valid (since free editing allows for it to not be)
            {
                int extraSlot = getFolderSlotByString("extraFolder");
                if (!isFolderValid(getFolderByString("extraFolder"), getFolderRegChipByString("extraFolder"), false))
                {
                    if (!forReducedCountSwitch)
                        Console.WriteLine("Extra Folder is invalid, so reverting it to default.");
                    FolderChip[] defaultExtra = new FolderChip[30];
                    setFolderContentsToPreset(ref defaultExtra, "XtraFldr");
                    if (extraSlot == 1)
                    {
                        folderSlot2 = defaultExtra;
                        folderSlot2RegularChip = 0xFF;
                    }
                    else if (extraSlot == 2)
                    {
                        folderSlot3 = defaultExtra;
                        folderSlot3RegularChip = 0xFF;
                    }
                }
                
                equippedFolder = (byte)extraSlot;
                equippedFolderRegularChip = getFolderRegChipByString("extraFolder");
                if (!forReducedCountSwitch)
                    Console.WriteLine("Switching to Extra Folder.");
            }
            
            if (!forReducedCountSwitch)
                M.waitForEnter();
        }
        
        /// <summary>Checks whether the given folder is valid under the rules of the current game.</summary>
        /// <param name="folder">The folder to check.</param>
        /// <param name="regularIndex">The chip index specified as the Regular Chip, to allow checking if it fits Regular Memory.</param>
        /// <param name="showWarnings">Whether to print warnings to console if errors are found.</param>
        /// <returns>Whether the folder is valid.</returns>
        public bool isFolderValid(FolderChip[] folder, byte regularIndex, bool showWarnings = true)
        {
            int chipInstanceLimit = game == 1? 10 : 5;
            int megaGigaChipInstanceLimit = 1;
            int totalNaviChipLimit = 5;
            int megaChipLimit = getMegaChipLimit();
            int gigaChipLimit = getGigaChipLimit();
            int memoryLimit = regularMemory + (game >= 4? 4 : 0);
            
            Dictionary<int, int> chipInstanceCount = new Dictionary<int, int>();
            int naviChipCount = 0;
            int megaChipCount = 0;
            int gigaChipCount = 0;
            
            bool valid = true;
            List<int> instanceWarningShown = new List<int>();
            for (int i = 0; i < folder.Length; i++)
            {
                int id = folder[i].chipID;
                
                if (!chipInstanceCount.ContainsKey(id))
                    chipInstanceCount[id] = 0;
                chipInstanceCount[id]++;
                
                int myInstanceLimit = chipInstanceLimit;
                if (game == 6) // Has instance limits based on size
                {
                    int size = getDefIndex<int>("chipSizes", id);
                    if (size >= 50)
                        myInstanceLimit = 1;
                    else if (size >= 40)
                        myInstanceLimit = 2;
                    else if (size >= 30)
                        myInstanceLimit = 3;
                    else if (size >= 20)
                        myInstanceLimit = 4;
                    else
                        myInstanceLimit = 5;
                }
                
                if (isMegaChip(id) || isGigaChip(id))
                    myInstanceLimit = megaGigaChipInstanceLimit;
                
                if (chipInstanceCount[id] > myInstanceLimit)
                {
                    if (showWarnings && !instanceWarningShown.Contains(id))
                    {
                        ConsoleC.WriteLineHL("{WARNING:} Chip instance limit for " + getChipName(id) + " exceeded. (Limit " + myInstanceLimit + ", counted " + chipInstanceCount[id] + ")", "red");
                        instanceWarningShown.Add(id);
                    }
                    valid = false;
                }
                
                if (isNaviChip(id))
                    naviChipCount++;
                if (isMegaChip(id))
                    megaChipCount++;
                if (isGigaChip(id))
                    gigaChipCount++;
                
                if (i == regularIndex)
                {
                    int size = getDefIndex<int>("chipSizes", id);
                    if (size > memoryLimit)
                    {
                        if (showWarnings)
                            ConsoleC.WriteLineHL("{WARNING:} Regular Chip exceeds Regular Memory. (Limit " + memoryLimit + "MB, chip is " + size + "MB)", "red");
                        valid = false;
                    }
                }
            }
            
            if (naviChipCount > totalNaviChipLimit)
            {
                if (showWarnings)
                    ConsoleC.WriteLineHL("{WARNING:} Total Navi Chip limit exceeded. (Limit " + totalNaviChipLimit + ", counted " + naviChipCount + ")", "red");
                valid = false;
            }
            if (megaChipCount > megaChipLimit)
            {
                if (showWarnings)
                    ConsoleC.WriteLineHL("{WARNING:} Total MegaChip limit exceeded. (Limit " + megaChipLimit + ", counted " + megaChipCount + ")", "red");
                valid = false;
            }
            if (gigaChipCount > gigaChipLimit)
            {
                if (showWarnings)
                    ConsoleC.WriteLineHL("{WARNING:} Total GigaChip limit exceeded. (Limit " + gigaChipLimit + ", counted " + gigaChipCount + ")", "red");
                valid = false;
            }
            
            return valid;
        }
        
        /// <summary>Checks whether a chip code is marked as legally obtainable, even if it's coded into the game.</summary>
        /// <param name="chipID">The ID of the chip.</param>
        /// <param name="codeIndex">The index of the chip code.</param>
        /// <returns>Whether the chip is legally obtainable.</returns>
        public bool isChipObtainable(int chipID, int codeIndex)
        {
            byte[] unobtainableCodes = getDefKey<int, byte[]>("unobtainableCodes", chipID);
            if (unobtainableCodes != null)
            {
                foreach (byte unobtainableCode in unobtainableCodes)
                {
                    if (unobtainableCode == codeIndex)
                        return false;
                }
            }
            return true;
        }
        
        /// <summary>Returns whether the chip is a Navi chip, for use prior to the introduction of chip classes in BN3.</summary>
        /// <param name="chipID">The ID of the chip.</param>
        /// <returns>Whether the chip is a Navi chip.</returns>
        public bool isNaviChip(int chipID)
        {
            if (game == 1)
                return chipID >= 148 && chipID <= 199; // PharoMan to Bass
            else if (game == 2)
                return (chipID >= 194 && chipID <= 250) || (chipID >= 261 && chipID <= 265); // Roll to BassV3, FireGspl to GateSP
            return false;
        }
        
        /// <summary>Returns whether the chip is a MegaChip.</summary>
        /// <param name="chipID">The ID of the chip.</param>
        /// <returns>Whether the chip is a MegaChip.</returns>
        public bool isMegaChip(int chipID)
        {
            if (game == 3)
                return chipID >= 201 && chipID <= 300 && !getChipName(chipID).EndsWith("V5"); // LifeAura to YamatMnV4, excluding V5 chips
            else if (game == 4)
                return (chipID >= 201 && chipID <= 300) || chipID == 312; // LifeAura to FinalGun, plus PrixPowr
            return false;
        }
        
        /// <summary>Returns whether the chip is a GigaChip.</summary>
        /// <param name="chipID">The ID of the chip.</param>
        /// <returns>Whether the chip is a GigaChip.</returns>
        public bool isGigaChip(int chipID)
        {
            if (game == 3)
                return (chipID >= 301 && chipID <= 312) || getChipName(chipID).EndsWith("V5"); // YamatMnV5 to BassGS, plus other V5 chips
            else if (game == 4)
                return chipID >= 301 && chipID != 312; // Bass onward, but not PrixPowr
            return false;
        }
        
        /* ITEM HELPERS */
        
        /// <summary>Sets all upgrade items of all types as collected or uncollected.</summary>
        /// <param name="set">Whether to set as collected or uncollected.</param>
        /// <returns>Whether changes were made.</returns>
        public bool setAllUpgradeItemsCollected(bool set = true)
        {
            bool changesMade = false;
            
            int[][] upgradeItemFlags = getDef<int[][]>("upgradeItemFlags");
            Dictionary<int, int[]> shopHPMemoryPrices = getDef<Dictionary<int, int[]>>("shopHPMemoryPrices");
            Dictionary<int, int[]> shopPowerUpPrices = getDef<Dictionary<int, int[]>>("shopPowerUpPrices");
            
            foreach (int[] itemFlags in upgradeItemFlags)
            {
                foreach (int flag in itemFlags)
                {
                    if (setUpgradeItemObtained(flag, set, true))
                        changesMade = true;
                }
            }
            
            foreach (int shop in shopHPMemoryPrices.Keys)
            {
                if (setHPMemoriesBought(shop, set? shopHPMemoryPrices[shop].Length : 0))
                    changesMade = true;
            }
            
            foreach (int shop in shopPowerUpPrices.Keys)
            {
                if (setPowerUpsBought(shop, set? shopPowerUpPrices[shop].Length : 0))
                    changesMade = true;
            }
            
            if (game == 1) // Set BN1 armors
            {
                for (int keyItemID = 68; keyItemID <= 70; keyItemID++)
                {
                    if (setKeyItemBought(keyItemID, set))
                        changesMade = true;
                }
            }
            else if (game == 2) // Set BN2 Regular System
            {
                if (setUpgradeItemObtained(-58, set))
                    changesMade = true;
            }
            
            updateUpgradeItemsByFlags();
            
            return changesMade;
        }
        
        /// <summary>Sets all upgrade items of a given type as collected or uncollected.</summary>
        /// <param name="upgradeTypeNum">Index in the upgrade item names list.</param>
        /// <param name="set">Whether to set as collected or uncollected.</param>
        /// <returns>Whether changes were made.</returns>
        public bool setAllUpgradeItemsOfTypeCollected(int upgradeTypeNum, bool set = true)
        {
            bool changesMade = false;
            
            string upgradeName = getDefIndex<string>("upgradeItemNames", upgradeTypeNum);
            int[] upgradeFlags = getDefIndex<int[]>("upgradeItemFlags", upgradeTypeNum);
            Dictionary<int, int[]> shopHPMemoryPrices = getDef<Dictionary<int, int[]>>("shopHPMemoryPrices");
            Dictionary<int, int[]> shopPowerUpPrices = getDef<Dictionary<int, int[]>>("shopPowerUpPrices");
            
            foreach (int flag in upgradeFlags)
            {
                if (setUpgradeItemObtained(flag, set, true))
                    changesMade = true;
            }
            
            if (upgradeName.Equals("HPMemory"))
            {
                foreach (int shop in shopHPMemoryPrices.Keys)
                {
                    int boughtNum = set? shopHPMemoryPrices[shop].Length : 0;
                    if (setHPMemoriesBought(shop, boughtNum))
                        changesMade = true;
                }
            }
            else if (upgradeName.Equals("PowerUP"))
            {
                foreach (int shop in shopPowerUpPrices.Keys)
                {
                    int boughtNum = set? shopPowerUpPrices[shop].Length : 0;
                    if (setPowerUpsBought(shop, boughtNum))
                        changesMade = true;
                }
            }
            
            updateUpgradeItemsByFlags(upgradeTypeNum);
            
            return changesMade;
        }
        
        /// <summary>Gets whether upgrade item is obtained based on the corresponding flag.</summary>
        /// <param name="flag">The flag for the upgrade from upgradeItemFlags. May be a special (i.e. negative) value for special cases.</param>
        /// <returns>Whether the corresponding upgrade has been obtained.</returns>
        public bool getUpgradeItemObtained(int flag)
        {
            if (game == 1 && flag == -583) // Special case for HPMemory+PowerUP in email
                return flags[7] && !flags[583]; // Dad's email received, and not unread
            else if (game == 2 && flag == -58) // Special case for Regular System (Reg+4) from ZLicense
                return keyItemQuantities[58] > 0;
            else if (game == 2 && flag == -59) // Special case for RegUP1 from BLicense
                return keyItemQuantities[59] > 0;
            else if (game == 3 && flag == -4493) // Special case for ExpMemry in email
                return flags[4365] && !flags[4493]; // Dad's email received, and not unread
            else if (game == 4 && flag >= 10000) // Special handling for loops
            {
                int loopRequirement = (flag / 10000) - 1;
                int loopsCollected = getBN4MysteryDataContentsIndex(flag % 10000);
                if (loopsCollected < loopRequirement) // Need to collect prior levels of this MD before you can get this, so can't have collected yet
                    return false;
                if (loopsCollected > loopRequirement) // Already collected MD more times than required, so must have been collected this item already
                    return true;
                flag = flag % 10000; // MD is at the appropriate level for the item, so determine based on the "collected this loop" flag
            }
            return flags[flag];
        }
        
        /// <summary>Gets the description for an upgrade item based on the corresponding flag.</summary>
        /// <param name="flag">The flag for the upgrade from upgradeItemFlags. May be a special (i.e. negative) value for special cases.</param>
        /// <returns>The description to give for the item.</returns>
        public string getUpgradeItemFlagDesc(int flag)
        {
            if (game == 1 && flag == -583) // Special case for HPMemory+PowerUP in email
                return "Email read: Sorry Lan (Dad)";
            else if (game == 2 && flag == -58) // Special case for Regular System (Reg+4) from ZLicense
                return "Completed ZLicense exam (reward: Regular System)";
            else if (game == 2 && flag == -59) // Special case for RegUP1 from BLicense
                return "Completed BLicense exam (reward: RegUP1)";
            else if (game == 3 && flag == -4493) // Special case for ExpMemry in email
                return "Email read: Good luck!! (Dad)";
            else if (game == 4 && (flag % 10000) >= 3328 && (flag % 10000) <= 4254)
            {
                int loopNumber = flag / 10000;
                string mdDesc = getFlagDesc(flag % 10000);
                string numberStr = loopNumber == 1? "1st" : loopNumber == 2? "2nd" : loopNumber == 3? "3rd" : loopNumber + "th";
                return mdDesc.Substring(0, mdDesc.IndexOf("(")) + "(" + numberStr + " time)"; // Replace items list with loop number
            }
            return getFlagDesc(flag);
        }
        
        /// <summary>Sets flag(s) to mark the corresponding upgrade item as obtained.</summary>
        /// <param name="flag">The flag for the upgrade from upgradeItemFlags. May be a special (i.e. negative) value for special cases.</param>
        /// <param name="setObtained">Whether to set as obtained (rather than set as unobtained). Defaults to true.</param>
        /// <param name="settingMultiple">Whether this is being called for multiple items, in which case text should be specific.</param>
        /// <returns>Whether any flags (or other) were changed.</returns>
        public bool setUpgradeItemObtained(int flag, bool setObtained = true, bool settingMultiple = false)
        {
            bool flagsChanged = false;
            
            // Special cases for items tied to reading emails.
            if ((game == 1 && flag == -583) || (game == 3 && flag == -4493))
            {
                int emailFlag = game == 1? 7 : game == 3? 4365 : 0;
                int unreadFlag = game == 1? 583 : game == 3? 4493 : 0;
                if (setObtained)
                {
                    if (!flags[emailFlag])
                    {
                        flags[emailFlag] = true; // Email received
                        flagsChanged = true;
                    }
                    if (flags[unreadFlag])
                    {
                        flags[unreadFlag] = false; // Email read and item obtained
                        flagsChanged = true;
                    }
                }
                else
                {
                    if (flags[emailFlag] && !flags[unreadFlag])
                    {
                        flags[unreadFlag] = true; // Email unread, item not yet obtained
                        flagsChanged = true;
                    }
                }
                return flagsChanged;
            }
            
            // Special cases for items tied to key items.
            if (game == 2 && (flag == -58 || flag == -59))
            {
                int newQuantity = setObtained? 1 : 0;
                if (keyItemQuantities[-flag] != newQuantity)
                {
                    keyItemQuantities[-flag] = (byte)newQuantity;
                    flagsChanged = true;
                }
                return flagsChanged;
            }
            
            // Special handling for Mystery Data flags in BN4.
            if (game == 4 && (flag % 10000) >= 3328 && (flag % 10000) <= 4254)
            {
                int loopRequirement = (flag / 10000) - 1;
                flag = flag % 10000;
                int currentTimesCollected = getBN4MysteryDataContentsIndex(flag);
                
                if (setObtained)
                {
                    while (currentTimesCollected < loopRequirement) // If not at required level, need to collect items from prior levels
                    {
                        if (flags[flag]) // Already collected on current loop, so skip giving for this loop
                            flags[flag] = false;
                        else
                            giveOrTakeBN4MysteryDataForLoop(flag, currentTimesCollected, true, settingMultiple);
                        flagsChanged = true;
                        currentTimesCollected++;
                    }
                    setBN4MysteryDataContentsIndex(flag, (byte)currentTimesCollected);
                    
                    if (currentTimesCollected == loopRequirement && !flags[flag]) // Collected correct number of times in past, not yet collected this loop
                    {
                        flags[flag] = true;
                        flagsChanged = true;
                    }
                    // Note: If currentTimesCollected > loopRequirement, should have collected in past loop, so no change
                }
                else
                {
                    while (currentTimesCollected > loopRequirement) // Collected this in a past loop, so roll important items back until reaching proper loop
                    {
                        giveOrTakeBN4MysteryDataForLoop(flag, currentTimesCollected, false, settingMultiple);
                        flagsChanged = true;
                        currentTimesCollected--;
                    }
                    setBN4MysteryDataContentsIndex(flag, (byte)currentTimesCollected);
                    
                    if (currentTimesCollected == loopRequirement && flags[flag]) // Collected correct number of times in past, and collected this loop
                    {
                        flags[flag] = false;
                        flagsChanged = true;
                    }
                    // Note: If currentTimesCollected < loopRequirement, haven't collected MD in enough past loops to have it, so no change
                }
                
                return flagsChanged;
            }
            
            if (flags[flag] != setObtained)
            {
                flags[flag] = setObtained;
                flagsChanged = true;
            }
            return flagsChanged;
        }
        
        /// <summary>Gets the number of HPMemories bought from all shops or a specified shop.</summary>
        /// <param name="shop">The specfic shop to check if not checking all.</param>
        /// <returns>The number of HPMemories bought from one or all shops.</returns>
        public int getHPMemoriesBought(int shop = -1)
        {
            Dictionary<int, int[]> shopHPMemoryPrices = getDef<Dictionary<int, int[]>>("shopHPMemoryPrices");
            
            int totalBought = 0;
            foreach (int checkShop in shopHPMemoryPrices.Keys)
            {
                if (shop != -1 && shop != checkShop) // Either check every shop if shop == -1, or only check checkShop
                    continue;
                
                if (game < 3) // Multiple HPMemories use a single item entry
                {
                    bool found = false;
                    foreach (ShopItem item in shopInventories[checkShop])
                    {
                        if (item.isHPMemory()) // If an HPMemory is in stock, match its price to list; that index will be the number bought
                        {
                            int index = new List<int>(shopHPMemoryPrices[checkShop]).IndexOf((int)item.getPrice());
                            if (index != -1)
                            {
                                totalBought += index;
                                found = true;
                                break;
                            }
                        }
                    }
                    if (!found) // If no HPMemory is found, assume maximum number have been bought
                        totalBought += shopHPMemoryPrices[checkShop].Length;
                }
                else // Each HPMemory has its own entry, with only the current first one being visible in-game
                {
                    int totalNumber = shopHPMemoryPrices[checkShop].Length;
                    int numberRemaining = 0;
                    foreach (ShopItem item in shopInventories[checkShop])
                    {
                        if (item.isHPMemory())
                            numberRemaining++;
                    }
                    totalBought += Math.Max(totalNumber - numberRemaining, 0);
                }
            }
            
            return totalBought;
        }
        
        /// <summary>Gets the number of PowerUPs bought from all shops or a specified shop.</summary>
        /// <param name="shop">The specfic shop to check if not checking all.</param>
        /// <returns>The number of PowerUPs bought from one or all shops.</returns>
        public int getPowerUpsBought(int shop = -1)
        {
            Dictionary<int, int[]> shopPowerUpPrices = getDef<Dictionary<int, int[]>>("shopPowerUpPrices");
            
            int totalBought = 0;
            foreach (int checkShop in shopPowerUpPrices.Keys)
            {
                if (shop != -1 && shop != checkShop)
                    continue;
                
                if (game < 3) // Multiple HPMemories use a single item entry
                {
                    bool found = false;
                    foreach (ShopItem item in shopInventories[checkShop])
                    {
                        if (item.isPowerUP()) // If a PowerUP is in stock, match its price to list; that index will be the number bought
                        {
                            int index = new List<int>(shopPowerUpPrices[checkShop]).IndexOf((int)item.getPrice());
                            if (index != -1)
                            {
                                totalBought += index;
                                found = true;
                                break;
                            }
                        }
                    }
                    if (!found) // If no PowerUP is found, assume maximum number have been bought
                        totalBought += shopPowerUpPrices[checkShop].Length;
                }
                else // Each PowerUP has its own entry, with only the current first one being visible in-game
                {
                    int totalNumber = shopPowerUpPrices[checkShop].Length;
                    int numberRemaining = 0;
                    foreach (ShopItem item in shopInventories[checkShop])
                    {
                        if (item.isPowerUP())
                            numberRemaining++;
                    }
                    totalBought += Math.Max(totalNumber - numberRemaining, 0);
                }
            }
            
            return totalBought;
        }
        
        /// <summary>Gets whether a one-of-a-kind key item has been bought from its associated shop.</summary>
        /// <param name="keyItemID">The ID of the key item.</param>
        /// <returns>Whether the key item has been bought from the associated shop.</returns>
        public bool getKeyItemBought(int keyItemID)
        {
            Dictionary<int, int[]> shopKeyItemPrices = getDef<Dictionary<int, int[]>>("shopKeyItemPrices");
            
            int myShop = -1;
            foreach (int shopKey in shopKeyItemPrices.Keys)
            {
                if (shopKeyItemPrices[shopKey][0] == keyItemID)
                {
                    myShop = shopKey;
                    break;
                }
            }
            
            if (myShop == -1)
                return false;
            
            foreach (ShopItem item in shopInventories[myShop])
            {
                if (item.isKeyItem(keyItemID)) // Still in stock
                    return false;
            }
            return true;
        }
        
        /// <summary>Adjusts HPMemory price/quantity in the given shop's inventory to match a certain number having been bought from it.</summary>
        /// <param name="shop">The ID of the shop.</param>
        /// <param name="newBought">The new number of HPMemories bought. Capped at defined number for sale at this shop.</param>
        /// <returns>Whether the stock was altered.</returns>
        public bool setHPMemoriesBought(int shop, int newBought)
        {
            if (shop < 0 || shop >= shopInventories.Length)
                return false;
            
            int[] myHPMemoryPrices = getDefKey<int, int[]>("shopHPMemoryPrices", shop);
            if (myHPMemoryPrices == null) // Not a shop that has defined HPMemories
                return false;
            if (newBought > myHPMemoryPrices.Length)
                newBought = myHPMemoryPrices.Length;
            
            int oldBought = getHPMemoriesBought(shop);
            if (oldBought == newBought) // Already matches the specified number to have bought
                return false;
            
            // Begin a new list of items, and start by adding the HPMemories that should be there based on number bought.
            List<ShopItem> newStock = new List<ShopItem>();
            int hpMemoryID = (new List<string>(getDef<string[]>("keyItemNames"))).IndexOf("HPMemory");
            if (game < 3) // Single item with corresponding price
            {
                if (newBought < myHPMemoryPrices.Length) // Only need to add this if buying less than full amount
                    newStock.Add(new ShopItem(ShopItem.T_KEYITEM, (ushort)hpMemoryID, 0x00, (uint)myHPMemoryPrices[newBought]));
            }
            else // Multiple items for each price starting at bought index
            {
                for (int i = newBought; i < myHPMemoryPrices.Length; i++)
                    newStock.Add(new ShopItem(ShopItem.T_KEYITEM, (ushort)hpMemoryID, 0xFF, (uint)myHPMemoryPrices[i]));
            }
            
            // Then add the non-HPMemory items from the original item list (cutting off if it somehow exceeds item max).
            foreach (ShopItem item in shopInventories[shop])
            {
                if (newStock.Count >= shopInventories[shop].Length)
                    break;
                if (!item.isHPMemory())
                    newStock.Add(item);
            }
            
            // Fill in any remaining space with blank items.
            while (newStock.Count < shopInventories[shop].Length)
                newStock.Add(new ShopItem());
            
            // Check if the inventory actually changed in the process; if so, set new inventory and return true.
            for (int i = 0; i < newStock.Count; i++)
            {
                if (!newStock[i].Equals(shopInventories[shop][i]))
                {
                    shopInventories[shop] = newStock.ToArray();
                    return true;
                }
            }
            
            return false;
        }
        
        /// <summary>Adjusts PowerUP price/quantity in the given shop's inventory to match a certain number having been bought from it.</summary>
        /// <param name="shop">The ID of the shop.</param>
        /// <param name="newBought">The new number of PowerUPs bought. Capped at defined number for sale at this shop.</param>
        /// <returns>Whether the stock was altered.</returns>
        public bool setPowerUpsBought(int shop, int newBought)
        {
            if (shop < 0 || shop >= shopInventories.Length)
                return false;
            
            int[] myPowerUpPrices = getDefKey<int, int[]>("shopPowerUpPrices", shop);
            if (myPowerUpPrices == null)
                return false;
            if (newBought > myPowerUpPrices.Length)
                newBought = myPowerUpPrices.Length;
            
            int oldBought = getPowerUpsBought(shop);
            if (oldBought == newBought) // Already matches the specified number to have bought
                return false;
            
            // Begin a new list of items, and start by adding any HPMemories.
            List<ShopItem> newStock = new List<ShopItem>();
            foreach (ShopItem item in shopInventories[shop])
            {
                if (item.isHPMemory())
                    newStock.Add(item);
            }
            
            // Next, adding the PowerUPs that should be there based on number bought.
            int powerUpID = (new List<string>(getDef<string[]>("keyItemNames"))).IndexOf("PowerUP");
            if (game < 3) // Single item with corresponding price
            {
                if (newBought < myPowerUpPrices.Length) // Although if buying full amount, don't add it at all
                    newStock.Add(new ShopItem(ShopItem.T_KEYITEM, (ushort)powerUpID, 0x00, (uint)myPowerUpPrices[newBought]));
            }
            else // Multiple items for each price starting at bought index
            {
                for (int i = newBought; i < myPowerUpPrices.Length; i++)
                    newStock.Add(new ShopItem(ShopItem.T_KEYITEM, (ushort)powerUpID, 0xFF, (uint)myPowerUpPrices[i]));
            }
            
            // Then add the non-HPMemory items from the original item list (cutting off if it somehow exceeds item max).
            foreach (ShopItem item in shopInventories[shop])
            {
                if (newStock.Count >= shopInventories[shop].Length)
                    break;
                if (!item.isHPMemory() && !item.isPowerUP())
                    newStock.Add(item);
            }
            
            // Fill in any remaining space with blank items.
            while (newStock.Count < shopInventories[shop].Length)
                newStock.Add(new ShopItem());
            
            shopInventories[shop] = newStock.ToArray();
            return true;
        }
        
        /// <summary>Sets a one-of-a-kind key item as bought or not, and removes or adds it to its associated shop accordingly.</summary>
        /// <param name="keyItemID">The ID of the key item.</param>
        /// <param name="newBought">The new "bought" state.</param>
        /// <returns>Whether the stock was altered.</returns>
        public bool setKeyItemBought(int keyItemID, bool newBought)
        {
            Dictionary<int, int[]> shopKeyItemPrices = getDef<Dictionary<int, int[]>>("shopKeyItemPrices");
            
            int myShop = -1;
            foreach (int shopKey in shopKeyItemPrices.Keys)
            {
                if (shopKeyItemPrices[shopKey][0] == keyItemID)
                {
                    myShop = shopKey;
                    break;
                }
            }
            
            if (myShop == -1)
                return false;
            
            bool oldBought = getKeyItemBought(keyItemID);
            if (oldBought == newBought) // Already matches the desired state
                return false;
            
            // Begin a new list of items, and start by adding any HPMemories and PowerUPs.
            List<ShopItem> newStock = new List<ShopItem>();
            foreach (ShopItem item in shopInventories[myShop])
            {
                if (item.isHPMemory() || item.isPowerUP())
                    newStock.Add(item);
            }
            
            // Next, if setting to "not bought," add the key item to the list.
            if (!newBought)
                newStock.Add(new ShopItem(ShopItem.T_KEYITEM, (ushort)keyItemID, 0x00, (uint)shopKeyItemPrices[myShop][1]));
            
            // Then add any other items from the original item list (cutting off if it somehowe exceeds item max).
            foreach (ShopItem item in shopInventories[myShop])
            {
                if (newStock.Count >= shopInventories[myShop].Length)
                    break;
                if (!item.isHPMemory() && !item.isPowerUP() && !item.isKeyItem(keyItemID))
                    newStock.Add(item);
            }
            
            // Fill in any remaining space with blank items.
            while (newStock.Count < shopInventories[myShop].Length)
                newStock.Add(new ShopItem());
            
            shopInventories[myShop] = newStock.ToArray();
            return true;
        }
        
        /// <summary>Checks collected flags for all upgrade items and sets counts accordingly.</summary>
        /// <param name="upgradeNum">The number of the upgrade item to update for. -1 for all upgrade items.</param>
        /// <param name="nameOverride">Override for upgrade name, for items outside of normal upgrade items.</param>
        /// <param name="additionalCall">Whether this is being called an additional time for a different type, to handle a case in BN1 where same flag is tied to two item types.</param>
        public void updateUpgradeItemsByFlags(int upgradeNum = -1, string nameOverride = "", bool additionalCall = false)
        {
            List<string> upgradeItemNames = new List<string>(getDef<string[]>("upgradeItemNames"));
            int[][] upgradeItemFlags = getDef<int[][]>("upgradeItemFlags");
            string upgradeName = upgradeNum != -1? upgradeItemNames[upgradeNum] : nameOverride;
            
            if (upgradeName.Equals("HPMemory") || upgradeName == "")
            {
                int myIndex = upgradeItemNames.IndexOf("HPMemory");
                byte itemCount = 0;
                
                // Calculate HP+ value given by NaviCust programs from total HP and previous base HP.
                int totalHP = getTotalHPWithExtras();
                bool hpMaxed = currentHP == totalHP;
                int expectedBaseHP = 100 + ((upgradeItemQuantities.Length > 0? upgradeItemQuantities[myIndex] : 0) * 20);
                int lostBaseHP = game >= 4? Math.Min(expectedBaseHP - baseMaxHP, 0) : 0;
                int hpPlus = 0;
                if (game <= 3)
                    hpPlus = Math.Max(totalHP - expectedBaseHP, 0);
                else
                    hpPlus = Math.Max(overallMaxHP - baseMaxHP, 0);
                
                // Count each HPMemory obtained flag and add ones bought from shops.
                foreach (int flag in upgradeItemFlags[myIndex])
                {
                    if (getUpgradeItemObtained(flag))
                        itemCount++;
                }
                itemCount += (byte)getHPMemoriesBought();
                
                // Set upgrade item count to new total.
                upgradeItemQuantities[myIndex] = itemCount;
                if (itemCount > 0)
                    setItemVerifiedObtained(myIndex, "upgrade");
                
                // Set current and max HP based on item count.
                if (game <= 3)
                {
                    ushort newHP = (ushort)(100 + (itemCount * 20) + hpPlus);
                    maxHP = newHP;
                    if (hpMaxed)
                        currentHP = newHP;
                    if (game == 3)
                        programEffects.setTotalHP(newHP);
                }
                else
                {
                    baseMaxHP = (ushort)Math.Max(100 + (itemCount * 20) - lostBaseHP, 1);
                    overallMaxHP = (ushort)(baseMaxHP + hpPlus);
                    if (hpMaxed)
                        currentHP = overallMaxHP;
                }
            }
            
            if (upgradeName.Equals("PowerUP") || upgradeName == "")
            {
                int myIndex = upgradeItemNames.IndexOf("PowerUP");
                int itemCount = 0;
                
                if (myIndex != -1)
                {
                    // Count each PowerUP obtained flag and add ones bought from shops.
                    foreach (int flag in upgradeItemFlags[myIndex])
                    {
                        if (getUpgradeItemObtained(flag))
                            itemCount++;
                    }
                    itemCount += getPowerUpsBought();
                    
                    // Subtract PowerUPs "spent" according to buster stats.
                    itemCount -= attackUpgrades + rapidUpgrades + chargeUpgrades;
                    
                    // If this resulted in a negative count, take away from stats and "add" those PowerUPs back to count until it's back up to 0.
                    while (itemCount < 0)
                    {
                        int highestIndex = 0;
                        int highestValue = 0;
                        if (attackUpgrades >= highestValue)
                        {
                            highestIndex = 0;
                            highestValue = attackUpgrades;
                        }
                        if (rapidUpgrades >= highestValue)
                        {
                            highestIndex = 1;
                            highestValue = rapidUpgrades;
                        }
                        if (chargeUpgrades >= highestValue)
                        {
                            highestIndex = 2;
                            highestValue = chargeUpgrades;
                        }
                        
                        if (highestIndex == 0)
                            attackUpgrades--;
                        else if (highestIndex == 1)
                            rapidUpgrades--;
                        else if (highestIndex == 2)
                            chargeUpgrades--;
                        itemCount++;
                    }
                    
                    // Set upgrade item count to new total.
                    upgradeItemQuantities[myIndex] = (byte)itemCount;
                    if (itemCount > 0)
                        setItemVerifiedObtained(myIndex, "upgrade");
                }
            }
            
            if (game == 1 && (upgradeName.Equals("Armor") || upgradeName == ""))
            {
                for (int keyItemID = 68; keyItemID <= 70; keyItemID++)
                    keyItemQuantities[keyItemID] = (byte)(getKeyItemBought(keyItemID)? 1 : 0);
            }
            
            if (upgradeName.StartsWith("RegUP") || upgradeName == "") // If any of the RegUPs are updated, all must be counted
            {
                if (upgradeItemNames.IndexOf("RegUP1") != -1)
                {
                    int regUpTotal = 0;
                    
                    if (game == 2) // In BN2, only add initial 4 if Regular System has been obtained
                    {
                        if (getUpgradeItemObtained(-58))
                            regUpTotal += 4;
                    }
                    
                    for (int regNum = 1; regNum <= 3; regNum++)
                    {
                        int myIndex = upgradeItemNames.IndexOf("RegUP" + regNum);
                        byte itemCount = 0;
                        
                        // Count each RegUP obtained flag.
                        foreach (int flag in upgradeItemFlags[myIndex])
                        {
                            if (getUpgradeItemObtained(flag))
                                itemCount++;
                        }
                        
                        // Set upgrade item count to new total, and add to overall RegUP total.
                        upgradeItemQuantities[myIndex] = itemCount;
                        if (itemCount > 0)
                            setItemVerifiedObtained(myIndex, "upgrade");
                        regUpTotal += itemCount * regNum;
                    }
                    
                    // Update Regular Memory to starting memory plus item total plus Regular+ value.
                    byte regMemoryBase = game == 3? (byte)4 : (byte)0; // regularMemory includes initial 4 in BN3, does not in BN2 or BN4+
                    int regularPlus = game == 3? programEffects.regularPlus : 0;
                    regularMemory = (byte)Math.Min(regMemoryBase + regUpTotal + regularPlus, byte.MaxValue);
                }
            }
            
            if (upgradeName.Equals("SubMem") || upgradeName == "")
            {
                int myIndex = upgradeItemNames.IndexOf("SubMem");
                byte itemCount = 0;
                
                if (myIndex != -1)
                {
                    // Count each SubMem obtained flag.
                    foreach (int flag in upgradeItemFlags[myIndex])
                    {
                        if (getUpgradeItemObtained(flag))
                            itemCount++;
                    }
                    
                    // Set SubChip capacity to initial 4 plus new total.
                    upgradeItemQuantities[myIndex] = (byte)(4 + itemCount);
                    if (itemCount > 0) // Checking itemCount rather than quantity is more accurate, as flag is not set until actually collecting a SubMem
                        setItemVerifiedObtained(myIndex, "subchip");
                }
            }
            
            if (upgradeName.Equals("ExpMemry") || upgradeName == "")
            {
                int myIndex = upgradeItemNames.IndexOf("ExpMemry");
                byte itemCount = 0;
                
                if (myIndex != -1)
                {
                    // Count each ExpMemry obtained flag.
                    foreach (int flag in upgradeItemFlags[myIndex])
                    {
                        if (getUpgradeItemObtained(flag))
                            itemCount++;
                    }
                    
                    // Set upgrade item count to new total.
                    upgradeItemQuantities[myIndex] = itemCount;
                    if (itemCount > 0)
                        setItemVerifiedObtained(myIndex, "upgrade");
                }
            }
            
            // In BN1, if specifically updating HPMemories or PowerUPs, should also call to update the other due to "Sorry Lan" email giving both.
            if (game == 1 && !additionalCall && (upgradeName.Equals("HPMemory") || upgradeName.Equals("PowerUP")))
                updateUpgradeItemsByFlags(upgradeName.Equals("HPMemory")? 1 : 0, additionalCall: true);
        }
        
        /// <summary>Sets BN4 Mystery Data collected count for the given Mystery Data flag.</summary>
        /// <param name="flagNum">The flag number associated with the Mystery Data.</param>
        /// <param name="newValue">The new count value.</param>
        /// <param name="pauseAfter">Tracks whether other item contents were given or taken, and thus there should be a pause after process is done to show the info text.</param>
        /// <param name="settingMultiple">Whether this is being called for multiple flags, in which case text should be specific.</param>
        /// <returns>Whether other item contents were given or taken, and thus there should be a pause to show the info text.</returns>
        public bool setMysteryDataCount(int flagNum, byte newValue, ref bool pauseAfter, bool settingMultiple = false)
        {
            byte oldValue = getBN4MysteryDataContentsIndex(flagNum);
            
            if (newValue != oldValue)
            {
                while (oldValue < newValue) // Increasing; give item for current loop then move to next
                {
                    if (flags[flagNum]) // Already collected on current loop, so skip giving for this loop
                        flags[flagNum] = false;
                    else
                    {
                        if (giveOrTakeBN4MysteryDataForLoop(flagNum, oldValue, true, settingMultiple))
                            pauseAfter = true;
                    }
                    oldValue++;
                }
                while (oldValue > newValue) // Decreasing; move to previous loop and take away that item
                {
                    oldValue--;
                    if (giveOrTakeBN4MysteryDataForLoop(flagNum, oldValue, false, settingMultiple))
                        pauseAfter = true;
                }
                
                setBN4MysteryDataContentsIndex(flagNum, newValue);
                return true;
            }
            
            return false;
        }
        
        /// <summary>Gives or (if sensible) takes away the item given by a given Mystery Data at the specified "level" (count of past-loop collections).</summary>
        /// <param name="flag">The flag corresponding to the Mystery Data.</param>
        /// <param name="collectionLevel">How many times this Mystery Data was collected in past loops.</param>
        /// <param name="give">Whether to give or take the item.</param>
        /// <param name="specifyMD">Whether to note the flag of the Mystery Data, for situations where multiple are being handled.</param>
        public bool giveOrTakeBN4MysteryDataForLoop(int flag, int collectionLevel, bool give = true, bool specifyMD = false)
        {
            string[] contents = BN4Definitions.getMysteryDataLoopContents(flag);
            if (contents.Length < 2) // No actual contents defined
                return false;
            
            int rewardIndex = 2 + collectionLevel;
            if (rewardIndex > contents.Length - 1) // Use last defined index repeatedly
                rewardIndex = contents.Length - 1;
            
            string itemString = contents[rewardIndex];
            string itemType = "";
            object itemArg1 = null;
            object itemArg2 = null;
            
            if (itemString.EndsWith("z"))
            {
                itemType = "zenny";
                int zennyValue = 0;
                if (int.TryParse(itemString.Substring(0, itemString.Length - 1), out zennyValue))
                    itemArg1 = zennyValue;
                else // If it fails to parse as number, continue searching
                    itemType = "";
            }
            else if (itemString.StartsWith("BugFrag"))
            {
                itemType = "bugfrag";
                int bugFragValue  = 0;
                if (int.TryParse(itemString.Substring(itemString.Length - 1), out bugFragValue))
                    itemArg1 = bugFragValue;
                else // If it fails to parse as number, there was probably a typo, but continue searching
                    itemType = "";
            }
            
            if (itemType == "") // Type not yet identified; try types that have a space
            {
                string[] spaceSplit = itemString.Split(' ');
                if (spaceSplit.Length == 2) // Contains exactly one space
                {
                    if (spaceSplit[1].Length == 1) // Second part is a single character: chip and code
                    {
                        itemType = "chip";
                        itemArg1 = spaceSplit[0];
                        itemArg2 = spaceSplit[1];
                    }
                    else // Second part is longer than one character: program and color
                    {
                        itemType = "program";
                        itemArg1 = spaceSplit[0];
                        itemArg2 = spaceSplit[1];
                    }
                }
            }
            
            if (itemType == "") // Type not yet identified; try checking against upgrade item names
            {
                string[] upgradeItemNames = getDef<string[]>("upgradeItemNames");
                for (int upgradeIndex = 0; upgradeIndex < upgradeItemNames.Length; upgradeIndex++)
                {
                    if (upgradeItemNames[upgradeIndex].Equals(itemString))
                    {
                        itemType = "upgrade";
                        itemArg1 = upgradeIndex;
                        break;
                    }
                }
            }
            
            if (itemType == "") // Type not yet identified; try checking against subchip names
            {
                string[] subchipNames = getDef<string[]>("subchipNames");
                for (int subchipIndex = 0; subchipIndex < subchipNames.Length; subchipIndex++)
                {
                    if (subchipNames[subchipIndex].Equals(itemString))
                    {
                        itemType = "subchip";
                        itemArg1 = subchipIndex;
                        break;
                    }
                }
            }
            
            if (itemType == "") // Type not yet identified; try checking against key item names
            {
                string[] keyItemNames = getDef<string[]>("keyItemNames");
                for (int keyItemIndex = 0; keyItemIndex < keyItemNames.Length; keyItemIndex++)
                {
                    if (keyItemNames[keyItemIndex].Equals(itemString))
                    {
                        itemType = "keyitem";
                        itemArg1 = keyItemIndex;
                        break;
                    }
                }
            }
            
            string mdDesc = "Mystery Data";
            if (specifyMD)
            {
                string[] mdDef = BN4Definitions.getMysteryDataLoopContents(flag);
                mdDesc = mdDef[1] + " " + mdDef[0];
            }
            string nthCollectionStr = (collectionLevel + 1)
                + (collectionLevel == 0 || (collectionLevel >= 20 && (collectionLevel + 1) % 10 == 1)? "st"
                 : collectionLevel == 1 || (collectionLevel >= 20 && (collectionLevel + 1) % 10 == 2)? "nd"
                 : collectionLevel == 2 || (collectionLevel >= 20 && (collectionLevel + 1) % 10 == 3)? "rd" : "th")
                + " level of " + mdDesc + ".";
            
            switch (itemType) // With type determined (or not, in which case nothing happens), now perform the giving/taking
            {
                case "zenny":
                    if (!give) // Kind of silly to take away Zenny that might have been spent
                        return false;
                    zenny = (uint)Math.Min(zenny + (int)itemArg1, 999999);
                    Console.WriteLine("Giving " + itemArg1 + " Zennys from " + nthCollectionStr);
                    return true;
                
                case "bugfrag":
                    if (!give) // Kind of silly to take away BugFrags that might have been spent
                        return false;
                    bugFrags = (uint)Math.Min(bugFrags + (int)itemArg1, 9999);
                    Console.WriteLine("Giving BugFrag x" + itemArg1 + " from " + nthCollectionStr);
                    return true;
                
                case "chip":
                    if (!give) // Kind of silly to take away chip that might be in a folder or given away
                        return false;
                    
                    int chipID = -1;
                    string[] chipNames = getDef<string[]>("chipNames");
                    for (int i = 0; i < chipNames.Length; i++)
                    {
                        if (chipNames[i].Equals(itemArg1 as string))
                        {
                            chipID = i;
                            break;
                        }
                    }
                    
                    if (chipID == -1)
                    {
                        Console.WriteLine("Chip with name of " + itemArg1 + " could not be found.");
                        return false;
                    }
                    
                    int codeIndex = -1;
                    string codes = getChipCodes(chipID);
                    for (int i = 0; i < codes.Length; i++)
                    {
                        if (codes[i].ToString().Equals(itemArg2 as string))
                        {
                            codeIndex = i;
                            break;
                        }
                    }
                    
                    if (codeIndex == -1)
                    {
                        Console.WriteLine("Code " + itemArg2 + " is not valid for chip " + itemArg1 + ".");
                        return false;
                    }
                    
                    pack[chipID].modifyQuantity(codeIndex, 1);
                    Console.WriteLine("Giving " + itemArg1 + " " + itemArg2 + " from " + nthCollectionStr);
                    return true;
                
                case "program":
                    if (!give) // Kind of silly to take away program that might be in use, and no programs given by Mystery Data are strictly limited
                        return false;
                    
                    int programID = -1;
                    string[] programNames = getDef<string[]>("programNames");
                    for (int i = 0; i < programNames.Length; i++)
                    {
                        if (programNames[i].Equals(itemArg1 as string))
                        {
                            programID = i;
                            break;
                        }
                    }
                    
                    if (programID == -1)
                    {
                        Console.WriteLine("Program with name of " + itemArg1 + " could not be found.");
                        return false;
                    }
                    
                    int colorIndex = -1;
                    string programColors = getDefIndex<string>("programColors", programID);
                    for (int i = 0; i < programColors.Length; i++)
                    {
                        if (programColors[i].Equals((itemArg2 as string)[0])) // For all programs found in MDs, just taking first letter works
                        {
                            colorIndex = i;
                            break;
                        }
                    }
                    
                    if (colorIndex == -1)
                    {
                        Console.WriteLine("Color " + itemArg2 + " is not valid for program " + itemArg1 + ".");
                        return false;
                    }
                    
                    int byteIndex = (programID * 4) + colorIndex;
                    programQuantities[byteIndex] = (byte)Math.Min(programQuantities[byteIndex] + 1, 9);
                    setItemVerifiedObtained(programID, "program", colorIndex);
                    Console.WriteLine("Giving " + itemArg1 + " (" + itemArg2 + ") from " + nthCollectionStr);
                    return true;
                
                case "subchip":
                    if (!give) // Kind of silly to take away SubChip that might have beeu used
                        return false;
                    
                    int subchipMax = getSubchipLimit();
                    subchipQuantities[(int)itemArg1] = (byte)Math.Min(subchipQuantities[(int)itemArg1] + 1, subchipMax);
                    setItemVerifiedObtained((int)itemArg1, "subchip");
                    Console.WriteLine("Giving " + itemString + " from " + nthCollectionStr);
                    return true;
                
                case "upgrade":
                    upgradeItemQuantities[(int)itemArg1] = (byte)Math.Max(Math.Min(upgradeItemQuantities[(int)itemArg1] + (give? 1 : -1), 255), 0);
                    if (give)
                        setItemVerifiedObtained((int)itemArg1, "upgrade");
                    
                    // If giving/taking HPMemory, update base HP accordingly.
                    if (getDefIndex<string>("upgradeItemNames", (int)itemArg1).Equals("HPMemory"))
                    {
                        bool hpMaxed = currentHP == overallMaxHP;
                        int hpPlus = overallMaxHP - baseMaxHP;
                        short hpChange = (short)(give? 20 : -20);
                        baseMaxHP = (ushort)Math.Max(baseMaxHP + hpChange, 1);
                        overallMaxHP = (ushort)(baseMaxHP + hpPlus);
                        if (hpMaxed)
                            currentHP = overallMaxHP;
                    }
                    
                    Console.WriteLine((give? "Giving " : "Taking away ") + itemString + " from " + nthCollectionStr);
                    return true;
                
                case "keyitem":
                    keyItemQuantities[(int)itemArg1] = (byte)Math.Max(Math.Min(keyItemQuantities[(int)itemArg1] + (give? 1 : -1), 255), 0);
                    if (give)
                        setItemVerifiedObtained((int)itemArg1);
                    Console.WriteLine((give? "Giving " : "Taking away ") + itemString + " from " + nthCollectionStr);
                    return true;
                
                default:
                    return false;
            }
        }
        
        /// <summary>For games that have extra verification on items being obtained, sets the given item as obtained.</summary>
        /// <param name="itemID">The ID of the item to set as obtained, relative to its type.</param>
        /// <param name="itemType">The item type. Default is key item, "upgrade" and "subchip" add offsets to get key-item-based ID.</param>
        /// <param name="itemSubID">An additional sub-ID for the item (used for program colors).</param>
        public void setItemVerifiedObtained(int itemID, string itemType = "", int itemSubID = 0)
        {
            if (game < 4)
                return;
            
            if (itemType != "")
            {
                List<string> keyItemNames = new List<string>(getDef<string[]>("keyItemNames"));
                if (itemType.ToLower().Equals("upgrade"))
                    itemID += keyItemNames.IndexOf(getDefIndex<string>("upgradeItemNames", 0)); // Offset by position of first upgrade item in key item list
                else if (itemType.ToLower().Equals("subchip")) // Offset by position of first SubChip in key item list
                    itemID += keyItemNames.IndexOf(getDefIndex<string>("subchipNames", 0));
                else if (itemType.ToLower().Equals("program")) // Set based on position of first program in key item list
                {
                    int firstProgramIndex = keyItemNames.IndexOf(getDefIndex<string>("programNames", 0) + " " + getDefIndex<string>("programColors", 0)[0]);
                    itemID = firstProgramIndex + (itemID * 4) + itemSubID;
                }
            }
            
            byte sourceValue = itemVerificationSource[itemID];
            byte trueValue = (byte)(sourceValue ^ (version == 'M'? 0x2C : 0x71));
            itemVerificationBytes[itemID] = trueValue;
        }
        
        /* BN4 TOURNAMENT SIMULATION FUNCTIONS */
        
        /// <summary>Initializes list of possible entrants for tournament in possibleTournamentEntrants using current tournament RNG seed.
        /// Inclusion of SoulNavis from other version depends on their presence in the WaitingRoom.
        /// Order (which affects which ones are actually encountered) can also differ depending on existing entrants list.</summary>
        /// <param name="tournamentNum">The number of the tournament (0 Den/City, 1 Eagle/Hawk, 2 Red Sun/Blue Moon).</param>
        /// <param name="affectFlags">Whether generation should actually change any flags, which is undesirable for temporary test generation.</param>
        /// <param name="forceCoinFlip">Pass 0 or 1 to force a specific outcome in the special Loop 2 Eagle/Hawk case.</param>
        /// <param name="desiredNextSoulNavi">Pass a SoulNavi ID to override normal ensure and put it in second spot, so it swaps into first slot next time.</param>
        /// <param name="desiredNextUnique">Pass a unique opponent ID to override normal behavior and ensure it is not in first spot, so it won't be de-prioritized next time.</param>
        /// <returns>Whether standard RNG was used (for one very specific case), making results not guaranteed but possible to soft-reset for.
        /// If desiredNextUnique is passed, it instead returns true if user rejects prompt to alter flags for other unique opponents, and false otherwise.</returns>
        public bool generatePossibleEntrantsList(int tournamentNum, bool affectFlags = false, int forceCoinFlip = -1, int desiredNextSoulNavi = -1, int desiredNextUnique = -1)
        {
            if (tournamentNum < 0 || tournamentNum > 2)
                return false;
            
            byte[] mySoulNaviList = null;
            byte[] myUniqueNaviList = null;
            byte[] myNormalNaviList = null;
            byte[] myHeelNaviList = null;
            switch (tournamentNum)
            {
                case 0:
                    mySoulNaviList = version == 'M'? new byte[] { 0x00, 0x01 } : new byte[] { 0x03, 0x02 };
                    myUniqueNaviList = version == 'M'? new byte[] { 0x0C, 0x0D, 0x02, 0x03 } : new byte[] { 0x0C, 0x0D, 0x00, 0x01 };
                    myNormalNaviList = new byte[] { 0x14, 0x16 };
                    myHeelNaviList = new byte[] { 0x15, 0x17 };
                    break;
                
                case 1:
                    mySoulNaviList = version == 'M'? new byte[] { 0x04, 0x05 } : new byte[] { 0x06, 0x07 };
                    myUniqueNaviList = version == 'M'? new byte[] { 0x10, 0x0F, 0x06, 0x07 } : new byte[] { 0x10, 0x0F, 0x04, 0x05 };
                    myNormalNaviList = new byte[] { 0x18, 0x1A };
                    myHeelNaviList = new byte[] { 0x19 };
                    break;
                
                case 2:
                    mySoulNaviList = version == 'M'? new byte[] { 0x08, 0x09 } : new byte[] { 0x0A, 0x0B };
                    myUniqueNaviList = version == 'M'? new byte[] { 0x11, 0x0E, 0x0A, 0x0B } : new byte[] { 0x11, 0x0E, 0x09, 0x08 };
                    myNormalNaviList = new byte[] { 0x1C };
                    myHeelNaviList = new byte[] { 0x1B, 0x1D };
                    break;
            }
            
            if (mySoulNaviList == null)
                return false;
            
            //Console.WriteLine("tournamentRandomSeed before generation (compare to 0x2001E98): " + tournamentRandomSeed.ToString("X2"));
            //Console.WriteLine("possibleTournamentEntrants before generation (compare to 0x20073A0):");
            //Console.WriteLine(M.printArrayHex(possibleTournamentEntrants));
            
            int offset = tournamentNum * 0xC;
            int OFFSET_SOUL1 = offset;
            int OFFSET_SOUL2 = offset + 1;
            int OFFSET_UNIQUE1 = offset + 2;
            int OFFSET_NORMAL1 = offset + 7;
            int OFFSET_NORMAL2 = offset + 8;
            int OFFSET_HEEL1 = offset + 9;
            int OFFSET_HEEL2 = offset + 10;
            
            bool standardRNGInvolved = false;
            
            // Phase 1: SoulNavis for version (00 and 01)
            // The SoulNavi put in the 00 slot here will (usually, but depends on layout) actually be fought, while the other will normally not.
            
            if (desiredNextSoulNavi != -1) // If doing seed-preparation setup, override to set specific order (desired SoulNavi in second spot so it gets swapped in)
            {
                byte desiredSoulIndex = (byte)(mySoulNaviList[0] == desiredNextSoulNavi? 0 : 1);
                byte otherSoulIndex = (byte)(1 - desiredSoulIndex);
                possibleTournamentEntrants[OFFSET_SOUL1] = mySoulNaviList[otherSoulIndex];
                possibleTournamentEntrants[OFFSET_SOUL2] = mySoulNaviList[desiredSoulIndex];
            }
            else if (possibleTournamentEntrants[offset] == 0xFF) // Not already defined by previous loop
            {
                if (flags[21]) // If flag 21 has been set (post-Tournament 1), put them in random order
                {
                    advanceRNG(ref tournamentRandomSeed);
                    byte whichFirst = (byte)(tournamentRandomSeed & 1);
                    possibleTournamentEntrants[OFFSET_SOUL1] = mySoulNaviList[whichFirst];
                    possibleTournamentEntrants[OFFSET_SOUL2] = mySoulNaviList[1 - whichFirst];
                }
                else // Forced setup for Loop 1 Tournament 1, use internal order (with GutsMan/AquaMan first)
                {
                    possibleTournamentEntrants[OFFSET_SOUL1] = mySoulNaviList[0];
                    possibleTournamentEntrants[OFFSET_SOUL2] = mySoulNaviList[1];
                }
            }
            else // Defined in a previous loop, so determine whether to swap existing order (usually it will, with one particular exception)
            {
                bool preventSwap = false;
                if (playthroughNumber == 1 && tournamentNum > 0 && !flags[155]) // Loop 2 Eagle/Hawk or Red Sun/Blue Moon, and "repeat SoulNavi" flag was not set
                {
                    bool nowIsTheTime = false;
                    if (tournamentNum == 1) // For Eagle/Hawk, use a standard RNG call to decide if now is the time to repeat SoulNavi from last loop
                    {
                        // In actual game, this uses standard constantly-changing RNG rather than tournament RNG, so note result as unreliable.
                        standardRNGInvolved = true;
                        if (forceCoinFlip == -1)
                        {
                            uint tempRNG = (uint)new Random((int)DateTime.Now.Ticks).Next();
                            advanceRNG(ref tempRNG);
                            nowIsTheTime = (tempRNG & 1) != 0;
                        }
                        else
                            nowIsTheTime = forceCoinFlip != 0;
                    }
                    else // For Red Sun/Blue Moon, do the repeat SoulNavi now since it wasn't done for Eagle/Hawk
                        nowIsTheTime = true;
                    
                    if (nowIsTheTime)
                    {
                        preventSwap = true;
                        if (affectFlags)
                            setFlag(155);
                    }
                }
                
                if (!preventSwap)
                    swapValues(ref possibleTournamentEntrants[OFFSET_SOUL1], ref possibleTournamentEntrants[OFFSET_SOUL2]);
            }
            
            // Phase 2: Other unique Navis (02 to 06)
            // The opponent put in the 02 slot here will (usually, but depends on layout) actually be fought, while the rest will normally not.
            
            // Initialize bytes that may not be filled, though keep 02 as a reference for which unique Navi got priority in previous loop (if there was one).
            byte previousPriorityID = possibleTournamentEntrants[OFFSET_UNIQUE1];
            for (int i = 3; i <= 6; i++)
                possibleTournamentEntrants[offset + i] = 0xFF;
            
            // Compile all available unique Navis in validUniquesList.
            List<byte> validUniquesList = new List<byte>();
            foreach (byte id in myUniqueNaviList)
            {
                bool okToAdd = true;
                
                if (id < 0xC) // IDs lower than 0C are SoulNavis, which require they be in WaitingRoom to be added
                {
                    okToAdd = false;
                    for (int waitingRoomIndex = 0; waitingRoomIndex + 1 < waitingRoomData.Length; waitingRoomIndex += 2)
                    {
                        if (waitingRoomData[waitingRoomIndex + 1] == id)
                        {
                            okToAdd = true;
                            break;
                        }
                    }
                }
                
                if (okToAdd)
                    validUniquesList.Add(id);
            }
            
            // Perform 1 to 3 swaps between random entries in validUniquesList.
            advanceRNG(ref tournamentRandomSeed);
            int swapCount = (int)(tournamentRandomSeed & 3);
            do
            {
                advanceRNG(ref tournamentRandomSeed);
                int randomIndex1 = (int)(tournamentRandomSeed & 7) % validUniquesList.Count;
                int randomIndex2 = (randomIndex1 + 1) & (validUniquesList.Count - 1);
                swapListValues(ref validUniquesList, randomIndex1, randomIndex2);
                swapCount--;
            } while (swapCount > 0);
            
            // Sort validUniquesList into those that have been selected in past tournaments and those that haven't.
            List<byte> newUniquesList = new List<byte>();
            List<byte> oldUniquesList = new List<byte>();
            
            foreach (byte id in validUniquesList)
            {
                if (!flags[1 + id]) // Flag for being selected before is not set, so place in list of new opponents to prioritize
                    newUniquesList.Add(id);
                else // Selected in past, so place in list of old opponents with lower priority
                    oldUniquesList.Add(id);
            }
            
            // Find an entrant to prioritize, favoring new ones that haven't been fought before.
            byte priorityID = 0xFF;
            foreach (byte newUniqueID in newUniquesList)
            {
                // If this matches with one of the latter two in uniques list (SoulNavis from other version), go with that.
                for (int otherVersionSoulIndex = 2; otherVersionSoulIndex < 4; otherVersionSoulIndex++)
                {
                    if (myUniqueNaviList[otherVersionSoulIndex] == newUniqueID)
                    {
                        priorityID = newUniqueID;
                        break;
                    }
                }
                
                if (priorityID != 0xFF)
                    break;
            }
            
            if (priorityID == 0xFF) // If no other-version SoulNavis in newUniquesList, use the first one from newUniquesList
            {
                if (newUniquesList.Count > 0)
                    priorityID = newUniquesList[0];
            }
            
            if (priorityID == 0xFF) // newUniquesList is empty (all possibilities have been encountered before), so take from oldUniquesList instead
            {
                if (oldUniquesList[0] != previousPriorityID) // Index 0 not the same one given priority from last time, so use that
                    priorityID = oldUniquesList[0];
                else // Use index 1 to be different from last time
                    priorityID = oldUniquesList[1];
            }
            
            // Find an entrant to give lowest priority.
            byte nonPriorityID = 0xFF;
            if (previousPriorityID != 0xFF) // Unique selection from past loop is defined, so de-prioritize that if it's part of current valid list
            {
                foreach (byte id in validUniquesList)
                {
                    if (id == previousPriorityID)
                    {
                        nonPriorityID = previousPriorityID;
                        break;
                    }
                }
            }
            
            // If past priority not defined or not found in valid entrants list, default to index 1 in newUniquesList.
            if (nonPriorityID == 0xFF && newUniquesList.Count > 1)
                nonPriorityID = newUniquesList[1];
            
            // Assign the priority and non-priority entrants to first and last index.
            possibleTournamentEntrants[OFFSET_UNIQUE1] = priorityID;
            possibleTournamentEntrants[OFFSET_UNIQUE1 + (validUniquesList.Count - 1)] = nonPriorityID;
            
            // Fill the middle with the other valid entrants.
            int finalFillIndex = 3;
            foreach (byte id in validUniquesList)
            {
                if (id != priorityID && id != nonPriorityID)
                {
                    possibleTournamentEntrants[offset + finalFillIndex] = id;
                    finalFillIndex++;
                }
            }
            
            // If doing seed-preparation setup, override original behavior to ensure desired unique for next time.
            if (desiredNextUnique != -1)
            {
                // If in the "selected last time" spot that de-prioritizes it next time, swap it out of there.
                if (possibleTournamentEntrants[OFFSET_UNIQUE1] == desiredNextUnique)
                    swapValues(ref possibleTournamentEntrants[OFFSET_UNIQUE1], ref possibleTournamentEntrants[OFFSET_UNIQUE1 + 1]);
                
                // If not an other-version SoulNavi, check if there are available SoulNavis that will be picked over this one unless something is done.
                if (desiredNextUnique >= 0x0C)
                {
                    List<int> higherPriorityIDs = new List<int>();
                    for (int otherVersionSoulIndex = 2; otherVersionSoulIndex < 4; otherVersionSoulIndex++)
                    {
                        byte otherVersionSoulID = myUniqueNaviList[otherVersionSoulIndex];
                        if (otherVersionSoulID == desiredNextUnique)
                            continue;
                        
                        if (validUniquesList.Contains(otherVersionSoulID) && !flags[1 + otherVersionSoulID])
                            higherPriorityIDs.Add(otherVersionSoulID);
                    }
                    
                    if (higherPriorityIDs.Count > 0)
                    {
                        string myName = BN4Definitions.tournamentEntrantData[desiredNextUnique][0];
                        bool plural = higherPriorityIDs.Count > 0;
                        string pluralS = plural? "s" : "";
                        
                        Console.WriteLine((plural? "Other opponents are" : "Another opponent is") + " precluding " + myName + " from being selected.\n"
                            + "SoulNavis from the other version currently in the WaitingRoom will normally\n"
                            + "be selected over other unique Navis, unless they were selected in the past.");
                        Console.WriteLine();
                        
                        Console.Write("Opponents that currently have higher priority: ");
                        for (int i = 0; i < higherPriorityIDs.Count; i++)
                            Console.Write((i > 0? ", " : "") + BN4Definitions.tournamentEntrantData[higherPriorityIDs[i]][0]);
                        Console.WriteLine();
                        Console.WriteLine();
                        
                        ConsoleC.WriteLineHL("This can be resolved in two different ways:\n"
                            + "{[A]} Remove the prioritized SoulNavi" + pluralS + " from the WaitingRoom.\n"
                            + "{[B]} Set flag" + pluralS + " for SoulNavi" + pluralS + " having been selected in a past tournament.\n"
                            + "{NOTE:} Choosing B will cause them to not be picked by normal board generation\n"
                            + "until ALL available opponents in the \"unique\" group have had that flag set,\n"
                            + "unless you edit to save to unset the flag" + pluralS + " afterward.");
                        Console.WriteLine();
                        
                        Console.WriteLine("Type A or B to choose a resolution method, or nothing to abort.");
                        
                        string otherFlagsPrompt = M.getTypedInput().ToUpper();
                        Console.WriteLine();
                        if (otherFlagsPrompt == "A") // Blank any WaitingRoom entries that match affected opponents
                        {
                            for (int i = 0; i + 1 < waitingRoomData.Length; i += 2)
                            {
                                if (higherPriorityIDs.Contains(waitingRoomData[i + 1]))
                                    setWaitingRoomNavi(i / 2, 0xFF);
                            }
                        }
                        else if (otherFlagsPrompt == "B") // Set selected flags for affected opponents
                        {
                            foreach (byte id in higherPriorityIDs)
                                setFlag(1 + id);
                        }
                        else
                            return true; // Signal to cancel search, since standardRNGInvolved is never true when using this function for seed-preparation setup
                    }
                }
            }
            
            // Set flag for the unique entrant that was prioritized this time.
            if (affectFlags)
                setFlag(1 + priorityID);
            
            // Phase 3: NormalNavis (07 and 08)
            // The first NormalNavi in the list may (depending on layout) be fought, while the other (which is visual filler in all tournaments) will normally not.
            
            possibleTournamentEntrants[OFFSET_NORMAL1] = myNormalNaviList[0];
            if (myNormalNaviList.Length > 1)
                possibleTournamentEntrants[OFFSET_NORMAL2] = myNormalNaviList[1];
            
            // Phase 4: HeelNavis (09 and 0A)
            // The first HeelNavi in the list may (depending on layout) be fought, while the other (which is visual filler in all tournaments) will normally not.
            
            possibleTournamentEntrants[OFFSET_HEEL1] = myHeelNaviList[0];
            if (myHeelNaviList.Length > 1)
                possibleTournamentEntrants[OFFSET_HEEL2] = myHeelNaviList[1];
            
            //Console.WriteLine("New possibleTournamentEntrants (compare to 0x20073A0):");
            //Console.WriteLine(M.printArrayHex(possibleTournamentEntrants));
            
            return standardRNGInvolved;
        }
        
        /// <summary>Generates tournament board data using list in possibleTournamentEntrants and current tournament RNG seed.
        /// Generation will be locked to a specific type if flag 21 is not set; this is used to guarantee GutsMan/AquaMan on Loop 1.</summary>
        /// <param name="tournamentNum">The number of the tournament (0 Den/City, 1 Eagle/Hawk, 2 Red Sun/Blue Moon).</param>
        public void generateTournamentBoard(int tournamentNum)
        {
            if (tournamentNum < 0 || tournamentNum > 2)
                return;
            
            byte[] prioritiesByPossibleIndex = new byte[] {
                00, // SoulNavi 1
                01, // SoulNavi 2
                00, // Unique Navi 1
                01, // Unique Navi 2
                02, // Unique Navi 3
                03, // Unique Navi 4
                04, // Unique Navi 5
                00, // NormalNavi 1
                01, // NormalNavi 2
                00, // HeelNavi 1
                01, // HeelNavi 2
                00, // Extras just in case
                00,
                00
            };
            
            int offset = tournamentNum * 0xC;
            int OFFSET_SOUL1 = offset;
            int OFFSET_SOUL2 = offset + 1;
            int OFFSET_UNIQUE1 = offset + 2;
            int OFFSET_NORMAL1 = offset + 7;
            int OFFSET_HEEL1 = offset + 9;
            
            // Set up lists for "left" and "right" sides of the bracket (sides may be swapped in final layout, but it doesn't have a material effect).
            // The two added to leftBracket here become the Round 1 and 2 opponents. For cases that add two to bracketRight, Round 3 is a 50-50 between them.
            // However, in the cases where only one "Round 3 candidate" is added, the top-priority opponent of the unchosen category may beat them.
            List<byte> bracketLeft = new List<byte>();
            List<byte> bracketRight = new List<byte>();
            
            // Always include MegaMan (1E) on the left side.
            bracketLeft.Add(0x1E);
            
            if (flags[21]) // Select a random layout as normal after Loop 1 Tournament 1
            {
                advanceRNG(ref tournamentRandomSeed);
                byte randomLayout = (byte)(tournamentRandomSeed & 3);
                if (randomLayout == 0) // Opponents will be Unique 1, NormalNavi/HeelNavi, and SoulNavi 1 or HeelNavi/NormalNavi
                {
                    bracketLeft.Add(possibleTournamentEntrants[OFFSET_UNIQUE1]); // Round 1: Unique 1
                    advanceRNG(ref tournamentRandomSeed);
                    if ((tournamentRandomSeed & 1) == 0)
                    {
                        bracketLeft.Add(possibleTournamentEntrants[OFFSET_NORMAL1]); // Round 2: Normal 1
                        bracketRight.Add(possibleTournamentEntrants[OFFSET_SOUL1]); // Round 3 (50-50): Soul 1
                        bracketRight.Add(possibleTournamentEntrants[OFFSET_HEEL1]); // Round 3 (50-50): Heel 1
                    }
                    else
                    {
                        bracketLeft.Add(possibleTournamentEntrants[OFFSET_HEEL1]); // Round 2: Heel 1
                        bracketRight.Add(possibleTournamentEntrants[OFFSET_SOUL1]); // Round 3 (50-50): Soul 1
                        bracketRight.Add(possibleTournamentEntrants[OFFSET_NORMAL1]); // Round 3 (50-50): Normal 1
                    }
                }
                else if (randomLayout == 1) // Opponents will be SoulNavi 1, NormalNavi/HeelNavi, and Unique 1 or HeelNavi/NormalNavi
                {
                    bracketLeft.Add(possibleTournamentEntrants[OFFSET_SOUL1]); // Round 1: Soul 1
                    advanceRNG(ref tournamentRandomSeed);
                    if ((tournamentRandomSeed & 1) == 0)
                    {
                        bracketLeft.Add(possibleTournamentEntrants[OFFSET_NORMAL1]); // Round 2: Normal 1
                        bracketRight.Add(possibleTournamentEntrants[OFFSET_UNIQUE1]); // Round 3 (50-50): Unique 1
                        bracketRight.Add(possibleTournamentEntrants[OFFSET_HEEL1]); // Round 3 (50-50): Heel 1
                    }
                    else
                    {
                        bracketLeft.Add(possibleTournamentEntrants[OFFSET_HEEL1]); // Round 2: Heel 1
                        bracketRight.Add(possibleTournamentEntrants[OFFSET_UNIQUE1]); // Round 3 (50-50): Unique 1
                        bracketRight.Add(possibleTournamentEntrants[OFFSET_NORMAL1]); // Round 3 (50-50): Normal 1
                    }
                }
                else if (randomLayout == 2) // Opponents will be NormalNavi, Unique/SoulNavi 1, and (possibly) SoulNavi/Unique 1
                {
                    bracketLeft.Add(possibleTournamentEntrants[OFFSET_NORMAL1]); // Round 1: Normal 1
                    advanceRNG(ref tournamentRandomSeed);
                    if ((tournamentRandomSeed & 1) == 0)
                    {
                        bracketLeft.Add(possibleTournamentEntrants[OFFSET_UNIQUE1]); // Round 2: Unique 1
                        bracketRight.Add(possibleTournamentEntrants[OFFSET_SOUL1]); // Round 3 candidate: Soul 1
                    }
                    else
                    {
                        bracketLeft.Add(possibleTournamentEntrants[OFFSET_SOUL1]); // Round 2: Soul 1
                        bracketRight.Add(possibleTournamentEntrants[OFFSET_UNIQUE1]); // Round 3 candidate: Unique 1
                    }
                    // No second Round 3 candidate given, but in practice it should be the unchosen Heel 1
                }
                else // Opponents will be HeelNavi, Unique/SoulNavi 1, and (possibly) SoulNavi/Unique 1
                {
                    bracketLeft.Add(possibleTournamentEntrants[OFFSET_HEEL1]); // Round 1: Heel 1
                    advanceRNG(ref tournamentRandomSeed);
                    if ((tournamentRandomSeed & 1) == 0)
                    {
                        bracketLeft.Add(possibleTournamentEntrants[OFFSET_UNIQUE1]); // Round 2: Unique 1
                        bracketRight.Add(possibleTournamentEntrants[OFFSET_SOUL1]); // Round 3 candidate: Soul 1
                    }
                    else
                    {
                        bracketLeft.Add(possibleTournamentEntrants[OFFSET_SOUL1]); // Round 2: Soul 1
                        bracketRight.Add(possibleTournamentEntrants[OFFSET_UNIQUE1]); // Round 3 candidate: Unique 1
                    }
                    // No second Round 3 candidate given, but in practice it should be the unchosen Normal 1
                }
            }
            else // Forced setup for Loop 1 Tournament 1
            {
                advanceRNG(ref tournamentRandomSeed);
                if ((tournamentRandomSeed & 1) == 0)
                    bracketLeft.Add(possibleTournamentEntrants[OFFSET_HEEL1]); // Round 1: Heel 1
                else
                    bracketLeft.Add(possibleTournamentEntrants[OFFSET_NORMAL1]); // Round 1: Normal 1
                bracketLeft.Add(possibleTournamentEntrants[OFFSET_SOUL1]); // Round 2: Soul 1
                bracketRight.Add(possibleTournamentEntrants[OFFSET_UNIQUE1]); // Round 3 candidate: Unique 1
            }
            
            // break 0x080443de
            //Console.WriteLine("bracketLeft/bracketRight before adding filler (at 0x080443de, 0x200ACCC):");
            //Console.WriteLine(M.printArrayHex(bracketLeft.ToArray()) + " " + M.printArrayHex(bracketRight.ToArray()));
            
            // Create a list of low-priority opponents that can fill the fourth spot on the left side of the bracket.
            List<byte> leftSideFillerCandidates = new List<byte>();
            leftSideFillerCandidates.Add(possibleTournamentEntrants[OFFSET_SOUL2]); // Soul 2
            
            // Go through Uniques 2-6 (avoid Unique 1, which is already in bracket in all cases) in reverse order and add first non-FF.
            for (int fillerSearchIndex = 6; fillerSearchIndex >= 3; fillerSearchIndex--)
            {
                if (possibleTournamentEntrants[offset + fillerSearchIndex] == 0xFF)
                    continue;
                leftSideFillerCandidates.Add(possibleTournamentEntrants[offset + fillerSearchIndex]);
                break;
            }
            
            // Go through NormalNavis in reverse order and add first non-FF that is not already in bracket.
            for (int fillerSearchIndex = 8; fillerSearchIndex >= 7; fillerSearchIndex--)
            {
                if (possibleTournamentEntrants[offset + fillerSearchIndex] == 0xFF)
                    continue;
                if (bracketLeft.Contains(possibleTournamentEntrants[offset + fillerSearchIndex]) || bracketRight.Contains(possibleTournamentEntrants[offset + fillerSearchIndex]))
                    continue;
                leftSideFillerCandidates.Add(possibleTournamentEntrants[offset + fillerSearchIndex]);
                break;
            }
            
            // Go through HeelNavis in reverse order and add first non-FF that is not already in bracket.
            for (int fillerSearchIndex = 10; fillerSearchIndex >= 9; fillerSearchIndex--)
            {
                if (possibleTournamentEntrants[offset + fillerSearchIndex] == 0xFF)
                    continue;
                if (bracketLeft.Contains(possibleTournamentEntrants[offset + fillerSearchIndex]) || bracketRight.Contains(possibleTournamentEntrants[offset + fillerSearchIndex]))
                    continue;
                leftSideFillerCandidates.Add(possibleTournamentEntrants[offset + fillerSearchIndex]);
                break;
            }
            
            // break 0x08044422
            //Console.WriteLine("leftSideFillerCandidates (at 0x08044422, 0x200ACD4):");
            //Console.WriteLine(M.printArrayHex(leftSideFillerCandidates.ToArray()));
            
            // Pick a random opponent from filler list to add to left side of bracket, bringing it to a complete 4.
            byte topBitOfOldRNG = (byte)(tournamentRandomSeed >> 31);
            advanceRNG(ref tournamentRandomSeed);
            byte randomIndex = (byte)(tournamentRandomSeed & 7);
            while (randomIndex > topBitOfOldRNG) // Was likely meant to use leftSideFillerOptions.Count, but this is how the original code works in practice
            {
                randomIndex--;
                randomIndex -= topBitOfOldRNG;
            }
            
            bracketLeft.Add(leftSideFillerCandidates[randomIndex]);
            
            // Make another filler list with everything from possible entrants list that isn't already in bracket.
            List<byte> fillerOpponents = new List<byte>();
            for (int possibleEntrantsIndex = 0; possibleEntrantsIndex <= 10; possibleEntrantsIndex++)
            {
                byte possibleID = possibleTournamentEntrants[offset + possibleEntrantsIndex];
                if (possibleID == 0xFF)
                    continue;
                if (bracketLeft.Contains(possibleID) || bracketRight.Contains(possibleID))
                    continue;
                fillerOpponents.Add(possibleID);
            }
            
            // break 0x08044472
            //Console.WriteLine("fillerOpponents before 5 random swaps (at 0x08044472, 0x200ACD4):");
            //Console.WriteLine(M.printArrayHex(fillerOpponents.ToArray()));
            
            // Perform 5 random swaps within filler list.
            int swapCount = 5;
            do
            {
                advanceRNG(ref tournamentRandomSeed);
                byte swapIndexA = (byte)(tournamentRandomSeed & 7);
                while (swapIndexA > fillerOpponents.Count - 1)
                {
                    swapIndexA--;
                    swapIndexA -= (byte)(fillerOpponents.Count - 1);
                }
                
                byte swapIndexB = (byte)(swapIndexA + 1);
                while (swapIndexB > fillerOpponents.Count - 1)
                {
                    swapIndexB--;
                    swapIndexB -= (byte)(fillerOpponents.Count - 1);
                }
                
                swapListValues(ref fillerOpponents, swapIndexA, swapIndexB);
                swapCount--;
            } while (swapCount > 0);
            
            // Starting from a random point in filler list (and wrapping around), copy to fill right side of bracket.
            advanceRNG(ref tournamentRandomSeed);
            byte copyFromFillerIndex = (byte)(tournamentRandomSeed & 7);
            while (copyFromFillerIndex > fillerOpponents.Count - 1)
            {
                copyFromFillerIndex--;
                copyFromFillerIndex -= (byte)(fillerOpponents.Count - 1);
            }
            
            while (bracketRight.Count < 4)
            {
                if (fillerOpponents[copyFromFillerIndex] != 0xFF)
                    bracketRight.Add(fillerOpponents[copyFromFillerIndex]);
                copyFromFillerIndex = (byte)((copyFromFillerIndex + 1) % fillerOpponents.Count);
            }
            
            // break 0x080444d8
            //Console.WriteLine("tournamentRandomSeed before final swaps (at 0x080444d8, 0x2001E98): " + tournamentRandomSeed.ToString("X2"));
            //Console.WriteLine("Bracket before making immaterial swaps (at 0x080444d8, 0x200ACCC):");
            //Console.WriteLine(M.printArrayHex(bracketLeft.ToArray()) + " " + M.printArrayHex(bracketRight.ToArray()));
            
            // Perform random swaps in the bracket that have no actual effect except to make things look more varied.
            
            // First, randomly swap or don't swap each Round 1 pair.
            advanceRNG(ref tournamentRandomSeed);
            uint shiftingSeed = tournamentRandomSeed;
            
            for (int bracketSwapIndex = 0; bracketSwapIndex < 4; bracketSwapIndex += 2)
            {
                if ((shiftingSeed & 1) != 0)
                    swapListValues(ref bracketLeft, bracketSwapIndex, bracketSwapIndex + 1);
                shiftingSeed = shiftingSeed >> 4;
            }
            for (int bracketSwapIndex = 0; bracketSwapIndex < 4; bracketSwapIndex += 2)
            {
                if ((shiftingSeed & 1) != 0)
                    swapListValues(ref bracketRight, bracketSwapIndex, bracketSwapIndex + 1);
                shiftingSeed = shiftingSeed >> 4;
            }
            
            // break 0x080444fe
            //Console.WriteLine("Bracket after Round 1 pair swaps (at 0x080444fe, 0x200ACCC):");
            //Console.WriteLine(M.printArrayHex(bracketLeft.ToArray()) + " " + M.printArrayHex(bracketRight.ToArray()));
            
            // Second, randomly swap or don't swap the pairs within each side of the bracket.
            advanceRNG(ref tournamentRandomSeed);
            if ((tournamentRandomSeed & 1) == 0)
            {
                swapListValues(ref bracketLeft, 0, 2);
                swapListValues(ref bracketLeft, 1, 3);
            }
            
            // For some reason pairs in right side are just always swapped rather than it being random - probably not intentional, but whatever.
            swapListValues(ref bracketRight, 0, 2);
            swapListValues(ref bracketRight, 1, 3);
            
            // break 0x08044538
            //Console.WriteLine("Bracket after within-side swaps (at 0x08044538, 0x200ACCC):");
            //Console.WriteLine(M.printArrayHex(bracketLeft.ToArray()) + " " + M.printArrayHex(bracketRight.ToArray()));
            
            // Finally, randomly decide whether to swap which side of the bracket is which.
            advanceRNG(ref tournamentRandomSeed);
            bool bracketLeftRightSwap = (tournamentRandomSeed & 1) == 0;
            
            // Set up tournament board data using the final bracket.
            int entrantIndex = 0;
            for (int bracketSide = 0; bracketSide < 2; bracketSide++)
            {
                List<byte> currentSide = bracketSide == 0? (!bracketLeftRightSwap? bracketLeft : bracketRight)
                                                         : (!bracketLeftRightSwap? bracketRight : bracketLeft);
                foreach (byte id in currentSide)
                {
                    byte priority = 0x00;
                    if (id == 0x1E) // MegaMan
                        priority = 0x00;
                    else // Look for where ID is in possible entrants index and assign associated priority
                    {
                        for (int possibleEntrantsIndex = 0; possibleEntrantsIndex < 0xC; possibleEntrantsIndex++)
                        {
                            if (possibleTournamentEntrants[offset + possibleEntrantsIndex] == id)
                                priority = prioritiesByPossibleIndex[possibleEntrantsIndex];
                        }
                    }
                    
                    tournamentBoards[tournamentNum][entrantIndex] = new TournamentEntrant(id, 0x40, priority, 0x00);
                    entrantIndex++;
                }
            }
            
            /*Console.WriteLine("Mew tournament board data (compare to 0x2001460):");
            for (int i = 0; i < tournamentBoards[tournamentNum].Length; i++)
                Console.Write((i > 0? (i % 4 == 0? "\n" : " ") : "") + tournamentBoards[tournamentNum][i].getBytesString());
            Console.WriteLine();
            Console.WriteLine("tournamentRandomSeed after generation (compare to 0x2001E98): " + tournamentRandomSeed.ToString("X2"));
            M.waitForEnter();*/
        }
        
        /// <summary>Takes the given RNG seed and advances it pseudo-randomly.</summary>
        /// <param name="rngSeed">The current RNG seed.</param>
        public static uint advanceRNG(ref uint rngSeed)
        {
            uint leftShift = rngSeed << 1;
            uint highestBit = rngSeed >> 31;
            rngSeed = leftShift + highestBit; // Highest bit loops around to lowest bit
            rngSeed++;
            rngSeed ^= 0x873CA9E5;
            return rngSeed;
        }
        
        /// <summary>Tests generating boards with different tournament RNG seeds to set up a seed that will have the desired opponents.</summary>
        /// <param name="tournamentNum">The number of the tournament (0 Den/City, 1 Eagle/Hawk, 2 Red Sun/Blue Moon).</param>
        /// <param name="desiredOpponents">A list of desired opponents.</param>
        /// <param name="desiredFirstRound">Whether the desired opponent (should only be one if true) should be in the first round rather than just any round.</param>
        /// <param name="newBoardOpponents">Result list that gives the order of opponents in the generated board.</param>
        /// <returns><para>A string indicating the result of the function.</para>
        /// <para>"success": Successfully found a matching seed and passed other variables by reference. If result required a certain 50-50 using standard RNG, appends "?".
        /// If a Navi was added to the WaitingRoom, also appends "#" followed by the name.</para>
        /// <para>"basicImpossible-X": Impossible for fundamental reasons of requesting too many of one opponent type.
        /// Ends with "-soul/unique/normal/heel" depending on the type.</para>
        /// <para>"abort": Aborted due to user choosing not to go through with changes required to make generation possible.</para>
        /// <para>"searchCancel-manual": User manually aborted the seed search.</para>
        /// <para>"searchCancel-auto": Automatically cancelled seed search due to looping all the way around.</para></returns>
        public string prepareTournamentSeed(int tournamentNum, List<int> desiredOpponents, bool desiredFirstRound, ref List<int> newBoardOpponents)
        {
            // Before trying anything, check if request is outright impossible.
            int soulNaviCount = 0;
            int uniqueNaviCount = 0;
            int normalNaviCount = 0;
            int heelNaviCount = 0;
            foreach (int desiredOpponent in desiredOpponents)
            {
                string[] def = BN4Definitions.tournamentEntrantData[desiredOpponent];
                if (def.Length > 5 && def[5].Equals(version == 'M'? "RS Soul" : "BM Soul"))
                    soulNaviCount++;
                if (def.Length > 5 && def[5].Equals(version == 'M'? "BM Soul" : "RS Soul"))
                    uniqueNaviCount++;
                if (desiredOpponent >= 0x0C && desiredOpponent <= 0x11)
                    uniqueNaviCount++;
                if (desiredOpponent >= 0x14 && desiredOpponent % 2 == 0)
                    normalNaviCount++;
                if (desiredOpponent >= 0x15 && desiredOpponent % 2 != 0)
                    heelNaviCount++;
            }
            
            if (soulNaviCount > 1)
                return "basicImpossible-soul";
            if (uniqueNaviCount > 1)
                return "basicImpossible-unique";
            if (normalNaviCount > 1)
                return "basicImpossible-normal";
            if (heelNaviCount > 1)
                return "basicImpossible-heel";
            
            // Back up everything that might be changed in process of seeking a seed.
            uint oldSeed = tournamentRandomSeed;
            bool[] oldFlags = (bool[])flags.Clone();
            byte[] oldWaitingRoom = (byte[])waitingRoomData.Clone();
            byte[] oldPossibles = (byte[])possibleTournamentEntrants.Clone();
            TournamentEntrant[] oldBoard = (TournamentEntrant[])tournamentBoards[tournamentNum].Clone();
            
            // Best to just set flag 21 if it wasn't already to enable full range of random layout selections.
            setFlag(21);
            
            // For Loop 2 Eagle/Sun and RS/BM, best to set the "did repeat" flag so it doesn't have to worry about possibly skipping the SoulNavi swap.
            if (playthroughNumber == 1 && tournamentNum > 0)
                setFlag(155);
            
            // Check for opponents that would require further changes to be possible to generate.
            string waitingRoomAddition = "";
            int waitingRoomReplaceSlot = 0;
            int desiredSoulNavi = -1;
            int desiredUnique = -1;
            foreach (int desiredOpponent in desiredOpponents)
            {
                string[] def = BN4Definitions.tournamentEntrantData[desiredOpponent];
                
                bool isSoul = desiredOpponent <= 0x0B;
                bool isSameVersionSoul = def.Length > 5 && def[5].Equals(version == 'M'? "RS Soul" : "BM Soul");
                bool isUnique = desiredOpponent >= 0x0C && desiredOpponent <= 0x11;
                
                // If it's a SoulNavi from other version, ensure they're present in WaitingRoom.
                if (isSoul && !isSameVersionSoul)
                {
                    isUnique = true;
                    
                    bool isInWaitingRoom = false;
                    for (int i = 0; i + 1 < waitingRoomData.Length; i += 2)
                    {
                        if (waitingRoomData[i + 1] == desiredOpponent)
                        {
                            isInWaitingRoom = true;
                            break;
                        }
                    }
                    
                    if (!isInWaitingRoom)
                    {
                        bool filledEmptySlot = false;
                        for (int i = 0; i + 1 < waitingRoomData.Length; i += 2)
                        {
                            if (waitingRoomData[i + 1] == 0xFF)
                            {
                                setWaitingRoomNavi(i / 2, (byte)desiredOpponent);
                                filledEmptySlot = true;
                                break;
                            }
                        }
                        
                        if (!filledEmptySlot) // All slots full, so replace one
                        {
                            setWaitingRoomNavi(waitingRoomReplaceSlot, (byte)desiredOpponent);
                            waitingRoomReplaceSlot++;
                        }
                        
                        waitingRoomAddition = getTournamentEntrantString(desiredOpponent, "navi");
                    }
                }
                
                if (isSameVersionSoul) // Set up pre-existing entrants list to accomodate getting this SoulNavi
                    desiredSoulNavi = desiredOpponent;
                
                if (isUnique) // For unique Navis, ensure flag for being selected in the past is unset so they go in priority group
                {
                    setFlag(1 + desiredOpponent, false);
                    desiredUnique = desiredOpponent; // Also, set up pre-existing entrants list to accomodate getting this unique Navi
                }
            }
            
            // If a particular SoulNavi or unique is desired, set up a pre-existing entrants list tailored to enable this.
            if (desiredSoulNavi != -1 || desiredUnique != -1)
            {
                bool abort = generatePossibleEntrantsList(tournamentNum, desiredNextSoulNavi: desiredSoulNavi, desiredNextUnique: desiredUnique);
                tournamentRandomSeed = oldSeed;
                if (abort) // Got prompted about unique selection flags and chose no
                {
                    flags = (bool[])oldFlags.Clone();
                    waitingRoomData = (byte[])oldWaitingRoom.Clone();
                    return "abort";
                }
            }
            
            byte[] postFixPossibles = (byte[])possibleTournamentEntrants.Clone();
            
            // Begin generating boards with different seeds until one meeting conditions is found.
            uint seedForBoard = 0;
            newBoardOpponents = null;
            bool standardRNGInvolved = false;
            ulong seedsTried = 0;
            ulong attemptThreshold = 100000;
            string cancelSearch = "";
            do
            {
                bool success = false;
                int coinFlip = 0;
                do
                {
                    seedForBoard = tournamentRandomSeed;
                    standardRNGInvolved = generatePossibleEntrantsList(tournamentNum, forceCoinFlip: coinFlip);
                    generateTournamentBoard(tournamentNum);
                    newBoardOpponents = new List<int>(getTournamentOpponentIDs(tournamentNum));
                    
                    // Reset possible entrants list and board after getting opponents; they influence outcome, and goal is not to actually change them.
                    // However, use postFixPossibles, since a certain pre-existing possible entrants list setup may be required.
                    possibleTournamentEntrants = (byte[])postFixPossibles.Clone();
                    tournamentBoards[tournamentNum] = (TournamentEntrant[])oldBoard.Clone();
                    
                    if (desiredFirstRound && newBoardOpponents[0] == desiredOpponents[0]) // Specifically Round 1
                    {
                        success = true;
                        break;
                    }
                    else if (!desiredFirstRound) // In any round
                    {
                        success = true;
                        foreach (int id in desiredOpponents)
                        {
                            if (!newBoardOpponents.Contains(id))
                            {
                                success = false;
                                break;
                            }
                        }
                        if (success)
                            break;
                    }
                    
                    if (standardRNGInvolved && coinFlip < 1) // For the special case where standard RNG decides SoulNavi order, try again with other outcome
                        coinFlip = 1;
                    else // In normal case, or if both ways were tried, stop there
                        break;
                } while (true);
               
                if (success)
                    break;
                
                seedsTried++;
                if (seedsTried == attemptThreshold)
                {
                    if (attemptThreshold == 100000)
                        Console.WriteLine("Tried " + seedsTried + " seeds to no avail; likely impossible. Press X key to stop.");
                    else
                        Console.WriteLine("Still trying (" + seedsTried + " attempts)... Press X key to stop.");
                    attemptThreshold += 100000;
                }
                
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.X)
                    {
                        cancelSearch = "searchCancel-manual";
                        break;
                    }
                }
                
                // Advance the seed used this time and try again.
                tournamentRandomSeed = seedForBoard;
                advanceRNG(ref tournamentRandomSeed);
                if (tournamentRandomSeed == oldSeed) // However, stop if it winds up at the starting seed again, as from there it would just loop
                {
                    cancelSearch = "searchCancel-auto";
                    break;
                }
            } while (cancelSearch == "");
            
            if (cancelSearch != "") // Revert anything that was changed if process was cancelled
            {
                tournamentRandomSeed = oldSeed;
                flags = (bool[])oldFlags.Clone();
                waitingRoomData = (byte[])oldWaitingRoom.Clone();
                // possibleTournamentEntrants and tournamentBoards[tournamentNum] are already reset after every generation
                return cancelSearch;
            }
            
            tournamentRandomSeed = seedForBoard;
            return "success" + (standardRNGInvolved? "?" : "") + (waitingRoomAddition != ""? "#" + waitingRoomAddition : "");
        }
        
        /// <summary>From a starting tournament board, determine what three opponents will be encountered.</summary>
        /// <returns>An array of three opponent IDs.</returns>
        public int[] getTournamentOpponentIDs(int tournamentNum)
        {
            TournamentEntrant[] board = tournamentBoards[tournamentNum];
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i].getRoundsWon() > 0) // If anyone has advanced, that's a different situation I don't have reason to deal with right now
                    return new int[0];
            }
            
            int lanIndex = -1;
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i].isMegaManAndLan())
                {
                    lanIndex = i;
                    break;
                }
            }
            
            if (lanIndex < 0)
                return new int[0];
            
            int[] opponents = new int[3];
            
            // First opponent is the one paired with Lan; if Lan is in an even index, it's to his right, otherwise it's to his left.
            opponents[0] = board[lanIndex % 2 == 0? lanIndex + 1 : lanIndex - 1].getEntrantID();
            
            // Determine Round 1 winners; second opponent will be the winner of the other Round 1 pair on Lan's side.
            TournamentEntrant[] round1Winners = new TournamentEntrant[4];
            for (int i = 0; i < 8; i += 2)
            {
                TournamentEntrant left = board[i];
                TournamentEntrant right = board[i + 1];
                
                if (left.isMegaManAndLan() || left.getPriority() < right.getPriority())
                    round1Winners[i / 2] = left;
                else if (right.isMegaManAndLan() || right.getPriority() < left.getPriority())
                    round1Winners[i / 2] = right;
                else
                {
                    advanceRNG(ref tournamentRandomSeed);
                    round1Winners[i / 2] = (tournamentRandomSeed & 1) != 0? left : right;
                }
                
                if (i / 4 == lanIndex / 4 && i / 2 != lanIndex / 2) // Same side, but different Round 1 pair
                    opponents[1] = round1Winners[i / 2].getEntrantID();
            }
            
            // Third opponent will be the Round 2 winner on the side opposite Lan.
            int otherSideIndex = (lanIndex / 4 == 0)? 2 : 0; // If Lan is on left side, check Round 2 matchup on right, and vice versa
            TournamentEntrant round2Left = round1Winners[otherSideIndex];
            TournamentEntrant round2Right = round1Winners[otherSideIndex + 1];
            
            if (round2Left.getPriority() < round2Right.getPriority())
                opponents[2] = round2Left.getEntrantID();
            else if (round2Right.getPriority() < round2Left.getPriority())
                opponents[2] = round2Right.getEntrantID();
            else
            {
                advanceRNG(ref tournamentRandomSeed);
                opponents[2] = ((tournamentRandomSeed & 1) != 0? round2Left : round2Right).getEntrantID();
            }
            
            return opponents;
        }
        
        /// <summary>Simulates tournament generation to determine what next board will be, without actually changing anything.</summary>
        /// <param name="tournamentNum">The number of the tournament (0 Den/City, 1 Eagle/Hawk, 2 Red Sun/Blue Moon).</param>
        /// <param name="nextBoardOrBoards">Array with one or two sets of board data, if there are two possibilities.</param>
        /// <param name="nextBoardOpponents">Array with one or two sets of calculated opponent IDs</param>
        public void getNextTournamentBoardPreview(int tournamentNum, ref TournamentEntrant[][] nextBoardOrBoards, ref int[][] nextBoardOpponents)
        {
            uint originalSeed = tournamentRandomSeed;
            byte[] originalPossibles = (byte[])possibleTournamentEntrants.Clone();
            TournamentEntrant[] originalBoard = (TournamentEntrant[])tournamentBoards[tournamentNum].Clone();
            
            bool standardRNGInvolved = generatePossibleEntrantsList(tournamentNum, forceCoinFlip: 0);
            generateTournamentBoard(tournamentNum);
            
            if (standardRNGInvolved) // If based on a coinflip, get the other possible board and return both
            {
                // Create arrays with two entries and assign current board and opponents as the first.
                nextBoardOrBoards = new TournamentEntrant[2][];
                nextBoardOpponents = new int[2][];
                nextBoardOrBoards[0] = (TournamentEntrant[])tournamentBoards[tournamentNum].Clone();
                nextBoardOpponents[0] = getTournamentOpponentIDs(tournamentNum);
                
                // Reset state and generate the second board.
                tournamentRandomSeed = originalSeed;
                possibleTournamentEntrants = (byte[])originalPossibles.Clone();
                tournamentBoards[tournamentNum] = (TournamentEntrant[])originalBoard.Clone();
                
                generatePossibleEntrantsList(tournamentNum, forceCoinFlip: 1);
                generateTournamentBoard(tournamentNum);
                
                // Assign the second board and its opponents.
                nextBoardOrBoards[1] = (TournamentEntrant[])tournamentBoards[tournamentNum].Clone();
                nextBoardOpponents[1] = getTournamentOpponentIDs(tournamentNum);
            }
            else // Return only the one board
            {
                nextBoardOrBoards = new TournamentEntrant[1][];
                nextBoardOrBoards[0] = (TournamentEntrant[])tournamentBoards[tournamentNum].Clone();
                
                nextBoardOpponents = new int[1][];
                nextBoardOpponents[0] = getTournamentOpponentIDs(tournamentNum);
            }
            
            // Restore original data.
            tournamentRandomSeed = originalSeed;
            possibleTournamentEntrants = (byte[])originalPossibles.Clone();
            tournamentBoards[tournamentNum] = (TournamentEntrant[])originalBoard.Clone();
        }
        
        /* OTHER GETTERS AND SETTERS */
        
        /// <summary>Gets the full name of the game version for current game.</summary>
        /// <param name="version">Which version (M for Main, S for Sub) to return. By default, uses current version of save.</param>
        /// <param name="language">The current language. This is only relevant for BN3, where the versions, though technically equivalent, have different names.</param>
        /// <returns>The name of the version.</returns>
        public string getVersionName(char version = '\0', string language = "")
        {
            if (version == '\0')
                version = this.version;
            return getGameVersionName(game, version, language);
        }
        
        /// <summary>Gets the full name of the game version for a given game.</summary>
        /// <param name="game">The game number.</param>
        /// <param name="version">Which version (M for Main, S for Sub) to return.</param>
        /// <param name="language">The current language. This is only relevant for BN3, where the versions, though technically equivalent, have different names.</param>
        /// <returns>The name of the version.</returns>
        public static string getGameVersionName(int game, char version, string language = "")
        {
            if (language == "")
            {
                if (M.saveData != null)
                    language = !M.saveData.lc? M.saveData.language : "en";
                else
                    language = "en";
            }
            
            switch (game)
            {
                case 3: return version == 'M'? (language == "en"? "Blue" : "EXE3 Black") : version == 'S'? (language == "en"? "White" : "EXE3 Original") : "";
                case 4: return version == 'M'? "Red Sun" : version == 'S'? "Blue Moon" : "";
                case 5: return version == 'M'? "Protoman" : version == 'S'? "Colonel" : "";
                case 6: return version == 'M'? "Gregar" : version == 'S'? "Falzar" : "";
            }
            return version.ToString();
        }
        
        /// <summary>Gets the current maximum number of SubChips you can hold.</summary>
        /// <returns>The current SubChip limit.</returns>
        public int getSubchipLimit()
        {
            return upgradeItemQuantities[5]; // SubMem
        }
        
        /// <summary>Gets the (current) limit on MegaChips in a single folder.</summary>
        /// <returns>The MegaChip limit.</returns>
        public int getMegaChipLimit()
        {
            return game >= 3? programEffects.megaChipLimit + getPatchCardAddedValue("megafolder") : 5;
        }
        
        /// <summary>Gets the (current) limit on GigaChips in a single folder.</summary>
        /// <returns>The GigaChip limit.</returns>
        public int getGigaChipLimit()
        {
            return game >= 3? programEffects.gigaChipLimit + getPatchCardAddedValue("gigafolder") : 1;
        }
        
        /// <summary>Gets the (current) number of starting chip slots.</summary>
        /// <returns>The number of initial chip slots when battle starts.</returns>
        public int getStartingChipSlots()
        {
            return game >= 3? programEffects.startingChips + getPatchCardAddedValue("custom") : 5;
        }
        
        /// <summary>Gets the current overall HP value, including what's added by programs or Patch Cards.</summary>
        /// <param name="withoutPatchCards">Whether to include programs but omit Patch Cards.</param>
        /// <returns>The total HP value.</returns>
        public ushort getTotalHPWithExtras(bool withoutPatchCards = false)
        {
            if (game < 3)
                return maxHP;
            else if (game == 3)
                return programEffects.getTotalHP();
            else
                return (ushort)(overallMaxHP + (!withoutPatchCards? getPatchCardAddedValue("hp") : 0));
        }
        
        /// <summary>Gets the current base HP value, not including extra added by programs or Patch Cards.</summary>
        /// <returns>The base HP value.</returns>
        public ushort getBaseHPWithoutExtras()
        {
            if (game < 3)
                return maxHP;
            else if (game == 3)
                return (ushort)(100 + (upgradeItemQuantities[0] * 20));
            else
                return baseMaxHP;
        }
        
        /// <summary>Gets the theoretical maximum of maxHP/baseMaxHP for the current game, not counting things that stack on top of that.</summary>
        /// <returns>The maximum HP amount.</returns>
        public ushort getTheoreticalHPMaximum()
        {
            if (game == 3)
                return 3200; // 1000 base HP from all HPMemories, four HP+300s, and HP+1000 mod code
            else // BN1-2 don't have anything to stack on top, while BN4+ put everything else (programs, Patch Cards, etc.) in overallMaxHP, not base
                return 1000; // 1000 base HP from all HPMemories and nothing else
        }
        
        /// <summary>Gets the maximum Zenny amount for the current game.</summary>
        /// <returns>The maximum Zenny amount.</returns>
        public uint getZennyMaximum()
        {
            return (uint)(game < 4? 9999999 : 999999);
        }
        
        /// <summary>Sets a flag to true or false.</summary>
        /// <param name="flagNum">The number of the flag.</param>
        /// <param name="set">Whether to set or unset.</param>
        public void setFlag(int flagNum, bool set = true)
        {
            flags[flagNum] = set;
            
            // Copy to library flag arrays, either because they overlap or because there are duplicates that must match (library shared flags).
            int[][] libraryRanges = getDef<int[][]>("libraryFlagRanges");
            for (int i = 0; i < libraryRanges.Length; i++)
            {
                if (libraryRanges[i] != null && flagNum >= libraryRanges[i][0] && flagNum <= libraryRanges[i][1])
                {
                    int start = libraryRanges[i][0];
                    if (i == 0)
                        libraryChipFlags[flagNum - start] = flags[flagNum];
                    else if (i == 1)
                        libraryPAFlags[flagNum - start] = flags[flagNum];
                    else if (i == 2)
                        librarySharedChipFlags[flagNum - start] = flags[flagNum];
                    else if (i == 3)
                        librarySharedPAFlags[flagNum - start] = flags[flagNum];
                }
            }
        }
        
        /// <summary>Toggles a flag between true and false.</summary>
        /// <param name="flagNum">The number of the flag.</param>
        public void toggleFlag(int flagNum)
        {
            setFlag(flagNum, !flags[flagNum]);
        }
        
        /// <summary>Sets library flag to register a chip.</summary>
        /// <param name="chip">The number of the chip.</param>
        /// <param name="set">Whether to register or unregister.</param>
        public void setLibraryChipFlag(int chip, bool set = true)
        {
            int[][] libraryRanges = getDef<int[][]>("libraryFlagRanges");
            
            libraryChipFlags[chip] = set;
            if (libraryRanges[0] != null) // Copy to flags array if necessary
                flags[libraryRanges[0][0] + chip] = set;
            
            if (game >= 4)
            {
                byte libraryXor = (byte)(version == 'M'? 0x64 : 0x47);
                byte librarySourceValue = libraryFlagVerificationSource[chip];
                byte libraryTrueValue = (byte)(librarySourceValue ^ libraryXor);
                byte libraryFalseValue = (byte)(255 - librarySourceValue);
                libraryFlagVerificationBytes[chip] = libraryChipFlags[chip]? libraryTrueValue : libraryFalseValue;
            }
        }
        
        /// <summary>Sets library flag to register a PA.</summary>
        /// <param name="chip">The number of the PA.</param>
        /// <param name="set">Whether to register or unregister.</param>
        public void setLibraryPAFlag(int pa, bool set = true)
        {
            int[][] libraryRanges = getDef<int[][]>("libraryFlagRanges");
            
            libraryPAFlags[pa] = set;
            if (libraryRanges[1] != null) // Copy to flags array if necessary
                flags[libraryRanges[1][0] + pa] = set;
            
            if (game >= 4)
            {
                int myIndex = 320 + pa;
                byte libraryXor = (byte)(version == 'M'? 0x64 : 0x47);
                byte librarySourceValue = libraryFlagVerificationSource[myIndex];
                byte libraryTrueValue = (byte)(librarySourceValue ^ libraryXor);
                byte libraryFalseValue = (byte)(255 - librarySourceValue);
                libraryFlagVerificationBytes[myIndex] = libraryPAFlags[pa]? libraryTrueValue : libraryFalseValue;
            }
        }
        
        /// <summary>Sets level of a style in BN2 registeredStyles data, and adjusts active style if necessary.</summary>
        /// <param name="styleIndex">The index of the style.</param>
        /// <param name="level">The level to set the style to from 0 to 3, default 1.</param>
        /// <returns>Whether changes were made.</returns>
        public bool setBN2RegisteredStyle(int styleIndex, byte level = 1)
        {
            if (level > 3)
                level = 3;
            
            bool changesMade = false;
            if (registeredStyles[styleIndex] != level)
            {
                registeredStyles[styleIndex] = level;
                changesMade = true;
            }
            
            // Update activeStyle as necessary.
            string activeStyleName = getStyleName(activeStyle, false);
            int activeStyleIndexInRegistered = 0;
            for (int i = 0; i < registeredStyles.Length; i++)
            {
                string registeredStyleName = BN2Definitions.getRegisteredStyleName(i, includeLevel: false);
                if (registeredStyleName.Equals(activeStyleName))
                {
                    activeStyleIndexInRegistered = i;
                    break;
                }
            }
            
            byte activeStyleLevelValue = registeredStyles[activeStyleIndexInRegistered];
            
            if (activeStyleLevelValue > 0) // Level is non-zero, so just make sure level matches
            {
                int newValue = (activeStyle % 0x40) + ((activeStyleLevelValue - 1) * 0x40);
                if (activeStyle != newValue)
                {
                    activeStyle = (byte)newValue;
                    changesMade = true;
                }
            }
            else // Style was removed, so switch to another registered style
            {
                for (int index = 0; index < registeredStyles.Length; index++)
                {
                    if (registeredStyles[index] != 0x00)
                    {
                        byte newStyleLevelValue = registeredStyles[index];
                        string newStyleName = BN2Definitions.getRegisteredStyleName(index, includeLevel: false);
                        for (int styleID = 0x00; styleID < 0x40; styleID++)
                        {
                            string checkingStyleName = getStyleName(styleID, false);
                            if (checkingStyleName.Equals(newStyleName))
                            {
                                activeStyle = (byte)(styleID + ((newStyleLevelValue - 1) * 0x40));
                                return true;
                            }
                        }
                    }
                }
                
                // If somehow nothing is registered, reset to NormStyl.
                activeStyle = 0x00;
                changesMade = true;
            }
            
            return changesMade;
        }
        
        /// <summary>Removes a style in BN2 registeredStyles data.</summary>
        /// <param name="styleIndex">The index of the style.</param>
        /// <returns>Whether changes were made.</returns>
        public bool removeBN2RegisteredStyle(int styleIndex)
        {
            return setBN2RegisteredStyle(styleIndex, 0);
        }
        
        /// <summary>Sets BN3 Virus Breeder food distribution.</summary>
        /// <param name="index">The index of the virus to set for.</param>
        /// <param name="foodValue">The value to set to.</param>
        /// <param name="mode"><para>Special mode for setting food distribution.</para>
        /// <para>"all": Sets given value for all viruses.</para>
        /// <para>"allstrongest": Sets given value for the strongest of each virus group, and sets the others in the group to 0.</para>
        /// <para>"allingroup": Sets given value for all viruses in the group starting at the given index.</para></param>
        /// <returns>Whether changes were made.</returns>
        public bool setVirusFoodDistribution(int index, byte foodValue, string mode = "")
        {
            if (foodValue > 100)
                foodValue = 100;
            
            bool changesMade = false;
            
            if (mode == "")
            {
                changesMade = virusFoodDistribution[index] != foodValue;
                virusFoodDistribution[index] = foodValue;
                return changesMade;
            }
            
            if (mode == "allingroup")
            {
                int virusLevelCount = BN3Definitions.virusBreederNames[index].Equals("Scuttlest")? 6 : 4;
                for (int virusLevel = 0; virusLevel < virusLevelCount; virusLevel++)
                {
                    if (virusFoodDistribution[index + virusLevel] != foodValue)
                        changesMade = true;
                    virusFoodDistribution[index + virusLevel] = foodValue;
                }
                return changesMade;
            }
            
            int virusIndex = 0;
            while (virusIndex < BN3Definitions.virusBreederNames.Length)
            {
                int virusLevelCount = BN3Definitions.virusBreederNames[virusIndex].Equals("Scuttlest")? 6 : 4;
                
                if (mode == "allstrongest")
                {
                    for (int virusLevel = 0; virusLevel < virusLevelCount - 1; virusLevel++)
                    {
                        if (virusFoodDistribution[virusIndex + virusLevel] != 0)
                            changesMade = true;
                        virusFoodDistribution[virusIndex + virusLevel] = 0;
                    }
                    
                    if (virusFoodDistribution[virusIndex + virusLevelCount - 1] != foodValue)
                        changesMade = true;
                    virusFoodDistribution[virusIndex + virusLevelCount - 1] = foodValue;
                }
                else if (mode == "all")
                {
                    for (int virusLevel = 0; virusLevel < virusLevelCount; virusLevel++)
                    {
                        if (virusFoodDistribution[virusIndex + virusLevel] != foodValue)
                            changesMade = true;
                        virusFoodDistribution[virusIndex + virusLevel] = foodValue;
                    }
                }
                
                virusIndex += virusLevelCount;
            }
            
            return changesMade;
        }
        
        /// <summary>Gets whether the given error code index is saved.</summary>
        /// <param name="code">The index of the error code.</param>
        /// <returns>Whether the error code has been saved (byte matches the internal saved value).</returns>
        public bool getErrorCodeSaved(int code)
        {
            return errorCodesSavedBytes[code] == BN3Definitions.errorCodeSaveBytes[code];
        }
        
        /// <summary>Sets the given error code index as saved or not.</summary>
        /// <param name="code">The index of the error code.</param>
        /// <param name="set">Whether to set the error code or not.</param>
        public void setErrorCodeSaved(int code, bool set = true)
        {
            errorCodesSavedBytes[code] = (byte)(set? BN3Definitions.errorCodeSaveBytes[code] : 0x00);
        }
        
        /// <summary>Toggles saved status of the given error code index.</summary>
        /// <param name="code">The index of the error code.</param>
        public void toggleErrorCodeSaved(int code)
        {
            setErrorCodeSaved(code, !getErrorCodeSaved(code));
        }
        
        /// <summary>Sets Navi ID for a slot in BN4 WaitingRoom.</summary>
        /// <param name="slot">The slot index (0-based).</param>
        /// <param name="naviID">The opponent ID of the Navi (FF for blank).</param>
        public void setWaitingRoomNavi(int slot, byte naviID)
        {
            waitingRoomData[slot * 2] = 0xFF;
            waitingRoomData[(slot * 2) + 1] = naviID;
            waitingRoomDataB[(slot * 2)] = (byte)(slot + 1);
            waitingRoomDataB[(slot * 2) + 1] = naviID;
        }
        
        /// <summary>Updates karma verification value to match current karma (stored in programEffects).</summary>
        /// <param name="forFreshSave">Whether this is being done for fresh save, in which case it weirdly uses value of 0.</param>
        public void updateKarmaVerification(bool forFreshSave = false)
        {
            ushort rawKarma = (ushort)(!forFreshSave? programEffects.getKarma() : 0);
            karmaVerificationValue = rawKarma ^ karmaVerificationBase;
        }
        
        /// <summary>Sets the given Patch Card as obtained, allowing it to be safely set in a slot.</summary>
        /// <param name="cardID">The ID of the card to set as obtained.</param>
        public void setPatchCardObtained(int cardID)
        {
            if (game < 4)
                return;
            
            byte sourceValue = patchCardVerificationSource[cardID];
            byte trueValue = (byte)(sourceValue ^ (version == 'M'? 0x43 : 0x31));
            patchCardVerificationBytes[cardID] = trueValue;
        }
        
        /// <summary>Gets the total value added by active Patch Cards of the specified type.</summary>
        /// <param name="type">The type of value to search for: "hp" "custom" "megafolder" "gigafolder"</param>
        /// <returns>The total value added by active Patch Cards.</returns>
        public int getPatchCardAddedValue(string type)
        {
            if (game < 4)
                return 0;
            
            int total = 0;
            string searchStr = "";
            switch (type)
            {
                case "hp": searchStr = "MAX HP +"; break;
                case "custom": searchStr = "Custom"; break;
                case "megafolder": searchStr = "MegaFolder"; break;
                case "gigafolder": searchStr = "GigaFolder"; break;
            }
            
            for (int cardIndex = 0; cardIndex < 6; cardIndex++)
            {
                if (patchCardData[cardIndex] != 0xFF)
                {
                    string cardName = getDefKey<byte, object[]>("patchCardDefs", patchCardData[cardIndex])[0] as string;
                    if (cardName == "")
                        continue;
                    
                    // If search string is found at start of name, get just the number at the end and add to total.
                    string valueStr = "";
                    if (cardName.StartsWith(searchStr))
                        valueStr = cardName.Substring(searchStr.Length);
                    
                    if (valueStr == "")
                        continue;
                    
                    int value = 0;
                    if (int.TryParse(valueStr, out value))
                        total += value;
                }
            }
            
            return total;
        }
        
        /// <summary>Gets whether the given Patch Card slot is occupied.</summary>
        /// <param name="slotIndex">The (0-based) slot index.</param>
        /// <returns>Whether the given slot is occupied.</returns>
        public bool isPatchCardSlotFilled(int slotIndex)
        {
            return patchCardData[slotIndex] != 0xFF || patchCardData[7 + slotIndex] != 0xFF;
        }
        
        /// <summary>Sets a card in the given Patch Card slot.</summary>
        /// <param name="slotIndex">The (0-based) slot index.</param>
        /// <param name="cardID">The ID of the card.</param>
        public void setPatchCardForSlot(byte slotIndex, byte cardID)
        {
            setFlag(114); // Properly unlock mod menu; still shows up without this, but has odd behavior for some reason
            setPatchCardObtained(cardID); // Card must be verified obtained to be set in a slot
            
            patchCardData[slotIndex] = cardID;
            patchCardData[7 + slotIndex] = 0xFF;
            
            updatePatchCardDescription(slotIndex);
            
            // Update first active patch card.
            firstActivePatchCard = 0x00; // Default if none are active
            for (int i = 0; i < 6; i++)
            {
                if (patchCardData[i] != 0xFF)
                {
                    firstActivePatchCard = patchCardData[i];
                    break;
                }
            }
        }
        
        /// <summary>Toggles the given Patch Card slot between active and inactive.</summary>
        /// <param name="slotIndex">The (0-based) slot index.</param>
        public void togglePatchCardActive(int slotIndex)
        {
            if (patchCardData[slotIndex] != 0xFF) // Active to inactive
            {
                patchCardData[7 + slotIndex] = patchCardData[slotIndex];
                patchCardData[slotIndex] = 0xFF;
            }
            else // Inactive to active
            {
                patchCardData[slotIndex] = patchCardData[7 + slotIndex];
                patchCardData[7 + slotIndex] = 0xFF;
            }
        }
        
        /// <summary>Empties the given Patch Card slot.</summary>
        /// <param name="slotIndex">The (0-based) slot index.</param>
        public void emptyPatchCardSlot(int slotIndex)
        {
            patchCardData[slotIndex] = 0xFF;
            patchCardData[7 + slotIndex] = 0xFF;
        }
        
        /// <summary>Gets whether LocEnemy SubChip is active.</summary>
        /// <returns>Status of the LocEnemy flag (false if there is none).</returns>
        public bool isLocEnemyActive()
        {
            int locEnemyFlag = game == 2? 2146 : game == 3? 4706 : game == 4? 4461 : -1;
            if (locEnemyFlag < 0)
                return false;
            return flags[locEnemyFlag];
        }
        
        /// <summary>Sets whether LocEnemy SubChip is active.</summary>
        /// <param name="active">The new LocEnemy status.</param>
        /// <param name="encounterID">The new encounter ID, if setting to active.</param>
        public void setLocEnemyActive(bool active = true, int encounterID = 0)
        {
            int locEnemyFlag = game == 2? 2146 : game == 3? 4706 : game == 4? 4461 : -1;
            if (locEnemyFlag < 0)
                return;
            
            setFlag(locEnemyFlag, active);
            locEnemyEncounterPointer.setEncounterID(active? encounterID : 0x00);
            locEnemyStepsRemaining = active? 0x1770 : 0;
        }
        
        /// <summary>Checks whether e-Reader text is not yet defined in the save.</summary>
        /// <param name="eReaderID">String identifier for which text to check. ("duo" "prixpowr")</param>
        /// <returns>Whether the e-Reader text data appears to be unset.</returns>
        public bool isEReaderStringUnset(string eReaderID)
        {
            byte nameStart = 0xFF;
            byte descStart = 0xFF;
            byte[] stringStartBytes = new byte[] { 0x02, 0x00 };
            byte[] stringEndBytes = new byte[] { 0xE5 };
            
            if (eReaderID == "duo")
            {
                nameStart = eReaderDataDuoName[2];
                descStart = eReaderDataDuoDesc[2];
            }
            else if (eReaderID == "prixpowr")
            {
                nameStart = eReaderDataPrixPowrName[2];
                descStart = eReaderDataPrixPowrDesc[2];
            }
            
            return nameStart == 0x7E || nameStart == 0x45 || nameStart == 0x00 // Name starts with ？ or ? or 00
                || descStart == 0x7E || descStart == 0x45 || descStart == 0x00; // Description starts with ？ or ? or 00
        }
        
        /// <summary>Updates Patch Card description string for current language.</summary>
        /// <param name="slotIndex">The index of the slot to update (0 for 0A through 5 for 0F).</param>
        public void updatePatchCardDescription(byte slotIndex)
        {
            byte cardID = patchCardData[slotIndex] != 0xFF? patchCardData[slotIndex] : patchCardData[7 + slotIndex];
            byte[] descBytes;
            
            if (cardID != 0xFF)
            {
                object[] cardDef = getDefKey<byte, object[]>("patchCardDefs", cardID);
                string nameEN = cardDef[0] as string;
                string nameJP = cardDef[1] as string;
                int buggy = (int)cardDef[3];
            
                string descString = (language == "en"? (!lc? "Mod #" : "Mod Number ") : "改造ナンバー")
                    + cardID.ToString("D3") + "\n"
                    + (language == "en"? nameEN : nameJP)
                    + (buggy != 0? (language == "en"? (!lc? "\nBuggy" : "w/Bug") : "\nバグあり") : "");
                
                byte[] startBytes = !lc? new byte[] { 0x02, 0x00, 0xF6, 0x02, 0x39, 0x6C, 0x03, 0xF0, 0x00, 0x00 }
                                       : new byte[] { 0x01, 0x00, cardID, 0x02, 0x39, 0x6C, 0x03, 0xF0, 0x00, 0x00 };
                descBytes = getTableStringBytes(descString, startBytes, new byte[] { 0xED, 0xFF }, 0x5C);
            }
            else
                descBytes = new byte[0x5C];
            
            if (slotIndex == 0)
                eReaderDataPatchCard0A = descBytes;
            else if (slotIndex == 1)
                eReaderDataPatchCard0B = descBytes;
            else if (slotIndex == 2)
                eReaderDataPatchCard0C = descBytes;
            else if (slotIndex == 3)
                eReaderDataPatchCard0D = descBytes;
            else if (slotIndex == 4)
                eReaderDataPatchCard0E = descBytes;
            else if (slotIndex == 5)
                eReaderDataPatchCard0F = descBytes;
        }
        
        /// <summary>Formats a time given in frames into a proper time format.</summary>
        /// <param name="frames">The number of frames in the time.</param>
        /// <param name="secondsMilliseconds">Whether to display as m:ss.ff (minutes, seconds, milliseconds) for short times.
        /// The default format is h:mm:ss +frames, designed for playtime-level times.</param>
        /// <param name="dashesPast95999">If time exceeds 9:59.99, shows dashes instead.</param>
        /// <returns>The formatted time string.</returns>
        public static string formatFrameTime(uint frames, bool secondsMilliseconds = false, bool dashesPast95999 = false)
        {
            uint milliframes = frames % 60;
            uint seconds = (frames / 60) % 60;
            uint minutes = (frames / 3600) % 60;
            uint hours = frames / 216000;
            
            if (dashesPast95999 && minutes >= 10)
                return "-:--.--";
            else if (!secondsMilliseconds)
                return hours + ":" + minutes.ToString("D2") + ":" + seconds.ToString("D2") + " +" + milliframes + "f";
            else
            {
                // -0.001f is to match the games' odd rounding, in which exact multiple-of-3 divisions like 57f / 60f = .950 display instead as .94.
                uint milliseconds = (uint)(((milliframes / 60f) - (milliframes > 0? 0.001f : 0)) * 100);
                return minutes + ":" + seconds.ToString("D2") + "." + milliseconds.ToString("D2");
            }
        }
        
        /* LIST GETTERS FOR OPTIONS LISTS AND/OR SAVE INFO */
        
        /// <summary>Gets a list of progress values for each style type.</summary>
        /// <param name="forSaveInfo">Whether to format for save info rather than menu.</param>
        /// <returns>List of style types and their progress values.</returns>
        public List<string> getStyleProgressList(bool forSaveInfo = false)
        {
            List<string> list = new List<string>();
            string[] styleTypes = getDef<string[]>("styleTypes");
            for (int i = 0; i < styleTypes.Length; i++)
                list.Add(getInfoString(forSaveInfo? "Battles Toward " + styleTypes[i] + " Style" : styleTypes[i],
                                       game == 2? styleProgressInts[i] : styleProgressBytes[i]));
            return list;
        }
        
        /// <summary>Gets a list of currently-registered styles for BN2, where you can have multiple.</summary>
        /// <returns>List of style names and levels for those marked as registered.</returns>
        public List<string> getBN2RegisteredStylesList()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < registeredStyles.Length; i++)
            {
                if (registeredStyles[i] > 0)
                    list.Add(BN2Definitions.getRegisteredStyleName(i, registeredStyles[i]));
            }
            return list;
        }
        
        /// <summary>Gets an options list of currently-registered styles for BN2, which includes the registeredStyles index.</summary>
        /// <returns>Options list with style names/levels for styles marked as registered and associated indexes in registeredStyles.</returns>
        public List<string[]> getBN2RegisteredStylesOptions()
        {
            List<string[]> list = new List<string[]>();
            for (int i = 0; i < registeredStyles.Length; i++)
            {
                if (registeredStyles[i] > 0)
                    list.Add(new string[] { i.ToString(), BN2Definitions.getRegisteredStyleName(i, registeredStyles[i]) });
            }
            return list;
        }
        
        /// <summary>Gets a list of Number Trader codes and their entered status.</summary>
        /// <returns>List of Number Trader codes and flag values.</returns>
        public List<string> getNumberTraderFlagsList()
        {
            string[] numberTraderCodes = getDef<string[]>("numberTraderCodes");
            List<string> list = new List<string>();
            for (int i = 0; i < numberTraderCodes.Length; i++)
                list.Add(numberTraderCodes[i] + ": " + numberTraderFlags[i]);
            return list;
        }
        
        /// <summary>Gets a list of BN3 time trial records.</summary>
        /// <returns>List of time trial records against each Navi.</returns>
        public List<string> getBN3TimeTrialList()
        {
            string[] timeTrialNames = getDef<string[]>("timeTrialNames");
            List<string> list = new List<string>();
            for (int i = 0; i / 2 < timeTrialNames.Length; i += 2)
                list.Add(timeTrialNames[i / 2] + ": " + formatFrameTime(timeTrialRecords[i], true)
                    + " (" + (timeTrialRecords[i + 1] == 0xEC? "Serenade" : "MegaMan") + ")");
            return list;
        }
        
        /// <summary>Gets a list of BN4 Navi deletion records.</summary>
        /// <returns>List of My/Best Records for each Navi.</returns>
        public List<string> getBN4NaviRecordsList()
        {
            string[] naviRecordNames = getDef<string[]>("timeTrialNames");
            List<string> list = new List<string>();
            for (int i = 0; i < naviRecordNames.Length; i++)
            {
                string displayName = naviRecordHolderNames[i].Replace("ー", "-").Replace("—", "-"); // Convert non-ASCII dash symbols for display
                list.Add(naviRecordNames[i] + ": My Record " + formatFrameTime(myNaviRecords[i], true, true)
                    + ", Best Record " + formatFrameTime(bestNaviRecords[i], true, true) + " (" + displayName + ")");
            }
            return list;
        }
        
        /// <summary>Gets a list of current WaitingRoom occupants.</summary>
        /// <returns>List of entries in the WaitingRoom.</returns>
        public List<string> getWaitingRoomOccupantsList()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 7; i++)
            {
                string naviName = "";
                byte naviID = waitingRoomData[(i * 2) + 1];
                if (naviID != 0xFF && naviID < BN4Definitions.tournamentEntrantData.Length)
                    naviName = BN4Definitions.tournamentEntrantData[naviID][0] as string;
                string displayName = waitingRoomNames[i].Replace("ー", "-").Replace("—", "-"); // Convert non-ASCII dash symbols for display
                list.Add(naviName != ""? (naviName + displayName) : "-NO ENTRY-");
            }
            return list;
        }
        
        /// <summary>Gets a list of SoulNavis that can be added to WaitingRoom.</summary>
        /// <returns>List of WaitingRoom Navi options.</returns>
        public List<string> getWaitingRoomNaviOptions()
        {
            List<string> list = new List<string>();
            for (int naviID = 0; naviID < 0xC; naviID++)
                list.Add(BN4Definitions.tournamentEntrantData[naviID][0] as string);
            return list;
        }
        
        /// <summary>Gets a list of what's in each Patch Card slot.</summary>
        /// <returns>List of assigned Patch Cards in each slot.</returns>
        public List<string> getPatchCardSlotList()
        {
            Dictionary<byte, object[]> defs = getGameDef().patchCardDefs;
            List<string> list = new List<string>();
            for (int i = 0; i < 6; i++)
            {
                string slotName = "0" + (char)('A' + i);
                string activeStr = "";
                
                byte myID = 0xFF;
                byte activeID = patchCardData[i];
                byte inactiveID = patchCardData[7 + i];
                if (activeID != 0xFF) // Active slot takes precedence - if there's a different ID in inactive slot, it just vanishes
                {
                    myID = activeID;
                    activeStr = " (Active)";
                }
                else if (inactiveID != 0xFF)
                {
                    myID = inactiveID;
                    activeStr = " (Inactive)";
                }
                
                string myName = myID != 0xFF && defs.ContainsKey(myID)? myID.ToString("D3") + " " + defs[myID][0] as string : "---";
                list.Add(slotName + ": " + myName + activeStr);
            }
            return list;
        }
        
        /// <summary>Gets an options list of all possible Patch Cards for the given slot.</summary>
        /// <param name="slotIndex">The (0-based) slot index.</param>
        /// <returns>Options list of Patch Cards for the given slot.</returns>
        public List<string[]> getPatchCardOptionsForSlot(int slotIndex)
        {
            string slotName = "0" + (char)('A' + slotIndex);
            Dictionary<byte, object[]> defs = getGameDef().patchCardDefs;
            
            List<string[]> list = new List<string[]>();
            foreach (byte key in defs.Keys)
            {
                if ((defs[key][2] as string).Equals(slotName))
                    list.Add(new string[] { key.ToString(), "{[" + key.ToString("D3") + "]} " + (defs[key][0] as string) });
            }
            return list;
        }
        
        /* PER-GAME DEFINITION GETTERS (ARRAYS/DICTIONARIES) */
        
        /// <summary>Gets a BNDefinitions object for a given game, or the current game by default.</summary>
        /// <param name="forGame">The game to get definitions for.</param>
        /// <returns>The BNDefinitions object. null if none is defined for the given game number.</returns>
        public static BNDefinitions getGameDef(int forGame = -1)
        {
            if (forGame == -1)
                forGame = M.game;
            switch (forGame)
            {
                case 1: return new BN1Definitions();
                case 2: return new BN2Definitions();
                case 3: return new BN3Definitions();
                case 4: return new BN4Definitions();
            }
            return null;
        }
        
        /// <summary>Returns a definition of the given type for the current game.</summary>
        /// <typeparam name="T">The type of the definition (as it is in BNDefinitions, without wrapper Dictionary for game number).</typeparam>
        /// <param name="defName">The field name of the definition.</param>
        /// <returns>The definition of the given type from the current game's definitions. Default value for type if not found.</returns>
        public T getDef<T>(string defName)
        {
            try
            {
                Dictionary<int, T> def = this.GetType().GetField(defName, BindingFlags.Static | BindingFlags.NonPublic).GetValue(this) as Dictionary<int, T>;
                if (def.ContainsKey(game))
                    return def[game];
            }
            catch
            {
                Console.WriteLine("ERROR: Definition " + defName + " not found.");
            }
            return default(T);
        }
        
        /// <summary>Returns an element from a definition array of the given type for the current game.</summary>
        /// <typeparam name="T">The return type, AKA the non-array form of the definition's type.</typeparam>
        /// <param name="defName">The field name of the definition.</param>
        /// <param name="index">The index in the array.</param>
        /// <returns>The element of the given type from the current game's definitions. Default value for type if not found.</returns>
        public T getDefIndex<T>(string defName, int index)
        {
            T[] array = getDef<T[]>(defName);
            if (array != null && index >= 0 && index < array.Length)
                return array[index];
            return default(T);
        }
        
        /// <summary>Returns an element from a definition Dictionary of the given type for the current game.</summary>
        /// <typeparam name="T1">The Dictionary's key type, and thus the type of the key parameter.</typeparam>
        /// <typeparam name="T2">The Dictionary's value type, and thus the return type.</typeparam>
        /// <param name="defName">The field name of the definition.</param>
        /// <param name="key">The key in the Dictionary.</param>
        /// <returns>The value for the given key in the Dictionary from the current game's definitions. Default value for type if not found.</returns>
        public T2 getDefKey<T1, T2>(string defName, T1 key)
        {
            Dictionary<T1, T2> dict = getDef<Dictionary<T1, T2>>(defName);
            if (dict != null && dict.ContainsKey(key))
                return dict[key];
            return default(T2);
        }
        
        /// <summary>Returns an int from the definition array for the current game. Unlike getDefIndex<int>, it returns -1 instead of 0 if not found.</summary>
        /// <param name="defName">The field name of the definition.</param>
        /// <param name="index">The index in the array.</param>
        /// <returns>The int from the current game's definitions. -1 if not found.</returns>
        public int getIntDefIndex(string defName, int index)
        {
            int[] array = getDef<int[]>(defName);
            if (array != null && index >= 0 && index < array.Length)
                return array[index];
            return -1;
        }
        
        /// <summary>Gets the defined name for a chip.</summary>
        /// <param name="chipID">The ID of the chip.</param>
        /// <param name="fallbackIfNotFound">Whether to return a placeholder instead of a blank string if not found.</param>
        /// <returns>The name of the chip.</returns>
        public string getChipName(int chipID, bool fallbackIfNotFound = true)
        {
            return getGameDef().getChipName(chipID, fallbackIfNotFound);
        }
        
        /// <summary>Gets the defined name for a Program Advance.</summary>
        /// <param name="chipID">The ID of the Program Advance.</param>
        /// <param name="fallbackIfNotFound">Whether to return a placeholder instead of a blank string if not found.</param>
        /// <returns>The name of the Program Advance.</returns>
        public string getPAName(int paID, bool fallbackIfNotFound = true)
        {
            return getGameDef().getPAName(paID, fallbackIfNotFound);
        }
        
        /// <summary>Gets the list of defined aliases for a chip by name.</summary>
        /// <param name="chipName">The canonical name of the chip.</param>
        /// <returns>The array of aliases, empty if none found.</returns>
        public string[] getAliasesForChipName(string chipName)
        {
            return getGameDef().getAliasesForChipName(chipName);
        }
        
        /// <summary>Gets the list of defined codes for a chip.</summary>
        /// <param name="chipID">The ID of the chip.</param>
        /// <returns>The codes for the chip.</returns>
        public string getChipCodes(int chipID)
        {
            string result = getDefIndex<string>("chipCodes", chipID);
            if (result != "")
                return result;
            return game == 1? "-----" : game < 4? "------" : "----";
        }
        
        /// <summary>Returns a list of internal code indexes for all of the chip's valid codes.</summary>
        /// <param name="chipID">The ID of the chip.</param>
        /// <returns>A list of code indexes.</returns>
        public List<int> getValidCodeIndexes(int chipID)
        {
            string codes = getChipCodes(chipID);
            List<int> validCodeIndexes = new List<int>();
            for (int i = 0; i < codes.Length; i++)
            {
                if (codes[i] != '-' && isChipObtainable(chipID, i))
                    validCodeIndexes.Add(i);
            }
            return validCodeIndexes;
        }
        
        /// <summary>Returns a list of letters for all of the chip's valid codes.</summary>
        /// <param name="chipID">The ID of the chip.</param>
        /// <returns>A list of code letters.</returns>
        public List<char> getValidCodeLetters(int chipID)
        {
            string codes = getChipCodes(chipID);
            List<char> validCodeLetters = new List<char>();
            for (int i = 0; i < codes.Length; i++)
            {
                if (codes[i] != '-' && isChipObtainable(chipID, i))
                    validCodeLetters.Add(codes[i]);
            }
            return validCodeLetters;
        }
        
        /// <summary>Gets the internal ID for a chip given its in-game numbering.</summary>
        /// <param name="type">The chip class: S for Standard, M for Mega, G for Giga, ? for Secret.</param>
        /// <param name="chipNum">The in-game number of the chip within its class.</param>
        /// <param name="version">The game version (M for Main, S for Sub), for cases where libraries differ between versions.</param>
        /// <returns>The ID of the chip.</returns>
        public int getChipIDFromInGameNum(char type, int chipNum, char version = '\0')
        {
            if (chipNum <= 0)
                return -1;
            
            chipNum--; // Adjust to be 0-based
            int result = -1;
            switch (type)
            {
                case 'S':
                    result = getIntDefIndex("gameOrderStandardChips", chipNum);
                    if (result != -1)
                        return result;
                    break;
                case 'M':
                    if (version == 'M') // Main
                        result = getIntDefIndex("gameOrderMegaChipsMain", chipNum);
                    else if (version == 'S') // Sub
                        result = getIntDefIndex("gameOrderMegaChipsSub", chipNum);
                    else if (version == '\0')
                        result = getIntDefIndex("gameOrderMegaChipsAll", chipNum);
                    if (result != -1)
                        return result;
                    break;
                case 'G':
                    if (version == 'M') // Main
                        result = getIntDefIndex("gameOrderGigaChipsMain", chipNum);
                    else if (version == 'S') // Sub
                        result = getIntDefIndex("gameOrderGigaChipsSub", chipNum);
                    else if (version == '\0')
                        result = getIntDefIndex("gameOrderGigaChipsAll", chipNum);
                    if (result != -1)
                        return result;
                    break;
                case '?':
                    if (version == 'M') // Main
                        result = getIntDefIndex("gameOrderSecretChipsMain", chipNum);
                    else if (version == 'S') // Sub
                        result = getIntDefIndex("gameOrderSecretChipsSub", chipNum);
                    else if (version == '\0')
                        result = getIntDefIndex("gameOrderSecretChipsAll", chipNum);
                    if (result != -1)
                        return result;
                    break;
            }
            return -1;
        }
        
        /// <summary>Gets the name for a chip given its in-game numbering.</summary>
        /// <param name="type">The chip class: S for Standard, M for Mega, G for Giga.</param>
        /// <param name="chipNum">The in-game number of the chip within its class.</param>
        /// <param name="version">The game version (M for Main, S for Sub), for cases where libraries differ between versions.</param>
        /// <returns>The name of the chip.</returns>
        string getChipNameUsingGameNum(char type, int chipNum, char version = '\0')
        {
            return getChipName(getChipIDFromInGameNum(type, chipNum, version));
        }
        
        /// <summary>Gets the internal ID for a Program Advance given its in-game numbering.</summary>
        /// <param name="paNum">The in-game number of the Program Advance.</param>
        /// <returns>The ID of the Program Advance.</returns>
        public int getPAIDFromInGameNum(int paNum)
        {
            int result = getIntDefIndex("gameOrderPAs", paNum - 1);
            if (result != -1)
                return result;
            return -1;
        }
        
        /// <summary>Gets the name for a Program Advance using in-game numbering.</summary>
        /// <param name="paNum">The in-game number of the Program Advance.</param>
        /// <returns>The name of the Program Advance.</returns>
        string getPANameUsingGameNum(int paNum)
        {
            return getPAName(getPAIDFromInGameNum(paNum));
        }
        
        /// <summary>Gets the defined name of a key item.</summary>
        /// <param name="item">The number of the key item.</param>
        /// <param name="fallbackIfNotFound">Whether to return a placeholder instead of a blank string if not found.</param>
        /// <returns>The name of the key item.</returns>
        public string getKeyItemName(int item, bool fallbackIfNotFound = true)
        {
            return getGameDef().getKeyItemName(item, fallbackIfNotFound);
        }
        
        /// <summary>Gets the defined name of an upgrade item.</summary>
        /// <param name="subchip">The number of the upgrade item.</param>
        /// <param name="fallbackIfNotFound">Whether to return a placeholder instead of a blank string if not found.</param>
        /// <returns>The name of the upgrade item.</returns>
        public string getUpgradeItemName(int item, bool fallbackIfNotFound = true)
        {
            return getGameDef().getUpgradeItemName(item, fallbackIfNotFound);
        }
        
        /// <summary>Gets the defined name of a SubChip.</summary>
        /// <param name="subchip">The number of the SubChip.</param>
        /// <param name="fallbackIfNotFound">Whether to return a placeholder instead of a blank string if not found.</param>
        /// <returns>The name of the SubChip.</returns>
        public string getSubchipName(int subchip, bool fallbackIfNotFound = true)
        {
            return getGameDef().getSubchipName(subchip, fallbackIfNotFound);
        }
        
        /// <summary>Gets the defined name of a preset folder.</summary>
        /// <param name="folder">The ID of the preset folder.</param>
        /// <param name="fallbackIfNotFound">Whether to return a placeholder instead of a blank string if not found.</param>
        /// <returns>The name of the preset folder.</returns>
        public string getPresetFolderName(int folder, bool fallbackIfNotFound = true)
        {
            return getGameDef().getPresetFolderName(folder, fallbackIfNotFound);
        }
        
        /// <summary>Gets a defined preset folder.</summary>
        /// <param name="presetName">The name of the preset.</param>
        /// <returns>The array of preset folder entries, empty if not found.</returns>
        public string[] getPresetFolder(string presetName)
        {
            return getGameDef().getPresetFolder(presetName);
        }
        
        /// <summary>Gets the defined name of a NaviCust program.</summary>
        /// <param name="program">The number of the program.</param>
        /// <param name="fallbackIfNotFound">Whether to return a placeholder instead of a blank string if not found.</param>
        /// <returns>The name of the program.</returns>
        public string getProgramName(int program, bool fallbackIfNotFound = true)
        {
            return getGameDef().getProgramName(program, fallbackIfNotFound);
        }
        
        /* PER-GAME DEFINITION GETTERS (FUNCTIONS) */
        
        /// <summary>Gets the name of an area, calling equivalent in BNDefinitions.</summary>
        /// <param name="area">The ID of the area.</param>
        /// <param name="noFallback">Whether to return direct result. Useful for checking defined areas, as undefined ones will return an empty string.</param>
        /// <param name="includeInternal">Whether to include the internal ID in brackets.</param>
        /// <returns>The name of the area.</returns>
        public string getAreaName(int area, bool noFallback = false, bool includeInternal = false)
        {
            return getSubareaName(area, 0, true, noFallback, includeInternal);
        }
        
        /// <summary>Gets the name of a subarea, calling equivalent in BNDefinitions.</summary>
        /// <param name="area">The ID of the area.</param>
        /// <param name="subarea">The ID of the subarea.</param>
        /// <param name="includeInternal">Whether to include the internal ID in brackets.</param>
        /// <param name="noFallback">Whether to return direct result. Useful for checking defined areas, as undefined ones will return an empty string.</param>
        /// <param name="returnArea">Whether to return area name instead of subarea, allowing one function to define both.</param>
        /// <returns>The name of the subarea (or area).</returns>
        public string getSubareaName(int area, int subarea, bool returnArea = false, bool noFallback = false, bool includeInternal = false)
        {
            string name = "";
            if (getGameDef() != null)
                name = getGameDef().getSubareaName(area, subarea, returnArea, !noFallback);
            
            string internalString = includeInternal? "[" + (returnArea? area : subarea).ToString("X2") + "]" : "";
            return name + (name != "" && internalString != ""? " " : "") + internalString;
        }
        
        /// <summary>Gets the name of a music track, calling equivalent in BNDefinitions.</summary>
        /// <param name="music">The ID of the music track.</param>
        /// <returns>The name of the music (empty string if not found) and its ID.</returns>
        public string getMusicName(int music)
        {
            string name = "";
            if (getGameDef() != null)
                name = getGameDef().getMusicName(music, true);
            return name;
        }
        
        /// <summary>Gets the name of a base style type (i.e. Guts), calling equivalent in BNDefinitions.</summary>
        /// <param name="style">The ID of the style type.</param>
        /// <param name="includeLevel">Whether to include the style level.</param>
        /// <returns>The name of the style type, or "Style #X" if not found.</returns>
        public string getStyleName(int style, bool includeLevel = true)
        {
            string name = "";
            if (getGameDef() != null)
                name = getGameDef().getStyleName(style, true, includeLevel);
            return name;
        }
        
        /// <summary>Gets the name of an email, calling equivalent in BNDefinitions.</summary>
        /// <param name="email">The ID of the email.</param>
        /// <returns>The name of the email, or "Email #X" if not found.</returns>
        public string getEmailName(int email)
        {
            string name = "";
            if (getGameDef() != null)
                name = getGameDef().getEmailName(email, true);
            return name;
        }
        
        /// <summary>Gets the name of a BBS post, calling equivalent in BNDefinitions.</summary>
        /// <param name="bbs">The ID of the BBS.</param>
        /// <param name="post">The ID of the post.</param>
        /// <returns>The name of the post, or "Post #X" if not found.</returns>
        public string getBBSPost(int bbs, int post)
        {
            string name = "";
            if (getGameDef() != null)
                name = getGameDef().getBBSPost(bbs, post, true);
            return name;
        }
        
        /// <summary>Gets the name of a shop, calling equivalent in BNDefinitions.</summary>
        /// <param name="shop">The ID of the shop.</param>
        /// <returns>The name of the shop, or "Shop #X" if not found.</returns>
        public string getShopName(int shop)
        {
            string name = "";
            if (getGameDef() != null)
                name = getGameDef().getShopName(shop, true);
            return name;
        }
        
        /// <summary>Gets the name of the chip order shop, calling equivalent in BNDefinitions.</summary>
        /// <returns>The name of the chip order shop.</returns>
        public string getChipOrderShopName()
        {
            string name = "";
            if (getGameDef() != null)
                name = getGameDef().getChipOrderShopName();
            if (name != "")
                return name;
            return "Chip Order Shop";
        }
        
        /// <summary>Gets whether the shop trades for BugFrags instead of Zenny.</summary>
        /// <param name="shop">The ID of the shop.</param>
        /// <returns>Whether the shop uses BugFrags.</returns>
        public bool isBugFragShop(int shop)
        {
            if (getGameDef() != null)
                return getGameDef().isBugFragShop(shop);
            return false;
        }
        
        /// <summary>Gets a description for a story chapter value, calling equivalent in BNDefinitions.</summary>
        /// <param name="chapter">The story chapter.</param>
        /// <param name="noFallback">Whether to return direct result. Useful for checking defined chapters, as undefined ones will return an empty string.</param>
        /// <returns>The chapter number and its description in parentheses if found, or with noFallback, just the description.</returns>
        public string getChapterDesc(int chapter, bool noFallback = false)
        {
            string desc = "";
            if (getGameDef() != null)
                desc = getGameDef().getChapterDesc(chapter);
            if (noFallback)
                return desc;
            return chapter + (desc != ""? " (" + desc + ")" : "");
        }
        
        /// <summary>Gets the description for a flag, calling equivalent in BNDefinitions.</summary>
        /// <param name="flag">The flag number.</param>
        /// <returns>The flag description, if defined; if not, an empty string.</returns>
        public string getFlagDesc(int flag)
        {
            if (getGameDef() != null)
                return getGameDef().getFlagDesc(flag);
            return "";
        }
        
        /// <summary>For the Mystery Data associated with the flag, gets the "contents index" (for BMDs/GMDs, number of times collected in past loops).</summary>
        /// <param name="flag">The flag number.</param>
        /// <returns>The number used to decide what the Mystery Data gives.</returns>
        public byte getBN4MysteryDataContentsIndex(int flag)
        {
            if (game != 4)
                return 0;
            int mdIndex = flag - 3328;
            if ((mdIndex * 2) + 1 >= mysteryDataLocationAndContents.Length)
                return 0;
            return mysteryDataLocationAndContents[(mdIndex * 2) + 1];
        }
        
        /// <summary>For the Mystery Data associated with the flag, sets the "contents index" (for BMDs/GMDs, number of times collected in past loops).</summary>
        /// <param name="flag">The flag number.</param>
        /// <param name="index">The number used to decide what the Mystery Data gives (which for BMDs/GMDs is equivalent to past collections).</param>
        public void setBN4MysteryDataContentsIndex(int flag, byte index)
        {
            if (game != 4)
                return;
            int mdIndex = flag - 3328;
            if ((mdIndex * 2) + 1 >= mysteryDataLocationAndContents.Length)
                return;
            mysteryDataLocationAndContents[(mdIndex * 2) + 1] = index;
        }
        
        /* BYTE READING AND WRITING */
        
        /// <summary>Returns current file bytes, with or without XOR encryption applied to raw (decrypted) bytes.</summary>
        /// <param name="xorEncrypt">Whether to apply XOR to returned bytes.</param>
        /// <param name="withSpecialFormat">Whether to include header/footer for non-SRAM GBA formats on export.</param>
        /// <returns>The file bytes.</returns>
        public byte[] getFileBytes(bool xorEncrypt = true, bool withSpecialFormat = false)
        {
            byte[] myBytes = (byte[])fileBytes.Clone();
            if (game >= 4 && xorEncrypt)
            {
                int address = !lc? getGameDef().saveEncryptXORAddressGBA : getGameDef().saveEncryptXORAddressLC; 
                myBytes = xorBytes(myBytes, address);
            }
            
            if (withSpecialFormat && !lc)
            {
                if (gbaSaveFormat == "sps")
                    return getBytesForSharkPort(myBytes);
                else if (gbaSaveFormat == "gsv")
                    return getBytesForGameSharkSP(myBytes);
            }
            
            return myBytes;
        }
        
        /// <summary>Applies XOR to all bytes in an array using value from a specified address in the array.</summary>
        /// <param name="xorValueAddress">The address for the XOR value.</param>
        byte[] xorBytes(byte[] bytes, int xorValueAddress)
        {
            List<int> excludeRanges = new List<int>(new int[] { xorValueAddress, xorValueAddress + 3 });
            if (!lc) // Areas converted to FFs in save file not affected
                excludeRanges.AddRange(new int[] { getGameDef().saveAreaLengthGBA, bytes.Length });
            
            byte xorValue = bytes[xorValueAddress];
            for (int i = 0; i < bytes.Length; i++)
            {
                bool exclude = false;
                for (int k = 0; k < excludeRanges.Count; k += 2)
                {
                    if (i >= excludeRanges[k] && i <= excludeRanges[k + 1])
                    {
                        exclude = true;
                        break;
                    }
                }
                bytes[i] = getXORedByte(fileBytes[i], !exclude? xorValue : (byte)0);
            }
            
            return bytes;
        }
        
        /// <summary>Clears out file bytes. May be used for reformatting, testing from-scratch save creation, or helping to locate values.</summary>
        /// <param name="start">The index to start clearing at.</param>
        /// <param name="end">The index to stop clearing at (inclusive). Goes to end of fileBytes by default.</param>
        /// <param name="value">The byte value to "clear" with, 00 by default.</param>
        /// <param name="cyclingValue">Mode that increments (and cycles after FF) value each byte.</param>
        public void clearFileBytes(int start = 0, int end = -1, byte value = 0x00, bool cyclingValue = false)
        {
            if (end == -1)
                end = fileBytes.Length - 1;
            for (int i = start; i <= end; i++)
            {
                fileBytes[i] = value;
                if (cyclingValue)
                {
                    if (fileBytes[i] < 0xff)
                        value++;
                    else
                        value = 0x00;
                }
            }
        }
        
        /// <summary>Reads a byte from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <returns>The read value.</returns>
        public byte readByte(int position)
        {
            if (invalidPosition(position))
                return 0;
            return fileBytes[position];
        }
        
        /// <summary>Reads a series of bytes from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="count">The number of bytes to read.</param>
        /// <param name="lcOutOfBounds">Whether this is the special case where BN1 LC writes partially out of bounds.</param>
        /// <returns>The read values.</returns>
        public byte[] readBytes(int position, int count, bool lcOutOfBounds = false)
        {
            if ((!lcOutOfBounds || !lc) && invalidPosition(position, count))
                return new byte[0];
            
            byte[] bytes = new byte[count];
            while (lcOutOfBounds && lc && position + count > fileBytes.Length)
                count--;
            Buffer.BlockCopy(fileBytes, position, bytes, 0, count);
            return bytes;
        }
        
        /// <summary>Reads a series of bytes from file bytes, decoding them using a XOR value.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="count">The number of bytes to read.</param>
        /// <param name="xorValue">The byte to XOR each byte with.</param>
        /// <returns>The read (and decoded) bytes.</returns>
        public byte[] readXORedBytes(int position, int count, byte xorValue)
        {
            if (invalidPosition(position, count))
                return new byte[0];
            
            byte[] bytes = new byte[count];
            Buffer.BlockCopy(fileBytes, position, bytes, 0, count);
            for (int i = 0; i < bytes.Length; i++)
                bytes[i] = (byte)(bytes[i] ^ xorValue);
            return bytes;
        }
        
        /// <summary>Reads a ushort (2 bytes) from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="lcOutOfBounds">Whether this is the special case where BN1 LC writes partially out of bounds.</param>
        /// <returns>The read value.</returns>
        public ushort readUShort(int position, bool lcOutOfBounds = false)
        {
            if ((!lcOutOfBounds || !lc) && invalidPosition(position, 2))
                return 0;
            
            byte[] bytes = readBytes(position, 2, lcOutOfBounds);
            if (lcOutOfBounds && lc) // Behavior of BN1 LC nextPackSlotValue seems to be that the read byte only replaces the lower byte of default value 0x8000
                bytes[1] = 0x80;
            return BitConverter.ToUInt16(bytes, 0);
        }
        
        /// <summary>Reads a series of ushorts (2 bytes each) from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="count">The number of ushorts to read.</param>
        /// <returns>The read values.</returns>
        public ushort[] readUShorts(int position, int count)
        {
            if (invalidPosition(position, count * 2))
                return new ushort[0];
            
            ushort[] array = new ushort[count];
            for (int i = 0; i < count; i++)
                array[i] = readUShort(position + (i * 2));
            return array;
        }
        
        /// <summary>Reads a short (2 bytes) from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <returns>The read value.</returns>
        public short readShort(int position)
        {
            if (invalidPosition(position, 2))
                return 0;
            
            byte[] bytes = readBytes(position, 2);
            return BitConverter.ToInt16(bytes, 0);
        }
        
        /// <summary>Reads a series of shorts (2 bytes each) from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="count">The number of shorts to read.</param>
        /// <returns>The read values.</returns>
        public short[] readShorts(int position, int count)
        {
            if (invalidPosition(position, count * 2))
                return new short[0];
            
            short[] array = new short[count];
            for (int i = 0; i < count; i++)
                array[i] = readShort(position + (i * 2));
            return array;
        }
        
        /// <summary>Reads a short (2 bytes) from file bytes, decoding them using a XOR value.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="xorValue">The byte to XOR each byte with.</param>
        /// <returns>The decoded value.</returns>
        public short readXORedShort(int position, byte xorValue)
        {
            if (invalidPosition(position, 2))
                return 0;
            
            byte[] bytes = readXORedBytes(position, 2, xorValue);
            return BitConverter.ToInt16(bytes, 0);
        }
        
        /// <summary>Reads a uint (4 bytes) from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <returns>The read value.</returns>
        public uint readUInt(int position)
        {
            if (invalidPosition(position, 4))
                return 0;
            
            byte[] bytes = readBytes(position, 4);
            return BitConverter.ToUInt32(bytes, 0);
        }
        
        /// <summary>Reads a series of uints (4 bytes each) from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="count">The number of uints to read.</param>
        /// <returns>The read values.</returns>
        public uint[] readUInts(int position, int count)
        {
            if (invalidPosition(position, count * 4))
                return new uint[0];
            
            uint[] array = new uint[count];
            for (int i = 0; i < count; i++)
                array[i] = readUInt(position + (i * 4));
            return array;
        }
        
        /// <summary>Reads a uint (4 bytes) from file bytes, decoding them using a XOR value.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="xorValue">The byte to XOR each byte with.</param>
        /// <returns>The decoded value.</returns>
        public uint readXORedUInt(int position, byte xorValue)
        {
            if (invalidPosition(position, 4))
                return 0;
            
            byte[] bytes = readXORedBytes(position, 4, xorValue);
            return BitConverter.ToUInt32(bytes, 0);
        }
        
        /// <summary>Reads an int (4 bytes) from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <returns>The read value.</returns>
        public int readInt(int position)
        {
            if (invalidPosition(position, 4))
                return 0;
            
            byte[] bytes = readBytes(position, 4);
            return BitConverter.ToInt32(bytes, 0);
        }
        
        /// <summary>Reads a series of ints (4 bytes each) from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="count">The number of ints to read.</param>
        /// <returns>The read values.</returns>
        public int[] readInts(int position, int count)
        {
            if (invalidPosition(position, count * 4))
                return new int[0];
            
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
                array[i] = readInt(position + (i * 4));
            return array;
        }
        
        /// <summary>Reads a series of bit flags from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="byteCount">The number of bytes to read.</param>
        /// <param name="flipBytes">Whether to read the bytes in reverse order (i.e. the last byte representing flags 0-7).</param>
        /// <returns>A bool array of flag values.</returns>
        public bool[] readFlags(int position, int byteCount, bool flipBytes = false)
        {
            if (invalidPosition(position, byteCount))
                return new bool[0];
            
            bool[] flags = new bool[byteCount * 8];
            for (int byteNum = 0; byteNum < byteCount; byteNum++)
            {
                int byteIndex = !flipBytes? byteNum : byteCount - 1 - byteNum;
                if (position + byteIndex > fileBytes.Length)
                    return flags;
                
                byte flagByte = fileBytes[position + byteIndex];
                for (int k = 0; k < 8; k++)
                    flags[(byteNum * 8) + k] = (flagByte & (byte)Math.Pow(2, 7 - k)) != 0;
            }
            return flags;
        }
        
        /// <summary>Reads an ASCII string from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="length">The length of the string.</param>
        /// <returns>The read value.</returns>
        public string readASCIIString(int position, int length)
        {
            if (invalidPosition(position, length))
                return "";
            
            byte[] bytes = readBytes(position, length);
            return Encoding.ASCII.GetString(bytes);
        }
        
        /// <summary>Reads a string from file bytes using defined string table.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="length">The length of the string. If -1, keeps going until terminator is read.</param>
        /// <param name="terminator">The terminating byte.</param>
        /// <param name="myLanguage">Which language's string table to use, currently-set language by default.</param>
        /// <param name="subset">Restricts table to a certain limited set of characters.</param>
        /// <param name="blankIfInvalid">Whether to return a blank string if invalid character for language is encountered</param>
        /// <param name="oneByteMode">Whether to use a special mode for Legacy Collection that omits the leading 64 byte.</param>
        /// <returns>The read value.</returns>
        public string readTableString(int position, int length, byte terminator = 0x00, string myLanguage = "", string subset = "", bool blankIfInvalid = false, bool oneByteMode = false)
        {
            if (invalidPosition(position, length))
                return "";
            
            if (myLanguage == "")
                myLanguage = language;
            Dictionary<ushort, string> byteStringTable = getGameDef().getByteStringTable(myLanguage, lc, subset);
            
            // If going until terminator, read 256 bytes (limited if it goes past end of file), otherwise just read given length.
            int readLength = length != -1? length : 256;
            if (position + readLength >= fileBytes.Length)
                readLength = fileBytes.Length - position;
            
            byte[] bytes = readBytes(position, readLength);
            string str = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                byte b = bytes[i];
                if (length == -1 && b == terminator)
                    break;
                
                if (lc && oneByteMode) // In LC one-byte mode, interpret bytes as 0x64 folllowed by the byte
                {
                    ushort twoByteValue = (ushort)(0x6400 + b);
                    if (byteStringTable.ContainsKey(twoByteValue))
                        str += byteStringTable[twoByteValue];
                    else if (blankIfInvalid)
                        return "";
                    continue;
                }
                
                if (b + 1 < bytes.Length
                 && ((!lc && myLanguage == "jp" && b == 0xE4) // In GBA JP, 0xE4 signifies two-byte character
                  || (lc && (b == 0x64 || b == 0x65)))) // In LC, 0x64 and 0x65 (which is all except linebreak) signify two-byte character
                {
                    ushort twoByteValue = (ushort)((b * 256) + bytes[i + 1]);
                    if (byteStringTable.ContainsKey(twoByteValue))
                        str += byteStringTable[twoByteValue];
                    else if (blankIfInvalid)
                        return "";
                    i++;
                    continue;
                }
                
                if (byteStringTable.ContainsKey(b))
                    str += byteStringTable[b];
                else if (blankIfInvalid)
                    return "";
            }
            
            return str;
        }
        
        /// <summary>Reads strings from file bytes using defined string table.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="spacing">The byte spacing between strings.</param>
        /// <param name="count">The number of strings.</param>
        /// <param name="myLanguage">Which language's string table to use, currently-set language by default.</param>
        /// <param name="subset">Restricts table to a certain limited set of characters.</param>
        /// <param name="blankIfInvalid">Whether to return a blank string if invalid character for language is encountered.</param>
        /// <param name="oneByteMode">Whether to use a special mode for Legacy Collection that omits the leading 64 byte.</param>
        /// <returns>The read values.</returns>
        public string[] readTableStrings(int position, int spacing, int count, string myLanguage = "", string subset = "", bool blankIfInvalid = false, bool oneByteMode = false)
        {
            if (invalidPosition(position, count * spacing))
                return null;
            
            string[] strings = new string[count];
            for (int i = 0; i < count; i++)
                strings[i] = readTableString(position + (i * spacing), spacing - 1, (byte)(!lc? 0x00 : 0x01), myLanguage, subset, blankIfInvalid, oneByteMode);
            return strings;
        }
        
        /// <summary>Reads an array of FolderChips (essentially, a Folder) from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="count">The number of chips to read. Default: 30.</param>
        /// <returns>The FolderChip array.</returns>
        FolderChip[] readFolderChips(int position, int count = 30)
        {
            if (invalidPosition(position, count * FolderChip.length))
                return new FolderChip[0];
            
            FolderChip[] folderChips = new FolderChip[count];
            for (int i = 0; i < count; i++)
                folderChips[i] = new FolderChip(position + (i * FolderChip.length));
            return folderChips;
        }
        
        /// <summary>Reads an array of PackChipSets (essentially, the Pack) from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="count">The number of chip sets to read.</param>
        /// <returns>The PackChipSet array.</returns>
        PackChipSet[] readPackChipSets(int position, int count)
        {
            if (invalidPosition(position, count * PackChipSet.length))
                return new PackChipSet[0];
            
            PackChipSet[] packChipSets = new PackChipSet[count];
            for (int i = 0; i < count; i++)
                packChipSets[i] = new PackChipSet(position + (i * PackChipSet.length), i);
            return packChipSets;
        }
        
        /// <summary>Reads an array of ShopItems (essentially, a shop inventory) from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="itemCount">The number of items to read.</param>
        /// <returns>The ShopItem array.</returns>
        ShopItem[] readShopInventory(int position, int itemCount)
        {
            if (invalidPosition(position, itemCount * ShopItem.length))
                return new ShopItem[0];
            
            ShopItem[] inventory = new ShopItem[itemCount];
            for (int i = 0; i < itemCount; i++)
                inventory[i] = new ShopItem(position + (i * ShopItem.length));
            return inventory;
        }
        
        /// <summary>Reads a 2D array of ShopItems (essentially, all shop inventories) from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="shopCount">The number of shops to read.</param>
        /// <param name="itemCount">The item count of all shops.</param>
        /// <returns>The ShopItem 2D array.</returns>
        ShopItem[][] readShopInventories(int position, int shopCount, int itemCount)
        {
            // If defined for game, use manual list of addresses as override if they're not in a standard order.
            int[][] addresses = getDef<int[][]>("shopInventoryAddresses");
            if (addresses != null && addresses.Length > 0)
            {
                if (addresses.Length != shopCount)
                {
                    ConsoleC.WriteLineHL("{WARNING:} Shop addresses do not match given shop count.", "red");
                    return null;
                }
                
                ShopItem[][] scatteredInventories = new ShopItem[addresses.Length][];
                for (int i = 0; i < shopCount; i++)
                    scatteredInventories[i] = readShopInventory(addresses[i][!lc? 0 : 1], itemCount);
                return scatteredInventories;
            }
            
            if (invalidPosition(position, shopCount * itemCount * ShopItem.length))
                return new ShopItem[0][];
            
            ShopItem[][] inventories = new ShopItem[shopCount][];
            for (int i = 0; i < shopCount; i++)
                inventories[i] = readShopInventory(position + (i * itemCount * ShopItem.length), itemCount);
            return inventories;
        }
        
        /// <summary>Reads EncounterPointer object from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <returns>The EncounterPointer object.</returns>
        EncounterPointer readEncounterPointer(int position)
        {
            if (invalidPosition(position, 4))
                return new EncounterPointer();
            
            return new EncounterPointer(position);
        }
        
        /// <summary>Reads ProgramEffects object from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <returns>The ProgramEffects object.</returns>
        ProgramEffects readProgramEffects(int position)
        {
            if (invalidPosition(position, ProgramEffects.length))
                return new ProgramEffects();
            
            return new ProgramEffects(position);
        }
        
        /// <summary>Reads an array of ProgramEffects objects from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="count">The number of ProgramEffects sets to read.</param>
        /// <returns>The ProgramEffects array.</returns>
        ProgramEffects[] readProgramEffectsArray(int position, int count)
        {
            if (invalidPosition(position, ProgramEffects.length))
                return new ProgramEffects[0];
            
            ProgramEffects[] programEffectsArray = new ProgramEffects[count];
            for (int i = 0; i < count; i++)
                programEffectsArray[i] = new ProgramEffects(position + (i * ProgramEffects.length));
            return programEffectsArray;
        }
        
        /// <summary>Reads an array of placed NaviCust programs from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="count">The number of programs to read.</param>
        /// <returns>The PlacedProgram array.</returns>
        PlacedProgram[] readPlacedPrograms(int position, int count)
        {
            if (invalidPosition(position, count * PlacedProgram.length))
                return new PlacedProgram[0];
            
            PlacedProgram[] placedPrograms = new PlacedProgram[count];
            for (int i = 0; i < count; i++)
                placedPrograms[i] = new PlacedProgram(position + (i * PlacedProgram.length));
            return placedPrograms;
        }
        
        /// <summary>Reads an array of NPCs from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="count">The number of NPCs to read.</param>
        /// <returns>The NPCData array.</returns>
        NPCData[] readNPCs(int position, int count)
        {
            if (invalidPosition(position, count * NPCData.length))
                return new NPCData[0];
            
            NPCData[] npcs = new NPCData[count];
            for (int i = 0; i < count; i++)
                npcs[i] = new NPCData(position + (i * NPCData.length));
            return npcs;
        }
        
        /// <summary>Reads a 2D array of TournamentEntrants (essentially, all tournament boards) from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="tournamentCount">The number of tournaments to read.</param>
        /// <param name="entrantCount">The entrant count of all tournaments.</param>
        /// <returns>The TournamentEntrant 2D array.</returns>
        TournamentEntrant[][] readTournamentBoards(int position, int tournamentCount, int entrantCount)
        {
            if (invalidPosition(position, tournamentCount * entrantCount * TournamentEntrant.length))
                return new TournamentEntrant[0][];
            
            TournamentEntrant[][] boards = new TournamentEntrant[tournamentCount][];
            for (int i = 0; i < tournamentCount; i++)
                boards[i] = readTournamentBoard(position + (i * entrantCount * TournamentEntrant.length), entrantCount);
            return boards;
        }
        
        /// <summary>Reads an array of TournamentEntrants (essentially, a tournament board) from file bytes.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="entrantCount">The number of entrants to read.</param>
        /// <returns>The TournamentEntrant array.</returns>
        TournamentEntrant[] readTournamentBoard(int position, int entrantCount)
        {
            if (invalidPosition(position, entrantCount * TournamentEntrant.length))
                return new TournamentEntrant[0];
            
            TournamentEntrant[] entrants = new TournamentEntrant[entrantCount];
            for (int i = 0; i < entrantCount; i++)
                entrants[i] = new TournamentEntrant(position + (i * TournamentEntrant.length));
            return entrants;
        }
        
        /// <summary>Checks whether the string at the given address matches the given string.</summary>
        /// <param name="position">The address to read from.</param>
        /// <param name="str">The expected string.</param>
        /// <param name="def">Definition for the current game when XOR-ing and/or memory shifting is required.</param>
        /// <returns>Whether the string matches.</returns>
        public bool checkString(int position, string str, BNDefinitions def = null)
        {
            int myXORAddress = -1;
            int myShiftAddress = -1;
            
            if (def != null)
            {
                myXORAddress = !lc? def.saveEncryptXORAddressGBA : def.saveEncryptXORAddressLC;
                myShiftAddress = !lc? def.memoryShiftAddressGBA : def.memoryShiftAddressLC;
                
                if (myXORAddress > fileBytes.Length || myShiftAddress > fileBytes.Length)
                    return false;
            }
            
            byte xorValue = myXORAddress != -1? fileBytes[myXORAddress] : (byte)0;
            if (myShiftAddress != -1)
                position += readXORedShort(myShiftAddress, xorValue);
            
            if (position < 0)
                return false;
            
            byte[] strBytes = Encoding.ASCII.GetBytes(str);
            for (int i = 0; i < strBytes.Length; i++)
            {
                if (position + i > fileBytes.Length)
                    return false;
                
                byte readByte = getXORedByte(fileBytes[position + i], xorValue);
                if (readByte != strBytes[i])
                    return false;
            }
            return true;
        }
        
        /// <summary>Writes a byte to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="value">The value to write.</param>
        public void writeByte(int position, byte value)
        {
            if (invalidPosition(position))
                return;
            fileBytes[position] = value;
        }
        
        /// <summary>Writes a byte array to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="values">The values to write.</param>
        public void writeBytes(int position, byte[] values)
        {
            if (invalidPosition(position, values.Length))
                return;
            Buffer.BlockCopy(values, 0, fileBytes, position, values.Length);
        }
        
        /// <summary>Writes a ushort to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="lcOutOfBounds">Whether this is the special case where BN1 LC writes partially out of bounds.</param>
        public void writeUShort(int position, ushort value, bool lcOutOfBounds = false)
        {
            if ((!lcOutOfBounds || !lc) && invalidPosition(position, 2))
                return;
            
            int myLength = 2;
            if (lcOutOfBounds && lc && position + myLength > fileBytes.Length)
                myLength--;
            Buffer.BlockCopy(BitConverter.GetBytes(value), 0, fileBytes, position, myLength);
        }
        
        /// <summary>Writes a ushort array to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="values">The values to write.</param>
        public void writeUShorts(int position, ushort[] values)
        {
            if (invalidPosition(position, values.Length * 2))
                return;
            for (int i = 0; i < values.Length; i++)
                Buffer.BlockCopy(BitConverter.GetBytes(values[i]), 0, fileBytes, position + (i * 2), 2);
        }
        
        /// <summary>Writes a short to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="value">The value to write.</param>
        public void writeShort(int position, short value)
        {
            if (invalidPosition(position, 2))
                return;
            Buffer.BlockCopy(BitConverter.GetBytes(value), 0, fileBytes, position, 2);
        }
        
        /// <summary>Writes a short array to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="values">The values to write.</param>
        public void writeShorts(int position, short[] values)
        {
            if (invalidPosition(position, values.Length * 2))
                return;
            for (int i = 0; i < values.Length; i++)
                Buffer.BlockCopy(BitConverter.GetBytes(values[i]), 0, fileBytes, position + (i * 2), 2);
        }
        
        /// <summary>Writes a uint to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="value">The value to write.</param>
        public void writeUInt(int position, uint value)
        {
            if (invalidPosition(position, 4))
                return;
            Buffer.BlockCopy(BitConverter.GetBytes(value), 0, fileBytes, position, 4);
        }
        
        /// <summary>Writes a uint array to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="values">The values to write.</param>
        public void writeUInts(int position, uint[] values)
        {
            if (invalidPosition(position, values.Length * 4))
                return;
            for (int i = 0; i < values.Length; i++)
                Buffer.BlockCopy(BitConverter.GetBytes(values[i]), 0, fileBytes, position + (i * 4), 4);
        }
        
        /// <summary>Writes a uint value to a byte list.</summary>
        /// <param name="bytes">The list to add to.</param>
        /// <param name="value">The value to write.</param>
        public void writeUIntToBytes(List<byte> bytes, uint value)
        {
            bytes.AddRange(BitConverter.GetBytes(value));
        }
        
        /// <summary>Writes an int to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="value">The value to write.</param>
        public void writeInt(int position, int value)
        {
            if (invalidPosition(position, 4))
                return;
            Buffer.BlockCopy(BitConverter.GetBytes(value), 0, fileBytes, position, 4);
        }
        
        /// <summary>Writes an int array to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="values">The values to write.</param>
        public void writeInts(int position, int[] values)
        {
            if (invalidPosition(position, values.Length * 4))
                return;
            for (int i = 0; i < values.Length; i++)
                Buffer.BlockCopy(BitConverter.GetBytes(values[i]), 0, fileBytes, position + (i * 4), 4);
        }
        
        /// <summary>Writes bit flags to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="values">The bool values to write.</param>
        public void writeFlags(int position, bool[] flags, bool flipBytes = false)
        {
            for (int i = 0; i < flags.Length / 8; i++)
            {
                byte flagByte = 0;
                for (int k = 0; k < 8; k++)
                {
                    if (flags[(i * 8) + k])
                        flagByte += (byte)Math.Pow(2, 7 - k);
                }
                int destination = !flipBytes? position + i : position + (flags.Length / 8) - 1 - i;
                fileBytes[destination] = flagByte;
            }
        }
        
        /// <summary>Writes an ASCII string to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="value">The value to write.</param>
        public void writeASCIIString(int position, string value)
        {
            writeBytes(position, Encoding.ASCII.GetBytes(value));
        }
        
        /// <summary>Writes an ASCII string to a byte list.</summary>
        /// <param name="bytes">The list to add to.</param>
        /// <param name="value">The value to write.</param>
        public void writeASCIIStringToBytes(List<byte> bytes, string value)
        {
            bytes.AddRange(Encoding.ASCII.GetBytes(value));
        }
        
        /// <summary>Writes a string to file bytes using defined string table.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="oneByteMode">Whether to use a special mode for Legacy Collection that omits the leading 64 byte.</param>
        public void writeTableString(int position, string value, bool oneByteMode = false)
        {
            byte[] endBytes = null;
            if (oneByteMode)
            {
                if (!lc)
                    endBytes = new byte[] { 0x00 };
                else
                    endBytes = new byte[] { 0x01 };
            }
            writeBytes(position, getTableStringBytes(value, endBytes: endBytes, oneByteMode: oneByteMode));
        }
        
        /// <summary>Writes a string array to file bytes using defined string table.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="value">The value to write.</param>
        /// <param name="spacing">The byte spacing between strings.</param>
        /// <param name="count">The number of strings.</param>
        /// <param name="oneByteMode">Whether to use a special mode for Legacy Collection that omits the leading 64 byte.</param>
        public void writeTableStrings(int position, string[] values, int spacing, int count, bool oneByteMode = false)
        {
            for (int i = 0; i < count; i++)
                writeTableString(position + (i * spacing), values[i], oneByteMode);
        }
        
        /// <summary>Gets bytes for string using defined string table.</summary>
        /// <param name="str">The string to write.</param>
        /// <param name="startBytes">Optional bytes to include at the start.</param>
        /// <param name="endBytes">Optional bytes to include at the end.</param>
        /// <param name="fullLength">An optional length to pad to with 00s.</param>
        /// <param name="oneByteMode">Whether to use a special mode for Legacy Collection that omits the leading 64 byte.</param>
        /// <returns>The bytes for the string.</returns>
        public byte[] getTableStringBytes(string str, byte[] startBytes = null, byte[] endBytes = null, int fullLength = -1, bool oneByteMode = false)
        {
            Dictionary<string, ushort> stringByteTable = getGameDef().getStringByteTable(language, lc);
            List<byte> bytes = new List<byte>();
            if (startBytes != null)
                bytes.AddRange(startBytes);
            
            foreach (char c in str)
            {
                string charStr = c.ToString();
                if (stringByteTable.ContainsKey(charStr))
                {
                    ushort charValue = stringByteTable[charStr];
                    if (lc && oneByteMode && charValue >= 0x6400)
                        charValue -= 0x6400;
                    
                    if (charValue <= byte.MaxValue)
                        bytes.Add((byte)charValue);
                    else
                    {
                        bytes.Add((byte)(charValue / 256));
                        bytes.Add((byte)(charValue % 256));
                    }
                }
                //else
                    //Console.WriteLine("WARNING: Could not find " + charStr + " in string table.");
            }
            
            if (endBytes != null)
                bytes.AddRange(endBytes);
            
            if (fullLength != -1)
            {
                while (bytes.Count < fullLength)
                    bytes.Add(0x00);
            }
            
            return bytes.ToArray();
        }
        
        /// <summary>Writes a FolderChip array to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="chips">The chips to write.</param>
        void writeFolderChips(int position, FolderChip[] chips)
        {
            for (int i = 0; i < chips.Length; i++)
                chips[i].write(position + (i * FolderChip.length));
        }
        
        /// <summary>Writes a PackChipSet array to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="chipSets">The chip sets to write.</param>
        void writePackChipSets(int position, PackChipSet[] chipSets)
        {
            for (int i = 0; i < chipSets.Length; i++)
                chipSets[i].write(position + (i * PackChipSet.length));
        }
        
        /// <summary>Writes a ShopItem array to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="inventory">The inventory to write.</param>
        void writeShopInventory(int position, ShopItem[] inventory)
        {
            for (int i = 0; i < inventory.Length; i++)
                inventory[i].write(position + (i * ShopItem.length));
        }
        
        /// <summary>Writes a ShopItem 2D array to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="inventories">The inventories to write.</param>
        void writeShopInventories(int position, ShopItem[][] inventories)
        {
            // If defined for game, use manual list of addresses as override if they're not in a standard order.
            int[][] addresses = getDef<int[][]>("shopInventoryAddresses");
            if (addresses != null && addresses.Length > 0)
            {
                if (addresses.Length != shopInventories.Length)
                {
                    ConsoleC.WriteLineHL("{WARNING:} Shop addresses do not match shop count.", "red");
                    return;
                }
                
                for (int i = 0; i < shopInventories.Length; i++)
                    writeShopInventory(addresses[i][!lc? 0 : 1], shopInventories[i]);
                return;
            }
            
            int inventoryPosition = position;
            for (int i = 0; i < inventories.Length; i++)
            {
                writeShopInventory(inventoryPosition, inventories[i]);
                inventoryPosition += inventories[i].Length * ShopItem.length;
            }
        }
        
        /// <summary>Writes an EncounterPointer object to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        void writeEncounterPointer(int position, EncounterPointer pointer)
        {
            pointer.write(position);
        }
        
        /// <summary>Writes a ProgramEffects object to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        void writeProgramEffects(int position, ProgramEffects effects)
        {
            effects.write(position);
        }
        
        /// <summary>Writes a ProgramEffects array to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="effectSets">The effect sets to write.</param>
        void writeProgramEffectsArray(int position, ProgramEffects[] effectSets)
        {
            for (int i = 0; i < effectSets.Length; i++)
                effectSets[i].write(position + (i * ProgramEffects.length));
        }
        
        /// <summary>Writes a PlacedProgram array to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="programs">The programs to write.</param>
        void writePlacedPrograms(int position, PlacedProgram[] programs)
        {
            for (int i = 0; i < programs.Length; i++)
                programs[i].write(position + (i * PlacedProgram.length));
        }
        
        /// <summary>Writes an NPCData array to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="npcs">The NPCs to write.</param>
        void writeNPCs(int position, NPCData[] npcs)
        {
            for (int i = 0; i < npcs.Length; i++)
                npcs[i].write(position + (i * NPCData.length));
        }
        
        /// <summary>Writes a TournamentEntrant array to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="entrants">The inventory to write.</param>
        void writeTournamentBoard(int position, TournamentEntrant[] entrants)
        {
            for (int i = 0; i < entrants.Length; i++)
                entrants[i].write(position + (i * TournamentEntrant.length));
        }
        
        /// <summary>Writes a TournamentEntrant 2D array to file bytes.</summary>
        /// <param name="position">The address to write to.</param>
        /// <param name="boards">The inventories to write.</param>
        void writeTournamentBoards(int position, TournamentEntrant[][] boards)
        {
            int tournamentPosition = position;
            for (int i = 0; i < boards.Length; i++)
            {
                writeTournamentBoard(tournamentPosition, boards[i]);
                tournamentPosition += boards[i].Length * TournamentEntrant.length;
            }
        }
        
        /// <summary>Returns a byte encoded/decoded with a XOR value.</summary>
        /// <param name="value">The byte to be XORed.</param>
        /// <param name="xorValue">The value to XOR with.</param>
        /// <returns>The resulting byte value.</returns>
        byte getXORedByte(byte value, byte xorValue)
        {
            if (xorValue == 0)
                return value;
            return (byte)(value ^ xorValue);
        }
        
        /// <summary>Gets the sum of file bytes in the given range for calculating checksum.</summary>
        /// <param name="start">The address to start at.</param>
        /// <param name="end">The address to end at (inclusive). Goes to end of fileBytes by default.</param>
        /// <param name="excludeRanges">A list of alternating start and end values for address ranges to exclude.</param>
        /// <returns>The byte sum.</returns>
        uint sumOfBytes(int start = 0, int end = -1, int[] excludeRanges = null)
        {
            if (end == -1)
                end = fileBytes.Length - 1;
            
            uint total = 0;
            for (int i = start; i <= end; i++)
            {
                if (excludeRanges != null)
                {
                    bool exclude = false;
                    for (int k = 0; k < excludeRanges.Length; k += 2)
                    {
                        if (i >= excludeRanges[k] && i <= excludeRanges[k + 1])
                        {
                            exclude = true;
                            break;
                        }
                    }
                    if (exclude)
                        continue;
                }
                total += fileBytes[i];
            }
            
            return total;
        }
        
        /// <summary>Checks if position is within range of file bytes before attempting to read or write there.</summary>
        /// <param name="position">The starting address.</param>
        /// <param name="count">The byte count from that address.</param>
        /// <returns>Whether the position is invalid.</returns>
        bool invalidPosition(int position, int count = 1)
        {
            if (position < 0 || position >= fileBytes.Length || position + count - 1 >= fileBytes.Length)
            {
                if (!throwFileExceptions)
                {
                    Console.WriteLine("Invalid file position " + position.ToString("X2") + (count > 1? " (length " + count + ")" : "") + ".");
                    M.waitForEnter();
                }
                else
                    throw new Exception();
                return true;
            }
            return false;
        }
        
        /* GENERAL HELPER FUNCTIONS */
        
        /// <summary>Reads two bytes in a byte array as a ushort value.</summary>
        /// <param name="array">The byte array to read from.</param>
        /// <param name="index">The starting index to read at.</param>
        /// <returns>The two-byte value as a ushort.</returns>
        public static ushort readUShortInByteArray(byte[] array, int index)
        {
            if (index + 1 >= array.Length)
                return 0;
            
            return (ushort)(array[index] + (array[index + 1] * 256));
        }
        
        /// <summary>Writes a ushort alue as two bytes in a byte array.</summary>
        /// <param name="array">The byte array to write into.</param>
        /// <param name="index">The starting index to write at.</param>
        /// <param name="value">The ushort value to write.</param>
        public static void writeUShortInByteArray(ref byte[] array, int index, ushort value)
        {
            if (index + 1 >= array.Length)
                return;
            
            array[index] = (byte)(value % 256);
            array[index + 1] = (byte)(value / 256);
        }
        
        /// <summary>Swaps two values passed as reference.</summary>
        /// <param name="value1">The first value.</param>
        /// <param name="value2">The second value.</param>
        static void swapValues(ref byte value1, ref byte value2)
        {
            value1 = (byte)(value1 ^ value2);
            value2 = (byte)(value1 ^ value2);
            value1 = (byte)(value1 ^ value2);
        }
        
        /// <summary>Swaps two values in a list passed as reference.</summary>
        /// <param name="list">The list to swap within.</param>
        /// <param name="index1">The first index.</param>
        /// <param name="index2">The second index.</param>
        static void swapListValues(ref List<byte> list, int index1, int index2)
        {
            byte temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
        
        /// <summary>Gets a string representation of a byte array.</summary>
        /// <param name="bytes">The byte array.</param>
        /// <param name="rowLength">The number of bytes to print per row before going to a new line. Prints all on one line by default.</param>
        /// <returns>The string representation of the byte array.</returns>
        string getBytesAsString(byte[] bytes, int rowLength = -1)
        {
            StringWriter writer = new StringWriter(new StringBuilder());
            for (int i = 0; i < bytes.Length; i++)
            {
                if (i > 0 && rowLength != -1 && i % rowLength == 0)
                    writer.WriteLine();
                writer.Write(bytes[i].ToString("X2"));
                if (i + 1 < bytes.Length && (rowLength == -1 || (i + 1) % rowLength != 0))
                    writer.Write(" ");
            }
            return writer.ToString();
        }
        
        /* DEBUG FUNCTIONS */
        
        /// <summary>A debug function to aid in compiling chip definitions/adjusting alphabet ordering, by reading chip data from the ROM off the clipboard.</summary>
        /// <param name="game">The game number.</param>
        /// <param name="mode"><para>The processing mode.</para>
        /// <para>"data" (default): Puts data on clipboard in data order.</para>
        /// <para>"alphabet": Puts data on clipboard in alphabetical order.</para>
        /// <para>"unknownXX": Puts data on clipboard sorted by unknown value XX (in hexadecimal).</para>
        /// <para>"rewrite": After loading chip data, rewrites the bytes and copies them to clipboard, for testing write parity.</para>
        /// <para>"resort": Redoes alphabetical order values and copies new bytes to clipboard.</para>
        /// <para>"codedef": Compiles a list of defined code letters on clipboard for chipCodes definition.</para>
        /// <para>"sizedef": Compiles a list of memory sizes on clipboard for chipSizes definition.</para></param>
        /// <para>"orderdef": Compiles a list of internal IDs in in-game-ID order on clipboard for gameOrder definitions.</para>
        /// <param name="startAddress">The starting address from which the data was copied, used to display where each entry starts in the ROM.</param>
        public static void processROMChipData(int game, string mode = "data", int startAddress = -1)
        {
            List<ROMChipData> chipData = new List<ROMChipData>();
            int entryLength = ROMChipData.getLength(game);
            if (entryLength == 0)
                return;
            
            string str = Clipboard.GetText();
            string[] strBytes = str.Split(' ');
            for (int i = 0; i < strBytes.Length / entryLength; i++)
            {
                byte[] entryBytes = new byte[entryLength];
                for (int k = 0; k < entryLength; k++)
                {
                    if (!byte.TryParse(strBytes[(i * entryLength) + k], System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out entryBytes[k]))
                    {
                        Console.WriteLine("Invalid byte format.");
                        return;
                    }
                }
                chipData.Add(new ROMChipData(i, entryBytes, startAddress != -1? startAddress + (i * entryLength) : -1));
            }
            
            //ROMChipData.printKnownValues();
            
            if (mode == "data") // Write to clipboard in data order
            {
                StringWriter writer = new StringWriter();
                foreach (ROMChipData chip in chipData)
                    writer.WriteLine(chip.getString());
                Clipboard.SetText(writer.ToString());
            }
            else if (mode == "alphabet") // Write to clipboard in alphabetical order
            {
                Dictionary<int, ROMChipData> byAlphabetOrder = new Dictionary<int, ROMChipData>();
                foreach (ROMChipData chip in chipData)
                {
                    int order = chip.alphabetOrder;
                    if (order != 0)
                    {
                        if (byAlphabetOrder.ContainsKey(order))
                            Console.WriteLine("Multiple chips with alphabet order of " + order);
                        byAlphabetOrder[order] = chip;
                    }
                }
                
                List<int> orderNumbers = new List<int>(byAlphabetOrder.Keys);
                orderNumbers.Sort();
                
                StringWriter writer = new StringWriter();
                foreach (int order in orderNumbers)
                    writer.WriteLine(byAlphabetOrder[order].getString());
                Clipboard.SetText(writer.ToString());
            }
            else if (mode.StartsWith("unknown")) // i.e. unknown1F; write to clipboard sorted by an unknown value
            {
                byte unknownIndex = byte.Parse(mode.Replace("unknown", ""), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture);
                
                Dictionary<short, List<ROMChipData>> byUnknownValue = new Dictionary<short, List<ROMChipData>>();
                foreach (ROMChipData chip in chipData)
                {
                    short unknown = chip.unknowns[unknownIndex];
                    if (unknown != -1)
                    {
                        if (!byUnknownValue.ContainsKey(unknown))
                            byUnknownValue[unknown] = new List<ROMChipData>();
                        byUnknownValue[unknown].Add(chip);
                    }
                }
                
                List<short> orderNumbers = new List<short>(byUnknownValue.Keys);
                orderNumbers.Sort();
                
                StringWriter writer = new StringWriter();
                foreach (short unknown in orderNumbers)
                    foreach (ROMChipData chip in byUnknownValue[unknown])
                        writer.WriteLine(chip.getString(true));
                
                Clipboard.SetText(writer.ToString());
            }
            else if (mode == "rewrite") // After reading data into ROMChipData objects, rewrites to bytes, useful for verifying write parity
            {
                List<byte> newBytes = new List<byte>();
                foreach (ROMChipData chip in chipData)
                    newBytes.AddRange(chip.getBytes());
                
                StringWriter writer = new StringWriter();
                foreach (byte newByte in newBytes)
                    writer.Write(newByte.ToString("X2") + " ");
                Clipboard.SetText(writer.ToString());
            }
            else if (mode == "resort") // Redo alphabetical ordering and write new bytes to clipboard
            {
                Dictionary<string, ROMChipData> byChipName = new Dictionary<string, ROMChipData>();
                foreach (ROMChipData chip in chipData)
                {
                    int index = chip.index;
                    string chipName = getGameDef(game).chipNames[index];
                    if (chipName != "" && chipName != null && chip.alphabetOrder != 0) // Ignore chips like MegaBstr that were unsorted before
                    {
                        if (chipName == "Recov10") // Order by number value
                            chipName = "Recov010";
                        else if (chipName == "Recov30") // Order by number value
                            chipName = "Recov030";
                        else if (chipName == "Recov50") // Order by number value
                            chipName = "Recov050";
                        else if (chipName == "Recov80") // Order by number value
                            chipName = "Recov080";
                        else if (chipName == "YamatoMn") // Make base version YamatoMn sort before YamatManV2-V5
                            chipName = "YamatMn";
                        else if (chipName == "KendoMan") // Make base version KendoMan sort before KendMnDS/SP
                            chipName = "KendMn";
                        else if (chipName == "MetalMan") // Make base version MetalMan sort before MetlMnDS/SP (BN4) or MetalMnV2-V5 (BN3)
                            chipName = game == 4? "MetlMn" : "MetalMn";
                        else if (chipName == "SparkMan") // Make base version SparkMan sort before SprkMnDS/SP
                            chipName = "SprkMn";
                        else if (chipName == "SearchMn") // Make base version SearchMn sort before SrchMnDS/SP
                            chipName = "SrchMn";
                        else if (chipName == "VideoMan") // Make base version VideoMan sort before VideMnDS/SP
                            chipName = "VideMn";
                        
                        if (byChipName.ContainsKey(chipName))
                            Console.WriteLine("Multiple chips with name of " + chipName);
                        byChipName[chipName] = chip;
                    }
                }
                
                List<string> chipNames = new List<string>(byChipName.Keys);
                chipNames.Sort();
                
                for (int i = 0; i < chipNames.Count; i++)
                    byChipName[chipNames[i]].alphabetOrder = (ushort)(i + 1);
                
                List<byte> newBytes = new List<byte>();
                foreach (ROMChipData chip in chipData)
                    newBytes.AddRange(chip.getBytes());
                
                StringWriter writer = new StringWriter();
                foreach (byte newByte in newBytes)
                    writer.Write(newByte.ToString("X2") + " ");
                Clipboard.SetText(writer.ToString());
            }
            else if (mode == "codedef") // Compile chipCodes letter list for definitions
            {
                StringWriter writer = new StringWriter();
                for (int i = 0; i < chipData.Count; i++)
                    writer.WriteLine("\"" + chipData[i].getCodesString() + "\", // " + getGameDef(game).chipNames[i]);
                Clipboard.SetText(writer.ToString());
            }
            else if (mode == "sizedef") // Compile chipSizes list for definitions
            {
                StringWriter writer = new StringWriter();
                for (int i = 0; i < chipData.Count; i++)
                    writer.WriteLine(chipData[i].memorySize + ", // " + getGameDef(game).chipNames[i]);
                Clipboard.SetText(writer.ToString());
            }
            else if (mode == "orderdef") // Compile gameOrder chip ID list for definitions
            {
                Dictionary<int, ROMChipData> byIDOrder = new Dictionary<int, ROMChipData>();
                foreach (ROMChipData chip in chipData)
                {
                    int index = chip.index;
                    if (chip.idOrder != 0) // Ignore unassigned chips
                    {
                        if (byIDOrder.ContainsKey(chip.idOrder))
                            Console.WriteLine("Multiple chips with ID order of " + chip.idOrder);
                        byIDOrder[chip.idOrder] = chip;
                    }
                }
                
                List<int> chipIDs = new List<int>(byIDOrder.Keys);
                chipIDs.Sort();
                
                StringWriter writer = new StringWriter();
                foreach (int chipID in chipIDs)
                {
                    ROMChipData chip = byIDOrder[chipID];
                    writer.WriteLine(chip.index + ", // " + getGameDef(game).chipNames[chip.index]);
                }
                Clipboard.SetText(writer.ToString());
            }
            
            Console.WriteLine("Done processing ROM chip data.");
            M.waitForEnter();
        }
        
        /// <summary>A debug function to aid in creating other game definitions that refer to save data (usually from game start).</summary>
        /// <param name="mode"><para>The processing mode.</para>
        /// <para>"flags" (default): Creates definition strings for making a list of set flags using current ones from save data.</para>
        /// <para>"shops": Creates definition strings for shop inventories using current ones from save data.</para></param>
        public void generateGameDefinitions(string mode = "flags")
        {
            StringWriter writer = new StringWriter();
            
            if (mode == "flags")
            {
                int flagRangeStart = -1;
                for (int flag = 0; flag <= flags.Length; flag++)
                {
                    if (flag < flags.Length && flags[flag]) // If flag is set, consider it start of/part of a range for now
                    {
                        if (flagRangeStart == -1)
                            flagRangeStart = flag;
                    }
                    else // If flag is not set (or reached end), end range (which may have been just one flag) and write
                    {
                        if (flagRangeStart != -1)
                        {
                            if (flagRangeStart == flag - 1)
                                writer.WriteLine("flags.Add(" + flagRangeStart + ");");
                            else
                                writer.WriteLine("for (int i = " + flagRangeStart + "; i <= " + (flag - 1) + "; i++)" + Environment.NewLine
                                               + "flags.Add(i);");
                            flagRangeStart = -1;
                        }
                    }
                }
            }
            else if (mode == "shops")
            {
                for (int shopIndex = 0; shopIndex <= shopInventories.Length; shopIndex++) // Go one past normal shop inventories for chip order shop
                {
                    writer.WriteLine("shops[" + shopIndex + "] = new ShopItem[] {");
                    ShopItem[] shop;
                    if (shopIndex < shopInventories.Length)
                        shop = shopInventories[shopIndex];
                    else if (chipOrderInventory != null)
                        shop = chipOrderInventory;
                    else
                        break;
                    
                    for (int itemIndex = 0; itemIndex < shop.Length; itemIndex++)
                    {
                        if (itemIndex > 0)
                        {
                            if (itemIndex % 2 == 0)
                                writer.WriteLine(",");
                            else
                                writer.Write(", ");
                        }
                        ShopItem item = shop[itemIndex];
                        writer.Write("new ShopItem(" + item.getDefinitionArrayString() + ")");
                    }
                    writer.WriteLine();
                    writer.WriteLine("};");
                }
            }
            
            if (writer.ToString() != "")
                Clipboard.SetText(writer.ToString());
            
            Console.WriteLine("Done generating definitions.");
            M.waitForEnter();
        }
        
        /// <summary>A debug function to aid in compiling chipCodes definitions, by reading in a list of chip names and their codes from clipboard.</summary>
        public void convertChipCodeList()
        {
            // Desired format of input clipboard string:
            // Cannon A, B, C, D, E, *
            // HiCannon A, B, C, D, E, *
            // ...
            
            Dictionary<string, string> codesForChipName = new Dictionary<string, string>();
            StringWriter writer = new StringWriter(new StringBuilder());
            
            string str = Clipboard.GetText();
            string[] lines = str.Replace("\r\n", "\n").Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(' ');
                string codeList = "";
                for (int k = 1; k < parts.Length; k++)
                    codeList += parts[k].Replace(",", "").Trim();
                while (codeList.Length < 6)
                    codeList += "-";
                codesForChipName[parts[0]] = codeList;
            }
            
            string[] chipNames = getDef<string[]>("chipNames");
            for (int i = 0; i < chipNames.Length; i++)
            {
                string chipName = chipNames[i];
                if (codesForChipName.ContainsKey(chipName))
                    writer.WriteLine("\"" + codesForChipName[chipName] + "\", // " + chipName);
                else
                    writer.WriteLine("// " + chipName + " not found");
            }
            
            Clipboard.SetText(writer.ToString());
        }
    }
    
    /// <summary>Definition for a field within the save data that indicates its location and other parameters.</summary>
    class DataField
    {
        public string fieldName;
        public byte dataType;
        public int gbaAddress;
        public int lcAddress;
        public int gbaAddress2;
        public int lcAddress2;
        public int param;
        public int param2;
        public bool shifts;
        
        public DataField(string fieldName, byte dataType, int gbaAddress, int lcAddress, int param = -1, int param2 = -1, int gbaAddress2 = -1, int lcAddress2 = -1, bool shifts = false)
        {
            this.fieldName = fieldName;
            this.dataType = dataType;
            this.gbaAddress = gbaAddress;
            this.lcAddress = lcAddress;
            this.gbaAddress2 = gbaAddress2;
            this.lcAddress2 = lcAddress2;
            this.param = param;
            this.param2 = param2;
            this.shifts = shifts;
        }
        
        public int getAddress(bool lc)
        {
            int address = !lc? gbaAddress : lcAddress;
            if (shifts)
                address = M.saveData.getShiftedAddress(address);
            return address;
        }
        
        public int getAddress2(bool lc)
        {
            int address = !lc? gbaAddress2 : lcAddress2;
            if (shifts)
                address = M.saveData.getShiftedAddress(address);
            return address;
        }
    }
}
