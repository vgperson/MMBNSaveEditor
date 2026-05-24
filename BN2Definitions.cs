using System.Collections.Generic;

namespace MMBNSaveEditor
{
    /// <summary>An object that returns definitions for Battle Network 2.</summary>
    class BN2Definitions : BNDefinitions
    {
        public override string[] chipNames { get { return new string[] {
            "MegaBstr", "Cannon", "HiCannon", "M-Cannon", "Shotgun", "V-Gun", "CrossGun", "Spreader", "Bubbler", "Bub-V",
            "BubCross", "BubSprd", "HeatShot", "Heat-V", "HeatCros", "HeatSprd", "MiniBomb", "LilBomb", "CrosBomb", "BigBomb",
            "TreeBom1", "TreeBom2", "TreeBom3", "Sword", "WideSwrd", "LongSwrd", "FireSwrd", "AquaSwrd", "ElecSwrd", "FireBlde",
            "AquaBlde", "ElecBlde", "StepSwrd", "Muramasa", "CustSwrd", "Kunai1", "Kunai2", "Kunai3", "Slasher", "Shockwav",
            "Sonicwav", "Dynawave", "Quake1", "Quake2", "Quake3", "GutPunch", "ColdPnch", "Atk+20", "Atk+30", "Navi+40",
            "DashAtk", "Wrecker", "CannBall", "DoubNdl", "TripNdl", "QuadNdl", "Trident", "Ratton1", "Ratton2", "Ratton3",
            "FireRat", "Tornado", "Twister", "Blower", "Burner", "ZapRing1", "ZapRing2", "ZapRing3", "Spice1", "Spice2",
            "Spice3", "Satelit1", "Satelit2", "Satelit3", "Yo-Yo1", "Yo-Yo2", "Yo-Yo3", "MagBomb1", "MagBomb2", "MagBomb3",
            "Meteor9", "Meteor12", "Meteor15", "Meteor18", "Hammer", "CrsShld1", "CrsShld2", "CrsShld3", "TimeBom1", "TimeBom2",
            "TimeBom3", "LilCloud", "MedCloud", "BigCloud", "Mine", "FrntSnsr", "DblSnsr", "Remobit1", "Remobit2", "Remobit3",
            "AquaBall", "ElecBall", "HeatBall", "Geyser", "LavaDrag", "GodStone", "OldWood", "PoisMask", "PoisFace", "Whirlpl",
            "Blckhole", "Guard", "Barrier", "PanlOut1", "PanlOut3", "LineOut", "Lance", "ZeusHamr", "BrnzFist", "SilvFist",
            "GoldFist", "VarSwrd", "Recov10", "Recov30", "Recov50", "Recov80", "Recov120", "Recov150", "Recov200", "Recov300",
            "PanlGrab", "AreaGrab", "GrabRvng", "Geddon1", "Geddon2", "Geddon3", "Catcher", "Mindbndr", "Escape", "AirShoes",
            "Repair", "Candle1", "Candle2", "Candle3", "RockCube", "Prism", "Guardian", "Wind", "Fan", "Anubis",
            "SloGauge", "FstGauge", "FullCust", "Invis1", "Invis2", "Invis3", "DropDown", "PopUp", "StoneBod", "Shadow1",
            "Shadow2", "Shadow3", "UnderSht", "BblWrap", "LeafShld", "AquaAura", "FireAura", "WoodAura", "ElecAura", "LifeAur1",
            "LifeAur2", "LifeAur3", "MagLine", "LavaLine", "IceLine", "GrassLne", "LavaStge", "IceStage", "GrassStg", "HolyPanl",
            "Jealousy", "AntiFire", "AntiElec", "AntiWatr", "AntiDmg", "AntiSwrd", "AntiNavi", "AntiRecv", "Atk+10", "Fire+40",
            "Aqua+40", "Wood+40", "Elec+40", "Navi+20", "Roll", "RollV2", "RollV3", "GutsMan", "GutsManV2", "GutsManV3",
            "ProtoMan", "ProtoMnV2", "ProtoMnV3", "AirMan", "AirManV2", "AirManV3", "QuickMan", "QuickMnV2", "QuickMnV3", "CutMan",
            "CutManV2", "CutManV3", "ShadoMan", "ShadoMnV2", "ShadoMnV3", "KnightMn", "KnghtMnV2", "KnghtMnV3", "MagnetMn", "MagntMnV2",
            "MagntMnV3", "FreezeMn", "FrzManV2", "FrzManV3", "HeatMan", "HeatManV2", "HeatManV3", "ToadMan", "ToadManV2", "ToadManV3",
            "ThunMan", "ThunManV2", "ThunManV3", "SnakeMan", "SnakeMnV2", "SnakeMnV3", "GateMan", "GateManV2", "GateManV3", "PlanetMn",
            "PlnetMnV2", "PlnetMnV3", "NapalmMn", "NaplmMnV2", "NaplmMnV3", "PharoMan", "PharoMnV2", "PharoMnV3", "Bass", "BassV2",
            "BassV3", "BgRedWav", "FreezBom", "Sparker", "GaiaSwrd", "BlkBomb", "FtrSword", "KngtSwrd", "HeroSwrd", "Meteors",
            "Poltrgst", "FireGspl", "AquaGspl", "ElecGspl", "WoodGspl", "GateSP", "", "", "", "",
            "Snctuary"
        }; } }
        
        public override string[] paNames { get { return new string[] {
            "Z-Canon1", "Z-Canon2", "Z-Canon3", "H-Burst", "Z-Ball", "Z-Raton1", "Z-Raton2", "Z-Raton3", "O-Canon1", "O-Canon2",
            "O-Canon3", "M-Burst", "O-Ball", "O-Raton1", "O-Raton2", "O-Raton3", "Arrows", "UltraBmb", "LifeSrd1", "LifeSrd2",
            "LifeSrd3", "Punch", "Curse", "TimeBom+", "HvyStamp", "PoisPhar", "Gater", "GtsShoot", "BigHeart", "BodyGrd",
            "2xHero", "Darkness"
        }; } }
        
        public override Dictionary<string, string[]> chipAliases { get {
            Dictionary<string, string[]> def = new Dictionary<string, string[]>();
            def["Jealousy"] = new string[] { "Jealosy" };
            def["Snctuary"] = new string[] { "Sanctuary" };
            def["ProtoMnV2"] = new string[] { "ProtoManV2" };
            def["ProtoMnV3"] = new string[] { "ProtoManV3" };
            def["QuickMnV2"] = new string[] { "QuickManV2" };
            def["QuickMnV3"] = new string[] { "QuickManV3" };
            def["ShadoMan"] = new string[] { "ShadowMan", "ShadowMn" };
            def["ShadoMnV2"] = new string[] { "ShadowMnV2", "ShadoManV2" };
            def["ShadoMnV3"] = new string[] { "ShadowMnV3", "ShadoManV3" };
            def["KnightMn"] = new string[] { "KnightMan" };
            def["KnghtMnV2"] = new string[] { "KnightMnV2", "KnightManV2", "KnghtManV2" };
            def["KnghtMnV3"] = new string[] { "KnightMnV3", "KnightManV3", "KnghtManV3" };
            def["MagnetMn"] = new string[] { "MagnetMan", "MagntMan" };
            def["MagntMnV2"] = new string[] { "MagnetManV2", "MagnetMnV2" };
            def["MagntMnV3"] = new string[] { "MagnetManV3", "MagnetMnV3" };
            def["FreezeMn"] = new string[] { "FreezeMan" };
            def["FrzManV2"] = new string[] { "FreezeManV2", "FreezManV2", "FreezeMnV2", "FreezMnV2" };
            def["FrzManV3"] = new string[] { "FreezeManV3", "FreezManV3", "FreezeMnV3", "FreezMnV3" };
            def["SnakeMnV2"] = new string[] { "SnakeManV2" };
            def["SnakeMnV3"] = new string[] { "SnakeManV3" };
            def["PlanetMn"] = new string[] { "PlanetMan" };
            def["PlnetMnV2"] = new string[] { "PlanetManV2", "PlanetMnV2" };
            def["PlnetMnV3"] = new string[] { "PlanetManV3", "PlanetMnV3" };
            def["NapalmMn"] = new string[] { "NapalmMan" };
            def["NaplmMnV2"] = new string[] { "NapalmManV2", "NapalmMnV2", "NaplmManV2" };
            def["NaplmMnV3"] = new string[] { "NapalmManV3", "NapalmMnV3", "NaplmManV3" };
            def["PharoMan"] = new string[] { "PharaohMan", "PharaohMn" };
            def["PharoMnV2"] = new string[] { "PharaohManV2", "PharaohMnV2", "PharoManV2" };
            def["PharoMnV3"] = new string[] { "PharaohManV3", "PharaohMnV3", "PharoManV3" };
            return def;
        } }
        
        public override string[] chipCodes { get { return new string[] {
            "------", // MegaBstr
            "ABCDE*", // Cannon
            "CDEFG*", // HiCannon
            "EFGHI*", // M-Cannon
            "BFHJN*", // Shotgun
            "AFGLP*", // V-Gun
            "HJMQS*", // CrossGun
            "MNOPQ*", // Spreader
            "BGHPR*", // Bubbler
            "CDJNS*", // Bub-V
            "KOPTV*", // BubCross
            "EFILM*", // BubSprd
            "BGHPR*", // HeatShot
            "CDJNS*", // Heat-V
            "KOPTV*", // HeatCros
            "EFILM*", // HeatSprd
            "BEGLO*", // MiniBomb
            "FJOQT*", // LilBomb
            "DJOQT*", // CrosBomb
            "OQTVY*", // BigBomb
            "BGHPR*", // TreeBom1
            "CDJNS*", // TreeBom2
            "KOPTV*", // TreeBom3
            "AKLSY*", // Sword
            "ACLQY*", // WideSwrd
            "AILOY*", // LongSwrd
            "FHNRU*", // FireSwrd
            "AHNRW*", // AquaSwrd
            "EHNRV*", // ElecSwrd
            "FHPRZ*", // FireBlde
            "AFJRZ*", // AquaBlde
            "EFMNR*", // ElecBlde
            "DHMQU*", // StepSwrd
            "NOTUW*", // Muramasa
            "BGKQT*", // CustSwrd
            "EILPS*", // Kunai1
            "DFJQR*", // Kunai2
            "CGHKN*", // Kunai3
            "ADHLQ*", // Slasher
            "HJLRU*", // Shockwav
            "EIMSW*", // Sonicwav
            "GNQTV*", // Dynawave
            "AMPQW*", // Quake1
            "BGNQW*", // Quake2
            "CEOQW*", // Quake3
            "BDHKN*", // GutPunch
            "BDLPS*", // ColdPnch
            "-----*", // Atk+20
            "-----*", // Atk+30
            "-----*", // Navi+40
            "BDGJL*", // DashAtk
            "OQSUW*", // Wrecker
            "OPQRS*", // CannBall
            "ACFIJ*", // DoubNdl
            "CIMTV*", // TripNdl
            "CHIPU*", // QuadNdl
            "EIKOT*", // Trident
            "HIJKL*", // Ratton1
            "JKLMN*", // Ratton2
            "LMNOP*", // Ratton3
            "BFGHR*", // FireRat
            "EJLMQ*", // Tornado
            "NOTUY*", // Twister
            "PRTWZ*", // Blower
            "ABFLS*", // Burner
            "AMPQW*", // ZapRing1
            "BGNRS*", // ZapRing2
            "CEOTZ*", // ZapRing3
            "ACGQT*", // Spice1
            "BEHJN*", // Spice2
            "DKMPQ*", // Spice3
            "GOQUW*", // Satelit1
            "HJKPR*", // Satelit2
            "LSTYZ*", // Satelit3
            "CERTV*", // Yo-Yo1
            "AGJKN*", // Yo-Yo2
            "DIMSY*", // Yo-Yo3
            "FGJMN*", // MagBomb1
            "BDIRT*", // MagBomb2
            "HKOQS*", // MagBomb3
            "CELSV*", // Meteor9
            "ACFJW*", // Meteor12
            "DGHRZ*", // Meteor15
            "BGIKO*", // Meteor18
            "RTUVZ*", // Hammer
            "AOPSZ*", // CrsShld1
            "AOPTV*", // CrsShld2
            "AOPUW*", // CrsShld3
            "CGKMZ*", // TimeBom1
            "FGKOZ*", // TimeBom2
            "EGKPZ*", // TimeBom3
            "CGIKN*", // LilCloud
            "DHJLO*", // MedCloud
            "QRTUW*", // BigCloud
            "LNRSV*", // Mine
            "HMQRT*", // FrntSnsr
            "EJPWY*", // DblSnsr
            "EGJKN*", // Remobit1
            "BFIRU*", // Remobit2
            "ALMTY*", // Remobit3
            "ABQTW*", // AquaBall
            "EHJKV*", // ElecBall
            "CFRSU*", // HeatBall
            "ABDLS*", // Geyser
            "FGORY*", // LavaDrag
            "EILQU*", // GodStone
            "CMSTW*", // OldWood
            "DSUWZ*", // PoisMask
            "PQUWY*", // PoisFace
            "ACEGI*", // Whirlpl
            "BDFHJ*", // Blckhole
            "-----*", // Guard
            "BELST*", // Barrier
            "ABDLS*", // PanlOut1
            "CENRY*", // PanlOut3
            "FHJQT*", // LineOut
            "OPTVY*", // Lance
            "JKOVZ*", // ZeusHamr
            "BNORS*", // BrnzFist
            "EILSV*", // SilvFist
            "DGLOZ*", // GoldFist
            "BLNTZ*", // VarSwrd
            "ACEGL*", // Recov10
            "BDFHM*", // Recov30
            "CEGIN*", // Recov50
            "DFHJO*", // Recov80
            "OQSUW*", // Recov120
            "NPRTV*", // Recov150
            "MNUVW*", // Recov200
            "ORVWZ*", // Recov300
            "BHKLP*", // PanlGrab
            "ELRSZ*", // AreaGrab
            "ALPSW*", // GrabRvng
            "CKLQS*", // Geddon1
            "JMRTZ*", // Geddon2
            "EJNPY*", // Geddon3
            "FIJNT*", // Catcher
            "DIMNT*", // Mindbndr
            "FHJLN*", // Escape
            "AJOVZ*", // AirShoes
            "ACELP*", // Repair
            "CFIMV*", // Candle1
            "AGJLT*", // Candle2
            "BEHNW*", // Candle3
            "BDGMV*", // RockCube
            "BCLNQ*", // Prism
            "OPUVZ*", // Guardian
            "GJOQT*", // Wind
            "AGLNY*", // Fan
            "HKMUW*", // Anubis
            "-----*", // SloGauge
            "-----*", // FstGauge
            "-----*", // FullCust
            "AFLRU*", // Invis1
            "BHMQV*", // Invis2
            "CGKPW*", // Invis3
            "ACFQS*", // DropDown
            "DIJTW*", // PopUp
            "CESTW*", // StoneBod
            "BGHLR*", // Shadow1
            "DEJMT*", // Shadow2
            "CFKNV*", // Shadow3
            "HJNRW*", // UnderSht
            "IJQRW*", // BblWrap
            "ADRSW*", // LeafShld
            "AEIMQ*", // AquaAura
            "BFJNR*", // FireAura
            "CGKOS*", // WoodAura
            "DHLPT*", // ElecAura
            "BGIOQ*", // LifeAur1
            "DFJNR*", // LifeAur2
            "EHKMT*", // LifeAur3
            "AEIMQ*", // MagLine
            "AFJMR*", // LavaLine
            "BEJNQ*", // IceLine
            "BFINR*", // GrassLne
            "DHMUV*", // LavaStge
            "ACEIS*", // IceStage
            "BDHPR*", // GrassStg
            "CEHLR*", // HolyPanl
            "EJORU*", // Jealousy
            "FKLPT*", // AntiFire
            "EHNUY*", // AntiElec
            "ADQWZ*", // AntiWatr
            "CJMRS*", // AntiDmg
            "DHIMT*", // AntiSwrd
            "KLOTX*", // AntiNavi
            "BDMPW*", // AntiRecv
            "-----*", // Atk+10
            "-----*", // Fire+40
            "-----*", // Aqua+40
            "-----*", // Wood+40
            "-----*", // Elec+40
            "-----*", // Navi+20
            "R----*", // Roll
            "R----*", // RollV2
            "R----*", // RollV3
            "G----*", // GutsMan
            "G----*", // GutsManV2
            "G----*", // GutsManV3
            "B----*", // ProtoMan
            "B----*", // ProtoMnV2
            "B----*", // ProtoMnV3
            "A----*", // AirMan
            "A----*", // AirManV2
            "A----*", // AirManV3
            "Q----*", // QuickMan
            "Q----*", // QuickMnV2
            "Q----*", // QuickMnV3
            "C----*", // CutMan
            "C----*", // CutManV2
            "C----*", // CutManV3
            "S----*", // ShadoMan
            "S----*", // ShadoMnV2
            "S----*", // ShadoMnV3
            "K----*", // KnightMn
            "K----*", // KnghtMnV2
            "K----*", // KnghtMnV3
            "M----*", // MagnetMn
            "M----*", // MagntMnV2
            "M----*", // MagntMnV3
            "F----*", // FreezeMn
            "F----*", // FrzManV2
            "F----*", // FrzManV3
            "H----*", // HeatMan
            "H----*", // HeatManV2
            "H----*", // HeatManV3
            "T----*", // ToadMan
            "T----*", // ToadManV2
            "T----*", // ToadManV3
            "T----*", // ThunMan
            "T----*", // ThunManV2
            "T----*", // ThunManV3
            "S----*", // SnakeMan
            "S----*", // SnakeMnV2
            "S----*", // SnakeMnV3
            "G----*", // GateMan
            "G----*", // GateManV2
            "G----*", // GateManV3
            "P----*", // PlanetMn
            "P----*", // PlnetMnV2
            "P----*", // PlnetMnV3
            "N----*", // NapalmMn
            "N----*", // NaplmMnV2
            "N----*", // NaplmMnV3
            "P----*", // PharoMan
            "P----*", // PharoMnV2
            "P----*", // PharoMnV3
            "F----*", // Bass
            "F----*", // BassV2
            "X----*", // BassV3
            "FHPRS*", // BgRedWav
            "AIJQU*", // FreezBom
            "CEGKV*", // Sparker
            "DLNWY*", // GaiaSwrd
            "BGFPR*", // BlkBomb
            "AILSY*", // FtrSword
            "FJKMQ*", // KngtSwrd
            "ENOTZ*", // HeroSwrd
            "BHORV*", // Meteors
            "EPRUW*", // Poltrgst
            "X----*", // FireGspl
            "X----*", // AquaGspl
            "X----*", // ElecGspl
            "X----*", // WoodGspl
            "G----*", // GateSP
            "------",
            "------",
            "------",
            "------",
            "ACELS*", // Snctuary
        }; } }
        
