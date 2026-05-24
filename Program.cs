using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MMBNSaveEditor
{
    /// <summary>The main editor program.</summary>
    class M
    {
        public static SaveData saveData;
        public static string loadedFilename = "";
        
        static int menu = 0;
        static int parentMenu = 0;
        static int menuPage = 0;
        static int menuPageCount = 1;
        static int flagCursor = 0;
        static int submenuArg = 0;
        static bool exit = false;
        static bool changesMade = false;
        
        public static int game { get { return saveData != null? saveData.game : 0; } }
        
        // Debug Options
        static bool debugSkipInitialPrompt = false; // Skip launch prompts to automatically show file load prompt
        static int debugLaunchToFreshSaveFor = 0; // Skip launch prompts to automatically start with a created fresh save for specified game
        static bool debugCompareFileChanges = false; // Store original loaded bytes, and show changes after writing new values when saving to file
        static bool debugAlwaysCreateFromBlank = false; // Blank all file bytes before writing values, testing from-scratch save creation with save values
        public static bool debugPrintChecksumsOnSave = false; // Show save (and library) checksum calculations when saving to file
        public static bool debugSaveUnXORedFile = false; // For games that encode save bytes with XOR, on load/save, write decoded bytes to .savx file
        public static int debugSaveUnXORedFileOnFailure = 0; // If load fails, still write decoded bytes to .savx file assuming given game number
        public static int debugListAddresses = 0; // After loading/creating a save, list defined fields for game by their addresses (1 GBA, 2 Legacy Collection)
        public static Dictionary<string, uint> debugForcedFieldValues = null; // Dictionary for forcing a specific value for field in fresh saves (defined below)
        
        public static Dictionary<string, int> userSettings;
        public static Dictionary<string, string> userSettingsStr;
        
        [STAThread]
        static void Main(string[] args)
        {
            Console.Title = "MMBN Save Editor";
            ConsoleC.enableConsoleColors();
            loadUserSettings();
            
            // Debug functions using data from clipboard, so they can run before loading save.
            //SaveData.processROMChipData(4, "data", 0x197EC);
            //SaveData.processROMChipData(4, "alphabet");
            //SaveData.processROMChipData(4, "unknown0E");
            //SaveData.processROMChipData(4, "rewrite");
            //SaveData.processROMChipData(4, "resort");
            //SaveData.processROMChipData(4, "codedef");
            //SaveData.processROMChipData(4, "sizedef");
            //SaveData.processROMChipData(4, "orderdef");
            
            // Definition for specific values to use in fresh saves for comparison.
            /*debugForcedFieldValues = new Dictionary<string, uint>();
            debugForcedFieldValues["ushort|memoryOffsetValue"] = 0x1E4;
            debugForcedFieldValues["tournamentRandomSeed"] = 0x4A9EC125;
            debugForcedFieldValues["zennyVerificationBase"] = 0x80D2C97;
            debugForcedFieldValues["bugFragsVerificationBase"] = 0x808CDB1;
            debugForcedFieldValues["karmaVerificationBase"] = 0x8113AD3;*/
            
            if (debugLaunchToFreshSaveFor > 0) // Launch directly into fresh save
            {
                char defaultVersion = debugLaunchToFreshSaveFor >= 3? userSettingsStr["NewSaveDefaultBN" + debugLaunchToFreshSaveFor + "Version"][0] : 'M';
                string defaultLanguage = userSettingsStr["NewSaveDefaultLanguage"];
                bool defaultLC = userSettingsStr["NewSaveDefaultPlatform"] == "lc";
                saveData = new SaveData(debugLaunchToFreshSaveFor, defaultVersion, defaultLanguage, defaultLC);
                loadedFilename = "";
                saveData.initFreshSaveData();
            }
            else if (debugSkipInitialPrompt) // Skip straight to load prompt
            {
                if (!loadSavePrompt())
                    return;
            }
            else // Show normal load/create save prompt
            {
                if (!showLoadOrCreatePrompt(true))
                    return;
            }
            
            // Debug functions that use save data.
            //saveData.generateGameDefinitions("flags");
            //saveData.generateGameDefinitions("shops");
            
            // If I want to change field values immediately after loading/creating saveData for testing purposes, do it here.
            
            while (!exit)
            {
                try
                {
                    switch (menu)
                    {
                        case 0: menu0Main(); break;
                        case 10: menu10Stats(); break;
                        case 20: menu20Customization(); break;
                        case 21: menu21ProgramEffects(); break;
                        case 30: menu30Chips(); break;
                        case 40: menu40Progress(); break;
                        case 41: menu41Flags(); break;
                        case 42: menu42TournamentBoards(); break;
                        case 50: menu50Items(); break;
                        case 51: menu51UpgradeItems(); break;
                        case 52: menu52UpgradeItemSubmenu(); break;
                        case 53: menu53MysteryDataCounts(); break;
                        case 60: menu60Miscellaneous(); break;
                        case 70: menu70SteamID(); break;
                        default: exit = true; break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                    Console.WriteLine(e.StackTrace);
                    
                    waitForEnter();
                }
            }
        }
        
        /// <summary>Loads the user settings file.</summary>
        static void loadUserSettings()
        {
            if (userSettings == null)
                userSettings = new Dictionary<string, int>();
            if (userSettingsStr == null)
                userSettingsStr = new Dictionary<string, string>();
            
            // Set default values.
            userSettings["SteamID"] = 0;
            userSettings["NewSaveDefaultGame"] = 0;
            userSettingsStr["NewSaveDefaultBN3Version"] = "M";
            userSettingsStr["NewSaveDefaultBN4Version"] = "M";
            userSettingsStr["NewSaveDefaultPlatform"] = "gba";
            userSettingsStr["NewSaveDefaultLanguage"] = "en";
            
            // Load settings from file.
            if (File.Exists("UserSettings.txt"))
            {
                using (StreamReader input = new StreamReader("UserSettings.txt"))
                {
                    string line;
                    while ((line = input.ReadLine()) != null)
                    {
                        if (line.StartsWith("@"))
                        {
                            int settingStart = line.IndexOf("@") + 1;
                            int equals = line.IndexOf("=");
                            string settingName = line.Substring(settingStart, equals - 1).Trim();
                            string settingStr = line.Substring(equals + 1).Trim();
                            
                            if (userSettingsStr.ContainsKey(settingName)) // String
                                userSettingsStr[settingName] = settingStr;
                            else // Number
                            {
                                int setting;
                                if (int.TryParse(settingStr, out setting))
                                    userSettings[settingName] = setting;
                            }
                        }
                    }
                }
            }
            
            // Validate settings.
            validateUserSetting("SteamID", 0, int.MaxValue, 0);
            validateUserSetting("NewSaveDefaultGame", 0, 4, 0);
            
            string key = "NewSaveDefaultBN3Version";
            switch (userSettingsStr[key].ToLower().Replace(" ", "").Trim())
            {
                case "white": case "w": userSettingsStr[key] = "s"; break;
                default: userSettingsStr[key] = "m"; break;
            }
            
            key = "NewSaveDefaultBN4Version";
            switch (userSettingsStr[key].ToLower().Replace(" ", "").Trim())
            {
                case "bluemoon": case "blue": case "bm": case "b": userSettingsStr[key] = "s"; break;
                default: userSettingsStr[key] = "m"; break;
            }
            
            key = "NewSaveDefaultPlatform";
            switch (userSettingsStr[key].ToLower().Replace(" ", "").Trim())
            {
                case "legacycollection": case "legacy": case "collection": case "lc": userSettingsStr[key] = "lc"; break;
                default: userSettingsStr[key] = "gba"; break;
            }
            
            key = "NewSaveDefaultLanguage";
            switch (userSettingsStr[key].ToLower().Replace(" ", "").Trim())
            {
                case "japanese": case "jp": case "ja": case "j": userSettingsStr[key] = "jp"; break;
                default: userSettingsStr[key] = "en"; break;
            }
        }
        
        /// <summary>Checks whether the given userSetting is valid, and if not, sets it to a default value.</summary>
        /// <param name="settingName">The key for the userSetting.</param>
        /// <param name="min">The minimum allowed value.</param>
        /// <param name="max">The maximum allowed value.</param>
        /// <param name="defaultValue">The default value</param>
        static void validateUserSetting(string settingName, int min, int max, int defaultValue)
        {
            if (userSettings[settingName] < min || userSettings[settingName] > max)
                userSettings[settingName] = defaultValue;
        }
        
        /// <summary>Shows initial prompt to load or create save.</summary>
        /// <param name="forStartup">Whether this is being shown on startup rather than being called from editor menu.</param>
        /// <return>Returns false if user chooses to exit.</return>
        static bool showLoadOrCreatePrompt(bool forStartup)
        {
            bool showStartPrompt = true;
            do
            {
                Console.Clear();
                ConsoleC.WriteLineHL("Press " + (forStartup? "{Enter} or " : "") + "{L} to load a save file.");
                ConsoleC.WriteLineHL("Press {C} to load save data from hex values on clipboard.");
                ConsoleC.WriteLineHL("Press {N} to create a new save from scratch.");
                if (forStartup)
                    ConsoleC.WriteLineHL("Press {X} to exit.");
                else
                    ConsoleC.WriteLineHL("Press {Enter} to go back to editing current save.");
                
                bool validInput;
                do
                {
                    validInput = true;
                    string newSaveInput = waitToGetInputString();
                    
                    if (!forStartup && (newSaveInput == "" || newSaveInput == "BACKSPACE")) // For non-startup version, Enter/Backspace goes back to editor
                        return false;
                    
                    switch (newSaveInput)
                    {
                        case "":
                        case "L":
                            if (loadSavePrompt())
                                showStartPrompt = false;
                            break;
                        
                        case "C":
                            Console.WriteLine();
                            if (tryReadingSaveFromClipboard())
                                showStartPrompt = false;
                            break;
                        
                        case "N":
                            Console.WriteLine();
                            if (newSavePrompt())
                                showStartPrompt = false;
                            break;
                        
                        case "X":
                            if (forStartup)
                                return false;
                            else
                                validInput = false;
                            break;
                        
                        default:
                            validInput = false;
                            break;
                    }
                } while (!validInput); // Stay in input loop unless valid input was pressed
            } while (showStartPrompt);
            
            return true;
        }
        
        /// <summary>Opens a file prompt to load a save.</summary>
        /// <returns>Whether a save was loaded successfully.</returns>
        [STAThread]
        static bool loadSavePrompt()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Save Formats|*.sav;*.sa2;*.sa3;*.sa4;*.bin;*.sps;*.xps;*.gsv|"
                + "GBA Save File (SRAM)|*.sav;*.sa2;*.sa3;*.sa4|MMBNLC Save File|*.bin|GBA SharkPort Save|*.sps;*.xps|GBA GameShark SP Save|*.gsv";
            dialog.Title = "Select Save File";
            
            string filename = "";
            bool tryLoad = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tryLoad = true;
                filename = dialog.FileName;
                string extension = Path.GetExtension(filename).ToLower();
                List<string> supportedExtensions = new List<string>(new string[] { ".sav", ".sa2", ".sa3", ".sa4", ".bin", ".sps", ".xps", ".gsv" });
                
                if (!supportedExtensions.Contains(extension))
                {
                    Console.WriteLine("Unrecognized file type.");
                    waitForEnter();
                    return false;
                }
                
                do
                {
                    try
                    {
                        saveData = new SaveData(File.ReadAllBytes(filename), extension.Equals(".bin"), extension);
                        loadedFilename = filename;
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Could not load " + Path.GetFileName(filename) + ". File may be in use.");
                        Console.WriteLine("Try again? (Y/N)");
                        string tryAgain = getTypedInput().ToUpper();
                        if (tryAgain != "Y")
                            tryLoad = false;
                    }
                } while (tryLoad);
            }
            
            if (!tryLoad) // Closed file prompt without choosing file or gave up on trying to load
                return false;
            
            Console.Clear();
            
            bool versionUncertain = true;
            bool languageUncertain = !saveData.lc;
            
            if (!saveData.initSaveData(ref versionUncertain, ref languageUncertain))
            {
                Console.WriteLine("Failed to load in save data.");
                waitForEnter();
                return false;
            }
            
            changesMade = false;
            
            Console.WriteLine("Save loaded!");
            Console.WriteLine("Press Enter to continue.");
            
            bool showedExtraPrompt = false;
            if (languageUncertain)
            {
                string otherLanguageName = saveData.language == "en"? "a Japanese" : "an English";
                string otherLanguageLetter = saveData.language == "en"? "J" : "E";
                Console.WriteLine("(If this is actually " + otherLanguageName + " save, press " + otherLanguageLetter + " now to switch.)");
                string langSwitchInput = waitToGetInputString();
                if (langSwitchInput.Equals(otherLanguageLetter))
                    saveData.updateLanguage(saveData.language == "en"? "jp" : "en", true);
                showedExtraPrompt = true;
            }
            
            if (game >= 3 && versionUncertain)
            {
                string otherVersionName = saveData.getVersionName(saveData.version == 'M'? 'S' : 'M');
                Console.WriteLine("(If this is actually a " + otherVersionName + " save, press V now to switch.)");
                string versionSwitchInput = waitToGetInputString();
                if (versionSwitchInput.Equals("V"))
                    saveData.updateGameVersion(saveData.version == 'M'? 'S' : 'M');
                showedExtraPrompt = true;
            }
            
            if (!showedExtraPrompt)
                waitForEnter();
            
            goToMenu(0);
            return true;
        }
        
        /// <summary>Opens a file prompt to save current save data to file.</summary>
        [STAThread]
        static void saveToFile()
        {
            if (saveData.lc && saveData.steamID == 0)
            {
                Console.Clear();
                Console.WriteLine("ATTENTION: Steam ID is currently set to 0.\n"
                    + "This is fine for non-Steam saves, but on Steam, it must match your user ID!\n"
                    + "Continue? (Y/N)");
                string yesNoPrompt = getTypedInput();
                if (yesNoPrompt.ToUpper() != "Y")
                    return;
            }
            
            if (saveData.lc != saveData.fileIsLC)
            {
                saveData.reformatFileBytes();
                saveData.writeFieldsToBytes(true);
            }
            else
            {
                byte[] originalBytes = null;
                if (debugCompareFileChanges)
                    originalBytes = (byte[])saveData.getFileBytes(false).Clone();
                if (debugAlwaysCreateFromBlank)
                    saveData.clearFileBytes();
                
                saveData.writeFieldsToBytes();
                
                if (debugCompareFileChanges)
                {
                    saveData.checkFileByteChangesDebug(originalBytes);
                    waitForEnter();
                }
            }
            
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = !saveData.lc? (saveData.gbaSaveFormat == "sav"? "GBA Save File (SRAM)|*.sav;*.sa2;*.sa3;*.sa4"
                                             : saveData.gbaSaveFormat == "sps"? "GBA SharkPort Save|*.sps;*.xps"
                                                                              : "GBA GameShark SP Save|*.gsv")
                                            : "MMBNLC Save File|*.bin";
            saveDialog.Title = "Select Save Destination";
            saveDialog.InitialDirectory = loadedFilename != ""? Path.GetDirectoryName(loadedFilename) : "";
            saveDialog.FileName = Path.GetFileName(loadedFilename);
            
            if (loadedFilename != "")
            {
                string saveExtension = !saveData.lc? "." + saveData.gbaSaveFormat : ".bin";
                if (Path.GetExtension(loadedFilename).ToLower() != saveExtension)
                    saveDialog.FileName = saveDialog.FileName.Replace(Path.GetExtension(loadedFilename), saveExtension);
            }
            
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Console.Clear();
                bool trySave = true;
                do
                {
                    try
                    {
                        File.WriteAllBytes(saveDialog.FileName, saveData.getFileBytes(withSpecialFormat: true));
                        Console.WriteLine("Save written to " + Path.GetFileName(saveDialog.FileName) + ".");
                        if (game >= 4 && debugSaveUnXORedFile)
                        {
                            string savxPath = saveDialog.FileName.Replace(Path.GetExtension(saveDialog.FileName), ".savx");
                            File.WriteAllBytes(savxPath, saveData.getFileBytes(true));
                            Console.WriteLine("Unencypted save written to " + Path.GetFileName(savxPath) + ".");
                        }
                        waitForEnter();
                        changesMade = false;
                        trySave = false;
                        loadedFilename = saveDialog.FileName;
                    }
                    catch
                    {
                        Console.WriteLine("Could not save to " + Path.GetFileName(saveDialog.FileName) + ". File may be in use.");
                        Console.WriteLine("Try again? (Y/N)");
                        string tryAgain = getTypedInput().ToUpper();
                        if (tryAgain != "Y")
                            trySave = false;
                    }
                } while (trySave);
            }
        }
        
        /// <summary>Attempts to load save data from hex values on clipboard, i.e. copied from save area of memory.</summary>
        /// <returns>Whether save was loaded successfully.</returns>
        static bool tryReadingSaveFromClipboard()
        {
            List<byte> clipBytes = getBytesFromClipboard();
            if (clipBytes == null || clipBytes.Count == 0)
                return false;
            
            saveData = new SaveData(clipBytes.ToArray());
            loadedFilename = "";
            
            Console.WriteLine("Read hex string of length 0x" + clipBytes.Count.ToString("X2") + " from clipboard.");
            
            bool versionUncertain = true;
            bool languageUncertain = true;
            
            if (!saveData.initSaveData(ref versionUncertain, ref languageUncertain, skipChecksumCheck: true))
            {
                Console.WriteLine("Failed to load in save data.");
                waitForEnter();
                return false;
            }
            
            changesMade = false;
            
            Console.WriteLine("Save loaded!");
            Console.WriteLine("Press Enter to continue.");
            waitForEnter();
            
            goToMenu(0);
            return true;
        }
        
        /// <summary>Prompts user to input game number and other info, and creates a blank save accordingly.</summary>
        /// <returns>Whether the save was created successfully.</returns>
        static bool newSavePrompt()
        {
            Console.WriteLine("Select a game:");
            for (int i = 1; i <= 4; i++)
                ConsoleC.WriteLineHL("{[" + i + "]} Mega Man Battle Network" + (i > 1? " " + i : ""));
            
            int gameNumber = waitToGetInputNumber(1, 4, enterDefault: userSettings["NewSaveDefaultGame"]);
            if (gameNumber <= 0)
                return false;
            
            Console.WriteLine("Selected Mega Man Battle Network" + (gameNumber > 1? " " + gameNumber : "") + ".");
            
            char versionChar = 'M';
            if (gameNumber >= 3) // Game with multiple versions
            {
                char defaultVersionChar = userSettingsStr["NewSaveDefaultBN" + gameNumber + "Version"].ToUpper()[0];
                int defaultVersionChoice = defaultVersionChar == 'M'? 1 : 2;
                
                Console.WriteLine();
                Console.WriteLine("Select game version (Enter for " + SaveData.getGameVersionName(gameNumber, defaultVersionChar) + "):");
                ConsoleC.WriteLineHL("{[1]} " + SaveData.getGameVersionName(gameNumber, 'M'));
                ConsoleC.WriteLineHL("{[2]} " + SaveData.getGameVersionName(gameNumber, 'S'));
                
                int versionIndex = waitToGetInputNumber(1, 2, enterDefault: defaultVersionChoice);
                if (versionIndex == 1)
                    versionChar = 'M';
                else if (versionIndex == 2)
                    versionChar = 'S';
                else
                    return false;
                
                Console.WriteLine("Selected " + SaveData.getGameVersionName(gameNumber, versionChar) + ".");
            }
            
            string defaultPlatformSetting = userSettingsStr["NewSaveDefaultPlatform"];
            string defaultPlatformStr = defaultPlatformSetting == "gba"? "GBA" : "Legacy Collection";
            int defaultPlatformChoice = defaultPlatformSetting == "gba"? 1 : 2;
            
            Console.WriteLine();
            Console.WriteLine("Select platform (Enter for " + defaultPlatformStr + "):");
            ConsoleC.WriteLineHL("{[1]} GBA");
            ConsoleC.WriteLineHL("{[2]} Legacy Collection");
            
            int platformNumber = waitToGetInputNumber(1, 2, enterDefault: defaultPlatformChoice);
            if (platformNumber < 0)
                return false;
            
            if (platformNumber == 1)
                Console.WriteLine("Selected GBA version.");
            else if (platformNumber == 2)
            {
                Console.WriteLine("Selected Legacy Collection.");
                if (userSettings["SteamID"] == 0) // If Steam ID not provided, show warning
                    ConsoleC.WriteLineHL("\n\n{NOTE:} Legacy Collection saves contain a Steam ID which must match your own.\n"
                        + "Be sure to set this if you plan to use the save with the Steam version.");
            }
            
            int languageNumber = 1;
            if (platformNumber == 1) // Only GBA has language differences in saves
            {
                string defaultLanguageSetting = userSettingsStr["NewSaveDefaultLanguage"];
                string defaultLanguageStr = defaultLanguageSetting == "en"? "English" : "Japanese";
                int defaultLanguageChoice = defaultLanguageSetting == "en"? 1 : 2;
                
                Console.WriteLine();
                Console.WriteLine("Select language (Enter for " + defaultLanguageStr + "):");
                ConsoleC.WriteLineHL("{[1]} English");
                ConsoleC.WriteLineHL("{[2]} Japanese");
                
                languageNumber = waitToGetInputNumber(1, 2, enterDefault: defaultLanguageChoice);
                if (languageNumber < 0)
                    return false;
            }
            
            saveData = new SaveData(gameNumber, versionChar, languageNumber == 1? "en" : "jp", platformNumber == 2);
            loadedFilename = "";
            saveData.initFreshSaveData();
            
            Console.WriteLine();
            Console.WriteLine("Save created!");
            Console.WriteLine("Press Enter to continue.");
            waitForEnter();
            
            goToMenu(0);
            return true;
        }
        
        /// <summary>Shows and handles main menu for editing saves.</summary>
        static void menu0Main()
        {
            parentMenu = 0;
            
            Console.Clear();
            ConsoleC.WriteLineColor("===== MMBN Save Editor =====", "yellow");
            Console.WriteLine("Press corresponding number/letter to enter menu/perform action.");
            Console.WriteLine();
            
            List<string[]> options = new List<string[]>();
            options.Add(new string[] { "stats", "Base Stats and Money" });
            options.Add(new string[] { "customization", "MegaMan Customization" });
            options.Add(new string[] { "chips", "Chips, Folders, Library" });
            options.Add(new string[] { "progress", "Progress and Location" });
            options.Add(new string[] { "items", "Collected Items" });
            options.Add(new string[] { "miscellaneous", "Miscellaneous" });
            if (saveData.lc)
                options.Add(new string[] { "steamID", "Steam ID (Legacy Collection)" });
            
            printOptions(options);
            printMainFunctions();
            
            bool validInput;
            do
            {
                validInput = true;
                string optionInput = waitToGetInputString();
                string selectedOption = getSelectedOption(options, optionInput);
                switch (selectedOption)
                {
                    case "stats":
                        goToMenu(10);
                        break;
                    case "customization":
                        goToMenu(20);
                        break;
                    case "chips":
                        goToMenu(30);
                        break;
                    case "progress":
                        goToMenu(40);
                        break;
                    case "items":
                        goToMenu(50);
                        break;
                    case "miscellaneous":
                        goToMenu(60);
                        break;
                    case "steamID":
                        goToMenu(70);
                        break;
                    default:
                        if (!checkMainFunctions(optionInput))
                            validInput = false;
                        break;
                }
            } while (!validInput); // Stay in input loop unless valid input was pressed
        }
        
        /* GENERAL MENU FUNCTIONS */
        
        /// <summary>Adds a menu option using info display text from SaveData.getFieldDisplayString.</summary>
        /// <param name="options">The option list.</param>
        /// <param name="fieldName">The name of the field.</param>
        static void addOptionInfo(List<string[]> options, string fieldName)
        {
            options.Add(new string[] { fieldName, saveData.getFieldDisplayString(fieldName) });
        }
        
        /// <summary>Prints a list of options, each one a string array containing an internal name and display text.</summary>
        /// <param name="options">The option list.</param>
        /// <param name="withBack">Whether to include option to go back a menu.</param>
        /// <param name="mainOptions">Whether these options are the primary options in a menu rather than options within a function.</param>
        /// <param name="columnCount">The number of columns to print options across.</param>
        /// <param name="columnWidth">The character width of columns (if not just one column).</param>
        /// <param name="withNumbers">Whether to include 1-based list numbers in brackets before each option.</param>
        /// <param name="onlyThisIndex">A particular option index to print. If one is specified, nothing else will be printed.</param>
        /// <param name="highlightThisIndex">A particular option to highlight in a special color.</param>
        /// <param name="noMainLinebreak">Omits final mainOptions linebreak, in case of a menu that doesn't have room to actually show main functions.</param>
        static void printOptions(List<string[]> options, bool mainOptions = true, int columnCount = 1, int columnWidth = 20, bool withNumbers = true, int onlyThisIndex = -1, int highlightThisIndex = -1, bool noMainLinebreak = false)
        {
            for (int i = 0; i < options.Count; i++)
            {
                if (onlyThisIndex != -1 && onlyThisIndex != i) // If only printing a particular index, skip all but that index
                    continue;
                
                if (columnCount > 1 && onlyThisIndex == -1 && i > 0 && i % columnCount == 0) // For multi-column printing, linebreak if at start of new row
                    Console.WriteLine();
                
                bool highlight = highlightThisIndex == i;
                string numberStr = withNumbers? "{[" + (i + 1) + "]} " : "";
                string optionStr = numberStr + (highlight? "<" : "") + options[i][1] + (highlight? ">" : "");
                
                if (columnCount > 1)
                {
                    int myWidth = columnWidth;
                    if (optionStr.Contains("{")) // Add highlight braces to column width to effectively not count them
                        myWidth += (optionStr.Split('{').Length - 1) + (optionStr.Split('}').Length - 1);
                    if (highlight) // Same for angle brackets added by highlight
                        myWidth += 2;
                    optionStr = string.Format("{0,-" + myWidth + "}", optionStr);
                }
                
                ConsoleC.WriteHL(optionStr, "lightblue", highlight? "limegreen" : "yellow");
                if (columnCount == 1)
                    Console.WriteLine();
            }
            
            if (columnCount > 1) // Need to go to new line after final multi-column entry
                Console.WriteLine();
            
            if (onlyThisIndex != -1)
                return;
            
            if (mainOptions)
            {
                if (menuPageCount != 1)
                    ConsoleC.WriteLineHL("{[?]} Change Page (" + (menuPage + 1) + "/" + menuPageCount + ")");
                if (menu != 0)
                    ConsoleC.WriteLineHL("{[0]} Back");
                if (!noMainLinebreak)
                    Console.WriteLine();
            }
        }
        
        /// <summary>Prints a list of options that is just a string list, with no internal names for each option.</summary>
        /// <param name="options">The option list.</param>
        /// <param name="withBack">Whether to include option to go back a menu.</param>
        /// <param name="mainOptions">Whether these options are the primary options in a menu rather than options within a function.</param>
        /// <param name="columnCount">The number of columns to print options across.</param>
        /// <param name="columnWidth">The character width of columns (if not just one column).</param>
        /// <param name="withNumbers">Whether to include 1-based list numbers in brackets before each option.</param>
        /// <param name="onlyThisIndex">A particular option index to print. If one is specified, nothing else will be printed.</param>
        /// <param name="highlightThisIndex">A particular option to highlight in a special color.</param>
        static void printOptions(List<string> options, bool mainOptions = true, int columnCount = 1, int columnWidth = 20, bool withNumbers = true, int onlyThisIndex = -1, int highlightThisIndex = -1)
        {
            List<string[]> options2 = new List<string[]>();
            foreach (string option in options)
                options2.Add(new string[] { "", option });
            printOptions(options2, mainOptions, columnCount, columnWidth, withNumbers, onlyThisIndex, highlightThisIndex);
        }
        
        /// <summary>Enters a loop waiting for the user to press Enter (or other keys) to continue.</summary>
        public static void waitForEnter()
        {
            while (true)
            {
                Console.CursorVisible = false;
                if (Console.KeyAvailable)
                {
                    string key = getInputStringFromKeyPressed(Console.ReadKey(true).Key);
                    if (key.Equals("") || key.Equals("BACKSPACE") || key.Equals("0"))
                        break;
                }
                System.Threading.Thread.Sleep(30);
            }
        }
        
        /// <summary>Prompts to type input, showing text cursor.</summary>
        public static string getTypedInput()
        {
            Console.CursorVisible = true;
            string result = Console.ReadLine();
            Console.CursorVisible = false;
            return result;
        }
        
        /// <summary>Enters a loop waiting for the user to press a key, and returns the string representation of that key.</summary>
        /// <returns>The string representation of the pressed key.</returns>
        static string waitToGetInputString()
        {
            while (true)
            {
                Console.CursorVisible = false;
                if (Console.KeyAvailable)
                {
                    string result = getInputStringFromKeyPressed(Console.ReadKey(true).Key);
                    while (Console.KeyAvailable) // Only take the first key and clear any other pending input
                        Console.ReadKey(true);
                    return result;
                }
                System.Threading.Thread.Sleep(30);
            }
        }
        
        /// <summary>Enters a loop waiting for the user to press a key, and returns number for number keys .</summary>
        /// <param name="min">Optional minimum desired number.</param>
        /// <param name="max">Optional maximum desired number.</param>
        /// <param name="retryUntilValid">Whether to keep waiting until if a valid in-range number, or Enter/Backspace, is pressed.</param>
        /// <param name="enterDefault">An optional default to return if Enter is pressed.</param>
        /// <returns>The number for the pressed key. Returns -1 if not a number, -2 if out of range, -3 for Enter, -4 for Backspace.</returns>
        static int waitToGetInputNumber(int min = -1, int max = -1, bool retryUntilValid = true, int enterDefault = -3)
        {
            do
            {
                string inputString = waitToGetInputString();
                
                if (inputString == "")
                    return enterDefault;
                else if (inputString == "BACKSPACE")
                    return -4;
                
                int inputNumber = -1;
                if (!int.TryParse(inputString, out inputNumber))
                {
                    if (retryUntilValid)
                        continue;
                    else
                        return -1;
                }
                
                if ((min != -1 && inputNumber < min) || (max != -1 && inputNumber > max))
                {
                    if (retryUntilValid)
                        continue;
                    else
                        return -2;
                }
                
                return inputNumber;
            } while (true);
        }
        
        /// <summary>Given an input string, returns internal name of the option it matches.</summary>
        /// <param name="options">The option list.</param>
        /// <param name="optionInput">The user's input.</param>
        /// <param name="mainOptions">Whether these options are the primary options in a menu rather than options within a function.</param>
        /// <returns>The internal name of the selected option. Empty string if no match.</returns>
        static string getSelectedOption(List<string[]> options, string optionInput, bool mainOptions = true)
        {
            if (mainOptions && menuPageCount != 1)
            {
                if (optionInput == "" || optionInput == "?" || optionInput == "RIGHT")
                {
                    menuPage = (menuPage + 1) % menuPageCount;
                    return "PAGE";
                }
                else if (optionInput == "LEFT")
                {
                    menuPage = (menuPage + menuPageCount - 1) % menuPageCount;
                    return "PAGE";
                }
            }
            
            int optionIndex = -1;
            if (int.TryParse(optionInput, out optionIndex))
            {
                optionIndex--;
                if (optionIndex >= 0 && optionIndex < options.Count)
                    return options[optionIndex][0];
            }
            return "";
        }
        
        /// <summary>Given an input string, returns index of the option it matches.</summary>
        /// <param name="options">The option list.</param>
        /// <param name="optionInput">The user's input.</param>
        /// <param name="mainOptions">Whether these options are the primary options in a menu rather than options within a function.</param>
        /// <returns>The index of the selected option. -1 if no match.</returns>
        static int getSelectedOptionIndex(List<string> options, string optionInput, bool mainOptions = false)
        {
            if (mainOptions && menuPageCount != 1)
            {
                if (optionInput == "" || optionInput == "?" || optionInput == "RIGHT")
                {
                    menuPage = (menuPage + 1) % menuPageCount;
                    return -2;
                }
                else if (optionInput == "LEFT")
                {
                    menuPage = (menuPage + menuPageCount - 1) % menuPageCount;
                    return -2;
                }
            }
            
            int optionIndex = -1;
            if (int.TryParse(optionInput, out optionIndex))
            {
                optionIndex--;
                if (optionIndex >= 0 && optionIndex < options.Count)
                    return optionIndex;
            }
            return -1;
        }
        
        /// <summary>Given an input string, returns internal name of the option it matches, converted to an int.</summary>
        /// <param name="options">The option list.</param>
        /// <param name="optionInput">The user's input.</param>
        /// <returns>The index of the selected option. -1 if no match, or if internal name could not be parsed as an int.</returns>
        static int getSelectedOptionAsInt(List<string[]> options, string optionInput)
        {
            string result = getSelectedOption(options, optionInput);
            int resultInt = -1;
            if (int.TryParse(result, out resultInt))
                return resultInt;
            return -1;
        }
        
        /// <summary>Returns string equivalent of a ConsoleKey.</summary>
        /// <param name="keyPressed">The key that was pressed.</param>
        /// <returns>The all-caps string representation of the key pressed. Note that Enter is represented by a blank string.</returns>
        static string getInputStringFromKeyPressed(ConsoleKey keyPressed)
        {
            switch (keyPressed)
            {
                case ConsoleKey.Enter: return "";
                case ConsoleKey.D0: case ConsoleKey.NumPad0: return "0";
                case ConsoleKey.D1: case ConsoleKey.NumPad1: return "1";
                case ConsoleKey.D2: case ConsoleKey.NumPad2: return "2";
                case ConsoleKey.D3: case ConsoleKey.NumPad3: return "3";
                case ConsoleKey.D4: case ConsoleKey.NumPad4: return "4";
                case ConsoleKey.D5: case ConsoleKey.NumPad5: return "5";
                case ConsoleKey.D6: case ConsoleKey.NumPad6: return "6";
                case ConsoleKey.D7: case ConsoleKey.NumPad7: return "7";
                case ConsoleKey.D8: case ConsoleKey.NumPad8: return "8";
                case ConsoleKey.D9: case ConsoleKey.NumPad9: return "9";
                case ConsoleKey.LeftArrow: return "LEFT";
                case ConsoleKey.RightArrow: return "RIGHT";
                case ConsoleKey.UpArrow: return "UP";
                case ConsoleKey.DownArrow: return "DOWN";
                case ConsoleKey.Backspace: return "BACKSPACE";
            }
            return keyPressed.ToString().ToUpper();
        }
        
        /// <summary>Prints primary functions available in all menus.</summary>
        static void printMainFunctions()
        {
            ConsoleC.WriteLineHL("{[Z]} Save to File " + (!changesMade? "(no changes)" : "(changes made)") + "\n"
                + "{[C]} Copy Save Info to Clipboard\n"
                + (game >= 3? ("{[V]} Game Version: " + saveData.getVersionName() + "\n") : "")
                + "{[B]} Exporting As: " + (!saveData.lc? "GBA" : "Legacy Collection")
                                         + (!saveData.lc? (saveData.language == "en"? " English" : " Japanese") : "")
                                         + (!saveData.lc && saveData.gbaSaveFormat != "sav"? " (." + saveData.gbaSaveFormat + ")" : "") + "\n"
                + "{[L]} Load or Create New Save\n"
                + "{[X]} Quit");
        }
        
        /// <summary>Checks if user inputted any of primary functions and performs them.</summary>
        /// <param name="optionInput">The user's input.</param>
        /// <returns>Whether a valid function input was matched.</returns>
        static bool checkMainFunctions(string optionInput)
        {
            switch (optionInput)
            {
                case "Z":
                    saveToFile();
                    return true;
                
                case "C":
                    saveData.printSaveInfoToClipboard();
                    waitForEnter();
                    return true;
                
                case "V":
                    if (game >= 3)
                    {
                        saveData.updateGameVersion(saveData.version == 'M'? 'S' : 'M');
                        changesMade = true;
                        return true;
                    }
                    else
                        return false;
                
                case "B":
                    Console.WriteLine("\nSelect an export setting to toggle:");
                    ConsoleC.WriteLineHL("{[1]} Release: GBA / Legacy Colection");
                    if (!saveData.lc)
                    {
                        ConsoleC.WriteLineHL("{[2]} Language: English / Japanese");
                        ConsoleC.WriteLineHL("{[3]} Save Format: SRAM (.sav) / SharkPort (.sps/xps) / GameShark SP (.gsv)");
                    }
                    
                    int formatOption = waitToGetInputNumber(1, !saveData.lc? 3 : 1);
                    if (formatOption < 0)
                        return true;
                    
                    if (formatOption == 1)
                        saveData.updateGBAorLC(!saveData.lc);
                    else if (!saveData.lc)
                    {
                        if (formatOption == 2)
                            saveData.updateLanguage(saveData.language == "en"? "jp" : "en");
                        else
                            saveData.gbaSaveFormat = saveData.gbaSaveFormat == "sav"? "sps" : saveData.gbaSaveFormat == "sps"? "gsv" : "sav";
                    }
                    
                    changesMade = true;
                    return true;
                
                case "L":
                    showLoadOrCreatePrompt(false);
                    return true;
                
                case "0":
                case "BACKSPACE":
                    if (menu != parentMenu)
                    {
                        menu = parentMenu;
                        menuPage = 0;
                        menuPageCount = 1;
                        return true;
                    }
                    else
                        return false;
                
                case "X":
                    Console.WriteLine("\nAre you sure you want to quit? (Y/N)");
                    string quitPrompt = getTypedInput().ToUpper();
                    if (quitPrompt.Equals("Y"))
                        exit = true;
                    return true;
                
                default:
                    return false;
            }
        }
        
        /// <summary>Changes to the given menu, resetting other menu variables.</summary>
        /// <param name="newMenu">The menu to change to.</param>
        static void goToMenu(int newMenu)
        {
            menu = newMenu;
            menuPage = 0;
            menuPageCount = 1;
            flagCursor = 0;
        }
        
        /* MENUS */
        
        /// <summary>Shows and handles stats menu.</summary>
        static void menu10Stats()
        {
            parentMenu = 0;
            
            Console.Clear();
            ConsoleC.WriteLineColor("----- Base Stats and Money -----", "pink");
            Console.WriteLine("Press corresponding number/letter to edit value/perform action.");
            Console.WriteLine();
            
            List<string[]> options = new List<string[]>();
            addOptionInfo(options, "currentHP");
            addOptionInfo(options, "maxHP");
            addOptionInfo(options, "zenny");
            if (game >= 2)
            {
                addOptionInfo(options, "bugFrags");
                addOptionInfo(options, "regularMemory");
            }
            
            printOptions(options);
            printMainFunctions();
            
            bool validInput;
            do
            {
                validInput = true;
                string optionInput = waitToGetInputString();
                string selectedOption = getSelectedOption(options, optionInput);
                switch (selectedOption)
                {
                    case "currentHP":
                        Console.WriteLine("\nType new HP (will be kept within max HP):");
                        editUShort(ref saveData.currentHP, max: saveData.getTotalHPWithExtras());
                        break;
                    
                    case "maxHP":
                        editMenuMaxHP();
                        break;
                    
                    case "zenny":
                        uint maximumZenny = saveData.getZennyMaximum();
                        Console.WriteLine("\nType new Zenny amount (maximum " + maximumZenny + "):");
                        editUInt(ref saveData.zenny, max: maximumZenny);
                        break;
                    
                    case "bugFrags":
                        Console.WriteLine("\nType new BugFrags amount (maximum 9999):");
                        editUInt(ref saveData.bugFrags, max: 9999);
                        break;
                    
                    case "regularMemory":
                        if (game >= 3) // Even though it doesn't have Reg+ programs, opening NaviCust in BN4 still resets this
                            ConsoleC.WriteLineHL("\n{WARNING:} This Regular Memory value will be reset whenever NaviCust is run,\n"
                                + "based on " + (game == 3? "collected RegUPs and Reg+ programs" : "number of collected RegUPs") + ". It's recommended that you\n"
                                + "edit RegUPs directly under [5] Collected Items > Upgrade Items.\n\n"
                                + "Type new (temporary) Regular Memory:", "red");
                        else
                            Console.WriteLine("\nType new Regular Memory:");
                        
                        byte regMemoryBase = game >= 4? (byte)4 : (byte)0;
                        ushort actualRegMemory = (ushort)(saveData.regularMemory + regMemoryBase);
                        editUShort(ref actualRegMemory, regMemoryBase, (ushort)(255 + regMemoryBase));
                        saveData.regularMemory = (byte)(actualRegMemory - regMemoryBase);
                        break;
                    
                    default:
                        if (!checkMainFunctions(optionInput))
                            validInput = false;
                        break;
                }
            } while (!validInput); // Stay in input loop unless valid input was pressed
        }
        
        /// <summary>Handler for editing max HP in Stats menu.</summary>
        static void editMenuMaxHP()
        {
            ushort maximumBaseHP = saveData.getTheoreticalHPMaximum();
            if (game < 4) // Edit maxHP directly
            {
                bool hpMaxed = saveData.currentHP == saveData.maxHP;
                
                if (game == 2) // Include note about HubStyle halving HP
                    ConsoleC.WriteLineHL("\n{NOTE:} This HP value will be halved if HubStyle is equipped.\n"
                        + "Type new (base) maximum HP (up to " + maximumBaseHP + "):");
                else if (game == 3) // Of the pre-BN4 games, maxHP resetting is only an issue in BN3
                    ConsoleC.WriteLineHL("\n{WARNING:} This maximum HP value will be reset whenever NaviCust is run,\n"
                        + "based on collected HPMemories and HP+ programs. It's recommended that you\n"
                        + "edit HPMemories directly under [5] Collected Items > Upgrade Items.\n\n"
                        + "Type new (temporary) maximum HP (up to " + maximumBaseHP + "):", "red");
                else
                    Console.WriteLine("\nType new maximum HP (up to " + maximumBaseHP + "):");
                
                if (editUShort(ref saveData.maxHP, 1, maximumBaseHP))
                {
                    if (game == 3)
                        saveData.programEffects.setTotalHP(saveData.maxHP);
                    if (saveData.currentHP > saveData.maxHP || hpMaxed)
                        saveData.currentHP = saveData.maxHP;
                }
            }
            else // Edit baseMaxHP
            {
                int maxHPWithAll = saveData.getTotalHPWithExtras();
                int maxHPWithPrograms = saveData.getTotalHPWithExtras(true);
                int programAddedHP = maxHPWithPrograms - saveData.baseMaxHP;
                bool hpMaxed = saveData.currentHP == maxHPWithAll;
                
                Console.WriteLine("\nCurrent base max HP (without extra from programs" + (game == 4? "/mods" : "") + ") is " + saveData.baseMaxHP + ".");
                Console.WriteLine("Type new base max HP (up to " + maximumBaseHP + "):");
                if (editUShort(ref saveData.baseMaxHP, 1, maximumBaseHP))
                {
                    ushort newHPWithPrograms = (ushort)(saveData.baseMaxHP + programAddedHP);
                    if (saveData.overallMaxHP != newHPWithPrograms)
                    {
                        saveData.overallMaxHP = newHPWithPrograms;
                        changesMade = true;
                    }
                    
                    ushort newHPWithAll = saveData.getTotalHPWithExtras();
                    if (hpMaxed || saveData.currentHP > newHPWithAll) // Either raise to meet new higher value, or cap to new lower value
                    {
                        saveData.currentHP = newHPWithAll;
                        changesMade = true;
                    }
                }
            }
        }
        
        /// <summary>Shows and handles customization menu.</summary>
        static void menu20Customization()
        {
            parentMenu = 0;
            
            Console.Clear();
            ConsoleC.WriteLineColor("----- MegaMan Customization -----", "pink");
            Console.WriteLine("Press corresponding number/letter to edit value/enter menu/perform action.");
            Console.WriteLine();
            
            List<string[]> options = new List<string[]>();
            
            if (game == 1 || game == 2)
            {
                addOptionInfo(options, "attackUpgrades");
                addOptionInfo(options, "rapidUpgrades");
                addOptionInfo(options, "chargeUpgrades");
            }
            
            if (game == 1)
                addOptionInfo(options, "activeArmor");
            else if (game == 2 || game == 3)
                addOptionInfo(options, "activeStyle");
            
            if (game == 2)
                addOptionInfo(options, "registeredStyles");
            else if (game == 3)
                addOptionInfo(options, "registeredStyle");
            
            if (game == 3)
                addOptionInfo(options, "styleLevel");
            
            if (game == 2 || game == 3)
                addOptionInfo(options, "battlesSinceStyleChange");
            
            if (game == 2)
                options.Add(new string[] { "styleProgress", "Style Points: " + printArray(saveData.styleProgressInts) });
            else if (game == 3)
                options.Add(new string[] { "styleProgress", "Style Points: " + printArray(saveData.styleProgressBytes) });
            
            if (game == 3)
                addOptionInfo(options, "styleAdvancementMode");
            
            if (game >= 3)
                options.Add(new string[] { "programEffects", "Equipped Program Effects..." });
            
            if (game >= 4)
                addOptionInfo(options, "karma");
            
            if (game == 4)
                options.Add(new string[] { "patchCards", "Patch Cards..." });
            
            printOptions(options);
            printMainFunctions();
            
            string[] styleTypes = saveData.getDef<string[]>("styleTypes");
            
            bool validInput;
            do
            {
                validInput = true;
                string optionInput = waitToGetInputString();
                string selectedOption = getSelectedOption(options, optionInput);
                switch (selectedOption)
                {
                    case "attackUpgrades":
                    case "rapidUpgrades":
                    case "chargeUpgrades":
                        Console.WriteLine("\nType new number of buster upgrades (0 to 4):");
                        if (selectedOption == "attackUpgrades")
                            editByte(ref saveData.attackUpgrades, 0, 4);
                        else if (selectedOption == "rapidUpgrades")
                            editByte(ref saveData.rapidUpgrades, 0, 4);
                        else if (selectedOption == "chargeUpgrades")
                            editByte(ref saveData.chargeUpgrades, 0, 4);
                        break;
                    
                    case "activeArmor":
                        Console.WriteLine("\nSelect active armor:");
                        ConsoleC.WriteLineHL("{[1]} Normal Armor");
                        ConsoleC.WriteLineHL("{[2]} HeatArmr");
                        ConsoleC.WriteLineHL("{[3]} AquaArmr");
                        ConsoleC.WriteLineHL("{[4]} WoodArmr");
                        
                        int armorNumber = waitToGetInputNumber(1, 4);
                        if (armorNumber < 0)
                            break;
                        
                        saveData.activeArmor = armorNumber == 1? (byte)0 : (byte)armorNumber;
                        break;
                    
                    case "activeStyle":
                        editMenuActiveOrRegisteredStyle(true);
                        break;
                    
                    case "registeredStyle":
                        editMenuActiveOrRegisteredStyle(false);
                        break;
                    
                    case "registeredStyles":
                        editMenuBN2RegisteredStyles();
                        break;
                    
                    case "styleLevel":
                        Console.WriteLine("\nType new style level (0 to 3):");
                        editByte(ref saveData.styleLevel, 0, 3);
                        break;
                    
                    case "battlesSinceStyleChange":
                        Console.WriteLine("\nType new battle count (" + (game == 2? "279+ for style change next battle" : "100+ triggers style change") + "):");
                        if (game == 2)
                        {
                            if (editUInt(ref saveData.battlesSinceStyleChangeInt))
                            {
                                // Auto-set "style change next battle" flag, which is normally set at exactly 280, so user setting it higher will still trigger it.
                                if (saveData.battlesSinceStyleChangeInt >= 280)
                                    saveData.setFlag(42);
                            }
                        }
                        else if (game == 3)
                            editUShort(ref saveData.battlesSinceStyleChangeShort);
                        break;
                    
                    case "styleProgress":
                        List<string> styleProgressOptions = saveData.getStyleProgressList();
                        
                        Console.WriteLine("\nSelect style to edit:");
                        printOptions(styleProgressOptions, false);
                        
                        int styleIndex = waitToGetInputNumber(1, styleProgressOptions.Count);
                        if (styleIndex < 0)
                            break;
                        styleIndex--; // Change to zero-based index
                        
                        Console.WriteLine();
                        Console.WriteLine("Type new points value for " + styleTypes[styleIndex] + " style:");
                        if (game == 2)
                            editUInt(ref saveData.styleProgressInts[styleIndex]);
                        else
                            editByte(ref saveData.styleProgressBytes[styleIndex]);
                        break;
                    
                    case "styleAdvancementMode":
                        toggle01Byte(ref saveData.styleAdvancementMode);
                        break;
                    
                    case "programEffects":
                        goToMenu(21);
                        break;
                    
                    case "karma":
                        Console.WriteLine("\nType new karma level (starts at 500):");
                        ushort karmaValue = saveData.programEffects.getKarma();
                        editUShort(ref karmaValue);
                        saveData.programEffects.setKarma(karmaValue);
                        break;
                    
                    case "patchCards":
                        editMenuPatchCards();
                        break;
                    
                    default:
                        if (!checkMainFunctions(optionInput))
                            validInput = false;
                        break;
                }
            } while (!validInput); // Stay in input loop unless valid input was pressed
        }
        
        /// <summary>Handler for editing either active or registered style (latter is BN3 only, as BN2 has multiple registered styles) in Customization menu.</summary>
        /// <param name="forActiveStyle">Whether this is for the activeStyle option.</param>
        static void editMenuActiveOrRegisteredStyle(bool forActiveStyle)
        {
            if (game == 2 && forActiveStyle) // For BN2 activeStyle, prompt to select a registered style to set to, but allow editing freely with a warning
            {
                List<string[]> styleOptions = saveData.getBN2RegisteredStylesOptions();
                int registeredStyleCount = styleOptions.Count;
                styleOptions.Add(new string[] { "freeEdit", "Set Freely" });
                
                Console.WriteLine();
                Console.WriteLine("Select registered style to set as active:");
                printOptions(styleOptions, false);
                
                int styleOptionIndex = waitToGetInputNumber(1, styleOptions.Count);
                if (styleOptionIndex < 0)
                    return;
                string styleSelection = styleOptions[styleOptionIndex - 1][0]; // Get ID string for selected option
                
                if (!styleSelection.Equals("freeEdit"))
                {
                    byte registeredStylesSelectedIndex = byte.Parse(styleSelection);
                    string selectedStyleName = BN2Definitions.getRegisteredStyleName(registeredStylesSelectedIndex, includeLevel: false);
                    byte levelValue = saveData.registeredStyles[registeredStylesSelectedIndex];
                    
                    for (int styleID = 0; styleID < 0x40; styleID++)
                    {
                        string checkingStyleName = saveData.getStyleName(styleID, false);
                        if (checkingStyleName.Equals(selectedStyleName))
                        {
                            saveData.activeStyle = (byte)(styleID + ((levelValue - 1) * 0x40));
                            break;
                        }
                    }
                    return;
                }
                else
                {
                    ConsoleC.WriteLineHL("\n{NOTE:} Active Styles not in the list of Registered Styles\n"
                        + "will \"disappear\" if you switch to another style in the MegaMan menu.\n"
                        + "Also, style levels are stored as part of the list of Registered Styles,\n"
                        + "so they are considered to be zero for unregistered styles.", "limegreen");
                }
            }
            
            string[] styleTypes = saveData.getDef<string[]>("styleTypes");
            
            List<string> styleTypeOptions = new List<string>();
            styleTypeOptions.Add("Normal");
            foreach (string styleType in styleTypes)
                styleTypeOptions.Add(styleType);
            if (game == 2)
                styleTypeOptions.Add("HubStyle");
            
            Console.WriteLine("\nSelect style type:");
            printOptions(styleTypeOptions, false);
            
            int baseStyleIndex = waitToGetInputNumber(1, styleTypeOptions.Count);
            if (baseStyleIndex < 0)
                return;
            baseStyleIndex--; // Change to zero-based index
            
            if (baseStyleIndex == 0) // Normal style, no further element
            {
                if ((forActiveStyle? saveData.activeStyle : saveData.registeredStyle) != 0)
                {
                    if (forActiveStyle)
                        saveData.activeStyle = 0;
                    else
                        saveData.registeredStyle = 0;
                    changesMade = true;
                }
            }
            else if (game == 2 && forActiveStyle && styleTypeOptions[baseStyleIndex].Equals("HubStyle")) // No further element
            {
                byte styleID = 0x28;
                if (saveData.activeStyle != styleID)
                {
                    saveData.activeStyle = styleID;
                    changesMade = true;
                }
            }
            else // Ask for element
            {
                Console.WriteLine();
                Console.WriteLine("Selected type " + styleTypeOptions[baseStyleIndex] + ".");
                
                Console.WriteLine();
                Console.WriteLine("Select style element:");
                ConsoleC.WriteLineHL("{[1]} Elec");
                ConsoleC.WriteLineHL("{[2]} Heat");
                ConsoleC.WriteLineHL("{[3]} Aqua");
                ConsoleC.WriteLineHL("{[4]} Wood");
                
                int elementNum = waitToGetInputNumber(1, 4);
                if (elementNum < 0)
                    return;
                
                byte styleID = (byte)((baseStyleIndex * 8) + elementNum);
                if ((forActiveStyle? saveData.activeStyle : saveData.registeredStyle) != styleID)
                {
                    if (forActiveStyle)
                        saveData.activeStyle = styleID;
                    else
                        saveData.registeredStyle = styleID;
                    changesMade = true;
                }
            }
            
            if (game == 3 && forActiveStyle) // Set "registered style equipped" flag based on activeStyle
                saveData.programEffects.setActiveStyle((byte)(saveData.activeStyle == 0? 1 : 2));
        }
        
        /// <summary>Handler for editing "list" of registered styles in BN2.</summary>
        static void editMenuBN2RegisteredStyles()
        {
            List<string[]> styleOptions = saveData.getBN2RegisteredStylesOptions();
            int registeredStyleCount = styleOptions.Count;
            if (registeredStyleCount < 3)
                styleOptions.Add(new string[] { "newStyle", "Register New Style" });
            
            Console.WriteLine();
            Console.WriteLine("Select registered style to edit:");
            printOptions(styleOptions, false);
            
            int styleOptionIndex = waitToGetInputNumber(1, styleOptions.Count);
            if (styleOptionIndex < 0)
                return;
            string styleSelection = styleOptions[styleOptionIndex - 1][0]; // Get ID string for selected option
            
            byte registeredStylesSelectedIndex = 0xFF;
            if (!styleSelection.Equals("newStyle")) // Selecting an existing style
            {
                registeredStylesSelectedIndex = byte.Parse(styleSelection);
                string selectionName = styleOptions[styleOptionIndex - 1][1];
                
                Console.WriteLine();
                Console.WriteLine("Selected " + selectionName + ".");
                
                List<string[]> editingTypeOptions = new List<string[]>();
                if (!selectionName.Equals("NormStyl") && !selectionName.Equals("HubStyle")) // Style that can be leveled
                    editingTypeOptions.Add(new string[] { "editLevel", "Change Style Level" });
                editingTypeOptions.Add(new string[] { "replaceStyle", "Replace Style" });
                if (registeredStyleCount > 1) // Don't allow deleting style if there's only one
                    editingTypeOptions.Add(new string[] { "deleteStyle", "Unregister Style" });
                
                if (editingTypeOptions.Count > 1) // More than one option
                {
                    Console.WriteLine();
                    printOptions(editingTypeOptions, false);
                    int editingTypeIndex = waitToGetInputNumber(1, editingTypeOptions.Count);
                    if (editingTypeIndex < 0)
                        return;
                    string editingTypeSelection = editingTypeOptions[editingTypeIndex - 1][0];
                    
                    if (editingTypeSelection.Equals("editLevel"))
                    {
                        Console.WriteLine();
                        ConsoleC.WriteLineHL("{[1]} Level 1");
                        ConsoleC.WriteLineHL("{[2]} Level 2");
                        ConsoleC.WriteLineHL("{[3]} Level 3");
                        
                        int levelNum = waitToGetInputNumber(1, 3);
                        if (levelNum < 0)
                            return;
                        
                        saveData.setBN2RegisteredStyle(registeredStylesSelectedIndex, (byte)levelNum);
                        changesMade = true;
                        return;
                    }
                    else if (editingTypeSelection.Equals("deleteStyle"))
                    {
                        saveData.removeBN2RegisteredStyle(registeredStylesSelectedIndex);
                        changesMade = true;
                        return;
                    }
                    // Otherwise, continue to choose a style to "replace" this one.
                }
            }
            
            string[] styleTypes = saveData.getDef<string[]>("styleTypes");
            
            List<string> styleTypeOptions = new List<string>();
            styleTypeOptions.Add("Normal");
            foreach (string styleType in styleTypes)
                styleTypeOptions.Add(styleType);
            styleTypeOptions.Add("HubStyle");
            
            Console.WriteLine();
            Console.WriteLine("Select style type:");
            printOptions(styleTypeOptions, false);
            
            int baseStyleIndex = waitToGetInputNumber(1, styleTypeOptions.Count);
            if (baseStyleIndex < 0)
                return;
            baseStyleIndex--; // Change to zero-based index
            string baseStyleSelection = styleTypeOptions[baseStyleIndex];
            
            if (baseStyleSelection.Equals("Normal") || baseStyleSelection.Equals("HubStyle")) // No further element
            {
                byte styleIndex = (byte)(baseStyleSelection.Equals("NormStyl")? 0x00 : 0x19);
                if (saveData.setBN2RegisteredStyle(styleIndex))
                {
                    if (registeredStylesSelectedIndex != 0xFF) // If this is replacing a currently registered style, unregister that style
                        saveData.removeBN2RegisteredStyle(registeredStylesSelectedIndex);
                    changesMade = true;
                }
            }
            else // Ask for element
            {
                Console.WriteLine();
                Console.WriteLine("Selected type " + baseStyleSelection + ".");
                
                Console.WriteLine();
                Console.WriteLine("Select style element:");
                ConsoleC.WriteLineHL("{[1]} Elec");
                ConsoleC.WriteLineHL("{[2]} Heat");
                ConsoleC.WriteLineHL("{[3]} Aqua");
                ConsoleC.WriteLineHL("{[4]} Wood");
                
                int elementIndex = waitToGetInputNumber(1, 4);
                if (elementIndex < 0)
                    return;
                elementIndex--; // Change to zero-based index
                
                byte styleTypeBaseIndex = 0;
                switch (baseStyleSelection)
                {
                    case "Guts": styleTypeBaseIndex = 0x06; break;
                    case "Custom": styleTypeBaseIndex = 0x0B; break;
                    case "Team": styleTypeBaseIndex = 0x10; break;
                    case "Shield": styleTypeBaseIndex = 0x14; break;
                }
                
                byte styleIndex = (byte)(styleTypeBaseIndex + elementIndex);
                if (saveData.setBN2RegisteredStyle(styleIndex))
                {
                    if (registeredStylesSelectedIndex != 0xFF) // If this is replacing a currently registered style, unregister that style
                        saveData.removeBN2RegisteredStyle(registeredStylesSelectedIndex);
                    changesMade = true;
                }
            }
        }
        
        /// <summary>Handler for editing Patch Cards.</summary>
        static void editMenuPatchCards()
        {
            Console.WriteLine("\nSelect a Patch Card slot to edit:");
            List<string> slotOptions = saveData.getPatchCardSlotList();
            printOptions(slotOptions, false);
            
            int slotIndex = waitToGetInputNumber(1, slotOptions.Count);
            if (slotIndex < 0)
                return;
            slotIndex--; // Change to zero-based index
            
            // If slot is filled, prompt to either toggle active/inactive or proceed to replacing it with a new card.
            if (saveData.isPatchCardSlotFilled(slotIndex))
            {
                Console.WriteLine();
                ConsoleC.WriteLineHL("{[1]} Toggle Active/Inactive");
                ConsoleC.WriteLineHL("{[2]} Replace Patch Card");
                ConsoleC.WriteLineHL("{[3]} Remove Card From Slot");
                
                int togglePrompt = waitToGetInputNumber(1, 3);
                if (togglePrompt < 0)
                    return;
                
                if (togglePrompt == 1) // Toggle
                {
                    saveData.togglePatchCardActive(slotIndex);
                    saveData.switchEquippedFolderIfInvalid(); // Check folder validity in case limits were affected
                    changesMade = true;
                    return;
                }
                else if (togglePrompt == 3) // Empty
                {
                    saveData.emptyPatchCardSlot(slotIndex);
                    changesMade = true;
                    return;
                }
                // Otherwise, continue on to set new card.
            }
            
            Console.WriteLine();
            List<string[]> patchCardOptions = saveData.getPatchCardOptionsForSlot(slotIndex);
            printOptions(patchCardOptions, false, 2, 30, withNumbers: false);
            
            Console.WriteLine("Type number of card to register to slot 0" + (char)('A' + slotIndex) + ":");
            string cardInput = getTypedInput();
            
            byte cardID;
            if (!byte.TryParse(cardInput, out cardID))
                return;
            
            // Check options to see if the number entered was a valid choice from the list.
            bool validOption = false;
            foreach (string[] option in patchCardOptions)
            {
                if (byte.Parse(option[0]) == cardID) // Matches the card's number
                {
                    validOption = true;
                    break;
                }
            }
            
            if (!validOption)
                return;
            
            saveData.setPatchCardForSlot((byte)slotIndex, cardID);
            saveData.switchEquippedFolderIfInvalid(); // Check folder validity in case limits were affected
            changesMade = true;
        }
        
        /// <summary>Shows and handles equipped program effects menu.</summary>
        static void menu21ProgramEffects()
        {
            parentMenu = 20;
            
            Console.Clear();
            ConsoleC.WriteLineColor("***** Equipped Program Effects *****", "limegreen");
            Console.WriteLine("Press corresponding number/letter to edit value/perform action.\n"
                + "Press Enter to go to next page or Left/Right to switch pages.");
            Console.WriteLine();
            
            ProgramEffects effects = saveData.programEffects;
            Dictionary<byte, object[]> effectDefs = saveData.getDef<Dictionary<byte, object[]>>("programEffectDefs");
            
            List<string[]> options = new List<string[]>();
            
            if (game == 3)
            {
                menuPageCount = 4;
                
                if (menuPage == 0)
                {
                    addProgramEffectOption(options, effectDefs, "totalHP");
                    addProgramEffectOption(options, effectDefs, "attackPlus");
                    addProgramEffectOption(options, effectDefs, "speedPlus");
                    addProgramEffectOption(options, effectDefs, "chargePlus");
                    addProgramEffectOption(options, effectDefs, "weaponLevel");
                    addProgramEffectOption(options, effectDefs, "regularPlus");
                    addProgramEffectOption(options, effectDefs, "startingChips");
                    addProgramEffectOption(options, effectDefs, "megaChipLimit");
                    addProgramEffectOption(options, effectDefs, "gigaChipLimit");
                }
                else if (menuPage == 1)
                {
                    addProgramEffectOption(options, effectDefs, "rewardType");
                    addProgramEffectOption(options, effectDefs, "attractType");
                    addProgramEffectOption(options, effectDefs, "shieldType");
                    addProgramEffectOption(options, effectDefs, "shadowType");
                    addProgramEffectOption(options, effectDefs, "groundType");
                    addProgramEffectOption(options, effectDefs, "supportType");
                }
                else if (menuPage == 2)
                {
                    addProgramEffectOption(options, effectDefs, "underShirt");
                    addProgramEffectOption(options, effectDefs, "sneakRun");
                    addProgramEffectOption(options, effectDefs, "fastGauge");
                    addProgramEffectOption(options, effectDefs, "airShoes");
                    addProgramEffectOption(options, effectDefs, "superArmor");
                    addProgramEffectOption(options, effectDefs, "breakBuster");
                    addProgramEffectOption(options, effectDefs, "breakCharge");
                    addProgramEffectOption(options, effectDefs, "bugStop");
                    addProgramEffectOption(options, effectDefs, "darkLicense");
                }
                else if (menuPage == 3)
                {
                    addProgramEffectOption(options, effectDefs, "press");
                    addProgramEffectOption(options, effectDefs, "energyChange");
                    addProgramEffectOption(options, effectDefs, "darkMind");
                    addProgramEffectOption(options, effectDefs, "alpha");
                    addProgramEffectOption(options, effectDefs, "humor");
                }
            }
            else if (game == 4)
            {
                menuPageCount = 3;
                
                if (menuPage == 0)
                {
                    //addProgramEffectOption(options, effectDefs, "totalHP"); // Seems to reset on load based on programs/Patch Cards, so not worth including
                    addProgramEffectOption(options, effectDefs, "attackPlus");
                    addProgramEffectOption(options, effectDefs, "speedPlus");
                    addProgramEffectOption(options, effectDefs, "chargePlus");
                    addProgramEffectOption(options, effectDefs, "startingChips");
                    addProgramEffectOption(options, effectDefs, "megaChipLimit");
                    addProgramEffectOption(options, effectDefs, "gigaChipLimit");
                }
                else if (menuPage == 1)
                {
                    addProgramEffectOption(options, effectDefs, "rewardType");
                    addProgramEffectOption(options, effectDefs, "shieldType");
                    addProgramEffectOption(options, effectDefs, "attractType");
                    addProgramEffectOption(options, effectDefs, "supportType");
                    addProgramEffectOption(options, effectDefs, "firstBarrier");
                }
                else if (menuPage == 2)
                {
                    addProgramEffectOption(options, effectDefs, "underShirt");
                    addProgramEffectOption(options, effectDefs, "sneakRun");
                    addProgramEffectOption(options, effectDefs, "airShoes");
                    addProgramEffectOption(options, effectDefs, "floatShoes");
                    addProgramEffectOption(options, effectDefs, "superArmor");
                    addProgramEffectOption(options, effectDefs, "bugStop");
                    addProgramEffectOption(options, effectDefs, "humor");
                    addProgramEffectOption(options, effectDefs, "soulCleanse");
                }
            }
            
            printOptions(options);
            if (game < 4)
                ConsoleC.WriteLineHL("{NOTE:} Program effects are usually reset when running Navi Customizer.");
            else
                ConsoleC.WriteLineHL("{NOTE:} Program/Patch Card effects are reset by NaviCust/MegaMan screen.");
            Console.WriteLine();
            printMainFunctions();
            
            bool validInput;
            do
            {
                validInput = true;
                string optionInput = waitToGetInputString();
                string selectedOption = getSelectedOption(options, optionInput);
                
                // First, handle options too specific to handle generically.
                if (selectedOption.Equals("totalHP"))
                {
                    Console.WriteLine("\nType new amount of program-added HP" + (game == 3? " (must be multiple of 5)" : "") + ":");
                    string hpPlusInput = getTypedInput();
                    ushort hpPlus = 0;
                    if (ushort.TryParse(hpPlusInput, out hpPlus))
                    {
                        int totalHP = saveData.getTotalHPWithExtras();
                        int baseMaxHP = saveData.getBaseHPWithoutExtras();
                        int addedHP = totalHP - baseMaxHP;
                        if (hpPlus == addedHP)
                            return;
                        
                        ushort newTotal = (ushort)(Math.Min(baseMaxHP + hpPlus, ushort.MaxValue));
                        if (saveData.currentHP == totalHP || saveData.currentHP > newTotal)
                            saveData.currentHP = newTotal;
                        if (game == 3)
                        {
                            saveData.maxHP = newTotal;
                            saveData.programEffects.setTotalHP(newTotal);
                        }
                        else
                        {
                            saveData.overallMaxHP = newTotal;
                            saveData.totalAddedHP = (ushort)addedHP;
                        }
                        
                        changesMade = true;
                    }
                    return;
                }
                
                // Find the number of the effect that matches the internal name of the selected option.
                byte selectedEffectNum = 0xFF;
                foreach (byte effect in effectDefs.Keys)
                {
                    if ((effectDefs[effect][0] as string).Equals(selectedOption))
                    {
                        selectedEffectNum = effect;
                        break;
                    }
                }
                
                if (selectedEffectNum != 0xFF)
                {
                    object[] effectDef = effectDefs[selectedEffectNum];
                    string fieldName = effectDef[0] as string;
                    int firstListIndex = 2;
                    string specialMode = "";
                    if (effectDef.Length > 2 && effectDef[2] is string)
                    {
                        specialMode = effectDef[2] as string;
                        firstListIndex = 3;
                    }
                    
                    byte effectByte = 0xFF;
                    try
                    {
                        effectByte = (byte)(saveData.programEffects.GetType().GetField(fieldName).GetValue(saveData.programEffects));
                    }
                    catch
                    {
                        Console.WriteLine("ProgramEffects field " + fieldName + " not found.");
                        waitForEnter();
                        return;
                    }
                    
                    if (firstListIndex >= effectDef.Length) // After internal/display names and optional special mode, nothing else defined: Edit value directly
                    {
                        if (effectDef[0].Equals("startingChips"))
                            Console.WriteLine("\nType number of starting chip slots (normally 5 to 10):");
                        else if (effectDef[0].Equals("megaChipLimit"))
                            Console.WriteLine("\nType MegaChip limit for folders (initially 5):");
                        else if (effectDef[0].Equals("gigaChipLimit"))
                            Console.WriteLine("\nType GigaChip limit for folders (initially 1):");
                        else
                            Console.WriteLine("\nType new " + effectDef[1] + " value:");
                        editByte(ref effectByte);
                    }
                    else if (firstListIndex + 1 >= effectDef.Length) // Only one value defined in list: Toggle between 00 and that value
                        toggle01Byte(ref effectByte, Convert.ToByte(effectDef[firstListIndex]));
                    else // Otherwise, cycle between defined values, or show selection prompt if there are 8 or more options
                    {
                        List<byte> valueList = new List<byte>();
                        for (int i = firstListIndex; i + 1 < effectDef.Length; i += 2)
                        {
                            int negativeCheck = 0;
                            int.TryParse(effectDef[i].ToString(), out negativeCheck);
                            if (negativeCheck == -1) // Terminator for selectable options
                                break;
                            valueList.Add(Convert.ToByte(effectDef[i]));
                        }
                        
                        if (valueList.Count < 8)
                            cycleByte(ref effectByte, valueList.ToArray());
                        else
                        {
                            List<string> longCycleOptions = new List<string>();
                            for (int i = firstListIndex; i + 1 < effectDef.Length; i += 2)
                            {
                                int negativeCheck = 0;
                                int.TryParse(effectDef[i].ToString(), out negativeCheck);
                                if (negativeCheck == -1) // Terminator for selectable options
                                    break;
                                longCycleOptions.Add(effectDef[i + 1] as string);
                            }
                            
                            Console.WriteLine();
                            printOptions(longCycleOptions, false, 3);
                            Console.WriteLine("Type number for option to change to:");
                            
                            string longCycleInput = getTypedInput();
                            int selectedIndex = getSelectedOptionIndex(longCycleOptions, longCycleInput);
                            if (selectedIndex < 0)
                                return;
                            
                            byte selectedValue = Convert.ToByte(effectDef[firstListIndex + (selectedIndex * 2)]);
                            if (effectByte != selectedValue)
                            {
                                effectByte = selectedValue;
                                changesMade = true;
                            }
                        }
                    }
                    
                    try
                    {
                        saveData.programEffects.GetType().GetField(fieldName).SetValue(saveData.programEffects, effectByte);
                    }
                    catch
                    {
                        Console.WriteLine("ProgramEffects field " + fieldName + " not found.");
                        waitForEnter();
                    }
                    
                    // When chip limits are edited, check that equipped folder is still valid.
                    if (changesMade && (effectDef[0].Equals("megaChipLimit") || effectDef[0].Equals("gigaChipLimit")))
                        saveData.switchEquippedFolderIfInvalid();
                    return;
                }
                
                // If no valid effect selected, fall to default input processing.
                if (!checkMainFunctions(optionInput))
                    validInput = false;
                
                if (selectedOption.Equals("PAGE")) // If page was changed by Enter or Left/Right, accept as valid input and refresh
                    validInput = true;
            } while (!validInput); // Stay in input loop unless valid input was pressed
        }
        
        /// <summary>Adds a program effect to a list of options.</summary>
        /// <param name="options">The options list.</param>
        /// <param name="effectDefs">All program effect definitions.</param>
        /// <param name="effectName">An internal name for the effect that matches an internal name in definitions.</param>
        static void addProgramEffectOption(List<string[]> options, Dictionary<byte, object[]> effectDefs, string effectName)
        {
            byte effectNum = 0xFF;
            foreach (byte effect in effectDefs.Keys)
            {
                if ((effectDefs[effect][0] as string).Equals(effectName))
                {
                    effectNum = effect;
                    break;
                }
            }
            
            if (effectNum != 0xFF)
            {
                string displayStr = saveData.programEffects.getProgramEffectString(effectNum);
                if (displayStr != "")
                    options.Add(new string[] { effectName, displayStr });
            }
            else
                Console.WriteLine("ERROR: Could not find effect named " + effectName + ".");
        }
        
        /// <summary>Shows and handles chips menu.</summary>
        static void menu30Chips()
        {
            parentMenu = 0;
            
            Console.Clear();
            ConsoleC.WriteLineColor("----- Chips, Folders, Library -----", "pink");
            Console.WriteLine("Press corresponding number/letter to edit value/enter menu/perform action.");
            Console.WriteLine();
            
            List<string[]> options = new List<string[]>();
            options.Add(new string[] { "giveChips", "Add/Remove Chips..." });
            if (game >= 2)
            {
                string equippedStr = saveData.getEquippedFolderString();
                options.Add(new string[] { "folderCount", "Folders Obtained: " + saveData.folderCount });
                options.Add(new string[] { "equippedFolder", "Equipped Folder: "
                    + (equippedStr == "folder1"? "Folder 1"
                     : equippedStr == "folder2"? "Folder 2"
                     : equippedStr == "folder3"? "Folder 3"
                     : equippedStr == "extraFolder"? "Extra Folder"
                     : "N/A") });
            }
            options.Add(new string[] { "folder1", "Edit Folder" + (game >= 2? " 1" : "") + "..." });
            if (saveData.isFolderObtained("folder2"))
                options.Add(new string[] { "folder2", "Edit Folder 2..." });
            if (saveData.isFolderObtained("folder3"))
                options.Add(new string[] { "folder3", "Edit Folder 3..." });
            if (saveData.isFolderObtained("extraFolder"))
                options.Add(new string[] { "extraFolder", "Edit Extra Folder (" + saveData.getPresetFolderName(saveData.getExtraFolderID()) + ")..." });
            options.Add(new string[] { "library", "Data Library..." });
            
            printOptions(options);
            printMainFunctions();
            
            bool validInput;
            do
            {
                validInput = true;
                string optionInput = waitToGetInputString();
                string selectedOption = getSelectedOption(options, optionInput);
                switch (selectedOption)
                {
                    case "giveChips":
                        editMenuGiveChips();
                        break;
                    
                    case "folderCount":
                        Console.WriteLine("\nSelect folders to unlock:");
                        int unlockOptionCount = 3;
                        ConsoleC.WriteLineHL("{[1]} Folder 1 only");
                        if (game == 2)
                        {
                            ConsoleC.WriteLineHL("{[2]} Folder 1 and 2");
                            ConsoleC.WriteLineHL("{[3]} Folder 1, 2, and 3");
                        }
                        else if (game == 3)
                        {
                            ConsoleC.WriteLineHL("{[2]} Folder 1 and Extra Folder");
                            ConsoleC.WriteLineHL("{[3]} Folder 1, 2, and Extra");
                        }
                        else if (game >= 4)
                        {
                            ConsoleC.WriteLineHL("{[2]} Folder 1 and Extra Folder");
                            ConsoleC.WriteLineHL("{[3]} Folder 1 and 2");
                            ConsoleC.WriteLineHL("{[4]} Folder 1, 2, and Extra");
                            unlockOptionCount = 4;
                        }
                        
                        int folderUnlockOption = waitToGetInputNumber(1, unlockOptionCount);
                        if (folderUnlockOption < 0)
                            break;
                        
                        byte newUnlockCount = (byte)folderUnlockOption;
                        bool secondSlotExtra = false;
                        if (game >= 4)
                        {
                            secondSlotExtra = folderUnlockOption == 2;
                            if (newUnlockCount >= 3) // Adjust selection to actual unlocked folder count
                                newUnlockCount--;
                        }
                        
                        if (saveData.setUnlockedFolders(newUnlockCount, secondSlotExtra))
                            changesMade = true;
                        break;
                    
                    case "equippedFolder":
                        if (saveData.folderCount <= 1)
                        {
                            Console.WriteLine("\nOnly one folder available to equip.");
                            waitForEnter();
                            break;
                        }
                        
                        List<string[]> folderOptions = new List<string[]>();
                        folderOptions.Add(new string[] { "folder1", "Folder 1" });
                        if (saveData.isFolderObtained("folder2"))
                            folderOptions.Add(new string[] { "folder2", "Folder 2" });
                        if (saveData.isFolderObtained("folder3"))
                            folderOptions.Add(new string[] { "folder3", "Folder 3" });
                        if (saveData.isFolderObtained("extraFolder"))
                            folderOptions.Add(new string[] { "extraFolder", "Extra Folder" });
                        
                        Console.WriteLine("\nSelect folder to equip:");
                        printOptions(folderOptions, false);
                        
                        int equipIndex = waitToGetInputNumber(1, folderOptions.Count);
                        if (equipIndex < 0)
                            break;
                        equipIndex--; // Change to zero-based index
                        
                        string equipChoice = folderOptions[equipIndex][0];
                        if (saveData.setEquippedFolder(equipChoice))
                            changesMade = true;
                        break;
                    
                    case "folder1":
                    case "folder2":
                    case "folder3":
                    case "extraFolder":
                        bool isExtraFolder = selectedOption == "extraFolder";
                        
                        int myFolderSlot = saveData.getFolderSlotByString(selectedOption);
                        if (myFolderSlot == -1)
                            break;
                        
                        if (isExtraFolder) // For Extra Folder, prompt to select a preset folder
                        {
                            string[] presetFolderNames = saveData.getDef<string[]>("presetFolderNames");
                            List<string[]> extraPresetOptions = new List<string[]>();
                            for (int presetIndex = 0; presetIndex < presetFolderNames.Length; presetIndex++)
                            {
                                string folderName = presetFolderNames[presetIndex];
                                if (folderName.Equals("Fldr1") || folderName.Equals("Fldr2")) // Don't include non-Extra folders
                                    continue;
                                extraPresetOptions.Add(new string[] { presetIndex.ToString(), folderName });
                            }
                            extraPresetOptions.Add(new string[] { "255", "Freely Edit Folder" });
                            
                            Console.WriteLine();
                            printOptions(extraPresetOptions, false);
                            Console.WriteLine("Type number of Extra Folder to adopt (or choose to edit freely):");
                            
                            string extraPresetInput = getTypedInput();
                            string extraSelection = getSelectedOption(extraPresetOptions, extraPresetInput);
                            if (extraSelection == "")
                                return;
                            
                            int extraChoice = int.Parse(extraSelection);
                            if (extraChoice != 255) // Assign preset
                            {
                                saveData.setExtraFolderToPreset((byte)extraChoice);
                                break;
                            }
                            // Otherwise, continue to free edit.
                        }
                        
                        FolderChip[] myFolderContents = saveData.getFolderByString(selectedOption);
                        byte myFolderRegularChip = saveData.getFolderRegChipByString(selectedOption);
                        
                        folderEditPrompt(ref myFolderContents, ref myFolderRegularChip, ref saveData.equippedFolderRegularChip, saveData.isFolderEquipped(selectedOption));
                        
                        // Assign updated contents/regular chip back to corresponding folder slot.
                        if (myFolderSlot == 0)
                        {
                            saveData.folderSlot1 = myFolderContents;
                            saveData.folderSlot1RegularChip = myFolderRegularChip;
                        }
                        else if (myFolderSlot == 1)
                        {
                            saveData.folderSlot2 = myFolderContents;
                            saveData.folderSlot2RegularChip = myFolderRegularChip;
                        }
                        else if (myFolderSlot == 2)
                        {
                            saveData.folderSlot3 = myFolderContents;
                            saveData.folderSlot3RegularChip = myFolderRegularChip;
                        }
                        break;
                    
                    case "library":
                        editMenuLibrary();
                        break;
                    
                    default:
                        if (!checkMainFunctions(optionInput))
                            validInput = false;
                        break;
                }
            } while (!validInput); // Stay in input loop unless valid input was pressed
        }
        
        /// <summary>Handler for granting chips in Chips menu.</summary>
        static void editMenuGiveChips()
        {
            int[] chipIDs = chipNamePrompt(true);
            if (chipIDs != null)
            {
                if (chipIDs.Length == 1) // Single chip
                {
                    int chipID = chipIDs[0];
                    if (chipID == -1)
                        return;
                    
                    int codeNum = chipCodePrompt(chipID);
                    if (codeNum != -1)
                    {
                        string chipName = saveData.getChipName(chipID);
                        List<int> validCodeIndexes = saveData.getValidCodeIndexes(chipID);
                        List<char> validCodeLetters = saveData.getValidCodeLetters(chipID);
                        
                        int codeIndex = -1; // Default indicates all codes
                        char codeLetter = '\0';
                        if (codeNum != 255) // Change from number in list to internal index for code
                        {
                            codeLetter = validCodeLetters[codeNum];
                            codeIndex = validCodeIndexes[codeNum];
                        }
                        
                        Console.WriteLine();
                        Console.WriteLine("Type quantity to give (negative to take away, =1 to set to at least 1):");
                        string quantityInput = getTypedInput();
                        int quantity = 0;
                        bool upToQuantity = false;
                        if (quantityInput.StartsWith("="))
                        {
                            upToQuantity = true;
                            quantityInput = quantityInput.Substring(1);
                        }
                        
                        if (int.TryParse(quantityInput, out quantity))
                        {
                            if (quantity == 0)
                                return;
                            
                            bool chipQuantitiesChanged = false;
                            if (codeIndex == -1)
                            {
                                for (int i = 0; i < validCodeIndexes.Count; i++)
                                {
                                    if (saveData.pack[chipID].modifyQuantity(validCodeIndexes[i], quantity, upToQuantity))
                                        chipQuantitiesChanged = true;
                                }
                            }
                            else
                            {
                                if (saveData.pack[chipID].modifyQuantity(codeIndex, quantity, upToQuantity))
                                    chipQuantitiesChanged = true;
                            }
                            
                            if (chipQuantitiesChanged)
                            {
                                changesMade = true;
                                if (!upToQuantity)
                                    Console.WriteLine((quantity > 0? "Added" : "Subtracted") + " " + chipName + (codeIndex != -1? " " + codeLetter : "")
                                        + " x" + Math.Abs(quantity) + (codeIndex == -1? " in all codes" : "") + "!");
                                else
                                    Console.WriteLine("Increased quantity of " + chipName + (codeIndex != -1? " " + codeLetter : "")
                                        + " up to x" + Math.Abs(quantity) + (codeIndex == -1? " in all codes" : "") + "!");
                            }
                            else
                                Console.WriteLine(chipName + (codeIndex != -1? " " + codeLetter : "") + " quantity remained the same.");
                            waitForEnter();
                        }
                    }
                }
                else // Multiple chips
                {
                    int allOption = game >= 2? 3 : 2;
                    
                    Console.WriteLine();
                    Console.WriteLine("Select option for the chip code:");
                    ConsoleC.WriteLineHL("{[1]} First valid code");
                    if (game >= 2)
                        ConsoleC.WriteLineHL("{[2]} * code (only if valid)");
                    ConsoleC.WriteLineHL("{[" + allOption + "]} All valid codes");
                    
                    int codeOption = waitToGetInputNumber(1, allOption);
                    if (codeOption < 0)
                        return;
                    
                    Console.WriteLine();
                    Console.WriteLine("Type quantity to give (negative to take away, =1 to bring up to 1):");
                    string quantityInput = getTypedInput();
                    
                    int quantity = 0;
                    bool upToQuantity = false;
                    if (quantityInput.StartsWith("="))
                    {
                        upToQuantity = true;
                        quantityInput = quantityInput.Substring(1);
                    }
                    
                    if (int.TryParse(quantityInput, out quantity))
                    {
                        if (quantity == 0)
                            return;
                        
                        bool chipQuantitiesChanged = false;
                        
                        for (int chipListIndex = 0; chipListIndex < chipIDs.Length; chipListIndex++)
                        {
                            int chipID = chipIDs[chipListIndex];
                            if (chipID == -1)
                                continue;
                            string codes = saveData.getChipCodes(chipID);
                            
                            if (codeOption == 1 || codeOption == allOption) // First valid code, or all codes
                            {
                                for (int codeIndex = 0; codeIndex < codes.Length; codeIndex++)
                                {
                                    if (codes[codeIndex] != '-' && saveData.isChipObtainable(chipID, codeIndex))
                                    {
                                        if (saveData.pack[chipID].modifyQuantity(codeIndex, quantity, upToQuantity))
                                            chipQuantitiesChanged = true;
                                        if (codeOption == 1) // Stop after first valid code
                                            break;
                                    }
                                }
                            }
                            else if (game >= 2 && codeOption == 2) // * code
                            {
                                if (codes[codes.Length - 1] != '-' && saveData.isChipObtainable(chipID, codes.Length - 1))
                                {
                                    if (saveData.pack[chipID].modifyQuantity(codes.Length - 1, quantity, upToQuantity))
                                        chipQuantitiesChanged = true;
                                }
                            }
                        }
                        
                        if (chipQuantitiesChanged)
                        {
                            changesMade = true;
                            string codeStr = codeOption == 1? "in first code" : game >= 2 && codeOption == 2? "in * code" : "in all codes";
                            if (!upToQuantity)
                                Console.WriteLine("x" + Math.Abs(quantity) + " " + (quantity > 0? "added to" : "subtracted from") + " selected chips " + codeStr + "!");
                            else
                                Console.WriteLine("Increased quantity of selected chips " + codeStr + " up to x" + Math.Abs(quantity) + "!");
                        }
                        else
                            Console.WriteLine("Quantity of selected chips remained the same.");
                        waitForEnter();
                    }
                }
            }
        }
        
        /// <summary>Handler for editing library flags in Chips menu.</summary>
        static void editMenuLibrary()
        {
            int[] libraryIDs = chipNamePrompt(true, game >= 2);
            if (libraryIDs != null)
            {
                if (libraryIDs.Length == 1) // Single selection
                {
                    int libraryID = libraryIDs[0];
                    if (libraryID < 0)
                        return;
                    
                    string libraryName = libraryID < 1000? saveData.getChipName(libraryID) : saveData.getPAName(libraryID - 1000);
                    bool registered = libraryID < 1000? saveData.libraryChipFlags[libraryID] : saveData.libraryPAFlags[libraryID - 1000];
                    if (!registered)
                    {
                        if (libraryID < 1000)
                            saveData.setLibraryChipFlag(libraryID);
                        else
                            saveData.setLibraryPAFlag(libraryID - 1000);
                        
                        Console.WriteLine(libraryName + " set as registered.");
                        waitForEnter();
                        changesMade = true;
                    }
                    else
                    {
                        if (libraryID >= 1000) // PAs can be safely set as unregistered, though prompt to do so
                        {
                            Console.WriteLine();
                            Console.WriteLine(libraryName + " is already registered.");
                            Console.WriteLine("Set as unregistered? (Y/N)");
                            string unregisterPrompt = getTypedInput();
                            if (unregisterPrompt.ToUpper().Equals("Y"))
                            {
                                saveData.setLibraryPAFlag(libraryID - 1000, false);
                                Console.WriteLine(libraryName + " set as unregistered.");
                                waitForEnter();
                                changesMade = true;
                            }
                        }
                        else // Chips, on the other hand...
                        {
                            Console.WriteLine();
                            Console.WriteLine(libraryName + " is already registered.");
                            Console.WriteLine("To set as unregistered, all instances of it must be erased.");
                            Console.WriteLine("Are you sure? (Y/N)");
                            string unregisterPrompt = getTypedInput();
                            if (unregisterPrompt.ToUpper().Equals("Y"))
                            {
                                int folderInstances = saveData.getChipInstancesInFolders(libraryID, includeExtra: true);
                                if (folderInstances != 0)
                                {
                                    string plural = folderInstances != 1? "s" : "";
                                    Console.WriteLine();
                                    Console.WriteLine(folderInstances + " instance" + plural + " of " + libraryName + " found in folders.");
                                    Console.WriteLine("You must provide a chip to replace them.");
                                    Console.WriteLine();
                                    
                                    int[] replacementChipIDs = chipNamePrompt();
                                    if (replacementChipIDs == null)
                                        return;
                                    
                                    int replacementChipID = replacementChipIDs[0];
                                    if (replacementChipID == libraryID)
                                    {
                                        Console.WriteLine("Same chip provided for replacement; aborting.");
                                        waitForEnter();
                                        return;
                                    }
                                    
                                    int codeIndex = chipCodePrompt(replacementChipID, false, true);
                                    if (codeIndex < 0)
                                        return;
                                    
                                    char codeLetter = saveData.getDefIndex<string>("chipCodes", replacementChipID)[codeIndex];
                                    int codeLetterValue = codeLetter == '*'? 26 : (int)codeLetter - (int)'A';
                                    if (!saveData.replaceInFolders(libraryID, replacementChipID, codeLetterValue))
                                    {
                                        Console.WriteLine("Replacement would break folder rules; reverting and aborting.");
                                        waitForEnter();
                                        return;
                                    }
                                    
                                    Console.WriteLine("Folder instances of " + libraryName + " replaced with " + saveData.getChipName(replacementChipID) + " " + codeLetter + ".");
                                }
                                
                                for (int i = 0; i < 6; i++)
                                    saveData.pack[libraryID].modifyQuantity(i, -999);
                                
                                saveData.setLibraryChipFlag(libraryID, false);
                                
                                Console.WriteLine(libraryName + " set as unregistered and removed from pack.");
                                waitForEnter();
                                changesMade = true;
                            }
                        }
                    }
                }
                else // Multiple selections
                {
                    List<string> valueDisplay = new List<string>();
                    foreach (int libraryID in libraryIDs)
                    {
                        if (libraryID < 1000)
                            valueDisplay.Add(string.Format("{0,-11}", saveData.getChipName(libraryID) + ": ")
                                            + (saveData.libraryChipFlags[libraryID]? "Y" : "N"));
                        else
                            valueDisplay.Add(string.Format("{0,-11}", saveData.getPAName(libraryID - 1000) + ": ")
                                            + (saveData.libraryPAFlags[libraryID - 1000]? "Y" : "N"));
                    }
                    
                    Console.WriteLine();
                    if (valueDisplay.Count <= 10)  // Print one per line if it's a small number
                        printOptions(valueDisplay, false, withNumbers: false);
                    else // Print 4 per line if it's a lot
                        printOptions(valueDisplay, false, 4, 18, false);
                    
                    Console.WriteLine("Set all as registered in Data Library? (Y/N)");
                    Console.WriteLine("(This will not add any chips to Pack.)");
                    string yesNoPrompt = getTypedInput();
                    if (yesNoPrompt.ToUpper().Equals("Y"))
                    {
                        foreach (int libraryID in libraryIDs)
                        {
                            if (libraryID < 1000)
                            {
                                if (!saveData.libraryChipFlags[libraryID])
                                {
                                    saveData.setLibraryChipFlag(libraryID);
                                    changesMade = true;
                                }
                            }
                            else
                            {
                                if (!saveData.libraryPAFlags[libraryID - 1000])
                                {
                                    saveData.setLibraryPAFlag(libraryID - 1000);
                                    changesMade = true;
                                }
                            }
                        }
                        Console.WriteLine("Selected entries set as registered.");
                        waitForEnter();
                    }
                }
            }
        }
        
        /// <summary>Prompts the user to enter a chip (or Program Advance) name.</summary>
        /// <param name="allowRange">Whether to allow the user to select a range of chips/PAs.</param>
        /// <param name="includePAs">Whether to include Program Advances in addition to chips.</param>
        /// <returns>A list of chips/PAs selected. null if none were selected. Program Advance IDs are returned as the ID plus 1000.</returns>
        static int[] chipNamePrompt(bool allowRange = false, bool includePAs = false)
        {
            string chipPAStr = !includePAs? "chip" : "chip/PA";
            string chipsPAsStr = !includePAs? "chips" : "chips/PAs";
            
            Console.WriteLine("\nEnter a " + chipPAStr + " by name, either the full name or some of the first letters.\n"
                + "Entering nothing will show a list of all " + chipsPAsStr + " to pick from.");
            
            if (game == 1)
                Console.WriteLine("Can also enter by library number.");
            else if (game == 2)
                Console.WriteLine("Can enter by library number, or P followed by the number for PAs.");
            else
                Console.WriteLine("Can enter by library number, i.e. S101 (S Standard, M Mega, G Giga" + (includePAs? ", P PA" : "") + ").");
            
            if (allowRange)
            {
                Console.WriteLine("Can also select a range (i.e. " + (game >= 3? "S" : "") + "50-60), or enter \"all\" to target all " + chipsPAsStr + ".");
                if (includePAs)
                    Console.WriteLine("\"allchips\" and \"allpas\" will target only chips or only PAs.");
            }
            
            string input = getTypedInput().Trim().ToUpper();
            
            if (allowRange)
            {
                List<int> allArray = new List<int>();
                if (input.Equals("ALL") || input.Replace(" ", "").Equals("ALLCHIPS"))
                {
                    allArray.AddRange(saveData.getDef<int[]>("gameOrderStandardChips"));
                    allArray.AddRange(saveData.getDef<int[]>("gameOrderMegaChipsAll"));
                    allArray.AddRange(saveData.getDef<int[]>("gameOrderGigaChipsAll"));
                    allArray.AddRange(saveData.getDef<int[]>("gameOrderSecretChipsAll"));
                }
                if (includePAs && (input.Equals("ALL") ||  input.Replace(" ", "").Equals("ALLPAS")))
                {
                    int[] allPAs = saveData.getDef<int[]>("gameOrderPAs");
                    foreach (int pa in allPAs)
                        allArray.Add(1000 + pa);
                }
                
                if (allArray.Count > 0)
                    return allArray.ToArray();
            }
            
            List<int> possibleIDs = new List<int>();
            
            string classes = "SMG" + (includePAs? "P" : "");
            Regex regexWithClass = new Regex("^([" + classes + "])[ ]*([0-9]+)$", RegexOptions.IgnoreCase);
            Regex regexNoClass = new Regex("^([0-9]+)$", RegexOptions.IgnoreCase);
            Regex regexRangeWithClass = new Regex("^([" + classes + "])[ ]*([0-9]+)[ ]*-[ ]*([0-9]+)$", RegexOptions.IgnoreCase);
            Regex regexRangeNoClass = new Regex("^([0-9]+)[ ]*-[ ]*([0-9]+)$", RegexOptions.IgnoreCase);
            Match classMatch = regexWithClass.Match(input);
            Match noClassMatch = regexNoClass.Match(input);
            Match rangeClassMatch = regexRangeWithClass.Match(input);
            Match rangeNoClassMatch = regexRangeNoClass.Match(input);
            
            ushort chipNum = 9999;
            ushort endNum = 9999;
            if (allowRange && rangeClassMatch.Success // Class-number range
             && ushort.TryParse(rangeClassMatch.Groups[2].Value, out chipNum) && ushort.TryParse(rangeClassMatch.Groups[3].Value, out endNum))
            {
                if (!rangeClassMatch.Groups[1].Value.Equals("P"))
                {
                    for (int i = chipNum; i <= endNum; i++)
                    {
                        int id = saveData.getChipIDFromInGameNum(input[0], i, saveData.version);
                        if (id != -1)
                            possibleIDs.Add(id);
                    }
                }
                else
                {
                    for (int i = chipNum; i <= endNum; i++)
                    {
                        int id = saveData.getPAIDFromInGameNum(i);
                        if (id != -1)
                            possibleIDs.Add(1000 + id);
                    }
                }
                return possibleIDs.ToArray();
            }
            else if (allowRange && rangeNoClassMatch.Success // Number-only range, assume Standard chips
             && ushort.TryParse(rangeNoClassMatch.Groups[1].Value, out chipNum) && ushort.TryParse(rangeNoClassMatch.Groups[2].Value, out endNum))
            {
                for (int i = chipNum; i <= endNum; i++)
                    possibleIDs.Add(saveData.getChipIDFromInGameNum('S', i, saveData.version));
                return possibleIDs.ToArray();
            }
            else if (classMatch.Success && ushort.TryParse(classMatch.Groups[2].Value, out chipNum)) // Class-number single
            {
                if (game == 3 && classMatch.Groups[1].Value.Equals("G") && chipNum == 2) // Special case for Bass/Bass+ vs. BassGS
                {
                    possibleIDs.Add(saveData.version == 'M'? (ushort)311 : (ushort)306); // Bass+ for Blue, Bass for White
                    possibleIDs.Add(312); // BassGS
                }
                else if (classMatch.Groups[1].Value.Equals("P"))
                {
                    int paID = saveData.getPAIDFromInGameNum(chipNum);
                    if (paID != -1)
                        return new int[] { 1000 + paID };
                }
                else
                {
                    int chipID = saveData.getChipIDFromInGameNum(input[0], chipNum, saveData.version);
                    if (chipID != -1)
                        return new int[] { chipID };
                }
            }
            else if (noClassMatch.Success && ushort.TryParse(input, out chipNum)) // Just number with no letter, assume Standard chips
            {
                int chipID = saveData.getChipIDFromInGameNum('S', chipNum, saveData.version);
                if (chipID != -1)
                    return new int[] { chipID };
            }
            else // Direct name entry, look for best matches
            {
                int longestMatchLength = 0;
                string[] chipNames = saveData.getDef<string[]>("chipNames");
                string[] paNames = saveData.getDef<string[]>("paNames");
                
                if (input == "") // Automatically add all without need to check
                {
                    possibleIDs.AddRange(saveData.getDef<int[]>("gameOrderStandardChips"));
                    possibleIDs.AddRange(saveData.getDef<int[]>("gameOrderMegaChipsAll"));
                    possibleIDs.AddRange(saveData.getDef<int[]>("gameOrderGigaChipsAll"));
                    possibleIDs.AddRange(saveData.getDef<int[]>("gameOrderSecretChipsAll"));
                    if (includePAs)
                    {
                        int[] allPAs = saveData.getDef<int[]>("gameOrderPAs");
                        foreach (int pa in allPAs)
                            possibleIDs.Add(1000 + pa);
                    }
                }
                else
                {
                    for (ushort testChipID = 0; testChipID < chipNames.Length; testChipID++)
                    {
                        string chipName = chipNames[testChipID];
                        string[] aliases = saveData.getAliasesForChipName(chipName);
                        
                        for (int nameIndex = 0; nameIndex < 1 + aliases.Length; nameIndex++)
                        {
                            string myName = (nameIndex == 0? chipName : aliases[nameIndex - 1]).ToUpper();
                            if (myName.Equals(input))
                                return new int[] { testChipID };
                            
                            if (possibleIDs.Contains(testChipID)) // Already added for one of aliases
                                break;
                            
                            for (int k = myName.Length - 1; k >= input.Length; k--)
                            {
                                if (input.StartsWith(myName.Substring(0, k)))
                                {
                                    if (k > longestMatchLength)
                                    {
                                        longestMatchLength = k;
                                        possibleIDs.Clear();
                                    }
                                    possibleIDs.Add(testChipID);
                                    break;
                                }
                            }
                        }
                    }
                    
                    if (includePAs)
                    {
                        for (ushort testPAID = 0; testPAID < paNames.Length; testPAID++)
                        {
                            string paName = paNames[testPAID];
                            if (paName.Equals(input))
                                return new int[] { 1000 + testPAID };
                            
                            for (int k = paName.Length - 1; k >= input.Length; k--)
                            {
                                if (input.StartsWith(paName.Substring(0, k)))
                                {
                                    if (k > longestMatchLength)
                                    {
                                        longestMatchLength = k;
                                        possibleIDs.Clear();
                                    }
                                    possibleIDs.Add(1000 + testPAID);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            
            if (possibleIDs.Count == 1)
                return possibleIDs.ToArray();
            else if (possibleIDs.Count > 0)
            {
                Console.WriteLine();
                List<string> possibleMatches = new List<string>();
                foreach (int possibleID in possibleIDs)
                {
                    if (possibleID < 1000)
                        possibleMatches.Add(saveData.getChipName(possibleID));
                    else
                        possibleMatches.Add(saveData.getPAName(possibleID - 1000));
                }
                if (possibleMatches.Count <= 10) // Print one per line if it's a small number
                    printOptions(possibleMatches, false);
                else // Print 4 per line if it's a lot
                    printOptions(possibleMatches, false, 4, 18);
                
                Console.WriteLine("Type a result number from the list above:");
                string selectInput = getTypedInput();
                int selection = getSelectedOptionIndex(possibleMatches, selectInput);
                if (selection != -1)
                    return new int[] { possibleIDs[selection] };
            }
            else
            {
                Console.WriteLine("No matches found.");
                waitForEnter();
            }
            
            return null;
        }
        
        /// <summary>Prompts the user to enter the desired chip code, listing valid codes for given chip.</summary>
        /// <param name="chipID">The ID of the selected chip.</param>
        /// <param name="allCodesOption">Whether to provide the option of selecting all codes</param>
        /// <param name="pauseAfterAutoCode">Whether to wait with ReadLine if a chip with only one code is auto-selected.
        /// Recommended if there is not another prompt after this.</param>
        /// <returns>The internal index of code in the chip's list of codes. 255 if "all codes" was selected.</returns>
        static int chipCodePrompt(int chipID, bool allCodesOption = true, bool pauseAfterAutoCode = false)
        {
            string chipName = saveData.getChipName(chipID);
            List<int> validCodeIndexes = saveData.getValidCodeIndexes(chipID);
            List<char> validCodeLetters = saveData.getValidCodeLetters(chipID);
            
            if (validCodeLetters.Count == 0)
            {
                Console.WriteLine("No matches found.");
                waitForEnter();
                return -1;
            }
            
            if (validCodeLetters.Count > 1)
            {
                List<string> chipCodeOptions = new List<string>();
                for (int i = 0; i < validCodeLetters.Count; i++)
                    chipCodeOptions.Add(chipName + " " + validCodeLetters[i] + " (x" + saveData.pack[chipID].getQuantity(validCodeIndexes[i]) + ")");
                if (allCodesOption)
                    chipCodeOptions.Add("All codes");
                
                Console.WriteLine();
                Console.WriteLine("Select chip code:");
                printOptions(chipCodeOptions, false);
                
                int codeIndex = waitToGetInputNumber(1, chipCodeOptions.Count);
                if (codeIndex < 0)
                    return -1;
                codeIndex--; // Change to zero-based index
                
                Console.WriteLine("Selected " + (codeIndex == chipCodeOptions.Count - 1? "all codes" : validCodeLetters[codeIndex] + " code") + ".");
                
                if (allCodesOption && codeIndex == chipCodeOptions.Count - 1)
                    return 255;
                else
                    return codeIndex;
            }
            else
            {
                Console.WriteLine("Auto-selecting " + chipName + " " + validCodeLetters[0] + " (only valid code).");
                if (pauseAfterAutoCode)
                    waitForEnter();
                return 0;
            }
        }
        
        /// <summary>Runs a submenu for editing a folder, that will continue until blank input.</summary>
        /// <param name="folder">The folder to edit.</param>
        /// <param name="folderRegularIndex">The Regular Chip index for this folder.</param>
        /// <param name="equippedRegularIndex">The Regular Chip index for the equipped folder (which may or may not be this one).</param>
        /// <param name="isEquipped">Whether the folder being edited is the equipped folder.</param>
        /// <param name="isExtra">Whether the folder is an Extra Folder, meaning chips inside it do not affect Pack quantities in BN3.</param>
        static void folderEditPrompt(ref FolderChip[] folder, ref byte folderRegularIndex, ref byte equippedRegularIndex, bool isEquipped = false, bool isExtra = false)
        {
            Console.Clear();
            bool editingInvalidFolder = false;
            if (!saveData.isFolderValid(folder, folderRegularIndex))
            {
                Console.WriteLine();
                Console.WriteLine("This folder was not found to be valid under current folder rules.");
                Console.WriteLine("Do you want to revert it to initial starting folder? (Y/N)");
                Console.WriteLine("(Any chips that were in the folder will go back to your Pack.)");
                
                string resetInput = getTypedInput().ToUpper();
                if (resetInput == "Y")
                {
                    saveData.setFolderContentsToPreset(ref folder, "Fldr1");
                    folderRegularIndex = 0xFF;
                    equippedRegularIndex = 0xFF;
                }
                else
                {
                    editingInvalidFolder = true;
                    Console.WriteLine();
                    Console.WriteLine("Proceeding to edit folder, temporarily without restriction.");
                    Console.WriteLine("Changes will only be saved if the folder is made valid.");
                    waitForEnter();
                }
            }
            
            string[] chipCodes = saveData.getDef<string[]>("chipCodes");
            FolderChip[] folderUponEntering = saveData.getFolderDeepCopy(folder);
            int lastEditedChip = -1;
            
            while (true)
            {
                Console.Clear();
                
                List<string> folderChipList = new List<string>();
                for (int i = 0; i < folder.Length; i++)
                    folderChipList.Add(saveData.getChipName(folder[i].chipID) + " " + SaveData.letterCodes[folder[i].codeLetterValue] + (folderRegularIndex == i? " [Reg]" : ""));
                
                ConsoleC.WriteLineColor("***** Folder Edit" + (editingInvalidFolder? " (INVALID)" : "") + " *****", "limegreen");
                Console.WriteLine();
                
                printOptions(folderChipList, false, 3, 24, highlightThisIndex: lastEditedChip);
                Console.WriteLine();
                
                int totalNaviChipLimit = 5;
                int megaChipLimit = saveData.getMegaChipLimit();
                int gigaChipLimit = saveData.getGigaChipLimit();
                int naviChipCount = 0;
                int megaChipCount = 0;
                int gigaChipCount = 0;
                for (int i = 0; i < folder.Length; i++)
                {
                    if (saveData.isNaviChip(folder[i].chipID))
                        naviChipCount++;
                    if (saveData.isMegaChip(folder[i].chipID))
                        megaChipCount++;
                    if (saveData.isGigaChip(folder[i].chipID))
                        gigaChipCount++;
                }
                
                Console.WriteLine(game < 3? ("Navi Chips: " + naviChipCount + "/" + totalNaviChipLimit)
                    : ("MegaChips: " + megaChipCount + "/" + megaChipLimit + ", GigaChips: " + gigaChipCount + "/" + gigaChipLimit));
                Console.WriteLine();
                
                Console.WriteLine("Type the number next to a chip to edit that slot.");
                Console.WriteLine((game >= 2? "Type R to set Regular Chip. " : "") + "Enter nothing to go back.");
                
                if (!isExtra || game >= 4) // Extra Folders are counted for Pack quantities in BN4+
                {
                    Console.WriteLine();
                    Console.WriteLine("Chips are given as necessary to fulfill folder contents.");
                    Console.WriteLine("Any chips replaced will go back to your Pack.");
                }
                
                string folderChipInput = getTypedInput();
                if (folderChipInput.ToUpper().Equals("R") && game >= 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Type number of chip to set as Regular Chip (0 for none):");
                    
                    string regularInput = getTypedInput();
                    byte regularNum = 0;
                    if (byte.TryParse(regularInput, out regularNum))
                    {
                        if (regularNum == 0)
                        {
                            folderRegularIndex = 0xFF;
                            if (isEquipped)
                                equippedRegularIndex = 0xFF;
                            lastEditedChip = -1;
                        }
                        else if (regularNum <= 30)
                        {
                            int size = saveData.getDefIndex<int>("chipSizes", folder[regularNum - 1].chipID);
                            byte regMemoryBase = game >= 4? (byte)4 : (byte)0;
                            ushort actualRegMemory = (ushort)(saveData.regularMemory + regMemoryBase);
                            if (size > actualRegMemory)
                            {
                                Console.WriteLine("Cannot set; " + saveData.getChipName(folder[regularNum - 1].chipID) + " (" + size + "MB) exceeds Regular Memory (" + actualRegMemory + "MB).");
                                waitForEnter();
                            }
                            else
                            {
                                folderRegularIndex = (byte)(regularNum - 1);
                                if (isEquipped)
                                    equippedRegularIndex = (byte)(regularNum - 1);
                                lastEditedChip = regularNum - 1;
                            }
                        }
                    }
                    continue;
                }
                
                int folderChipIndex = getSelectedOptionIndex(folderChipList, folderChipInput);
                if (folderChipIndex == -1)
                {
                    if (folderChipInput.Trim() == "")
                    {
                        if (editingInvalidFolder) // Invalid folder was not made valid through edits
                        {
                            folder = saveData.getFolderDeepCopy(folderUponEntering);
                            Console.WriteLine("Folder remained invalid, so no changes saved.");
                            waitForEnter();
                        }
                        return;
                    }
                    else
                        continue;
                }
                
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("Replacing slot " + (folderChipIndex + 1) + ": " + folderChipList[folderChipIndex]);
                
                int[] chipIDs = chipNamePrompt();
                if (chipIDs != null)
                {
                    int chipID = chipIDs[0];
                    if (chipID == -1)
                        continue;
                    
                    int codeIndex = chipCodePrompt(chipID, false, true);
                    if (codeIndex != -1)
                    {
                        char codeLetter = saveData.getDefIndex<string>("chipCodes", chipID)[codeIndex];
                        int codeLetterValue = codeLetter == '*'? 26 : (int)codeLetter - (int)'A';
                        
                        ushort oldID = folder[folderChipIndex].chipID;
                        ushort oldCode = folder[folderChipIndex].codeLetterValue;
                        folder[folderChipIndex].chipID = (ushort)chipIDs[0];
                        folder[folderChipIndex].codeLetterValue = (ushort)codeLetterValue;
                        
                        if (!saveData.isFolderValid(folder, folderRegularIndex))
                        {
                            if (!editingInvalidFolder) // Under normal circumstances, revert changes that make folder invalid
                            {
                                folder[folderChipIndex].chipID = oldID;
                                folder[folderChipIndex].codeLetterValue = oldCode;
                                Console.WriteLine("The chip will not be changed.");
                                waitForEnter();
                                continue;
                            }
                            // If editing an invalid folder, however, accept changes for time being.
                        }
                        else // If folder is now valid after this change, switch to normal editing mode
                            editingInvalidFolder = false;
                        
                        saveData.matchPackToFolders();
                        
                        lastEditedChip = folderChipIndex;
                        changesMade = true;
                    }
                    continue;
                }
            }
        }
        
        /// <summary>Shows and handles progress menu.</summary>
        static void menu40Progress()
        {
            parentMenu = 0;
            
            Console.Clear();
            ConsoleC.WriteLineColor("----- Progress and Location -----", "pink");
            Console.WriteLine("Press corresponding number/letter to edit value/enter menu/perform action.");
            Console.WriteLine();
            
            List<string[]> options = new List<string[]>();
            addOptionInfo(options, "location");
            addOptionInfo(options, "jackInLocation");
            addOptionInfo(options, "chapter");
            if (game == 4)
            {
                options.Add(new string[] { "tournamentBoards", "Tournament Boards..." });
                addOptionInfo(options, "playthroughNumber");
            }
            addOptionInfo(options, "playTime");
            if (game < 4)
                addOptionInfo(options, "timeInBattles");
            options.Add(new string[] { "flags", "Flags..." });
            
            printOptions(options);
            printMainFunctions();
            
            bool validInput;
            do
            {
                validInput = true;
                string optionInput = waitToGetInputString();
                string selectedOption = getSelectedOption(options, optionInput);
                switch (selectedOption)
                {
                    case "location":
                        editMenuLocation(false);
                        break;
                    
                    case "jackInLocation":
                        editMenuLocation(true);
                        break;
                    
                    case "chapter":
                        Console.WriteLine();
                        bool repeatPrompt = false;
                        do
                        {
                            repeatPrompt = false;
                            Console.WriteLine("Type story chapter number (V to view list of defined values):");
                            string chapterInput = getTypedInput();
                            if (chapterInput.ToUpper() == "V")
                            {
                                Console.WriteLine();
                                for (byte i = 0x00; i < 0xFF; i++)
                                {
                                    string chapterDesc = saveData.getChapterDesc(i, noFallback: true);
                                    if (chapterDesc != "")
                                        ConsoleC.WriteLineHL("{[" + i + "]} " + chapterDesc);
                                }
                                repeatPrompt = true;
                            }
                            else
                                editByte(ref saveData.chapter, input: chapterInput);
                        } while (repeatPrompt);
                        break;
                    
                    case "tournamentBoards":
                        goToMenu(42);
                        break;
                    
                    case "playthroughNumber":
                        ConsoleC.WriteLineHL("\n{NOTE:} Changing this does not fully function like starting a new loop.\n"
                            + "Current progress is retained, and BMDs and PMDs will not respawn/upgrade.\n"
                            + "In general, only things that check this value directly will be affected.\n"
                            + "If you want the game to prompt you to start a new loop, set Flag 110.");
                        Console.WriteLine();
                        
                        Console.WriteLine("Type new playthrough number:");
                        ushort playthroughOneBased = (ushort)(saveData.playthroughNumber + 1);
                        editUShort(ref playthroughOneBased, 1, 256);
                        saveData.playthroughNumber = (byte)(playthroughOneBased - 1);
                        break;
                    
                    case "playTime":
                        Console.WriteLine("\nCurrent playtime in frames: " + saveData.playTime + "\n"
                            + "Type new playtime in frames (60 frames = 1 second):");
                        editUInt(ref saveData.playTime);
                        break;
                    
                    case "timeInBattles":
                        Console.WriteLine("\nCurrent battle time in frames: " + saveData.timeInBattles + "\n"
                            + "Type new battle time in frames (60 frames = 1 second):");
                        editUInt(ref saveData.timeInBattles);
                        break;
                    
                    case "flags":
                        goToMenu(41);
                        break;
                    
                    default:
                        if (!checkMainFunctions(optionInput))
                            validInput = false;
                        break;
                }
            } while (!validInput); // Stay in input loop unless valid input was pressed
        }
        
        /// <summary>Handler for editing player location or last jack-in location in Progress menu.</summary>
        /// <param name="jackIn">Whether this is for editing the last jack-in location.</param>
        static void editMenuLocation(bool jackIn)
        {
            bool changedArea = false;
            bool changedAreaOrSubarea = false;
            
            List<string[]> areaOptions = new List<string[]>();
            for (byte i = 0x00; i < 0xFF; i++)
            {
                string areaName = saveData.getAreaName(i, noFallback: true);
                if (areaName != "")
                    areaOptions.Add(new string[] { i.ToString(), areaName });
            }
            
            Console.WriteLine();
            printOptions(areaOptions, false);
            Console.WriteLine("Type area number (blank to keep current):");
            
            string areaInput = getTypedInput();
            int areaID = getSelectedOptionAsInt(areaOptions, areaInput);
            if (areaID != -1 && (!jackIn? saveData.area : saveData.jackInArea) != areaID)
            {
                if (!jackIn)
                {
                    saveData.area = (byte)areaID;
                    saveData.subarea = 0x00;
                    saveData.playerX = 0;
                    saveData.playerY = 0;
                    saveData.playerZ = 0;
                }
                else
                {
                    saveData.jackInArea = (byte)areaID;
                    saveData.jackInSubarea = 0x00;
                    saveData.jackInX = 0;
                    saveData.jackInY = 0;
                    saveData.jackInZ = 0;
                }
                changesMade = true;
                changedArea = true;
                changedAreaOrSubarea = true;
            }
            
            List<string[]> subareaOptions = new List<string[]>();
            for (byte i = 0x00; i < 0xFF; i++)
            {
                string subareaName = saveData.getSubareaName(!jackIn? saveData.area : saveData.jackInArea, i, noFallback: true);
                if (subareaName != "")
                    subareaOptions.Add(new string[] { i.ToString(), subareaName });
            }
            
            Console.WriteLine();
            printOptions(subareaOptions, false);
            Console.WriteLine("Type subarea number (blank to keep " + (changedArea? "subarea 1" : "current") + "):");
            
            string subareaInput = getTypedInput();
            int subareaID = getSelectedOptionAsInt(subareaOptions, subareaInput);
            if (subareaID != -1 && (!jackIn? saveData.subarea : saveData.jackInSubarea) != subareaID)
            {
                if (!jackIn)
                {
                    saveData.subarea = (byte)subareaID;
                    saveData.playerX = 0;
                    saveData.playerY = 0;
                    saveData.playerZ = 0;
                }
                else
                {
                    saveData.jackInSubarea = (byte)subareaID;
                    saveData.jackInX = 0;
                    saveData.jackInY = 0;
                    saveData.jackInZ = 0;
                }
                changesMade = true;
                changedAreaOrSubarea = true;
            }
            
            Console.WriteLine();
            Console.WriteLine("Type X position (blank to keep " + (changedAreaOrSubarea? "at map origin" : "current") + "):");
            string xInput = getTypedInput();
            short xValue = 0;
            if (short.TryParse(xInput, out xValue))
            {
                if ((!jackIn? saveData.playerX : saveData.jackInX) != xValue)
                {
                    if (!jackIn)
                        saveData.playerX = xValue;
                    else
                        saveData.jackInX = xValue;
                    changesMade = true;
                }
            }
            
            Console.WriteLine("Type Y position (blank to keep " + (changedAreaOrSubarea? "at map origin" : "current") + "):");
            string yInput = getTypedInput();
            short yValue = 0;
            if (short.TryParse(yInput, out yValue))
            {
                if ((!jackIn? saveData.playerY : saveData.jackInY) != yValue)
                {
                    if (!jackIn)
                        saveData.playerY = yValue;
                    else
                        saveData.jackInY = yValue;
                    changesMade = true;
                }
            }
            
            Console.WriteLine("Type Z position (elevation) (blank to keep " + (changedAreaOrSubarea? "at map origin" : "current") + "):");
            string zInput = getTypedInput();
            short zValue = 0;
            if (short.TryParse(zInput, out zValue))
            {
                if ((!jackIn? saveData.playerZ : saveData.jackInZ) != zValue)
                {
                    if (!jackIn)
                        saveData.playerZ = zValue;
                    else
                        saveData.jackInZ = zValue;
                    changesMade = true;
                }
            }
            
            if (changedAreaOrSubarea)
                saveData.updateOnMapChange();
        }
        
        /// <summary>Shows and handles flags menu.</summary>
        static void menu41Flags()
        {
            parentMenu = 40;
            
            if (saveData.flags == null)
            {
                menu = parentMenu;
                return;
            }
            
            Console.Clear();
            ConsoleC.WriteLineColor("***** Flags *****", "limegreen");
            
            int flagsPerPage = 20;
            int firstFlagLine = 1;
            int cursorMax = (menuPage + 1) * flagsPerPage < saveData.flags.Length? flagsPerPage : saveData.flags.Length % flagsPerPage;
            if (cursorMax == 0) // On last page with exactly even number of flags
                cursorMax = flagsPerPage;
            if (flagCursor > cursorMax - 1)
                flagCursor = cursorMax - 1;
            
            List<string> options = new List<string>();
            for (int i = 0; i < flagsPerPage && (menuPage * flagsPerPage) + i < saveData.flags.Length; i++)
            {
                int flagNum = (menuPage * flagsPerPage) + i;
                string desc = saveData.getFlagDesc(flagNum);
                int nonDescMaxLength = (((menuPage + 1) * flagsPerPage) - 1).ToString().Length + 8; // Digits of largest flag + "[] False"
                if (nonDescMaxLength + desc.Length >= 76)
                    desc = desc.Substring(0, 73 - nonDescMaxLength) + "...";
                string leftBracket = i == flagCursor? "*" : "[";
                string rightBracket = i == flagCursor? "*" : "]";
                
                string nonDescString = string.Format("{0,-" + nonDescMaxLength + "}", leftBracket + flagNum + rightBracket + " " + saveData.flags[flagNum]);
                if (i == flagCursor) // Yellow highlight
                    nonDescString = "<*" + nonDescString.Substring(1).Replace("*", "*>");
                else // White highlight
                    nonDescString = nonDescString.Replace("[", "{[").Replace("]", "]}");
                
                options.Add(nonDescString + (desc != ""? " | " + desc : ""));
            }
            
            printOptions(options, false, withNumbers: false);
            Console.WriteLine();
            ConsoleC.WriteLineHL("{[Up/Down]} Cursor  {[Left/Right]} Page  {[Enter]} Toggle  {[G]} Go To  {[0]} Back");
            
            while (true)
            {
                Console.CursorVisible = false;
                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.RightArrow)
                    {
                        menuPage++;
                        if (menuPage * flagsPerPage >= saveData.flags.Length)
                            menuPage = 0;
                        return;
                    }
                    else if (key == ConsoleKey.LeftArrow)
                    {
                        menuPage--;
                        if (menuPage < 0)
                            menuPage = (saveData.flags.Length - 1) / flagsPerPage;
                        return;
                    }
                    else if (key == ConsoleKey.DownArrow || key == ConsoleKey.UpArrow)
                    {
                        int oldCursor = flagCursor;
                        if (key == ConsoleKey.DownArrow)
                            flagCursor = (flagCursor + 1) % cursorMax;
                        else
                            flagCursor = (flagCursor + cursorMax - 1) % cursorMax;
                        
                        // Reprint only the lines for old and new cursor positions, and continue input loop.
                        if (oldCursor >= 0 && flagCursor >= 0 && flagCursor < options.Count && oldCursor < options.Count)
                        {
                            options[oldCursor] = Regex.Replace(options[oldCursor], "^<\\*([0-9]+)\\*>", "{[$1]}");
                            Console.CursorTop = firstFlagLine + oldCursor;
                            printOptions(options, withNumbers: false, onlyThisIndex: oldCursor);
                            
                            options[flagCursor] = Regex.Replace(options[flagCursor], "^\\{\\[([0-9]+)\\]\\}", "<*$1*>");
                            Console.CursorTop = firstFlagLine + flagCursor;
                            printOptions(options, withNumbers: false, onlyThisIndex: flagCursor);
                            
                            Console.CursorVisible = false;
                            System.Threading.Thread.Sleep(10);
                            continue;
                        }
                        else // Fall back on full refresh
                            return;
                    }
                    else if (key == ConsoleKey.Enter)
                    {
                        int flagNum = (menuPage * flagsPerPage) + flagCursor;
                        saveData.toggleFlag(flagNum);
                        changesMade = true;
                        
                        // Reprint only the toggled line, and continue input loop.
                        if (flagCursor >= 0 && flagCursor < options.Count)
                        {
                            options[flagCursor] = Regex.Replace(options[flagCursor], string.Format("{0,-5}", !saveData.flags[flagNum]), string.Format("{0,-5}", saveData.flags[flagNum]));
                            Console.CursorTop = firstFlagLine + flagCursor;
                            printOptions(options, withNumbers: false, onlyThisIndex: flagCursor);
                            
                            Console.CursorVisible = false;
                            System.Threading.Thread.Sleep(10);
                            continue;
                        }
                        else // Fall back on full refresh
                            return;
                    }
                    else if (key == ConsoleKey.G)
                    {
                        Console.CursorTop = firstFlagLine + cursorMax + 2; // Header before flags, flag lines for page, blank line, controls line
                        
                        Console.Write("Type flag number to jump to: ");
                        string jumpInput = getTypedInput();
                        ushort jumpFlag = 0;
                        if (ushort.TryParse(jumpInput, out jumpFlag))
                        {
                            if (jumpFlag < saveData.flags.Length)
                            {
                                menuPage = jumpFlag / flagsPerPage;
                                flagCursor = jumpFlag % flagsPerPage;
                            }
                        }
                        return;
                    }
                    else if (key == ConsoleKey.D0 || key == ConsoleKey.Backspace)
                    {
                        menu = parentMenu;
                        menuPage = 0;
                        menuPageCount = 1;
                        return;
                    }
                }
                
                System.Threading.Thread.Sleep(30);
            }
        }
        
        /// <summary>Shows and handles BN4 tournament boards menu.</summary>
        static void menu42TournamentBoards()
        {
            parentMenu = 40;
            
            menuPageCount = 4;
            
            List<string[]> options = new List<string[]>();
            
            TournamentEntrant[] board = null;
            int tournamentNum = menuPage - 1;
            int lanIndex = -1;
            bool duplicateLans = false;
            
            Console.Clear();
            
            if (menuPage == 0) // Explanation page
            {
                ConsoleC.WriteLineColor("***** Important Notes on Editing Tournament Boards *****", "limegreen");
                Console.WriteLine();
                
                ConsoleC.WriteLineHL("If you're in the middle of a tournament, you can edit the bracket directly\n"
                    + "to set up whatever {Round 2 and 3 matchups} you desire.\n\n"
                    + "However, because the game will generate a new bracket\n"
                    + "when viewing the board for the first time before Round 1,\n"
                    + "this approach does not work for setting a Round 1 matchup.\n\n"
                    + "If you want a particular {Round 1 matchup}, use {Prepare Tournament Seed}\n"
                    + "to select desired opponents and set up the tournament RNG accordingly.");
                Console.WriteLine();
                
                printOptions(options);
                printMainFunctions();
            }
            else // Tournament board
            {
                string tournamentName = menuPage == 1? "Den/City" : menuPage == 2? "Eagle/Hawk" : "Red Sun/Blue Moon";
                board = saveData.tournamentBoards[tournamentNum];
                bool isUninitialized = board[0].isUninitialized();
                
                duplicateLans = false;
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i].isMegaManAndLan())
                    {
                        if (lanIndex == -1)
                            lanIndex = i;
                        else
                        {
                            duplicateLans = true;
                            lanIndex = -1;
                            break;
                        }
                    }
                }
                
                ConsoleC.WriteLineColor("***** Edit " + tournamentName + " Tournament Board *****", "limegreen");
                Console.WriteLine();
                
                if (isUninitialized)
                    Console.WriteLine("(This board has not been iniitalized.)");
                else
                    ConsoleC.WriteLineHL(SaveData.getTournamentBoardChart(board, true), "yellow", "darkgray");
                Console.WriteLine();
                
                options = new List<string[]>();
                if (!isUninitialized)
                {
                    options.Add(new string[] { "editEntrant", "Edit Entrant" });
                    options.Add(new string[] { "setNextMatch", "Set Next Match" });
                }
                options.Add(new string[] { "prepareSeed", "Prepare Tournament Seed" });
                options.Add(new string[] { "previewNextBoard", "Preview Next Board (Given Current Seed)" });
                
                printOptions(options, noMainLinebreak: !isUninitialized);
                if (isUninitialized)
                    printMainFunctions();
            }
            
            bool validInput;
            do
            {
                validInput = true;
                string optionInput = waitToGetInputString();
                string selectedOption = getSelectedOption(options, optionInput);
                switch (selectedOption)
                {
                    case "editEntrant":
                        editMenuEntrant(board, tournamentNum);
                        break;
                    
                    case "setNextMatch":
                        if (lanIndex < 0)
                        {
                            if (!duplicateLans)
                                Console.WriteLine("\nMegaMan and Lan are not present on the current board!");
                            else
                                Console.WriteLine("\nMultiple MegaMan & Lans are present on the current board!");
                            waitForEnter();
                            break;
                        }
                        
                        // Can't set up a next round if Lan is already at or past Round 3.
                        int roundsWon = board[lanIndex].getRoundsWon();
                        if (roundsWon >= 3)
                        {
                            Console.WriteLine("\nMegaMan and Lan have already won this tournament.");
                            waitForEnter();
                            break;
                        }
                        else if (roundsWon >= 2)
                        {
                            Console.WriteLine("\nMegaMan and Lan are already in Round 3.");
                            waitForEnter();
                            break;
                        }
                        
                        // Determine who to replace (and check board validity) before prompt to select replacement opponent, since that doesn't affect it.
                        int possibleOpponentLeftIndex = -1;
                        int possibleOpponentRightIndex = -1;
                        if (roundsWon == 0) // Set up for Round 2
                        {
                            int opponentPairIndex = 0;
                            if (lanIndex / 4 == 0) // Lan is on left side of bracket
                                opponentPairIndex = 1 - (lanIndex / 2); // If Lan is in pair 1, possible Round 2 opponents are in pair 2, and vice versa
                            else // Lan is on right side of bracket
                                opponentPairIndex = 3 - ((lanIndex / 2) - 2); // If Lan is in pair 3, possible Round 2 opponents are in pair 4, and vice versa
                            
                            possibleOpponentLeftIndex = opponentPairIndex * 2;
                            possibleOpponentRightIndex = (opponentPairIndex * 2) + 1;
                        }
                        else // Set up for Round 3
                        {
                            // Find the (expected) two opponents on other side of baord that haven't yet been defeated.
                            int searchStart = lanIndex / 4 == 0? 4 : 0;
                            int searchEnd = lanIndex / 4 == 0? 8 : 4;
                            for (int opponentSearchIndex = searchStart; opponentSearchIndex < searchEnd; opponentSearchIndex++)
                            {
                                if (saveData.tournamentBoards[tournamentNum][opponentSearchIndex].isStillInTournament())
                                {
                                    if (possibleOpponentLeftIndex == -1)
                                    {
                                        possibleOpponentLeftIndex = opponentSearchIndex;
                                        continue;
                                    }
                                    else if (possibleOpponentRightIndex == -1)
                                    {
                                        possibleOpponentRightIndex = opponentSearchIndex;
                                        continue;
                                    }
                                    else // More than two opponents remaining on opposite side of the board
                                    {
                                        Console.WriteLine("\nCan't determine how to set match due to invalid board setup.");
                                        waitForEnter();
                                        break;
                                    }
                                }
                            }
                        }
                        
                        if (possibleOpponentLeftIndex == -1 || possibleOpponentRightIndex == -1)
                        {
                            Console.WriteLine("\nCan't determine how to set match due to invalid board setup.");
                            waitForEnter();
                            break;
                        }
                        
                        Console.WriteLine("\nMegaMan and Lan are currently in Round " + (roundsWon + 1) + ".");
                        Console.WriteLine("Select an opponent to guarantee for the Round " + (roundsWon + 2) + " match:");
                        
                        int nextRoundOpponent = selectOpponentPrompt(tournamentNum);
                        if (nextRoundOpponent < 0)
                            break;
                        
                        // Compare priorities of opponents; if one is already lower (better), replace that one, otherwise change priorities to 0 and 1.
                        TournamentEntrant left = saveData.tournamentBoards[tournamentNum][possibleOpponentLeftIndex];
                        TournamentEntrant right = saveData.tournamentBoards[tournamentNum][possibleOpponentRightIndex];
                        bool entrantChanged = false;
                        
                        if (left.getPriority() < right.getPriority())
                            entrantChanged = left.setEntrantID((byte)nextRoundOpponent);
                        else if (right.getPriority() < left.getPriority())
                            entrantChanged = right.setEntrantID((byte)nextRoundOpponent);
                        else
                        {
                            entrantChanged = left.setEntrantID((byte)nextRoundOpponent);
                            if (left.setPriority(0))
                                entrantChanged = true;
                            if (right.setPriority(1))
                                entrantChanged = true;
                        }
                        
                        if (entrantChanged)
                            changesMade = true;
                        break;
                    
                    case "prepareSeed":
                        editMenuPrepareSeed(board, tournamentNum);
                        break;
                    
                    case "previewNextBoard":
                        showNextBoardPreview(tournamentNum);
                        break;
                    
                    case "PAGE": // Page-changing input
                        validInput = true;
                        break;
                    
                    default:
                        if (!checkMainFunctions(optionInput))
                            validInput = false;
                        break;
                }
            } while (!validInput); // Stay in input loop unless valid input was pressed
        }
        
        /// <summary>Handler for editing entrants in Tournament Boards menu.</summary>
        /// <param name="board">The array of TournamentEntrants making up the board.</param>
        /// <param name="tournamentNum">The number of the tournament,</param>
        static void editMenuEntrant(TournamentEntrant[] board, int tournamentNum)
        {
            Console.WriteLine("\nSelect an entrant to edit:");
            for (int i = 0; i < 8; i ++)
                ConsoleC.WriteLineHL("{[" + (i + 1) + "]} " + SaveData.getTournamentEntrantString(board, i, showPriority: true));
            
            int entrantOtherIndex = waitToGetInputNumber(1, 8);
            if (entrantOtherIndex < 0)
                return;
            entrantOtherIndex--; // Change to zero-based index
            
            Console.WriteLine("Selected " + SaveData.getTournamentEntrantString(board, entrantOtherIndex) + ".");
            Console.WriteLine();
            
            Console.WriteLine("Select what to edit for this entrant:");
            ConsoleC.WriteLineHL("{[1]} Opponent ID");
            ConsoleC.WriteLineHL("{[2]} Round advancement");
            ConsoleC.WriteLineHL("{[3]} Defeated status");
            ConsoleC.WriteLineHL("{[4]} Win priority");
            
            int otherTypeOption = waitToGetInputNumber(1, 4);
            if (otherTypeOption < 0)
                return;
            
            if (otherTypeOption == 1)
            {
                Console.WriteLine("\nType number for replacement entrant:");
                int opponentNum = selectOpponentPrompt(tournamentNum, true);
                if (opponentNum < 0)
                    return;
                
                if (board[entrantOtherIndex].setEntrantID((byte)opponentNum))
                    changesMade = true;
            }
            else if (otherTypeOption == 2)
            {
                Console.WriteLine("\nSelect entrant's degree of advancement:");
                ConsoleC.WriteLineHL("{[1]} Before Round 1");
                ConsoleC.WriteLineHL("{[2]} Won Round 1");
                ConsoleC.WriteLineHL("{[3]} Won Round 2");
                ConsoleC.WriteLineHL("{[4]} Won tournament");
                
                int newRoundsWon = waitToGetInputNumber(1, 4);
                if (newRoundsWon < 0)
                    return;
                newRoundsWon--; // Change to zero-based count
                
                if (board[entrantOtherIndex].setRoundsWon(newRoundsWon))
                    changesMade = true;
            }
            else if (otherTypeOption == 3)
            {
                Console.WriteLine("\nSelect entrant's defeated status:");
                ConsoleC.WriteLineHL("{[1]} Still in tournament");
                ConsoleC.WriteLineHL("{[2]} Defeated, out of tournament");
                
                int defeatedOption = waitToGetInputNumber(1, 2);
                if (defeatedOption < 0)
                    return;
                
                if (board[entrantOtherIndex].setStillInTournament(defeatedOption == 1))
                    changesMade = true;
            }
            else if (otherTypeOption == 4)
            {
                Console.WriteLine("\nType new win priority (lower priority wins CPU matchups, 50-50 if same):");
                string newPriority = getTypedInput();
                byte priorityValue = 0;
                if (byte.TryParse(newPriority, out priorityValue))
                {
                    if (board[entrantOtherIndex].setPriority(priorityValue))
                        changesMade = true;
                }
            }
        }
        
        /// <summary>Handler for setting up desired seed in Tournament Boards menu.</summary>
        /// <param name="board">The array of TournamentEntrants making up the board.</param>
        /// <param name="tournamentNum">The number of the tournament,</param>
        static void editMenuPrepareSeed(TournamentEntrant[] board, int tournamentNum)
        {
            // Before starting, check current chapter to determine it's currently appropriate to use this function for given tournament.
            bool beforeTourney1 = saveData.chapter <= 10 // // Between start of game and viewing T1 board
                || (saveData.chapter >= 37 && saveData.chapter < 48); // After finishing T3 and not in a tournament scenario (next up will be next loop's T1)
            bool beforeTourney2 = saveData.chapter > 12 && saveData.chapter <= 22; // Between finishing T1 and viewing T2 board
            bool beforeTourney3 = saveData.chapter >= 25 && saveData.chapter <= 34; // Between finishing T2 and viewing T3 board
            
            if ((tournamentNum == 0 && !beforeTourney1) || (tournamentNum == 1 && !beforeTourney2) || (tournamentNum == 2 && !beforeTourney3))
            {
                Console.WriteLine("\nThe current story chapter does not appear to be at a suitable point\n"
                    + "(i.e. before the start of Tournament " + (tournamentNum + 1) + ") to use this function.\n"
                    + "The tournament seed changes when generating any new tournament board,\n"
                    + "and will often change between rounds of a tournament as well.\n"
                    + "The predicted results here will only be accurate if the next use of\n"
                    + "the tournament seed is to generate a new board for Tournament " + (tournamentNum + 1) + ".\n\n"
                    + "It is recommended to wait until you are in a point of the story\n"
                    + "between tournaments, and before Tournament " + (tournamentNum + 1) + " starts, to use this function.\n"
                    + "Do you want to use it anyway? (Y/N)");
                string useAnywayPrompt = getTypedInput();
                if (useAnywayPrompt.ToUpper() != "Y")
                    return;
            }
            
            Console.WriteLine("\nSelect how to prepare seed:");
            ConsoleC.WriteLineHL("{[1]} Only specify Round 1 opponent");
            ConsoleC.WriteLineHL("{[2]} Specify one opponent (in any round)");
            ConsoleC.WriteLineHL("{[3]} Specify two opponents (in any round)");
            ConsoleC.WriteLineHL("{[4]} Specify all three opponents (any order)");
            
            int prepareSeedOption = waitToGetInputNumber(1, 4);
            if (prepareSeedOption < 0)
                return;
            
            int desiredOpponentCount = Math.Max(prepareSeedOption - 1, 1);
            if (desiredOpponentCount > 1)
                ConsoleC.WriteLineHL("\n{NOTE:} The game can't generate a board with two opponents from the\n"
                    + "same \"category\" (SoulNavi for version, Unique Navi, NormalNavi, HeelNavi),\n"
                    + "so don't pick more than one of each type.", "limegreen");
            
            List<int> desiredOpponents = new List<int>();
            for (int opponentIndex = 0; opponentIndex < desiredOpponentCount; opponentIndex++)
            {
                Console.WriteLine();
                Console.WriteLine(prepareSeedOption == 1? "Select an opponent for Round 1:" : "Select an opponent:");
                int selectedID = selectOpponentPrompt(tournamentNum, includeCategory: desiredOpponentCount > 1, omissions: desiredOpponents);
                if (selectedID < 0)
                    return;
                Console.WriteLine("Selected " + SaveData.getTournamentEntrantString(selectedID) + ".");
                desiredOpponents.Add(selectedID);
            }
            
            if (desiredOpponentCount > 1)
            {
                Console.WriteLine();
                Console.WriteLine("All selections:");
                for (int i = 0; i < desiredOpponents.Count; i++)
                    Console.Write((i > 0? ", " : "") + SaveData.getTournamentEntrantString(desiredOpponents[i]));
                Console.WriteLine();
            }
            
            Console.WriteLine();
            
            List<int> newBoardOpponents = null;
            string result = saveData.prepareTournamentSeed(tournamentNum, desiredOpponents, prepareSeedOption == 1, ref newBoardOpponents);
            
            if (result.StartsWith("basicImpossible")) // Fundamentally impossible request
            {
                string resultSub = result.Split('-')[1];
                ConsoleC.WriteLineHL("{Unable to satisfy request.} The game cannot generate a layout in which you\n"
                    + (resultSub == "soul"? "fight both of the version-exclusive SoulNavis for that tournament."
                     : resultSub == "unique"? "fight more than one non-Soul \"unique\" Navi (includes other-version SoulNavis)."
                     : resultSub == "normal"? "fight more than one NormalNavi in the same tournament."
                                            : "fight more than one HeelNavi in the same tournament.") + "\n"
                    + "If you want this, prepare a seed with a desired Round 1 opponent,\n"
                    + "then modify the board at some point after starting Round 1.", "red");
                waitForEnter();
                return;
            }
           
            if (result == "abort") // Backed out of making changes
            {
                Console.WriteLine("Aborting seed preparation.");
                waitForEnter();
                return;
            }
            
            if (result == "searchCancel-manual") // User cancelled search that was going too long
            {
                Console.WriteLine("Seed search cancelled.");
                waitForEnter();
                return;
            }
            
            if (result == "searchCancel-auto") // Auto-cancelled search that looped back to same seed
            {
                Console.WriteLine("Seed has returned to initial value; layout is very likely impossible.");
                waitForEnter();
                return;
            }
            
            if (!result.StartsWith("success"))
                return;
            
            ConsoleC.WriteLineColor("Found and set up seed for board with these opponents:", "yellow");
            Console.WriteLine(SaveData.getTournamentEntrantString(newBoardOpponents[0]) + ", "
                            + SaveData.getTournamentEntrantString(newBoardOpponents[1]) + ", "
                            + SaveData.getTournamentEntrantString(newBoardOpponents[2]));
            
            if (result.Contains("#")) // Navi was added to WaitingRoom
            {
                string waitingRoomAddition = result.Split('#')[1];
                ConsoleC.WriteLineHL("{NOTE:} " + waitingRoomAddition + " was added to WaitingRoom to make selection possible.");
            }
            
            Console.WriteLine();
            Console.WriteLine("(To be clear, this is referring to \"what the game will generate\n"
                + "when the next tournament starts\"; current board data is unaffected.)");
            
            if (result.Contains("?")) // Standard RNG was involved in outcome
            {
                Console.WriteLine();
                ConsoleC.WriteLineHL("{WARNING:} The Loop 2 Eagle/Hawk Tournament is a special case.\n"
                    + "When you first view the board, there is a 50-50 chance that it either\n"
                    + "selects the same SoulNavi fought in Loop 1, or selects the other SoulNavi.\n"
                    + "(The Loop 2 Red Sun/Blue Moon Tournament will then choose the other option.)\n\n"
                    + "This is random at the time of viewing, not unchanging like most tournaments,\n"
                    + "so if you don't get the right board, reset the game and try again.", "red");
            }
            
            waitForEnter();
        }
        
        /// <summary>Handler for displaying what next board will be in Tournament Boards menu.</summary>
        /// <param name="board">The array of TournamentEntrants making up the board.</param>
        /// <param name="tournamentNum">The number of the tournament,</param>
        static void showNextBoardPreview(int tournamentNum)
        {
            TournamentEntrant[][] nextBoardOrBoards = null;
            int[][] nextBoardOpponents = null;
            
            saveData.getNextTournamentBoardPreview(tournamentNum, ref nextBoardOrBoards, ref nextBoardOpponents);
            
            string tournamentName = tournamentNum == 0? "Den/City" : tournamentNum == 1? "Eagle/Hawk" : "Red Sun/Blue Moon";
            Console.WriteLine();
            Console.WriteLine("If you begin the " + tournamentName + " Tournament now, before doing anything else\n"
                + "that would affect the tournament RNG (such as begin a different tournament,\n"
                + "or in some cases advance rounds, as it may be used to decide CPU matchups),\n"
                + "this is the initial board that will be generated:");
            Console.WriteLine();
            
            Console.WriteLine(SaveData.getTournamentBoardChart(nextBoardOrBoards[0], bottomRowOnly: true));
            
            if (nextBoardOrBoards.Length > 1)
            {
                Console.WriteLine("--- OR ---");
                Console.WriteLine(SaveData.getTournamentBoardChart(nextBoardOrBoards[1], bottomRowOnly: true));
            }
            
            Console.WriteLine();
            Console.WriteLine("Your opponents on this board for each round " + (nextBoardOpponents.Length == 1? "will" : "might") + " be:");
            Console.WriteLine(SaveData.getTournamentEntrantString(nextBoardOpponents[0][0]) + ", "
                            + SaveData.getTournamentEntrantString(nextBoardOpponents[0][1]) + ", "
                            + SaveData.getTournamentEntrantString(nextBoardOpponents[0][2]));
            
            if (nextBoardOpponents.Length > 1)
            {
                Console.WriteLine("Or they might be:");
                Console.WriteLine(SaveData.getTournamentEntrantString(nextBoardOpponents[1][0]) + ", "
                                + SaveData.getTournamentEntrantString(nextBoardOpponents[1][1]) + ", "
                                + SaveData.getTournamentEntrantString(nextBoardOpponents[1][2]));
                Console.WriteLine("(Which of these boards you get is decided randomly on first viewing.)");
            }
            
            waitForEnter();
        }
        
        /// <summary>Prompts the user to select an opponent from the given tournament.</summary>
        /// <param name="tournamentNum">The number of the tournament,</param>
        /// <param name="includeMegaMan">Whether to include MegaMan as an option at the start.</param>
        /// <param name="includeCategory">Whether to note each opponent's category (Soul/Unique/etc.) to aid in understanding possible board setups.</param>
        /// <param name="omissions">A list of IDs to omit from the list.</param>
        /// <returns>The selected opponent ID.</returns>
        static int selectOpponentPrompt(int tournamentNum, bool includeMegaMan = false, bool includeCategory = false, List<int> omissions = null)
        {
            if (omissions == null)
                omissions = new List<int>();
            
            List<int> opponentIDs = new List<int>();
            if (includeMegaMan)
                opponentIDs.Add(0x1E);
            
            string[] tournamentNames = new string[] { "Den/City", "Eagle/Hawk", "Red Sun/Blue Moon" };
            for (int i = 0; i < BN4Definitions.tournamentEntrantData.Length; i++)
            {
                if (omissions.Contains(i))
                    continue;
                if (BN4Definitions.tournamentEntrantData[i][0].Contains("(Filler)"))
                    continue;
                if (BN4Definitions.tournamentEntrantData[i][4].Equals(tournamentNames[tournamentNum]))
                    opponentIDs.Add(i);
            }
            
            for (int i = 0; i < opponentIDs.Count; i++)
                ConsoleC.WriteLineHL("{[" + (i + 1) + "]} " + SaveData.getTournamentEntrantString(opponentIDs[i], includeVerSoul: true, includeCategory: includeCategory));
            
            int opponentIndex = waitToGetInputNumber(1, opponentIDs.Count);
            if (opponentIndex < 0)
                return -1;
            opponentIndex--;
            
            return opponentIDs[opponentIndex];
        }
        
        /// <summary>Shows and handles items menu.</summary>
        static void menu50Items()
        {
            parentMenu = 0;
            
            Console.Clear();
            ConsoleC.WriteLineColor("----- Collected Items -----", "pink");
            Console.WriteLine("Press corresponding number/letter to edit value/enter menu/perform action.");
            Console.WriteLine();
            
            List<string[]> options = new List<string[]>();
            
            options.Add(new string[] { "upgradeItems", "Upgrade Items..." });
            options.Add(new string[] { "keyItems", "Key Items..." });
            if (game >= 3)
                options.Add(new string[] { "programs", "Programs..." });
            if (game >= 2)
                options.Add(new string[] { "subchips", "SubChips: " + printArray(saveData.subchipQuantities) });
            if (game == 3)
                options.Add(new string[] { "errorCodes", "Saved Error Codes..." });
            if (game == 4)
                options.Add(new string[] { "mysteryDataTimesCollected", "Past Mystery Data Collection Counts..." });
            if (game >= 3)
                options.Add(new string[] { "numberTraderFlags", "Number Trader Codes Used..." });
            
            printOptions(options);
            printMainFunctions();
            
            bool validInput;
            do
            {
                validInput = true;
                string optionInput = waitToGetInputString();
                string selectedOption = getSelectedOption(options, optionInput);
                switch (selectedOption)
                {
                    case "upgradeItems":
                        goToMenu(51);
                        break;
                    
                    case "keyItems":
                        List<string[]> keyItemOptions = new List<string[]>();
                        List<int> validKeyItems = new List<int>();
                        for (int i = 0; i < saveData.keyItemQuantities.Length; i++)
                        {
                            string keyItemName = saveData.getKeyItemName(i, false);
                            if (keyItemName != "")
                            {
                                keyItemOptions.Add(new string[] { i.ToString(), keyItemName + " x" + saveData.keyItemQuantities[i] });
                                validKeyItems.Add(i);
                            }
                        }
                        keyItemOptions.Add(new string[] { "255", "All Key Items" });
                        
                        Console.WriteLine();
                        printOptions(keyItemOptions, false, 4, 19);
                        Console.WriteLine("Type number of item to edit quantity of:");
                        
                        string keyItemInput = getTypedInput();
                        int keyItemIndex = getSelectedOptionAsInt(keyItemOptions, keyItemInput);
                        if (keyItemIndex < 0)
                            break;
                        
                        Console.WriteLine("Selected " + (keyItemIndex != 255? saveData.getKeyItemName(keyItemIndex) : "all items") + ".");
                        Console.WriteLine();
                        
                        if (keyItemIndex != 255)
                        {
                            Console.WriteLine("Type new quantity of item (usually just 0 or 1):");
                            editByte(ref saveData.keyItemQuantities[keyItemIndex]);
                            if (saveData.keyItemQuantities[keyItemIndex] > 0)
                                saveData.setItemVerifiedObtained(keyItemIndex);
                        }
                        else
                        {
                            Console.WriteLine("Type quantity to set all items to (usually just 0 or 1):");
                            editBytesToOneValue(ref saveData.keyItemQuantities, indexesToModify: validKeyItems);
                            foreach (int index in validKeyItems)
                            {
                                if (saveData.keyItemQuantities[index] > 0)
                                    saveData.setItemVerifiedObtained(index);
                            }
                        }
                        break;
                    
                    case "programs":
                        List<string[]> programOptions = new List<string[]>();
                        List<int> validPrograms = new List<int>();
                        for (int i = 0; i < saveData.programQuantities.Length; i++)
                        {
                            string programName = saveData.getProgramName(i / 4, false);
                            if (programName != "" && programName != "NONE")
                            {
                                char programColor = saveData.getDefIndex<string>("programColors", i / 4)[i % 4];
                                if (programColor == '-')
                                    continue;
                                string colorStr = programColor == 'U'? "Pu" : programColor == 'D'? "Gray" : programColor.ToString();
                                bool compressed = saveData.programCompressedFlags != null? saveData.programCompressedFlags[i] : false;
                                programOptions.Add(new string[] { i.ToString(), programName + " (" + colorStr + ") x" + saveData.programQuantities[i] + (compressed? " *" : "") });
                                validPrograms.Add(i);
                            }
                        }
                        programOptions.Add(new string[] { "255", "All Programs" });
                        
                        bool gameHasCompression = game == 3 || game >= 5;
                        
                        Console.WriteLine();
                        printOptions(programOptions, false, 3, 26);
                        Console.WriteLine("Type number of program to edit quantity of:");
                        if (gameHasCompression)
                            Console.WriteLine("(To toggle compression (marked by *), type C followed by the number.)");
                        
                        string programInput = getTypedInput();
                        if (gameHasCompression && programInput.ToUpper().StartsWith("C"))
                        {
                            int compressProgramIndex = getSelectedOptionAsInt(programOptions, programInput.Substring(1));
                            if (compressProgramIndex < 0)
                                break;
                            
                            if (compressProgramIndex != 255) // Toggle compression of one
                            {
                                saveData.programCompressedFlags[compressProgramIndex] = !saveData.programCompressedFlags[compressProgramIndex];
                                changesMade = true;
                            }
                            else // Set all
                            {
                                Console.WriteLine();
                                ConsoleC.WriteLineHL("{[1]} Set all as compressed");
                                ConsoleC.WriteLineHL("{[2]} Set all as uncompressed");
                                
                                int compressAllPrompt = waitToGetInputNumber(1, 2);
                                if (compressAllPrompt < 0)
                                    break;
                                bool compressAll = compressAllPrompt == 1;
                                
                                foreach (string[] programOption in programOptions)
                                {
                                    int index = int.Parse(programOption[0]);
                                    if (saveData.programCompressedFlags[index] != compressAll)
                                        changesMade = true;
                                    saveData.programCompressedFlags[index] = compressAll;
                                }
                            }
                            break;
                        }
                        
                        int programIndex = getSelectedOptionAsInt(programOptions, programInput);
                        if (programIndex < 0)
                            break;
                        
                        char selectedColor = programIndex != 255? saveData.getDefIndex<string>("programColors", programIndex / 4)[programIndex % 4] : '-';
                        Console.WriteLine("Selected " + (programIndex != 255? saveData.getProgramName(programIndex / 4) + " (" + selectedColor + ")" : "all programs") + ".");
                        Console.WriteLine();
                        
                        if (programIndex != 255)
                        {
                            Console.WriteLine("Type new quantity of program (max 9):");
                            editByte(ref saveData.programQuantities[programIndex], 0, 9);
                            if (saveData.programQuantities[programIndex] > 0)
                                saveData.setItemVerifiedObtained(programIndex / 4, "program", programIndex % 4);
                        }
                        else
                        {
                            Console.WriteLine("Type quantity to set all programs to (max 9):");
                            editBytesToOneValue(ref saveData.programQuantities, 0, 9, indexesToModify: validPrograms);
                            foreach (int index in validPrograms)
                            {
                                if (saveData.programQuantities[index] > 0)
                                    saveData.setItemVerifiedObtained(index / 4, "program", index % 4);
                            }
                        }
                        break;
                    
                    case "subchips":
                        List<string> subchipOptions = new List<string>();
                        for (int i = 0; i < saveData.subchipQuantities.Length; i++)
                            subchipOptions.Add(saveData.getSubchipName(i) + ": " + saveData.subchipQuantities[i]);
                        subchipOptions.Add("All SubChips");
                        
                        Console.WriteLine("\nSelect SubChip to edit quantity of:");
                        printOptions(subchipOptions, false);
                        
                        int subchipIndex = waitToGetInputNumber(1, subchipOptions.Count);
                        if (subchipIndex < 0)
                            break;
                        subchipIndex--; // Change to zero-based index
                        
                        Console.WriteLine();
                        byte subchipMax = (byte)saveData.getSubchipLimit();
                        if (subchipIndex < saveData.subchipQuantities.Length)
                        {
                            Console.WriteLine("Type new " + saveData.getSubchipName(subchipIndex) + " quantity (max " + subchipMax + "):");
                            editByte(ref saveData.subchipQuantities[subchipIndex], max: subchipMax);
                            if (saveData.subchipQuantities[subchipIndex] > 0)
                                saveData.setItemVerifiedObtained(subchipIndex, "subchip");
                        }
                        else // Last option
                        {
                            Console.WriteLine("Type new quantity for all SubChips (max " + subchipMax + "):");
                            editBytesToOneValue(ref saveData.subchipQuantities, max: subchipMax);
                            for (int index = 0; index < saveData.subchipQuantities.Length; index++)
                            {
                                if (saveData.subchipQuantities[index] > 0)
                                    saveData.setItemVerifiedObtained(index, "subchip");
                            }
                        }
                        break;
                    
                    case "errorCodes":
                        List<string[]> errorCodeOptions = new List<string[]>();
                        List<int> validErrorCodes = new List<int>();
                        for (int i = 0; i < saveData.errorCodesSavedBytes.Length; i++)
                        {
                            string errorCodeName = BN3Definitions.getErrorCodeName(i, true);
                            if (errorCodeName != "")
                            {
                                errorCodeOptions.Add(new string[] { i.ToString(), errorCodeName + ": " + saveData.getErrorCodeSaved(i) });
                                validErrorCodes.Add(i);
                            }
                        }
                        errorCodeOptions.Add(new string[] { "255", "All Codes" });
                        
                        Console.WriteLine();
                        printOptions(errorCodeOptions, false, 2, 38);
                        Console.WriteLine("Type number of error code to toggle (saved codes get auto-entered):");
                        
                        string errorCodeInput = getTypedInput();
                        int errorCodeIndex = getSelectedOptionAsInt(errorCodeOptions, errorCodeInput);
                        if (errorCodeIndex < 0)
                            break;
                        
                        if (errorCodeIndex != 255)
                        {
                            saveData.toggleErrorCodeSaved(errorCodeIndex);
                            changesMade = true;
                        }
                        else
                        {
                            Console.WriteLine();
                            ConsoleC.WriteLineHL("{[1]} Set all as saved");
                            ConsoleC.WriteLineHL("{[2]} Set all as not saved");
                            
                            int saveAllPrompt = waitToGetInputNumber(1, 2);
                            if (saveAllPrompt < 0)
                                break;
                            bool saveAll = saveAllPrompt == 1;
                            
                            foreach (int index in validErrorCodes)
                            {
                                if (saveData.getErrorCodeSaved(index) != saveAll)
                                    changesMade = true;
                                saveData.setErrorCodeSaved(index, saveAll);
                            }
                        }
                        break;
                    
                    case "mysteryDataTimesCollected":
                        goToMenu(53);
                        break;
                    
                    case "numberTraderFlags":
                        List<string> numberCodeOptions = saveData.getNumberTraderFlagsList();
                        numberCodeOptions.Add("All codes");
                        
                        Console.WriteLine();
                        printOptions(numberCodeOptions, false, 2, 38);
                        Console.WriteLine("Type number for Number Trader code to set as claimed/unclaimed:");
                        
                        string numberCodeInput = getTypedInput();
                        int numberCodeIndex = getSelectedOptionIndex(numberCodeOptions, numberCodeInput);
                        if (numberCodeIndex < 0)
                            break;
                        
                        bool selectedAllCodes = numberCodeIndex == numberCodeOptions.Count - 1;
                        Console.WriteLine("Selected " + (!selectedAllCodes? saveData.getDefIndex<string>("numberTraderCodes", numberCodeIndex) : "all codes") + ".");
                        Console.WriteLine();
                        
                        ConsoleC.WriteLineHL("{[1]} Set code" + (selectedAllCodes? "s" : "") + " as unclaimed (false)");
                        ConsoleC.WriteLineHL("{[2]} Set code" + (selectedAllCodes? "s" : "") + " as already claimed (true)");
                        
                        int setCodePrompt = waitToGetInputNumber(1, 2);
                        if (setCodePrompt < 0)
                            break;
                        bool setAsUsed = setCodePrompt == 2;
                        
                        if (!selectedAllCodes)
                        {
                            if (saveData.numberTraderFlags[numberCodeIndex] != setAsUsed)
                            {
                                saveData.numberTraderFlags[numberCodeIndex] = setAsUsed;
                                changesMade = true;
                            }
                        }
                        else // All option
                        {
                            for (int i = 0; i < saveData.numberTraderFlags.Length; i++)
                            {
                                if (saveData.numberTraderFlags[i] != setAsUsed)
                                {
                                    saveData.numberTraderFlags[i] = setAsUsed;
                                    changesMade = true;
                                }
                            }
                        }
                        break;
                    
                    default:
                        if (!checkMainFunctions(optionInput))
                            validInput = false;
                        break;
                }
            } while (!validInput); // Stay in input loop unless valid input was pressed
        }
        
        /// <summary>Shows and handles upgrade items menu.</summary>
        static void menu51UpgradeItems()
        {
            parentMenu = 50;
            
            int[][] upgradeItemFlags = saveData.getDef<int[][]>("upgradeItemFlags");
            
            if (upgradeItemFlags == null || upgradeItemFlags.Length == 0)
            {
                menu = parentMenu;
                return;
            }
            
            // Count number obtained for each upgrade item, based on flags and shops.
            string[] upgradeItemNames = saveData.getDef<string[]>("upgradeItemNames");
            Dictionary<int, int[]> shopHPMemoryPrices = saveData.getDef<Dictionary<int, int[]>>("shopHPMemoryPrices");
            Dictionary<int, int[]> shopPowerUpPrices = saveData.getDef<Dictionary<int, int[]>>("shopPowerUpPrices");
            
            int[] itemsObtained = new int[upgradeItemNames.Length];
            for (int i = 0; i < upgradeItemFlags.Length; i++)
            {
                itemsObtained[i] = 0;
                foreach (int flag in upgradeItemFlags[i])
                {
                    if (saveData.getUpgradeItemObtained(flag))
                        itemsObtained[i]++;
                }
                
                if (upgradeItemNames[i].Equals("HPMemory"))
                    itemsObtained[i] += saveData.getHPMemoriesBought();
                else if (upgradeItemNames[i].Equals("PowerUP"))
                    itemsObtained[i] += saveData.getPowerUpsBought();
            }
            
            int[] itemMax = new int[upgradeItemNames.Length];
            for (int i = 0; i < upgradeItemNames.Length; i++)
                itemMax[i] = upgradeItemFlags[i].Length;
            foreach (int shop in shopHPMemoryPrices.Keys)
                itemMax[0] += shopHPMemoryPrices[shop].Length;
            foreach (int shop in shopPowerUpPrices.Keys)
                itemMax[1] += shopPowerUpPrices[shop].Length;
            
            Console.Clear();
            ConsoleC.WriteLineColor("***** Upgrade Items *****", "limegreen");
            Console.WriteLine("Press corresponding number/letter to enter menu/perform action.");
            Console.WriteLine();
            
            List<string> options = new List<string>();
            for (int i = 0; i < upgradeItemNames.Length; i++)
                options.Add(upgradeItemNames[i] + ": " + itemsObtained[i] + "/" + itemMax[i]);
            if (game == 1) // Special options for BN1 armors
            {
                for (int keyItemID = 68; keyItemID <= 70; keyItemID++)
                    options.Add(saveData.getDefIndex<string>("keyItemNames", keyItemID) + ": " + (saveData.keyItemQuantities[keyItemID] >= 1));
            }
            else if (game == 2) // Special option for BN2 Regular System (initial +4)
                options.Add("Regular System (+4): " + saveData.getUpgradeItemObtained(-58));
            options.Add("All Upgrade Items");
            
            printOptions(options);
            
            ConsoleC.WriteLineHL("{NOTE:} Editing obtained upgrade flags in these menus will automatically update\n" +
                (game == 1? "HP and Buster stats" : game == 2? "HP/Buster/Regular Memory" : "HP and Regular Memory values") + " to match what the flags indicate.");
            if (game == 4)
                Console.WriteLine("For upgrades found in Mystery Data, the items offered in other loops\n" +
                    "may also be given (or in some cases taken, when removing upgrades).");
            Console.WriteLine();
            
            printMainFunctions();
            
            bool validInput;
            do
            {
                validInput = true;
                string optionInput = waitToGetInputString();
                int selectedOption = getSelectedOptionIndex(options, optionInput);
                
                if (selectedOption < 0) // Not an option
                {
                    if (!checkMainFunctions(optionInput))
                        validInput = false;
                }
                else if (selectedOption < upgradeItemNames.Length) // Within range of normal upgrade items
                {
                    submenuArg = selectedOption;
                    goToMenu(52);
                    return;
                }
                else if (selectedOption < options.Count - 1) // Extra options outside those contained in upgradeItemNames
                {
                    if (game == 1) // BN1 armors
                    {
                        int keyItemID = 68 + (selectedOption - upgradeItemNames.Length);
                        bool bought = saveData.getKeyItemBought(keyItemID);
                        saveData.setKeyItemBought(keyItemID, !bought);
                        saveData.updateUpgradeItemsByFlags(nameOverride: "Armor");
                    }
                    else if (game == 2) // BN2 Regular System
                    {
                        bool obtained = saveData.getUpgradeItemObtained(-58);
                        saveData.setUpgradeItemObtained(-58, !obtained);
                        saveData.updateUpgradeItemsByFlags(nameOverride: "RegUP");
                    }
                }
                else // Last option, for all items
                {
                    Console.WriteLine();
                    ConsoleC.WriteLineHL("{[1]} Set all as collected");
                    ConsoleC.WriteLineHL("{[2]} Set all as uncollected");
                    
                    int allOption = waitToGetInputNumber(1, 2);
                    if (allOption < 0)
                        break;
                    
                    saveData.setAllUpgradeItemsCollected(allOption == 1);
                    
                    Console.WriteLine("All upgrades set as " + (allOption == 1? "" : "un") + "collected, and values updated.");
                    waitForEnter();
                }
            } while (!validInput); // Stay in input loop unless valid input was pressed
        }
        
        /// <summary>Shows nad handles submenu for toggling flags for a specific type of upgrade item, set by submenuArg.</summary>
        static void menu52UpgradeItemSubmenu()
        {
            parentMenu = 51;
            int upgradeNum = submenuArg;
            
            string upgradeName = saveData.getDefIndex<string>("upgradeItemNames", upgradeNum);
            int[] upgradeFlags = saveData.getDefIndex<int[]>("upgradeItemFlags", upgradeNum);
            Dictionary<int, int[]> shopHPMemoryPrices = saveData.getDef<Dictionary<int, int[]>>("shopHPMemoryPrices");
            Dictionary<int, int[]> shopPowerUpPrices = saveData.getDef<Dictionary<int, int[]>>("shopPowerUpPrices");
            
            int perPage = 8;
            
            int totalItems = upgradeFlags.Length;
            if (upgradeName.Equals("HPMemory") && shopHPMemoryPrices != null)
                totalItems += shopHPMemoryPrices.Keys.Count;
            if (upgradeName.Equals("PowerUP") && shopPowerUpPrices != null)
                totalItems += shopPowerUpPrices.Keys.Count;
            menuPageCount = (int)Math.Ceiling(totalItems / (double)perPage);
            
            Console.Clear();
            ConsoleC.WriteLineColor("***** Edit " + upgradeName + " Flags *****", "limegreen");
            Console.WriteLine("Press corresponding number/letter to edit value/perform action."
                + (menuPageCount > 1? "\nPress Enter to go to next page or Left/Right to switch pages." : ""));
            Console.WriteLine();
            
            List<string> flagOptions = new List<string>();
            for (int i = menuPage * perPage; i < (menuPage + 1) * perPage && i < totalItems; i++)
            {
                if (i < upgradeFlags.Length) // Flag
                {
                    bool obtained = saveData.getUpgradeItemObtained(upgradeFlags[i]);
                    string description = saveData.getUpgradeItemFlagDesc(upgradeFlags[i]);
                    flagOptions.Add(string.Format("{0,-5}", obtained) + " | " + description);
                }
                else // Shop
                {
                    int shopIndex = i - upgradeFlags.Length;
                    int shopNum = 0, shopBought = 0, shopMax = 0;
                    if (upgradeName.Equals("HPMemory"))
                    {
                        shopNum = new List<int>(shopHPMemoryPrices.Keys)[shopIndex];
                        shopBought = saveData.getHPMemoriesBought(shopNum);
                        shopMax = shopHPMemoryPrices[shopNum].Length;
                    }
                    else if (upgradeName.Equals("PowerUP"))
                    {
                        shopNum = new List<int>(shopPowerUpPrices.Keys)[shopIndex];
                        shopBought = saveData.getPowerUpsBought(shopNum);
                        shopMax = shopPowerUpPrices[shopNum].Length;
                    }
                    flagOptions.Add(saveData.getShopName(shopNum) + ": " + shopBought + "/" + shopMax);
                }
            }
            flagOptions.Add("All Flags for Item Type");
            
            printOptions(flagOptions);
            printMainFunctions();
            
            int flagIndex = 0;
            do
            {
                string flagInput = waitToGetInputString();
                flagIndex = getSelectedOptionIndex(flagOptions, flagInput, true);
                if (flagIndex == -2) // Page change
                    return;
                else if (flagIndex < 0)
                {
                    if (!checkMainFunctions(flagInput))
                        continue;
                    else
                        return;
                }
                break;
            } while (true);
            
            if (flagIndex == flagOptions.Count - 1) // All items option
            {
                Console.WriteLine();
                ConsoleC.WriteLineHL("{[1]} Set all as collected");
                ConsoleC.WriteLineHL("{[2]} Set all as uncollected");
                
                int allOption = waitToGetInputNumber(1, 2);
                if (allOption < 0)
                    return;
                
                if (saveData.setAllUpgradeItemsOfTypeCollected(upgradeNum, allOption == 1))
                    changesMade = true;
                
                Console.WriteLine("All " + upgradeName + " items set as " + (allOption == 1? "" : "un") + "collected, and values updated.");
                waitForEnter();
                return;
            }
            
            flagIndex += menuPage * perPage; // Get actual flag index by adding page offset
            if (flagIndex < upgradeFlags.Length) // Flag
            {
                int flagNum = upgradeFlags[flagIndex];
                if (saveData.setUpgradeItemObtained(flagNum, !saveData.getUpgradeItemObtained(flagNum))) // Set to opposite of current "obtained" status
                {
                    saveData.updateUpgradeItemsByFlags(upgradeNum);
                    changesMade = true;
                }
            }
            else if (flagIndex < totalItems) // Shop
            {
                int shopIndex = flagIndex - upgradeFlags.Length;
                int shopNum = 0, shopMax = 0;
                if (upgradeName.Equals("HPMemory"))
                {
                    shopNum = new List<int>(shopHPMemoryPrices.Keys)[shopIndex];
                    shopMax = shopHPMemoryPrices[shopNum].Length;
                }
                else if (upgradeName.Equals("PowerUP"))
                {
                    shopNum = new List<int>(shopPowerUpPrices.Keys)[shopIndex];
                    shopMax = shopPowerUpPrices[shopNum].Length;
                }
                
                Console.WriteLine();
                Console.WriteLine("Enter number of " + (upgradeName.Equals("HPMemory")? "HPMemories" : "PowerUPs") + " bought (out of " + shopMax + "):");
                string boughtInput = getTypedInput();
                byte boughtNum = 0;
                if (byte.TryParse(boughtInput, out boughtNum))
                {
                    if (boughtNum > shopMax)
                        boughtNum = (byte)shopMax;
                    
                    bool result = false;
                    if (upgradeName.Equals("HPMemory"))
                        result = saveData.setHPMemoriesBought(shopNum, boughtNum);
                    else if (upgradeName.Equals("PowerUP"))
                        result = saveData.setPowerUpsBought(shopNum, boughtNum);
                    
                    if (result)
                    {
                        saveData.updateUpgradeItemsByFlags(upgradeNum);
                        changesMade = true;
                    }
                }
            }
        }
        
        /// <summary>Shows and handles BN4 Past Mystery Data Collection Counts menu.</summary>
        static void menu53MysteryDataCounts()
        {
            parentMenu = 50;
            
            if (saveData.flags == null)
            {
                menu = parentMenu;
                return;
            }
            
            List<int> definedMDFlags = new List<int>();
            for (int flag = 3328; flag <= 4254; flag++)
            {
                string[] contents = BN4Definitions.getMysteryDataLoopContents(flag);
                if (contents.Length > 2) // Don't include GMDs without defined content
                    definedMDFlags.Add(flag);
            }
            
            Console.Clear();
            ConsoleC.WriteLineColor("***** Past Mystery Data Collection Counts *****", "limegreen");
            Console.WriteLine("(This counts number of collections of each BMD/PMD on past game loops.");
            Console.WriteLine("It does not count collection in the current loop, which is in Flags.)");
            Console.WriteLine();
            
            int flagsPerPage = 16;
            int firstFlagLine = 4;
            int cursorMax = (menuPage + 1) * flagsPerPage < definedMDFlags.Count? flagsPerPage : definedMDFlags.Count % flagsPerPage;
            if (cursorMax == 0) // On last page with exactly even number of flags
                cursorMax = flagsPerPage;
            if (flagCursor > cursorMax - 1)
                flagCursor = cursorMax - 1;
            
            List<string> options = new List<string>();
            for (int i = 0; i < flagsPerPage && (menuPage * flagsPerPage) + i < definedMDFlags.Count; i++)
            {
                int definedFlagIndex = (menuPage * flagsPerPage) + i;
                int flagNum = definedMDFlags[definedFlagIndex];
                string desc = saveData.getFlagDesc(flagNum);
                int nonDescMaxLength = definedMDFlags[(menuPage * flagsPerPage) + cursorMax - 1].ToString().Length + 7; // Digits of largest flag + "[] x255"
                if (nonDescMaxLength + desc.Length >= 76)
                    desc = desc.Substring(0, 73 - nonDescMaxLength) + "...";
                string leftBracket = i == flagCursor? "*" : "[";
                string rightBracket = i == flagCursor? "*" : "]";
                
                string nonDescString = string.Format("{0,-" + nonDescMaxLength + "}", leftBracket + flagNum + rightBracket + " x" + saveData.getBN4MysteryDataContentsIndex(flagNum));
                if (i == flagCursor) // Yellow highlight
                    nonDescString = "<*" + nonDescString.Substring(1).Replace("*", "*>");
                else // White highlight
                    nonDescString = nonDescString.Replace("[", "{[").Replace("]", "]}");
                
                options.Add(nonDescString + (desc != ""? " | " + desc : ""));
            }
            
            printOptions(options, false, withNumbers: false);
            Console.WriteLine();
            ConsoleC.WriteLineHL("{[Up/Down]} Cursor  {[Left/Right]} Page  {[Enter]} Edit  {[A]} Change All  {[0]} Back");
            
            while (true)
            {
                Console.CursorVisible = false;
                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.RightArrow)
                    {
                        menuPage++;
                        if (menuPage * flagsPerPage >= definedMDFlags.Count)
                            menuPage = 0;
                        return;
                    }
                    else if (key == ConsoleKey.LeftArrow)
                    {
                        menuPage--;
                        if (menuPage < 0)
                            menuPage = (definedMDFlags.Count - 1) / flagsPerPage;
                        return;
                    }
                    else if (key == ConsoleKey.DownArrow || key == ConsoleKey.UpArrow)
                    {
                        int oldCursor = flagCursor;
                        if (key == ConsoleKey.DownArrow)
                            flagCursor = (flagCursor + 1) % cursorMax;
                        else
                            flagCursor = (flagCursor + cursorMax - 1) % cursorMax;
                        
                        // Reprint only the lines for old and new cursor positions, and continue input loop.
                        if (oldCursor >= 0 && flagCursor >= 0 && flagCursor < options.Count && oldCursor < options.Count)
                        {
                            options[oldCursor] = Regex.Replace(options[oldCursor], "^<\\*([0-9]+)\\*>", "{[$1]}");
                            Console.CursorTop = firstFlagLine + oldCursor;
                            printOptions(options, withNumbers: false, onlyThisIndex: oldCursor);
                            
                            options[flagCursor] = Regex.Replace(options[flagCursor], "^\\{\\[([0-9]+)\\]\\}", "<*$1*>");
                            Console.CursorTop = firstFlagLine + flagCursor;
                            printOptions(options, withNumbers: false, onlyThisIndex: flagCursor);
                            
                            Console.CursorVisible = false;
                            System.Threading.Thread.Sleep(10);
                            continue;
                        }
                        else // Fall back on full refresh
                            return;
                    }
                    else if (key == ConsoleKey.Enter)
                    {
                        Console.CursorTop = firstFlagLine + cursorMax + 2; // Header before flags, flag lines for page, blank line, controls line
                        Console.CursorVisible = true;
                        
                        int definedFlagIndex = (menuPage * flagsPerPage) + flagCursor;
                        int flagNum = definedMDFlags[definedFlagIndex];
                        
                        Console.WriteLine(saveData.getFlagDesc(flagNum));
                        Console.Write("Enter new collected count: ");
                        string editInput = getTypedInput();
                        byte editValue = 0;
                        if (byte.TryParse(editInput, out editValue))
                        {
                            bool pauseAfter = false;
                            if (saveData.setMysteryDataCount(flagNum, editValue, ref pauseAfter))
                            {
                                changesMade = true;
                                if (pauseAfter)
                                    waitForEnter();
                            }
                        }
                        return;
                    }
                    else if (key == ConsoleKey.A)
                    {
                        Console.CursorTop = firstFlagLine + cursorMax + 2; // Header before flags, flag lines for page, blank line, controls line
                        Console.CursorVisible = true;
                        
                        ConsoleC.WriteLineHL("Enter a number to increment all counts by that number.\n"
                            + "An = followed by a number will increase counts up to that number.\n"
                            + "{NOTE:} Undernet 5/Black Earth are only intended to be reached on Loop 3+,\n"
                            + "so they are skipped for global increments, and =s are offset accordingly.\n"
                            + "BMDs in random tournament scenarios are also skipped entirely.");
                        Console.WriteLine();
                        
                        Console.Write("Enter global change value: ");
                        string changeAllInput = getTypedInput();
                        byte changeAllAmount = 0;
                        bool upToCount = changeAllInput.StartsWith("=");
                        if (changeAllInput.StartsWith("="))
                        {
                            upToCount = true;
                            changeAllInput = changeAllInput.Substring(1);
                        }
                        
                        if (byte.TryParse(changeAllInput, out changeAllAmount))
                        {
                            bool pauseAfter = false;
                            for (int flagIndex = 0; flagIndex < definedMDFlags.Count; flagIndex++)
                            {
                                int flagNum = definedMDFlags[flagIndex];
                                if (flagNum >= 4214) // Flags for MDs in random scenarios
                                    continue;
                                
                                string[] mdDef = BN4Definitions.getMysteryDataLoopContents(flagNum);
                                byte myChangeAmount = changeAllAmount;
                                if (mdDef.Length == 4) // Only type, area name, and two contents defined: intended to be inaccessible until Loop 3
                                {
                                    if (!upToCount || changeAllAmount < 3) // Skip over for global incrementing or setting below 3
                                        continue;
                                    else // Offset for assumption of first obtaining on Loop 3
                                        myChangeAmount -= 2;
                                }
                                
                                byte oldValue = saveData.getBN4MysteryDataContentsIndex(flagNum);
                                byte newValue = upToCount? (myChangeAmount > oldValue? myChangeAmount : oldValue) : (byte)Math.Min(oldValue + myChangeAmount, 255);
                                
                                if (saveData.setMysteryDataCount(flagNum, newValue, ref pauseAfter, true))
                                    changesMade = true;
                            }
                            if (pauseAfter)
                                waitForEnter();
                        }
                        return;
                    }
                    else if (key == ConsoleKey.D0 || key == ConsoleKey.NumPad0 || key == ConsoleKey.Backspace)
                    {
                        menu = parentMenu;
                        menuPage = 0;
                        menuPageCount = 1;
                        return;
                    }
                }
                
                System.Threading.Thread.Sleep(30);
            }
        }
        
        /// <summary>Shows and handles miscellaneous menu.</summary>
        static void menu60Miscellaneous()
        {
            parentMenu = 0;
            
            Console.Clear();
            ConsoleC.WriteLineColor("----- Miscellaneous -----", "pink");
            Console.WriteLine("Press corresponding number/letter to edit value/enter menu/perform action.");
            Console.WriteLine();
            
            List<string[]> options = new List<string[]>();
            
            if (game == 1)
                options.Add(new string[] { "powerPlantBattery", "Battery (Power Plant Comp): " + saveData.powerPlantBattery });
            else if (game == 3)
            {
                options.Add(new string[] { "virusFood", "Virus Food Distribution..." });
                options.Add(new string[] { "timeTrialRecords", "Time Trial Records..." });
            }
            else if (game == 4)
            {
                addOptionInfo(options, "playerName");
                options.Add(new string[] { "waitingRoom", "WaitingRoom Navis..." });
                options.Add(new string[] { "naviRecords", "Navi Record Times..." });
                addOptionInfo(options, "battlePoints");
            }
            
            if (game >= 2)
                addOptionInfo(options, "locEnemyEncounter");
            
            options.Add(new string[] { "multiplayerBattles", "Multiplayer Battles: " + saveData.multiplayerBattleRecord });
            options.Add(new string[] { "multiplayerWins", "Multiplayer Wins: " + saveData.multiplayerWinRecord });
            if (game == 4)
                options.Add(new string[] { "multiplayerVSVersion", "Multiplayer VS RS/BM Wins: " + saveData.multiplayerVSVersionRecord });
            
            printOptions(options);
            printMainFunctions();
            
            bool validInput;
            do
            {
                validInput = true;
                string optionInput = waitToGetInputString();
                string selectedOption = getSelectedOption(options, optionInput);
                switch (selectedOption)
                {
                    case "powerPlantBattery":
                        Console.WriteLine("\nInput remaining battery in Power Plant Comp (normal maximum 10):");
                        editByte(ref saveData.powerPlantBattery);
                        break;
                    
                    case "virusFood":
                        editMenuVirusFood();
                        break;
                    
                    case "timeTrialRecords":
                        List<string> timeTrialOptions = saveData.getBN3TimeTrialList();
                        
                        Console.WriteLine();
                        printOptions(timeTrialOptions, false);
                        
                        Console.WriteLine("Type number of time trial to edit:");
                        string timeTrialInput = getTypedInput();
                        int timeTrialIndex = getSelectedOptionIndex(timeTrialOptions, timeTrialInput);
                        if (timeTrialIndex < 0)
                            break;
                        
                        string timeTrialName = saveData.getDefIndex<string>("timeTrialNames", timeTrialIndex);
                        Console.WriteLine("Current " + timeTrialName + " record in frames: " + saveData.timeTrialRecords[timeTrialIndex * 2] + "\n"
                            + "Type new record in frames (60 frames = 1 second):");
                        if (editUInt(ref saveData.timeTrialRecords[timeTrialIndex * 2]))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Select record holder (Enter to default to MegaMan):");
                            ConsoleC.WriteLineHL("{[1]} MegaMan");
                            ConsoleC.WriteLineHL("{[2]} Serenade");
                            
                            int holderInput = waitToGetInputNumber(1, 2, enterDefault: 1);
                            if (holderInput < 0)
                                break;
                            
                            saveData.timeTrialRecords[(timeTrialIndex * 2) + 1] = holderInput == 2? (uint)0xEC : (uint)0x00;
                        }
                        break;
                    
                    case "playerName":
                        Console.WriteLine("\nType new player name (three letters/numbers or - . /):");
                        string playerName = getTypedInput().ToUpper();
                        if (playerName.Length == 0)
                            break;
                        
                        bool pauseAfter = false;
                        if (playerName.Length > 3)
                        {
                            playerName = playerName.Substring(0, 3);
                            Console.WriteLine("Shortening to " + playerName + ".");
                            pauseAfter = true;
                        }
                        
                        while (playerName.Length < 3)
                            playerName = playerName + "-";
                        
                        if (saveData.verifyTableString(playerName, "playerName"))
                        {
                            if (playerName != saveData.playerName)
                            {
                                saveData.playerName = playerName;
                                changesMade = true;
                            }
                        }
                        else
                            pauseAfter = true;
                        
                        if (pauseAfter)
                            waitForEnter();
                        break;
                    
                    case "waitingRoom":
                        editMenuWaitingRoom();
                        break;
                    
                    case "naviRecords":
                        editMenuBN4NaviRecords();
                        break;
                    
                    case "battlePoints":
                        Console.WriteLine("\nType new BattlePoints (50 needed for Eagle/Hawk prelims):");
                        editByte(ref saveData.battlePoints);
                        break;
                    
                    case "locEnemyEncounter":
                        Dictionary<int, string> encounters = SaveData.getGameDef().getDefinedEncounters();
                        if (encounters == null)
                            break;
                        
                        List<string> locEnemyOptions = new List<string>();
                        List<int> locEnemyIDs = new List<int>();
                        foreach (int key in encounters.Keys)
                        {
                            locEnemyOptions.Add(encounters[key]);
                            locEnemyIDs.Add(key);
                        }
                        locEnemyOptions.Add("None");
                        locEnemyIDs.Add(0);
                        
                        Console.WriteLine();
                        printOptions(locEnemyOptions, false, 2, 35);
                        
                        Console.WriteLine("Type number of encounter to set LocEnemy to:");
                        string locEnemyInput = getTypedInput();
                        int locEnemyIndex = getSelectedOptionIndex(locEnemyOptions, locEnemyInput);
                        if (locEnemyIndex < 0)
                            break;
                        
                        if (locEnemyIndex == locEnemyIDs.Count - 1) // None
                        {
                            if (saveData.isLocEnemyActive())
                            {
                                saveData.setLocEnemyActive(false);
                                changesMade = true;
                            }
                            break;
                        }
                        
                        int newEncounterID = locEnemyIDs[locEnemyIndex];
                        if (newEncounterID != saveData.locEnemyEncounterPointer.getEncounterID() || !saveData.isLocEnemyActive())
                        {
                            saveData.setLocEnemyActive(true, newEncounterID);
                            changesMade = true;
                        }
                        break;
                    
                    case "multiplayerBattles":
                        Console.WriteLine("\nType new multiplayer battle record:");
                        editUShort(ref saveData.multiplayerBattleRecord);
                        break;
                    
                    case "multiplayerWins":
                        Console.WriteLine("\nType new multiplayer win record:");
                        editUShort(ref saveData.multiplayerWinRecord);
                        break;
                    
                    case "multiplayerVSVersion":
                        Console.WriteLine("\nType new VS Red Sun/Blue Moon multiplayer win record (positive or negative):");
                        editShort(ref saveData.multiplayerVSVersionRecord);
                        break;
                    
                    default:
                        if (!checkMainFunctions(optionInput))
                            validInput = false;
                        break;
                }
            } while (!validInput); // Stay in input loop unless valid input was pressed
        }
        
        /// <summary>Handler for editing BN3 Virus Breeder food distribution.</summary>
        static void editMenuVirusFood()
        {
            List<string> virusGroupOptions = new List<string>();
            int virusIndex = 0;
            while (virusIndex < BN3Definitions.virusBreederNames.Length)
            {
                List<byte> foodAmounts = new List<byte>();
                int virusLevelCount = BN3Definitions.virusBreederNames[virusIndex].Equals("Scuttlest")? 6 : 4;
                if (virusLevelCount != 6) // Normal order)
                {
                    for (int virusLevel = 0; virusLevel < virusLevelCount; virusLevel++)
                        foodAmounts.Add(saveData.virusFoodDistribution[virusIndex + virusLevel]);
                }
                else // Shifted internal order for Scuttlest
                {
                    for (int virusLevel = 1; virusLevel <= 4; virusLevel++) // Scutz, Scuttle, Scuttler
                        foodAmounts.Add(saveData.virusFoodDistribution[virusIndex + virusLevel]);
                    foodAmounts.Add(saveData.virusFoodDistribution[virusIndex]); // Scuttlest
                    foodAmounts.Add(saveData.virusFoodDistribution[virusIndex + 5]); // Scuttle Omega
                }
                
                virusGroupOptions.Add(BN3Definitions.virusBreederNames[virusIndex] + ": " + printArray<byte>(foodAmounts.ToArray()));
                virusIndex += virusLevelCount;
            }
            virusGroupOptions.Add("All Groups");
            
            Console.WriteLine();
            printOptions(virusGroupOptions, false);
            
            Console.WriteLine("Type number of virus group to edit:");
            string virusGroupInput = getTypedInput();
            int virusGroupIndex = getSelectedOptionIndex(virusGroupOptions, virusGroupInput);
            if (virusGroupIndex < 0)
                return;
            
            int targetIndex = -1;
            string specialMode = "";
            if (virusGroupIndex == virusGroupOptions.Count - 1) // All groups
            {
                Console.WriteLine();
                ConsoleC.WriteLineHL("{[1]} Set food for strongest in each group");
                ConsoleC.WriteLineHL("{[2]} Set food for all viruses");
                
                int allTargetInput = waitToGetInputNumber(1, 2, enterDefault: 1);
                if (allTargetInput < 0)
                    return;
                
                specialMode = allTargetInput == 1? "allstrongest" : "all";
                Console.WriteLine("Selected " + (allTargetInput == 1? "strongest only" : "all viruses") + ".");
            }
            else // Pick within chosen group
            {
                List<string> individualVirusOptions = new List<string>();
                int groupBaseIndex = virusGroupIndex * 4;
                int virusLevelCount = BN3Definitions.virusBreederNames[groupBaseIndex].Equals("Scuttlest")? 6 : 4;
                for (int virusLevel = 0; virusLevel < virusLevelCount; virusLevel++)
                {
                    int trueIndex = virusLevel;
                    if (virusLevelCount == 6) // Swap ordering for Scuttlest, which has weird order internally
                    {
                        if (trueIndex < 4) // First four levels (index 0-3) are at indexes 1 to 4
                            trueIndex++;
                        else if (trueIndex == 4) // Fifth level (index 4) is Scuttlest, at index 0 such that its name is used as group name
                            trueIndex = 0;
                        // Sixth level (index 5) is Scuttle Omega, which remains 5
                    }
                    
                    individualVirusOptions.Add(BN3Definitions.virusBreederNames[groupBaseIndex + trueIndex] + ": " + saveData.virusFoodDistribution[groupBaseIndex + trueIndex]);
                }
                individualVirusOptions.Add("All In Group");
                
                Console.WriteLine();
                printOptions(individualVirusOptions, false);
                
                Console.WriteLine("Type number of virus to edit:");
                string individualVirusInput = getTypedInput();
                targetIndex = getSelectedOptionIndex(individualVirusOptions, individualVirusInput);
                if (targetIndex < 0)
                    return;
                
                if (targetIndex == individualVirusOptions.Count - 1) // All in group
                {
                    targetIndex = groupBaseIndex;
                    specialMode = "allingroup";
                }
                else // Single target in group
                {
                    int trueIndex = targetIndex;
                    if (virusLevelCount == 6) // Swap ordering for Scuttlest
                    {
                        if (trueIndex < 4) // First four levels (index 0-3) are at indexes 1 to 4
                            trueIndex++;
                        else if (trueIndex == 4) // Fifth level (index 4) is Scuttlest, at index 0 such that its name is used as group name
                            trueIndex = 0;
                        // Sixth level (index 5) is Scuttle Omega, which remains 5
                    }
                    targetIndex = groupBaseIndex + trueIndex;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Type food amount to set (maximum 100):");
            string foodInput = getTypedInput();
            byte foodValue = 0;
            if (!byte.TryParse(foodInput, out foodValue))
                return;
            
            if (saveData.setVirusFoodDistribution(targetIndex, foodValue, specialMode))
                changesMade = true;
        }
        
        /// <summary>Handler for editing WaitingRoom entries.</summary>
        static void editMenuWaitingRoom()
        {
            List<string> waitingRoomOptions = saveData.getWaitingRoomOccupantsList();
            
            Console.WriteLine();
            Console.WriteLine("Select slot to edit:");
            printOptions(waitingRoomOptions, false);
            
            int waitingRoomIndex = waitToGetInputNumber(1, 7);
            if (waitingRoomIndex < 0)
                return;
            waitingRoomIndex--; // Change to zero-based index
            
            Console.WriteLine("Selected Slot " + (waitingRoomIndex + 1) + ": " + waitingRoomOptions[waitingRoomIndex] + ".");
            
            int waitingRoomAction = -1;
            if (saveData.waitingRoomData[(waitingRoomIndex * 2) + 1] != 0xFF) // Slot filled, prompt for what to do
            {
                Console.WriteLine();
                ConsoleC.WriteLineHL("{[1]} Replace Navi");
                ConsoleC.WriteLineHL("{[2]} Change Associated Name");
                ConsoleC.WriteLineHL("{[3]} Delete Entry");
                
                waitingRoomAction = waitToGetInputNumber(1, 3);
                if (waitingRoomAction < 0)
                    return;
                
                if (waitingRoomAction == 3) // Delete entry
                {
                    saveData.setWaitingRoomNavi(waitingRoomIndex, 0xFF);
                    changesMade = true;
                    return;
                }
                // Otherwise, continue on to set new Navi or name.
            }
            
            if (waitingRoomAction == 1 || waitingRoomAction == -1) // Set Navi (either directly selected, or default because slot is empty)
            {
                List<string> naviOptions = saveData.getWaitingRoomNaviOptions();
                
                Console.WriteLine();
                printOptions(naviOptions, false);
                Console.WriteLine("Type number of Navi to put in slot:");
                
                string selectNaviInput = getTypedInput();
                int selectNaviID = getSelectedOptionIndex(naviOptions, selectNaviInput);
                if (selectNaviID < 0)
                    return;
                
                if (saveData.waitingRoomData[(waitingRoomIndex * 2) + 1] != selectNaviID)
                {
                    saveData.setWaitingRoomNavi(waitingRoomIndex, (byte)selectNaviID);
                    changesMade = true;
                }
            }
            
            if (waitingRoomAction == 2 || waitingRoomAction == -1) // Set name (either directly selected, or after picking Navi for empty slot)
            {
                Console.WriteLine();
                string playerNameDisplay = saveData.playerName.Replace("ー", "-").Replace("—", "-"); // Convert non-ASCII dash symbols for display
                Console.WriteLine("Type associated name (Enter to use player name " + playerNameDisplay + "):");
                string newAssociatedName = getTypedInput().ToUpper();
                
                if (newAssociatedName != "")
                {
                    if (newAssociatedName.Length > 3)
                        newAssociatedName = newAssociatedName.Substring(0, 3);
                    while (newAssociatedName.Length < 3)
                        newAssociatedName = newAssociatedName + "-";
                    if (!saveData.verifyTableString(newAssociatedName, "playerName"))
                        newAssociatedName = "";
                }
                
                string trueNewName = newAssociatedName != ""? newAssociatedName : saveData.playerName;
                if (saveData.waitingRoomNames[waitingRoomIndex] != trueNewName)
                {
                    saveData.waitingRoomNames[waitingRoomIndex] = trueNewName;
                    changesMade = true;
                }
            }
        }
        
        /// <summary>Handler for editing BN4 Navi deletion time records.</summary>
        static void editMenuBN4NaviRecords()
        {
            List<string> naviRecordOptions = saveData.getBN4NaviRecordsList();
            
            Console.WriteLine();
            printOptions(naviRecordOptions, false);
            
            Console.WriteLine("Type number of record to edit:");
            string naviRecordInput = getTypedInput();
            int naviRecordIndex = getSelectedOptionIndex(naviRecordOptions, naviRecordInput);
            if (naviRecordIndex < 0)
                return;
            
            string naviRecordName = saveData.getDefIndex<string>("timeTrialNames", naviRecordIndex);
            
            Console.WriteLine();
            Console.WriteLine("Select which " + naviRecordName + " record to edit (if My Record is faster, updates both):");
            ConsoleC.WriteLineHL("{[1]} My Record (" + (saveData.myNaviRecords[naviRecordIndex] < 0xFFFF? "in frames: " + saveData.myNaviRecords[naviRecordIndex] : "unset") + ")");
            ConsoleC.WriteLineHL("{[2]} Best Record (" + (saveData.bestNaviRecords[naviRecordIndex] < 0xFFFF? "in frames: " + saveData.bestNaviRecords[naviRecordIndex] : "unset") + ")");
            
            int whichRecord = waitToGetInputNumber(1, 2);
            if (whichRecord < 0)
                return;
            
            bool bestChanged = false;
            Console.WriteLine();
            Console.WriteLine("Type new record in frames (60 frames = 1 second):");
            if (whichRecord == 1)
                editUShort(ref saveData.myNaviRecords[naviRecordIndex]);
            else if (whichRecord == 2)
                bestChanged = editUShort(ref saveData.bestNaviRecords[naviRecordIndex]);
            
            if (saveData.myNaviRecords[naviRecordIndex] < saveData.bestNaviRecords[naviRecordIndex])
            {
                saveData.bestNaviRecords[naviRecordIndex] = saveData.myNaviRecords[naviRecordIndex];
                bestChanged = true;
                changesMade = true;
            }
            
            if (!saveData.flags[133 + naviRecordIndex]) // Flag to show this Navi in records screen
            {
                saveData.setFlag(133 + naviRecordIndex);
                changesMade = true;
            }
            
            if (bestChanged)
            {
                Console.WriteLine();
                string playerNameDisplay = saveData.playerName.Replace("ー", "-").Replace("—", "-"); // Convert non-ASCII dash symbols for display
                Console.WriteLine("Type new record holder name (Enter to use player name " + playerNameDisplay + "):");
                string newRecordHolder = getTypedInput().ToUpper();
                
                if (newRecordHolder.Length > 3)
                    newRecordHolder = newRecordHolder.Substring(0, 3);
                while (newRecordHolder.Length < 3)
                    newRecordHolder = newRecordHolder + "-";
                if (!saveData.verifyTableString(newRecordHolder, "playerName"))
                    newRecordHolder = "";
                
                saveData.naviRecordHolderNames[naviRecordIndex] = newRecordHolder != ""? newRecordHolder : saveData.playerName;
            }
        }
        
        /// <summary>Shows and handles Steam ID menu.</summary>
        static void menu70SteamID()
        {
            parentMenu = 0;
            
            Console.Clear();
            ConsoleC.WriteLineColor("----- Steam ID -----", "pink");
            Console.WriteLine("Press corresponding number/letter to edit value/perform action.");
            Console.WriteLine();
            
            List<string[]> options = new List<string[]>();
            addOptionInfo(options, "steamID");
            options.Add(new string[] { "loadIDFromSave", "Load Steam ID From LC Save..." });
            
            printOptions(options);
            
            int lcVolume = game <= 3? 1 : 2;
            int steamGameID = lcVolume == 1? 1798010 : 1798020;
            
            Console.WriteLine("(In the Steam version of Legacy Collection, the Steam ID in the save\n"
                + "must match your Steam user ID to load. MMBNLC Volume " + lcVolume + " Steam saves are\n"
                + "generally located at \".../Program Files/Steam/userdata/[SteamID]/" + steamGameID + "\".\n"
                + "If you provide an LC save of your own, the Steam ID can be read from it."
                + (userSettings["SteamID"] == 0? "\nIt can be set automatically if you define it in UserSettings.txt." : "")
                + ")");
            Console.WriteLine();
            
            printMainFunctions();
            
            bool validInput;
            do
            {
                validInput = true;
                string optionInput = waitToGetInputString();
                string selectedOption = getSelectedOption(options, optionInput);
                switch (selectedOption)
                {
                    case "steamID":
                        Console.WriteLine("\nEnter Steam ID:");
                        editUInt(ref saveData.steamID);
                        break;
                    
                    case "loadIDFromSave":
                        OpenFileDialog dialog = new OpenFileDialog();
                        dialog.Filter = "MMBNLC Save File|*.bin";
                        dialog.Title = "Select MMBNLC Save File";
                        
                        string filename = "";
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            filename = dialog.FileName;
                            string extension = Path.GetExtension(filename).ToLower();
                            if (!extension.Equals(".bin"))
                            {
                                Console.WriteLine("Unrecognized file type.");
                                waitForEnter();
                                return;
                            }
                            
                            bool tryLoad = true;
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Reading Steam ID from " + Path.GetFileName(filename) + ".");
                                    SaveData tempSave = new SaveData(File.ReadAllBytes(filename), true, onlyLoadSteamID: true);
                                    bool versionUncertain = false;
                                    bool languageUncertain = false;
                                    tempSave.initSaveData(ref versionUncertain, ref languageUncertain, true);
                                    if (saveData.steamID != tempSave.steamID)
                                    {
                                        saveData.steamID = tempSave.steamID;
                                        changesMade = true;
                                        Console.WriteLine("Steam ID set to " + tempSave.steamID + ".");
                                    }
                                    else
                                        Console.WriteLine("Steam ID already matches.");
                                    waitForEnter();
                                    tryLoad = false;
                                }
                                catch
                                {
                                    Console.WriteLine("Could not load " + Path.GetFileName(filename) + ". File may be in use.");
                                    Console.WriteLine("Try again? (Y/N)");
                                    string tryAgain = getTypedInput().ToUpper();
                                    if (tryAgain != "Y")
                                        tryLoad = false;
                                }
                            } while (tryLoad);
                        }
                        break;
                    
                    default:
                        if (!checkMainFunctions(optionInput))
                            validInput = false;
                        break;
                }
            } while (!validInput); // Stay in input loop unless valid input was pressed
        }
        
        /* GENERAL HELPER FUNCTIONS */
        
        /// <summary>Takes user input to edit the passed byte value, setting changesMade if the value differs.</summary>
        /// <param name="value">The value to edit.</param>
        /// <param name="min">Minumum value which input will be kept within.</param>
        /// <param name="max">Maximum value which input will be kept within.</param>
        /// <param name="input">The user's input. By default, this function includes the input prompt, but it can be passed in instead if already obtained.</param>
        /// <returns>Whether the value changed.</returns>
        static bool editByte(ref byte value, byte min = 0, byte max = byte.MaxValue, string input = null)
        {
            if (input == null)
                input = getTypedInput();
            
            byte newValue = 0;
            if (byte.TryParse(input, out newValue))
            {
                newValue = Math.Min(Math.Max(newValue, min), max);
                if (newValue != value)
                {
                    value = newValue;
                    changesMade = true;
                    return true;
                }
            }
            return false;
        }
        
        /// <summary>Takes user input to assign to all bytes of the passed array, setting changesMade if any values changed.</summary>
        /// <param name="values">The values to edit.</param>
        /// <param name="min">Minumum value which input will be kept within.</param>
        /// <param name="max">Maximum value which input will be kept within.</param>
        /// <param name="input">The user's input. By default, this function includes the input prompt, but it can be passed in instead if already obtained.</param>
        /// <param name="indexesToModify">A list of what indexes in the array should be modified; if provided, indexes not included will be skipped.</param>
        /// <returns>Whether any values changed.</returns>
        static bool editBytesToOneValue(ref byte[] values, byte min = 0, byte max = byte.MaxValue, string input = null, List<int> indexesToModify = null)
        {
            if (input == null)
                input = getTypedInput();
            
            byte newValue = 0;
            if (byte.TryParse(input, out newValue))
            {
                newValue = Math.Min(Math.Max(newValue, min), max);
                bool anyChanges = false;
                for (int i = 0; i < values.Length; i++)
                {
                    if (indexesToModify != null && !indexesToModify.Contains(i))
                        continue;
                    
                    if (newValue != values[i])
                    {
                        values[i] = newValue;
                        changesMade = true;
                    }
                }
                return anyChanges;
            }
            return false;
        }
        
        /// <summary>Toggles the value of a byte that is either 00 or 01 (or 00 and a specified "on" value), and sets changesMade.</summary>
        /// <param name="value">The value to toggle.</param>
        static void toggle01Byte(ref byte value, byte onValue = 0x01)
        {
            value = (value == onValue? (byte)0x00 : onValue);
            changesMade = true;
        }
        
        /// <summary>Cycles a byte value between the given list of values in order, and sets changesMade.</summary>
        /// <param name="value">The value to change.</param>
        /// <param name="cycleValues">An array of values to cycle through.</param>
        static void cycleByte(ref byte value, byte[] cycleValues)
        {
            int index = -1;
            for (int i = 0; i < cycleValues.Length; i++)
            {
                if (value == cycleValues[i])
                {
                    index = i;
                    break;
                }
            }
            value = cycleValues[(index + 1) % cycleValues.Length];
            changesMade = true;
        }
        
        /// <summary>Takes user input to edit the passed ushort value, setting changesMade if the value differs.</summary>
        /// <param name="value">The value to edit.</param>
        /// <param name="min">Minumum value which input will be kept within.</param>
        /// <param name="max">Maximum value which input will be kept within.</param>
        /// <param name="input">The user's input. By default, this function includes the input prompt, but it can be passed in instead if already obtained.</param>
        /// <returns>Whether the value changed.</returns>
        static bool editUShort(ref ushort value, ushort min = 0, ushort max = ushort.MaxValue, string input = null)
        {
            if (input == null)
                input = getTypedInput();
            
            ushort newValue = 0;
            if (ushort.TryParse(input, out newValue))
            {
                newValue = Math.Min(Math.Max(newValue, min), max);
                if (newValue != value)
                {
                    value = newValue;
                    changesMade = true;
                    return true;
                }
            }
            return false;
        }
        
        /// <summary>Takes user input to edit the passed short value, setting changesMade if the value differs.</summary>
        /// <param name="value">The value to edit.</param>
        /// <param name="min">Minumum value which input will be kept within.</param>
        /// <param name="max">Maximum value which input will be kept within.</param>
        /// <param name="input">The user's input. By default, this function includes the input prompt, but it can be passed in instead if already obtained.</param>
        /// <returns>Whether the value changed.</returns>
        static bool editShort(ref short value, short min = short.MinValue, short max = short.MaxValue, string input = null)
        {
            if (input == null)
                input = getTypedInput();
            
            short newValue = 0;
            if (short.TryParse(input, out newValue))
            {
                newValue = Math.Min(Math.Max(newValue, min), max);
                if (newValue != value)
                {
                    value = newValue;
                    changesMade = true;
                    return true;
                }
            }
            return false;
        }
        
        /// <summary>Takes user input to edit the passed uint value, setting changesMade if the value differs.</summary>
        /// <param name="value">The value to edit.</param>
        /// <param name="min">Minumum value which input will be kept within.</param>
        /// <param name="max">Maximum value which input will be kept within.</param>
        /// <param name="input">The user's input. By default, this function includes the input prompt, but it can be passed in instead if already obtained.</param>
        /// <returns>Whether the value changed.</returns>
        static bool editUInt(ref uint value, uint min = 0, uint max = uint.MaxValue, string input = null)
        {
            if (input == null)
                input = getTypedInput();
            
            uint newValue = 0;
            if (uint.TryParse(input, out newValue))
            {
                newValue = Math.Min(Math.Max(newValue, min), max);
                if (newValue != value)
                {
                    value = newValue;
                    changesMade = true;
                    return true;
                }
            }
            return false;
        }
        
        /// <summary>Returns a number array in string format.</summary>
        /// <param name="array">The array to print.</param>
        /// <param name="length">The length of array to print; by default, prints the whole array.</param>
        /// <param name="format">String format to use for values. For example, {0:X2} will print hex strings.</param>
        /// <returns>The array string.</returns>
        public static string printArray<T>(T[] array, int length = -1, string format = "")
        {
            if (array == null)
                return "";
            
            if (length == -1)
                length = array.Length;
            
            string str = "";
            for (int i = 0; i < length; i++)
                str += (str != ""? ", " : "") + (format == ""? array[i].ToString() : string.Format(format, array[i]));
            return "[" + str + "]";
        }
        
        /// <summary>Returns a number array in hex string format.</summary>
        /// <param name="array">The array to print.</param>
        /// <param name="length">The length of array to print; by default, prints the whole array.</param>
        /// <returns>The array string.</returns>
        public static string printArrayHex<T>(T[] array, int length = -1)
        {
            return printArray<T>(array, length, "{0:X2}");
        }
        
        /// <summary>Returns a string array as a single combined string.</summary>
        /// <param name="array">The string array to print.</param>
        /// <param name="commaSeparator">Whether to use commas instead of linebreaks.</param>
        /// <returns>The list string.</returns>
        public static string printStringArray(string[] array, bool commaSeparator = false)
        {
            if (array == null)
                return "";
            
            string str = "";
            for (int i = 0; i < array.Length; i++)
                str += (str != ""? (!commaSeparator? Environment.NewLine : ", ") : "") + array[i];
            return str;
        }
        
        /// <summary>Returns a string list as a single combined string.</summary>
        /// <param name="list">The string list to print.</param>
        /// <param name="commaSeparator">Whether to use commas instead of linebreaks.</param>
        /// <returns>The list string.</returns>
        public static string printStringList(List<string> list, bool commaSeparator = false)
        {
            return printStringArray(list.ToArray(), commaSeparator);
        }
        
        /// <summary>Converts a hex string of bytes on clipboard to a list of bytes.</summary>
        /// <returns>The byte list.</returns>
        static List<byte> getBytesFromClipboard()
        {
            string clipboard = Clipboard.GetText();
            List<byte> clipBytes = new List<byte>();
            
            bool validFormat = true;
            for (int i = 0; i + 1 < clipboard.Length; i += 2)
            {
                try
                {
                    string byteStr = clipboard.Substring(i, 2);
                    if (byteStr.Contains(" "))
                    {
                        validFormat = false;
                        break;
                    }
                    clipBytes.Add(byte.Parse(byteStr, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture));
                }
                catch
                {
                    validFormat = false;
                    break;
                }
            }
            
            // If spacing of 2 (no spaces between bytes) doesn't work, try spacing of 3 (one space between bytes).
            if (!validFormat)
            {
                clipBytes.Clear();
                for (int i = 0; i + 1 < clipboard.Length; i += 3)
                {
                    try
                    {
                        string byteStr = byteStr = clipboard.Substring(i, i + 2 < clipboard.Length? 3 : 2);
                        clipBytes.Add(byte.Parse(byteStr.Trim(), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture));
                    }
                    catch
                    {
                        Console.WriteLine("Unable to read clipboard content as valid hex string.");
                        waitForEnter();
                        return new List<byte>();
                    }
                }
            }
            
            return clipBytes;
        }
    }
    
    /// <summary>A wrapper for the Console class to aid in writing colored text.</summary>
    public static class ConsoleC
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);
        
        [DllImport("kernel32.dll")]
        static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);
        
        [DllImport("kernel32.dll")]
        static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);
        
        static string RESET_COLOR = "\x1b[0m";
        
        /// <summary>Switches console mode to allow custom console colors.</summary>
        public static void enableConsoleColors()
        {
            IntPtr handle = GetStdHandle(-11); // STD_OUTPUT_HANDLE
            uint mode;
            GetConsoleMode(handle, out mode);
            SetConsoleMode(handle, mode | 0x4);// ENABLE_VIRTUAL_TERMINAL_PROCESSING
        }
        
        /// <summary>Writes an entire line to console in the specified color.</summary>
        /// <param name="message">The string to write.</param>
        /// <param name="color">The optional color for the line.</param>
        public static void WriteLineColor(String message, string color)
        {
            string colorCode = getColorEscapeCode(color);
            Console.WriteLine(colorCode + message + (colorCode != ""? RESET_COLOR : ""));
        }
        
        /// <summary>Writes text to console with bracketed text being in specified colors.</summary>
        /// <param name="message">The string to write.</param>
        /// <param name="curlyColor">The color name for text within {} curly braces. Default is light blue.</param>
        /// <param name="angleColor">The color name for text within <> angle brackets. If not specified, angle brackets will be printed as normal.</param>
        /// <param name="bracketColor">The color name for text within [] square brackets. If not specified, square brackets will be printed as normal.</param>
        public static void WriteHL(String message, string curlyColor = "lightblue", string angleColor = "", string bracketColor = "")
        {
            List<string> bracketTypes = new List<string>();
            if (curlyColor != "")
                bracketTypes.Add("{");
            if (angleColor != "")
                bracketTypes.Add("<");
            if (bracketColor != "")
                bracketTypes.Add("[");
            
            int writePosition = 0;
            while (true)
            {
                int nextBracket = int.MaxValue;
                string nextBracketType = "";
                foreach (string bracket in bracketTypes)
                {
                    int myNextBracket = message.IndexOf(bracket, writePosition);
                    if (myNextBracket >= 0 && myNextBracket < nextBracket) // Earliest bracket found so far
                    {
                        nextBracket = myNextBracket;
                        nextBracketType = bracket;
                    }
                }
                
                if (nextBracket == -1 || nextBracket == int.MaxValue || nextBracketType == "") // No more brackets, write the rest
                {
                    Console.Write(message.Substring(writePosition, message.Length - writePosition));
                    break;
                }
                
                // Write up to the start bracket.
                if (nextBracket > writePosition)
                    Console.Write(message.Substring(writePosition, nextBracket - writePosition));
                writePosition = nextBracket + 1;
                
                // Determine color.
                string myColor = "";
                if (nextBracketType == "{")
                    myColor = curlyColor;
                else if (nextBracketType == "<")
                    myColor = angleColor;
                else if (nextBracketType == "[")
                    myColor = bracketColor;
                string colorCode = getColorEscapeCode(myColor);
                
                // Find the matching end bracket.
                string endBracketType = nextBracketType == "{"? "}" : nextBracketType == "<"? ">" : "]";
                int endBracket = message.IndexOf(endBracketType, writePosition);
                
                if (endBracket == -1) // Couldn't find matching bracket, so just go to end
                {
                    Console.Write(colorCode + message.Substring(writePosition, message.Length - writePosition) + (colorCode != ""? RESET_COLOR : ""));
                    break;
                }
                
                // Write up to the end bracket with color escape code.
                if (endBracket > writePosition)
                    Console.Write(colorCode + message.Substring(writePosition, endBracket - writePosition) + (colorCode != ""? RESET_COLOR : ""));
                writePosition = endBracket + 1;
            }
        }
        
        /// <summary>Writes a line to console with bracketed text being in specified colors.</summary>
        /// <param name="message">The string to write.</param>
        /// <param name="curlyColor">The color name for text within {} curly braces. Default is light blue.</param>
        /// <param name="angleColor">The color name for text within <> angle brackets. If not specified, angle brackets will be printed as normal.</param>
        /// <param name="bracketColor">The color name for text within [] square brackets. If not specified, square brackets will be printed as normal.</param>
        public static void WriteLineHL(String message, string curlyColor = "lightblue", string angleColor = "", string bracketColor = "")
        {
            WriteHL(message, curlyColor, angleColor, bracketColor);
            Console.WriteLine();
        }
        
        /// <summary>Returns a color escape code for the given color name.</summary>
        /// <param name="color">The color name.</param>
        /// <param name="blankIfNotFound">Whether to return a blank string instead of white if the color name is not defined.</param>
        /// <returns>The color escape code that can be used to change color of console text.</returns>
        static string getColorEscapeCode(string color, bool blankIfNotFound = true)
        {
            byte[] values = getColor(color);
            if (blankIfNotFound && color != "white" && values[0] == 255 && values[1] == 255 && values[2] == 255)
                return "";
            return "\x1b[38;2;" + values[0] + ";" + values[1] + ";" + values[2] + "m";
        }
        
        /// <summary>Returns a byte array of RGB color values for the given color name.</summary>
        /// <param name="color">The color name.</param>
        /// <returns>An array of RGB values. If color name not found, returns white.</returns>
        static byte[] getColor(string color)
        {
            switch (color)
            {
                case "lightblue": return new byte[] { 170, 220, 255 };
                case "yellow": return new byte[] { 240, 210, 0 };
                case "red": return new byte[] { 220, 70, 70 };
                case "limegreen": return new byte[] { 200, 230, 90 };
                case "pink": return new byte[] { 240, 140, 240 };
                case "darkgray": return new byte[] { 128, 128, 128 };
            }
            return new byte[] { 255, 255, 255 };
        }
    }
}
