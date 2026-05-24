using System.Collections.Generic;

namespace MMBNSaveEditor
{
    /// <summary>An object that returns definitions for Battle Network 1.</summary>
    class BN1Definitions : BNDefinitions
    {
        public override string[] chipNames { get { return new string[] {
            "Buster", "Cannon", "HiCannon", "M-Cannon", "Sword", "WideSwrd", "LongSwrd", "LilBomb", "CrosBomb", "BigBomb",
            "Spreader", "Bubbler", "Heater", "MiniBomb", "Shotgun", "CrossGun", "ShokWave", "SoniWave", "DynaWave", "FireTowr",
            "AquaTowr", "WoodTowr", "Quake1", "Quake2", "Quake3", "FireSwrd", "ElecSwrd", "AquaSwrd", "GutsPnch", "IcePunch",
            "FtrSword", "Dash", "KngtSwrd", "HeroSwrd", "MetGuard", "", "", "TriArrow", "TriSpear", "TriLance",
            "Typhoon", "Huricane", "Cyclone", "Howitzer", "Thunder1", "Thunder2", "Thunder3", "", "", "Snakegg1",
            "Snakegg2", "Snakegg3", "Hammer", "", "", "BodyBurn", "", "", "Ratton1", "Ratton2",
            "Ratton3", "Lockon1", "Lockon2", "Lockon3", "X-Panel1", "X-Panel3", "", "Recov10", "Recov30", "Recov50",
            "Recov80", "Recov120", "Recov150", "Recov200", "Recov300", "", "Steal", "", "", "Geddon1",
            "Geddon2", "", "Escape", "Interupt", "LifeAura", "AquaAura", "FireAura", "WoodAura", "Repair", "",
            "", "Cloud", "Cloudier", "Cloudest", "IceCube", "RockCube", "", "TimeBom1", "TimeBom2", "TimeBom3",
            "Invis1", "Invis2", "Invis3", "IronBody", "", "Remobit1", "Remobit2", "Remobit3", "BstrGard", "BstrBomb",
            "BstrSwrd", "BstrPnch", "RingZap1", "RingZap2", "RingZap3", "Candle1", "Candle2", "Candle3", "SloGauge", "FstGauge",
            "", "Drain1", "Drain2", "Drain3", "Mine1", "Mine2", "Mine3", "Gaia1", "Gaia2", "Gaia3",
            "BblWrap1", "BblWrap2", "BblWrap3", "Wave", "RedWave", "BigWave", "Muramasa", "Dropdown", "Popup", "Dynamyt1",
            "Dynamyt2", "Dynamyt3", "Anubis", "", "", "IronShld", "LeafShld", "Barrier", "PharoMan", "PharoMn2",
            "PharoMn3", "ShadoMan", "ShadoMn2", "ShadoMn3", "", "", "", "MagicMan", "MagicMn2", "MagicMn3",
            "Roll", "Roll2", "Roll3", "GutsMan", "GutsMan2", "GutsMan3", "ProtoMan", "ProtoMn2", "ProtoMn3", "WoodMan",
            "WoodMan2", "WoodMan3", "FireMan", "FireMan2", "FireMan3", "NumbrMan", "NumbrMn2", "NumbrMn3", "StoneMan", "StoneMn2",
            "StoneMn3", "IceMan", "IceMan2", "IceMan3", "SkullMan", "SkullMn2", "SkullMn3", "ColorMan", "ColorMn2", "ColorMn3",
            "BombMan", "BombMan2", "BombMan3", "SharkMan", "SharkMn2", "SharkMn3", "ElecMan", "ElecMan2", "ElecMan3", "Bass"
        }; } }
        
        public override Dictionary<string, string[]> chipAliases { get {
            Dictionary<string, string[]> def = new Dictionary<string, string[]>();
            def["PharoMan"] = new string[] { "PharaohMan", "PharaohMn" };
            def["PharoMn2"] = new string[] { "PharaohMan2", "PharaohMn2", "PharoMan2", "PharaohManV2", "PharaohMnV2", "PharoManV2" };
            def["PharoMn3"] = new string[] { "PharaohMan3", "PharaohMn3", "PharoMan3", "PharaohManV3", "PharaohMnV3", "PharoManV3" };
            def["ShadoMan"] = new string[] { "ShadowMan", "ShadowMn" };
            def["ShadoMnV2"] = new string[] { "ShadowMn2", "ShadoMan2", "ShadowMnV2", "ShadoManV2" };
            def["ShadoMnV3"] = new string[] { "ShadowMn3", "ShadoMan3", "ShadowMnV3", "ShadoManV3" };
            def["MagicMn2"] = new string[] { "MagicMan2", "MagicMnV2", "MagicManV2" };
            def["MagicMn3"] = new string[] { "MagicMan3", "MagicMnV3", "MagicManV3" };
            def["Roll2"] = new string[] { "RollV2" };
            def["Roll3"] = new string[] { "RollV3" };
            def["GutsMan2"] = new string[] { "GutsManV2" };
            def["GutsMan3"] = new string[] { "GutsManV3" };
            def["ProtoMn2"] = new string[] { "ProtoMan2", "ProtoMnV2", "ProtoManV2" };
            def["ProtoMn3"] = new string[] { "ProtoMan3", "ProtoMnV3", "ProtoManV3" };
            def["WoodMan2"] = new string[] { "WoodManV2" };
            def["WoodMan3"] = new string[] { "WoodManV3" };
            def["FireMan2"] = new string[] { "FireManV2" };
            def["FireMan3"] = new string[] { "FireManV3" };
            def["NumbrMan"] = new string[] { "NumberMan", "NumberMn" };
            def["NumbrMn2"] = new string[] { "NumberMan2", "NumberMn2", "NumbrMnV2", "NumberManV2", "NumberMnV2" };
            def["NumbrMn3"] = new string[] { "NumberMan3", "NumberMn3", "NumbrMnV3", "NumberManV3", "NumberMnV3" };
            def["StoneMn2"] = new string[] { "StoneMan2", "StoneMnV2", "StoneManV2" };
            def["StoneMn3"] = new string[] { "StoneMan3", "StoneMnV3", "StoneManV3" };
            def["IceMan2"] = new string[] { "IceManV2" };
            def["IceMan3"] = new string[] { "IceManV3" };
            def["SkullMn2"] = new string[] { "SkullMan2", "SkullMnV2", "SkullManV2" };
            def["SkullMn3"] = new string[] { "SkullMan3", "SkullMnV3", "SkullManV3" };
            def["ColorMn2"] = new string[] { "ColorMan2", "ColorMnV2", "ColorManV2" };
            def["ColorMn3"] = new string[] { "ColorMan3", "ColorMnV3", "ColorManV3" };
            def["BombMan2"] = new string[] { "BombManV2" };
            def["BombMan3"] = new string[] { "BombManV3" };
            def["SharkMn2"] = new string[] { "SharkMan2", "SharkMnV2", "SharkManV2" };
            def["SharkMn3"] = new string[] { "SharkMan3", "SharkMnV3", "SharkManV3" };
            def["ElecMan2"] = new string[] { "ElecManV2" };
            def["ElecMan3"] = new string[] { "ElecManV3" };
            return def;
        } }
        