        public override Dictionary<int, byte[]> unobtainableCodes { get {
            Dictionary<int, byte[]> def = new Dictionary<int, byte[]>();
            
            int[] ungettableStarCodes = new int[] {
                3, // M-Cannon
                5, // V-Gun
                8, // Bubbler
                9, // Bub-V
                10, // BubCross
                11, // BubSprd
                12, // HeatShot
                13, // Heat-V
                14, // HeatCros
                15, // HeatSprd
                18, // CrosBomb
                21, // TreeBom2
                22, // TreeBom3
                23, // Sword
                25, // LongSwrd
                26, // FireSwrd
                27, // AquaSwrd
                32, // StepSwrd
                35, // Kunai1
                36, // Kunai2
                37, // Kunai3
                34, // CustSwrd
                33, // Muramasa
                121, // VarSwrd
                38, // Slasher
                39, // Shockwav
                40, // Sonicwav
                41, // Dynawave
                42, // Quake1
                43, // Quake2
                44, // Quake3
                45, // GutPunch
                46, // ColdPnch
                51, // Wrecker
                53, // DoubNdl
                54, // TripNdl
                55, // QuadNdl
                56, // Trident
                60, // FireRat
                61, // Tornado
                62, // Twister
                63, // Blower
                64, // Burner
                66, // ZapRing2
                67, // ZapRing3
                71, // Satelit1
                72, // Satelit2
                73, // Satelit3
                68, // Spice1
                69, // Spice2
                70, // Spice3
                79, // MagBomb3
                74, // Yo-Yo1
                75, // Yo-Yo2
                76, // Yo-Yo3
                85, // CrsShld1
                86, // CrsShld2
                87, // CrsShld3
                84, // Hammer
                117, // ZeusHamr
                116, // Lance
                118, // BrnzFist
                119, // SilvFist
                120, // GoldFist
                107, // PoisMask
                108, // PoisFace
                109, // Whirlpl
                110, // Blckhole
                80, // Meteor9
                81, // Meteor12
                82, // Meteor15
                83, // Meteor18
                88, // TimeBom1
                89, // TimeBom2
                90, // TimeBom3
                91, // LilCloud
                92, // MedCloud
                93, // BigCloud
                95, // FrntSnsr
                96, // DblSnsr
                97, // Remobit1
                98, // Remobit2
                99, // Remobit3
                100, // AquaBall
                101, // ElecBall
                102, // HeatBall
                103, // Geyser
                104, // LavaDrag
                105, // GodStone
                106, // OldWood
                115, // LineOut
                136, // Catcher
                137, // Mindbndr
                126, // Recov120
                127, // Recov150
                128, // Recov200
                129, // Recov300
                132, // GrabRvng
                133, // Geddon1
                134, // Geddon2
                135, // Geddon3
                138, // Escape
                139, // AirShoes
                141, // Candle1
                142, // Candle2
                143, // Candle3
                145, // Prism
                146, // Guardian
                149, // Anubis
                156, // DropDown
                157, // PopUp
                158, // StoneBod
                159, // Shadow1
                160, // Shadow2
                161, // Shadow3
                162, // UnderSht
                163, // BblWrap
                164, // LeafShld
                165, // AquaAura
                166, // FireAura
                167, // WoodAura
                168, // ElecAura
                169, // LifeAur1
                170, // LifeAur2
                171, // LifeAur3
                172, // MagLine
                173, // LavaLine
                174, // IceLine
                175, // GrassLne
                176, // LavaStge
                177, // IceStage
                178, // GrassStg
                179, // HolyPanl
                180, // Jealousy
                181, // AntiFire
                182, // AntiElec
                183, // AntiWatr
                184, // AntiDmg
                185, // AntiSwrd
                186, // AntiNavi
                187, // AntiRecv
                196, // RollV3
                198, // GutsManV2
                199, // GutsManV3
                201, // ProtoMnV2
                202, // ProtoMnV3
                213, // ShadoMnV2
                214, // ShadoMnV3
                216, // KnghtMnV2
                217, // KnghtMnV3
                219, // MagntMnV2
                220, // MagntMnV3
                222, // FrzManV2
                223, // FrzManV3
                225, // HeatManV2
                226, // HeatManV3
                228, // ToadManV2
                229, // ToadManV3
                231, // ThunManV2
                232, // ThunManV3
                234, // SnakeMnV2
                235, // SnakeMnV3
                237, // GateManV2
                238, // GateManV3
                245, // PharoMan
                246, // PharoMnV2
                247, // PharoMnV3
                242, // NapalmMn
                243, // NaplmMnV2
                244, // NaplmMnV3
                239, // PlanetMn
                240, // PlnetMnV2
                241, // PlnetMnV3
                248, // Bass
                249, // BassV2
                250, // BassV3
                265, // GateSP
                261, // FireGspl
                262, // AquaGspl
                263, // ElecGspl
                264, // WoodGspl
                270, // Snctuary
            };
            foreach (int id in ungettableStarCodes)
                def[id] = new byte[] { 5 };
            
            def[171] = new byte[] { 1, 3, 5 }; // LifeAur3 H, M, *
            def[258] = new byte[] { 4 }; // HeroSwrd Z
            
            return def;
        } }
        
        public override int[] chipSizes { get { return new int[] {
            99, // MegaBstr
            16, // Cannon
            24, // HiCannon
            32, // M-Cannon
            4, // Shotgun
            4, // V-Gun
            8, // CrossGun
            20, // Spreader
            12, // Bubbler
            16, // Bub-V
            20, // BubCross
            32, // BubSprd
            14, // HeatShot
            18, // Heat-V
            22, // HeatCros
            36, // HeatSprd
            8, // MiniBomb
            12, // LilBomb
            16, // CrosBomb
            32, // BigBomb
            10, // TreeBom1
            15, // TreeBom2
            20, // TreeBom3
            12, // Sword
            16, // WideSwrd
            22, // LongSwrd
            24, // FireSwrd
            26, // AquaSwrd
            28, // ElecSwrd
            32, // FireBlde
            32, // AquaBlde
            32, // ElecBlde
            54, // StepSwrd
            88, // Muramasa
            68, // CustSwrd
            48, // Kunai1
            64, // Kunai2
            78, // Kunai3
            24, // Slasher
            10, // Shockwav
            30, // Sonicwav
            50, // Dynawave
            16, // Quake1
            32, // Quake2
            64, // Quake3
            8, // GutPunch
            8, // ColdPnch
            20, // Atk+20
            38, // Atk+30
            42, // Navi+40
            12, // DashAtk
            16, // Wrecker
            22, // CannBall
            18, // DoubNdl
            24, // TripNdl
            30, // QuadNdl
            30, // Trident
            26, // Ratton1
            32, // Ratton2
            38, // Ratton3
            30, // FireRat
            22, // Tornado
            22, // Twister
            22, // Blower
            28, // Burner
            12, // ZapRing1
            16, // ZapRing2
            20, // ZapRing3
            14, // Spice1
            28, // Spice2
            42, // Spice3
            20, // Satelit1
            24, // Satelit2
            28, // Satelit3
            36, // Yo-Yo1
            40, // Yo-Yo2
            44, // Yo-Yo3
            10, // MagBomb1
            14, // MagBomb2
            18, // MagBomb3
            12, // Meteor9
            24, // Meteor12
            48, // Meteor15
            60, // Meteor18
            24, // Hammer
            18, // CrsShld1
            24, // CrsShld2
            32, // CrsShld3
            32, // TimeBom1
            48, // TimeBom2
            64, // TimeBom3
            16, // LilCloud
            24, // MedCloud
            32, // BigCloud
            12, // Mine
            14, // FrntSnsr
            24, // DblSnsr
            8, // Remobit1
            16, // Remobit2
            32, // Remobit3
            20, // AquaBall
            20, // ElecBall
            20, // HeatBall
            40, // Geyser
            60, // LavaDrag
            60, // GodStone
            60, // OldWood
            24, // PoisMask
            30, // PoisFace
            20, // Whirlpl
            30, // Blckhole
            2, // Guard
            8, // Barrier
            4, // PanlOut1
            8, // PanlOut3
            24, // LineOut
            20, // Lance
            70, // ZeusHamr
            18, // BrnzFist
            30, // SilvFist
            60, // GoldFist
            40, // VarSwrd
            2, // Recov10
            4, // Recov30
            8, // Recov50
            16, // Recov80
            32, // Recov120
            48, // Recov150
            64, // Recov200
            80, // Recov300
            4, // PanlGrab
            8, // AreaGrab
            24, // GrabRvng
            16, // Geddon1
            32, // Geddon2
            48, // Geddon3
            12, // Catcher
            38, // Mindbndr
            64, // Escape
            12, // AirShoes
            8, // Repair
            50, // Candle1
            60, // Candle2
            70, // Candle3
            16, // RockCube
            24, // Prism
            54, // Guardian
            10, // Wind
            10, // Fan
            90, // Anubis
            10, // SloGauge
            10, // FstGauge
            10, // FullCust
            12, // Invis1
            24, // Invis2
            48, // Invis3
            64, // DropDown
            84, // PopUp
            64, // StoneBod
            32, // Shadow1
            48, // Shadow2
            64, // Shadow3
            18, // UnderSht
            36, // BblWrap
            26, // LeafShld
            30, // AquaAura
            36, // FireAura
            42, // WoodAura
            48, // ElecAura
            60, // LifeAur1
            70, // LifeAur2
            80, // LifeAur3
            24, // MagLine
            24, // LavaLine
            24, // IceLine
            24, // GrassLne
            64, // LavaStge
            64, // IceStage
            64, // GrassStg
            22, // HolyPanl
            22, // Jealousy
            32, // AntiFire
            32, // AntiElec
            32, // AntiWatr
            32, // AntiDmg
            32, // AntiSwrd
            32, // AntiNavi
            32, // AntiRecv
            4, // Atk+10
            12, // Fire+40
            12, // Aqua+40
            12, // Wood+40
            12, // Elec+40
            24, // Navi+20
            8, // Roll
            24, // RollV2
            48, // RollV3
            32, // GutsMan
            48, // GutsManV2
            64, // GutsManV3
            52, // ProtoMan
            64, // ProtoMnV2
            76, // ProtoMnV3
            16, // AirMan
            34, // AirManV2
            72, // AirManV3
            32, // QuickMan
            56, // QuickMnV2
            80, // QuickMnV3
            20, // CutMan
            50, // CutManV2
            80, // CutManV3
            64, // ShadoMan
            80, // ShadoMnV2
            96, // ShadoMnV3
            64, // KnightMn
            80, // KnghtMnV2
            96, // KnghtMnV3
            48, // MagnetMn
            64, // MagntMnV2
            80, // MagntMnV3
            64, // FreezeMn
            80, // FrzManV2
            96, // FrzManV3
            64, // HeatMan
            80, // HeatManV2
            96, // HeatManV3
            28, // ToadMan
            48, // ToadManV2
            68, // ToadManV3
            30, // ThunMan
            60, // ThunManV2
            90, // ThunManV3
            25, // SnakeMan
            50, // SnakeMnV2
            75, // SnakeMnV3
            24, // GateMan
            40, // GateManV2
            56, // GateManV3
            64, // PlanetMn
            80, // PlnetMnV2
            96, // PlnetMnV3
            48, // NapalmMn
            64, // NaplmMnV2
            80, // NaplmMnV3
            32, // PharoMan
            48, // PharoMnV2
            64, // PharoMnV3
            96, // Bass
            96, // BassV2
            96, // BassV3
            64, // BgRedWav
            56, // FreezBom
            48, // Sparker
            72, // GaiaSwrd
            64, // BlkBomb
            50, // FtrSword
            64, // KngtSwrd
            90, // HeroSwrd
            68, // Meteors
            50, // Poltrgst
            96, // FireGspl
            96, // AquaGspl
            96, // ElecGspl
            96, // WoodGspl
            50, // GateSP
            64,
            99,
            99,
            99,
            99 // Snctuary
        }; } }
        
