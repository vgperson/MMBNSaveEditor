using System.Collections.Generic;

namespace MMBNSaveEditor
{
    /// <summary>Base class for an object that returns game-based definitions.</summary>
    abstract class BNDefinitions
    {
        public virtual string[] chipNames { get { return new string[0]; } }
        public virtual string[] paNames { get { return new string[0]; } }
        public virtual Dictionary<string, string[]> chipAliases { get { return new Dictionary<string, string[]>(); } }
        public virtual string[] chipCodes { get { return new string[0]; } }
        public virtual Dictionary<int, byte[]> unobtainableCodes { get { return new Dictionary<int, byte[]>(); } }
        public virtual int[] chipSizes { get { return new int[0]; } }
        
        public virtual int[] gameOrderStandardChips { get { return new int[0]; } }
        public virtual int[] gameOrderMegaChipsMain { get { return new int[0]; } }
        public virtual int[] gameOrderMegaChipsSub { get { return new int[0]; } }
        public virtual int[] gameOrderMegaChipsAll { get { return new int[0]; } }
        public virtual int[] gameOrderGigaChipsMain { get { return new int[0]; } }
        public virtual int[] gameOrderGigaChipsSub { get { return new int[0]; } }
        public virtual int[] gameOrderGigaChipsAll { get { return new int[0]; } }
        public virtual int[] gameOrderSecretChipsMain { get { return new int[0]; } }
        public virtual int[] gameOrderSecretChipsSub { get { return new int[0]; } }
        public virtual int[] gameOrderSecretChipsAll { get { return new int[0]; } }
        public virtual int[] gameOrderPAs { get { return new int[0]; } }
        
        public virtual string[] keyItemNames { get { return new string[0]; } }
        public virtual string[] upgradeItemNames { get { return new string[0]; } }
        public virtual int[][] upgradeItemFlags { get { return new int[0][]; } }
        public virtual string[] subchipNames { get { return new string[0]; } }
        public virtual int[][] shopInventoryAddresses { get { return new int[0][]; } }
        public virtual Dictionary<int, int[]> shopHPMemoryPrices { get { return new Dictionary<int, int[]>(); } }
        public virtual Dictionary<int, int[]> shopPowerUpPrices { get { return new Dictionary<int, int[]>(); } }
        public virtual Dictionary<int, int[]> shopKeyItemPrices { get { return new Dictionary<int, int[]>(); } }
        public virtual int[][] libraryFlagRanges { get { return new int[4][]; } }
        
        public virtual string[] presetFolderNames { get { return new string[0]; } }
        public virtual Dictionary<string, string[]> presetFolders { get { return new Dictionary<string, string[]>(); } }
        
        public virtual string[] programNames { get { return new string[0]; } }
        public virtual string[] programColors { get { return new string[0]; } }
        public virtual Dictionary<byte, object[]> programEffectDefs { get { return new Dictionary<byte, object[]>(); } }
        
        public virtual string[] numberTraderCodes { get { return new string[0]; } }
        
        public virtual string[] bbsNames { get { return new string[0]; } }
        public virtual string[] styleTypes { get { return new string[0]; } }
        
        public virtual string[] timeTrialNames { get { return new string[0]; } }
        
        public virtual Dictionary<byte, object[]> patchCardDefs { get { return new Dictionary<byte, object[]>(); } }
        
        public virtual object[] safeLocationLansRoom { get { return new object[0]; } }
        public virtual object[] startLocationForFreshSave { get { return new object[0]; } }
        public virtual object[] uninitializedJackInLocation { get { return new object[0]; } }
        
        public virtual Dictionary<string, ushort> getStringByteTable(string language = "en", bool lc = false, string subset = "") { return new Dictionary<string, ushort>(); }
        
        // Calls getStringByteTable and flips it; only the former needs to be defined for each game definition.
        public virtual Dictionary<ushort, string> getByteStringTable(string language = "en", bool lc = false, string subset = "")
        {
            Dictionary<string, ushort> stringByte = getStringByteTable(language, lc, subset);
            Dictionary<ushort, string> byteString = new Dictionary<ushort, string>();
            foreach (string key in stringByte.Keys)
                byteString[stringByte[key]] = key;
            return byteString;
        }
        