        public override string[] chipCodes { get { return new string[] {
            "-----", // Buster
            "ABCDE", // Cannon
            "FGHIJ", // HiCannon
            "KLMNO", // M-Cannon
            "BKLPS", // Sword
            "CKMNS", // WideSwrd
            "DENOS", // LongSwrd
            "BDGOT", // LilBomb
            "BDHJL", // CrosBomb
            "BGOST", // BigBomb
            "HIJKL", // Spreader
            "AKLPS", // Bubbler
            "CFGKO", // Heater
            "CEJLP", // MiniBomb
            "KMNQR", // Shotgun
            "CEFJK", // CrossGun
            "CKLNP", // ShokWave
            "CDJMS", // SoniWave
            "CEMSR", // DynaWave
            "EFLMT", // FireTowr
            "ACGHR", // AquaTowr
            "BCHKN", // WoodTowr
            "AEHKQ", // Quake1
            "BCIKQ", // Quake2
            "CDHMQ", // Quake3
            "BFGNP", // FireSwrd
            "EGLOS", // ElecSwrd
            "AMNOP", // AquaSwrd
            "BHMNT", // GutsPnch
            "BHMNT", // IcePunch
            "BKLPS", // FtrSword
            "BDGLO", // Dash
            "BCEGH", // KngtSwrd
            "BDFIJ", // HeroSwrd
            "ACEGL", // MetGuard
            "-----",
            "-----",
            "ABCDE", // TriArrow
            "FGHIJ", // TriSpear
            "KLMNO", // TriLance
            "ABDEG", // Typhoon
            "GIJKL", // Huricane
            "EFGHI", // Cyclone
            "ACGHO", // Howitzer
            "AEGHS", // Thunder1
            "BCFIL", // Thunder2
            "DFGKN", // Thunder3
            "-----",
            "-----",
            "BEGMN", // Snakegg1
            "CEHNP", // Snakegg2
            "ACFLS", // Snakegg3
            "AFIMQ", // Hammer
            "-----",
            "-----",
            "EFKMN", // BodyBurn
            "-----",
            "-----",
            "ABCDE", // Ratton1
            "FGHIJ", // Ratton2
            "KLMNO", // Ratton3
            "CDHIL", // Lockon1
            "BEGHM", // Lockon2
            "ADKNO", // Lockon3
            "BDGLS", // X-Panel1
            "BDGLS", // X-Panel3
            "-----",
            "ACEGL", // Recov10
            "ACEGL", // Recov30
            "ACEGL", // Recov50
            "ACEGL", // Recov80
            "ACEGL", // Recov120
            "ACEGL", // Recov150
            "ACEGL", // Recov200
            "ACEGL", // Recov300
            "-----",
            "AELPS", // Steal
            "-----",
            "-----",
            "FHJLN", // Geddon1
            "ABEIK", // Geddon2
            "-----",
            "FHJLN", // Escape
            "FHJLN", // Interupt
            "AHKMP", // LifeAura
            "DELRS", // AquaAura
            "BGINT", // FireAura
            "CFJOQ", // WoodAura
            "AGHKS", // Repair
            "-----",
            "-----",
            "BGHOR", // Cloud
            "ADIMP", // Cloudier
            "CFJKO", // Cloudest
            "ACILM", // IceCube
            "BEGMO", // RockCube
            "-----",
            "EGJLQ", // TimeBom1
            "CFJLS", // TimeBom2
            "ABGOP", // TimeBom3
            "IJLOQ", // Invis1
            "ACFJM", // Invis2
            "BDHKN", // Invis3
            "CDLQR", // IronBody
            "-----",
            "ACFNO", // Remobit1
            "BDEHI", // Remobit2
            "GJKPQ", // Remobit3
            "AGKNR", // BstrGard
            "DHJOT", // BstrBomb
            "BELPS", // BstrSwrd
            "CFIMQ", // BstrPnch
            "GHMNP", // RingZap1
            "CEGJL", // RingZap2
            "ABORT", // RingZap3
            "CFIPS", // Candle1
            "BEGJL", // Candle2
            "ADHKM", // Candle3
            "HKNOQ", // SloGauge
            "ACELN", // FstGauge
            "-----",
            "ABDKO", // Drain1
            "ACHNT", // Drain2
            "AEFLQ", // Drain3
            "GHMNP", // Mine1
            "CEGJL", // Mine2
            "ABORT", // Mine3
            "CDLOT", // Gaia1
            "CFKPS", // Gaia2
            "CGMRT", // Gaia3
            "CEGIM", // BblWrap1
            "DFHKN", // BblWrap2
            "ABLQR", // BblWrap3
            "ADILM", // Wave
            "BEJNP", // RedWave
            "CHKLQ", // BigWave
            "CEGJK", // Muramasa
            "ABORT", // Dropdown
            "CDHKN", // Popup
            "BGOQS", // Dynamyt1
            "ACKMN", // Dynamyt2
            "GKMOP", // Dynamyt3
            "CLNQT", // Anubis
            "-----",
            "-----",
            "ABORT", // IronShld
            "CDFKQ", // LeafShld
            "DFMRS", // Barrier
            "P----", // PharoMan
            "P----", // PharoMn2
            "P----", // PharoMn3
            "S----", // ShadoMan
            "S----", // ShadoMn2
            "S----", // ShadoMn3
            "-----",
            "-----",
            "-----",
            "M----", // MagicMan
            "M----", // MagicMn2
            "M----", // MagicMn3
            "R----", // Roll
            "R----", // Roll2
            "R----", // Roll3
            "G----", // GutsMan
            "G----", // GutsMan2
            "G----", // GutsMan3
            "B----", // ProtoMan
            "B----", // ProtoMn2
            "B----", // ProtoMn3
            "W----", // WoodMan
            "W----", // WoodMan2
            "W----", // WoodMan3
            "F----", // FireMan
            "F----", // FireMan2
            "F----", // FireMan3
            "N----", // NumbrMan
            "N----", // NumbrMn2
            "N----", // NumbrMn3
            "S----", // StoneMan
            "S----", // StoneMn2
            "S----", // StoneMn3
            "I----", // IceMan
            "I----", // IceMan2
            "I----", // IceMan3
            "S----", // SkullMan
            "S----", // SkullMn2
            "S----", // SkullMn3
            "C----", // ColorMan
            "C----", // ColorMn2
            "C----", // ColorMn3
            "B----", // BombMan
            "B----", // BombMan2
            "B----", // BombMan3
            "S----", // SharkMan
            "S----", // SharkMn2
            "S----", // SharkMn3
            "E----", // ElecMan
            "E----", // ElecMan2
            "E----", // ElecMan3
            "F----", // Bass
        }; } }
        