        public override int[] gameOrderStandardChips { get { return new int[] {
            1, // Cannon
            2, // HiCannon
            3, // M-Cannon
            4, // Shotgun
            5, // V-Gun
            6, // CrossGun
            7, // Spreader
            8, // Bubbler
            9, // Bub-V
            10, // BubCross
            11, // BubSprd
            12, // HeatShot
            13, // Heat-V
            14, // HeatCros
            15, // HeatSprd
            16, // MiniBomb
            17, // LilBomb
            18, // CrosBomb
            19, // BigBomb
            20, // TreeBom1
            21, // TreeBom2
            22, // TreeBom3
            23, // Sword
            24, // WideSwrd
            25, // LongSwrd
            26, // FireSwrd
            27, // AquaSwrd
            28, // ElecSwrd
            29, // FireBlde
            30, // AquaBlde
            31, // ElecBlde
            32, // StepSwrd
            35, // Kunai1
            36, // Kunai2
            37, // Kunai3
            34, // CustSwrd
            33, // Muramasa
            121, // VarSwrd
            38, // Slasher
            39, // Shockwav
            40, // Sonicwav
            41, // Dynawave
            42, // Quake1
            43, // Quake2
            44, // Quake3
            45, // GutPunch
            46, // ColdPnch
            50, // DashAtk
            51, // Wrecker
            52, // CannBall
            53, // DoubNdl
            54, // TripNdl
            55, // QuadNdl
            56, // Trident
            57, // Ratton1
            58, // Ratton2
            59, // Ratton3
            60, // FireRat
            61, // Tornado
            62, // Twister
            63, // Blower
            64, // Burner
            65, // ZapRing1
            66, // ZapRing2
            67, // ZapRing3
            71, // Satelit1
            72, // Satelit2
            73, // Satelit3
            68, // Spice1
            69, // Spice2
            70, // Spice3
            77, // MagBomb1
            78, // MagBomb2
            79, // MagBomb3
            74, // Yo-Yo1
            75, // Yo-Yo2
            76, // Yo-Yo3
            85, // CrsShld1
            86, // CrsShld2
            87, // CrsShld3
            84, // Hammer
            117, // ZeusHamr
            116, // Lance
            118, // BrnzFist
            119, // SilvFist
            120, // GoldFist
            107, // PoisMask
            108, // PoisFace
            109, // Whirlpl
            110, // Blckhole
            80, // Meteor9
            81, // Meteor12
            82, // Meteor15
            83, // Meteor18
            88, // TimeBom1
            89, // TimeBom2
            90, // TimeBom3
            91, // LilCloud
            92, // MedCloud
            93, // BigCloud
            94, // Mine
            95, // FrntSnsr
            96, // DblSnsr
            97, // Remobit1
            98, // Remobit2
            99, // Remobit3
            100, // AquaBall
            101, // ElecBall
            102, // HeatBall
            103, // Geyser
            104, // LavaDrag
            105, // GodStone
            106, // OldWood
            111, // Guard
            113, // PanlOut1
            114, // PanlOut3
            115, // LineOut
            136, // Catcher
            137, // Mindbndr
            122, // Recov10
            123, // Recov30
            124, // Recov50
            125, // Recov80
            126, // Recov120
            127, // Recov150
            128, // Recov200
            129, // Recov300
            130, // PanlGrab
            131, // AreaGrab
            132, // GrabRvng
            133, // Geddon1
            134, // Geddon2
            135, // Geddon3
            138, // Escape
            139, // AirShoes
            140, // Repair
            141, // Candle1
            142, // Candle2
            143, // Candle3
            144, // RockCube
            145, // Prism
            146, // Guardian
            147, // Wind
            148, // Fan
            149, // Anubis
            150, // SloGauge
            151, // FstGauge
            152, // FullCust
            153, // Invis1
            154, // Invis2
            155, // Invis3
            156, // DropDown
            157, // PopUp
            158, // StoneBod
            159, // Shadow1
            160, // Shadow2
            161, // Shadow3
            162, // UnderSht
            112, // Barrier
            163, // BblWrap
            164, // LeafShld
            165, // AquaAura
            166, // FireAura
            167, // WoodAura
            168, // ElecAura
            169, // LifeAur1
            170, // LifeAur2
            171, // LifeAur3
            172, // MagLine
            173, // LavaLine
            174, // IceLine
            175, // GrassLne
            176, // LavaStge
            177, // IceStage
            178, // GrassStg
            179, // HolyPanl
            180, // Jealousy
            181, // AntiFire
            182, // AntiElec
            183, // AntiWatr
            184, // AntiDmg
            185, // AntiSwrd
            186, // AntiNavi
            187, // AntiRecv
            188, // Atk+10
            47, // Atk+20
            48, // Atk+30
            189, // Fire+40
            190, // Aqua+40
            191, // Wood+40
            192, // Elec+40
            193, // Navi+20
            49, // Navi+40
            194, // Roll
            195, // RollV2
            196, // RollV3
            197, // GutsMan
            198, // GutsManV2
            199, // GutsManV3
            200, // ProtoMan
            201, // ProtoMnV2
            202, // ProtoMnV3
            203, // AirMan
            204, // AirManV2
            205, // AirManV3
            206, // QuickMan
            207, // QuickMnV2
            208, // QuickMnV3
            209, // CutMan
            210, // CutManV2
            211, // CutManV3
            212, // ShadoMan
            213, // ShadoMnV2
            214, // ShadoMnV3
            215, // KnightMn
            216, // KnghtMnV2
            217, // KnghtMnV3
            218, // MagnetMn
            219, // MagntMnV2
            220, // MagntMnV3
            221, // FreezeMn
            222, // FrzManV2
            223, // FrzManV3
            224, // HeatMan
            225, // HeatManV2
            226, // HeatManV3
            227, // ToadMan
            228, // ToadManV2
            229, // ToadManV3
            230, // ThunMan
            231, // ThunManV2
            232, // ThunManV3
            233, // SnakeMan
            234, // SnakeMnV2
            235, // SnakeMnV3
            236, // GateMan
            237, // GateManV2
            238, // GateManV3
            245, // PharoMan
            246, // PharoMnV2
            247, // PharoMnV3
            242, // NapalmMn
            243, // NaplmMnV2
            244, // NaplmMnV3
            239, // PlanetMn
            240, // PlnetMnV2
            241, // PlnetMnV3
            248, // Bass
            249, // BassV2
            250, // BassV3
            251, // BgRedWav
            252, // FreezBom
            253, // Sparker
            254, // GaiaSwrd
            255, // BlkBomb
            256, // FtrSword
            257, // KngtSwrd
            258, // HeroSwrd
            259, // Meteors
            260, // Poltrgst
        }; } }
        
        public override int[] gameOrderSecretChipsAll { get { return new int[] {
            265, // GateSP
            261, // FireGspl
            262, // AquaGspl
            263, // ElecGspl
            264, // WoodGspl
            270, // Snctuary
        }; } }
        
        public override int[] gameOrderPAs { get { return new int[] {
            0, // Z-Canon1
            1, // Z-Canon2
            2, // Z-Canon3
            3, // H-Burst
            4, // Z-Ball
            5, // Z-Raton1
            6, // Z-Raton2
            7, // Z-Raton3
            8, // O-Canon1
            9, // O-Canon2
            10, // O-Canon3
            11, // M-Burst
            12, // O-Ball
            13, // O-Raton1
            14, // O-Raton2
            15, // O-Raton3
            16, // Arrows
            17, // UltraBmb
            18, // LifeSrd1
            19, // LifeSrd2
            20, // LifeSrd3
            21, // Punch
            22, // Curse
            23, // TimeBom+
            24, // HvyStamp
            25, // PoisPhar
            26, // Gater
            27, // GtsShoot
            28, // BigHeart
            29, // BodyGrd
            30, // 2xHero
            31, // Darkness
        }; } }
        
        public override string[] keyItemNames { get { return new string[] {
            "PET", "HeroData", "HopeData", "Fan", "ExamCard", "WalkProg", "NiceData", "Paper", "Lighter", "Stick",
            "Binocs", "Knife", "Firewood", "Fish", "Balloon", "OddProg", "BadDataA", "BadDataB", "Battery", "YumKey",
            "NoteData", "Chng.bat", "Ticket", "Passport", "Wireless", "MiniPET", "CyberKey", "Brooch", "NetRoboX", "GoldRing",
            "PilotCap", "Chopstck", "Whiskey", "Thread", "RedFrag", "RedCure", "HeatData", "YeloCure", "BluFragA", "BluFragB",
            "GospelID", "KotoPass", "MagSuit", "ElBit042", "ElBit082", "ElBit093", "ElBit201", "ElBit232", "ElBit243", "ElBit253",
            "ElBit271", "ElBitEV", "LoveLetr", "Beetle", "YumTear", "KngStone", "Twilight", "ArmyData", "ZLicense", "BLicense",
            "ALicense", "SLicense", "SSLicnse", "SSSLcnse", "FreePass", "GateKeyA", "GateKeyB", "GateKeyC", "GateKeyD", "BugFrag",
            "", "", "", "", "", "", "", "", "", "",
            "MaylCode", "DexCode", "YaiCode", "RibiCode", "RaulCode", "MiliCode", "ONBACode", "GospCode", "ACDCPass", "MariPass",
            "OkuPass", "AirPass", "", "", "", "", "HPMemory", "PowerUP", "RegUP1", "RegUP2",
            "RegUP3", "SubMem", "", "", "", "", "", "", "", "",
            "", "", "MiniEnrg", "FullEnrg", "SneakRun", "Untrap", "LocEnemy", "Unlocker"
        }; } } // Includes upgrade items and SubChips for things that use IDs relative to start of key items
        
        public override string[] upgradeItemNames { get { return new string[] {
            "HPMemory", "PowerUP", "RegUP1", "RegUP2", "RegUP3", "SubMem"
        }; } }
        
        public override int[][] upgradeItemFlags { get {
            int[][] flags = new int[upgradeItemNames.Length][];
            // HPMemory
            flags[0] = new int[] { 183, 199, 258, 274, 320, 323, 324, 1323, 1333, 1346,
                1518, 1525, 1444, 1491, 1373, 1391, 1399, 1437, 1532, 3202, 3204, 3213 };
            // PowerUP
            flags[1] = new int[] { 319, 327, 1294, 1343, 1473, 1496, 3211 };
            // RegUP1
            flags[2] = new int[] { -59 /* BLicense item */, 230, 240, 1309, 1324, 1351, 1383, 1390, 1393, 1397,
                1403, 1469, 1485, 1503, 1512, 3200, 3203, 3214 };
            // RegUP2
            flags[3] = new int[] { 321, 322, 326, 552, 1338, 1364, 1526, 1405, 1529, 1551, 3210 };
            // RegUP3
            flags[4] = new int[] { 280, 1425 };
            // SubMem
            flags[5] = new int[] { 325, 1452, 1539, 1570 };
            return flags;
        } }
        
        public override string[] subchipNames { get { return new string[] {
            "MiniEnrg", "FullEnrg", "SneakRun", "Untrap", "LocEnemy", "Unlocker"
        }; } }
        