        public virtual int[] getGameStartFlags(char version = 'M') { return new int[0]; }
        public virtual ShopItem[][] getInitialShopInventories(char version = 'M') { return new ShopItem[0][]; }
        public virtual ShopItem[] getInitialChipOrderInventory(char version = 'M') { return new ShopItem[0]; }
        public virtual byte[] getInitialBBSPostsList() { return new byte[0]; }
        
        public virtual byte encounterPointerSpacing { get { return 0x8; } }
        public virtual uint getBaseEncounterPointerForArea(byte area, byte subsection = 0x00, char version = 'M', string language = "en", bool lc = false) { return 0; }
        public virtual Dictionary<int, string> getDefinedEncounters() { return new Dictionary<int, string>(); }
        
        public virtual int saveAreaLengthGBA {get { return 0x8000; } }
        public virtual int saveFileSizeLC {get { return 0x8000; } }
        public virtual int saveEncryptXORAddressGBA { get { return -1; } }
        public virtual int memoryShiftAddressGBA { get { return -1; } }
        public virtual int saveEncryptXORAddressLC { get { return -1; } }
        public virtual int memoryShiftAddressLC { get { return -1; } }
        
        public virtual string getSubareaName(int area, int subarea, bool returnArea = false, bool fallbackIfNotFound = false) { return ""; }
        public virtual string getMusicName(int music, bool fallbackIfNotFound = false) { return ""; }
        public virtual string getStyleName(int style, bool fallbackIfNotFound = false, bool includeLevel = true) { return ""; }
        public virtual string getEmailName(int email, bool fallbackIfNotFound = false) { return ""; }
        public virtual string getBBSPost(int bbs, int post, bool fallbackIfNotFound = false) { return ""; }
        public virtual string getShopName(int shop, bool fallbackIfNotFound = false) { return ""; }
        public virtual string getChipOrderShopName() { return ""; }
        public virtual bool isBugFragShop(int shop, bool fallbackIfNotFound = false) { return false; }
        public virtual string getChapterDesc(int chapter) { return ""; }
        public virtual string getFlagDesc(int flag) { return ""; }
        
        // Fully generic helpers for getting contents of arrays with appropriate fallbacks.
        public string getChipName(int chipID, bool fallbackIfNotFound = true)
        {
            string result = chipID < chipNames.Length? chipNames[chipID] : "";
            if (result != "")
                return result;
            return fallbackIfNotFound? "Chip #" + chipID : "";
        }
        public string getPAName(int paID, bool fallbackIfNotFound = true)
        {
            string result = paID < paNames.Length? paNames[paID] : "";
            if (result != "")
                return result;
            return fallbackIfNotFound? "PA #" + paID : "";
        }
        public string[] getAliasesForChipName(string chipName)
        {
            if (chipAliases != null && chipAliases.ContainsKey(chipName))
                return chipAliases[chipName];
            return new string[0];
        }
        public string getKeyItemName(int item, bool fallbackIfNotFound = true)
        {
            if (item < keyItemNames.Length)
                return keyItemNames[item];
            return fallbackIfNotFound? "Key Item #" + item : "";
        }
        public string getSubchipName(int subchip, bool fallbackIfNotFound = true)
        {
            if (subchip < subchipNames.Length)
                return subchipNames[subchip];
            return fallbackIfNotFound? "Subchip #" + subchip : "";
        }
        public string getUpgradeItemName(int item, bool fallbackIfNotFound = true)
        {
            if (item < upgradeItemNames.Length)
                return upgradeItemNames[item];
            return fallbackIfNotFound? "Upgrade Item #" + item : "";
        }
        public string getPresetFolderName(int folder, bool fallbackIfNotFound = true)
        {
            if (folder < presetFolderNames.Length)
                return presetFolderNames[folder];
            return fallbackIfNotFound? "Folder #" + folder : "";
        }
        public string[] getPresetFolder(string presetName)
        {
            if (presetFolders != null && presetFolders.ContainsKey(presetName))
                return presetFolders[presetName];
            return new string[0];
        }
        public string getProgramName(int program, bool fallbackIfNotFound = true)
        {
            if (program < programNames.Length)
                return programNames[program];
            return fallbackIfNotFound? "Program #" + program : "";
        }
    }
}