        public override int[] gameOrderStandardChips { get { return new int[] {
            1, // Cannon
            2, // HiCannon
            3, // M-Cannon
            14, // Shotgun
            15, // CrossGun
            10, // Spreader
            11, // Bubbler
            12, // Heater
            13, // MiniBomb
            7, // LilBomb
            8, // CrosBomb
            9, // BigBomb
            4, // Sword
            5, // WideSwrd
            6, // LongSwrd
            30, // FtrSword
            32, // KngtSwrd
            33, // HeroSwrd
            25, // FireSwrd
            27, // AquaSwrd
            26, // ElecSwrd
            136, // Muramasa
            16, // ShokWave
            17, // SoniWave
            18, // DynaWave
            19, // FireTowr
            20, // AquaTowr
            21, // WoodTowr
            22, // Quake1
            23, // Quake2
            24, // Quake3
            28, // GutsPnch
            29, // IcePunch
            31, // Dash
            43, // Howitzer
            37, // TriArrow
            38, // TriSpear
            39, // TriLance
            58, // Ratton1
            59, // Ratton2
            60, // Ratton3
            133, // Wave
            134, // RedWave
            135, // BigWave
            127, // Gaia1
            128, // Gaia2
            129, // Gaia3
            44, // Thunder1
            45, // Thunder2
            46, // Thunder3
            112, // RingZap1
            113, // RingZap2
            114, // RingZap3
            40, // Typhoon
            41, // Huricane
            42, // Cyclone
            49, // Snakegg1
            50, // Snakegg2
            51, // Snakegg3
            121, // Drain1
            122, // Drain2
            123, // Drain3
            55, // BodyBurn
            64, // X-Panel1
            65, // X-Panel3
            52, // Hammer
            34, // MetGuard
            145, // IronShld
            67, // Recov10
            68, // Recov30
            69, // Recov50
            70, // Recov80
            71, // Recov120
            72, // Recov150
            73, // Recov200
            74, // Recov300
            76, // Steal
            79, // Geddon1
            80, // Geddon2
            82, // Escape
            83, // Interupt
            88, // Repair
            97, // TimeBom1
            98, // TimeBom2
            99, // TimeBom3
            91, // Cloud
            92, // Cloudier
            93, // Cloudest
            124, // Mine1
            125, // Mine2
            126, // Mine3
            139, // Dynamyt1
            140, // Dynamyt2
            141, // Dynamyt3
            105, // Remobit1
            106, // Remobit2
            107, // Remobit3
            61, // Lockon1
            62, // Lockon2
            63, // Lockon3
            115, // Candle1
            116, // Candle2
            117, // Candle3
            142, // Anubis
            94, // IceCube
            95, // RockCube
            108, // BstrGard
            109, // BstrBomb
            110, // BstrSwrd
            111, // BstrPnch
            118, // SloGauge
            119, // FstGauge
            100, // Invis1
            101, // Invis2
            102, // Invis3
            137, // Dropdown
            138, // Popup
            103, // IronBody
            147, // Barrier
            130, // BblWrap1
            131, // BblWrap2
            132, // BblWrap3
            146, // LeafShld
            85, // AquaAura
            86, // FireAura
            87, // WoodAura
            84, // LifeAura
            160, // Roll
            161, // Roll2
            162, // Roll3
            163, // GutsMan
            164, // GutsMan2
            165, // GutsMan3
            166, // ProtoMan
            167, // ProtoMn2
            168, // ProtoMn3
            172, // FireMan
            173, // FireMan2
            174, // FireMan3
            175, // NumbrMan
            176, // NumbrMn2
            177, // NumbrMn3
            178, // StoneMan
            179, // StoneMn2
            180, // StoneMn3
            181, // IceMan
            182, // IceMan2
            183, // IceMan3
            187, // ColorMan
            188, // ColorMn2
            189, // ColorMn3
            196, // ElecMan
            197, // ElecMan2
            198, // ElecMan3
            190, // BombMan
            191, // BombMan2
            192, // BombMan3
            157, // MagicMan
            158, // MagicMn2
            159, // MagicMn3
            169, // WoodMan
            170, // WoodMan2
            171, // WoodMan3
            184, // SkullMan
            185, // SkullMn2
            186, // SkullMn3
            193, // SharkMan
            194, // SharkMn2
            195, // SharkMn3
            148, // PharoMan
            149, // PharoMn2
            150, // PharoMn3
            151, // ShadoMan
            152, // ShadoMn2
            153, // ShadoMn3
            199 // Bass
        }; } }
        