        public override Dictionary<int, int[]> shopHPMemoryPrices { get {
            Dictionary<int, int[]> def = new Dictionary<int, int[]>();
            def[0] = new int[] { 1000, 2000 }; // Den Area 1 NetDealer
            def[2] = new int[] { 3000, 5000, 8000 }; // Den Area 3 NetDealer
            def[3] = new int[] { 2000, 4000, 8000 }; // The Square NetDealer
            def[5] = new int[] { 15000, 20000, 30000 }; // UnderKoto NetDealer
            def[6] = new int[] { 4000, 8000, 12000 }; // KotoSquare NetDealer
            def[10] = new int[] { 8000, 12000, 16000 }; // NetSquare NetDealer
            def[12] = new int[] { 10000, 15000, 20000 }; // Undernet 1 NetDealer
            def[14] = new int[] { 12000, 16000, 20000 }; // UnderSquare NetDealer
            return def;
        } }
        
        public override Dictionary<int, int[]> shopPowerUpPrices { get {
            Dictionary<int, int[]> def = new Dictionary<int, int[]>();
            def[2] = new int[] { 5000 }; // Den Area 3 NetDealer
            def[5] = new int[] { 20000 }; // UnderKoto NetDealer
            def[6] = new int[] { 10000 }; // KotoSquare NetDealer
            def[10] = new int[] { 10000 }; // NetSquare NetDealer
            def[14] = new int[] { 20000 }; // UnderSquare NetDealer
            return def;
        } }
        
        public override int[][] libraryFlagRanges { get { return new int[][] {
            new int[] { 768, 1031 }, new int[] { 1248, 1279 }, null, null // Chips, PAs, no library sharing
        }; } }
        
        public override Dictionary<string, string[]> presetFolders { get {
            Dictionary<string, string[]> def = new Dictionary<string, string[]>();
            def["Fldr1"] = new string[] {
                "Cannon A", "Cannon A", "Cannon A", "Cannon B", "Cannon B", "Shotgun J", "Shotgun J", "Shotgun J", "V-Gun L", "V-Gun L",
                "V-Gun L", "MiniBomb B", "MiniBomb B", "MiniBomb B", "Recov10 A", "Recov10 A", "Recov10 L", "Recov10 L", "Recov10 L", "Escape F",
                "Sword S", "Sword S", "Sword S", "Sword S", "WideSwrd L", "PanlOut1 B", "PanlOut1 B", "Atk+10 *", "Atk+10 *", "AreaGrab S"
            };
            def["Fldr2"] = new string[] {
                "Cannon C", "Cannon E", "HiCannon E", "HiCannon F", "HiCannon G", "CrossGun M", "CrossGun M", "CrossGun Q", "CrossGun Q", "Wrecker S",
                "Wrecker W", "DoubNdl C", "DoubNdl C", "DoubNdl I", "DoubNdl I", "BrnzFist N", "BrnzFist S", "Recov50 C", "Recov50 *", "Escape H",
                "Sword A", "Sword L", "Sword Y", "WideSwrd A", "WideSwrd Y", "RockCube *", "PanlOut3 *", "Atk+10 *", "Navi+20 *", "AreaGrab S"
            };
            def["Fldr3"] = new string[] {
                "Ratton1 H", "Ratton1 H", "Ratton1 I", "Ratton1 J", "Ratton2 J", "TripNdl C", "TripNdl I", "Spice2 E", "Spice2 E", "Spice2 E",
                "LilCloud G", "LilCloud G", "LilCloud G", "SilvFist E", "Catcher F", "Recov80 D", "Recov80 D", "Recov120 U", "Mindbndr D", "Escape J",
                "WideSwrd Y", "FireBlde F", "AquaBlde A", "ElecBlde E", "StepSwrd U", "MagLine Q", "LavaLine M", "IceLine J", "Atk+20 *", "AreaGrab *"
            };
            return def;
        } }
        
        public override string[] bbsNames { get { return new string[] {
            "Job BBS", "Battle BBS", "Street BBS", "Virus BBS", "Chat BBS", "Secret Info BBS", "Undernet Info BBS"
        }; } }
        
        public override string[] styleTypes { get { return new string[] {
            "Guts", "Custom", "Team", "Shield"
        }; } }
        
        public override object[] safeLocationLansRoom { get { return new object[] { 0x00, 0x03, 0, 48, 0, 0x01 }; } }
        public override object[] startLocationForFreshSave { get { return new object[] { 0x00, 0x09, 66, 100, 0, 0x04 }; } } // Entrance to Class 5-A
        public override object[] uninitializedJackInLocation { get { return new object[] { 0x00, 0x09, 0, 0, 0, 0x01 }; } } // Center of Class 5-A
        
        public override int[] getGameStartFlags(char version = 'M')
        {
            List<int> flags = new List<int>();
            
            for (int i = 10; i <= 12; i++)
                flags.Add(i);
            for (int i = 14; i <= 18; i++)
                flags.Add(i);
            flags.Add(20);
            for (int i = 88; i <= 89; i++)
                flags.Add(i);
            for (int i = 512; i <= 513; i++)
                flags.Add(i);
           
            // Initial library flags.
            flags.Add(769);
            for (int i = 772; i <= 773; i++)
                flags.Add(i);
            flags.Add(784);
            for (int i = 791; i <= 792; i++)
                flags.Add(i);
            flags.Add(881);
            flags.Add(890);
            flags.Add(899);
            flags.Add(906);
            flags.Add(956);
            
            flags.Add(1447);
            flags.Add(1451);
            for (int i = 1459; i <= 1460; i++)
                flags.Add(i);
            for (int i = 2095; i <= 2096; i++)
                flags.Add(i);
            flags.Add(2131); // PET menu open
            flags.Add(2134); // Enable movement
            for (int i = 2160; i <= 2161; i++)
                flags.Add(i);
            
            return flags.ToArray();
        }
        