        public override string[] keyItemNames { get { return new string[] {
            "PET", "IceBlock", "WaterGun", "SchoolID", "SciLabID", "Handle", "Message", "Response", "WWW PIN", "BatteryA",
            "BatteryB", "BatteryC", "BatteryD", "BatteryE", "Charger", "WWW Pass", "", "Dentures", "", "",
            "", "", "", "", "", "", "", "", "", "",
            "", "", "", "@Mayl", "@Yai", "@Dex", "", "@Dad", "@Sal", "",
            "@Miyu", "", "", "@Masa", "", "@WWW", "", "", "/Dex", "/Sal",
            "/Miyu", "", "Hig Memo", "Lab Memo", "YuriMemo", "Pa'sMemo", "", "", "", "",
            "ACDCPass", "GovtPass", "TownPass", "", "HPMemory", "PowerUP", "", "", "HeatArmr", "AquaArmr",
            "WoodArmr"
        }; } } // Includes upgrade items for things that use IDs relative to start of key items
        
        public override string[] upgradeItemNames { get { return new string[] {
            "HPMemory", "PowerUP"
        }; } }
        
        public override int[][] upgradeItemFlags { get {
            int[][] flags = new int[upgradeItemNames.Length][];
            // HPMemory
            flags[0] = new int[] { -583 /* "Sorry Lan" email from Dad */, 684, 696, 728, 740, 741, 758, 764, 794, 847, 851, 855, 862, 1107 };
            // PowerUP
            flags[1] = new int[] { -583 /* "Sorry Lan" email from Dad */, 701, 731, 818, 864 };
            return flags;
        } }
        
        public override int[][] shopInventoryAddresses { get { return new int[][] {
            new int[] { 0x90, 0x10F0 }, // Higsby's
            new int[] { 0x410, 0x1178 }, // Internet 1 NetDealer
            new int[] { 0x340, 0x1200 }, // Internet 3 NetDealer
            new int[] { 0x21F0, 0x1288 }, // Internet 4 NetDealer
            new int[] { 0x130, 0x1310 }, // Undernet 1 NetDealer
            new int[] { 0x2280, 0x1398 }, // Undernet 6 NetDealer
            new int[] { 0x2160, 0x1420 }, // Undernet 8 NetDealer
            new int[] { 0x1FE0, 0x14A8 } // Undernet 11 NetDealer
        }; } }
        
        public override Dictionary<int, int[]> shopHPMemoryPrices { get {
            Dictionary<int, int[]> def = new Dictionary<int, int[]>();
            def[1] = new int[] { 500, 1000, 2000, 3000, 5000 }; // Internet 1 NetDealer
            def[2] = new int[] { 4000, 6000, 9000, 12000, 15000 }; // Internet 3 NetDealer
            def[3] = new int[] { 6000, 8000, 10000, 12000, 15000 }; // Internet 4 NetDealer
            def[4] = new int[] { 8000, 10000, 12000, 15000 }; // Undernet 1 NetDealer
            def[5] = new int[] { 12000, 15000, 20000, 25000 }; // Undernet 6 NetDealer
            def[6] = new int[] { 12000, 15000, 20000, 25000 }; // Undernet 8 NetDealer
            def[7] = new int[] { 15000, 20000, 25000, 40000 }; // Undernet 11 NetDealer
            return def;
        } }
        
        public override Dictionary<int, int[]> shopPowerUpPrices { get {
            Dictionary<int, int[]> def = new Dictionary<int, int[]>();
            def[1] = new int[] { 2000, 5000 }; // Internet 1 NetDealer
            def[4] = new int[] { 20000 }; // Undernet 1 NetDealer
            def[5] = new int[] { 25000 }; // Undernet 6 NetDealer
            def[6] = new int[] { 25000, 50000 }; // Undernet 8 NetDealer
            def[7] = new int[] { 100000 }; // Undernet 11 NetDealer
            return def;
        } }
        
        public override Dictionary<int, int[]> shopKeyItemPrices { get {
            Dictionary<int, int[]> def = new Dictionary<int, int[]>();
            def[2] = new int[] { 70, 15000 }; // WoodArmr at Internet 3 NetDealer
            def[3] = new int[] { 68, 20000 }; // HeatArmr at Internet 4 NetDealer
            def[5] = new int[] { 69, 30000 }; // AquaArmr at Undernet 6 NetDealer
            return def;
        } }
        
        public override int[][] libraryFlagRanges { get { return new int[][] {
            new int[] { 256, 455 }, null, null, null // Chips, no PA tracking, no library sharing
        }; } }
        
        public override Dictionary<string, string[]> presetFolders { get {
            Dictionary<string, string[]> def = new Dictionary<string, string[]>();
            def["Fldr1"] = new string[] {
                "Cannon A", "Cannon A", "Cannon B", "Cannon B", "Shotgun N", "Shotgun N", "Shotgun N", "Shotgun N", "CrossGun J", "CrossGun J",
                "CrossGun J", "CrossGun J", "MiniBomb C", "MiniBomb C", "MiniBomb L", "MiniBomb L", "Sword S", "Sword S", "Sword S", "Sword S",
                "WideSwrd S", "X-Panel1 L", "X-Panel1 L", "Recov10 A", "Recov10 A", "Recov10 A", "Recov10 L", "Recov10 L", "Steal S", "Escape F"
            };
            return def;
        } }
        
        public override object[] safeLocationLansRoom { get { return new object[] { 0x01, 0x03, 0, 48, 0, 0x01 }; } }
        public override object[] startLocationForFreshSave { get { return new object[] { 0x01, 0x03, 0, 48, 0, 0x04 }; } }
        public override object[] uninitializedJackInLocation { get { return new object[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }; } } // Fully uninitialized, will crash
        
        public override int[] getGameStartFlags(char version = 'M')
        {
            List<int> flags = new List<int>();
            
            flags.Add(144);
            flags.Add(257);
            for (int i = 260; i <= 261; i++)
                flags.Add(i);
            for (int i = 269; i <= 271; i++)
                flags.Add(i);
            flags.Add(320);
            flags.Add(323);
            flags.Add(332);
            flags.Add(338);
            for (int i = 512; i <= 513; i++)
                flags.Add(i);
            for (int i = 576; i <= 577; i++) // Emails unread
                flags.Add(i);
            flags.Add(640);
            flags.Add(1024); // Enable movement
            flags.Add(1028); // PET menu open
            flags.Add(1033);
            
            return flags.ToArray();
        }
        