        public override ShopItem[][] getInitialShopInventories(char version = 'M')
        {
            ShopItem[][] shops = new ShopItem[23][];
            
            shops[0] = new ShopItem[] {
                new ShopItem(0x01, 0x60, 0xFF, 1000, 1), new ShopItem(0x01, 0x60, 0xFF, 2000, 1),
                new ShopItem(0x02, 0x04, 0x01, 200, 3), new ShopItem(0x02, 0x11, 0x09, 500, 3),
                new ShopItem(0x02, 0x7A, 0x1A, 500, 3), new ShopItem(0x02, 0x07, 0x10, 1000, 3),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[1] = new ShopItem[] {
                new ShopItem(0x02, 0x93, 0x1A, 2000, 3), new ShopItem(0x02, 0x94, 0x1A, 2000, 3),
                new ShopItem(0x02, 0x70, 0x1A, 4000, 3), new ShopItem(0x02, 0x41, 0x1A, 5000, 3),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[2] = new ShopItem[] {
                new ShopItem(0x01, 0x60, 0xFF, 3000, 1), new ShopItem(0x01, 0x60, 0xFF, 5000, 1),
                new ShopItem(0x01, 0x60, 0xFF, 8000, 1), new ShopItem(0x01, 0x61, 0xFF, 5000, 1),
                new ShopItem(0x02, 0xBC, 0x1A, 600, 3), new ShopItem(0x02, 0x07, 0x0E, 800, 3),
                new ShopItem(0x02, 0x7B, 0x01, 1000, 3), new ShopItem(0x02, 0x83, 0x04, 2000, 3)
            };
            shops[3] = new ShopItem[] {
                new ShopItem(0x01, 0x60, 0xFF, 2000, 1), new ShopItem(0x01, 0x60, 0xFF, 4000, 1),
                new ShopItem(0x01, 0x60, 0xFF, 8000, 1), new ShopItem(0x02, 0x06, 0x09, 600, 3),
                new ShopItem(0x02, 0x18, 0x0B, 800, 3), new ShopItem(0x02, 0x7B, 0x07, 1000, 3),
                new ShopItem(0x02, 0x70, 0x01, 1200, 3), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[4] = new ShopItem[] {
                new ShopItem(0x01, 0x70, 0xFF, 50, 255), new ShopItem(0x01, 0x72, 0xFF, 200, 255),
                new ShopItem(0x01, 0x75, 0xFF, 4000, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[5] = new ShopItem[] {
                new ShopItem(0x01, 0x60, 0xFF, 15000, 1), new ShopItem(0x01, 0x60, 0xFF, 20000, 1),
                new ShopItem(0x01, 0x60, 0xFF, 30000, 1), new ShopItem(0x01, 0x61, 0xFF, 20000, 1),
                new ShopItem(0x02, 0x97, 0x1A, 5000, 3), new ShopItem(0x02, 0x96, 0x1A, 5000, 3),
                new ShopItem(0x02, 0x1E, 0x11, 8000, 3), new ShopItem(0x02, 0x89, 0x03, 10000, 3)
            };
            shops[6] = new ShopItem[] {
                new ShopItem(0x01, 0x60, 0xFF, 4000, 1), new ShopItem(0x01, 0x60, 0xFF, 8000, 1),
                new ShopItem(0x01, 0x60, 0xFF, 12000, 1), new ShopItem(0x01, 0x61, 0xFF, 10000, 1),
                new ShopItem(0x02, 0x82, 0x1A, 1000, 3), new ShopItem(0x02, 0xBD, 0x1A, 3000, 3),
                new ShopItem(0x02, 0x1D, 0x11, 3800, 3), new ShopItem(0x02, 0x1B, 0x0D, 5000, 3)
            };
            shops[7] = new ShopItem[] {
                new ShopItem(0x01, 0x70, 0xFF, 50, 255), new ShopItem(0x01, 0x72, 0xFF, 200, 255),
                new ShopItem(0x01, 0x75, 0xFF, 4000, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[8] = new ShopItem[] {
                new ShopItem(0x02, 0x90, 0x1A, 500, 3), new ShopItem(0x02, 0x2E, 0x01, 800, 3),
                new ShopItem(0x02, 0x07, 0x0D, 800, 3), new ShopItem(0x02, 0x88, 0x13, 2000, 3),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[9] = new ShopItem[] {
                new ShopItem(0x02, 0x7E, 0x0E, 4000, 3), new ShopItem(0x02, 0xC0, 0x1A, 5000, 3),
                new ShopItem(0x02, 0x22, 0x01, 7500, 3), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[10] = new ShopItem[] {
                new ShopItem(0x01, 0x60, 0xFF, 8000, 1), new ShopItem(0x01, 0x60, 0xFF, 12000, 1),
                new ShopItem(0x01, 0x60, 0xFF, 16000, 1), new ShopItem(0x01, 0x61, 0xFF, 10000, 1),
                new ShopItem(0x02, 0x8C, 0x1A, 2400, 3), new ShopItem(0x02, 0x18, 0x1A, 3000, 3),
                new ShopItem(0x02, 0x54, 0x14, 4800, 3), new ShopItem(0x02, 0xB4, 0x09, 10000, 3)
            };
            shops[11] = new ShopItem[] {
                new ShopItem(0x01, 0x70, 0xFF, 50, 255), new ShopItem(0x01, 0x71, 0xFF, 400, 255),
                new ShopItem(0x01, 0x72, 0xFF, 200, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[12] = new ShopItem[] {
                new ShopItem(0x01, 0x60, 0xFF, 10000, 1), new ShopItem(0x01, 0x60, 0xFF, 15000, 1),
                new ShopItem(0x01, 0x60, 0xFF, 20000, 1), new ShopItem(0x02, 0x98, 0x1A, 5000, 3),
                new ShopItem(0x02, 0x2F, 0x1A, 8000, 3), new ShopItem(0x02, 0x1F, 0x11, 9000, 3),
                new ShopItem(0x02, 0x84, 0x16, 10000, 3), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[13] = new ShopItem[] {
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[14] = new ShopItem[] {
                new ShopItem(0x01, 0x60, 0xFF, 12000, 1), new ShopItem(0x01, 0x60, 0xFF, 16000, 1),
                new ShopItem(0x01, 0x60, 0xFF, 20000, 1), new ShopItem(0x01, 0x61, 0xFF, 20000, 1),
                new ShopItem(0x02, 0xAC, 0x10, 8000, 3), new ShopItem(0x02, 0xAD, 0x00, 8000, 3),
                new ShopItem(0x02, 0xAE, 0x04, 8000, 3), new ShopItem(0x02, 0xAF, 0x11, 8000, 3)
            };
            shops[15] = new ShopItem[] {
                new ShopItem(0x01, 0x70, 0xFF, 50, 255), new ShopItem(0x01, 0x71, 0xFF, 400, 255),
                new ShopItem(0x01, 0x73, 0xFF, 100, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[16] = new ShopItem[] {
                new ShopItem(0x01, 0x70, 0xFF, 50, 255), new ShopItem(0x01, 0x71, 0xFF, 400, 255),
                new ShopItem(0x01, 0x75, 0xFF, 4000, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[17] = new ShopItem[] {
                new ShopItem(0x01, 0x70, 0xFF, 50, 255), new ShopItem(0x01, 0x72, 0xFF, 200, 255),
                new ShopItem(0x01, 0x75, 0xFF, 4000, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[18] = new ShopItem[] {
                new ShopItem(0x01, 0x71, 0xFF, 400, 255), new ShopItem(0x01, 0x72, 0xFF, 200, 255),
                new ShopItem(0x01, 0x74, 0xFF, 10000, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[19] = new ShopItem[] {
                new ShopItem(0x01, 0x70, 0xFF, 50, 255), new ShopItem(0x01, 0x71, 0xFF, 400, 255),
                new ShopItem(0x01, 0x74, 0xFF, 10000, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[20] = new ShopItem[] {
                new ShopItem(0x01, 0x70, 0xFF, 50, 255), new ShopItem(0x01, 0x71, 0xFF, 400, 255),
                new ShopItem(0x01, 0x72, 0xFF, 200, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[21] = new ShopItem[] {
                new ShopItem(0x02, 0x38, 0x04, 20000, 3), new ShopItem(0x02, 0x3D, 0x04, 20000, 3),
                new ShopItem(0x02, 0x5E, 0x12, 20000, 3), new ShopItem(0x02, 0x5F, 0x11, 20000, 3),
                new ShopItem(0x02, 0x60, 0x04, 20000, 3), new ShopItem(0x02, 0xA3, 0x11, 20000, 3),
                new ShopItem(0x02, 0x69, 0x10, 50000, 3), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[22] = new ShopItem[] {
                new ShopItem(0x02, 0x06, 0x1A, 1, 1), new ShopItem(0x02, 0x07, 0x0C, 1, 1),
                new ShopItem(0x02, 0x7D, 0x1A, 2, 1), new ShopItem(0x02, 0x8B, 0x00, 4, 1),
                new ShopItem(0x02, 0x30, 0x1A, 8, 1), new ShopItem(0x02, 0x75, 0x19, 16, 1),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            
            return shops;
        }
        
        public override byte[] getInitialBBSPostsList()
        {
            byte[] postBytes = new byte[0x200];
            for (int i = 0; i < postBytes.Length; i++)
                postBytes[i] = 0x40;
            
            return postBytes;
        }
        
        public new bool encountersUsingSubsections = true;
        
        public override uint getBaseEncounterPointerForArea(byte area, byte subsection = 0xFF, char version = 'M', string language = "en", bool lc = false)
        {
            int baseAddress = 0x0;
            
            switch (area)
            {
                // Type 0: GBA English, type 1: Legacy Collection (in labels.bin)
                case 0x80: // Gas Comp
                    switch (subsection)
                    {
                        case 0x00: baseAddress = !lc? 0x8016900 : 0x32C80; break;
                        case 0x01: baseAddress = !lc? 0x80169C4 : 0x32D2C; break;
                    }
                    break;
                case 0x81: // Bomb Comp
                    switch (subsection)
                    {
                        case 0x00: baseAddress = !lc? 0x8016AD4 : 0x32E28; break;
                        case 0x01: baseAddress = !lc? 0x8016C10 : 0x32E40; break;
                        case 0x02: baseAddress = !lc? 0x8016D58 : 0x33064; break;
                        case 0x03: baseAddress = !lc? 0x8016EA4 : 0x3318C; break;
                    }
                    break;
                case 0x82: // Mother Comp
                    switch (subsection)
                    {
                        case 0x00: baseAddress = !lc? 0x8017034 : 0x332F8; break;
                        case 0x01: baseAddress = !lc? 0x8017174 : 0x33414; break;
                        case 0x02: baseAddress = !lc? 0x80172A4 : 0x33520; break;
                        case 0x03: baseAddress = !lc? 0x80173E4 : 0x3363C; break;
                        case 0x04: baseAddress = !lc? 0x801751C : 0x33750; break;
                    }
                    break;
                case 0x83: // Castle Comp
                    switch (subsection)
                    {
                        case 0x00: baseAddress = !lc? 0x801769C : 0x338B0; break;
                        case 0x01: baseAddress = !lc? 0x80177B4 : 0x339A4; break;
                        case 0x02: baseAddress = !lc? 0x80178D4 : 0x33AA0; break;
                        case 0x03: baseAddress = !lc? 0x8017A10 : 0x33BB8; break;
                        case 0x04: baseAddress = !lc? 0x8017B3C : 0x33CC0; break;
                    }
                    break;
                case 0x84: // Air Comp
                    switch (subsection)
                    {
                        case 0x00: baseAddress = !lc? 0x8017CAC : 0x33E10; break;
                        case 0x01: baseAddress = !lc? 0x8017DD8 : 0x33F18; break;
                        case 0x02: baseAddress = !lc? 0x8017F00 : 0x3401C; break;
                        case 0x03: baseAddress = !lc? 0x8018028 : 0x34120; break;
                        case 0x04: baseAddress = !lc? 0x8018158 : 0x3422C; break;
                    }
                    break;
                case 0x85: // Apartment Comp
                    switch (subsection)
                    {
                        case 0x00: baseAddress = !lc? 0x80182C0 : 0x34370; break; // Apartment Comp 1
                        case 0x01: baseAddress = !lc? 0x80183E8 : 0x34474; break; // Apartment Comp 2
                        case 0x02: baseAddress = !lc? 0x801853C : 0x345A4; break; // Apartment Comp 3
                        case 0x03: baseAddress = !lc? 0x8018684 : 0x346C8; break; // Apartment Comp 4
                        case 0x04: case 0x05: baseAddress = !lc? 0x80187B4 : 0x347D4; break; // Gosp Server 1/2 (same encounters)
                    }
                    break;
                // 0x86 is unused, points to Gas Comp
                // 0x87 is unused, points to Gas Comp
                case 0x88: // Home Pages
                    switch (subsection)
                    {
                        case 0x00: case 0x01: baseAddress = !lc? 0x8018950 : 0x34950; break; // Lan/Mayl's PC (same encounters)
                        case 0x02: baseAddress = !lc? 0x8018A0C : 0x349F4; break; // Dex's PC
                        case 0x03: baseAddress = !lc? 0x8018AC8 : 0x34A98; break; // Yai's PC
                        case 0x04: baseAddress = !lc? 0x8018B8C : 0x34B44; break; // Ribitta's Van
                        case 0x05: baseAddress = !lc? 0x8018C54 : 0x34BF4; break; // Raoul's Radio
                        case 0x06: baseAddress = !lc? 0x8018D20 : 0x34CA8; break; // Millions's Bag
                    }
                    break;
                // 0x89 is unused, points to Gas Comp
                // 0x8A is unused, points to Gas Comp
                // 0x8B is unused, points to Gas Comp
                case 0x8C: // Cyberworlds A
                    switch (subsection)
                    {
                        case 0x00: baseAddress = !lc? 0x8018E14 : 0x34D88; break; // Blackboard Comp
                        case 0x01: baseAddress = !lc? 0x8018EDC : 0x34E38; break; // Broken Toy Comp
                        case 0x02: baseAddress = !lc? 0x8018FD0 : 0x34F14; break; // Doghouse Comp
                        case 0x03: baseAddress = !lc? 0x8019090 : 0x34FBC; break; // Control Panel Comp
                        case 0x04: baseAddress = !lc? 0x8019158 : 0x3506C; break; // Piano Comp
                        case 0x05: baseAddress = !lc? 0x8019220 : 0x3511C; break; // Coffee Machine Comp
                        case 0x06: baseAddress = !lc? 0x80192EC : 0x351D0; break; // Portable Game Comp
                        case 0x07: baseAddress = !lc? 0x80193A0 : 0x3526C; break; // Telephone Comp
                        case 0x08: baseAddress = !lc? 0x8019470 : 0x35324; break; // Guardian Comp
                        case 0x09: baseAddress = !lc? 0x8019570 : 0x3540C; break; // Gas Stove Comp
                        case 0x0A: baseAddress = !lc? 0x8019640 : 0x354C4; break; // Bear Comp
                        case 0x0B: baseAddress = !lc? 0x8019704 : 0x35570; break; // Monitor Comp
                        case 0x0C: baseAddress = !lc? 0x80197D0 : 0x35624; break; // Wide Monitor Comp
                        case 0x0D: baseAddress = !lc? 0x8019894 : 0x356D0; break; // Flight Board Comp
                        case 0x0E: baseAddress = !lc? 0x8019958 : 0x3577C; break; // Gift Shop Comp
                        case 0x0F: baseAddress = !lc? 0x8019A38 : 0x35844; break; // Bronze Statue Comp
                    }
                    break;
                case 0x8D: // Cyberworlds B
                    switch (subsection)
                    {
                        case 0x00: baseAddress = !lc? 0x8019B3C : 0x35930; break; // Refrigerator Comp
                        case 0x01: baseAddress = !lc? 0x8019C08 : 0x359E4; break; // Goddess Comp
                        case 0x02: baseAddress = !lc? 0x8019CEC : 0x35AB0; break; // Television Comp
                        case 0x03: baseAddress = !lc? 0x8019DB0 : 0x35B5C; break; // Vending Machine Comp 
                        case 0x04: baseAddress = !lc? 0x8019E78 : 0x35C0C; break; // Autolock Comp
                    }
                    break;
                // 0x8E is unused, points to Gas Comp
                // 0x8F is unused, points to Gas Comp
                case 0x90: // Den Area
                    switch (subsection)
                    {
                        case 0x00: baseAddress = !lc? 0x8019FC0 : 0x35D40; break; // Den Area 1
                        case 0x01: baseAddress = !lc? 0x801A07C : 0x35DE4; break; // Den Area 2
                        case 0x02: baseAddress = !lc? 0x801A148 : 0x35E98; break; // Den Area 3
                        case 0x10: baseAddress = !lc? 0x801A210 : 0x35F48; break; // Den Area 1 Special
                    }
                    break;
                case 0x91: // Koto Area
                    switch (subsection)
                    {
                        case 0x00: baseAddress = !lc? 0x801A2E4 : 0x36020; break; // Koto Area
                        case 0x01: baseAddress = !lc? 0x801A404 : 0x3611C; break; // UnderKoto
                        case 0x10: baseAddress = !lc? 0x801A538 : 0x3622C; break; // Koto Area Special
                    }
                    break;
                case 0x92: // Yumland Area
                    switch (subsection)
                    {
                        case 0x00: baseAddress = !lc? 0x801A62C : 0x36320; break; // Yumland Area 1
                        case 0x01: baseAddress = !lc? 0x801A74C : 0x3641C; break; // Yumland Area 2
                        case 0x11: baseAddress = !lc? 0x801A87C : 0x36528; break; // Yumland Area 2 Special
                    }
                    break;
                case 0x93: // Netopia Area
                    switch (subsection)
                    {
                        case 0x00: baseAddress = !lc? 0x801A978 : 0x36628; break; // Netopia Area 1
                        case 0x01: baseAddress = !lc? 0x801AAA4 : 0x36730; break; // Netopia Area 2
                        case 0x02: baseAddress = !lc? 0x801ABD4 : 0x3683C; break; // Netopia Area 3
                        case 0x10: baseAddress = !lc? 0x801AD04 : 0x36948; break; // Netopia Area 1 Special
                    }
                    break;
                case 0x94: // Undernet (and WWW Area)
                    switch (subsection)
                    {
                        case 0x00: baseAddress = !lc? 0x801AE78 : 0x36AC0; break; // Undernet 1
                        case 0x01: baseAddress = !lc? 0x801AF9C : 0x36BC0; break; // Undernet 2
                        case 0x02: baseAddress = !lc? 0x801B0E0 : 0x36CE0; break; // Undernet 3
                        case 0x03: baseAddress = !lc? 0x801B220 : 0x36DFC; break; // Undernet 4
                        case 0x04: baseAddress = !lc? 0x801B348 : 0x36F00; break; // Undernet 5
                        case 0x05: baseAddress = !lc? 0x801B494 : 0x37028; break; // Undernet 6
                        case 0x06: baseAddress = !lc? 0x801B5D4 : 0x37144; break; // Undernet 7
                        case 0x07: baseAddress = !lc? 0x801B718 : 0x37264; break; // WWW Area 1
                        case 0x08: baseAddress = !lc? 0x801B844 : 0x3736C; break; // WWW Area 2
                        case 0x09: baseAddress = !lc? 0x801B990 : 0x37494; break; // WWW Area 3
                        case 0x11: baseAddress = !lc? 0x801BAE4 : 0x375C4; break; // Undernet 2 Special
                        case 0x14: baseAddress = !lc? 0x801BB58 : 0x37638; break; // Undernet 5 Special
                        case 0x16: baseAddress = !lc? 0x801BBD4 : 0x376B4; break; // Undernet 7 Special
                        case 0x17: baseAddress = !lc? 0x801BC50 : 0x37730; break; // WWW Area 1 Special
                        case 0x18: baseAddress = !lc? 0x801BCC4 : 0x377A4; break; // WWW Area 2 Special
                        case 0x19: baseAddress = !lc? 0x801BD40 : 0x37820; break; // WWW Area 3 Special
                        case 0x29: baseAddress = !lc? 0x801BE40 : 0x3789C; break; // WWW Area 3 Special 2 (note that Special 2 and 3 are in swapped order)
                        case 0x39: baseAddress = !lc? 0x801BDBC : 0x3789C; break; // WWW Area 3 Special 3 (only exists in GBA, so treat like Special 2 in LC)
                    }
                    break;
            }
            
            if (baseAddress == 0)
                return 0;
            
            if (!lc && language == "jp") // Offset from GBA English
                baseAddress -= 0x174;
            
            return (uint)(baseAddress);
        }
        
        public override Dictionary<int, string> getDefinedEncounters()
        {
            Dictionary<int, string> encounters = new Dictionary<int, string>();
            
            // Define "encounter IDs" (a thing I made up, not really a thing in-game) by combining area, subsection, and offset within that subsection.
            // (Subsections are only used for BN2 currently, because in BN2, offsets based on area alone are not consistent between GBA and LC.)
            int areaIDMult = 0x10000;
            int sectionIDMult = 0x100;
            
            int subarea1Special = 0x10 * sectionIDMult;
            int subarea2Special = 0x11 * sectionIDMult;
            int subarea5Special = 0x14 * sectionIDMult;
            int subarea7Special = 0x16 * sectionIDMult;
            int subarea8Special = 0x17 * sectionIDMult;
            int subarea9Special = 0x18 * sectionIDMult;
            int subarea10Special = 0x19 * sectionIDMult;
            int subarea10Special2 = 0x29 * sectionIDMult;
            
            int denAreaBase = 0x90 * areaIDMult;
            encounters[denAreaBase + subarea1Special + 0x40] = "AirMan V3";
            
            int kotoAreaBase = 0x91 * areaIDMult;
            encounters[kotoAreaBase + subarea1Special + 0x60] = "QuickMan V3";
            
            int yumlandAreaBase = 0x92 * areaIDMult;
            encounters[yumlandAreaBase + subarea2Special + 0x60] = "CutMan V3";
            
            int netopiaAreaBase = 0x93 * areaIDMult;
            encounters[netopiaAreaBase + subarea1Special + 0x60] = "KnightMan V3";
            
            int undernetWWWBase = 0x94 * areaIDMult;
            encounters[undernetWWWBase + subarea2Special + 0x60] = "MagnetMan V3";
            encounters[undernetWWWBase + subarea5Special + 0x68] = "ShadowMan V3";
            encounters[undernetWWWBase + subarea7Special + 0x68] = "FreezeMan V3";
            encounters[undernetWWWBase + subarea8Special + 0x60] = "PharaohMan V3";
            encounters[undernetWWWBase + subarea9Special + 0x68] = "NapalmMan V3";
            encounters[undernetWWWBase + subarea10Special + 0x68] = "PlanetMan V3"; // Also exists in Special2 and Special3 groups
            encounters[undernetWWWBase + subarea10Special2 + 0x70] = "Bass Deluxe"; // Also exists in Special3 group
            
            return encounters;
        }
        
        public override int saveAreaLengthGBA {get { return 0x3A78; } }
        public override int saveFileSizeLC {get { return 0x3A80; } }
        
        public override string getSubareaName(int area, int subarea, bool returnArea = false, bool fallbackIfNotFound = false)
        {
            switch (area)
            {
                case 0x00:
                    if (returnArea)
                        return "ACDC Town";
                    switch (subarea)
                    {
                        case 0x00: return "ACDC Town";
                        case 0x01: return "ACDC Station";
                        case 0x02: return "Lan's House";
                        case 0x03: return "Lan's Room";
                        case 0x04: return "Mayl's House";
                        case 0x05: return "Mayl's Room";
                        case 0x06: return "Dex's Room";
                        case 0x07: return "Yai's Room";
                        case 0x08: return "Yai's Bath";
                        case 0x09: return "Class 5-A";
                        case 0x0A: return "Yai's Hall";
                    }
                    break;
                
                case 0x01:
                    if (returnArea)
                        return "Marine Harbor";
                    switch (subarea)
                    {
                        case 0x00: return "Marine Harbor";
                        case 0x01: return "Marine Station";
                        case 0x02: return "Center Lobby";
                        case 0x03: return "Licence Office";
                        case 0x04: return "Exam Room";
                        case 0x05: return "Dad's Lab";
                        case 0x06: return "Mother Computer";
                    }
                    break;
                
                case 0x02:
                    if (returnArea)
                        return "Okuden Valley";
                    switch (subarea)
                    {
                        case 0x00: return "Okuden Station";
                        case 0x01: return "Camp Entrance";
                        case 0x02: return "Camp Road 1";
                        case 0x03: return "Camp Road 2";
                        case 0x04: return "Camp";
                        case 0x05: return "Okuden Dam";
                    }
                    break;
                
                case 0x03:
                    if (returnArea)
                        return "Den Airport";
                    switch (subarea)
                    {
                        case 0x00: return "Den Airport";
                        case 0x01: return "Den Airport Boarding";
                        case 0x02: return "Airport Station";
                    }
                    break;
                
                case 0x04:
                    if (returnArea)
                        return "Net Airport";
                    switch (subarea)
                    {
                        case 0x00: return "Net Airport";
                        case 0x01: return "Net Airport Boarding";
                    }
                    break;
                
                case 0x05:
                    if (returnArea)
                        return "Netopia";
                    switch (subarea)
                    {
                        case 0x00: return "Netopia Park";
                        case 0x01: return "Netopia Town";
                        case 0x02: return "Netopia Backstreet";
                        case 0x03: return "Hotel Room";
                        case 0x04: return "Jewelry Shop";
                        case 0x05: return "Net Castle";
                        case 0x06: return "Banquet Room";
                        case 0x07: return "Trap Room";
                        case 0x08: return "Arrow Room";
                        case 0x09: return "Ceiling Room";
                        case 0x0A: return "Lower Stairs";
                        case 0x0B: return "Fire Room";
                        case 0x0C: return "Confusion Room";
                        case 0x0D: return "Aboveground";
                        case 0x0E: return "Watchtower";
                    }
                    break;
                
                case 0x06:
                    if (returnArea)
                        return "Airplane";
                    switch (subarea)
                    {
                        case 0x00: return "Crew Room";
                        case 0x01: return "Economy";
                        case 0x02: return "Business";
                        case 0x03: return "First Class";
                        case 0x04: return "Cockpit";
                    }
                    break;
                
                case 0x07:
                    if (returnArea)
                        return "Kotobuki Town";
                    switch (subarea)
                    {
                        case 0x00: return "Kotobuki";
                        case 0x01: return "Apartments 1F";
                        case 0x02: return "Apartments 2F";
                        case 0x03: return "Apartments 8F";
                        case 0x04: return "Apartments 25F";
                        case 0x05: return "Apartments 27F";
                        case 0x06: return "Apartments 4F";
                        case 0x07: return "Apartments 9F";
                        case 0x08: return "Apartments 20F";
                        case 0x09: return "Apartments 23F";
                        case 0x0A: return "Apartments 24F";
                        case 0x0B: return "Apartments 30F";
                    }
                    break;
                
                case 0x08:
                    if (returnArea)
                        return "Kotobuki Apartment Rooms";
                    switch (subarea)
                    {
                        case 0x00: return "Penthouse";
                        case 0x01: return "Last Room";
                        case 0x02: return "Room 021";
                        case 0x03: return "Room 082";
                        case 0x04: return "Room 253";
                        case 0x05: return "Room 271";
                        case 0x06: return "Room 042";
                        case 0x07: return "Room 093";
                        case 0x08: return "Room 201";
                        case 0x09: return "Room 232";
                        case 0x0A: return "Room 243";
                    }
                    break;
                
                case 0x80:
                    if (returnArea)
                        return "Gas Comp";
                    switch (subarea)
                    {
                        case 0x00: return "Gas Comp 1";
                        case 0x01: return "Gas Comp 2";
                    }
                    break;
                
                case 0x81:
                    if (returnArea)
                        return "Bomb Comp";
                    switch (subarea)
                    {
                        case 0x00: return "Bomb Comp 1";
                        case 0x01: return "Bomb Comp 2";
                        case 0x02: return "Bomb Comp 3";
                        case 0x03: return "Bomb Comp 4";
                    }
                    break;
                
                case 0x82:
                    if (returnArea)
                        return "Mother Comp";
                    switch (subarea)
                    {
                        case 0x00: return "Mother Comp 1";
                        case 0x01: return "Mother Comp 2";
                        case 0x02: return "Mother Comp 3";
                        case 0x03: return "Mother Comp 4";
                        case 0x04: return "Mother Comp 5";
                    }
                    break;
                
                case 0x83:
                    if (returnArea)
                        return "Castle Comp";
                    switch (subarea)
                    {
                        case 0x00: return "Castle Comp 1";
                        case 0x01: return "Castle Comp 2";
                        case 0x02: return "Castle Comp 3";
                        case 0x03: return "Castle Comp 4";
                        case 0x04: return "Castle Comp 5";
                    }
                    break;
                
                case 0x84:
                    if (returnArea)
                        return "Air Comp";
                    switch (subarea)
                    {
                        case 0x00: return "Air Comp 1";
                        case 0x01: return "Air Comp 2";
                        case 0x02: return "Air Comp 3";
                        case 0x03: return "Air Comp 4";
                        case 0x04: return "Air Comp 5";
                    }
                    break;
                
                case 0x85:
                    if (returnArea)
                        return "Apartment Comp";
                    switch (subarea)
                    {
                        case 0x00: return "Apartment Comp 1";
                        case 0x01: return "Apartment Comp 2";
                        case 0x02: return "Apartment Comp 3";
                        case 0x03: return "Apartment Comp 4";
                        case 0x04: return "Gosp Server 1";
                        case 0x05: return "Gosp Server 2";
                    }
                    break;
                
                case 0x88:
                    if (returnArea)
                        return "Home Pages";
                    switch (subarea)
                    {
                        case 0x00: return "Lan's PC";
                        case 0x01: return "Mayl's PC";
                        case 0x02: return "Dex's PC";
                        case 0x03: return "Yai's PC";
                        case 0x04: return "Ribitta's Van";
                        case 0x05: return "Raoul's Radio";
                        case 0x06: return "Millions's Bag";
                    }
                    break;
                
                case 0x8C:
                    if (returnArea)
                        return "Cyberworlds A";
                    switch (subarea)
                    {
                        case 0x00: return "Blackboard Comp";
                        case 0x01: return "Broken Toy Comp";
                        case 0x02: return "Doghouse Comp";
                        case 0x03: return "Control Panel Comp";
                        case 0x04: return "Piano Comp";
                        case 0x05: return "Coffee Machine Comp";
                        case 0x06: return "Portable Game Comp";
                        case 0x07: return "Telephone Comp";
                        case 0x08: return "Guardian Comp";
                        case 0x09: return "Gas Stove Comp";
                        case 0x0A: return "Bear Comp";
                        case 0x0B: return "Monitor Comp";
                        case 0x0C: return "Wide Monitor Comp";
                        case 0x0D: return "Flight Board Comp";
                        case 0x0E: return "Gift Shop Comp";
                        case 0x0F: return "Bronze Statue Comp";
                    }
                    break;
                
                case 0x8D:
                    if (returnArea)
                        return "Cyberworlds B";
                    switch (subarea)
                    {
                        case 0x00: return "Refrigerator Comp";
                        case 0x01: return "Goddess Comp";
                        case 0x02: return "Television Comp";
                        case 0x03: return "Vending Machine Comp";
                        case 0x04: return "Autolock Comp";
                    }
                    break;
                
                case 0x90:
                    if (returnArea)
                        return "Den Area";
                    switch (subarea)
                    {
                        case 0x00: return "Den Area 1";
                        case 0x01: return "Den Area 2";
                        case 0x02: return "Den Area 3";
                        case 0x03: return "Square Entrance";
                        case 0x04: return "The Square";
                        case 0x05: return "BBS Room";
                    }
                    break;
                
                case 0x91:
                    if (returnArea)
                        return "Koto Area";
                    switch (subarea)
                    {
                        case 0x00: return "Koto Area";
                        case 0x01: return "UnderKoto";
                        case 0x02: return "KotoSquare Entrance";
                        case 0x03: return "KotoSquare 1";
                        case 0x04: return "KotoSquare 2";
                        case 0x05: return "Gospel HQ";
                    }
                    break;
                
                case 0x92:
                    if (returnArea)
                        return "Yumland Area";
                    switch (subarea)
                    {
                        case 0x00: return "Yumland Area 1";
                        case 0x01: return "Yumland Area 2";
                        case 0x02: return "YumSquare Entrance";
                        case 0x03: return "YumSquare";
                        case 0x04: return "Treasure Room";
                    }
                    break;
                
                case 0x93:
                    if (returnArea)
                        return "Netopia Area";
                    switch (subarea)
                    {
                        case 0x00: return "Netopia Area 1";
                        case 0x01: return "Netopia Area 2";
                        case 0x02: return "Netopia Area 3";
                        case 0x03: return "NetSquare Entrance";
                        case 0x04: return "NetSquare";
                    }
                    break;
                
                case 0x94:
                    if (returnArea)
                        return "Undernet";
                    switch (subarea)
                    {
                        case 0x00: return "Undernet 1";
                        case 0x01: return "Undernet 2";
                        case 0x02: return "Undernet 3";
                        case 0x03: return "Undernet 4";
                        case 0x04: return "Undernet 5";
                        case 0x05: return "Undernet 6";
                        case 0x06: return "Undernet 7";
                        case 0x07: return "WWW Area 1";
                        case 0x08: return "WWW Area 2";
                        case 0x09: return "WWW Area 3";
                        case 0x0A: return "UnderSquare Entrance";
                        case 0x0B: return "UnderSquare";
                        case 0x0C: return "UnderBBS";
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
                case 0x01: return "Secret Maneuvers";
                case 0x02: return "ACDC Town";
                case 0x03: return "ACDC School";
                case 0x04: return "Inside House";
                case 0x05: return "Okuden Valley";
                case 0x06: return "Marine Harbor";
                case 0x07: return "Official Center";
                case 0x08: return "Airport (Begin a Journey)";
                case 0x09: return "Netopia Town (Busy Street of a Foreign Country)";
                case 0x0A: return "Netopia Castle";
                case 0x0B: return "Airplane (Sky Travel)";
                case 0x0C: return "Kotobuki (Determination in the Heart)";
                case 0x0D: return "Suspicious Mood";
                case 0x0E: return "Incident Occurrence!";
                case 0x0F: return "Vicinity of Sorrow";
                case 0x10: return "Proof of Courage";
                case 0x11: return "Transmission!";
                case 0x12: return "Gas Comp (Smoky Field)";
                case 0x13: return "Bomb Comp (Time Limit)";
                case 0x14: return "Mother Computer (A Serious Mission)";
                case 0x15: return "Castle Comp (Fear in the Castle)";
                case 0x16: return "Air Comp (Magnetic Airplane)";
                case 0x17: return "Apartment Comp (You Can't Go Back)";
                case 0x18: return "Internet (Internet World)";
                case 0x19: return "Undernet (Fearful)";
                case 0x1A: return "WWW Area (And You Will Know the Truth)";
                case 0x1B: return "Virus Battle (Virus Busting)";
                case 0x1C: return "Boss Battle";
                case 0x1D: return "VS Gospel";
                case 0x1E: return "Victory!";
                case 0x1F: return "Style Change";
                case 0x20: return "Loser";
                case 0x21: return "Game Over";
                case 0x22: return "Boss Encounter (Pressure)";
                case 0x23: return "Back Alley";
                case 0x24: return "Underground Prison";
                case 0x25: return "Credits (Peace Again)";
            }
            
            return fallbackIfNotFound? "[" + music.ToString("X2") + "]" : "";
        }
        
        public override string getStyleName(int style, bool fallbackIfNotFound = false, bool includeLevel = true)
        {
            int level = 1;
            if (style >= 0x40)
            {
                level += style / 0x40;
                style = style % 0x40;
            }
            string levelStr = level > 1 && includeLevel? "V" + level : "";
            
            switch (style)
            {
                case 0x00: return "NormStyl" + levelStr;
                case 0x09: return "ElecGuts" + levelStr;
                case 0x0A: return "HeatGuts" + levelStr;
                case 0x0B: return "AquaGuts" + levelStr;
                case 0x0C: return "WoodGuts" + levelStr;
                case 0x11: return "ElecCust" + levelStr;
                case 0x12: return "HeatCust" + levelStr;
                case 0x13: return "AquaCust" + levelStr;
                case 0x14: return "WoodCust" + levelStr;
                case 0x19: return "ElecTeam" + levelStr;
                case 0x1A: return "HeatTeam" + levelStr;
                case 0x1B: return "AquaTeam" + levelStr;
                case 0x1C: return "WoodTeam" + levelStr;
                case 0x21: return "ElecShld" + levelStr;
                case 0x22: return "HeatShld" + levelStr;
                case 0x23: return "AquaShld" + levelStr;
                case 0x24: return "WoodShld" + levelStr;
                case 0x28: return "HubStyle" + levelStr;
            }
            
            return fallbackIfNotFound? "Style #" + style + " " + levelStr : "";
        }
        
        public static string getRegisteredStyleName(int styleIndex, int level = 1, bool includeLevel = true)
        {
            string levelStr = level > 1 && includeLevel? "V" + level : "";
            
            switch (styleIndex)
            {
                case 0x00: return "NormStyl";
                case 0x06: return "ElecGuts" + levelStr;
                case 0x07: return "HeatGuts" + levelStr;
                case 0x08: return "AquaGuts" + levelStr;
                case 0x09: return "WoodGuts" + levelStr;
                case 0x0B: return "ElecCust" + levelStr;
                case 0x0C: return "HeatCust" + levelStr;
                case 0x0D: return "AquaCust" + levelStr;
                case 0x0E: return "WoodCust" + levelStr;
                case 0x10: return "ElecTeam" + levelStr;
                case 0x11: return "HeatTeam" + levelStr;
                case 0x12: return "AquaTeam" + levelStr;
                case 0x13: return "WoodTeam" + levelStr;
                case 0x14: return "ElecShld" + levelStr;
                case 0x15: return "HeatShld" + levelStr;
                case 0x16: return "AquaShld" + levelStr;
                case 0x17: return "WoodShld" + levelStr;
                case 0x19: return "HubStyle";
            }
            return "";
        }
        
        public override string getEmailName(int email, bool fallbackIfNotFound = false)
        {
            switch (email)
            {
                case 0: return "More viruses! (MailNews)";
                case 1: return "Use Roll... (Mayl)";
                case 2: return "Passport (Dad)";
                case 3: return "Come to lab (Dad)";
                case 4: return "Hurry up! (Dex)";
                case 5: return "My PC code (Mayl)";
                case 6: return "Exam info (Center)";
                case 7: return "Find 4 bombs! (Chaud)";
                case 8: return "Bomb program (Chaud)";
                case 9: return "Let's camp!!! (Dex)";
                case 10: return "Surely not? (Yai)";
                case 11: return "OK to camp (Mayl)";
                case 12: return "No thanks. (Chaud)";
                case 13: return "Yer late! (Dex)";
                case 14: return "Your FreePass (NAL)";
                case 15: return "More damage (MailNews)";
                case 16: return "This help? (Mayl)";
                case 17: return "Report (Chaud)";
                case 18: return "Major quake (MailNews)";
                case 19: return "It's OK now (Dad)";
                case 20: return "Global conf. (ONB HQ)";
                case 21: return "Roll is lost! (Mayl)";
                case 22: return "Challenge me! (Famous)";
                case 23: return "Folder usage! (Famous)";
                case 24: return "Chip trader! (Unknown)";
                case 25: return "Station bomb? (MailNews)";
                case 26: return "Yes, souvenir (Yai)";
                case 27: return "Some cash (Mom)";
                case 28: return "Secret conf. (ONB HQ)";
                case 29: return "City NetBattlers (Center)";
                case 30: return "Retro, huh! (Unknown)";
                case 31: return "GutsStyle info (Dad)";
                case 32: return "CustStyle info (Dad)";
                case 33: return "TeamStyle info (Dad)";
                case 34: return "ShieldStyle info (Dad)";
                case 35: return "HubStyle info (Dad)";
            }
            
            return fallbackIfNotFound? "Email #" + email : "";
        }
        
        public override string getBBSPost(int bbs, int post, bool fallbackIfNotFound = false)
        {
            switch (bbs)
            {
                case 0: // Job BBS
                    switch (post)
                    {
                        case 0: return "Special Op 1";
                        case 1: return "Special Op 2";
                        case 2: return "Special Op 3";
                        case 3: return "Finding someone";
                        case 4: return "At the cafe";
                        case 5: return "Chip please!";
                        case 6: return "Restore order";
                        case 7: return "For the observant";
                        case 8: return "I'll pay up front";
                        case 9: return "Need a Cupid";
                        case 10: return "For male pride";
                        case 11: return "Help research";
                        case 12: return "Sell me a chip!";
                        case 13: return "Help reconcile us";
                        case 14: return "Please help";
                        case 15: return "Lend me cash!";
                        case 16: return "Insect academics";
                        case 17: return "Recover my jewels!";
                    }
                    break;
                
                case 1: // Battle BBS
                    switch (post)
                    {
                        case 0: return "Cuckoo - Trade info!";
                        case 1: return "Vanessa - Virus info!";
                        case 2: return "NaviNavi - Mettaur strat";
                        case 3: return "Akira - Regular Chip";
                        case 4: return "ShyBoy - Not yet...";
                        case 5: return "Noogie - On the Net...";
                        case 6: return "Baldy - I saw it too!";
                        case 7: return "Cuckoo - Techniques";
                        case 8: return "Akira - \"Atk+10\"";
                        case 9: return "Chuck - Busting Level";
                        case 10: return "Mickey - Sword rumor";
                        case 11: return "Skeeter - Is it true?";
                        case 12: return "Santa - What to pick?";
                        case 13: return "Noogie - You mean...";
                        case 14: return "Pow! - Virus info!";
                        case 15: return "Servbot - Asterisk!";
                        case 16: return "Kenny - Heard this?";
                        case 17: return "Hoss - Could it be?";
                        case 18: return "Yaz - No kidding?!";
                        case 19: return "Hoss - Re: No kidding";
                        case 20: return "Baldy - DashAtk??";
                        case 21: return "Noogie - Re: DashAtk??";
                        case 22: return "Akira - Busting Level";
                        case 23: return "Famous - Re: Busting Level";
                        case 24: return "Hoss - Mr. Famous?!";
                        case 25: return "Skeeter - Re: Mr. Famous?!";
                        case 26: return "Yaz - My deck";
                        case 27: return "Pow! - Re: My deck";
                        case 28: return "Dex - Re: My deck";
                        case 29: return "Santa - Breaking thru";
                        case 30: return "Hoss - Re: Breaking thru";
                        case 31: return "Skeeter - Re: Breaking thru";
                        case 32: return "Baldy - RockCube";
                        case 33: return "Noogie - Re: RockCube";
                        case 34: return "Mickey - Re: RockCube";
                        case 35: return "Noogie - A huge hint";
                        case 36: return "Baldy - I got it!";
                        case 37: return "Famous - Try this too";
                        case 38: return "Cuckoo - Re: Try this too";
                        case 39: return "Dex - Lacking...?";
                        case 40: return "Famous - Re: Lacking...?";
                        case 41: return "Pow! - Great chip?";
                        case 42: return "Kenny - Re: Great chip?";
                        case 43: return "Pow! - Re: Great chip?";
                        case 44: return "Skeeter - Grass panels";
                        case 45: return "Yaz - Re: Grass panels";
                        case 46: return "Servbot - Lava panels";
                        case 47: return "Kenny - Re: Lava panels";
                        case 48: return "ShyBoy - CustomSword";
                        case 49: return "Noogie - Re: CustomSword";
                        case 50: return "ShyBoy - Cool!";
                        case 51: return "Marble - Weird ice";
                        case 52: return "NaviNavi - Re: Weird ice";
                        case 53: return "Marble - On the ice";
                        case 54: return "Kenny - [Fire] element";
                        case 55: return "Hoss - P.A. info";
                        case 56: return "Cuz=P - Re: P.A. info";
                        case 57: return "Yaz - Re: P.A. info";
                        case 58: return "Hoss - You got it?";
                        case 59: return "Yaz - P.A. info 2";
                        case 60: return "Mr. Beltz - Re: P.A. info 2";
                        case 61: return "Elmo - FighterSwords";
                        case 62: return "Famous - Mystery chip";
                    }
                    break;
                
                case 2: // Street BBS
                    switch (post)
                    {
                        case 0: return "MegaMan - Info wanted!";
                        case 1: return "Grimace - To MegaMan";
                        case 2: return "IronMan - Prog. expert";
                        case 3: return "Tiger - These days...";
                        case 4: return "Alice - A rumor...";
                        case 5: return "Crow - Who is Doc?";
                        case 6: return "Vishnu - Re: Who is Doc?";
                        case 7: return "Vishnu - Hi, everyone!";
                        case 8: return "Tiger - This BBS...";
                        case 9: return "Roll - Hello!";
                        case 10: return "GutsMan - Gutttsssss...";
                        case 11: return "Admin - The Net (#1)";
                        case 12: return "Admin - The Net (#2)";
                        case 13: return "Marble - ACDC Town!";
                        case 14: return "Alice - Kotobuki rlz!";
                        case 15: return "Maple - Chip shops";
                        case 16: return "Scummy - Chip trader?";
                        case 17: return "Oozy - Re: Chip trader?";
                        case 18: return "Yaz - Wow!";
                        case 19: return "Zack - Camping";
                        case 20: return "Baldy - Re: Camping";
                        case 21: return "Roll - Re: Camping";
                        case 22: return "Yaz - Traders again";
                        case 23: return "Crow - Re: Traders again";
                        case 24: return "Mr. Beltz - Mystery data";
                        case 25: return "Admin - Re: Mystery data";
                        case 26: return "Mr. Beltz - Re: Mystery data";
                        case 27: return "Alice - Camp entrance";
                        case 28: return "Mickey - Traveling!";
                        case 29: return "Zoot - Re: Traveling!";
                        case 30: return "Mickey - Re: Traveling!";
                        case 31: return "Mr. Ted - Netopia";
                        case 32: return "Mickey - That was fun!";
                        case 33: return "Mickey - Very fun!!!";
                        case 34: return "Zoot - Traders...";
                        case 35: return "Mr. Ted - Well, I'm back";
                        case 36: return "Mr. Ted - Still back";
                        case 37: return "Marble - It's like...";
                        case 38: return "Scummy - Ice?";
                        case 39: return "Tiger - Re: Ice?";
                        case 40: return "Maple - Den Area";
                        case 41: return "Vishnu - Re: Den Area";
                        case 42: return "Zoot - Those traders";
                        case 43: return "Yaz - Re: Those traders";
                        case 44: return "Crow - Trading chips";
                        case 45: return "Quiz-giver - Baldy";
                        case 46: return "Marble - More Kotobuki";
                    }
                    break;
                
                case 3: // Virus BBS
                    switch (post)
                    {
                        case 0: return "Cuz=P - Virus info!";
                        case 1: return "Comicker - Bunny";
                        case 2: return "Oozy - Re: Bunny";
                        case 3: return "Dex - Beetank";
                        case 4: return "IronMan - Re: Beetank";
                        case 5: return "Ms.Tater - HardHead";
                        case 6: return "Noogie - Re: HardHead";
                        case 7: return "Ms.Tater - Re: HardHead";
                        case 8: return "Oozy - Re: HardHead";
                        case 9: return "Ms.Tater - Re: HardHead";
                        case 10: return "Amayan - Dominerd";
                        case 11: return "Skeeter - Re: Dominerd";
                        case 12: return "Grimace - Viruses...";
                        case 13: return "Koetsu - Dominerd strats";
                        case 14: return "Vishnu - Mushy";
                        case 15: return "Crow - Flamey";
                        case 16: return "Noogie - Re: Flamey";
                        case 17: return "Hoss - Octon";
                        case 18: return "Koetsu - Re: Octon";
                        case 19: return "Cuckoo - Bagworm?";
                        case 20: return "Santa - Re: Bagworm?";
                        case 21: return "Cuckoo - Re: Bagworm?";
                        case 22: return "Sarah - Auras...";
                        case 23: return "Tiger - Re: Auras...";
                        case 24: return "Amayan - Re: Auras...";
                        case 25: return "Sarah - Re: Auras...";
                        case 26: return "Admin - Forbidden";
                        case 27: return "Cuz=P - Everyone!";
                        case 28: return "Elmo - [Elec] element";
                        case 29: return "Zoot - Re: [Elec] element";
                        case 30: return "Scummy - Re: [Elec] element";
                        case 31: return "Grimace - KillPlants";
                        case 32: return "Amayan - Shrimpy";
                        case 33: return "Koetsu - Combo strats 1";
                        case 34: return "Koetsu - Combo strats 2";
                        case 35: return "Cuckoo - What to do...";
                        case 36: return "Kevin - Ratty";
                        case 37: return "Alice - Re: Ratty";
                        case 38: return "Mazeltov - MotherComp";
                        case 39: return "Mr. Beltz - Re: MotherComp";
                        case 40: return "Mary - Re: MotherComp";
                        case 41: return "Mr. Beltz - DataLibrary";
                        case 42: return "Crow - Re: DataLibrary";
                        case 43: return "Baldy - Ice...";
                        case 44: return "Scummy - Re: Ice...";
                        case 45: return "Putzy - Re: Ice...";
                        case 46: return "IronMan - From Kotobuki";
                        case 47: return "Kevin - Re: From Kotobuki";
                        case 48: return "Santa - Uber virus!";
                        case 49: return "Vishnu - Re: Uber virus!";
                        case 50: return "Cuckoo - Re: Uber virus!";
                        case 51: return "Cuz=P - Re: Uber virus!";
                        case 52: return "Koetsu - Re: Uber virus!";
                        case 53: return "Comicker - LifeVirus";
                        case 54: return "Oozy - Re: LifeVirus";
                        case 55: return "Amayan - Re: LifeVirus";
                        case 56: return "NO NAME - LifeVirus...";
                        case 57: return "Hoss - Mischief?";
                        case 58: return "Chuck - Please delete";
                        case 59: return "Crow - Maybe...";
                        case 60: return "Admin - Notice";
                        case 61: return "Yaz - Re: Notice";
                        case 62: return "Koetsu - Virus busting";
                    }
                    break;
                
                case 4: // Chat BBS
                    switch (post)
                    {
                        case 0: return "Egghead - Just chat!";
                        case 1: return "Suzie - Hi there!";
                        case 2: return "Chuck - My ZLicense!";
                        case 3: return "Ms.Tater - CyberSquare?";
                        case 4: return "Mary - Kotobuki too";
                        case 5: return "Koetsu - I'm gonna...";
                        case 6: return "Ms.Tater - Best for date";
                        case 7: return "Koetsu - I got it!";
                        case 8: return "Sarah - Marine Harbor";
                        case 9: return "Zack - Ms. Ribitta...";
                        case 10: return "Egghead - In that van";
                        case 11: return "Vishnu - Camp incident";
                        case 12: return "Marble - NetBattles...";
                        case 13: return "Scummy - Can it be?!";
                        case 14: return "Oozy - NetBattle, eh";
                        case 15: return "Amayan - On Yumland";
                        case 16: return "Servbot - What's wrong?";
                        case 17: return "Oopsy - Center people";
                        case 18: return "Admin - From Admin";
                        case 19: return "Baldy - Good luck!";
                        case 20: return "Cuz=P - A close one!";
                        case 21: return "Oozy - Yumland";
                        case 22: return "Elmo - Did you hear?";
                        case 23: return "Grimace - Chip Traders";
                        case 24: return "Baldy - Re: Chip Traders";
                        case 25: return "Scummy - Re: Chip Traders";
                        case 26: return "Hoss - ACDC chips";
                        case 27: return "Zack - Battler mtng!";
                        case 28: return "Alice - Bug symposium";
                        case 29: return "Amayan - On Netopia";
                        case 30: return "Baldy - Re: On Netopia";
                        case 31: return "Rover - My husband";
                        case 32: return "Tommy - Exchange student";
                        case 33: return "Cuz=P - Gauss arrest!";
                        case 34: return "Vishnu - Re: Gauss arrest!";
                        case 35: return "Koetsu - Re: Gauss arrest!";
                        case 36: return "Yaz - Re: Gauss arrest!";
                        case 37: return "Egghead - Re: Gauss arrest!";
                        case 38: return "Noogie - Scary quake!";
                        case 39: return "Amayan - Gospel...";
                        case 40: return "Mickey - The quakes";
                        case 41: return "Zoot - From Kotobuki";
                        case 42: return "Marble - Re: From Kotobuki";
                        case 43: return "Scummy - Re: From Kotobuki";
                    }
                    break;
                
                case 5: // Secret Info BBS
                    switch (post)
                    {
                        case 0: return "K.I. - Secret BBS!";
                        case 1: return "Gummy - Ice Navi?";
                        case 2: return "Kramer - Re: Ice Navi?";
                        case 3: return "Informer - The Ice Navi";
                        case 4: return "Claude - Gospel gone?!";
                        case 5: return "Informer - Blue Navi";
                        case 6: return "Kramer - Re: Blue Navi";
                        case 7: return "K.I. - Strange Navis";
                        case 8: return "NO NAME - Heheheee...";
                        case 9: return "Cindy - Yeesh...";
                        case 10: return "DarkWar - Info wanted!";
                        case 11: return "Gummy - Re: Info wanted!";
                        case 12: return "hAcKeR - Virus profits";
                        case 13: return "Enforcer - Famous";
                        case 14: return "Cindy - Re: Famous";
                        case 15: return "Kramer - PA w/ Navi?";
                        case 16: return "Cindy - Re: PA w/ Navi?";
                        case 17: return "SirBaldy - Re: PA w/ Navi?";
                        case 18: return "Cindy - ShadowMan's?";
                        case 19: return "SirBaldy - Re: ShadowMan's?";
                        case 20: return "DarkWar - Ceiling?";
                        case 21: return "K.I. - Bagworm, eh?";
                        case 22: return "Informer - Command chips";
                        case 23: return "Kitty - Re: Command chips";
                        case 24: return "Peon - Cloak Navi";
                        case 25: return "CrAcKeR - Re: Cloak Navi";
                        case 26: return "Peon - Re: Cloak Navi";
                        case 27: return "CannonB - Re: Cloak Navi";
                        case 28: return "Claude - Re: Cloak Navi";
                        case 29: return "Informer - SuperNavi?";
                        case 30: return "SirBaldy - Re: SuperNavi?";
                        case 31: return "CannonB - Programs";
                    }
                    break;
                
                case 6: // Undernet Info BBS
                    switch (post)
                    {
                        case 0: return "MegaMan.EXE - To Doc";
                        case 1: return "Shredder - Gimme dirt!";
                        case 2: return "Killer - Rumor 1";
                        case 3: return "Deleter - Rumor 2";
                        case 4: return "IronBear - Re: Rumor 2";
                        case 5: return "RareChip - Re: Rumor 2";
                        case 6: return "Claude - Re: Rumor 2";
                        case 7: return "Assassin - Rumor 3";
                        case 8: return "IronBear - Re: Rumor 3";
                        case 9: return "Deleter - Re: Rumor 3";
                        case 10: return "IronBear - Re: Rumor 3";
                        case 11: return "Killer - Rumor 4";
                        case 12: return "Cueball - A rumor?";
                        case 13: return "Claude - The Doc";
                        case 14: return "IronBear - Re: The Doc";
                        case 15: return "Cueball - The blue Navi";
                        case 16: return "Deleter - Rumor 5";
                        case 17: return "IronBear - Re: Rumor 5";
                        case 18: return "Claude - Re: Rumor 5";
                        case 19: return "RareChip - Re: Rumor 5";
                        case 20: return "ExWWWNav - Re: Rumor 5";
                        case 21: return "Assassin - Re: Rumor 5";
                        case 22: return "Demon - Rumor 6";
                        case 23: return "Claude - Re: Rumor 6";
                        case 24: return "Killer - Rumor 7";
                        case 25: return "Naviman - Rumor 8";
                        case 26: return "TheSneak - Rumor 9";
                        case 27: return "Claude - Re: Rumor 9";
                        case 28: return "If you...";
                        case 29: return "read this...";
                        case 30: return "you will...";
                        case 31: return "be deleted...";
                    }
                    break;
            }
            
            return fallbackIfNotFound? "Post #" + (post + 1) : "";
        }
        
        public override string getShopName(int shop, bool fallbackIfNotFound = false)
        {
            switch (shop)
            {
                case 0: return "Den Area 1 NetDealer";
                case 1: return "Netopia 2 NetDealer";
                case 2: return "Den Area 3 NetDealer";
                case 3: return "The Square NetDealer";
                case 4: return "The Square SubChip dealer";
                case 5: return "UnderKoto NetDealer";
                case 6: return "KotoSquare NetDealer";
                case 7: return "KotoSquare SubChip dealer";
                case 8: return "Yumland 1 NetDealer";
                case 9: return "NumberMan";
                case 10: return "NetSquare NetDealer";
                case 11: return "NetSquare SubChip dealer";
                case 12: return "Undernet 1 NetDealer";
                case 13: return "Unused shop";
                case 14: return "UnderSquare NetDealer";
                case 15: return "UnderSquare SubChip dealer";
                case 16: return "ACDC Town SubChip dealer";
                case 17: return "Okuden Dam SubChip dealer";
                case 18: return "Center Lobby SubChip dealer";
                case 19: return "NetCastle SubChip dealer";
                case 20: return "Airplane TV SubChip dealer";
                case 21: return "WWW Area 1 NetDealer";
                case 22: return "Koto Square BugFrag Trader";
            }
            
            return fallbackIfNotFound? "Shop #" + (shop + 1) : "";
        }
        
        public override string getChapterDesc(int chapter)
        {
            switch (chapter)
            {
                case 0: return "Start of game";
                case 71: return "Reached top floor of apartments (endgame)";
                case 72: return "After entering Gospel Server";
            }
            return "";
        }
        
        public override string getFlagDesc(int flag)
        {
            if (flag >= 768 && flag <= 1031) // Library chip flags
            {
                string chipName = getChipName(flag - 768, false);
                if (chipName == "")
                    chipName = "(UNUSED)";
                return "Library chip flag: " + chipName;
            }
            else if (flag >= 1248 && flag <= 1279) // Library PA flags
            {
                string paName = getPAName(flag - 1248, false);
                if (paName == "")
                    paName = "(UNUSED)";
                return "Library PA flag: " + paName;
            }
            else if (flag >= 1792 && flag <= 1827) // Emails
                return "Email: " + getEmailName(flag - 1792, true);
            else if (flag >= 1920 && flag <= 1955) // Emails unread
                return "Email unread: " + getEmailName(flag - 1920, true);
            else if (flag >= 2176 && flag <= 3199) // BBS posts, BBS posts unread
            {
                bool unreadFlag = flag >= 2688;
                int startFlag = !unreadFlag? 2176 : 2688;
                int bbsNum = (flag - startFlag) / 64;
                int postNum = (flag - startFlag) % 64;
                if (bbsNum < bbsNames.Length)
                    return "Post" + (unreadFlag? " unread" : "") + ": " + bbsNames[bbsNum] + ", " + getBBSPost(bbsNum, postNum, true);
            }
            else if (flag >= 3200 && flag <= 3217) // Job complete
                return "Job complete: " + getBBSPost(0, flag - 3200, true);
            else if (flag >= 3264 && flag <= 3281) // Job taken
                return "Job taken: " + getBBSPost(0, flag - 3264, true);
            
            switch (flag)
            {
                case 4: return "Game clear flag";
                
                case 42: return "Will get style change after next victory (set at 280 battles)";
                
                case 82: return "Job BBS request active";
                
                case 183: return "Beat GateMan for the first time (reward: HPMemory)";
                case 199: return "Beat HeatMan for the first time (reward: HPMemory)";
                
                case 230: return "Completed SSLicense exam (reward: RegUP1)";
                case 240: return "Completed SSSLicense exam (reward: RegUP1)";
                
                case 258: return "Traded Invis1 * for Escape N on Camp Road 1 (gives bonus HPMemory)";
                
                case 274: return "Defeated Quiz Master in Net Castle Banquet Room (reward: HPMemory)";
                case 280: return "Defeated Quiz King in Net Castle Arrow Room (reward: RegUP3)";
                
                case 319: return "Marine Harbor Dad's Lab coat PowerUP";
                case 320: return "Netopia Hotel Room fridge HPMemory";
                case 321: return "Netopia Backstreet dumpster RegUP2";
                case 322: return "Net Airport Boarding postcards RegUP2";
                case 323: return "Airplane Business Class curtains HPMemory";
                case 324: return "Kotobuki Apartments 9F west doorknob HPMemory";
                case 325: return "Netopia Park trees hidden kid SubMem";
                case 326: return "Okuden Valley Camp Road 2 hidden old woman RegUP2";
                case 327: return "Marine Harbor Mother Computer room hidden Mr. Prog PowerUP";
                
                case 552: return "Completed ALicense exam (reward: RegUP2)";
                
                // 768-1031: Library chip flags
                // 1248-1279: Library PA flags
                
                case 1294: return "PMD: Den Area 3 PowerUP";
                case 1309: return "BMD: Yumland Area 1 RegUP1";
                case 1323: return "BMD: Gas Comp 2 HPMemory";
                case 1324: return "BMD: Gas Comp 2 RegUP1";
                case 1333: return "BMD: Bomb Comp 2 HPMemory";
                case 1338: return "BMD: Bomb Comp 3 RegUP2";
                case 1343: return "BMD: Bomb Comp 4 PowerUP";
                case 1346: return "BMD: Mother Comp 1 HPMemory";
                case 1351: return "BMD: Mother Comp 2 RegUP1";
                case 1364: return "BMD: Mother Comp 5 RegUP2";
                case 1373: return "BMD: Yai's HP HPMemory";
                case 1383: return "BMD: ACDC Town Broken Toy Comp RegUP1";
                case 1390: return "BMD: Mayl's Piano Comp RegUP1";
                case 1391: return "BMD: Mayl's Piano Comp HPMemory";
                case 1393: return "BMD: Marine Harbor Coffee Machine Comp RegUP1";
                case 1397: return "BMD: Yai's House Telephone Comp RegUP1";
                case 1399: return "BMD: Okuden Valley Guardian Comp HPMemory";
                case 1403: return "BMD: Okuden Valley Bear Comp RegUP1";
                case 1405: return "BMD: Marine Harbor Monitor Comp RegUP2";
                case 1425: return "BMD: Kotobuki Vending Machine Comp RegUP3";
                case 1437: return "BMD: Netopia Area 3 HPMemory";
                case 1444: return "BMD: Castle Comp 1 HPMemory";
                case 1452: return "BMD: Castle Comp 3 SubMem";
                case 1469: return "BMD: Castle Comp 3 RegUP1";
                case 1473: return "BMD: Castle Comp 4 PowerUP";
                case 1485: return "BMD: Apartment Comp 1 RegUP1";
                case 1491: return "BMD: Apartment Comp 2 HPMemory";
                case 1496: return "BMD: Apartment Comp 3 PowerUP";
                case 1503: return "BMD: Gospel Server 1 RegUP1";
                case 1512: return "BMD: Air Comp 1 RegUP1";
                case 1518: return "BMD: Air Comp 2 HPMemory";
                case 1525: return "BMD: Air Comp 4 HPMemory";
                case 1526: return "BMD: Air Comp 4 RegUP2";
                case 1529: return "BMD: Undernet 1 RegUP2";
                case 1532: return "BMD: Undernet 2 HPMemory";
                case 1539: return "PMD: Undernet 3 SubMem";
                case 1551: return "BMD: Undernet 6 RegUP2";
                case 1570: return "BMD: WWW Area 3 SubMem";
                
                // 1792-1827: Emails
                // 1920-1955: Emails unread
                
                case 2134: return "Show mugshot in textbox, locks movement if false";
                case 2143: return "Unlocker subchip being used";
                case 2146: return "LocEnemy subchip active";
                
                // 2176-2687: BBS posts
                // 2688-3200: BBS posts unread
                // 3200-3217: Job complete
                // 3264-3281: Job taken
            }
            return "";
        }
    }
}