        public override ShopItem[][] getInitialShopInventories(char version = 'M')
        {
            ShopItem[][] shops = new ShopItem[8][];
            
            shops[0] = new ShopItem[] {
                new ShopItem(0x00, 0x01, 0x04, 1000, 3), new ShopItem(0x00, 0x0A, 0x0A, 1000, 3),
                new ShopItem(0x00, 0x46, 0x04, 3000, 3), new ShopItem(0x00, 0x41, 0x0B, 3000, 3),
                new ShopItem(0x00, 0x58, 0x06, 3000, 3), new ShopItem(0x00, 0x93, 0x05, 3000, 3),
                new ShopItem(0x00, 0x1A, 0x04, 5000, 3), new ShopItem(0x00, 0x4C, 0x0B, 5000, 3),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255)
            };
            shops[1] = new ShopItem[] {
                new ShopItem(0x01, 0x40, 0x00, 500, 1), new ShopItem(0x01, 0x41, 0x00, 2000, 1),
                new ShopItem(0x00, 0x05, 0x0A, 1000, 3), new ShopItem(0x00, 0x0A, 0x08, 1000, 3),
                new ShopItem(0x00, 0x34, 0x00, 2000, 3), new ShopItem(0x00, 0x45, 0x02, 2000, 3),
                new ShopItem(0x00, 0x01, 0x02, 3000, 3), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255)
            };
            shops[2] = new ShopItem[] {
                new ShopItem(0x01, 0x40, 0x00, 4000, 1), new ShopItem(0x01, 0x46, 0x00, 15000, 1),
                new ShopItem(0x00, 0x05, 0x12, 3000, 3), new ShopItem(0x00, 0x34, 0x08, 3000, 3),
                new ShopItem(0x00, 0x41, 0x06, 3000, 3), new ShopItem(0x00, 0x03, 0x0B, 10000, 3),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255)
            };
            shops[3] = new ShopItem[] {
                new ShopItem(0x01, 0x40, 0x00, 6000, 1), new ShopItem(0x01, 0x44, 0x00, 20000, 1),
                new ShopItem(0x00, 0x5E, 0x08, 3000, 3), new ShopItem(0x00, 0x5C, 0x00, 5000, 3),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255)
            };
            shops[4] = new ShopItem[] {
                new ShopItem(0x01, 0x40, 0x00, 8000, 1), new ShopItem(0x01, 0x41, 0x00, 20000, 1),
                new ShopItem(0x00, 0x40, 0x12, 1000, 3), new ShopItem(0x00, 0x64, 0x10, 5000, 3),
                new ShopItem(0x00, 0x62, 0x12, 8000, 3), new ShopItem(0x00, 0x26, 0x09, 10000, 3),
                new ShopItem(0x00, 0x48, 0x02, 10000, 3), new ShopItem(0x00, 0x3B, 0x06, 10000, 3),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255)
            };
            shops[5] = new ShopItem[] {
                new ShopItem(0x01, 0x40, 0x00, 12000, 1), new ShopItem(0x01, 0x41, 0x00, 25000, 1),
                new ShopItem(0x01, 0x45, 0x00, 30000, 1), new ShopItem(0x00, 0x06, 0x04, 5000, 3),
                new ShopItem(0x00, 0x03, 0x0B, 10000, 3), new ShopItem(0x00, 0x4C, 0x00, 10000, 3),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255)
            };
            shops[6] = new ShopItem[] {
                new ShopItem(0x01, 0x40, 0x00, 12000, 1), new ShopItem(0x01, 0x41, 0x00, 25000, 1),
                new ShopItem(0x00, 0x1D, 0x0C, 5000, 3), new ShopItem(0x00, 0x4F, 0x0B, 5000, 3),
                new ShopItem(0x00, 0x50, 0x00, 8000, 3), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255)
            };
            shops[7] = new ShopItem[] {
                new ShopItem(0x01, 0x40, 0x00, 15000, 1), new ShopItem(0x01, 0x41, 0x00, 100000, 1),
                new ShopItem(0x00, 0x1F, 0x06, 3000, 3), new ShopItem(0x00, 0x58, 0x06, 3000, 3),
                new ShopItem(0x00, 0x85, 0x00, 10000, 3), new ShopItem(0x00, 0x84, 0x11, 10000, 3),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255),
                new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255), new ShopItem(0xFF, 0xFF, 0xFF, 0xFFFFFFFF, 255)
            };
            
            return shops;
        }
        
        public override int saveAreaLengthGBA {get { return 0x2308; } }
        public override int saveFileSizeLC {get { return 0x22CD; } }
        
        public override string getSubareaName(int area, int subarea, bool returnArea = false, bool fallbackIfNotFound = false)
        {
            switch (area)
            {
                case 0x00:
                    if (returnArea)
                        return "ACDC School";
                    switch (subarea)
                    {
                        case 0x00: return "Class 5-A";
                        case 0x01: return "Class 5-B";
                        case 0x02: return "Library";
                        case 0x03: return "5th Grade Class Hall";
                        //case 0x04: return "N/A";
                        case 0x05: return "Class 1-A";
                        case 0x06: return "Class 1-B";
                        case 0x07: return "AV Room";
                        case 0x08: return "Infirmary";
                        case 0x09: return "1st Grade Class Hall";
                        //case 0x0A: return "N/A";
                        case 0x0B: return "Cross Hall";
                        case 0x0C: return "Storage Room";
                        case 0x0D: return "Staff Lounge";
                        case 0x0E: return "Lounge Hall";
                        //case 0x0F: return "False ACDC Town";
                    }
                    break;
                
                case 0x01:
                    if (returnArea)
                        return "ACDC Town";
                    switch (subarea)
                    {
                        case 0x00: return "ACDC Town";
                        case 0x01: return "School Entrance";
                        case 0x02: return "Lan's House";
                        case 0x03: return "Lan's Room";
                        //case 0x04: return "N/A";
                        case 0x05: return "Mayl's House";
                        case 0x06: return "Mayl's Room";
                        case 0x07: return "Dex's Room";
                        //case 0x08: return "N/A";
                        case 0x09: return "Yai's Room";
                        //case 0x0A: return "N/A";
                        case 0x0B: return "Higsby's";
                        case 0x0C: return "Metroline";
                        case 0x0D: return "Secret Metroline";
                    }
                    break;
                
                case 0x02:
                    if (returnArea)
                        return "Government Complex";
                    switch (subarea)
                    {
                        case 0x00: return "Outside Complex";
                        case 0x01: return "Metroline";
                        case 0x02: return "Waterworks Lobby";
                        case 0x03: return "SciLab Lobby";
                        case 0x04: return "Waterworks-SciLab Hallway";
                        case 0x05: return "Dad's Lab";
                        case 0x06: return "Waterworks Elevator Hall";
                        case 0x07: return "Waterworks Control Room";
                        //case 0x08: return "N/A";
                        case 0x09: return "Waterworks Pump Room";
                        //case 0x0A: return "N/A";
                        case 0x0B: return "Waterworks Filter Room";
                    }
                    break;
                
                case 0x03:
                    if (returnArea)
                        return "Dentown";
                    switch (subarea)
                    {
                        case 0x00: return "Central Block";
                        case 0x01: return "Metroline";
                        case 0x02: return "Northwest Block";
                        case 0x03: return "Northeast Block";
                        case 0x04: return "Southeast Block";
                        case 0x05: return "Southwest Block";
                        case 0x06: return "Antique Shop";
                        case 0x07: return "Summer School";
                    }
                    break;
                
                case 0x04:
                    if (returnArea)
                        return "Restaurant & Power Plant";
                    switch (subarea)
                    {
                        case 0x00: return "Restaurant Elevator Hall";
                        case 0x01: return "Restaurant";
                        case 0x02: return "Power Plant Elevator Hall";
                        case 0x03: return "Power Plant Entrance Hall";
                        case 0x04: return "Power Plant Control Room";
                        case 0x05: return "Generator Room";
                    }
                    break;
                
                case 0x05:
                    if (returnArea)
                        return "WWW Base";
                    switch (subarea)
                    {
                        case 0x00: return "WWW Base Outside";
                        case 0x01: return "Control Center";
                        case 0x02: return "Rocket Room";
                        case 0x03: return "1F-2F Hallway";
                        case 0x04: return "2F-3F Hallway";
                        case 0x05: return "3F-4F Hallway";
                    }
                    break;
                
                case 0x80:
                    if (returnArea)
                        return "School Comp";
                    switch (subarea)
                    {
                        case 0x00: return "School Comp 1";
                        case 0x01: return "School Comp 2";
                        case 0x02: return "School Comp 3";
                        case 0x03: return "School Comp 4";
                        case 0x04: return "School Comp 5";
                    }
                    break;
                
                // oven comp
                
                case 0x82:
                    if (returnArea)
                        return "Waterworks Comp";
                    switch (subarea)
                    {
                        case 0x00: return "Waterworks Comp 1";
                        case 0x01: return "Waterworks Comp 2";
                        case 0x02: return "Waterworks Comp 3";
                        case 0x03: return "Waterworks Comp 4";
                        case 0x04: return "Waterworks Comp 5";
                        case 0x05: return "Waterworks Comp 6";
                    }
                    break;
                
                case 0x83:
                    if (returnArea)
                        return "Traffic Comp";
                    switch (subarea)
                    {
                        case 0x00: return "Traffic Comp 1";
                        case 0x01: return "Traffic Comp 2";
                        case 0x02: return "Traffic Comp 3";
                        case 0x03: return "Traffic Comp 4";
                        case 0x04: return "Traffic Comp 5";
                    }
                    break;
                
                case 0x84:
                    if (returnArea)
                        return "Power Plant Comp";
                    switch (subarea)
                    {
                        case 0x00: return "Power Plant Comp 1";
                        case 0x01: return "Power Plant Comp 2";
                        case 0x02: return "Power Plant Comp 3";
                        case 0x03: return "Power Plant Comp 4";
                    }
                    break;
                
                case 0x85:
                    if (returnArea)
                        return "WWW Comp";
                    switch (subarea)
                    {
                        case 0x00: return "WWW Comp 1";
                        case 0x01: return "WWW Comp 2";
                        case 0x02: return "WWW Comp 3";
                        case 0x03: return "WWW Comp 4";
                        case 0x04: return "WWW Comp 5";
                        case 0x05: return "Rocket Comp";
                    }
                    break;
                
                case 0x88:
                    if (returnArea)
                        return "ACDC HPs";
                    switch (subarea)
                    {
                        case 0x00: return "Lan's HP";
                        case 0x01: return "Mayl's HP (Piano Comp)";
                        case 0x02: return "Yai's HP (Portrait Comp)";
                        case 0x03: return "Dex's HP";
                    }
                    break;
                
                case 0x89:
                    if (returnArea)
                        return "Government Complex HPs";
                    switch (subarea)
                    {
                        case 0x00: return "Dad's PC";
                        case 0x01: return "Sal's HP (Lunch Stand Comp)";
                    }
                    break;
                
                case 0x8B:
                    if (returnArea)
                        return "Masa's HP";
                    switch (subarea)
                    {
                        case 0x00: return "Masa's HP (Fish Stand Comp)";
                    }
                    break;
                
                case 0x8C:
                    if (returnArea)
                        return "Cyberworlds";
                    switch (subarea)
                    {
                        case 0x00: return "Doghouse Comp";
                        case 0x01: return "Servbot Comp";
                        case 0x02: return "Game Console Comp";
                        case 0x03: return "Telephone Comp";
                        case 0x04: return "Car Comp";
                        case 0x05: return "Waterworks Vending Machine Comp";
                        case 0x06: return "TV Comp";
                        case 0x07: return "Large Monitor Comp";
                        case 0x08: return "Waterworks Control Panel Comp";
                        case 0x09: return "SciLab Vending Machine Comp";
                        case 0x0A: return "Recycled PET Comp";
                        case 0x0B: return "Big Vase Comp";
                        case 0x0C: return "Summer School Blackboard Comp";
                    }
                    break;
                
                case 0x90:
                    if (returnArea)
                        return "Internet";
                    switch (subarea)
                    {
                        case 0x00: return "Internet 1";
                        case 0x01: return "Internet 2";
                        case 0x02: return "Internet 3";
                        case 0x03: return "Internet 4";
                        case 0x04: return "Internet 5 (Undernet 1)";
                        case 0x05: return "Internet 6 (Undernet 2)";
                        case 0x06: return "Internet 7 (Undernet 3)";
                        case 0x07: return "Internet 8 (Undernet 4)";
                        case 0x08: return "Internet 9 (Undernet 5)";
                        case 0x09: return "Internet 10 (Undernet 6)";
                        case 0x0A: return "Internet 11 (Undernet 7)";
                        case 0x0B: return "Internet 12 (Undernet 8)";
                        case 0x0C: return "Internet 13 (Undernet 9)";
                        case 0x0D: return "Internet 14 (Undernet 10)";
                        case 0x0E: return "Internet 15 (Undernet 11)";
                        case 0x0F: return "Internet 16 (Undernet 12)";
                    }
                    break;
            }
            
            return fallbackIfNotFound? "[" + (returnArea? area : subarea).ToString("X2") + "]" : "";
        }
        
        public override string getMusicName(int music, bool fallbackIfNotFound = false)
        {
            switch (music)
            {
                case 0x00: return "None";
                case 0x01: return "ACDC Town";
                case 0x02: return "Inside House";
                case 0x03: return "Suspicious Mood";
                case 0x04: return "Incident Occurrence!";
                case 0x05: return "Transmission!";
                case 0x06: return "Oven Comp (Fire Field)";
                case 0x07: return "School Comp (Running Through the Cyber World)";
                case 0x08: return "Internet (Boundless Network)";
                case 0x09: return "Hour of Fate";
                case 0x0A: return "Waterworks Comp (Cold & Silent)";
                case 0x0B: return "Traffic Comp (Red or Blue)";
                case 0x0C: return "Power Plant Comp (Electrical Crisis)";
                case 0x0D: return "WWW Comp (Void)";
                case 0x0E: return "Virus Battle (Operation!)";
                case 0x0F: return "Boss Battle";
                case 0x10: return "VS Life Virus";
                case 0x11: return "Victory!";
                case 0x12: return "Game Over";
                case 0x13: return "Credits";
                case 0x14: return "ACDC School";
                case 0x15: return "Loser";
            }
            
            return fallbackIfNotFound? "[" + music.ToString("X2") + "]" : "";
        }
        
        public override string getStyleName(int armor, bool fallbackIfNotFound = false, bool includeLevel = false)
        {
            switch (armor)
            {
                case 0x00: return "Normal Armor";
                case 0x02: return "HeatArmr";
                case 0x03: return "AquaArmr";
                case 0x04: return "WoodArmr";
            }
            return fallbackIfNotFound? "Armor #" + armor : "";
        }
        
        public override string getEmailName(int email, bool fallbackIfNotFound = false)
        {
            switch (email)
            {
                case 0: return "WWW Crime! (NetNews)";
                case 1: return "Sorry! (Dad)";
                case 2: return "PowerUp! (Dad)";
                case 3: return "Student Crime (NetNews)";
                case 4: return "Roll call (Yai)";
                case 5: return "A challenge! (Dex)";
                case 6: return "No Water! (NetNews)";
                case 7: return "Sorry Lan (Dad)";
                case 8: return "Kidnapped! (Yai)";
                case 9: return "Yai's present (Mayl)";
                case 10: return "New Metroline (NetNews)";
                case 11: return "Meeting place (Mayl)";
                case 12: return "Accidents? (Your WWW)";
                case 13: return "What to do?! (Mayl)";
                case 14: return "About Chaud (Dad)";
                case 15: return "Net address (Mayl)";
                case 16: return "Old friend (Higsby)";
                case 17: return "Lab location (Dad)";
                case 18: return "For you... (Froid)";
                case 19: return "Official ML (Froid)";
                case 20: return "Water virus (BattleML)";
                case 21: return "Re: Virus (BattleML)";
                case 22: return "Mystery op? (BattleML)";
                case 23: return "Advances (BattleML)";
                case 24: return "Aura virus? (BattleML)";
                case 25: return "Aura, cont. (BattleML)";
                case 26: return "Re: Aura, cont. (BattleML)";
                case 27: return "Rare chips! (BattleML)";
                case 28: return "The truth! (Yai)";
                case 29: return "Dinner? (Dad)";
                case 30: return "R U OK? (Dad)";
                case 31: return "The LifeVirus (BattleML)";
                case 32: return "Class notes (Ms. Mari)";
            }
            
            return fallbackIfNotFound? "Email #" + email : "";
        }
        
        public override string getShopName(int shop, bool fallbackIfNotFound = false)
        {
            switch (shop)
            {
                case 0: return "Higsby's";
                case 1: return "Internet 1 NetDealer";
                case 2: return "Internet 3 NetDealer";
                case 3: return "Internet 4 NetDealer";
                case 4: return "Internet 5 (Undernet 1) NetDealer";
                case 5: return "Internet 10 (Undernet 6) NetDealer";
                case 6: return "Internet 12 (Undernet 8) NetDealer";
                case 7: return "Internet 15 (Undernet 11) NetDealer";
            }
            
            return fallbackIfNotFound? "Shop #" + (shop + 1) : "";
        }
        
        public override string getChapterDesc(int chapter)
        {
            switch (chapter)
            {
                case 0: return "Start of game";
                
                case 65: return "After restaurant blackout";
                case 66: return "After power plant control room door opens";
                
                case 84: return "After finding secret Metroline (endgame)";
            }
            return "";
        }
        
        public override string getFlagDesc(int flag)
        {
            if (flag >= 0 && flag <= 32) // Emails
                return "Email: " + getEmailName(flag, true);
            else if (flag >= 256 && flag <= 455) // Library chip flags
            {
                string chipName = getChipName(flag - 256, false);
                if (chipName == "")
                    chipName = "(UNUSED)";
                return "Library chip flag: " + chipName;
            }
            else if (flag >= 576 && flag <= 608) // Emails unread
                return "Email unread: " + getEmailName(flag - 576, true);
            
            switch (flag)
            {
                // 0-32: Emails
                
                case 42: return "Metroline ticket bought";
                
                case 161: return "Multi-use story progression flag";
                case 162: return "Multi-use story progression flag";
                case 163: return "Multi-use story progression flag";
                case 164: return "Multi-use story progression flag";
                case 165: return "Multi-use story progression flag";
                case 166: return "Multi-use story progression flag";
                case 167: return "Multi-use story progression flag";
                case 168: return "Multi-use story progression flag";
                case 169: return "Multi-use story progression flag";
                case 170: return "Multi-use story progression flag";
                case 171: return "Multi-use story progression flag";
                case 172: return "Multi-use story progression flag";
                case 173: return "Multi-use story progression flag";
                case 174: return "Multi-use story progression flag";
                case 175: return "Multi-use story progression flag";
                case 176: return "Multi-use story progression flag";
                case 177: return "Stopped by scientist in Power Plant Control Room";
                
                // 256-455: Library chip flags
                
                // 576-608: Emails unread
                
                case 684: return "BMD: School Comp 3 HPMemory";
                case 696: return "BMD: Waterworks Comp 2 HPMemory";
                case 701: return "BMD: Waterworks Comp 5 PowerUP";
                case 728: return "BMD: Traffic Comp 4 HPMemory";
                //case 730: return "BMD: Internet 2 PowerUP (unused)";
                case 731: return "BMD: Internet 2 PowerUP";
                
                case 740: return "School Storage Room shelf HPMemory";
                case 741: return "Waterworks Control Room lockers HPMemory";
                
                case 758: return "BMD: Internet 4 HPMemory";
                case 764: return "BMD: Internet 5 HPMemory";
                case 794: return "BMD: Internet 10 HPMemory";
                case 818: return "BMD: Internet 14 PowerUP";
                
                case 847: return "BMD: WWW Comp 4 HPMemory";
                case 851: return "BMD: Toy Comp HPMemory";
                case 855: return "BMD: Car Comp HPMemory";
                case 862: return "BMD: Recycled PET Comp HPMemory";
                case 864: return "BMD: Summer School Blackboard PowerUP";
                
                case 1024: return "Show mugshot in textbox, locks movement if false";
                case 1026: return "MegaMan in Cyberworld";
                case 1028: return "PET menu open";
                
                case 1107: return "Beat Masa for HPMemory";
            }
            return "";
        }
    }
}
