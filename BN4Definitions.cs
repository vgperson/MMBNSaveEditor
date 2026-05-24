using System.Collections.Generic;

namespace MMBNSaveEditor
{
    /// <summary>An object that returns definitions for Battle Network 4.</summary>
    class BN4Definitions : BNDefinitions
    {
        public override string[] chipNames { get { return new string[] {
            "",
            "Cannon", "HiCannon", "M-Cannon", "AirShot", "Blizzard", "HeatBrth", "Silence", "Tornado", "WideSht1", "WideSht2",
            "WideSht3", "FlmLine1", "FlmLine2", "FlmLine3", "Vulcan1", "Vulcan2", "Vulcan3", "Spreader", "HeatShot", "Heat-V",
            "HeatSide", "Bubbler", "Bub-V", "BublSide", "ElemFlar", "ElemIce", "Static", "LifeSync", "MiniBomb", "EnergBom",
            "MegEnBom", "GunDelS1", "GunDelS2", "GunDelS3", "MagBolt1", "MagBolt2", "MagBolt3", "Binder1", "Binder2", "Binder3",
            "BugBomb", "ElecShok", "WoodPwdr", "Ball", "Geyser", "BlkBomb", "SandRing", "Sword", "WideSwrd", "LongSwrd",
            "WideBlde", "LongBlde", "WindRack", "CustSwrd", "VarSwrd", "Slasher", "Thunder1", "Thunder2", "Thunder3", "Counter1",
            "Counter2", "Counter3", "AirHoc1", "AirHoc2", "AirHoc3", "CircGun1", "CircGun2", "CircGun3", "TwnFng1", "TwnFng2",
            "TwnFng3", "WhitWeb1", "WhitWeb2", "WhitWeb3", "Boomer1", "Boomer2", "Boomer3", "SidBmbo1", "SidBmbo2", "SidBmbo3",
            "Lance", "Hole", "Wind", "Fan", "BoyBomb1", "BoyBomb2", "BoyBomb3", "Guard1", "Guard2", "Guard3",
            "CrakOut", "DublCrak", "TripCrak", "Magnum", "MetaGel", "Snake", "TimeBomb", "Mine", "RockCube", "Fanfare",
            "Discord", "Timpani", "VDoll", "BigHamr1", "BigHamr2", "BigHamr3", "Recov10", "Recov30", "Recov50", "Recov80",
            "Recov120", "Recov150", "Recov200", "Recov300", "Repair", "PanlGrab", "AreaGrab", "GrabRvng", "GrabBnsh", "SloGauge",
            "FstGauge", "PnlRetrn", "Geddon1", "Geddon2", "Geddon3", "ElemLeaf", "ColorPt", "ElemSand", "Blinder", "MokoRus1",
            "MokoRus2", "MokoRus3", "Invis", "PopUp", "Barrier", "Barr100", "Barr200", "NrthWind", "HolyPanl", "AntiFire",
            "AntiWatr", "AntiElec", "AntiWood", "AntiNavi", "AntiDmg", "AntiSwrd", "AntiRecv", "CopyDmg", "Atk+10", "Navi+20",
            "RollAro1", "RollAro2", "RollAro3", "GutPnch1", "GutPnch2", "GutPnch3", "PropBom1", "PropBom2", "PropBom3", "SeekBom1",
            "SeekBom2", "SeekBom3", "Meteors1", "Meteors2", "Meteors3", "Ligtnin1", "Ligtnin2", "Ligtnin3", "HawkCut1", "HawkCut2",
            "HawkCut3", "NumbrBl1", "NumbrBl2", "NumbrBl3", "MetlGer1", "MetlGer2", "MetlGer3", "PanlSht1", "PanlSht2", "PanlSht3",
            "AquaUp1", "AquaUp2", "AquaUp3", "GreenWd1", "GreenWd2", "GreenWd3", "DrkCanon", "DrkSword", "DarkBomb", "DrkVulcn",
            "DrkLance", "DrkSpred", "DrkStage", "DrkRecov", "", "", "", "", "", "",
            "LifeAura", "Muramasa", "Guardian", "Anubis", "Atk+30", "BugFix", "DblPoint", "Snctuary", "FullCust", "ShotStar",
            "BugChain", "Jealousy", "ElemDark", "BlakWing", "GodHammr", "DrkLine", "NeoVari", "Z-Saber", "GunDSlEX", "SuprVulc",
            "Roll", "RollSP", "RollDS", "GutsMan", "GutsMnSP", "GutsMnDS", "WindMan", "WindMnSP", "WindMnDS", "SearchMn",
            "SrchMnSP", "SrchMnDS", "FireMan", "FireMnSP", "FireMnDS", "ThundrMn", "ThunMnSP", "ThunMnDS", "ProtoMan", "ProtoMSP",
            "ProtoMDS", "NumberMn", "NumbMnSP", "NumbMnDS", "MetalMan", "MetlMnSP", "MetlMnDS", "JunkMan", "JunkMnSP", "JunkMnDS",
            "AquaMan", "AquaMnSP", "AquaMnDS", "WoodMan", "WoodMnSP", "WoodMnDS", "TopMan", "TopMnSP", "TopMnDS", "ShadeMan",
            "ShadMnSP", "ShadMnDS", "BurnerMn", "BurnMnSP", "BurnMnDS", "ColdMan", "ColdMnSP", "ColdMnDS", "SparkMan", "SprkMnSP",
            "SprkMnDS", "LaserMan", "LasrMnSP", "LasrMnDS", "KendoMan", "KendMnSP", "KendMnDS", "VideoMan", "VideMnSP", "VideMnDS",
            "Marking", "CannMode", "BallMode", "SwrdMode", "FirePlus", "ThunPlus", "AquaPowr", "WoodPowr", "BlakWeap", "FinalGun",
            "", "", "", "", "", "", "", "", "", "",
            "Bass", "DeltaRay", "BugCurse", "RedSun", "SignlRed", "BassAnly", "HolyDrem", "BlakBarr", "BlueMoon", "BugCharg",
            "Duo", "PrixPowr"
        }; } }
        
        public override string[] paNames { get { return new string[] {
            "DarkNeo", "HeatSprd", "BubSprd", "GigaCan1", "GigaCan2", "GigaCan3", "SuprSpr1", "SuprSpr2", "SuprSpr3", "FlmCros1",
            "FlmCros2", "FlmCros3", "PitRng1", "PitRng2", "PitRng3", "BstFang1", "BstFang2", "BstFang3", "PitHoky1", "PitHoky2",
            "PitHoky3", "MagShok1", "MagShok2", "MagShok3", "LifeSrd", "PileDrvr", "TimeBom+", "PoisPhar", "BodyGrd", "H-Burst"
        }; } }
        
        public override Dictionary<string, string[]> chipAliases { get {
            Dictionary<string, string[]> def = new Dictionary<string, string[]>();
            def["BallMode"] = new string[] { "CannBall" };
            def["GunDelS1"] = new string[] { "GunSol1", "GunDSol1", "GunDlSol1", "GunDSl1", "GunDeSl1", "GunDelSl1", "GunDlS1", "GunDelS1", "GunDelSol1" };
            def["GunDelS2"] = new string[] { "GunSol2", "GunDSol2", "GunDlSol2", "GunDSl2", "GunDeSl2", "GunDelSl2", "GunDlS2", "GunDelS2", "GunDelSol2" };
            def["GunDelS3"] = new string[] { "GunSol3", "GunDSol3", "GunDlSol3", "GunDSl3", "GunDeSl3", "GunDelSl3", "GunDlS3", "GunDelS3", "GunDelSol3" };
            def["GunDSlEX"] = new string[] { "GunSolEX", "GunDSolEX", "GunDlSolEX", "GunDSlEX", "GunDeSlEX", "GunDelSlEX", "GunDlSEX", "GunDelSEX", "GunDelSolEX" };
            def["Z-Saber"] = new string[] { "Z Saber", "ZSaber", "Z-Saver", "Z Saver", "ZSaver" };
            def["GutsMnSP"] = new string[] { "GutsManSP" };
            def["GutsMnDS"] = new string[] { "GutsManDS" };
            def["WindMnSP"] = new string[] { "WindManSP" };
            def["WindMnDS"] = new string[] { "WindManDS" };
            def["SearchMn"] = new string[] { "SearchMan", "SerchMan" };
            def["SrchMnSP"] = new string[] { "SerchMnSP", "SerchManSP", "SearchMnSP", "SearchManSP" };
            def["SrchMnDS"] = new string[] { "SerchMnDS", "SerchManDS", "SearchMnDS", "SearchManDS" };
            def["FireMnSP"] = new string[] { "FireManSP" };
            def["FireMnDS"] = new string[] { "FireManDS" };
            def["ThundrMn"] = new string[] { "ThunderMan", "ThunMan" };
            def["ThunMnSP"] = new string[] { "ThunManSP", "ThundrMnSP", "ThundrManSP", "ThunderManSP" };
            def["ThunMnDS"] = new string[] { "ThunManDS", "ThundrMnDS", "ThundrManDS", "ThunderManDS" };
            def["ProtoMSP"] = new string[] { "ProtoMnSP", "ProtoManSP" };
            def["ProtoMDS"] = new string[] { "ProtoMnDS", "ProtoManDS" };
            def["NumberMn"] = new string[] { "NumbMn", "NumbMan", "NumbrMn", "NumbrMan", "NumberMan" };
            def["NumbMnSP"] = new string[] { "NumbManSP", "NumbrMnSP", "NumbrManSP", "NumberManSP" };
            def["NumbMnDS"] = new string[] { "NumbManDS", "NumbrMnDS", "NumbrManDS", "NumberManDS" };
            def["MetlMnSP"] = new string[] { "MetalMnSP", "MetlManSP", "MetalManSP" };
            def["MetlMnDS"] = new string[] { "MetalMnDS", "MetlManDS", "MetalManDS" };
            def["JunkMnSP"] = new string[] { "JunkManSP" };
            def["JunkMnDS"] = new string[] { "JunkManDS" };
            def["AquaMnSP"] = new string[] { "AquaManSP" };
            def["AquaMnDS"] = new string[] { "AquaManDS" };
            def["WoodMnSP"] = new string[] { "WoodManSP" };
            def["WoodMnDS"] = new string[] { "WoodManDS" };
            def["TopMnSP"] = new string[] { "TopManSP" };
            def["TopMnDS"] = new string[] { "TopManDS" };
            def["ShadMnSP"] = new string[] { "ShadeMnSP", "ShadManSP", "ShadeManSP" };
            def["ShadMnDS"] = new string[] { "ShadeMnDS", "ShadManDS", "ShadeManDS" };
            def["BurnerMn"] = new string[] { "BurnMan", "BurnrMan", "BurnerMan" };
            def["BurnMnSP"] = new string[] { "BurnManSP", "BurnrManSP", "BurnerMnSP", "BurnerManSP" };
            def["BurnMnDS"] = new string[] { "BurnManDS", "BurnrManDS", "BurnerMnDS", "BurnerManDS" };
            def["ColdMnSP"] = new string[] { "ColdManSP" };
            def["ColdMnDS"] = new string[] { "ColdManDS" };
            def["SprkMnSP"] = new string[] { "SparkMnSP", "SprkManSP", "SparkManSP" };
            def["SprkMnDS"] = new string[] { "SparkMnDS", "SprkManDS", "SparkManDS" };
            def["LasrMnSP"] = new string[] { "LaserMnSP", "LasrManSP", "LaserManSP" };
            def["LasrMnDS"] = new string[] { "LaserMnDS", "LasrManDS", "LaserManDS" };
            def["KendMnSP"] = new string[] { "KendoMnSP", "KendManSP", "KendoManSP" };
            def["KendMnDS"] = new string[] { "KendoMnDS", "KendManDS", "KendoManDS" };
            def["VideMnSP"] = new string[] { "VideoMnSP", "VideManSP", "VideoManSP" };
            def["VideMnDS"] = new string[] { "VideoMnDS", "VideManDS", "VideoManDS" };
            return def;
        } }
        
        public override string[] chipCodes { get { return new string[] {
            "----", // (MegaBstr)
            "ABC*", // Cannon
            "CDE-", // HiCannon
            "EFG-", // M-Cannon
            "ASV*", // AirShot
            "HJV*", // Blizzard
            "DKO*", // HeatBrth
            "CMR*", // Silence
            "ELT-", // Tornado
            "CDE*", // WideSht1
            "LMN-", // WideSht2
            "STU-", // WideSht3
            "FGH*", // FlmLine1
            "DEF-", // FlmLine2
            "JKL-", // FlmLine3
            "ESV*", // Vulcan1
            "BHO-", // Vulcan2
            "OTW-", // Vulcan3
            "LMN*", // Spreader
            "BCD*", // HeatShot
            "CDE-", // Heat-V
            "DEF-", // HeatSide
            "PQR*", // Bubbler
            "CDE-", // Bub-V
            "DEF-", // BublSide
            "KNP-", // ElemFlar
            "HQV-", // ElemIce
            "BGZ*", // Static
            "NQY-", // LifeSync
            "BLT*", // MiniBomb
            "ENT*", // EnergBom
            "DJW-", // MegEnBom
            "AGM*", // GunDelS1
            "BGS-", // GunDelS2
            "CGT-", // GunDelS3
            "BCD*", // MagBolt1
            "EFG-", // MagBolt2
            "ABC-", // MagBolt3
            "COS*", // Binder1
            "ATY-", // Binder2
            "EIO-", // Binder3
            "BGZ*", // BugBomb
            "JLS*", // ElecShok
            "FTW*", // WoodPwdr
            "BTV*", // Ball
            "BLV-", // Geyser
            "DHZ-", // BlkBomb
            "CRS*", // SandRing
            "ELS-", // Sword
            "ELS-", // WideSwrd
            "ELS-", // LongSwrd
            "CKS-", // WideBlde
            "GRS-", // LongBlde
            "ALR*", // WindRack
            "BPS-", // CustSwrd
            "CJV-", // VarSwrd
            "FHR-", // Slasher
            "BLP*", // Thunder1
            "HSP-", // Thunder2
            "ITW-", // Thunder3
            "FMT*", // Counter1
            "BHL*", // Counter2
            "ANV-", // Counter3
            "DEF*", // AirHoc1
            "IJK-", // AirHoc2
            "UVW-", // AirHoc3
            "HTZ-", // CircGun1
            "DGT-", // CircGun2
            "JMR-", // CircGun3
            "ABC*", // TwnFng1
            "OPQ-", // TwnFng2
            "FGH-", // TwnFng3
            "DLR*", // WhitWeb1
            "CEY*", // WhitWeb2
            "KOV*", // WhitWeb3
            "LMN*", // Boomer1
            "LMN-", // Boomer2
            "STU-", // Boomer3
            "BIR*", // SidBmbo1
            "HOS-", // SidBmbo2
            "AFU-", // SidBmbo3
            "AGR*", // Lance
            "*---", // Hole
            "*---", // Wind
            "*---", // Fan
            "EJM-", // BoyBomb1
            "ISW-", // BoyBomb2
            "GTV-", // BoyBomb3
            "ALV*", // Guard1
            "CGP*", // Guard2
            "FRT*", // Guard3
            "*---", // CrakOut
            "BLR*", // DublCrak
            "BLR*", // TripCrak
            "HQV-", // Magnum
            "KTZ-", // MetaGel
            "DMR-", // Snake
            "JKL-", // TimeBomb
            "CHZ-", // Mine
            "*---", // RockCube
            "EGN*", // Fanfare
            "DTV*", // Discord
            "PTZ*", // Timpani
            "IOY-", // VDoll
            "BRO-", // BigHamr1
            "GJW-", // BigHamr2
            "DVZ-", // BigHamr3
            "ALN*", // Recov10
            "FHR*", // Recov30
            "ELS*", // Recov50
            "BJO*", // Recov80
            "FJQ*", // Recov120
            "CTZ-", // Recov150
            "HMW-", // Recov200
            "JNY-", // Recov300
            "IPR*", // Repair
            "KOY*", // PanlGrab
            "EMS*", // AreaGrab
            "DJN-", // GrabRvng
            "EKP-", // GrabBnsh
            "EHV*", // SloGauge
            "IQU*", // FstGauge
            "*---", // PnlRetrn
            "JKW-", // Geddon1
            "NTY-", // Geddon2
            "HQU-", // Geddon3
            "CDI-", // ElemLeaf
            "*---", // ColorPt
            "ALS*", // ElemSand
            "*---", // Blinder
            "CIM-", // MokoRus1
            "GKU-", // MokoRus2
            "OTY-", // MokoRus3
            "*---", // Invis
            "JPY*", // PopUp
            "ADZ*", // Barrier
            "PQW-", // Barr100
            "IOU-", // Barr200
            "ENT*", // NrthWind
            "*---", // HolyPanl
            "K---", // AntiFire
            "D---", // AntiWatr
            "H---", // AntiElec
            "M---", // AntiWood
            "JMT-", // AntiNavi
            "KMR-", // AntiDmg
            "CIN*", // AntiSwrd
            "BDG*", // AntiRecv
            "*---", // CopyDmg
            "*---", // Atk+10
            "*---", // Navi+20
            "AFT-", // RollAro1
            "DRW-", // RollAro2
            "QYZ-", // RollAro3
            "BEN-", // GutPnch1
            "GPY-", // GutPnch2
            "MQT-", // GutPnch3
            "EGP*", // PropBom1
            "FVZ-", // PropBom2
            "HJQ-", // PropBom3
            "BRS*", // SeekBom1
            "CIO-", // SeekBom2
            "MUW-", // SeekBom3
            "GLS*", // Meteors1
            "MQT-", // Meteors2
            "CRZ-", // Meteors3
            "LTW*", // Ligtnin1
            "AEV-", // Ligtnin2
            "HJQ-", // Ligtnin3
            "HNO-", // HawkCut1
            "FSV-", // HawkCut2
            "INZ-", // HawkCut3
            "ELW-", // NumbrBl1
            "AEP-", // NumbrBl2
            "LTY-", // NumbrBl3
            "AMP*", // MetlGer1
            "CEG*", // MetlGer2
            "ILQ*", // MetlGer3
            "AHS*", // PanlSht1
            "CGT*", // PanlSht2
            "FJN*", // PanlSht3
            "BSZ-", // AquaUp1
            "IPU-", // AquaUp2
            "FKW-", // AquaUp3
            "GJY-", // GreenWd1
            "DKP-", // GreenWd2
            "ENP-", // GreenWd3
            "ABC*", // DrkCanon
            "ABC*", // DrkSword
            "ABC*", // DarkBomb
            "ABC*", // DrkVulcn
            "ABC*", // DrkLance
            "ABC*", // DrkSpred
            "ABC*", // DrkStage
            "ABC*", // DrkRecov
            "----", // (Unused #195)
            "----", // (Unused #196)
            "----", // (Unused #197)
            "----", // (Unused #198)
            "----", // (Unused #199)
            "----", // (Unused #200)
            "D---", // LifeAura
            "M---", // Muramasa
            "O---", // Guardian
            "A---", // Anubis
            "*---", // Atk+30
            "B*--", // BugFix
            "*---", // DblPoint
            "S---", // Snctuary
            "*---", // FullCust
            "R---", // ShotStar
            "C*--", // BugChain
            "J---", // Jealousy
            "E---", // ElemDark
            "W---", // BlakWing
            "G---", // GodHammr
            "L*--", // DrkLine
            "N---", // NeoVari
            "Z---", // Z-Saber
            "G---", // GunDSlEX
            "V---", // SuprVulc
            "R---", // Roll
            "R---", // RollSP
            "R---", // RollDS
            "G---", // GutsMan
            "G---", // GutsMnSP
            "G---", // GutsMnDS
            "W---", // WindMan
            "W---", // WindMnSP
            "W---", // WindMnDS
            "S---", // SearchMn
            "S---", // SrchMnSP
            "S---", // SrchMnDS
            "F---", // FireMan
            "F---", // FireMnSP
            "F---", // FireMnDS
            "T---", // ThundrMn
            "T---", // ThunMnSP
            "T---", // ThunMnDS
            "B---", // ProtoMan
            "B---", // ProtoMSP
            "B---", // ProtoMDS
            "N---", // NumberMn
            "N---", // NumbMnSP
            "N---", // NumbMnDS
            "M---", // MetalMan
            "M---", // MetlMnSP
            "M---", // MetlMnDS
            "J---", // JunkMan
            "J---", // JunkMnSP
            "J---", // JunkMnDS
            "A---", // AquaMan
            "A---", // AquaMnSP
            "A---", // AquaMnDS
            "W---", // WoodMan
            "W---", // WoodMnSP
            "W---", // WoodMnDS
            "T---", // TopMan
            "T---", // TopMnSP
            "T---", // TopMnDS
            "X---", // ShadeMan
            "X---", // ShadMnSP
            "X---", // ShadMnDS
            "B---", // BurnerMn
            "B---", // BurnMnSP
            "B---", // BurnMnDS
            "C---", // ColdMan
            "C---", // ColdMnSP
            "C---", // ColdMnDS
            "S---", // SparkMan
            "S---", // SprkMnSP
            "S---", // SprkMnDS
            "L---", // LaserMan
            "L---", // LasrMnSP
            "L---", // LasrMnDS
            "K---", // KendoMan
            "K---", // KendMnSP
            "K---", // KendMnDS
            "V---", // VideoMan
            "V---", // VideMnSP
            "V---", // VideMnDS
            "ABC*", // Marking
            "ABC*", // CannMode
            "ABC*", // BallMode
            "ABC*", // SwrdMode
            "ABC*", // FirePlus
            "ABC*", // ThunPlus
            "ABC*", // AquaPowr
            "ABC*", // WoodPowr
            "ABC*", // BlakWeap
            "ABC*", // FinalGun
            "----", // (Unused #291)
            "----", // (Unused #292)
            "----", // (Unused #293)
            "----", // (Unused #294)
            "----", // (Unused #295)
            "----", // (Unused #296)
            "----", // (Unused #297)
            "----", // (Unused #298)
            "----", // (Unused #299)
            "----", // (Unused #300)
            "X---", // Bass
            "Z---", // DeltaRay
            "C---", // BugCurse
            "R---", // RedSun
            "S---", // SignlRed
            "X---", // BassAnly
            "H---", // HolyDrem
            "A---", // BlakBarr
            "B---", // BlueMoon
            "C---", // BugCharg
            "D---", // Duo
            "G---", // PrixPowr
        }; } }
        
        // No unobtainableCodes, as all defined codes are seemingly obtainable
        
        public override int[] chipSizes { get { return new int[] {
            5, // (MegaBstr)
            8, // Cannon
            24, // HiCannon
            40, // M-Cannon
            6, // AirShot
            26, // Blizzard
            30, // HeatBrth
            20, // Silence
            22, // Tornado
            10, // WideSht1
            30, // WideSht2
            50, // WideSht3
            18, // FlmLine1
            26, // FlmLine2
            54, // FlmLine3
            6, // Vulcan1
            18, // Vulcan2
            30, // Vulcan3
            10, // Spreader
            8, // HeatShot
            22, // Heat-V
            44, // HeatSide
            12, // Bubbler
            22, // Bub-V
            44, // BublSide
            24, // ElemFlar
            24, // ElemIce
            30, // Static
            12, // LifeSync
            5, // MiniBomb
            11, // EnergBom
            30, // MegEnBom
            15, // GunDelS1
            25, // GunDelS2
            35, // GunDelS3
            18, // MagBolt1
            28, // MagBolt2
            38, // MagBolt3
            10, // Binder1
            17, // Binder2
            24, // Binder3
            30, // BugBomb
            40, // ElecShok
            40, // WoodPwdr
            30, // Ball
            38, // Geyser
            55, // BlkBomb
            8, // SandRing
            9, // Sword
            16, // WideSwrd
            25, // LongSwrd
            38, // WideBlde
            40, // LongBlde
            23, // WindRack
            20, // CustSwrd
            60, // VarSwrd
            18, // Slasher
            7, // Thunder1
            18, // Thunder2
            33, // Thunder3
            14, // Counter1
            28, // Counter2
            42, // Counter3
            20, // AirHoc1
            30, // AirHoc2
            40, // AirHoc3
            28, // CircGun1
            40, // CircGun2
            52, // CircGun3
            13, // TwnFng1
            26, // TwnFng2
            39, // TwnFng3
            26, // WhitWeb1
            36, // WhitWeb2
            46, // WhitWeb3
            16, // Boomer1
            28, // Boomer2
            40, // Boomer3
            14, // SidBmbo1
            22, // SidBmbo2
            30, // SidBmbo3
            42, // Lance
            23, // Hole
            10, // Wind
            10, // Fan
            30, // BoyBomb1
            40, // BoyBomb2
            50, // BoyBomb3
            4, // Guard1
            10, // Guard2
            16, // Guard3
            4, // CrakOut
            7, // DublCrak
            10, // TripCrak
            52, // Magnum
            52, // MetaGel
            60, // Snake
            55, // TimeBomb
            42, // Mine
            6, // RockCube
            20, // Fanfare
            20, // Discord
            20, // Timpani
            58, // VDoll
            22, // BigHamr1
            33, // BigHamr2
            44, // BigHamr3
            8, // Recov10
            16, // Recov30
            24, // Recov50
            32, // Recov80
            40, // Recov120
            48, // Recov150
            56, // Recov200
            64, // Recov300
            5, // Repair
            6, // PanlGrab
            8, // AreaGrab
            48, // GrabRvng
            24, // GrabBnsh
            22, // SloGauge
            32, // FstGauge
            14, // PnlRetrn
            34, // Geddon1
            47, // Geddon2
            62, // Geddon3
            24, // ElemLeaf
            25, // ColorPt
            24, // ElemSand
            9, // Blinder
            14, // MokoRus1
            28, // MokoRus2
            42, // MokoRus3
            12, // Invis
            21, // PopUp
            7, // Barrier
            27, // Barr100
            47, // Barr200
            33, // NrthWind
            24, // HolyPanl
            58, // AntiFire
            54, // AntiWatr
            59, // AntiElec
            55, // AntiWood
            44, // AntiNavi
            31, // AntiDmg
            43, // AntiSwrd
            37, // AntiRecv
            12, // CopyDmg
            6, // Atk+10
            36, // Navi+20
            32, // RollAro1
            38, // RollAro2
            44, // RollAro3
            22, // GutPnch1
            36, // GutPnch2
            50, // GutPnch3
            18, // PropBom1
            26, // PropBom2
            34, // PropBom3
            25, // SeekBom1
            35, // SeekBom2
            45, // SeekBom3
            15, // Meteors1
            23, // Meteors2
            31, // Meteors3
            37, // Ligtnin1
            45, // Ligtnin2
            53, // Ligtnin3
            40, // HawkCut1
            50, // HawkCut2
            60, // HawkCut3
            28, // NumbrBl1
            35, // NumbrBl2
            42, // NumbrBl3
            20, // MetlGer1
            28, // MetlGer2
            36, // MetlGer3
            19, // PanlSht1
            25, // PanlSht2
            31, // PanlSht3
            22, // AquaUp1
            28, // AquaUp2
            34, // AquaUp3
            35, // GreenWd1
            40, // GreenWd2
            45, // GreenWd3
            99, // DrkCanon
            99, // DrkSword
            99, // DarkBomb
            99, // DrkVulcn
            99, // DrkLance
            99, // DrkSpred
            99, // DrkStage
            99, // DrkRecov
            5, // (Unused #195)
            5, // (Unused #196)
            5, // (Unused #197)
            5, // (Unused #198)
            5, // (Unused #199)
            5, // (Unused #200)
            70, // LifeAura
            81, // Muramasa
            64, // Guardian
            86, // Anubis
            66, // Atk+30
            62, // BugFix
            50, // DblPoint
            62, // Snctuary
            45, // FullCust
            73, // ShotStar
            59, // BugChain
            35, // Jealousy
            38, // ElemDark
            58, // BlakWing
            68, // GodHammr
            59, // DrkLine
            74, // NeoVari
            80, // Z-Saber
            80, // GunDSlEX
            75, // SuprVulc
            28, // Roll
            60, // RollSP
            60, // RollDS
            32, // GutsMan
            68, // GutsMnSP
            68, // GutsMnDS
            48, // WindMan
            64, // WindMnSP
            64, // WindMnDS
            45, // SearchMn
            70, // SrchMnSP
            70, // SrchMnDS
            36, // FireMan
            72, // FireMnSP
            72, // FireMnDS
            48, // ThundrMn
            68, // ThunMnSP
            68, // ThunMnDS
            54, // ProtoMan
            79, // ProtoMSP
            79, // ProtoMDS
            33, // NumberMn
            66, // NumbMnSP
            66, // NumbMnDS
            52, // MetalMan
            74, // MetlMnSP
            74, // MetlMnDS
            80, // JunkMan
            80, // JunkMnSP
            80, // JunkMnDS
            41, // AquaMan
            63, // AquaMnSP
            63, // AquaMnDS
            50, // WoodMan
            76, // WoodMnSP
            76, // WoodMnDS
            54, // TopMan
            71, // TopMnSP
            71, // TopMnDS
            73, // ShadeMan
            88, // ShadMnSP
            88, // ShadMnDS
            46, // BurnerMn
            69, // BurnMnSP
            69, // BurnMnDS
            53, // ColdMan
            72, // ColdMnSP
            72, // ColdMnDS
            55, // SparkMan
            77, // SprkMnSP
            77, // SprkMnDS
            60, // LaserMan
            80, // LasrMnSP
            80, // LasrMnDS
            45, // KendoMan
            75, // KendMnSP
            75, // KendMnDS
            44, // VideoMan
            67, // VideMnSP
            67, // VideMnDS
            10, // Marking
            30, // CannMode
            40, // BallMode
            50, // SwrdMode
            80, // FirePlus
            80, // ThunPlus
            80, // AquaPowr
            80, // WoodPowr
            64, // BlakWeap
            80, // FinalGun
            5, // (Unused #291)
            5, // (Unused #292)
            5, // (Unused #293)
            5, // (Unused #294)
            5, // (Unused #295)
            5, // (Unused #296)
            5, // (Unused #297)
            5, // (Unused #298)
            5, // (Unused #299)
            5, // (Unused #300)
            95, // Bass
            82, // DeltaRay
            73, // BugCurse
            90, // RedSun
            61, // SignlRed
            95, // BassAnly
            92, // HolyDrem
            87, // BlakBarr
            90, // BlueMoon
            77, // BugCharg
            99, // Duo
            94 // PrixPowr
        }; } }
        
        public override int[] gameOrderStandardChips { get { return new int[] {
            1, // Cannon
            2, // HiCannon
            3, // M-Cannon
            4, // AirShot
            15, // Vulcan1
            16, // Vulcan2
            17, // Vulcan3
            18, // Spreader
            19, // HeatShot
            20, // Heat-V
            21, // HeatSide
            22, // Bubbler
            23, // Bub-V
            24, // BublSide
            57, // Thunder1
            58, // Thunder2
            59, // Thunder3
            9, // WideSht1
            10, // WideSht2
            11, // WideSht3
            12, // FlmLine1
            13, // FlmLine2
            14, // FlmLine3
            32, // GunDelS1
            33, // GunDelS2
            34, // GunDelS3
            5, // Blizzard
            6, // HeatBrth
            42, // ElecShok
            43, // WoodPwdr
            47, // SandRing
            69, // TwnFng1
            70, // TwnFng2
            71, // TwnFng3
            25, // ElemFlar
            26, // ElemIce
            126, // ElemLeaf
            128, // ElemSand
            35, // MagBolt1
            36, // MagBolt2
            37, // MagBolt3
            8, // Tornado
            27, // Static
            29, // MiniBomb
            30, // EnergBom
            31, // MegEnBom
            44, // Ball
            46, // BlkBomb
            45, // Geyser
            41, // BugBomb
            38, // Binder1
            39, // Binder2
            40, // Binder3
            48, // Sword
            49, // WideSwrd
            50, // LongSwrd
            51, // WideBlde
            52, // LongBlde
            54, // CustSwrd
            55, // VarSwrd
            56, // Slasher
            53, // WindRack
            63, // AirHoc1
            64, // AirHoc2
            65, // AirHoc3
            60, // Counter1
            61, // Counter2
            62, // Counter3
            75, // Boomer1
            76, // Boomer2
            77, // Boomer3
            78, // SidBmbo1
            79, // SidBmbo2
            80, // SidBmbo3
            81, // Lance
            72, // WhitWeb1
            73, // WhitWeb2
            74, // WhitWeb3
            130, // MokoRus1
            131, // MokoRus2
            132, // MokoRus3
            66, // CircGun1
            67, // CircGun2
            68, // CircGun3
            96, // Snake
            94, // Magnum
            104, // BigHamr1
            105, // BigHamr2
            106, // BigHamr3
            85, // BoyBomb1
            86, // BoyBomb2
            87, // BoyBomb3
            97, // TimeBomb
            98, // Mine
            99, // RockCube
            83, // Wind
            84, // Fan
            100, // Fanfare
            101, // Discord
            102, // Timpani
            7, // Silence
            103, // VDoll
            88, // Guard1
            89, // Guard2
            90, // Guard3
            91, // CrakOut
            92, // DublCrak
            93, // TripCrak
            107, // Recov10
            108, // Recov30
            109, // Recov50
            110, // Recov80
            111, // Recov120
            112, // Recov150
            113, // Recov200
            114, // Recov300
            115, // Repair
            116, // PanlGrab
            117, // AreaGrab
            95, // MetaGel
            119, // GrabBnsh
            118, // GrabRvng
            122, // PnlRetrn
            123, // Geddon1
            124, // Geddon2
            125, // Geddon3
            120, // SloGauge
            121, // FstGauge
            129, // Blinder
            138, // NrthWind
            139, // HolyPanl
            82, // Hole
            133, // Invis
            134, // PopUp
            135, // Barrier
            136, // Barr100
            137, // Barr200
            140, // AntiFire
            141, // AntiWatr
            142, // AntiElec
            143, // AntiWood
            145, // AntiDmg
            146, // AntiSwrd
            144, // AntiNavi
            147, // AntiRecv
            148, // CopyDmg
            28, // LifeSync
            149, // Atk+10
            150, // Navi+20
            127, // ColorPt
        }; } }
        
        public override int[] gameOrderMegaChipsMain { get { return new int[] {
            220, // SuprVulc
            217, // NeoVari
            210, // ShotStar
            215, // GodHammr
            203, // Guardian
            212, // Jealousy
            211, // BugChain
            206, // BugFix
            209, // FullCust
            201, // LifeAura
            208, // Snctuary
            205, // Atk+30
            207, // DblPoint
            202, // Muramasa
            204, // Anubis
            213, // ElemDark
            214, // BlakWing
            216, // DrkLine
            221, // Roll
            222, // RollSP
            223, // RollDS
            224, // GutsMan
            225, // GutsMnSP
            226, // GutsMnDS
            227, // WindMan
            228, // WindMnSP
            229, // WindMnDS
            230, // SearchMn
            231, // SrchMnSP
            232, // SrchMnDS
            233, // FireMan
            234, // FireMnSP
            235, // FireMnDS
            236, // ThundrMn
            237, // ThunMnSP
            238, // ThunMnDS
            257, // TopMan
            258, // TopMnSP
            259, // TopMnDS
            263, // BurnerMn
            264, // BurnMnSP
            265, // BurnMnDS
            266, // ColdMan
            267, // ColdMnSP
            268, // ColdMnDS
            269, // SparkMan
            270, // SprkMnSP
            271, // SprkMnDS
            260, // ShadeMan
            261, // ShadMnSP
            262, // ShadMnDS
            272, // LaserMan
            273, // LasrMnSP
            274, // LasrMnDS
            275, // KendoMan
            276, // KendMnSP
            277, // KendMnDS
            278, // VideoMan
            279, // VideMnSP
            280, // VideMnDS
            312, // PrixPowr [unregistered]
        }; } }
        
        public override int[] gameOrderMegaChipsSub { get { return new int[] {
            220, // SuprVulc
            217, // NeoVari
            210, // ShotStar
            215, // GodHammr
            203, // Guardian
            212, // Jealousy
            211, // BugChain
            206, // BugFix
            209, // FullCust
            201, // LifeAura
            208, // Snctuary
            205, // Atk+30
            207, // DblPoint
            202, // Muramasa
            204, // Anubis
            213, // ElemDark
            214, // BlakWing
            216, // DrkLine
            239, // ProtoMan
            240, // ProtoMSP
            241, // ProtoMDS
            242, // NumberMn
            243, // NumbMnSP
            244, // NumbMnDS
            245, // MetalMan
            246, // MetlMnSP
            247, // MetlMnDS
            248, // JunkMan
            249, // JunkMnSP
            250, // JunkMnDS
            251, // AquaMan
            252, // AquaMnSP
            253, // AquaMnDS
            254, // WoodMan
            255, // WoodMnSP
            256, // WoodMnDS
            257, // TopMan
            258, // TopMnSP
            259, // TopMnDS
            263, // BurnerMn
            264, // BurnMnSP
            265, // BurnMnDS
            266, // ColdMan
            267, // ColdMnSP
            268, // ColdMnDS
            269, // SparkMan
            270, // SprkMnSP
            271, // SprkMnDS
            260, // ShadeMan
            261, // ShadMnSP
            262, // ShadMnDS
            272, // LaserMan
            273, // LasrMnSP
            274, // LasrMnDS
            275, // KendoMan
            276, // KendMnSP
            277, // KendMnDS
            278, // VideoMan
            279, // VideMnSP
            280, // VideMnDS
            312, // PrixPowr [unregistered]
        }; } }
        
        public override int[] gameOrderMegaChipsAll { get { return new int[] {
            220, // SuprVulc
            217, // NeoVari
            210, // ShotStar
            215, // GodHammr
            203, // Guardian
            212, // Jealousy
            211, // BugChain
            206, // BugFix
            209, // FullCust
            201, // LifeAura
            208, // Snctuary
            205, // Atk+30
            207, // DblPoint
            202, // Muramasa
            204, // Anubis
            213, // ElemDark
            214, // BlakWing
            216, // DrkLine
            221, // Roll
            222, // RollSP
            223, // RollDS
            224, // GutsMan
            225, // GutsMnSP
            226, // GutsMnDS
            227, // WindMan
            228, // WindMnSP
            229, // WindMnDS
            230, // SearchMn
            231, // SrchMnSP
            232, // SrchMnDS
            233, // FireMan
            234, // FireMnSP
            235, // FireMnDS
            236, // ThundrMn
            237, // ThunMnSP
            238, // ThunMnDS
            239, // ProtoMan
            240, // ProtoMSP
            241, // ProtoMDS
            242, // NumberMn
            243, // NumbMnSP
            244, // NumbMnDS
            245, // MetalMan
            246, // MetlMnSP
            247, // MetlMnDS
            248, // JunkMan
            249, // JunkMnSP
            250, // JunkMnDS
            251, // AquaMan
            252, // AquaMnSP
            253, // AquaMnDS
            254, // WoodMan
            255, // WoodMnSP
            256, // WoodMnDS
            257, // TopMan
            258, // TopMnSP
            259, // TopMnDS
            263, // BurnerMn
            264, // BurnMnSP
            265, // BurnMnDS
            266, // ColdMan
            267, // ColdMnSP
            268, // ColdMnDS
            269, // SparkMan
            270, // SprkMnSP
            271, // SprkMnDS
            260, // ShadeMan
            261, // ShadMnSP
            262, // ShadMnDS
            272, // LaserMan
            273, // LasrMnSP
            274, // LasrMnDS
            275, // KendoMan
            276, // KendMnSP
            277, // KendMnDS
            278, // VideoMan
            279, // VideMnSP
            280, // VideMnDS
            312, // PrixPowr [unregistered]
        }; } }
        
        public override int[] gameOrderGigaChipsMain { get { return new int[] {
            304, // RedSun
            307, // HolyDrem
            301, // Bass
            310, // BugCharg
            308, // BlakBarr
            311, // Duo [unregistered]
        }; } }
        
        public override int[] gameOrderGigaChipsSub { get { return new int[] {
            309, // BlueMoon
            305, // SignlRed
            306, // BassAnly
            303, // BugCurse
            302, // DeltaRay
            311, // Duo [unregistered]
        }; } }
        
        public override int[] gameOrderGigaChipsAll { get { return new int[] {
            304, // RedSun
            307, // HolyDrem
            301, // Bass
            310, // BugCharg
            308, // BlakBarr
            309, // BlueMoon
            305, // SignlRed
            306, // BassAnly
            303, // BugCurse
            302, // DeltaRay
            311, // Duo [unregistered]
        }; } }
        
        public override int[] gameOrderSecretChipsMain { get { return new int[] {
            151, // RollAro1
            152, // RollAro2
            153, // RollAro3
            154, // GutPnch1
            155, // GutPnch2
            156, // GutPnch3
            157, // PropBom1
            158, // PropBom2
            159, // PropBom3
            160, // SeekBom1
            161, // SeekBom2
            162, // SeekBom3
            163, // Meteors1
            164, // Meteors2
            165, // Meteors3
            166, // Ligtnin1
            167, // Ligtnin2
            168, // Ligtnin3
            169, // HawkCut1
            170, // HawkCut2
            171, // HawkCut3
            172, // NumbrBl1
            173, // NumbrBl2
            174, // NumbrBl3
            175, // MetlGer1
            176, // MetlGer2
            177, // MetlGer3
            178, // PanlSht1
            179, // PanlSht2
            180, // PanlSht3
            181, // AquaUp1
            182, // AquaUp2
            183, // AquaUp3
            184, // GreenWd1
            185, // GreenWd2
            186, // GreenWd3
            219, // GunDSlEX
            218, // Z-Saber
            239, // ProtoMan
            240, // ProtoMSP
            241, // ProtoMDS
            242, // NumberMn
            243, // NumbMnSP
            244, // NumbMnDS
            245, // MetalMan
            246, // MetlMnSP
            247, // MetlMnDS
            248, // JunkMan
            249, // JunkMnSP
            250, // JunkMnDS
            251, // AquaMan
            252, // AquaMnSP
            253, // AquaMnDS
            254, // WoodMan
            255, // WoodMnSP
            256, // WoodMnDS
        }; } } // Includes Blue Moon Navi chips
        
        public override int[] gameOrderSecretChipsSub { get { return new int[] {
            151, // RollAro1
            152, // RollAro2
            153, // RollAro3
            154, // GutPnch1
            155, // GutPnch2
            156, // GutPnch3
            157, // PropBom1
            158, // PropBom2
            159, // PropBom3
            160, // SeekBom1
            161, // SeekBom2
            162, // SeekBom3
            163, // Meteors1
            164, // Meteors2
            165, // Meteors3
            166, // Ligtnin1
            167, // Ligtnin2
            168, // Ligtnin3
            169, // HawkCut1
            170, // HawkCut2
            171, // HawkCut3
            172, // NumbrBl1
            173, // NumbrBl2
            174, // NumbrBl3
            175, // MetlGer1
            176, // MetlGer2
            177, // MetlGer3
            178, // PanlSht1
            179, // PanlSht2
            180, // PanlSht3
            181, // AquaUp1
            182, // AquaUp2
            183, // AquaUp3
            184, // GreenWd1
            185, // GreenWd2
            186, // GreenWd3
            219, // GunDSlEX
            218, // Z-Saber
            221, // Roll
            222, // RollSP
            223, // RollDS
            224, // GutsMan
            225, // GutsMnSP
            226, // GutsMnDS
            227, // WindMan
            228, // WindMnSP
            229, // WindMnDS
            230, // SearchMn
            231, // SrchMnSP
            232, // SrchMnDS
            233, // FireMan
            234, // FireMnSP
            235, // FireMnDS
            236, // ThundrMn
            237, // ThunMnSP
            238, // ThunMnDS
        }; } } // Includes Red Sun Navi chips
        
        public override int[] gameOrderSecretChipsAll { get { return new int[] {
            151, // RollAro1
            152, // RollAro2
            153, // RollAro3
            154, // GutPnch1
            155, // GutPnch2
            156, // GutPnch3
            157, // PropBom1
            158, // PropBom2
            159, // PropBom3
            160, // SeekBom1
            161, // SeekBom2
            162, // SeekBom3
            163, // Meteors1
            164, // Meteors2
            165, // Meteors3
            166, // Ligtnin1
            167, // Ligtnin2
            168, // Ligtnin3
            169, // HawkCut1
            170, // HawkCut2
            171, // HawkCut3
            172, // NumbrBl1
            173, // NumbrBl2
            174, // NumbrBl3
            175, // MetlGer1
            176, // MetlGer2
            177, // MetlGer3
            178, // PanlSht1
            179, // PanlSht2
            180, // PanlSht3
            181, // AquaUp1
            182, // AquaUp2
            183, // AquaUp3
            184, // GreenWd1
            185, // GreenWd2
            186, // GreenWd3
            219, // GunDSlEX
            218, // Z-Saber
        }; } } // Leaves out other-version Navi chips, since they're already in MegaChipsAll
        
        public override int[] gameOrderPAs { get { return new int[] {
            3, // GigaCan1
            4, // GigaCan2
            5, // GigaCan3
            29, // H-Burst
            1, // HeatSprd
            2, // BubSprd
            6, // SuprSpr1
            7, // SuprSpr2
            8, // SuprSpr3
            9, // FlmCros1
            10, // FlmCros2
            11, // FlmCros3
            15, // BstFang1
            16, // BstFang2
            17, // BstFang3
            21, // MagShok1
            22, // MagShok2
            23, // MagShok3
            18, // PitHoky1
            19, // PitHoky2
            20, // PitHoky3
            12, // PitRng1
            13, // PitRng2
            14, // PitRng3
            24, // LifeSrd
            26, // TimeBom+
            28, // BodyGrd
            27, // PoisPhar
            25, // PileDrvr
            0, // DarkNeo
        }; } }
        
        public override string[] keyItemNames { get {
            List<string> allItems = new List<string>();
            
            // First, add standard key item names.
            allItems.AddRange(new string[] {
                "PET", "Earbuds", "RcvPatch", "CyberBat", "???Data", "BootDatA", "BootDatB", "SmTrophy", "FireID", "Paper",
                "Memo", "HintData", "Data1", "Data2", "Data3", "Data4", "Data5", "CyberTop", "Secret1", "Secret2",
                "Secret3", "Secret4", "LabData", "GoldbugM", "GoldbugF", "Mmbrship", "FreePass", "IceCream", "OxyTank", "ShukoKey",
                "SolSensr", "MdTrophy", "LgTrophy", "NetPassp", "KeyDataA", "KeyDataB", "KeyDataC", "KeyDataD", "Mirror", "Comb",
                "BigTree", "Statue", "MghtyBlw", "StrmKiss", "Lecture", "WizCat", "WizRat", "WzDragon", "MagcSeal", "WildDnce",
                "BadJoke", "GoodNose", "Scratch", "GoodEyes", "Thrust", "War", "Emotion", "Comedy", "Pride", "Bird",
                "Dance", "Lance", "Zombie", "ToyPart", "Dancer", "Politicn", "FarmRobo", "GunDelSl", "CrmScarf", "RdUndies",
                "WalshP37", "Otenko", "Sunlight", "Moonlght", "MissSun", "Skylight", "Taiyohh!", "Mo-o-m!", "BaldHead", "C-Slider",
                "TownKyDt", "DadsNote", "CybSutra", "CybCryst", "PlTicket", "RoomKey", "BraveryM", "StrngthM", "WisdomM", "KindnesM",
                "HigsbyAd", "HigsbyKy", "GrasFlut", "VirusCln", "CybrJrky", "Video1", "Video2", "Video3", "BmbShoes", "DumpKey",
                "Transmtr", "License1", "License2", "License3", "GateData", "WaterGun", "FireBstr", "Shovel", "BoardPrt", "JetPart",
                "WingPart", "RedKey", "BlueKey", "GreenKey", "YelowKey", "WhiteKey", "BlackKey", "CopyKey", "RecvrDrp", "LionKey",
                "CursDoll", "NebulaCd", "ChefKey", "Ingrdnts", "KindData", "JomonCde", "CybrSwrd", "WaterGod", "SpinWhit", "SpinPink",
                "SpinYllw", "SpinRed", "SpinBlue", "SpinGrn", "MaylCode", "DexCode", "YaiCode", "HotelCde", "YumlandC", "NetFricC",
                "SharoCde", "CastlCde", "SpaceCde", "MaylBanr", "DexBannr", "YaiBannr", "JomonBnr", "CastlBnr", "HotelBnr", "SpaceBnr"
            });
            
            // Add blanks up to 160, then add upgrade item names.
            while (allItems.Count < 160)
                allItems.Add("");
            allItems.AddRange(upgradeItemNames);
            
            // Add blanks up to 176, then add SubChips.
            while (allItems.Count < 176)
                allItems.Add("");
            allItems.AddRange(subchipNames);
            
            // Add blanks up to 192, then add programs in each color.
            while (allItems.Count < 192)
                allItems.Add("");
            for (int programIndex = 0; programIndex < programNames.Length; programIndex++)
            {
                string myProgramColors = programColors[programIndex];
                for (int colorIndex = 0; colorIndex < myProgramColors.Length; colorIndex++)
                    allItems.Add(programNames[programIndex] + " " + myProgramColors[colorIndex]);
            }
            
            return allItems.ToArray();
        } } // Includes upgrade items, SubChips, and programs for things that use IDs relative to start of key items
        
        public override string[] upgradeItemNames { get { return new string[] {
            "HPMemory", "ExpMemry", "RegUP1", "RegUP2", "RegUP3", "SubMemry"
        }; } }
        
        public override int[][] upgradeItemFlags { get {
            // Add an offset to flags to indicate which level of the Mystery Data they correspond to.
            // Even 1st-time BMDs (loop1) must be distinguished from "this flag exactly corresponds to this being obtained," which is only true for three items.
            int loop1 = 10000;
            int loop2 = 20000;
            int loop3 = 30000;
            
            int[][] flags = new int[upgradeItemNames.Length][];
            // HPMemory
            flags[0] = new int[] { 3392 + loop1, 3409 + loop3, 3457 + loop2, 3464 + loop1, 3474 + loop3,
                                   3529 + loop1, 3537 + loop3, 3545 + loop1, 3544 + loop2, 3584 + loop2,
                                   3600 + loop1, 3609 + loop3, 3610 + loop1, 3632 + loop1, 3641 + loop1,
                                   3714 + loop3, 3722 + loop1, 3722 + loop2, 3777 + loop3, 3785 + loop1,
                                   3793 + loop2, 3801 + loop1, 3841 + loop1, 3850 + loop3, 3856 + loop2,
                                   4164 + loop1, 4190 + loop2, 4198 + loop1, 4172 + loop1, 4174 + loop2,
                                   4202 + loop1 };
            // ExpMemry
            flags[1] = new int[] { 3592 + loop1, 4212 + loop1 };
            // RegUP1
            flags[2] = new int[] { 4258 /* DenDome chairs */, 4257 /* NetFrica house */, 3393 + loop2, 3529 + loop2, 3584 + loop1,
                                   3592 + loop2, 3714 + loop2, 3778 + loop1, 3777 + loop2, 3801 + loop3,
                                   3841 + loop3, 3848 + loop2, 3867 + loop2, 4163 + loop1, 4170 + loop2,
                                   4198 + loop2, 4178 + loop2, 4200 + loop1 };
            // RegUP2
            flags[3] = new int[] { 3328 + loop2, 3457 + loop1, 3456 + loop2, 3520 + loop1, 3521 + loop3,
                                   3713 + loop1, 3722 + loop3, 3794 + loop1, 3801 + loop2, 4170 + loop1,
                                   4184 + loop1 };
            // RegUP3
            flags[4] = new int[] { 4259 /* NAXA spacesuit */, 3850 + loop1 };
            // SubMemry
            flags[5] = new int[] { 4196 + loop1, 4172 + loop2, 4176 + loop1, 3545 + loop3 };
            return flags;
        } }
        
        public override string[] subchipNames { get { return new string[] {
            "MiniEnrg", "FullEnrg", "SneakRun", "Untrap", "LocEnemy", "Unlocker"
        }; } }
        
        public override Dictionary<int, int[]> shopHPMemoryPrices { get {
            Dictionary<int, int[]> def = new Dictionary<int, int[]>();
            def[0] = new int[] { 25, 60, 100 }; // Town Area 3
            def[1] = new int[] { 60, 100, 140 }; // Netopia Area
            def[2] = new int[] { 100, 150, 200, 300 }; // Undernet 1
            def[3] = new int[] { 300, 500 }; // Undernet 5
            def[5] = new int[] { 10, 32 }; // ACDC Area 2
            return def;
        } }
        
        public override string[] presetFolderNames { get { return new string[] {
            "Fldr1", "Fldr2", "HackFldr (1)", "XtraFldr", "ApprFldr", "FamFoldr", "HackFldr (2)", "HackFldr (3)"
        }; } }
        
        public override Dictionary<string, string[]> presetFolders { get {
            Dictionary<string, string[]> def = new Dictionary<string, string[]>();
            def["Fldr1"] = new string[] {
                "Cannon A", "Cannon A", "Cannon B", "Cannon B", "AirShot A", "AirShot A", "AirShot A", "Vulcan1 V", "Vulcan1 V", "Vulcan1 V",
                "MiniBomb B", "MiniBomb B", "MiniBomb L", "MiniBomb L", "Sword S", "Sword S", "Sword S", "Sword S", "WideSwrd S", "WideSwrd S",
                "CrakOut *", "CrakOut *", "CrakOut *", "Recov10 A", "Recov10 A", "Recov10 L", "Recov10 L", "AreaGrab S", "Atk+10 *", "Atk+10 *"
            };
            def["Fldr2"] = new string[] {
                "HeatShot B", "HeatShot B", "HeatShot C", "HeatShot C", "AirShot *", "AirShot *", "AirShot *", "Vulcan1 *", "Vulcan1 *", "Vulcan2 O",
                "MiniBomb B", "MiniBomb B", "MiniBomb *", "MiniBomb *", "Sword E", "Sword E", "Sword E", "Sword E", "WideSwrd E", "WideSwrd E",
                "FlmLine1 F", "WideSht1 C", "Thunder1 L", "Recov50 E", "Recov50 E", "Recov50 E", "Recov50 E", "AreaGrab E", "Atk+10 *", "Atk+10 *"
            };
            def["XtraFldr"] = new string[] {
                "Cannon A", "Cannon A", "Cannon B", "Cannon B", "AirShot A", "AirShot A", "AirShot A", "Vulcan1 V", "Vulcan1 V", "Vulcan1 V",
                "MiniBomb B", "MiniBomb B", "Sword S", "Sword S", "Sword S", "Sword S", "WideSwrd S", "WideSwrd S", "CrakOut *", "CrakOut *",
                "Guard1 *", "Guard1 *", "Recov10 A", "Recov10 A", "Recov10 A", "Recov10 A", "Barrier A", "Barrier A", "Atk+10 *", "Atk+10 *"
            };
            def["ApprFldr"] = new string[] {
                "HiCannon C", "HiCannon C", "HiCannon D", "HiCannon E", "AirShot *", "Vulcan2 O", "Vulcan2 O", "Thunder1 B", "Thunder1 B", "MiniBomb *",
                "MiniBomb *", "EnergBomb E", "EnergBomb E", "Sword E", "Sword E", "WideSwrd E", "WideSwrd E", "LongSwrd E", "CustSwrd B", "CustSwrd B",
                "RockCube *", "Fanfare *", "Geddon1 K", "PnlRetrn *", "Barrier *", "Atk+10 *", "Atk+10 *", "SuprVulc V", "TopMan T", "SparkMan S"
            };
            def["FamFoldr"] = new string[] {
                "M-Cannon E", "M-Cannon F", "M-Cannon G", "M-Cannon G", "AirShot *", "Spreader L", "Spreader M", "Spreader N", "Blizzard *", "HeatBrth *",
                "ElecShok *", "WoodPwdr *", "HeatShot B", "HeatShot C", "HeatShot D", "HeatShot D", "Bubbler P", "Bubbler Q", "Bubbler R", "Bubbler R",
                "TwnFng1 *", "TwnFng1 *", "Recov150 C", "Recov150 C", "Wind *", "Fan *", "Invis *", "SuprVulc V", "BurnMan B", "VideoMan V"
            };
            def["HackFldr (1)"] = new string[] { // Loop 1
                "Cannon A", "Cannon A", "Cannon A", "Cannon A", "AirShot A", "AirShot A", "AirShot A", "AirShot A", "MiniBomb B", "MiniBomb B",
                "MiniBomb B", "MiniBomb B", "Sword S", "Sword S", "Sword S", "Sword S", "CrakOut *", "CrakOut *", "CrakOut *", "CrakOut *",
                "Recov10 A", "Recov10 A", "Recov10 L", "Recov10 L", "AreaGrab S", "AreaGrab S", "Atk+10 *", "Atk+10 *", "Atk+10 *", "Atk+10 *"
            };
            def["HackFldr (2)"] = new string[] { // Loop 2
                "Cannon *", "Cannon *", "Cannon *", "Cannon *", "AirShot *", "AirShot *", "AirShot *", "AirShot *", "Vulcan1 S", "Vulcan1 S",
                "Vulcan1 S", "Vulcan1 S", "MiniBomb *", "MiniBomb *", "MiniBomb *", "MiniBomb *", "Sword S", "Sword S", "Sword S", "Sword S",
                "WideSwrd S", "WideSwrd S", "WideSwrd S", "WideSwrd S", "AreaGrab *", "AreaGrab *", "Atk+10 *", "Atk+10 *", "Atk+10 *", "Atk+10 *"
            };
            def["HackFldr (3)"] = new string[] { // Loop 3
                "MiniBomb *", "MiniBomb *", "MiniBomb *", "MiniBomb *", "EnergBom *", "EnergBom *", "EnergBom *", "EnergBom *", "MegEnBom D", "MegEnBom D",
                "MegEnBom D", "MegEnBom D", "Binder1 S", "Binder1 S", "Binder1 S", "Binder1 S", "Binder2 T", "Binder2 T", "Binder2 T", "Binder2 T",
                "BugBomb B", "BugBomb B", "BugBomb B", "BugBomb B", "AreaGrab *", "AreaGrab *", "Atk+10 *", "Atk+10 *", "Atk+10 *", "Atk+10 *"
            };
            return def;
        } }
        
        public override string[] programNames { get { return new string[] {
            "NONE", "SprArmr", // 36A8
            "Custom1", "Custom2", "MegFldr1", "MegFldr2", // 36B0
            "GigFldr1", "FstBarr", "Shield", "Reflect", // 36C0
            "AntiMagc", "FlotShoe", "AirShoes", "UnderSht", // 36D0
            "SneakRun", "OilBody", "Fish", "Battery", // 36E0
            "Jungle", "Collect", "Humor", "BustPack", // 36F0
            "BodyPack", "HubBatc", "BugStop", "SoulClen", // 3700
            "Rush", "Beat", "Tango", "HeatWepn", // 3710
            "AquaWepn", "ElecWepn", "WoodWepn", "Invisibl", // 3720
            "Attack+1", "Speed+1", "Charge+1", "AttckMAX", // 3730
            "SpeedMAX", "ChargMAX", "WeapLV+1", "HP+50", // 3740
            "HP+100", "HP+200", "HP+300", "HP+400", // 3750
            "HP+500" // 3760
        }; } }
        
        public override string[] programColors { get { return new string[] {
            "----", "---R", // 36A8
            "---B", "---Y", "-P-G", "---G", // 36B0
            "R---", "---W", "---B", "---B", // 36C0
            "---R", "---G", "B---", "W---", // 36D0
            "--Y-", "---R", "-B--", "---Y", // 36E0
            "G---", "-W--", "-P--", "R---", // 36F0
            "B---", "W---", "W---", "-W--", // 3700
            "--Y-", "B---", "-G--", "----", // 3710
            "----", "----", "----", "----", // 3720
            "WPY-", "WPY-", "WPY-", "WPY-", // 3730
            "WPY-", "WPY-", "----", "WPY-", // 3740
            "WPY-", "WPY-", "WPY-", "WPY-", // 3750
            "WPY-" // 3760
        }; } }
        
        public override Dictionary<byte, object[]> programEffectDefs { get {
            Dictionary<byte, object[]> def = new Dictionary<byte, object[]>();
            
            // Format: Variable name, display string, list of value-string pairs
            // If one value given but no string, treat as true/false; if no values given, treat as direct number
            // If first object in list is a string, use special handling and read the rest as pairs:
            // "": Don't include in save info program effects list
            // ">1": Don't display in save info unless greater than 1
            // "%##": Mod by given hex value before check
            // "addedHP": Display total HP added by programs relative to base HP
            // "karma": Display combined karma bytes
            
            def[0x00] = new object[] { "unknownBN400", "Unknown (00)", "" };
            def[0x01] = new object[] { "superArmor", "SuprArmr", 0x01 };
            def[0x02] = new object[] { "floatShoes", "FlotShoe", 0x01 };
            def[0x03] = new object[] { "airShoes", "AirShoes", 0x01 };
            def[0x04] = new object[] { "underShirt", "UnderSht", 0x01 };
            def[0x05] = new object[] { "attackPlus", "Attack+" };
            def[0x06] = new object[] { "speedPlus", "Speed+" };
            def[0x07] = new object[] { "chargePlus", "Charge+" };
            def[0x09] = new object[] { "busterAttack", "Buster Attack", // Gets reset without Patch Card
                0x00, "Normal", 0x20, "WaterGun", 0x21, "Flower", 0x26, "Reflect", 0x34, "CrackBuster",
                0x35, "PoisonBuster", 0x36, "CrakOut", 0x5A, "BlindBuster", 0x62, "Guard1", 0x69, "IceBuster" };
            def[0x0A] = new object[] { "chargeAttack", "Charge Attack", // Gets reset without Patch Card
                0x01, "Normal", 0x04, "ZapRing", 0x28, "GutsMG", 0x29, "Cannon", 0x2A, "MiniBomb",
                0x2B, "HeatShot", 0x2C, "Bubbler", 0x2D, "Thunder1", 0x2E, "Sword", 0x2F, "Spreader",
                0x37, "CopyDmg", 0x38, "WideSht1", 0x3A, "Thunder2", 0x3E, "WideSwrd", 0x42, "Hole",
                0x43, "WideSht2", 0x44, "SandRing", 0x45, "EnergBom", 0x46, "Thunder3", 0x48, "TripCrak",
                0x49, "LongSwrd", 0x4B, "FullCust", 0x4C, "WideSht3", 0x4E, "WindRack", 0x4F, "MegEnBom",
                0x50, "Ball", 0x51, "BugBomb", 0x52, "WideBlde", 0x53, "LongBlde", 0x55, "PnlRetrn",
                0x5B, "Blizzard", 0x5C, "HeatBrth", 0x5D, "WoodPwdr", 0x5E, "Repair", 0x60, "ElecShok" };
            def[0x0C] = new object[] { "shieldType", "Shield (B+Left) Program",
                0xFF, "None", 0x25, "Shield", 0x26, "Reflect", 0x27, "AntiMagc",
                // The rest of these get reset without associated Patch Card, so include -1 to terminate selectable options
                -1, "patchonly", 0x31, "RandomTrap", 0x36, "CrakOut", 0x3C, "DublCrak", 0x40, "Recov10", 0x41, "Lance",
                0x48, "TripCrak", 0x4F, "MegEnBom", 0x51, "BugBomb", 0x54, "NrthWind", 0x55, "PnlRetrn", 0x5F, "AirShot" };
            def[0x0D] = new object[] { "bugEffectAutoMove", "Auto-Move Bug", 0x00, "None", 0x10, "Forward", 0xFF, "Confused" };
            def[0x0E] = new object[] { "bugEffectHPDrain", "Battle HP Drain Bug" };
            def[0x0F] = new object[] { "bugEffectCustomHPDrain", "Custom HP Drain Bug" };
            def[0x10] = new object[] { "unknownBN410", "Unknown (10)", "" };
            def[0x11] = new object[] { "unknownBN411", "Unknown (11)", "" };
            def[0x12] = new object[] { "startingChips", "Starting Chip Slots", "" }; // Already displayed elsewhere, has non-zero value even without programs
            def[0x13] = new object[] { "megaChipLimit", "MegaChip Folder Limit", "" }; // Same as above
            def[0x14] = new object[] { "gigaChipLimit", "GigaChip Folder Limit", "" }; // Same as above
            def[0x16] = new object[] { "sneakRun", "SneakRun", 0x01 };
            def[0x17] = new object[] { "attractType", "Attract Program", 0x1F, "None", 0x02, "OilBody", 0x04, "Fish", 0x08, "Battery", 0x10, "Jungle" };
            def[0x18] = new object[] { "supportType", "Support Program", 0x00, "None", 0x01, "Rush", 0x02, "Beat", 0x04, "Tango",
                -1, "patchonly", 0x07, "TripleSupporter" }; // Gets reset without associated Patch Card
            def[0x19] = new object[] { "rewardType", "Rewards Program", 0x00, "None", 0x01, "Zenny only", 0x02, "Collect" };
            def[0x1B] = new object[] { "panelChange", "Panel Change", // Gets reset without associated Patch Card
                0xFF, "None", 0x01, "Broken", 0x03, "Cracked", 0x05, "Metal", 0x09, "Holy" };
            def[0x1C] = new object[] { "humor", "Humor", 0x01 };
            def[0x1D] = new object[] { "bugStop", "BugStop", 0x01 };
            def[0x1E] = new object[] { "soulCleanse", "SoulClen", 0x01 };
            def[0x1F] = new object[] { "defaultFullSync", "Default Full Synchro", 0x01 }; // Gets reset without associated Patch Card
            def[0x20] = new object[] { "unknownBN420", "Unknown (20)", "" };
            def[0x21] = new object[] { "firstBarrier", "Barrier Effect", 0x00, "None", 0x01, "FstBarr",
                -1, "patchonly", 0x06, "FirstLifeAura" }; // Gets reset without associated Patch Card
            def[0x24] = new object[] { "permanentSoul", "Permanent Soul", // Gets reset without associated Patch Card
                0x00, "None", 0x01, "RollSoul", 0x02, "GutsSoul", 0x03, "WindSoul", 0x04, "SearchSoul", 0x05, "FireSoul", 0x06, "ThunderSoul",
                0x07, "ProtoSoul", 0x08, "NumberSoul", 0x09, "MetalSoul", 0x0A, "JunkSoul", 0x0B, "AquaSoul", 0x0C, "WoodSoul" };
            def[0x27] = new object[] { "megaManColor", "MegaMan Color", 0x00, "Normal", 0x01, "Red", 0x02, "Yellow", 0x03, "White", 0x04, "Green" }; // Gets reset without associated Patch Card
            def[0x28] = new object[] { "allGuard", "AllGuard", 0x01 }; // Gets reset without associated Patch Card
            def[0x2A] = new object[] { "unknownBN42A", "Unknown (2A)", "" };
            def[0x30] = new object[] { "unknownBN430", "Unknown (30)", "" };
            def[0x32] = new object[] { "unknownBN432", "Unknown (32)", "" };
            def[0x34] = new object[] { "unknownBN434", "Unknown (34)", "" };
            def[0x36] = new object[] { "karma", "Karma", "karma" };
            def[0x37] = new object[] { "karmaByte2", "Karma", "" }; // Don't show again for second byte
            def[0xFE] = new object[] { "totalHP", "HP+", "addedHP" }; // Not included with effects internally, but should be included in menu
            return def;
        } }
        
        public override string[] numberTraderCodes { get { return new string[] {
            "MiniEnrg (16589650)",
            "MiniEnrg (45798331)",
            "FullEnrg (84625799)",
            "FullEnrg (59891137)",
            "SneakRun (24247309)",
            "SneakRun (89866302)",
            "Untrap (02368995)",
            "Untrap (14769745)",
            "LocEnemy (27979609)",
            "LocEnemy (37198940)",
            "Unlocker (00274304)",
            "Unlocker (94872322)",
            "Custom2 (Y) (75420107)",
            "MegFldr2 (G) (02109544)",
            "BustPack (R) (05178924)",
            "BodyPack (B) (43494372)",
            "Rush (Y) (73298100)",
            "Beat (B) (25435428)",
            "Tango (G) (10170506)",
            "HP+500 (W) (30873642)",
            "HP+500 (P) (97618739)",
            "WideSht3 T (68009092)",
            "FlmLine1 G (46292983)",
            "FlmLine3 J (57604335)",
            "AirHoc3 V (77038416)",
            "TwnFng3 G (88019791)",
            "VarSwrd C (03696458)",
            "Snake R (32108251)",
            "Recov300 J (66703422)",
            "ColorPt * (19095677)",
            "GunSolEX G (74293099)",
            "Z-Saber Z (72794137)"
        }; } }
        
        public override string[] bbsNames { get { return new string[] {
            "Dex's HP Battle BBS", "Yai's HP Chat BBS", "Netopia Hotel Battle BBS", "Castillo Chat BBS", "JomonElec Chat BBS", "Under BBS"
        }; } }
        
        public override string[] timeTrialNames { get { return new string[] {
            "Roll", "GutsMan", "WindMan", "SearchMan", "FireMan", "ThunderMan", "ProtoMan", "NumberMan", "MetalMan", "JunkMan",
            "AquaMan", "WoodMan", "TopMan", "SparkMan", "BurnerMan", "VideoMan", "ColdMan", "KendoMan", "ShadeMan", "LaserMan"
        }; } }
        
        public override Dictionary<byte, object[]> patchCardDefs { get {
            Dictionary<byte, object[]> def = new Dictionary<byte, object[]>();
            def[0] = new object[] { "Buster MiniBomb", "バスターミニボム", "0A", 0 };
            def[1] = new object[] { "MAX HP +100", "マックスHP+100", "0A", 0 };
            def[2] = new object[] { "MAX HP +100", "マックスHP+100", "0C", 0 };
            def[3] = new object[] { "MAX HP +150", "マックスHP+150", "0B", 0 };
            def[4] = new object[] { "MAX HP +150", "マックスHP+150", "0A", 0 };
            def[5] = new object[] { "MAX HP +200", "マックスHP+200", "0A", 0 };
            def[6] = new object[] { "MAX HP +200", "マックスHP+200", "0B", 0 };
            def[7] = new object[] { "MAX HP +250", "マックスHP+250", "0C", 0 };
            def[8] = new object[] { "MAX HP +250", "マックスHP+250", "0A", 0 };
            def[9] = new object[] { "MAX HP +300", "マックスHP+300", "0A", 0 };
            def[10] = new object[] { "MAX HP +300", "マックスHP+300", "0B", 0 };
            def[11] = new object[] { "FirstBarrier100", "ファーストバリア100", "0C", 1 };
            def[12] = new object[] { "BlindBuster", "ブラインドバスター", "0A", 1 };
            def[13] = new object[] { "GrassBuster", "クサムラバスター", "0A", 0 };
            def[14] = new object[] { "PanelChange: Metal", "パネルチェンジ:メタル", "0D", 0 };
            def[15] = new object[] { "PanelChange: Cracked", "パネルチェンジ:ヒビ", "0D", 0 };
            def[16] = new object[] { "PanelChange: Broken", "パネルチェンジ:アナ", "0D", 0 };
            def[17] = new object[] { "Custom2", "カスタム2", "0A", 1 };
            def[18] = new object[] { "MegaFolder2", "メガフォルダ2", "0D", 1 };
            def[19] = new object[] { "Buster Attack10", "バスター攻撃力10", "0A", 1 };
            def[20] = new object[] { "Charge GutsMG", "チャージガッツマシンガン", "0E", 0 };
            def[21] = new object[] { "Charge Cannon", "チャージキャノン", "0E", 0 };
            def[22] = new object[] { "Charge MiniBomb", "チャージミニボム", "0E", 0 };
            def[23] = new object[] { "Charge HeatShot", "チャージヒートショット", "0E", 0 };
            def[24] = new object[] { "Charge Bubbler", "チャージバブルショット", "0E", 0 };
            def[25] = new object[] { "Charge Thunder1", "チャージサンダーボール1", "0E", 0 };
            def[26] = new object[] { "Charge Sword", "チャージソード", "0E", 0 };
            def[27] = new object[] { "Charge Spreader", "チャージスプレッドガン", "0E", 0 };
            def[28] = new object[] { "PET Scrn Color: Blue", "PET画面カラー:ブルー", "0F", 0 };
            def[29] = new object[] { "PET Scrn Color: Pink", "PET画面カラー:ピンク", "0F", 0 };
            def[30] = new object[] { "PET Scrn Color: Green", "PET画面カラー:グリーン", "0F", 0 };
            def[31] = new object[] { "MAX HP +350", "マックスHP+350", "0B", 0 };
            def[32] = new object[] { "MAX HP +350", "マックスHP+350", "0C", 0 };
            def[33] = new object[] { "MAX HP +400", "マックスHP+400", "0A", 0 };
            def[34] = new object[] { "MAX HP +400", "マックスHP+400", "0B", 0 };
            def[35] = new object[] { "MAX HP +450", "マックスHP+450", "0B", 1 };
            def[36] = new object[] { "MAX HP +450", "マックスHP+450", "0C", 1 };
            def[37] = new object[] { "MAX HP +500", "マックスHP+500", "0E", 0 };
            def[38] = new object[] { "MAX HP +500", "マックスHP+500", "0A", 1 };
            def[39] = new object[] { "B+Left AirShot", "B+左でエアシュート", "0D", 0 };
            def[40] = new object[] { "B+Left RandomTrap", "B+左でランダムトラップ", "0D", 0 };
            def[41] = new object[] { "B+Left BugBomb", "B+左でバグボム", "0D", 0 };
            def[42] = new object[] { "B+Left CrakOut", "B+左でクラックアウト", "0D", 0 };
            def[43] = new object[] { "CrackBuster", "クラックバスター", "0A", 0 };
            def[44] = new object[] { "PoisonBuster", "ポイズンバスター", "0A", 0 };
            def[45] = new object[] { "Default Full Synchro", "デフォルトフルシンクロ", "0C", 0 };
            def[46] = new object[] { "FirstBarrier200", "ファーストバリア200", "0C", 1 };
            def[47] = new object[] { "Buster Guard1", "バスターメットガード1", "0A", 0 };
            def[48] = new object[] { "Buster CrakOut", "バスタークラックアウト", "0A", 0 };
            def[49] = new object[] { "Buster Attack15", "バスター攻撃力15", "0A", 1 };
            def[50] = new object[] { "GigaFolder1", "ギガフォルダ1", "0B", 1 };
            def[51] = new object[] { "Charge CopyDmg", "チャージコピーダメージ", "0E", 0 };
            def[52] = new object[] { "Charge WideSht1", "チャージワイドショット1", "0E", 0 };
            def[53] = new object[] { "Charge Blizzard", "チャージブリザード", "0E", 0 };
            def[54] = new object[] { "Charge HeatBrth", "チャージヒートブレス", "0E", 0 };
            def[55] = new object[] { "Charge ElecShok", "チャージエレキショック", "0E", 0 };
            def[56] = new object[] { "Charge WoodPwdr", "チャージウッディパウダー", "0E", 0 };
            def[57] = new object[] { "Charge PnlRetrn", "チャージパネルリターン", "0E", 0 };
            def[58] = new object[] { "Charge WideSwrd", "チャージワイドソード", "0E", 0 };
            def[59] = new object[] { "MegaMan Color: Red", "ロックマンカラー:レッド", "0C", 0 };
            def[60] = new object[] { "MegaMan Color: Yellow", "ロックマンカラー:イエロー", "0C", 0 };
            def[61] = new object[] { "MAX HP +550", "マックスHP+550", "0B", 0 };
            def[62] = new object[] { "MAX HP +550", "マックスHP+550", "0D", 0 };
            def[63] = new object[] { "MAX HP +600", "マックスHP+600", "0C", 0 };
            def[64] = new object[] { "MAX HP +600", "マックスHP+600", "0A", 0 };
            def[65] = new object[] { "MAX HP +650", "マックスHP+650", "0E", 0 };
            def[66] = new object[] { "MAX HP +650", "マックスHP+650", "0B", 1 };
            def[67] = new object[] { "MAX HP +700", "マックスHP+700", "0A", 1 };
            def[68] = new object[] { "B+Left MegEnBom", "B+左でメガエナジーボム", "0D", 0 };
            def[69] = new object[] { "B+Left Recov10", "B+左でリカバリー10", "0D", 0 };
            def[70] = new object[] { "B+Left PnlRetrn", "B+左でパネルリターン", "0D", 0 };
            def[71] = new object[] { "B+Left NrthWind", "B+左でスーパーキタカゼ", "0D", 0 };
            def[72] = new object[] { "B+Left Lance", "B+左でバンブーランス", "0D", 0 };
            def[73] = new object[] { "B+Left DublCrak", "B+左でダブルクラック", "0D", 0 };
            def[74] = new object[] { "TripleSupporter 1/2", "トリプルサポーター1/2", "0B", 0 };
            def[75] = new object[] { "TripleSupporter 2/2", "トリプルサポーター2/2", "0C", 0 };
            def[76] = new object[] { "AllGuard 1/2", "オールガード1/2", "0C", 1 };
            def[77] = new object[] { "AllGuard 2/2", "オールガード2/2", "0D", 1 };
            def[78] = new object[] { "FirstLifeAura", "ファーストドリームオーラ", "0C", 1 };
            def[79] = new object[] { "Charge Hole", "チャージダークホール", "0E", 0 };
            def[80] = new object[] { "Charge WideSht2", "チャージワイドショット2", "0E", 0 };
            def[81] = new object[] { "Charge ZapRing", "チャージラビリング", "0E", 0 };
            def[82] = new object[] { "Charge SandRing", "チャージサンドリング", "0E", 0 };
            def[83] = new object[] { "Charge EnergBom", "チャージエナジーボム", "0E", 0 };
            def[84] = new object[] { "Charge Thunder2", "チャージサンダーボール2", "0E", 0 };
            def[85] = new object[] { "Charge Repair", "チャージリペアー", "0E", 0 };
            def[86] = new object[] { "Charge TripCrak", "チャージトリプルクラック", "0E", 0 };
            def[87] = new object[] { "Charge LongSwrd", "チャージロングソード", "0E", 0 };
            def[88] = new object[] { "PET Scrn Color: Black", "PET画面カラー:ブラック", "0F", 0 };
            def[89] = new object[] { "MegaMan Color: White", "ロックマンカラー:ホワイト", "0C", 0 };
            def[90] = new object[] { "MegaMan Color: Green", "ロックマンカラー:グリーン", "0C", 0 };
            def[91] = new object[] { "MAX HP +700", "マックスHP+700", "0B", 1 };
            def[92] = new object[] { "MAX HP +750", "マックスHP+750", "0A", 0 };
            def[93] = new object[] { "MAX HP +750", "マックスHP+750", "0B", 1 };
            def[94] = new object[] { "MAX HP +800", "マックスHP+800", "0A", 0 };
            def[95] = new object[] { "MAX HP +800", "マックスHP+800", "0B", 1 };
            def[96] = new object[] { "MAX HP +850", "マックスHP+850", "0A", 0 };
            def[97] = new object[] { "MAX HP +850", "マックスHP+850", "0B", 1 };
            def[98] = new object[] { "MAX HP +900", "マックスHP+900", "0E", 0 };
            def[99] = new object[] { "MAX HP +900", "マックスHP+900", "0B", 1 };
            def[100] = new object[] { "MAX HP +950", "マックスHP+950", "0B", 1 };
            def[101] = new object[] { "MAX HP +1000", "マックスHP+1000", "0E", 0 };
            def[102] = new object[] { "IceBuster", "アイスバスター", "0A", 0 };
            def[103] = new object[] { "Charge FullCust 1/2", "チャージフルカスタム1/2", "0D", 1 };
            def[104] = new object[] { "Charge FullCust 2/2", "チャージフルカスタム2/2", "0E", 1 };
            def[105] = new object[] { "PanelChange: Holy", "パネルチェンジ:ホーリー", "0D", 1 };
            def[106] = new object[] { "Buster Reflect", "バスターリフレクト", "0A", 1 };
            def[107] = new object[] { "Buster Flower", "バスターフラワー", "0A", 0 };
            def[108] = new object[] { "Buster WaterGun", "バスターミズデッポウ", "0A", 0 };
            def[109] = new object[] { "MegaFolder3", "メガフォルダ3", "0C", 1 };
            def[110] = new object[] { "Custom3", "カスタム3", "0D", 1 };
            def[111] = new object[] { "GigaFolder1", "ギガフォルダ1", "0A", 0 };
            def[112] = new object[] { "B+Left TripCrak", "B+左でトリプルクラック", "0D", 0 };
            def[113] = new object[] { "Charge WideSht3", "チャージワイドショット3", "0E", 0 };
            def[114] = new object[] { "Charge Thunder3", "チャージサンダーボール3", "0E", 0 };
            def[115] = new object[] { "Charge WindRack", "チャージフウジンラケット", "0E", 0 };
            def[116] = new object[] { "Charge MegEnBom", "チャージメガエナジーボム", "04", 0 };
            def[117] = new object[] { "Charge Ball", "チャージホウガン", "0E", 0 };
            def[118] = new object[] { "Charge BugBomb", "チャージバグボム", "0E", 0 };
            def[119] = new object[] { "Charge WideBlde", "チャージワイドブレード", "0E", 1 };
            def[120] = new object[] { "Charge LongBlde", "チャージロングブレード", "0E", 1 };
            def[121] = new object[] { "RollSoul", "ロールソウル", "0E", 1 };
            def[122] = new object[] { "GutsSoul", "ガッツソウル", "0E", 1 };
            def[123] = new object[] { "WindSoul", "ウインドソウル", "0E", 1 };
            def[124] = new object[] { "SearchSoul", "サーチソウル", "0E", 1 };
            def[125] = new object[] { "FireSoul", "ファイアソウル", "0E", 1 };
            def[126] = new object[] { "ThunderSoul", "サンダーソウル", "0E", 1 };
            def[127] = new object[] { "ProtoSoul", "ブルースソウル", "0E", 1 };
            def[128] = new object[] { "NumberSoul", "ナンバーソウル", "0E", 1 };
            def[129] = new object[] { "MetalSoul", "メタルソウル", "0E", 1 };
            def[130] = new object[] { "JunkSoul", "ジャンクソウル", "0E", 1 };
            def[131] = new object[] { "AquaSoul", "アクアソウル", "0E", 1 };
            def[132] = new object[] { "WoodSoul", "ウッドソウル", "0E", 1 };
            return def;
        } }
        
        public override object[] safeLocationLansRoom { get { return new object[] { 0x00, 0x02, 0, 0, 0, 0x01 }; } }
        public override object[] startLocationForFreshSave { get { return safeLocationLansRoom; } }
        public override object[] uninitializedJackInLocation { get { return new object[] { 0x05, 0x00, 4, 256, 0, 0x04 }; } } // NAXA Observation Room
        
        public override Dictionary<string, ushort> getStringByteTable(string language = "en", bool lc = false, string subset = "")
        {
            Dictionary<string, ushort> table = new Dictionary<string, ushort>();
            
            if (!lc)
            {
                if (language == "en")
                {
                    // Start with only intended player name characters to terminate early if only those are desired.
                    table["0"] = 0x01;
                    table["1"] = 0x02;
                    table["2"] = 0x03;
                    table["3"] = 0x04;
                    table["4"] = 0x05;
                    table["5"] = 0x06;
                    table["6"] = 0x07;
                    table["7"] = 0x08;
                    table["8"] = 0x09;
                    table["9"] = 0x0A;
                    table["A"] = 0x0B;
                    table["B"] = 0x0C;
                    table["C"] = 0x0D;
                    table["D"] = 0x0E;
                    table["E"] = 0x0F;
                    table["F"] = 0x10;
                    table["G"] = 0x11;
                    table["H"] = 0x12;
                    table["I"] = 0x13;
                    table["J"] = 0x14;
                    table["K"] = 0x15;
                    table["L"] = 0x16;
                    table["M"] = 0x17;
                    table["N"] = 0x18;
                    table["O"] = 0x19;
                    table["P"] = 0x1A;
                    table["Q"] = 0x1B;
                    table["R"] = 0x1C;
                    table["S"] = 0x1D;
                    table["T"] = 0x1E;
                    table["U"] = 0x1F;
                    table["V"] = 0x20;
                    table["W"] = 0x21;
                    table["X"] = 0x22;
                    table["Y"] = 0x23;
                    table["Z"] = 0x24;
                    table["-"] = 0x40;
                    table["—"] = 0x49; // Not actually valid option for name entry, but used for initial English player name and WaitingRoom names
                    table["."] = 0x4E;
                    table["・"] = 0x4F;
                    table["/"] = 0x54;
                    
                    if (subset == "playerName")
                        return table;
                    
                    table["ー"] = 0x82; // Not actually in English table, but used for initial Navi record-holder names in both languages
                    
                    if (subset == "naviRecordHolderNames")
                        return table;
                    
                    table[" "] = 0x00;
                    table["*"] = 0x25;
                    table["a"] = 0x26;
                    table["b"] = 0x27;
                    table["c"] = 0x28;
                    table["d"] = 0x29;
                    table["e"] = 0x2A;
                    table["f"] = 0x2B;
                    table["g"] = 0x2C;
                    table["h"] = 0x2D;
                    table["i"] = 0x2E;
                    table["j"] = 0x2F;
                    table["k"] = 0x30;
                    table["l"] = 0x31;
                    table["m"] = 0x32;
                    table["n"] = 0x33;
                    table["o"] = 0x34;
                    table["p"] = 0x35;
                    table["q"] = 0x36;
                    table["r"] = 0x37;
                    table["s"] = 0x38;
                    table["t"] = 0x39;
                    table["u"] = 0x3A;
                    table["v"] = 0x3B;
                    table["w"] = 0x3C;
                    table["x"] = 0x3D;
                    table["y"] = 0x3E;
                    table["z"] = 0x3F;
                    table["×"] = 0x41;
                    table["="] = 0x42;
                    table[":"] = 0x43;
                    table["%"] = 0x44;
                    table["?"] = 0x45;
                    table["+"] = 0x46;
                    table["÷"] = 0x47;
                    table["※"] = 0x48;
                    table["!"] = 0x4A;
                    table["&"] = 0x4B;
                    table[","] = 0x4C;
                    table["。"] = 0x4D;
                    table[";"] = 0x50;
                    table["'"] = 0x51;
                    table["\""] = 0x52;
                    table["~"] = 0x53;
                    table["("] = 0x55;
                    table[")"] = 0x56;
                    table["「"] = 0x57;
                    table["」"] = 0x58;
                    table["α"] = 0x59;
                    table["β"] = 0x5A;
                    table["Ω"] = 0x5B;
                    //table["[V5]"] = 0x5C;
                    table["_"] = 0x5D;
                    //table["[MB]"] = 0x5E;
                    //table["[z]"] = 0x5F;
                    //table["[square]"] = 0x60;
                    //table["[circle]"] = 0x61;
                    //table["[cross]"] = 0x62;
                    table["■"] = 0x63;
                    table["⋯"] = 0x64;
                    table["…"] = 0x65;
                    table["#"] = 0x66;
                    table["【"] = 0x67;
                    table["】"] = 0x68;
                    table[">"] = 0x69;
                    table["<"] = 0x6A;
                    table["★"] = 0x6B;
                    table["♥"] = 0x6C;
                    table["♦"] = 0x6D;
                    table["♣"] = 0x6E;
                    table["♠"] = 0x6F;
                    table["？"] = 0x7E;
                    table["\n"] = 0xE8;
                }
                else if (language == "jp")
                {
                    // Start with only intended player name characters to terminate early if only those are desired.
                    table["0"] = 0x01;
                    table["1"] = 0x02;
                    table["2"] = 0x03;
                    table["3"] = 0x04;
                    table["4"] = 0x05;
                    table["5"] = 0x06;
                    table["6"] = 0x07;
                    table["7"] = 0x08;
                    table["8"] = 0x09;
                    table["9"] = 0x0A;
                    table["A"] = 0x5E;
                    table["B"] = 0x5F;
                    table["C"] = 0x60;
                    table["D"] = 0x61;
                    table["E"] = 0x62;
                    table["F"] = 0x63;
                    table["G"] = 0x64;
                    table["H"] = 0x65;
                    table["I"] = 0x66;
                    table["J"] = 0x67;
                    table["K"] = 0x68;
                    table["L"] = 0x69;
                    table["M"] = 0x6A;
                    table["N"] = 0x6B;
                    table["O"] = 0x6C;
                    table["P"] = 0x6D;
                    table["Q"] = 0x6E;
                    table["R"] = 0x6F;
                    table["S"] = 0x70;
                    table["T"] = 0x71;
                    table["U"] = 0x72;
                    table["V"] = 0x73;
                    table["W"] = 0x74;
                    table["X"] = 0x75;
                    table["Y"] = 0x76;
                    table["Z"] = 0x77;
                    table["-"] = 0x79;
                    table["."] = 0x89;
                    table["・"] = 0x8A;
                    table["/"] = 0x8F;
                    table["ー"] = 0x82; // Not actually valid option for name entry, but used for initial value of all names in Japanese (and long vowel mark)
                    
                    if (subset == "playerName" || subset == "naviRecordHolderNames")
                        return table;
                    
                    table[" "] = 0x00;
                    table["ア"] = 0x0B;
                    table["イ"] = 0x0C;
                    table["ウ"] = 0x0D;
                    table["エ"] = 0x0E;
                    table["オ"] = 0x0F;
                    table["カ"] = 0x10;
                    table["キ"] = 0x11;
                    table["ク"] = 0x12;
                    table["ケ"] = 0x13;
                    table["コ"] = 0x14;
                    table["サ"] = 0x15;
                    table["シ"] = 0x16;
                    table["ス"] = 0x17;
                    table["セ"] = 0x18;
                    table["ソ"] = 0x19;
                    table["タ"] = 0x1A;
                    table["チ"] = 0x1B;
                    table["ツ"] = 0x1C;
                    table["テ"] = 0x1D;
                    table["ト"] = 0x1E;
                    table["ナ"] = 0x1F;
                    table["ニ"] = 0x20;
                    table["ヌ"] = 0x21;
                    table["ネ"] = 0x22;
                    table["ノ"] = 0x23;
                    table["ハ"] = 0x24;
                    table["ヒ"] = 0x25;
                    table["フ"] = 0x26;
                    table["ヘ"] = 0x27;
                    table["ホ"] = 0x28;
                    table["マ"] = 0x29;
                    table["ミ"] = 0x2A;
                    table["ム"] = 0x2B;
                    table["メ"] = 0x2C;
                    table["モ"] = 0x2D;
                    table["ヤ"] = 0x2E;
                    table["ユ"] = 0x2F;
                    table["ヨ"] = 0x30;
                    table["ラ"] = 0x31;
                    table["リ"] = 0x32;
                    table["ル"] = 0x33;
                    table["レ"] = 0x34;
                    table["ロ"] = 0x35;
                    table["ワ"] = 0x36;
                    table["熱"] = 0x37;
                    table["斗"] = 0x38;
                    table["ヲ"] = 0x39;
                    table["ン"] = 0x3A;
                    table["ガ"] = 0x3B;
                    table["ギ"] = 0x3C;
                    table["グ"] = 0x3D;
                    table["ゲ"] = 0x3E;
                    table["ゴ"] = 0x3F;
                    table["ザ"] = 0x40;
                    table["ジ"] = 0x41;
                    table["ズ"] = 0x42;
                    table["ゼ"] = 0x43;
                    table["ゾ"] = 0x44;
                    table["ダ"] = 0x45;
                    table["ヂ"] = 0x46;
                    table["ヅ"] = 0x47;
                    table["デ"] = 0x48;
                    table["ド"] = 0x49;
                    table["バ"] = 0x4A;
                    table["ビ"] = 0x4B;
                    table["ブ"] = 0x4C;
                    table["ベ"] = 0x4D;
                    table["ボ"] = 0x4E;
                    table["パ"] = 0x4F;
                    table["ピ"] = 0x50;
                    table["プ"] = 0x51;
                    table["ペ"] = 0x52;
                    table["ポ"] = 0x53;
                    table["ァ"] = 0x54;
                    table["ィ"] = 0x55;
                    table["ゥ"] = 0x56;
                    table["ェ"] = 0x57;
                    table["ォ"] = 0x58;
                    table["ッ"] = 0x59;
                    table["ャ"] = 0x5A;
                    table["ュ"] = 0x5B;
                    table["ョ"] = 0x5C;
                    table["ヴ"] = 0x5D;
                    table["*"] = 0x78;
                    table["★"] = 0x7A;
                    table["="] = 0x7B;
                    table[":"] = 0x7C;
                    table["%"] = 0x7D;
                    table["?"] = 0x7E;
                    table["+"] = 0x7F;
                    table["空"] = 0x80;
                    table["港"] = 0x81;
                    table["!"] = 0x83;
                    table["現"] = 0x84;
                    table["実"] = 0x85;
                    table["&"] = 0x86;
                    table["、"] = 0x87;
                    table["。"] = 0x88;
                    table[";"] = 0x8B;
                    table["’"] = 0x8C;
                    table["\""] = 0x8D;
                    table["~"] = 0x8E;
                    table["("] = 0x90;
                    table[")"] = 0x91;
                    table["「"] = 0x92;
                    table["」"] = 0x93;
                    //table["[V2]"] = 0x94;
                    //table["[V3]"] = 0x95;
                    //table["[V4]"] = 0x96;
                    //table["[V5]"] = 0x97;
                    table["_"] = 0x98;
                    //table["[z]"] = 0x99;
                    table["周"] = 0x9A;
                    table["あ"] = 0x9B;
                    table["い"] = 0x9C;
                    table["う"] = 0x9D;
                    table["え"] = 0x9E;
                    table["お"] = 0x9F;
                    table["か"] = 0xA0;
                    table["き"] = 0xA1;
                    table["く"] = 0xA2;
                    table["け"] = 0xA3;
                    table["こ"] = 0xA4;
                    table["さ"] = 0xA5;
                    table["し"] = 0xA6;
                    table["す"] = 0xA7;
                    table["せ"] = 0xA8;
                    table["そ"] = 0xA9;
                    table["た"] = 0xAA;
                    table["ち"] = 0xAB;
                    table["つ"] = 0xAC;
                    table["て"] = 0xAD;
                    table["と"] = 0xAE;
                    table["な"] = 0xAF;
                    table["に"] = 0xB0;
                    table["ぬ"] = 0xB1;
                    table["ね"] = 0xB2;
                    table["の"] = 0xB3;
                    table["は"] = 0xB4;
                    table["ひ"] = 0xB5;
                    table["ふ"] = 0xB6;
                    table["へ"] = 0xB7;
                    table["ほ"] = 0xB8;
                    table["ま"] = 0xB9;
                    table["み"] = 0xBA;
                    table["む"] = 0xBB;
                    table["め"] = 0xBC;
                    table["も"] = 0xBD;
                    table["や"] = 0xBE;
                    table["ゆ"] = 0xBF;
                    table["よ"] = 0xC0;
                    table["ら"] = 0xC1;
                    table["り"] = 0xC2;
                    table["る"] = 0xC3;
                    table["れ"] = 0xC4;
                    table["ろ"] = 0xC5;
                    table["わ"] = 0xC6;
                    table["研"] = 0xC7;
                    table["究"] = 0xC8;
                    table["を"] = 0xC9;
                    table["ん"] = 0xCA;
                    table["が"] = 0xCB;
                    table["ぎ"] = 0xCC;
                    table["ぐ"] = 0xCD;
                    table["げ"] = 0xCE;
                    table["ご"] = 0xCF;
                    table["ざ"] = 0xD0;
                    table["じ"] = 0xD1;
                    table["ず"] = 0xD2;
                    table["ぜ"] = 0xD3;
                    table["ぞ"] = 0xD4;
                    table["だ"] = 0xD5;
                    table["ぢ"] = 0xD6;
                    table["づ"] = 0xD7;
                    table["で"] = 0xD8;
                    table["ど"] = 0xD9;
                    table["ば"] = 0xDA;
                    table["び"] = 0xDB;
                    table["ぶ"] = 0xDC;
                    table["べ"] = 0xDD;
                    table["ぼ"] = 0xDE;
                    table["ぱ"] = 0xDF;
                    table["ぴ"] = 0xE0;
                    table["ぷ"] = 0xE1;
                    table["ぺ"] = 0xE2;
                    table["ぽ"] = 0xE3;
                    table["ぁ"] = 0xE400;
                    table["ぃ"] = 0xE401;
                    table["ぅ"] = 0xE402;
                    table["ぇ"] = 0xE403;
                    table["ぉ"] = 0xE404;
                    table["っ"] = 0xE405;
                    table["ゃ"] = 0xE406;
                    table["ゅ"] = 0xE407;
                    table["ょ"] = 0xE408;
                    table["a"] = 0xE409;
                    table["b"] = 0xE40A;
                    table["c"] = 0xE40B;
                    table["d"] = 0xE40C;
                    table["e"] = 0xE40D;
                    table["f"] = 0xE40E;
                    table["g"] = 0xE40F;
                    table["h"] = 0xE410;
                    table["i"] = 0xE411;
                    table["j"] = 0xE412;
                    table["k"] = 0xE413;
                    table["l"] = 0xE414;
                    table["m"] = 0xE415;
                    table["n"] = 0xE416;
                    table["o"] = 0xE417;
                    table["p"] = 0xE418;
                    table["q"] = 0xE419;
                    table["r"] = 0xE41A;
                    table["s"] = 0xE41B;
                    table["t"] = 0xE41C;
                    table["u"] = 0xE41D;
                    table["v"] = 0xE41E;
                    table["w"] = 0xE41F;
                    table["x"] = 0xE420;
                    table["y"] = 0xE421;
                    table["z"] = 0xE422;
                    table["容"] = 0xE423;
                    table["量"] = 0xE424;
                    table["全"] = 0xE425;
                    table["木"] = 0xE426;
                    //table["[MB]"] = 0xE427;
                    table["無"] = 0xE428;
                    table["嵐"] = 0xE429;
                    //table["[square]"] = 0xE42A;
                    table["○"] = 0xE42B;
                    table["×"] = 0xE42C;
                    table["駅"] = 0xE42D;
                    table["匠"] = 0xE42E;
                    table["不"] = 0xE42F;
                    table["止"] = 0xE430;
                    table["彩"] = 0xE431;
                    table["起"] = 0xE432;
                    table["父"] = 0xE433;
                    table["集"] = 0xE434;
                    table["院"] = 0xE435;
                    table["一"] = 0xE436;
                    table["二"] = 0xE437;
                    table["三"] = 0xE438;
                    table["四"] = 0xE439;
                    table["五"] = 0xE43A;
                    table["六"] = 0xE43B;
                    table["七"] = 0xE43C;
                    table["八"] = 0xE43D;
                    table["陽"] = 0xE43E;
                    table["十"] = 0xE43F;
                    table["百"] = 0xE440;
                    table["千"] = 0xE441;
                    table["万"] = 0xE442;
                    table["脳"] = 0xE443;
                    table["上"] = 0xE444;
                    table["下"] = 0xE445;
                    table["左"] = 0xE446;
                    table["右"] = 0xE447;
                    table["手"] = 0xE448;
                    table["足"] = 0xE449;
                    table["日"] = 0xE44A;
                    table["目"] = 0xE44B;
                    table["月"] = 0xE44C;
                    table["転"] = 0xE44D;
                    table["各"] = 0xE44E;
                    table["人"] = 0xE44F;
                    table["入"] = 0xE450;
                    table["出"] = 0xE451;
                    table["山"] = 0xE452;
                    table["口"] = 0xE453;
                    table["光"] = 0xE454;
                    table["電"] = 0xE455;
                    table["気"] = 0xE456;
                    table["助"] = 0xE457;
                    table["科"] = 0xE458;
                    table["戸"] = 0xE459;
                    table["名"] = 0xE45A;
                    table["前"] = 0xE45B;
                    table["学"] = 0xE45C;
                    table["校"] = 0xE45D;
                    table["省"] = 0xE45E;
                    table["祐"] = 0xE45F;
                    table["室"] = 0xE460;
                    table["世"] = 0xE461;
                    table["界"] = 0xE462;
                    table["舟"] = 0xE463;
                    table["朗"] = 0xE464;
                    table["枚"] = 0xE465;
                    table["野"] = 0xE466;
                    table["悪"] = 0xE467;
                    table["路"] = 0xE468;
                    table["闇"] = 0xE469;
                    table["大"] = 0xE46A;
                    table["小"] = 0xE46B;
                    table["中"] = 0xE46C;
                    table["自"] = 0xE46D;
                    table["分"] = 0xE46E;
                    table["間"] = 0xE46F;
                    table["村"] = 0xE470;
                    table["花"] = 0xE471;
                    table["問"] = 0xE472;
                    table["異"] = 0xE473;
                    table["門"] = 0xE474;
                    table["城"] = 0xE475;
                    table["王"] = 0xE476;
                    table["兄"] = 0xE477;
                    table["帯"] = 0xE478;
                    table["道"] = 0xE479;
                    table["行"] = 0xE47A;
                    table["街"] = 0xE47B;
                    table["屋"] = 0xE47C;
                    table["水"] = 0xE47D;
                    table["見"] = 0xE47E;
                    table["終"] = 0xE47F;
                    table["丁"] = 0xE480;
                    table["桜"] = 0xE481;
                    table["先"] = 0xE482;
                    table["生"] = 0xE483;
                    table["長"] = 0xE484;
                    table["今"] = 0xE485;
                    table["了"] = 0xE486;
                    table["点"] = 0xE487;
                    table["井"] = 0xE488;
                    table["子"] = 0xE489;
                    table["言"] = 0xE48A;
                    table["太"] = 0xE48B;
                    table["属"] = 0xE48C;
                    table["風"] = 0xE48D;
                    table["会"] = 0xE48E;
                    table["性"] = 0xE48F;
                    table["持"] = 0xE490;
                    table["時"] = 0xE491;
                    table["勝"] = 0xE492;
                    table["赤"] = 0xE493;
                    table["毎"] = 0xE494;
                    table["年"] = 0xE495;
                    table["火"] = 0xE496;
                    table["改"] = 0xE497;
                    table["計"] = 0xE498;
                    table["画"] = 0xE499;
                    table["休"] = 0xE49A;
                    table["体"] = 0xE49B;
                    table["波"] = 0xE49C;
                    table["回"] = 0xE49D;
                    table["外"] = 0xE49E;
                    table["地"] = 0xE49F;
                    table["病"] = 0xE4A0;
                    table["正"] = 0xE4A1;
                    table["造"] = 0xE4A2;
                    table["値"] = 0xE4A3;
                    table["合"] = 0xE4A4;
                    table["戦"] = 0xE4A5;
                    table["川"] = 0xE4A6;
                    table["秋"] = 0xE4A7;
                    table["原"] = 0xE4A8;
                    table["町"] = 0xE4A9;
                    table["所"] = 0xE4AA;
                    table["用"] = 0xE4AB;
                    table["金"] = 0xE4AC;
                    table["郎"] = 0xE4AD;
                    table["作"] = 0xE4AE;
                    table["数"] = 0xE4AF;
                    table["方"] = 0xE4B0;
                    table["社"] = 0xE4B1;
                    table["攻"] = 0xE4B2;
                    table["撃"] = 0xE4B3;
                    table["力"] = 0xE4B4;
                    table["同"] = 0xE4B5;
                    table["武"] = 0xE4B6;
                    table["何"] = 0xE4B7;
                    table["発"] = 0xE4B8;
                    table["少"] = 0xE4B9;
                    table["味"] = 0xE4BA;
                    table["以"] = 0xE4BB;
                    table["白"] = 0xE4BC;
                    table["早"] = 0xE4BD;
                    table["暮"] = 0xE4BE;
                    table["面"] = 0xE4BF;
                    table["組"] = 0xE4C0;
                    table["後"] = 0xE4C1;
                    table["文"] = 0xE4C2;
                    table["字"] = 0xE4C3;
                    table["本"] = 0xE4C4;
                    table["階"] = 0xE4C5;
                    table["明"] = 0xE4C6;
                    table["才"] = 0xE4C7;
                    table["者"] = 0xE4C8;
                    table["立"] = 0xE4C9;
                    table["泉"] = 0xE4CA;
                    table["々"] = 0xE4CB;
                    table["ヶ"] = 0xE4CC;
                    table["連"] = 0xE4CD;
                    table["射"] = 0xE4CE;
                    table["国"] = 0xE4CF;
                    table["綾"] = 0xE4D0;
                    table["切"] = 0xE4D1;
                    table["土"] = 0xE4D2;
                    table["炎"] = 0xE4D3;
                    table["伊"] = 0xE4D4;
                    table["■"] = 0xE4D5;
                    table["\n"] = 0xE8;
                }
            }
            else
            {
                if (language == "en")
                {
                    // Start with only intended player name characters to terminate early if only those are desired.
                    table["0"] = 0x6401;
                    table["1"] = 0x6402;
                    table["2"] = 0x6403;
                    table["3"] = 0x6404;
                    table["4"] = 0x6405;
                    table["5"] = 0x6406;
                    table["6"] = 0x6407;
                    table["7"] = 0x6408;
                    table["8"] = 0x6409;
                    table["9"] = 0x640A;
                    table["A"] = 0x640B;
                    table["B"] = 0x640C;
                    table["C"] = 0x640D;
                    table["D"] = 0x640E;
                    table["E"] = 0x640F;
                    table["F"] = 0x6410;
                    table["G"] = 0x6411;
                    table["H"] = 0x6412;
                    table["I"] = 0x6413;
                    table["J"] = 0x6414;
                    table["K"] = 0x6415;
                    table["L"] = 0x6416;
                    table["M"] = 0x6417;
                    table["N"] = 0x6418;
                    table["O"] = 0x6419;
                    table["P"] = 0x641A;
                    table["Q"] = 0x641B;
                    table["R"] = 0x641C;
                    table["S"] = 0x641D;
                    table["T"] = 0x641E;
                    table["U"] = 0x641F;
                    table["V"] = 0x6420;
                    table["W"] = 0x6421;
                    table["X"] = 0x6422;
                    table["Y"] = 0x6423;
                    table["Z"] = 0x6424;
                    table["-"] = 0x6440; // Used for initial English player name and WaitingRoom names
                    table["."] = 0x6450;
                    table["・"] = 0x6451;
                    table["/"] = 0x6456;
                    
                    if (subset == "playerName")
                        return table;
                    
                    table["ー"] = 0x6482; // Not actually valid option for name entry, but used for initial Navi record-holder names in both languages
                    
                    if (subset == "naviRecordHolderNames")
                        return table;
                    
                    table[" "] = 0x6400;
                    table["*"] = 0x6425;
                    table["a"] = 0x6426;
                    table["b"] = 0x6427;
                    table["c"] = 0x6428;
                    table["d"] = 0x6429;
                    table["e"] = 0x642A;
                    table["f"] = 0x642B;
                    table["g"] = 0x642C;
                    table["h"] = 0x642D;
                    table["i"] = 0x642E;
                    table["j"] = 0x642F;
                    table["k"] = 0x6430;
                    table["l"] = 0x6431;
                    table["m"] = 0x6432;
                    table["n"] = 0x6433;
                    table["o"] = 0x6434;
                    table["p"] = 0x6435;
                    table["q"] = 0x6436;
                    table["r"] = 0x6437;
                    table["s"] = 0x6438;
                    table["t"] = 0x6439;
                    table["u"] = 0x643A;
                    table["v"] = 0x643B;
                    table["w"] = 0x643C;
                    table["x"] = 0x643D;
                    table["y"] = 0x643E;
                    table["z"] = 0x643F;
                    table["★"] = 0x6441;
                    table["="] = 0x6442;
                    table[":"] = 0x6443;
                    table["%"] = 0x6444;
                    table["?"] = 0x6445;
                    table["+"] = 0x6446;
                    table["÷"] = 0x6447;
                    table["※"] = 0x6448;
                    table["—"] = 0x6449;
                    table["―"] = 0x644A;
                    table["!"] = 0x644B;
                    table["&"] = 0x644C;
                    table["、"] = 0x644D;
                    table[","] = 0x644E;
                    table["。"] = 0x644F;
                    table[";"] = 0x6452;
                    table["'"] = 0x6453;
                    table["\""] = 0x6454;
                    table["~"] = 0x6455;
                    table["("] = 0x6457;
                    table[")"] = 0x6458;
                    table["「"] = 0x6459;
                    table["」"] = 0x645A;
                    //table["[V2]"] = 0x645B;
                    //table["[V3]"] = 0x645C;
                    //table["[V4]"] = 0x645D;
                    table["α"] = 0x645E;
                    table["β"] = 0x645F;
                    table["Ω"] = 0x6460;
                    table["Ⅴ"] = 0x6461;
                    table["_"] = 0x6462;
                    //table["[MB]"] = 0x6463;
                    //table["[z]"] = 0x6464;
                    table["◇"] = 0x6465;
                    table["○"] = 0x6466;
                    table["×"] = 0x6467;
                    table["◆"] = 0x6468;
                    table["■"] = 0x6469;
                    table["…"] = 0x646A;
                    //table["[space]"] = 0x646B;
                    table["#"] = 0x646C;
                    table["["] = 0x646D;
                    table["]"] = 0x646E;
                    //table["[bracket1]"] = 0x646F;
                    //table["[bracket2]"] = 0x6470;
                    table["<"] = 0x6471;
                    table[">"] = 0x6472;
                    table["☆"] = 0x6473;
                    table["♥"] = 0x6474;
                    table["♦"] = 0x6475;
                    table["♣"] = 0x6476;
                    table["♠"] = 0x6477;
                    table["Ⅵ"] = 0x6478;
                    table["\n"] = 0xE8;
                }
                else if (language == "jp")
                {
                    // Start with only intended player name characters to terminate early if only those are desired.
                    table["0"] = 0x6401;
                    table["1"] = 0x6402;
                    table["2"] = 0x6403;
                    table["3"] = 0x6404;
                    table["4"] = 0x6405;
                    table["5"] = 0x6406;
                    table["6"] = 0x6407;
                    table["7"] = 0x6408;
                    table["8"] = 0x6409;
                    table["9"] = 0x640A;
                    table["A"] = 0x645E;
                    table["B"] = 0x645F;
                    table["C"] = 0x6460;
                    table["D"] = 0x6461;
                    table["E"] = 0x6462;
                    table["F"] = 0x6463;
                    table["G"] = 0x6464;
                    table["H"] = 0x6465;
                    table["I"] = 0x6466;
                    table["J"] = 0x6467;
                    table["K"] = 0x6468;
                    table["L"] = 0x6469;
                    table["M"] = 0x646A;
                    table["N"] = 0x646B;
                    table["O"] = 0x646C;
                    table["P"] = 0x646D;
                    table["Q"] = 0x646E;
                    table["R"] = 0x646F;
                    table["S"] = 0x6470;
                    table["T"] = 0x6471;
                    table["U"] = 0x6472;
                    table["V"] = 0x6473;
                    table["W"] = 0x6474;
                    table["X"] = 0x6475;
                    table["Y"] = 0x6476;
                    table["Z"] = 0x6477;
                    table["-"] = 0x6479;
                    table["."] = 0x6489;
                    table["・"] = 0x648A;
                    table["/"] = 0x648F;
                    
                    if (subset == "playerName")
                        return table;
                    
                    table["ー"] = 0x6482; // Not actually valid option for name entry, but used for initial value of all names in Japanese (and long vowel mark)
                    
                    if (subset == "naviRecordHolderNames")
                        return table;
                    
                    table[" "] = 0x6400;
                    table["ア"] = 0x640B;
                    table["イ"] = 0x640C;
                    table["ウ"] = 0x640D;
                    table["エ"] = 0x640E;
                    table["オ"] = 0x640F;
                    table["カ"] = 0x6410;
                    table["キ"] = 0x6411;
                    table["ク"] = 0x6412;
                    table["ケ"] = 0x6413;
                    table["コ"] = 0x6414;
                    table["サ"] = 0x6415;
                    table["シ"] = 0x6416;
                    table["ス"] = 0x6417;
                    table["セ"] = 0x6418;
                    table["ソ"] = 0x6419;
                    table["タ"] = 0x641A;
                    table["チ"] = 0x641B;
                    table["ツ"] = 0x641C;
                    table["テ"] = 0x641D;
                    table["ト"] = 0x641E;
                    table["ナ"] = 0x641F;
                    table["ニ"] = 0x6420;
                    table["ヌ"] = 0x6421;
                    table["ネ"] = 0x6422;
                    table["ノ"] = 0x6423;
                    table["ハ"] = 0x6424;
                    table["ヒ"] = 0x6425;
                    table["フ"] = 0x6426;
                    table["ヘ"] = 0x6427;
                    table["ホ"] = 0x6428;
                    table["マ"] = 0x6429;
                    table["ミ"] = 0x642A;
                    table["ム"] = 0x642B;
                    table["メ"] = 0x642C;
                    table["モ"] = 0x642D;
                    table["ヤ"] = 0x642E;
                    table["ユ"] = 0x642F;
                    table["ヨ"] = 0x6430;
                    table["ラ"] = 0x6431;
                    table["リ"] = 0x6432;
                    table["ル"] = 0x6433;
                    table["レ"] = 0x6434;
                    table["ロ"] = 0x6435;
                    table["ワ"] = 0x6436;
                    table["熱"] = 0x6437;
                    table["斗"] = 0x6438;
                    table["ヲ"] = 0x6439;
                    table["ン"] = 0x643A;
                    table["ガ"] = 0x643B;
                    table["ギ"] = 0x643C;
                    table["グ"] = 0x643D;
                    table["ゲ"] = 0x643E;
                    table["ゴ"] = 0x643F;
                    table["ザ"] = 0x6440;
                    table["ジ"] = 0x6441;
                    table["ズ"] = 0x6442;
                    table["ゼ"] = 0x6443;
                    table["ゾ"] = 0x6444;
                    table["ダ"] = 0x6445;
                    table["ヂ"] = 0x6446;
                    table["ヅ"] = 0x6447;
                    table["デ"] = 0x6448;
                    table["ド"] = 0x6449;
                    table["バ"] = 0x644A;
                    table["ビ"] = 0x644B;
                    table["ブ"] = 0x644C;
                    table["ベ"] = 0x644D;
                    table["ボ"] = 0x644E;
                    table["パ"] = 0x644F;
                    table["ピ"] = 0x6450;
                    table["プ"] = 0x6451;
                    table["ペ"] = 0x6452;
                    table["ポ"] = 0x6453;
                    table["ァ"] = 0x6454;
                    table["ィ"] = 0x6455;
                    table["ゥ"] = 0x6456;
                    table["ェ"] = 0x6457;
                    table["ォ"] = 0x6458;
                    table["ッ"] = 0x6459;
                    table["ャ"] = 0x645A;
                    table["ュ"] = 0x645B;
                    table["ョ"] = 0x645C;
                    table["ヴ"] = 0x645D;
                    table["*"] = 0x6478;
                    table["★"] = 0x647A;
                    table["="] = 0x647B;
                    table[":"] = 0x647C;
                    table["%"] = 0x647D;
                    table["?"] = 0x647E;
                    table["+"] = 0x647F;
                    table["空"] = 0x6480;
                    table["港"] = 0x6481;
                    table["!"] = 0x6483;
                    table["現"] = 0x6484;
                    table["実"] = 0x6485;
                    table["&"] = 0x6486;
                    table["、"] = 0x6487;
                    table["。"] = 0x6488;
                    table[";"] = 0x648B;
                    table["'"] = 0x648C;
                    table["\""] = 0x648D;
                    table["~"] = 0x648E;
                    table["("] = 0x6490;
                    table[")"] = 0x6491;
                    table["「"] = 0x6492;
                    table["」"] = 0x6493;
                    //table["[V2]"] = 0x6494;
                    //table["[V3]"] = 0x6495;
                    //table["[V4]"] = 0x6496;
                    //table["[V5]"] = 0x6497;
                    table["_"] = 0x6498;
                    //table["[z]"] = 0x6499;
                    table["周"] = 0x649A;
                    table["あ"] = 0x649B;
                    table["い"] = 0x649C;
                    table["う"] = 0x649D;
                    table["え"] = 0x649E;
                    table["お"] = 0x649F;
                    table["か"] = 0x64A0;
                    table["き"] = 0x64A1;
                    table["く"] = 0x64A2;
                    table["け"] = 0x64A3;
                    table["こ"] = 0x64A4;
                    table["さ"] = 0x64A5;
                    table["し"] = 0x64A6;
                    table["す"] = 0x64A7;
                    table["せ"] = 0x64A8;
                    table["そ"] = 0x64A9;
                    table["た"] = 0x64AA;
                    table["ち"] = 0x64AB;
                    table["つ"] = 0x64AC;
                    table["て"] = 0x64AD;
                    table["と"] = 0x64AE;
                    table["な"] = 0x64AF;
                    table["に"] = 0x64B0;
                    table["ぬ"] = 0x64B1;
                    table["ね"] = 0x64B2;
                    table["の"] = 0x64B3;
                    table["は"] = 0x64B4;
                    table["ひ"] = 0x64B5;
                    table["ふ"] = 0x64B6;
                    table["へ"] = 0x64B7;
                    table["ほ"] = 0x64B8;
                    table["ま"] = 0x64B9;
                    table["み"] = 0x64BA;
                    table["む"] = 0x64BB;
                    table["め"] = 0x64BC;
                    table["も"] = 0x64BD;
                    table["や"] = 0x64BE;
                    table["ゆ"] = 0x64BF;
                    table["よ"] = 0x64C0;
                    table["ら"] = 0x64C1;
                    table["り"] = 0x64C2;
                    table["る"] = 0x64C3;
                    table["れ"] = 0x64C4;
                    table["ろ"] = 0x64C5;
                    table["わ"] = 0x64C6;
                    table["ゐ"] = 0x64C7;
                    table["ゑ"] = 0x64C8;
                    table["を"] = 0x64C9;
                    table["ん"] = 0x64CA;
                    table["が"] = 0x64CB;
                    table["ぎ"] = 0x64CC;
                    table["ぐ"] = 0x64CD;
                    table["げ"] = 0x64CE;
                    table["ご"] = 0x64CF;
                    table["ざ"] = 0x64D0;
                    table["じ"] = 0x64D1;
                    table["ず"] = 0x64D2;
                    table["ぜ"] = 0x64D3;
                    table["ぞ"] = 0x64D4;
                    table["だ"] = 0x64D5;
                    table["ぢ"] = 0x64D6;
                    table["づ"] = 0x64D7;
                    table["で"] = 0x64D8;
                    table["ど"] = 0x64D9;
                    table["ば"] = 0x64DA;
                    table["び"] = 0x64DB;
                    table["ぶ"] = 0x64DC;
                    table["べ"] = 0x64DD;
                    table["ぼ"] = 0x64DE;
                    table["ぱ"] = 0x64DF;
                    table["ぴ"] = 0x64E0;
                    table["ぷ"] = 0x64E1;
                    table["ぺ"] = 0x64E2;
                    table["ぽ"] = 0x64E3;
                    table["ぁ"] = 0x64E4;
                    table["ぃ"] = 0x64E5;
                    table["ぅ"] = 0x64E6;
                    table["ぇ"] = 0x64E7;
                    table["ぉ"] = 0x64E8;
                    table["っ"] = 0x64E9;
                    table["ゃ"] = 0x64EA;
                    table["ゅ"] = 0x64EB;
                    table["ょ"] = 0x64EC;
                    table["a"] = 0x64ED;
                    table["b"] = 0x64EE;
                    table["c"] = 0x64EF;
                    table["d"] = 0x64F0;
                    table["e"] = 0x64F1;
                    table["f"] = 0x64F2;
                    table["g"] = 0x64F3;
                    table["h"] = 0x64F4;
                    table["i"] = 0x64F5;
                    table["j"] = 0x64F6;
                    table["k"] = 0x64F7;
                    table["l"] = 0x64F8;
                    table["m"] = 0x64F9;
                    table["n"] = 0x64FA;
                    table["o"] = 0x64FB;
                    table["p"] = 0x64FC;
                    table["q"] = 0x64FD;
                    table["r"] = 0x64FE;
                    table["s"] = 0x64FF;
                    table["t"] = 0x6500;
                    table["u"] = 0x6501;
                    table["v"] = 0x6502;
                    table["w"] = 0x6503;
                    table["x"] = 0x6504;
                    table["y"] = 0x6505;
                    table["z"] = 0x6506;
                    table["容"] = 0x6507;
                    table["量"] = 0x6508;
                    table["全"] = 0x6509;
                    table["木"] = 0x650A;
                    //table["[MB]"] = 0x650B;
                    table["無"] = 0x650C;
                    table["嵐"] = 0x650D;
                    table["◇"] = 0x650E;
                    table["○"] = 0x650F;
                    table["×"] = 0x6510;
                    table["駅"] = 0x6511;
                    table["匠"] = 0x6512;
                    table["不"] = 0x6513;
                    table["止"] = 0x6514;
                    table["彩"] = 0x6515;
                    table["起"] = 0x6516;
                    table["父"] = 0x6517;
                    table["集"] = 0x6518;
                    table["院"] = 0x6519;
                    table["一"] = 0x651A;
                    table["二"] = 0x651B;
                    table["三"] = 0x651C;
                    table["四"] = 0x651D;
                    table["五"] = 0x651E;
                    table["六"] = 0x651F;
                    table["七"] = 0x6520;
                    table["八"] = 0x6521;
                    table["陽"] = 0x6522;
                    table["十"] = 0x6523;
                    table["百"] = 0x6524;
                    table["千"] = 0x6525;
                    table["万"] = 0x6526;
                    table["脳"] = 0x6527;
                    table["上"] = 0x6528;
                    table["下"] = 0x6529;
                    table["左"] = 0x652A;
                    table["右"] = 0x652B;
                    table["手"] = 0x652C;
                    table["足"] = 0x652D;
                    table["日"] = 0x652E;
                    table["目"] = 0x652F;
                    table["月"] = 0x6530;
                    table["転"] = 0x6531;
                    table["各"] = 0x6532;
                    table["人"] = 0x6533;
                    table["入"] = 0x6534;
                    table["出"] = 0x6535;
                    table["山"] = 0x6536;
                    table["口"] = 0x6537;
                    table["光"] = 0x6538;
                    table["電"] = 0x6539;
                    table["気"] = 0x653A;
                    table["助"] = 0x653B;
                    table["科"] = 0x653C;
                    table["戸"] = 0x653D;
                    table["名"] = 0x653E;
                    table["前"] = 0x653F;
                    table["学"] = 0x6540;
                    table["校"] = 0x6541;
                    table["省"] = 0x6542;
                    table["祐"] = 0x6543;
                    table["室"] = 0x6544;
                    table["世"] = 0x6545;
                    table["界"] = 0x6546;
                    table["舟"] = 0x6547;
                    table["朗"] = 0x6548;
                    table["枚"] = 0x6549;
                    table["野"] = 0x654A;
                    table["悪"] = 0x654B;
                    table["路"] = 0x654C;
                    table["闇"] = 0x654D;
                    table["大"] = 0x654E;
                    table["小"] = 0x654F;
                    table["中"] = 0x6550;
                    table["自"] = 0x6551;
                    table["分"] = 0x6552;
                    table["間"] = 0x6553;
                    table["村"] = 0x6554;
                    table["花"] = 0x6555;
                    table["問"] = 0x6556;
                    table["異"] = 0x6557;
                    table["門"] = 0x6558;
                    table["城"] = 0x6559;
                    table["王"] = 0x655A;
                    table["兄"] = 0x655B;
                    table["帯"] = 0x655C;
                    table["道"] = 0x655D;
                    table["行"] = 0x655E;
                    table["街"] = 0x655F;
                    table["屋"] = 0x6560;
                    table["水"] = 0x6561;
                    table["見"] = 0x6562;
                    table["終"] = 0x6563;
                    table["丁"] = 0x6564;
                    table["桜"] = 0x6565;
                    table["先"] = 0x6566;
                    table["生"] = 0x6567;
                    table["長"] = 0x6568;
                    table["今"] = 0x6569;
                    table["了"] = 0x656A;
                    table["点"] = 0x656B;
                    table["井"] = 0x656C;
                    table["子"] = 0x656D;
                    table["言"] = 0x656E;
                    table["太"] = 0x656F;
                    table["属"] = 0x6570;
                    table["風"] = 0x6571;
                    table["会"] = 0x6572;
                    table["性"] = 0x6573;
                    table["持"] = 0x6574;
                    table["時"] = 0x6575;
                    table["勝"] = 0x6576;
                    table["赤"] = 0x6577;
                    table["毎"] = 0x6578;
                    table["年"] = 0x6579;
                    table["火"] = 0x657A;
                    table["改"] = 0x657B;
                    table["計"] = 0x657C;
                    table["画"] = 0x657D;
                    table["休"] = 0x657E;
                    table["体"] = 0x657F;
                    table["波"] = 0x6580;
                    table["回"] = 0x6581;
                    table["外"] = 0x6582;
                    table["地"] = 0x6583;
                    table["病"] = 0x6584;
                    table["正"] = 0x6585;
                    table["造"] = 0x6586;
                    table["値"] = 0x6587;
                    table["合"] = 0x6588;
                    table["戦"] = 0x6589;
                    table["川"] = 0x658A;
                    table["秋"] = 0x658B;
                    table["原"] = 0x658C;
                    table["町"] = 0x658D;
                    table["所"] = 0x658E;
                    table["用"] = 0x658F;
                    table["金"] = 0x6590;
                    table["郎"] = 0x6591;
                    table["作"] = 0x6592;
                    table["数"] = 0x6593;
                    table["方"] = 0x6594;
                    table["社"] = 0x6595;
                    table["攻"] = 0x6596;
                    table["撃"] = 0x6597;
                    table["力"] = 0x6598;
                    table["同"] = 0x6599;
                    table["武"] = 0x659A;
                    table["何"] = 0x659B;
                    table["発"] = 0x659C;
                    table["少"] = 0x659D;
                    table["味"] = 0x659E;
                    table["以"] = 0x659F;
                    table["白"] = 0x65A0;
                    table["早"] = 0x65A1;
                    table["暮"] = 0x65A2;
                    table["面"] = 0x65A3;
                    table["組"] = 0x65A4;
                    table["後"] = 0x65A5;
                    table["文"] = 0x65A6;
                    table["字"] = 0x65A7;
                    table["本"] = 0x65A8;
                    table["階"] = 0x65A9;
                    table["明"] = 0x65AA;
                    table["才"] = 0x65AB;
                    table["者"] = 0x65AC;
                    table["立"] = 0x65AD;
                    table["泉"] = 0x65AE;
                    table["々"] = 0x65AF;
                    table["ヶ"] = 0x65B0;
                    table["連"] = 0x65B1;
                    table["射"] = 0x65B2;
                    table["国"] = 0x65B3;
                    table["綾"] = 0x65B4;
                    table["切"] = 0x65B5;
                    table["土"] = 0x65B6;
                    table["炎"] = 0x65B7;
                    table["伊"] = 0x65B8;
                    table["■"] = 0x65B9;
                    table["Ⅵ"] = 0x65BA;
                    table["\n"] = 0xE8;
                }
            }
            
            return table;
        }
        
        public override int[] getGameStartFlags(char version = 'M')
        {
            List<int> flags = new List<int>();
            
            flags.Add(44);
            for (int i = 418; i <= 421; i++)
                flags.Add(i);
            for (int i = 463; i <= 469; i++)
                flags.Add(i);
            for (int i = 769; i <= 770; i++)
                flags.Add(i);
            flags.Add(797);
            flags.Add(870);
            for (int i = 1338; i <= 1341; i++)
                flags.Add(i);
            for (int i = 1941; i <= 1946; i++)
                flags.Add(i);
            for (int i = 1953; i <= 1955; i++)
                flags.Add(i);
            flags.Add(2256);
            for (int i = 2695; i <= 2700; i++)
                flags.Add(i);
            for (int i = 2784; i <= 2787; i++)
                flags.Add(i);
            for (int i = 3020; i <= 3023; i++)
                flags.Add(i);
            flags.Add(3101);
            flags.Add(4468); // Usually enabled to allow movement
            flags.Add(4477);
            for (int i = 4608; i <= 4619; i++) // Dex's HP Battle BBS posts
                flags.Add(i);
            for (int i = 4672; i <= 4677; i++) // Yai's HP Chat BBS posts
                flags.Add(i);
            for (int i = 4800; i <= 4809; i++) // Castillo Chat BBS posts
                flags.Add(i);
            for (int i = 4864; i <= 4871; i++) // JomonElec Chat BBS posts
                flags.Add(i);
            for (int i = 4928; i <= 4936; i++) // Under BBS posts
                flags.Add(i);
            for (int i = 5120; i <= 5131; i++) // Dex's HP Battle BBS posts unread
                flags.Add(i);
            for (int i = 5184; i <= 5189; i++) // Yai's HP Chat BBS posts unread
                flags.Add(i);
            for (int i = 5312; i <= 5321; i++) // Castillo Chat BBS posts unread
                flags.Add(i);
            for (int i = 5376; i <= 5383; i++) // JomonElec Chat BBS posts unread
                flags.Add(i);
            for (int i = 5440; i <= 5448; i++) // Under BBS posts unread
                flags.Add(i);
            flags.Add(5577);
            flags.Add(5705);
            
            return flags.ToArray();
        }
        
        public override ShopItem[][] getInitialShopInventories(char version = 'M')
        {
            ShopItem[][] shops = new ShopItem[16][];
            
            bool bm = version == 'S';
            
            shops[0] = new ShopItem[] {
                new ShopItem(0x01, 0xA0, 0xFF, 25, 1), new ShopItem(0x01, 0xA0, 0xFF, 60, 1),
                new ShopItem(0x01, 0xA0, 0xFF, 100, 1), new ShopItem(0x02, 0x01, 0x02, 20, 255),
                new ShopItem(0x02, 0x85, 0x1A, 33, 4), new ShopItem(0x02, 0x6E, 0x01, 50, 3),
                new ShopItem(0x02, 0x61, 0x0A, 120, 1), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[1] = new ShopItem[] {
                new ShopItem(0x01, 0xA0, 0xFF, 60, 1), new ShopItem(0x01, 0xA0, 0xFF, 100, 1),
                new ShopItem(0x01, 0xA0, 0xFF, 140, 1), new ShopItem(0x02, 0x73, 0x0F, 40, 2),
                new ShopItem(0x02, 0x06, 0x0A, 50, 255), new ShopItem(0x02, 0x10, 0x07, 63, 3),
                new ShopItem(0x02, 0x38, 0x11, 88, 2), new ShopItem(0x02, 0x77, 0x0F, 95, 1)
            };
            shops[2] = new ShopItem[] {
                new ShopItem(0x01, 0xA0, 0xFF, 100, 1), new ShopItem(0x01, 0xA0, 0xFF, 150, 1),
                new ShopItem(0x01, 0xA0, 0xFF, 200, 1), new ShopItem(0x01, 0xA0, 0xFF, 300, 1),
                new ShopItem(0x02, 0x78, 0x04, 82, 1), new ShopItem(0x02, 0x79, 0x10, 98, 1),
                new ShopItem(0x02, 0x8A, 0x13, 100, 3), new ShopItem(0x02, 0x1B, 0x19, 160, 1)
            };
            shops[3] = new ShopItem[] {
                new ShopItem(0x01, 0xA0, 0xFF, 300, 1), new ShopItem(0x01, 0xA0, 0xFF, 500, 1),
                new ShopItem(0x02, 0x5F, 0x0A, 140, 1), new ShopItem(0x02, 0x90, 0x0C, 160, 1),
                new ShopItem(0x02, 0xD3, 0x02, 220, 1), new ShopItem(0x02, 0xCD, 0x1A, 280, 1),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[4] = new ShopItem[] {
                new ShopItem(0x02, 0x12, 0x0B, 38, 255), new ShopItem(0x02, 0x7A, 0x1A, 45, 3),
                new ShopItem(0x02, 0x1C, 0x10, 55, 2), new ShopItem(0x02, 0x7C, 0x0D, 68, 1),
                new ShopItem(0x02, 0x02, 0x02, 84, 3), new ShopItem(0x02, 0x6F, 0x09, 100, 1),
                new ShopItem(0x02, 0x34, 0x06, 120, 2), new ShopItem(0x02, 0xDC, 0x15, 210, 1)
            };
            shops[5] = new ShopItem[] {
                new ShopItem(0x01, 0xA0, 0xFF, 10, 1), new ShopItem(0x01, 0xA0, 0xFF, 32, 1),
                new ShopItem(0x02, 0x16, 0x11, 8, 255), new ShopItem(0x02, 0x1E, 0x04, 24, 2),
                new ShopItem(0x02, 0x12, 0x1A, 32, 1), new ShopItem(0x02, 0x08, 0x0B, 76, 1),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[6] = new ShopItem[] {
                new ShopItem(0x01, 0xB1, 0xFF, 10, 255), new ShopItem(0x01, 0xB4, 0xFF, 100, 255),
                new ShopItem(0x01, 0xB5, 0xFF, 40, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[7] = new ShopItem[] {
                new ShopItem(0x01, 0xB0, 0xFF, 1, 255), new ShopItem(0x01, 0xB2, 0xFF, 2, 255),
                new ShopItem(0x01, 0xB4, 0xFF, 100, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[8] = new ShopItem[] {
                new ShopItem(0x01, 0xB1, 0xFF, 10, 255), new ShopItem(0x01, 0xB2, 0xFF, 2, 255),
                new ShopItem(0x01, 0xB3, 0xFF, 1, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[9] = new ShopItem[] {
                new ShopItem(0x01, 0xB1, 0xFF, 10, 255), new ShopItem(0x01, 0xB4, 0xFF, 100, 255),
                new ShopItem(0x01, 0xB5, 0xFF, 40, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[10] = new ShopItem[] {
                new ShopItem(0x01, 0xB1, 0xFF, 10, 255), new ShopItem(0x01, 0xB5, 0xFF, 40, 255),
                new ShopItem(0x01, 0xB4, 0xFF, 100, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[11] = new ShopItem[] {
                new ShopItem(0x01, 0xB3, 0xFF, 1, 255), new ShopItem(0x01, 0xB2, 0xFF, 2, 255),
                new ShopItem(0x01, 0xB5, 0xFF, 40, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[12] = new ShopItem[] {
                new ShopItem(0x03, 0x38, 0x03, 8, 1), new ShopItem(0x02, 0x8B, 0x1A, 10, 1),
                new ShopItem(0x03, 0xB4, 0x02, 16, 1), new ShopItem(0x02, 0x91, 0x11, 24, 1),
                new ShopItem(0x03, 0x4C, 0x01, 42, 1), new ShopItem(0x02, 0xD2, 0x11, 60, 1),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[13] = new ShopItem[] {
                new ShopItem(0x03, 0x30, 0x05, 22, 1), new ShopItem(0x02, 0x96, 0x1A, 28, 1),
                new ShopItem(0x03, 0x28, 0x04, 36, 1), new ShopItem(0x02, 0x7D, 0x14, 50, 1),
                new ShopItem(0x03, 0x94, 0x01, 72, 1), new ShopItem(0x02, (ushort)(!bm? 0x133 : 0x131), (ushort)(!bm? 0x07 : 0x12), 100, 1), // HolyDrem H in RS vs. SignlRed S in BM
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[14] = new ShopItem[] {
                new ShopItem(0x03, 0xA8, 0x03, 34, 1), new ShopItem(0x03, 0x9C, 0x02, 48, 1),
                new ShopItem(0x03, 0x20, 0x05, 55, 1), new ShopItem(0x03, 0x1C, 0x01, 68, 1),
                new ShopItem(0x03, 0x10, 0x06, 80, 1), new ShopItem(0x03, 0x08, 0x05, 96, 1),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[15] = new ShopItem[] {
                new ShopItem(0x03, 0xB0, 0x02, 96, 1), new ShopItem(0x03, 0x3C, 0x04, 62, 1),
                new ShopItem(0x03, 0x10, 0x06, 80, 1), new ShopItem(0x03, 0x08, 0x05, 96, 1),
                new ShopItem(0x03, 0x2C, 0x06, 84, 1), new ShopItem(0x03, 0x24, 0x05, 130, 1),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            
            return shops;
        }
        
        public override ShopItem[] getInitialChipOrderInventory(char version = 'M')
        {
            return new ShopItem[] {
                new ShopItem(0x02, 0x01, 0x01, 15, 1), new ShopItem(0x02, 0x02, 0x03, 40, 1), 
                new ShopItem(0x02, 0x03, 0x05, 85, 1), new ShopItem(0x02, 0x04, 0x00, 20, 1), 
                new ShopItem(0x02, 0x0F, 0x12, 10, 1), new ShopItem(0x02, 0x10, 0x07, 50, 1), 
                new ShopItem(0x02, 0x11, 0x13, 105, 1), new ShopItem(0x02, 0x12, 0x0C, 35, 1), 
                new ShopItem(0x02, 0x13, 0x02, 18, 1), new ShopItem(0x02, 0x14, 0x03, 66, 1), 
                new ShopItem(0x02, 0x15, 0x04, 99, 1), new ShopItem(0x02, 0x16, 0x10, 46, 1), 
                new ShopItem(0x02, 0x17, 0x03, 82, 1), new ShopItem(0x02, 0x18, 0x04, 108, 1), 
                new ShopItem(0x02, 0x39, 0x01, 18, 1), new ShopItem(0x02, 0x3A, 0x07, 49, 1), 
                new ShopItem(0x02, 0x3B, 0x08, 102, 1), new ShopItem(0x02, 0x09, 0x03, 35, 1), 
                new ShopItem(0x02, 0x0A, 0x0C, 68, 1), new ShopItem(0x02, 0x0B, 0x12, 116, 1), 
                new ShopItem(0x02, 0x0C, 0x05, 50, 1), new ShopItem(0x02, 0x0D, 0x04, 93, 1), 
                new ShopItem(0x02, 0x0E, 0x0A, 133, 1), new ShopItem(0x02, 0x20, 0x06, 100, 1), 
                new ShopItem(0x02, 0x21, 0x06, 200, 1), new ShopItem(0x02, 0x22, 0x06, 300, 1), 
                new ShopItem(0x02, 0x05, 0x09, 56, 1), new ShopItem(0x02, 0x06, 0x0A, 82, 1), 
                new ShopItem(0x02, 0x2A, 0x0B, 111, 1), new ShopItem(0x02, 0x2B, 0x13, 139, 1), 
                new ShopItem(0x02, 0x2F, 0x11, 48, 1), new ShopItem(0x02, 0x45, 0x00, 60, 1), 
                new ShopItem(0x02, 0x46, 0x0E, 93, 1), new ShopItem(0x02, 0x47, 0x05, 120, 1), 
                new ShopItem(0x02, 0x19, 0x0D, 85, 1), new ShopItem(0x02, 0x1A, 0x10, 110, 1), 
                new ShopItem(0x02, 0x7E, 0x03, 140, 1), new ShopItem(0x02, 0x80, 0x00, 160, 1), 
                new ShopItem(0x02, 0x23, 0x02, 57, 1), new ShopItem(0x02, 0x24, 0x05, 88, 1), 
                new ShopItem(0x02, 0x25, 0x01, 113, 1), new ShopItem(0x02, 0x08, 0x0B, 130, 1), 
                new ShopItem(0x02, 0x1B, 0x06, 98, 1), new ShopItem(0x02, 0x1D, 0x01, 5, 1), 
                new ShopItem(0x02, 0x1E, 0x0D, 60, 1), new ShopItem(0x02, 0x1F, 0x09, 120, 1), 
                new ShopItem(0x02, 0x2C, 0x13, 150, 1), new ShopItem(0x02, 0x2E, 0x19, 128, 1), 
                new ShopItem(0x02, 0x2D, 0x01, 105, 1), new ShopItem(0x02, 0x29, 0x06, 77, 1), 
                new ShopItem(0x02, 0x26, 0x0E, 45, 1), new ShopItem(0x02, 0x27, 0x13, 86, 1), 
                new ShopItem(0x02, 0x28, 0x08, 127, 1), new ShopItem(0x02, 0x30, 0x12, 18, 1), 
                new ShopItem(0x02, 0x31, 0x12, 48, 1), new ShopItem(0x02, 0x32, 0x12, 79, 1), 
                new ShopItem(0x02, 0x33, 0x0A, 125, 1), new ShopItem(0x02, 0x34, 0x06, 158, 1), 
                new ShopItem(0x02, 0x36, 0x01, 94, 1), new ShopItem(0x02, 0x37, 0x15, 170, 1), 
                new ShopItem(0x02, 0x38, 0x11, 105, 1), new ShopItem(0x02, 0x35, 0x00, 100, 1), 
                new ShopItem(0x02, 0x3F, 0x03, 52, 1), new ShopItem(0x02, 0x40, 0x08, 97, 1), 
                new ShopItem(0x02, 0x41, 0x14, 132, 1), new ShopItem(0x02, 0x3C, 0x0C, 69, 1), 
                new ShopItem(0x02, 0x3D, 0x07, 99, 1), new ShopItem(0x02, 0x3E, 0x0D, 130, 1), 
                new ShopItem(0x02, 0x4B, 0x0C, 52, 1), new ShopItem(0x02, 0x4C, 0x0C, 89, 1), 
                new ShopItem(0x02, 0x4D, 0x13, 117, 1), new ShopItem(0x02, 0x4E, 0x08, 48, 1), 
                new ShopItem(0x02, 0x4F, 0x07, 89, 1), new ShopItem(0x02, 0x50, 0x00, 116, 1), 
                new ShopItem(0x02, 0x51, 0x06, 133, 1), new ShopItem(0x02, 0x48, 0x0B, 66, 1), 
                new ShopItem(0x02, 0x49, 0x02, 108, 1), new ShopItem(0x02, 0x4A, 0x0A, 130, 1), 
                new ShopItem(0x02, 0x82, 0x02, 64, 1), new ShopItem(0x02, 0x83, 0x0A, 102, 1), 
                new ShopItem(0x02, 0x84, 0x18, 128, 1), new ShopItem(0x02, 0x42, 0x13, 78, 1), 
                new ShopItem(0x02, 0x43, 0x06, 107, 1), new ShopItem(0x02, 0x44, 0x0C, 139, 1), 
                new ShopItem(0x02, 0x60, 0x0C, 150, 1), new ShopItem(0x02, 0x5E, 0x10, 180, 1), 
                new ShopItem(0x02, 0x68, 0x11, 55, 1), new ShopItem(0x02, 0x69, 0x09, 98, 1), 
                new ShopItem(0x02, 0x6A, 0x15, 125, 1), new ShopItem(0x02, 0x55, 0x09, 80, 1), 
                new ShopItem(0x02, 0x56, 0x08, 110, 1), new ShopItem(0x02, 0x57, 0x06, 140, 1), 
                new ShopItem(0x02, 0x61, 0x0A, 130, 1), new ShopItem(0x02, 0x62, 0x19, 160, 1), 
                new ShopItem(0x02, 0x63, 0x1A, 20, 1), new ShopItem(0x02, 0x53, 0x1A, 10, 1), 
                new ShopItem(0x02, 0x54, 0x1A, 20, 1), new ShopItem(0x02, 0x64, 0x06, 60, 1), 
                new ShopItem(0x02, 0x65, 0x13, 70, 1), new ShopItem(0x02, 0x66, 0x13, 80, 1), 
                new ShopItem(0x02, 0x07, 0x0C, 90, 1), new ShopItem(0x02, 0x67, 0x18, 198, 1), 
                new ShopItem(0x02, 0x58, 0x0B, 13, 1), new ShopItem(0x02, 0x59, 0x06, 42, 1), 
                new ShopItem(0x02, 0x5A, 0x11, 91, 1), new ShopItem(0x02, 0x5B, 0x1A, 12, 1), 
                new ShopItem(0x02, 0x5C, 0x1A, 36, 1), new ShopItem(0x02, 0x5D, 0x1A, 69, 1), 
                new ShopItem(0x02, 0x6B, 0x00, 14, 1), new ShopItem(0x02, 0x6C, 0x05, 35, 1), 
                new ShopItem(0x02, 0x6D, 0x04, 59, 1), new ShopItem(0x02, 0x6E, 0x01, 78, 1), 
                new ShopItem(0x02, 0x6F, 0x05, 112, 1), new ShopItem(0x02, 0x70, 0x02, 138, 1), 
                new ShopItem(0x02, 0x71, 0x07, 160, 1), new ShopItem(0x02, 0x72, 0x09, 190, 1), 
                new ShopItem(0x02, 0x73, 0x0F, 42, 1), new ShopItem(0x02, 0x74, 0x18, 59, 1), 
                new ShopItem(0x02, 0x75, 0x12, 89, 1), new ShopItem(0x02, 0x5F, 0x0A, 200, 1), 
                new ShopItem(0x02, 0x77, 0x0A, 101, 1), new ShopItem(0x02, 0x76, 0x09, 182, 1), 
                new ShopItem(0x02, 0x7A, 0x1A, 39, 1), new ShopItem(0x02, 0x7B, 0x16, 90, 1), 
                new ShopItem(0x02, 0x7C, 0x0D, 110, 1), new ShopItem(0x02, 0x7D, 0x14, 150, 1), 
                new ShopItem(0x02, 0x78, 0x04, 66, 1), new ShopItem(0x02, 0x79, 0x10, 123, 1), 
                new ShopItem(0x02, 0x81, 0x1A, 60, 1), new ShopItem(0x02, 0x8A, 0x13, 132, 1), 
                new ShopItem(0x02, 0x8B, 0x1A, 80, 1), new ShopItem(0x02, 0x52, 0x1A, 200, 1), 
                new ShopItem(0x02, 0x85, 0x1A, 50, 1), new ShopItem(0x02, 0x86, 0x0F, 135, 1), 
                new ShopItem(0x02, 0x87, 0x03, 24, 1), new ShopItem(0x02, 0x88, 0x10, 94, 1), 
                new ShopItem(0x02, 0x89, 0x0E, 144, 1), new ShopItem(0x02, 0x8C, 0x0A, 100, 1), 
                new ShopItem(0x02, 0x8D, 0x03, 100, 1), new ShopItem(0x02, 0x8E, 0x07, 100, 1), 
                new ShopItem(0x02, 0x8F, 0x0C, 100, 1), new ShopItem(0x02, 0x91, 0x0C, 127, 1), 
                new ShopItem(0x02, 0x92, 0x02, 119, 1), new ShopItem(0x02, 0x90, 0x0C, 200, 1), 
                new ShopItem(0x02, 0x93, 0x03, 106, 1), new ShopItem(0x02, 0x94, 0x1A, 69, 1), 
                new ShopItem(0x02, 0x1C, 0x10, 53, 1), new ShopItem(0x02, 0x95, 0x1A, 38, 1), 
                new ShopItem(0x02, 0x96, 0x1A, 121, 1), new ShopItem(0x02, 0x7F, 0x1A, 99, 1), 
                new ShopItem(0x02, 0x97, 0x05, 100, 1), new ShopItem(0x02, 0x98, 0x11, 150, 1), 
                new ShopItem(0x02, 0x99, 0x18, 200, 1), new ShopItem(0x02, 0x9A, 0x04, 100, 1), 
                new ShopItem(0x02, 0x9B, 0x0F, 150, 1), new ShopItem(0x02, 0x9C, 0x10, 200, 1), 
                new ShopItem(0x02, 0x9D, 0x06, 100, 1), new ShopItem(0x02, 0x9E, 0x15, 150, 1), 
                new ShopItem(0x02, 0x9F, 0x09, 200, 1), new ShopItem(0x02, 0xA0, 0x11, 100, 1), 
                new ShopItem(0x02, 0xA1, 0x08, 150, 1), new ShopItem(0x02, 0xA2, 0x14, 200, 1), 
                new ShopItem(0x02, 0xA3, 0x0B, 100, 1), new ShopItem(0x02, 0xA4, 0x10, 150, 1), 
                new ShopItem(0x02, 0xA5, 0x11, 200, 1), new ShopItem(0x02, 0xA6, 0x13, 100, 1), 
                new ShopItem(0x02, 0xA7, 0x04, 150, 1), new ShopItem(0x02, 0xA8, 0x09, 200, 1), 
                new ShopItem(0x02, 0xA9, 0x0D, 100, 1), new ShopItem(0x02, 0xAA, 0x12, 150, 1), 
                new ShopItem(0x02, 0xAB, 0x0D, 200, 1), new ShopItem(0x02, 0xAC, 0x0B, 100, 1), 
                new ShopItem(0x02, 0xAD, 0x04, 150, 1), new ShopItem(0x02, 0xAE, 0x13, 200, 1), 
                new ShopItem(0x02, 0xAF, 0x0C, 100, 1), new ShopItem(0x02, 0xB0, 0x04, 150, 1), 
                new ShopItem(0x02, 0xB1, 0x0B, 200, 1), new ShopItem(0x02, 0xB2, 0x07, 100, 1), 
                new ShopItem(0x02, 0xB3, 0x06, 150, 1), new ShopItem(0x02, 0xB4, 0x09, 200, 1), 
                new ShopItem(0x02, 0xB5, 0x12, 100, 1), new ShopItem(0x02, 0xB6, 0x0F, 150, 1), 
                new ShopItem(0x02, 0xB7, 0x0A, 200, 1), new ShopItem(0x02, 0xB8, 0x18, 100, 1), 
                new ShopItem(0x02, 0xB9, 0x0A, 150, 1), new ShopItem(0x02, 0xBA, 0x0D, 200, 1), 
                new ShopItem(0x02, 0xDC, 0x15, 212, 1), new ShopItem(0x02, 0xD9, 0x0D, 240, 1), 
                new ShopItem(0x02, 0xD2, 0x11, 215, 1), new ShopItem(0x02, 0xD7, 0x06, 208, 1), 
                new ShopItem(0x02, 0xCB, 0x0E, 210, 1), new ShopItem(0x02, 0xD4, 0x09, 166, 1), 
                new ShopItem(0x02, 0xD3, 0x02, 177, 1), new ShopItem(0x02, 0xCE, 0x01, 160, 1), 
                new ShopItem(0x02, 0xD1, 0x1A, 198, 1), new ShopItem(0x02, 0xC9, 0x03, 198, 1), 
                new ShopItem(0x02, 0xD0, 0x12, 200, 1), new ShopItem(0x02, 0xCD, 0x1A, 179, 1), 
                new ShopItem(0x02, 0xCF, 0x1A, 165, 1), new ShopItem(0x02, 0xCA, 0x0C, 223, 1), 
                new ShopItem(0x02, 0xCC, 0x00, 240, 1), new ShopItem(0x02, 0xD5, 0x04, 199, 1), 
                new ShopItem(0x02, 0xD6, 0x16, 218, 1), new ShopItem(0x02, 0xD8, 0x0B, 235, 1), 
                new ShopItem(0x02, 0xDB, 0x06, 300, 0), new ShopItem(0x02, 0xDA, 0x19, 300, 0), 
                new ShopItem(0x02, 0xDD, 0x11, 100, 1), new ShopItem(0x02, 0xDE, 0x11, 200, 1), 
                new ShopItem(0x02, 0xDF, 0x11, 200, 1), new ShopItem(0x02, 0xE0, 0x06, 100, 1), 
                new ShopItem(0x02, 0xE1, 0x06, 200, 1), new ShopItem(0x02, 0xE2, 0x06, 200, 1), 
                new ShopItem(0x02, 0xE3, 0x16, 100, 1), new ShopItem(0x02, 0xE4, 0x16, 200, 1), 
                new ShopItem(0x02, 0xE5, 0x16, 200, 1), new ShopItem(0x02, 0xE6, 0x12, 100, 1), 
                new ShopItem(0x02, 0xE7, 0x12, 200, 1), new ShopItem(0x02, 0xE8, 0x12, 200, 1), 
                new ShopItem(0x02, 0xE9, 0x05, 100, 1), new ShopItem(0x02, 0xEA, 0x05, 200, 1), 
                new ShopItem(0x02, 0xEB, 0x05, 200, 1), new ShopItem(0x02, 0xEC, 0x13, 100, 1), 
                new ShopItem(0x02, 0xED, 0x13, 200, 1), new ShopItem(0x02, 0xEE, 0x13, 200, 1), 
                new ShopItem(0x02, 0xEF, 0x01, 100, 1), new ShopItem(0x02, 0xF0, 0x01, 200, 1), 
                new ShopItem(0x02, 0xF1, 0x01, 200, 1), new ShopItem(0x02, 0xF2, 0x0D, 100, 1), 
                new ShopItem(0x02, 0xF3, 0x0D, 200, 1), new ShopItem(0x02, 0xF4, 0x0D, 200, 1), 
                new ShopItem(0x02, 0xF5, 0x0C, 100, 1), new ShopItem(0x02, 0xF6, 0x0C, 200, 1), 
                new ShopItem(0x02, 0xF7, 0x0C, 200, 1), new ShopItem(0x02, 0xF8, 0x09, 100, 1), 
                new ShopItem(0x02, 0xF9, 0x09, 200, 1), new ShopItem(0x02, 0xFA, 0x09, 200, 1), 
                new ShopItem(0x02, 0xFB, 0x00, 100, 1), new ShopItem(0x02, 0xFC, 0x00, 200, 1), 
                new ShopItem(0x02, 0xFD, 0x00, 200, 1), new ShopItem(0x02, 0xFE, 0x16, 100, 1), 
                new ShopItem(0x02, 0xFF, 0x16, 200, 1), new ShopItem(0x02, 0x100, 0x16, 200, 1), 
                new ShopItem(0x02, 0x101, 0x13, 100, 1), new ShopItem(0x02, 0x102, 0x13, 200, 1), 
                new ShopItem(0x02, 0x103, 0x13, 200, 1), new ShopItem(0x02, 0x107, 0x01, 100, 1), 
                new ShopItem(0x02, 0x108, 0x01, 200, 1), new ShopItem(0x02, 0x109, 0x01, 200, 1), 
                new ShopItem(0x02, 0x10A, 0x02, 100, 1), new ShopItem(0x02, 0x10B, 0x02, 200, 1), 
                new ShopItem(0x02, 0x10C, 0x02, 200, 1), new ShopItem(0x02, 0x10D, 0x12, 100, 1), 
                new ShopItem(0x02, 0x10E, 0x12, 200, 1), new ShopItem(0x02, 0x10F, 0x12, 200, 1), 
                new ShopItem(0x02, 0x104, 0x17, 100, 1), new ShopItem(0x02, 0x105, 0x17, 200, 1), 
                new ShopItem(0x02, 0x106, 0x17, 200, 1), new ShopItem(0x02, 0x110, 0x0B, 100, 1), 
                new ShopItem(0x02, 0x111, 0x0B, 200, 1), new ShopItem(0x02, 0x112, 0x0B, 200, 1), 
                new ShopItem(0x02, 0x113, 0x0A, 100, 1), new ShopItem(0x02, 0x114, 0x0A, 200, 1), 
                new ShopItem(0x02, 0x115, 0x0A, 200, 1), new ShopItem(0x02, 0x116, 0x15, 100, 1), 
                new ShopItem(0x02, 0x117, 0x15, 200, 1), new ShopItem(0x02, 0x118, 0x15, 200, 1)
            };
        }
        
        public override byte[] getInitialBBSPostsList()
        {
            byte[] postBytes = new byte[0x200];
            for (int i = 0; i < postBytes.Length; i++)
                postBytes[i] = 0x40;
            
            int bbsNum = 0; // Dex's HP Battle BBS
            for (byte i = 0x00; i <= 0x0B; i++)
                postBytes[(bbsNum * 0x40) + i] = i;
            
            bbsNum = 1; // Yai's HP Chat BBS
            for (byte i = 0x00; i <= 0x05; i++)
                postBytes[(bbsNum * 0x40) + i] = i;
            
            bbsNum = 3; // Castillo Chat BBS
            for (byte i = 0x00; i <= 0x09; i++)
                postBytes[(bbsNum * 0x40) + i] = i;
            
            bbsNum = 4; // JomonElec Chat BBS
            for (byte i = 0x00; i <= 0x07; i++)
                postBytes[(bbsNum * 0x40) + i] = i;
            
            bbsNum = 5; // Under BBS
            for (byte i = 0x00; i <= 0x08; i++)
                postBytes[(bbsNum * 0x40) + i] = i;
            
            return postBytes;
        }
        
        public override uint getBaseEncounterPointerForArea(byte area, byte subsection = 0xFF, char version = 'M', string language = "en", bool lc = false)
        {
            int baseAddress = 0x0;
            int type = !lc && language == "en"? 0 : !lc && language == "jp"? 1 : 2;
            switch (area)
            {
                // Type 0: GBA English (Red Sun), type 1: GBA Japanese (Red Sun), type 2: Legacy Collection (in labels.bin)
                case 0x80: baseAddress = type == 0? 0x80FC82C : type == 1? 0x80FC700 : 0x42D70; break; // ElecTower Comp
                case 0x81: baseAddress = type == 0? 0x80FCA98 : type == 1? 0x80FC96C : 0x42FE0; break; // ToyRobo Comp
                case 0x82: baseAddress = type == 0? 0x80FCF64 : type == 1? 0x80FCE38 : 0x434B0; break; // Asteroid Comp
                case 0x83: baseAddress = type == 0? 0x80FD464 : type == 1? 0x80FD338 : 0x439B0; break; // (Unused)
                case 0x84: baseAddress = type == 0? 0x80FD61C : type == 1? 0x80FD530 : 0x43BA8; break; // (Unused)
                case 0x85: baseAddress = type == 0? 0x80FD814 : type == 1? 0x80FD728 : 0x43DA0; break; // (Unused)
                case 0x86: baseAddress = type == 0? 0x80FDA0C : type == 1? 0x80FD920 : 0x43F98; break; // (Unused)
                case 0x87: baseAddress = type == 0? 0x80FDC04 : type == 1? 0x80FDB18 : 0x44190; break; // (Unused)
                case 0x88: baseAddress = type == 0? 0x80FDE3C : type == 1? 0x80FDD10 : 0x44388; break; // Home Pages
                case 0x89: baseAddress = type == 0? 0x80FDFF4 : type == 1? 0x80FDF08 : 0x44580; break; // (Unused)
                case 0x8A: baseAddress = type == 0? 0x80FE1EC : type == 1? 0x80FE100 : 0x44778; break; // (Unused)
                case 0x8B: baseAddress = type == 0? 0x80FE3E4 : type == 1? 0x80FE2F8 : 0x44970; break; // (Unused)
                case 0x8C: baseAddress = type == 0? 0x80FE5DC : type == 1? 0x80FE4F0 : 0x44B68; break; // Cyberworlds A
                case 0x8D: baseAddress = type == 0? 0x80FF4E4 : type == 1? 0x80FF3F8 : 0x45A70; break; // Cyberworlds B
                case 0x8E: baseAddress = type == 0? 0x80FFD1C : type == 1? 0x80FFC30 : 0x462A8; break; // WaterGod Comp
                case 0x8F: baseAddress = type == 0? 0x80FFE58 : type == 1? 0x80FFD6C : 0x463E8; break; // (Unused)
                case 0x90: baseAddress = type == 0? 0x8100150 : type == 1? 0x8100024 : 0x466A0; break; // ACDC Area
                case 0x91: baseAddress = type == 0? 0x810081C : type == 1? 0x81006F0 : 0x46D70; break; // Town Area
                case 0x92: baseAddress = type == 0? 0x8100F84 : type == 1? 0x8100E58 : 0x474E0; break; // Park Area
                case 0x93: baseAddress = type == 0? 0x8101738 : type == 1? 0x810160C : 0x47C98; break; // Overseas Nets
                case 0x94: baseAddress = type == 0? 0x8101FC8 : type == 1? 0x8101E9C : 0x48528; break; // Undernet
            }
            
            if (baseAddress == 0)
                return 0;
            
            if (!lc && version == 'S') // Blue Moon addresses are +C from Red Sun in all GBA versions, but no difference between them in LC
                baseAddress += 0xC;
            
            return (uint)baseAddress;
        }
        
        public override Dictionary<int, string> getDefinedEncounters()
        {
            Dictionary<int, string> encounters = new Dictionary<int, string>();
            
            // Define "encounter IDs" (a thing I made up, not really a thing in-game) by adding area value * 0x10000 to the offset within that area.
            int areaIDMult = 0x10000;
            
            int acdcAreaID = 0x90 * areaIDMult; // RS English base: 0x8100150
            encounters[acdcAreaID + 0x18C] = "AquaMan Omega";
            encounters[acdcAreaID + 0x1FC] = "GutsMan Omega";
            encounters[acdcAreaID + 0x26C] = "SparkMan Omega";
            
            int townAreaID = 0x91 * areaIDMult; // RS English base: 0x810081C
            encounters[townAreaID + 0x1F0] = "TopMan Omega";
            encounters[townAreaID + 0x260] = "FireMan Omega";
            encounters[townAreaID + 0x2D0] = "Roll Omega";
            encounters[townAreaID + 0x340] = "NumberMan Omega";
            
            int parkAreaID = 0x92 * areaIDMult; // RS English base: 0x8100F84
            encounters[parkAreaID + 0x1EC] = "WoodMan Omega";
            encounters[parkAreaID + 0x274] = "BurnerMan Omega";
            encounters[parkAreaID + 0x2FC] = "VideoMan Omega";
            
            int overseasNetsID = 0x93 * areaIDMult; // RS English base: 0x8101738
            encounters[overseasNetsID + 0x2E0] = "WindMan Omega";
            encounters[overseasNetsID + 0x380] = "ThunderMan Omega";
            encounters[overseasNetsID + 0x420] = "KendoMan Omega";
            encounters[overseasNetsID + 0x4C0] = "ColdMan Omega";
            
            int undernetID = 0x94 * areaIDMult; // RS English base: 0x8101FC8
            encounters[undernetID + 0x554] = "SearchMan Omega";
            encounters[undernetID + 0x5F4] = "JunkMan Omega";
            encounters[undernetID + 0x694] = "MetalMan Omega";
            encounters[undernetID + 0x734] = "ShadeMan Omega";
            encounters[undernetID + 0x7D4] = "LaserMan Omega";
            encounters[undernetID + 0x898] = "ProtoMan Omega";
            encounters[undernetID + 0x938] = "Bass Omega";
            encounters[undernetID + 0x9D8] = "BassXX";
            
            return encounters;
        }
        
        public override int saveAreaLengthGBA {get { return 0x73D2; } }
        public override int saveFileSizeLC {get { return 0x73A0; } }
        public override int saveEncryptXORAddressGBA { get { return 0x1554; } }
        public override int memoryShiftAddressGBA { get { return 0x1550; } }
        public override int saveEncryptXORAddressLC { get { return 0x3324; } }
        public override int memoryShiftAddressLC { get { return 0x3320; } }
        
        // BN4 exclusive
        public static string[][] tournamentEntrantData { get { return new string[][] {
            // Full Navi name, full operator name, short Navi name (if different), short operator name (if different), tournament, RS/BM Soul (optional)
            new string[] { "GutsMan", "Dex", "", "", "Den/City", "RS Soul" }, // 0x00
            new string[] { "FireMan", "Mr. Match", "", "Mr.Match", "Den/City", "RS Soul" }, // 0x01
            new string[] { "NumberMan", "Higsby", "", "", "Den/City", "BM Soul" }, // 0x02
            new string[] { "AquaMan", "Shuko", "", "", "Den/City", "BM Soul" }, // 0x03
            new string[] { "Roll", "Mayl", "", "", "Eagle/Hawk", "RS Soul" }, // 0x04
            new string[] { "WindMan", "Lilly", "", "", "Eagle/Hawk", "RS Soul" }, // 0x05
            new string[] { "MetalMan", "Tamako", "", "", "Eagle/Hawk", "BM Soul" }, // 0x06
            new string[] { "WoodMan", "Sal", "", "", "Eagle/Hawk", "BM Soul" }, // 0x07
            new string[] { "ThunderMan", "Raoul", "ThunderMn", "", "Red Sun/Blue Moon", "RS Soul" }, // 0x08
            new string[] { "SearchMan", "Raika", "", "", "Red Sun/Blue Moon", "RS Soul" }, // 0x09
            new string[] { "ProtoMan", "Chaud", "", "", "Red Sun/Blue Moon", "BM Soul" }, // 0x0A
            new string[] { "JunkMan", "N/A", "", "", "Red Sun/Blue Moon", "BM Soul" }, // 0x0B
            new string[] { "SparkMan", "Terry", "", "", "Den/City" }, // 0x0C
            new string[] { "TopMan", "Tensuke", "", "", "Den/City" }, // 0x0D
            new string[] { "ColdMan", "Chillski", "", "", "Red Sun/Blue Moon" }, // 0x0E
            new string[] { "BurnerMan", "Atsuki", "", "", "Eagle/Hawk" }, // 0x0F
            new string[] { "VideoMan", "Viddy Narcy", "", "VddyNarcy", "Eagle/Hawk" }, // 0x10
            new string[] { "KendoMan", "Mr. Famous", "", "Mr.Famous", "Red Sun/Blue Moon" }, // 0x11
            new string[] { "N/A", "N/A", "", "", "" }, // 0x12
            new string[] { "N/A", "N/A", "", "", "" }, // 0x13
            new string[] { "Ponta [NormalNavi]", "Yuko", "Ponta", "", "Den/City" }, // 0x14
            new string[] { "HeelNavi", "Tetsu", "", "", "Den/City" }, // 0x15
            new string[] { "NormalNavi (Filler)", "N/A", "NormlNavi", "", "Den/City" }, // 0x16
            new string[] { "HeelNavi (Filler)", "N/A", "HeelNavi", "", "Den/City" }, // 0x17
            new string[] { "NormalNavi", "Flave", "NormlNavi", "", "Eagle/Hawk" }, // 0x18
            new string[] { "Crusher [HeelNavi]", "Riki", "Crusher", "", "Eagle/Hawk" }, // 0x19
            new string[] { "NormalNavi (Filler)", "N/A", "MormlNavi", "", "Eagle/Hawk" }, // 0x1A
            new string[] { "Jammer [HeelNavi]", "Paulie", "Jammer", "", "Red Sun/Blue Moon" }, // 0x1B
            new string[] { "NormalNavi", "Jack Bomber", "NormlNavi", "JackBombr", "Red Sun/Blue Moon" }, // 0x1C
            new string[] { "HeelNavi (Filler)", "N/A", "HeelNavi", "", "Red Sun/Blue Moon" }, // 0x1D
            new string[] { "MegaMan", "Lan", "", "", "" } // 0x1E
        }; } }
        
        public static string eReaderUnknownNameAndDesc = "????";
        
        public static string eReaderDuoName = "Duo";
        public static string eReaderDuoNameJP = "デューオ";
        public static string eReaderDuoDesc = "MetrKnukl\nof justic\nrain down";
        public static string eReaderDuoDescJP = "むすうにふりそそぐ\nせいぎのコブシ\nメテオナックル!";
        
        public static string eReaderPrixPowrName = "PrixPowr";
        public static string eReaderPrixPowrNameJP = "グランプリパワー";
        public static string eReaderPrixPowrDesc = "GrandPrix\n3 Navis\natk tgthr";
        public static string eReaderPrixPowrDescJP = "グランプリをとった\n3体のナビたちの\nゆめのきょうえん!";
        
        #region // e-Reader Graphics Data
        public static byte[] eReaderBlankIconGraphics = new byte[] {
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x99, 0x99, 0x99, 0x99, 0x59, 0x55, 0x55, 0x55, 0x59, 0x88, 0x88, 0x88, 0x59, 0x88, 0x88, 0x88,
            0x59, 0x88, 0x88, 0x88, 0x59, 0x88, 0x88, 0x88, 0x59, 0x88, 0x88, 0x88, 0x59, 0x88, 0x88, 0x88,
            0x99, 0x99, 0x99, 0x99, 0x55, 0x55, 0x55, 0x95, 0x88, 0x88, 0x88, 0x95, 0x88, 0x88, 0x88, 0x95,
            0x88, 0x88, 0x88, 0x95, 0x88, 0x88, 0x88, 0x95, 0x88, 0x88, 0x88, 0x95, 0x88, 0x88, 0x88, 0x95,
            0x59, 0x88, 0x88, 0x88, 0x59, 0x88, 0x88, 0x88, 0x59, 0x88, 0x88, 0x88, 0x59, 0x88, 0x88, 0x88,
            0x59, 0x88, 0x88, 0x88, 0x59, 0x88, 0x88, 0x88, 0x59, 0x55, 0x55, 0x55, 0x99, 0x99, 0x99, 0x99,
            0x88, 0x88, 0x88, 0x95, 0x88, 0x88, 0x88, 0x95, 0x88, 0x88, 0x88, 0x95, 0x88, 0x88, 0x88, 0x95,
            0x88, 0x88, 0x88, 0x95, 0x88, 0x88, 0x88, 0x95, 0x55, 0x55, 0x55, 0x95, 0x99, 0x99, 0x99, 0x99
        };
        
        public static byte[] eReaderDuoGraphics = new byte[] {
            0x66, 0x53, 0x55, 0x55, 0x66, 0x5B, 0x55, 0x55, 0x66, 0x2B, 0x55, 0x55, 0x66, 0xB7, 0x55, 0x55,
            0x76, 0xB6, 0x52, 0x55, 0x66, 0x77, 0x2B, 0x52, 0x76, 0x77, 0xB7, 0x3B, 0x67, 0x77, 0x77, 0xB7,
            0x25, 0x25, 0x52, 0x55, 0x25, 0x55, 0x52, 0x55, 0x25, 0x55, 0x52, 0x22, 0x55, 0x55, 0x22, 0x33,
            0x25, 0x25, 0x33, 0xDB, 0x25, 0x32, 0xCA, 0xEE, 0x33, 0x33, 0xEC, 0xCC, 0xCC, 0xCC, 0xEB, 0xAE,
            0x55, 0x55, 0x22, 0x32, 0x25, 0x22, 0x33, 0xCB, 0x32, 0xB3, 0xEC, 0xEE, 0xCB, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xAC, 0xEE, 0xCD, 0x8A, 0x56, 0x8B, 0x66, 0x86, 0x58, 0xAA, 0x66, 0x87, 0x19,
            0x33, 0xCB, 0xDC, 0xEE, 0xED, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xAC, 0xEE, 0xBD, 0x68, 0x77,
            0x79, 0x66, 0x66, 0x76, 0x65, 0x66, 0x66, 0x77, 0x55, 0x65, 0x66, 0x66, 0x56, 0x55, 0x65, 0x76,
            0xEE, 0xCE, 0x9A, 0xA3, 0xDE, 0x9A, 0x99, 0x7A, 0x78, 0x98, 0x99, 0x66, 0x87, 0x88, 0x69, 0x66,
            0x77, 0x88, 0x67, 0x66, 0x77, 0x68, 0x66, 0x66, 0x77, 0x76, 0x66, 0x66, 0x66, 0x77, 0x67, 0x66,
            0x67, 0x66, 0x65, 0x65, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66, 0x66,
            0x66, 0x66, 0x66, 0x97, 0x66, 0x66, 0x97, 0xAA, 0x66, 0x97, 0xAB, 0xAA, 0xA8, 0xBC, 0xBB, 0xAA,
            0x66, 0x96, 0x99, 0x99, 0x66, 0x98, 0x99, 0x99, 0x86, 0xA9, 0x99, 0x9A, 0x99, 0x9A, 0x9A, 0x99,
            0xAA, 0xA9, 0xA9, 0x99, 0xAA, 0xA9, 0x99, 0x39, 0xAA, 0x99, 0x39, 0x23, 0xAA, 0x39, 0x23, 0x52,
            0x66, 0x76, 0x77, 0x77, 0x66, 0x76, 0x76, 0x76, 0x67, 0x66, 0x67, 0x67, 0x7C, 0x66, 0x66, 0x66,
            0xDD, 0x7A, 0x66, 0x66, 0xDD, 0xDD, 0x8B, 0x66, 0xDD, 0xDD, 0xDD, 0xCD, 0xDC, 0xDD, 0xDD, 0xDD,
            0x67, 0x67, 0xE8, 0xAE, 0x76, 0x66, 0xD6, 0xAE, 0x66, 0x66, 0x76, 0x77, 0x66, 0x66, 0x76, 0x78,
            0x66, 0x66, 0x66, 0x78, 0x66, 0x66, 0x66, 0x78, 0xBB, 0xBB, 0xBB, 0x77, 0xDD, 0xDD, 0xDD, 0x67,
            0xA9, 0x67, 0x88, 0x1E, 0x88, 0x87, 0xC8, 0x1F, 0x66, 0x98, 0xFA, 0xCF, 0x76, 0xAA, 0xFD, 0xDF,
            0x76, 0x77, 0x17, 0x11, 0x56, 0x55, 0x55, 0x11, 0x66, 0x55, 0x65, 0x15, 0x56, 0x55, 0x55, 0x56,
            0x11, 0x55, 0x55, 0x55, 0x11, 0x11, 0x55, 0x65, 0x11, 0x11, 0x71, 0x77, 0x11, 0x44, 0x71, 0x67,
            0x44, 0x44, 0x77, 0x56, 0x44, 0x14, 0x77, 0x55, 0x41, 0x74, 0x67, 0x55, 0x41, 0x71, 0x56, 0xB5,
            0x66, 0x77, 0x67, 0x76, 0x66, 0x77, 0x56, 0x66, 0x66, 0x56, 0x55, 0x66, 0x55, 0x55, 0x55, 0x66,
            0x55, 0x55, 0x55, 0x66, 0x55, 0x55, 0x56, 0x66, 0x95, 0x55, 0x56, 0x65, 0xCD, 0x55, 0x56, 0x65,
            0xCB, 0xBB, 0xAB, 0xAA, 0xBC, 0xBC, 0xBB, 0xAA, 0xCB, 0xBB, 0xAB, 0xAA, 0xB8, 0xBC, 0xBA, 0xAA,
            0xC7, 0xBB, 0xBB, 0xAA, 0xB6, 0xBB, 0xAB, 0xAA, 0xA6, 0xBB, 0xAA, 0x39, 0x96, 0xAB, 0x39, 0x33,
            0x39, 0x23, 0x25, 0x55, 0x39, 0x52, 0x25, 0x55, 0x39, 0x52, 0x25, 0x55, 0x39, 0x52, 0x25, 0x55,
            0x39, 0x52, 0x25, 0x55, 0x39, 0x52, 0x25, 0x55, 0x23, 0x52, 0x25, 0x52, 0x22, 0x52, 0x25, 0x52,
            0xDB, 0xDD, 0xDD, 0xDD, 0xA8, 0xBB, 0xDC, 0xDD, 0x25, 0x32, 0x33, 0xCB, 0x25, 0x25, 0x22, 0x33,
            0x55, 0x25, 0x25, 0x32, 0x55, 0x25, 0x55, 0x32, 0x55, 0x25, 0x55, 0x22, 0x55, 0x25, 0x25, 0x25,
            0xDD, 0xDD, 0xDD, 0x69, 0xDD, 0xDD, 0xDD, 0x6B, 0xDD, 0xDD, 0xDD, 0x5D, 0xDD, 0xDD, 0xDD, 0x6D,
            0xDC, 0xDD, 0xDD, 0xBD, 0xDB, 0xDD, 0xDD, 0xBD, 0x33, 0xBB, 0xCB, 0xAC, 0x22, 0x33, 0xCB, 0xBD,
            0x66, 0x55, 0x55, 0x65, 0x56, 0x55, 0x55, 0x66, 0x57, 0xD8, 0xFE, 0xCE, 0x57, 0xA6, 0xED, 0x7D,
            0x76, 0x76, 0x87, 0xC8, 0x66, 0x76, 0xDB, 0xEE, 0x6A, 0x76, 0xC8, 0xEE, 0x7A, 0x66, 0xC6, 0xEE,
            0x15, 0x67, 0xA6, 0xFE, 0x76, 0x66, 0xD5, 0xFF, 0x66, 0x96, 0x67, 0x76, 0x7B, 0x86, 0x99, 0xAA,
            0x7E, 0x87, 0x99, 0xBA, 0x9E, 0x77, 0x99, 0xBA, 0xAE, 0x77, 0xA9, 0xBA, 0xCE, 0x88, 0xA9, 0xAA,
            0xBF, 0x55, 0x56, 0x65, 0x7C, 0x65, 0x55, 0x65, 0x87, 0x66, 0x55, 0x65, 0xAA, 0x56, 0x55, 0x65,
            0xAB, 0x56, 0x55, 0x66, 0xBB, 0x56, 0x55, 0x66, 0xBB, 0x57, 0x55, 0x66, 0xBB, 0x57, 0x55, 0x86,
            0x86, 0xBA, 0xCC, 0xCC, 0x66, 0x88, 0x88, 0x88, 0x66, 0x77, 0x77, 0x88, 0x66, 0x76, 0x87, 0x88,
            0x66, 0x76, 0x88, 0x78, 0x66, 0x87, 0x88, 0x77, 0x87, 0x88, 0x77, 0x77, 0x88, 0x78, 0x77, 0x77,
            0xCC, 0x23, 0x25, 0x52, 0x88, 0x3C, 0x22, 0x52, 0x88, 0xC9, 0x22, 0x52, 0x97, 0xC9, 0x23, 0x52,
            0x88, 0x99, 0x3C, 0x52, 0x87, 0x99, 0x3C, 0x52, 0x78, 0x98, 0xC9, 0x23, 0x87, 0x98, 0xC9, 0x39,
            0x55, 0x25, 0x25, 0x25, 0x55, 0x25, 0x25, 0x22, 0x55, 0x25, 0x25, 0x32, 0x55, 0x25, 0x25, 0x32,
            0x55, 0x25, 0x25, 0x35, 0x55, 0x25, 0x25, 0x25, 0x55, 0x25, 0x25, 0x25, 0x55, 0x25, 0x25, 0x25,
            0x32, 0xC3, 0xEE, 0xBD, 0xC3, 0xEE, 0x7D, 0x66, 0x9C, 0x9A, 0x77, 0x66, 0x9C, 0xAA, 0x77, 0x66,
            0x9C, 0xAA, 0x77, 0x66, 0xC3, 0xAA, 0x77, 0x66, 0xC3, 0xAA, 0x78, 0x66, 0xC3, 0xAA, 0x68, 0x66,
            0xCA, 0x66, 0xA5, 0xED, 0xD8, 0x68, 0x86, 0xED, 0xD6, 0x6C, 0x66, 0xEC, 0xC6, 0x6D, 0x56, 0xEB,
            0x86, 0x7D, 0x56, 0xD9, 0x56, 0x9D, 0x66, 0xC7, 0x66, 0xDC, 0x66, 0x95, 0x56, 0xD8, 0x66, 0x55,
            0xEE, 0x9A, 0xAA, 0xAA, 0xEE, 0xAD, 0xAA, 0xAA, 0xEE, 0x9A, 0x88, 0xA8, 0xAE, 0xDE, 0xBC, 0x8A,
            0xEE, 0xCC, 0x9A, 0xAA, 0xEE, 0x8D, 0x67, 0xA9, 0xEC, 0x8E, 0x77, 0xA6, 0xB9, 0x8D, 0x77, 0x86,
            0xAB, 0x58, 0x87, 0x88, 0xAA, 0x98, 0x89, 0x77, 0xAA, 0xA8, 0xAA, 0x77, 0xAA, 0xA8, 0xAA, 0x78,
            0x9A, 0xA7, 0xAA, 0x78, 0x89, 0x97, 0xAA, 0x79, 0x78, 0x85, 0xAA, 0x7A, 0x57, 0x75, 0xAA, 0x7A,
            0x78, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77,
            0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77,
            0x77, 0x88, 0x99, 0xBC, 0x87, 0x88, 0x99, 0xC9, 0x77, 0x88, 0x98, 0xA8, 0x77, 0x87, 0x88, 0x99,
            0x77, 0x87, 0x97, 0x99, 0x77, 0x77, 0x76, 0x77, 0x77, 0x66, 0x66, 0x77, 0x67, 0x66, 0x66, 0x76,
            0x55, 0x25, 0x25, 0x25, 0x55, 0x75, 0x25, 0x32, 0x55, 0x55, 0x25, 0xB3, 0x55, 0x55, 0x35, 0xEB,
            0x25, 0x55, 0x35, 0xED, 0x25, 0x55, 0x35, 0xEE, 0x55, 0x55, 0x32, 0xDE, 0x55, 0x55, 0x32, 0xCF,
            0xC3, 0xAA, 0x69, 0x66, 0xC3, 0xA9, 0x69, 0x56, 0xFE, 0x99, 0x58, 0x55, 0xFF, 0xAC, 0x57, 0x55,
            0xFF, 0xAE, 0x9A, 0x99, 0xCB, 0xCD, 0xAA, 0x78, 0xAB, 0xAA, 0x89, 0x97, 0xAB, 0xAA, 0x8A, 0x97,
            0x55, 0xC5, 0x68, 0x56, 0x55, 0x55, 0x66, 0x56, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55,
            0x67, 0x55, 0x55, 0x55, 0x77, 0x77, 0x77, 0x88, 0x89, 0x88, 0x87, 0x77, 0x88, 0x88, 0x67, 0x66,
            0x85, 0x8B, 0x77, 0x67, 0x55, 0x65, 0x77, 0x57, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55,
            0x55, 0x55, 0x66, 0x76, 0x56, 0x86, 0x98, 0xAA, 0x76, 0xA9, 0xAA, 0xAA, 0x98, 0x89, 0x88, 0x88,
            0x55, 0x65, 0xAA, 0x8A, 0x55, 0x55, 0xAA, 0x9A, 0x55, 0x55, 0xAA, 0x9A, 0x55, 0x75, 0x99, 0x99,
            0x87, 0xA9, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0x99, 0xAA, 0x9A, 0x78, 0x77, 0x88, 0x78, 0x77, 0x77,
            0x77, 0x77, 0x77, 0x67, 0x77, 0x77, 0x67, 0x66, 0x77, 0x87, 0x88, 0x76, 0xA8, 0x9A, 0x79, 0x66,
            0x9A, 0x88, 0x77, 0x67, 0x77, 0x77, 0x77, 0x67, 0x77, 0x77, 0x77, 0x67, 0x77, 0x77, 0x77, 0x77,
            0x66, 0x66, 0x77, 0x76, 0x66, 0x76, 0x77, 0x67, 0x77, 0x77, 0x77, 0x67, 0x66, 0x77, 0x77, 0x67,
            0x66, 0x77, 0x77, 0x67, 0x66, 0x76, 0x77, 0x56, 0x66, 0x76, 0x67, 0x55, 0x66, 0x66, 0x56, 0x55,
            0x25, 0x25, 0xB3, 0xBF, 0x25, 0x92, 0xCE, 0xBE, 0x25, 0xEA, 0xCF, 0xBD, 0x95, 0xFC, 0xDF, 0x9A,
            0x95, 0xEC, 0xEF, 0xAB, 0xB2, 0xEC, 0xFF, 0xAD, 0xC2, 0xCE, 0xDB, 0xAD, 0xB9, 0xBE, 0xAA, 0x9A,
            0xAB, 0xAA, 0x7A, 0x89, 0xAA, 0xAA, 0x7A, 0x89, 0xAA, 0xAA, 0x79, 0x89, 0xAA, 0xAA, 0x79, 0x77,
            0x99, 0xAA, 0x78, 0x66, 0xAA, 0x89, 0x77, 0x65, 0x9A, 0x78, 0x77, 0x65, 0x89, 0x77, 0x57, 0x55,
            0x88, 0x88, 0x66, 0x65, 0x88, 0x88, 0x66, 0x66, 0x88, 0x78, 0x66, 0x56, 0x77, 0x77, 0x67, 0x56,
            0x66, 0x66, 0x77, 0x56, 0x66, 0x66, 0x76, 0x67, 0x66, 0x66, 0x66, 0x76, 0x66, 0x66, 0x66, 0x87,
            0x99, 0x99, 0x89, 0x88, 0x99, 0x99, 0x89, 0x88, 0x99, 0x99, 0x89, 0x88, 0x99, 0x99, 0x89, 0x88,
            0x99, 0x99, 0x89, 0x88, 0x99, 0x99, 0x89, 0x88, 0x99, 0x99, 0x89, 0x88, 0x88, 0x88, 0x88, 0x98,
            0x88, 0x88, 0x77, 0x77, 0x88, 0x88, 0x77, 0x77, 0x88, 0x88, 0x77, 0x77, 0x88, 0x88, 0x77, 0x77,
            0x88, 0x88, 0x77, 0x77, 0x88, 0x88, 0x77, 0x87, 0x88, 0x88, 0x98, 0xAA, 0x99, 0xAA, 0xAA, 0xAA,
            0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0xA8, 0x77, 0x77, 0x97, 0xAA,
            0x77, 0x98, 0xAA, 0xAA, 0xA9, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0x78, 0xAA, 0x9A, 0x78, 0x77,
            0x66, 0x66, 0x65, 0x55, 0x99, 0x89, 0x67, 0x55, 0xAA, 0xAA, 0x68, 0x55, 0xAA, 0x8A, 0x67, 0x55,
            0x9A, 0x77, 0x66, 0x55, 0x78, 0x67, 0x66, 0x55, 0x77, 0x66, 0x56, 0x55, 0x67, 0x66, 0x55, 0x55,
            0x00, 0x00, 0x39, 0x18, 0x40, 0x19, 0x06, 0x32, 0x9F, 0x29, 0x80, 0x08, 0x63, 0x1C, 0xC5, 0x24,
            0x27, 0x31, 0x89, 0x39, 0xCB, 0x41, 0x0D, 0x46, 0x71, 0x52, 0xF5, 0x62, 0x79, 0x6F, 0xDD, 0x7B,
            0x99, 0x99, 0x99, 0x99, 0x59, 0x55, 0x55, 0x55, 0x59, 0x68, 0x88, 0x88, 0x59, 0x64, 0x88, 0x88,
            0x59, 0x66, 0x88, 0x88, 0x59, 0x66, 0x68, 0x66, 0x59, 0x66, 0x68, 0x66, 0x59, 0x64, 0x66, 0x64,
            0x99, 0x99, 0x99, 0x99, 0x55, 0x55, 0x55, 0x95, 0x88, 0x68, 0x88, 0x95, 0x88, 0x68, 0x84, 0x95,
            0x88, 0x68, 0x86, 0x95, 0x66, 0x68, 0x86, 0x95, 0x66, 0x68, 0x86, 0x95, 0x64, 0x66, 0x84, 0x95,
            0x59, 0x88, 0x66, 0x66, 0x59, 0x88, 0x68, 0x66, 0x59, 0x66, 0x68, 0x66, 0x59, 0x66, 0x66, 0x66,
            0x59, 0x66, 0x66, 0x66, 0x59, 0x66, 0x66, 0x66, 0x59, 0x55, 0x55, 0x55, 0x99, 0x99, 0x99, 0x99,
            0x66, 0x86, 0x88, 0x95, 0x66, 0x88, 0x88, 0x95, 0x66, 0x68, 0x86, 0x95, 0x66, 0x66, 0x86, 0x95,
            0x66, 0x66, 0x66, 0x95, 0x66, 0x66, 0x66, 0x95, 0x55, 0x55, 0x55, 0x95, 0x99, 0x99, 0x99, 0x99
        };
        
        public static byte[] eReaderPrixPowrGraphics = new byte[] {
            0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33,
            0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33,
            0x44, 0x44, 0x44, 0x54, 0x44, 0x44, 0x44, 0x54, 0x44, 0x44, 0x44, 0x54, 0x44, 0x44, 0x44, 0x54,
            0x44, 0x44, 0x44, 0x54, 0x44, 0x44, 0x44, 0x55, 0x44, 0x44, 0x44, 0x65, 0x44, 0x44, 0x44, 0x65,
            0x44, 0x44, 0xD5, 0x6E, 0x44, 0x54, 0xD5, 0x6E, 0x44, 0x54, 0xD5, 0x6E, 0x54, 0x54, 0xD6, 0x6E,
            0x54, 0x55, 0xD6, 0xDE, 0x54, 0x55, 0xD6, 0xDE, 0x55, 0x65, 0xD6, 0xCE, 0x55, 0x65, 0xE6, 0x8E,
            0x65, 0xFE, 0xEF, 0xEE, 0x66, 0x1D, 0x21, 0x22, 0xD6, 0x21, 0x22, 0x11, 0xB6, 0x99, 0x81, 0x99,
            0x86, 0x98, 0x81, 0x98, 0x89, 0x18, 0x8A, 0x98, 0x88, 0x28, 0x89, 0x98, 0x88, 0x28, 0x88, 0xA8,
            0xDE, 0x66, 0xE6, 0x45, 0xE1, 0x6D, 0xE6, 0x46, 0x11, 0xDE, 0xED, 0x46, 0x1A, 0xE2, 0xED, 0x46,
            0xBA, 0xC1, 0xEE, 0x56, 0xBA, 0x1B, 0xEC, 0x56, 0xBA, 0xBB, 0xD1, 0x5D, 0xBB, 0xCB, 0xB1, 0x6D,
            0x44, 0x64, 0x45, 0x45, 0x44, 0x64, 0x45, 0x44, 0x44, 0x65, 0x55, 0x44, 0x44, 0x65, 0x45, 0x45,
            0x55, 0x65, 0x55, 0x44, 0x65, 0x65, 0x45, 0x45, 0x65, 0x65, 0x55, 0x44, 0x65, 0x65, 0x55, 0x45,
            0x44, 0x33, 0x33, 0x33, 0x44, 0x33, 0x33, 0x33, 0x44, 0x33, 0x33, 0x33, 0x44, 0x33, 0x33, 0x33,
            0x44, 0x33, 0x33, 0x33, 0x44, 0x33, 0x33, 0x33, 0x44, 0x33, 0x33, 0x33, 0x44, 0x33, 0x33, 0x33,
            0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33,
            0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33, 0x3D, 0x33, 0x33, 0x33, 0xDF, 0x33, 0x33, 0x33,
            0x44, 0x44, 0x44, 0x65, 0x44, 0x44, 0x54, 0x65, 0x44, 0x44, 0x44, 0x65, 0x44, 0x44, 0x54, 0x65,
            0x44, 0x44, 0x54, 0x65, 0x44, 0x44, 0x54, 0x66, 0x54, 0x65, 0x66, 0xE6, 0x44, 0x44, 0x54, 0x66,
            0x65, 0x65, 0xE6, 0x8C, 0x65, 0x65, 0xED, 0x98, 0x65, 0xD6, 0xCE, 0x99, 0x65, 0xD6, 0xBE, 0xAA,
            0xD6, 0xED, 0xCE, 0xED, 0xED, 0xEE, 0xEE, 0xFE, 0xFE, 0xFF, 0xEE, 0xFF, 0xE6, 0xEE, 0xCC, 0x55,
            0x88, 0x29, 0x88, 0xA8, 0x99, 0x1A, 0x99, 0xA9, 0xAA, 0x1A, 0xAA, 0xBA, 0xCB, 0xCD, 0xDD, 0xDD,
            0xED, 0xEE, 0xFE, 0xFE, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xEE, 0xDD, 0x66, 0x66, 0x66, 0x55,
            0xBB, 0xCB, 0x2C, 0xDB, 0xCB, 0xCC, 0xCC, 0xB2, 0xBB, 0xAB, 0xBA, 0x2B, 0xCD, 0xAA, 0xBB, 0x2B,
            0xDE, 0xED, 0xFE, 0xEE, 0xFF, 0xFE, 0xDE, 0x2D, 0x56, 0xCC, 0xAB, 0x11, 0x14, 0x99, 0x99, 0xA1,
            0x66, 0x65, 0x55, 0x44, 0x6D, 0x65, 0x55, 0x45, 0xDD, 0x66, 0x55, 0x44, 0xDC, 0x6D, 0x55, 0x55,
            0xEE, 0xEE, 0x66, 0x66, 0xEB, 0x6E, 0x56, 0x54, 0xD1, 0xDE, 0x56, 0x44, 0xC1, 0xDE, 0x56, 0x54,
            0x44, 0x33, 0x33, 0x33, 0x44, 0x33, 0x33, 0x33, 0x44, 0x33, 0x33, 0x33, 0x44, 0x33, 0x33, 0x33,
            0x45, 0x33, 0x33, 0x33, 0x44, 0x33, 0x33, 0x33, 0x44, 0x33, 0x33, 0x33, 0x44, 0x33, 0x33, 0xFD,
            0xFE, 0x3F, 0x33, 0x33, 0xEE, 0xFD, 0x3D, 0x33, 0xEE, 0xDC, 0xFF, 0x33, 0xDE, 0xCC, 0xEA, 0xDF,
            0xDE, 0xAC, 0xCC, 0xFB, 0xCE, 0xAC, 0xAC, 0x99, 0xCE, 0xBC, 0x8A, 0x99, 0xCD, 0xCC, 0x88, 0x89,
            0x44, 0x44, 0x54, 0x66, 0x44, 0x44, 0x54, 0x66, 0x44, 0x44, 0x55, 0x66, 0x44, 0x44, 0x54, 0x66,
            0x4F, 0x44, 0x55, 0xD6, 0xFE, 0x4D, 0x54, 0xD6, 0xBA, 0xFF, 0x65, 0xE6, 0xA8, 0xFA, 0x6F, 0xED,
            0xED, 0xEE, 0x87, 0x11, 0xED, 0xEE, 0x97, 0x12, 0xEE, 0xDF, 0xA7, 0x1E, 0xEE, 0xDF, 0xB7, 0x1F,
            0xEE, 0xAE, 0xC7, 0x1F, 0xEE, 0x7A, 0x27, 0xAE, 0xBE, 0x78, 0x27, 0xA2, 0x8C, 0x77, 0x27, 0x92,
            0x88, 0x11, 0x98, 0x29, 0x88, 0x11, 0x98, 0x29, 0x88, 0x12, 0x88, 0x29, 0x88, 0x12, 0x98, 0xD9,
            0x88, 0x1D, 0x88, 0xD9, 0x88, 0x1D, 0x88, 0x29, 0x88, 0x12, 0x88, 0x28, 0x77, 0x12, 0x77, 0x17,
            0x22, 0x99, 0x99, 0x91, 0x2E, 0x99, 0x99, 0x91, 0x2F, 0x99, 0x99, 0xA1, 0xEF, 0x9A, 0x99, 0x19,
            0xEF, 0x9A, 0x99, 0x99, 0x2F, 0x8A, 0xC8, 0xAB, 0x2E, 0x89, 0xDC, 0x9C, 0x12, 0xB9, 0xCC, 0xAC,
            0xC1, 0xDE, 0x56, 0x44, 0xB1, 0xDE, 0x56, 0x44, 0x91, 0xEC, 0x6D, 0x55, 0x78, 0xC8, 0xDE, 0x55,
            0x77, 0x87, 0xEC, 0x6D, 0x78, 0x77, 0xC8, 0xFE, 0x89, 0x77, 0xF8, 0xCF, 0x99, 0xA7, 0xDF, 0xBB,
            0x44, 0x33, 0xF3, 0x3E, 0x44, 0x33, 0xDF, 0x33, 0x44, 0xFD, 0x3D, 0x33, 0xE4, 0x8F, 0x44, 0x34,
            0xEF, 0x88, 0x48, 0x45, 0xDE, 0xCD, 0xCC, 0xBC, 0xBB, 0xBB, 0xBB, 0xAB, 0xAB, 0x79, 0x77, 0x77,
            0xCC, 0xCC, 0x89, 0x88, 0xBC, 0xCB, 0x8B, 0x88, 0xBB, 0xBB, 0xAC, 0x88, 0xA9, 0xBB, 0xBB, 0x9A,
            0xAC, 0xA8, 0xBB, 0xAB, 0xEE, 0x79, 0xAA, 0xBB, 0xEE, 0x7A, 0xFC, 0xBD, 0xCC, 0x99, 0xFD, 0xEF,
            0x88, 0xAA, 0xFE, 0xDF, 0x88, 0x98, 0xD9, 0xFF, 0x98, 0x99, 0x9A, 0xEA, 0x99, 0xAA, 0x9A, 0xAA,
            0xAA, 0xAA, 0x9A, 0xAA, 0xAB, 0xAA, 0xAA, 0xB9, 0xBB, 0xAA, 0xAA, 0x88, 0xBC, 0xAB, 0xBA, 0x8A,
            0x78, 0x87, 0x18, 0x82, 0x79, 0x87, 0x18, 0x81, 0xBF, 0x88, 0x98, 0x81, 0xFB, 0x9F, 0x88, 0x77,
            0xCC, 0xFE, 0x8B, 0x77, 0x9A, 0xB8, 0xFF, 0x77, 0x88, 0x88, 0xCC, 0x8F, 0x88, 0x88, 0xB8, 0xFC,
            0x77, 0x11, 0x77, 0x97, 0x77, 0x11, 0x87, 0x88, 0x77, 0x81, 0x88, 0x88, 0x77, 0x87, 0x88, 0x88,
            0x77, 0x87, 0x88, 0x88, 0x77, 0x87, 0x88, 0x88, 0x77, 0x87, 0x88, 0x88, 0x7F, 0x87, 0x88, 0x98,
            0x99, 0xAA, 0xCB, 0xCC, 0x98, 0xA9, 0xBB, 0xCC, 0x99, 0xA9, 0xBA, 0xEC, 0x98, 0x99, 0xCA, 0xDF,
            0x98, 0x99, 0xFC, 0x9B, 0x88, 0xFA, 0xAF, 0x89, 0xB8, 0xDF, 0x9A, 0x78, 0xFF, 0x38, 0x8A, 0x77,
            0xAA, 0xFD, 0xBC, 0x8A, 0xFB, 0xBE, 0x89, 0x77, 0xCF, 0x89, 0x77, 0x77, 0xAC, 0x78, 0x77, 0xB7,
            0xAD, 0x77, 0xB8, 0xEE, 0xAD, 0xA8, 0xED, 0xDD, 0xAD, 0xDB, 0xCC, 0x8A, 0xCD, 0xCD, 0x7A, 0x38,
            0x77, 0x78, 0x87, 0x88, 0x87, 0x87, 0x88, 0x98, 0x77, 0xC7, 0xED, 0xDE, 0xED, 0xFF, 0xDE, 0xCD,
            0xDE, 0xCD, 0xAC, 0x78, 0xAC, 0xEA, 0xAE, 0x88, 0x33, 0x44, 0x8F, 0x78, 0x44, 0x55, 0x8E, 0x88,
            0xAA, 0x99, 0xFC, 0x36, 0x8A, 0x99, 0xFB, 0x34, 0x89, 0x99, 0xE9, 0x33, 0x98, 0x99, 0xB9, 0x33,
            0x99, 0x99, 0x99, 0x43, 0x99, 0x99, 0x89, 0x88, 0x99, 0x9A, 0x89, 0x88, 0x99, 0x9A, 0x88, 0x88,
            0xE5, 0xCB, 0xBC, 0x9B, 0xE4, 0xDC, 0xCD, 0xBB, 0xF4, 0xCE, 0xCD, 0xBB, 0xF6, 0xCF, 0xDD, 0xBB,
            0xFF, 0x9F, 0xDD, 0xBC, 0xDA, 0x9F, 0xDC, 0xBD, 0x88, 0x88, 0xD8, 0xBD, 0x88, 0x88, 0x88, 0xBB,
            0x88, 0x88, 0x88, 0xD9, 0x99, 0x98, 0xA9, 0x9A, 0xAB, 0x9A, 0x99, 0x99, 0xBB, 0xAA, 0x9A, 0xAA,
            0xBA, 0xAB, 0x9A, 0x99, 0x91, 0xAB, 0x8A, 0x99, 0x99, 0xDA, 0x8C, 0x88, 0x3A, 0xE5, 0x8B, 0x88,
            0xFD, 0x8D, 0x88, 0xFD, 0xC9, 0xFF, 0xF2, 0xCF, 0xBA, 0xEB, 0xEF, 0xCC, 0x89, 0xA8, 0xCF, 0xDC,
            0x88, 0xA8, 0xDF, 0xDD, 0x99, 0xA8, 0xDF, 0xDD, 0x99, 0x89, 0xDF, 0xED, 0x88, 0x98, 0xEF, 0xDE,
            0xCD, 0xA8, 0x79, 0x97, 0xCC, 0x98, 0x78, 0xAA, 0xDC, 0x38, 0xA7, 0x9A, 0xDD, 0x38, 0xA9, 0x79,
            0xDD, 0x98, 0x9A, 0x77, 0xED, 0xA8, 0x79, 0x87, 0xDE, 0x88, 0xC8, 0x43, 0xDD, 0x38, 0xD7, 0xE5,
            0xCD, 0x8B, 0x87, 0x4C, 0xDC, 0x77, 0xA7, 0x3E, 0xDC, 0x77, 0xC7, 0xDF, 0xDB, 0x78, 0xC7, 0xAC,
            0xD9, 0x7A, 0x77, 0xEA, 0xD8, 0x7B, 0xCA, 0xCD, 0xC8, 0xBD, 0xDC, 0x8B, 0xC9, 0xCD, 0x8B, 0x77,
            0x54, 0x6E, 0x8B, 0x88, 0x44, 0x84, 0xA8, 0xCC, 0x83, 0xDB, 0xFF, 0xEE, 0xED, 0xEE, 0xDD, 0xBC,
            0xDE, 0xBC, 0x89, 0x78, 0x8B, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x87,
            0x99, 0x9A, 0x18, 0x91, 0x99, 0x9B, 0x18, 0x22, 0x99, 0x9B, 0x88, 0x12, 0x99, 0x9B, 0x18, 0x18,
            0x99, 0x9B, 0x18, 0x82, 0x99, 0x9B, 0x18, 0x12, 0x99, 0x9B, 0x18, 0x12, 0x99, 0xAB, 0x99, 0x99,
            0x88, 0x88, 0x88, 0x88, 0x89, 0x88, 0x88, 0x88, 0x11, 0x89, 0x88, 0x88, 0x18, 0x11, 0x89, 0x88,
            0x81, 0x18, 0x11, 0x89, 0x11, 0x81, 0x98, 0x88, 0x11, 0x11, 0x91, 0x78, 0x88, 0x11, 0x89, 0x78,
            0x33, 0xCE, 0xC9, 0xA9, 0x88, 0x77, 0xCC, 0xEB, 0x88, 0x87, 0xBB, 0xEE, 0x78, 0xA7, 0xC8, 0xEE,
            0x78, 0x88, 0xEC, 0xEE, 0x77, 0xDB, 0xEE, 0x2E, 0xC7, 0xEE, 0x2E, 0x2E, 0xE9, 0xE2, 0x22, 0x22,
            0x9A, 0x19, 0xDF, 0xDD, 0x2E, 0x22, 0xDF, 0xDD, 0xEE, 0x2E, 0xDF, 0xEE, 0x22, 0x22, 0xEF, 0xEE,
            0x22, 0x22, 0xEF, 0xEE, 0x2E, 0x22, 0xEF, 0xFF, 0x22, 0x22, 0xFF, 0xFF, 0x22, 0x22, 0xFF, 0xEE,
            0xDD, 0x39, 0x87, 0x7A, 0xBE, 0x3C, 0x73, 0xB8, 0xBE, 0x3D, 0x83, 0xAB, 0xCE, 0x3A, 0xB3, 0x7A,
            0xFF, 0xA9, 0xA9, 0x78, 0xFF, 0xAB, 0x83, 0x77, 0xEE, 0x9E, 0x33, 0x77, 0xEE, 0xDD, 0x39, 0x73,
            0xAA, 0xBD, 0x77, 0x77, 0x9A, 0xCC, 0x78, 0x77, 0x78, 0xCA, 0x7A, 0x77, 0x77, 0xC8, 0x7B, 0xB8,
            0x77, 0xB7, 0xBC, 0xDC, 0x77, 0xA7, 0xCB, 0x9C, 0x77, 0xAB, 0xBC, 0x78, 0xB8, 0x8A, 0xCA, 0x7B,
            0x77, 0x77, 0x87, 0xCB, 0x77, 0xB8, 0xEE, 0xDE, 0xD9, 0xEE, 0xCD, 0xAB, 0xDD, 0xBC, 0x79, 0x77,
            0x9C, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0x77, 0xA8,
            0x00, 0x00, 0x45, 0x46, 0x2B, 0x7B, 0x53, 0x1C, 0x3B, 0x3D, 0xBD, 0x51, 0x5E, 0x62, 0x42, 0x08,
            0xE7, 0x1C, 0x28, 0x29, 0x8C, 0x2D, 0xEF, 0x3D, 0x73, 0x4E, 0xF9, 0x6A, 0x7C, 0x77, 0xDE, 0x7B,
            0x99, 0x99, 0x99, 0x99, 0x59, 0x55, 0x55, 0x55, 0x59, 0x18, 0x18, 0x18, 0x59, 0x18, 0x18, 0x53,
            0x59, 0x16, 0x18, 0x55, 0x59, 0x66, 0x18, 0x55, 0x59, 0x68, 0x16, 0x58, 0x59, 0x88, 0x66, 0x44,
            0x99, 0x99, 0x99, 0x99, 0x55, 0x55, 0x55, 0x95, 0x81, 0x81, 0x81, 0x95, 0x35, 0x81, 0x81, 0x95,
            0x55, 0x81, 0x61, 0x95, 0x55, 0x81, 0x66, 0x95, 0x85, 0x61, 0x86, 0x95, 0x44, 0x66, 0x88, 0x95,
            0x59, 0x88, 0x68, 0x46, 0x59, 0x38, 0x35, 0x66, 0x59, 0x58, 0x55, 0x68, 0x59, 0x58, 0x55, 0x68,
            0x59, 0x88, 0x85, 0x68, 0x59, 0x48, 0x44, 0x68, 0x59, 0x55, 0x55, 0x55, 0x99, 0x99, 0x99, 0x99,
            0x64, 0x86, 0x88, 0x95, 0x66, 0x53, 0x83, 0x95, 0x86, 0x55, 0x85, 0x95, 0x86, 0x55, 0x85, 0x95,
            0x86, 0x58, 0x88, 0x95, 0x86, 0x44, 0x84, 0x95, 0x55, 0x55, 0x55, 0x95, 0x99, 0x99, 0x99, 0x99
        };
        #endregion
        
        public override string getSubareaName(int area, int subarea, bool returnArea = false, bool fallbackIfNotFound = false)
        {
            switch (area)
            {
                case 0x00:
                    if (returnArea)
                        return "ACDC Town";
                    switch (subarea)
                    {
                        case 0x00: return "ACDC Outside";
                        case 0x01: return "Lan's House";
                        case 0x02: return "Lan's Room";
                        case 0x03: return "Mayl's Room";
                        case 0x04: return "Dex's Room";
                        case 0x05: return "Yai's Room";
                        case 0x06: return "Higsby's";
                    }
                    break;
                
                case 0x01:
                    if (returnArea)
                        return "ElecTown";
                    switch (subarea)
                    {
                        case 0x00: return "ElecTown 1";
                        case 0x01: return "ElecTown 2";
                        case 0x02: return "ElecTown Square";
                    }
                    break;
                
                case 0x02:
                    if (returnArea)
                        return "DenDome";
                    switch (subarea)
                    {
                        case 0x00: return "Outside Dome";
                        case 0x01: return "Dome Hall";
                        case 0x02: return "Dome Waiting Room";
                        case 0x03: return "Dome Stadium";
                    }
                    break;
                
                case 0x03:
                    if (returnArea)
                        return "Castillo";
                    switch (subarea)
                    {
                        case 0x00: return "Castillo Entrance";
                        case 0x01: return "CenterSquare";
                        case 0x02: return "Castillo Waiting Room";
                        case 0x03: return "SkyStadium";
                        case 0x04: return "TaleSquare";
                        case 0x05: return "VampireManor";
                    }
                    break;
                
                case 0x04:
                    if (returnArea)
                        return "Netopia and Others";
                    switch (subarea)
                    {
                        case 0x00: return "Netopia Outside";
                        case 0x01: return "Colosseum Ave";
                        case 0x02: return "Netopia Guest Noom";
                        case 0x03: return "Colosseum Waiting Room";
                        case 0x04: return "Colosseum Arena";
                        case 0x05: return "Yumland";
                        case 0x06: return "YumRuins";
                        case 0x07: return "NetFrica";
                        case 0x08: return "Sharo";
                        case 0x09: return "Sharo SpaceCenter";
                    }
                    break;
                
                case 0x05:
                    if (returnArea)
                        return "NAXA";
                    switch (subarea)
                    {
                        case 0x00: return "Observation Room";
                        case 0x01: return "NAXA Roof";
                        case 0x02: return "NAXA Entrance";
                        case 0x03: return "NAXA Lobby";
                    }
                    break;
                
                case 0x80:
                    if (returnArea)
                        return "ElecTower Comp";
                    switch (subarea)
                    {
                        case 0x00: return "ElecTower Comp 1";
                        case 0x01: return "ElecTower Comp 2";
                    }
                    break;
                
                case 0x81:
                    if (returnArea)
                        return "ToyRobo Comp";
                    switch (subarea)
                    {
                        case 0x00: return "ToyRobo Comp 1";
                        case 0x01: return "ToyRobo Comp 2";
                        case 0x02: return "ToyRobo Comp 3";
                        case 0x03: return "ToyRobo Comp 4";
                    }
                    break;
                
                case 0x82:
                    if (returnArea)
                        return "Asteroid Comp";
                    switch (subarea)
                    {
                        case 0x00: return "Asteroid Comp 1";
                        case 0x01: return "Asteroid Comp 2";
                        case 0x02: return "Asteroid Comp 3";
                        case 0x03: return "Asteroid Comp 4";
                        case 0x04: return "Asteroid Control Area";
                    }
                    break;
                
                case 0x88:
                    if (returnArea)
                        return "Home Pages";
                    switch (subarea)
                    {
                        case 0x00: return "Lan's HP";
                        case 0x01: return "Mayl's HP";
                        case 0x02: return "Dex's HP";
                        case 0x03: return "Yai's HP";
                        case 0x04: return "Hotel HP";
                        case 0x05: return "Castillo HP";
                        case 0x06: return "JomonElec HP";
                        case 0x07: return "SpaceCenter HP";
                    }
                    break;
                
                case 0x8C:
                    if (returnArea)
                        return "Cyberworlds A";
                    switch (subarea)
                    {
                        case 0x00: return "Oven Comp";
                        case 0x01: return "Stereo Comp";
                        case 0x02: return "Hotdog Comp";
                        case 0x03: return "Dome NetBattle Machine Comp";
                        case 0x04: return "CyberTop Comp";
                        case 0x05: return "LCD Comp";
                        case 0x06: return "Castillo NetBattle Machine Comp";
                        case 0x07: return "Statue Comp";
                        case 0x08: return "Nupopo Comp";
                        case 0x09: return "Sharo Computer Comp";
                        case 0x0A: return "Toy Comp";
                        case 0x0B: return "Colosseum NetBattle Machine Comp";
                        case 0x0C: return "Lion Comp";
                        case 0x0D: return "Doghouse Comp";
                        case 0x0E: return "Game Comp";
                        case 0x0F: return "Vending Machine Comp";
                    }
                    break;
                   
                case 0x8D:
                    if (returnArea)
                        return "Cyberworlds B";
                    switch (subarea)
                    {
                        case 0x00: return "Card Comp";
                        case 0x01: return "Water Comp";
                        case 0x02: return "Ticket Comp";
                        case 0x03: return "Stand Comp";
                        case 0x04: return "Antenna Comp 1";
                        case 0x05: return "Antenna Comp 2";
                        case 0x06: return "Antenna Comp 3";
                        case 0x07: return "Antenna Comp 4";
                        case 0x08: return "Buddha Comp";
                        case 0x09: return "Goddess Comp";
                        case 0x0A: return "Hero Comp";
                        case 0x0B: return "Cook Comp";
                    }
                    break;
                
                case 0x8E:
                    if (returnArea)
                        return "WaterGod Comp";
                    if (subarea < 16)
                        return "WaterGod Comp " + (subarea + 1);
                    break;
                
                case 0x90:
                    if (returnArea)
                        return "ACDC Area";
                    switch (subarea)
                    {
                        case 0x00: return "ACDC Area 1";
                        case 0x01: return "ACDC Area 2";
                        case 0x02: return "ACDC Area 3";
                    }
                    break;
                
                case 0x91:
                    if (returnArea)
                        return "Town Area";
                    switch (subarea)
                    {
                        case 0x00: return "Town Area 1";
                        case 0x01: return "Town Area 2";
                        case 0x02: return "Town Area 3";
                        case 0x03: return "Town Area 4";
                    }
                    break;
                
                case 0x92:
                    if (returnArea)
                        return "Park Area";
                    switch (subarea)
                    {
                        case 0x00: return "Park Area 1";
                        case 0x01: return "Park Area 2";
                        case 0x02: return "Park Area 3";
                    }
                    break;
                
                case 0x93:
                    if (returnArea)
                        return "Overseas Nets";
                    switch (subarea)
                    {
                        case 0x00: return "Yumland Area";
                        case 0x01: return "Netopia Area";
                        case 0x02: return "NetFrica Area";
                        case 0x03: return "Sharo Area";
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
                        case 0x06: return "Black Earth 1";
                        case 0x07: return "Black Earth 2";
                    }
                    break;
            }
            
            return fallbackIfNotFound? "[" + (returnArea? area : subarea).ToString("X2") + "]" : "";
        }
        
        public override string getMusicName(int music, bool fallbackIfNotFound = false)
        {
            switch (music)
            {
                case 0x00: return "Title Screen";
                case 0x01: return "The Quiet Darkness";
                case 0x02: return "ACDC Town";
                case 0x03: return "Inside House";
                case 0x04: return "ElecTown";
                case 0x05: return "DenDome";
                case 0x06: return "Cielo Castillo";
                case 0x07: return "Overseas Areas (Journey of Determination)";
                case 0x08: return "NAXA";
                case 0x09: return "Tournament Board (Player Entrance)";
                case 0x0A: return "Dracky's Mansion";
                case 0x0B: return "Incident Occurrence!";
                case 0x0C: return "Emotional Theme (Sad Rain)";
                case 0x0D: return "Heroic Theme (Under Justice)";
                case 0x0E: return "Transmission!";
                case 0x0F: return "ElecTower Comp (Invisible Wing)";
                case 0x10: return "ToyRobo Comp (Story of Wonder)";
                case 0x11: return "Asteroid Comp (Save Our Planet)";
                case 0x12: return "Internet (Global Network)";
                case 0x13: return "Undernet (Heel's Paradise)";
                case 0x14: return "Virus Battle (Cyber Battle)";
                case 0x15: return "Boss Battle (Battle with Myself)";
                case 0x16: return "VS Duo";
                case 0x17: return "Tournament Battle (Battle Pressure)";
                case 0x18: return "Enemy Deleted!";
                case 0x19: return "Loser";
                case 0x1A: return "Game Over";
                case 0x1B: return "Boss Encounter";
                case 0x1C: return "Credits (Your Answer)";
                case 0x1D: return "Navi Customizer";
                case 0x1E: return "Enemy Deleted! (Short)";
                case 0x1F: return "Championship Congratulation!";
                case 0x20: return "ToyRobo Comp 4 (Vampire)";
                case 0x21: return "Tutorial Battle";
                case 0xFF: return "None";
            }
            
            return fallbackIfNotFound? "[" + music.ToString("X2") + "]" : "";
        }
        
        public override string getEmailName(int email, bool fallbackIfNotFound = false)
        {
            switch (email)
            {
                case 0: return "DublSoul (Dad)";
                case 1: return "I have Chisao (???)";
                case 2: return "Help! (Chisao)";
                case 3: return "Maintenance (JomonElec)";
                case 4: return "Daily Fortune! (DenEZine)";
                case 5: return "Notice (ENBA)";
                case 6: return "Back home (Mom)";
                case 7: return "Meeting Place (WNBA)";
                case 8: return "Challenge (Roll)";
                case 9: return "Virus Scans (Den News)";
                case 10: return "Hey there! (Sal)";
                case 11: return "Please help! (Sal)";
                case 12: return "NaviCust (Dad)";
                case 13: return "Please help? (Mom)";
                case 14: return "Bring it on! (J. Bomber)";
                case 15: return "In a bind? (C. Master)";
                case 16: return "GutsSoul (Dad)";
                case 17: return "FireSoul (Dad)";
                case 18: return "RollSoul (Dad)";
                case 19: return "WindSoul (Dad)";
                case 20: return "ThunSoul (Dad)";
                case 21: return "SrchSoul (Dad)";
                case 22: return "AquaSoul (Dad)";
                case 23: return "NumSoul (Dad)";
                case 24: return "WoodSoul (Dad)";
                case 25: return "MetalSoul (Dad)";
                case 26: return "JunkSoul (Dad)";
                case 27: return "ProtoSoul (Dad)";
                case 28: return "Undernet (Chaud)";
                case 29: return "Weather update (WeathCen)";
                case 30: return "Get to it! (Yai)";
                case 31: return "You the man! (Dex)";
                case 32: return "Notice (JomonElec)";
                case 33: return "Dear customer (HotelNet)";
            }
            
            return fallbackIfNotFound? "Email #" + email : "";
        }
        
        public override string getBBSPost(int bbs, int post, bool fallbackIfNotFound = false)
        {
            switch (bbs)
            {
                case 0: // Dex's HP Battle BBS
                    switch (post)
                    {
                        case 0: return "AdminDex - Welcome!";
                        case 1: return "Yai - Impressive!";
                        case 2: return "GutsMan - I got it!";
                        case 3: return "Mayl - Boomer";
                        case 4: return "AdminDex - RE: Boomer";
                        case 5: return "Mayl - Well...";
                        case 6: return "Masabumi - Specs Virus";
                        case 7: return "Koetsu - RE: Specs Virirus";
                        case 8: return "Goh - Mystery Data?";
                        case 9: return "Koetsu - RE: MysteryData?";
                        case 10: return "Rutha - Chip Merge?";
                        case 11: return "AdminDex - RE: Chip Merge?";
                        case 12: return "Hinata - Sheep!";
                        case 13: return "Kawachi - RE: Sheep!";
                        case 14: return "Nonchan - NaviCust!";
                        case 15: return "Mabo - RE: NaviCust!";
                        case 16: return "Bork - Bug?";
                        case 17: return "Yai - RE: Bug?";
                        case 18: return "Goh - Black Navi";
                        case 19: return "Zono - RE: Black Navi";
                        case 20: return "Goh - Uh oh...";
                        case 21: return "Saki - Tournaments!";
                        case 22: return "AdminDex - RE: Tournaments!";
                        case 23: return "Mayl - RE: Tournaments!";
                        case 24: return "Beltz - VarSwrd";
                        case 25: return "Niko - Spider Virus";
                        case 26: return "Ryuge - RE: Spider Virus";
                        case 27: return "Wolf - Network Duels";
                        case 28: return "Koetsu - RE: Network Duels";
                    }
                    break;
                
                case 1: // Yai's HP Chat BBS
                    switch (post)
                    {
                        case 0: return "Glyde - Welcome, all!";
                        case 1: return "Mayl - Good for you!";
                        case 2: return "Dex - Congrats!!";
                        case 3: return "Yai - Thanks!";
                        case 4: return "GutsMan - RE: Thanks!";
                        case 5: return "Dex - RE: Thanks!";
                        case 6: return "Hans - Bonjour!";
                        case 7: return "Nikaido - Hi Yai!";
                        case 8: return "Dex - Ghosts?!";
                        case 9: return "GutsMan - RE: Ghosts?!";
                        case 10: return "Nikaido - RE: Ghosts?!";
                        case 11: return "Yai - Oh, my!";
                        case 12: return "Matsu - Tournament?";
                        case 13: return "Yai - Sponsor";
                        case 14: return "Mayl - Lan too!";
                        case 15: return "Dex - Lan rules!";
                    }
                    break;
                
                case 2: // Netopia Hotel Battle BBS
                    switch (post)
                    {
                        case 0: return "Anna - Welcome!";
                        case 1: return "Mustash - Travel Tips";
                        case 2: return "Mustash - Yumland";
                        case 3: return "Mustash - Sharo";
                        case 4: return "Mustash - NetFrica";
                        case 5: return "Mustash - Netopia";
                        case 6: return "Chama - Hole";
                        case 7: return "Koetsu - RE: Hole";
                        case 8: return "Robin - RE: Hole";
                        case 9: return "Goemon - BlkBomb";
                        case 10: return "Anna - RE: BlkBomb";
                    }
                    break;
                
                case 3: // Castillo Chat BBS
                    switch (post)
                    {
                        case 0: return "Admin - Welcome!";
                        case 1: return "Akane - What a blast!";
                        case 2: return "Yumechan - Jealous!";
                        case 3: return "Sujiko - TinMan";
                        case 4: return "Shinya - HlbrdPrincess";
                        case 5: return "Higsby - WizDog";
                        case 6: return "Takumi - Dracky!";
                        case 7: return "Kappepo - RE: Dracky!";
                        case 8: return "Suzy - Django";
                        case 9: return "Chikachi - GunDelSol";
                        case 10: return "Admin - Apology";
                        case 11: return "Tomo - Scary!";
                        case 12: return "Mayumin - RE: Scary!";
                        case 13: return "Vortex - Event?";
                        case 14: return "Kanideka - Tournament";
                        case 15: return "Fujirin - RE: Tournament";
                        case 16: return "Nanase - Say...";
                        case 17: return "Noah - RE: Say...";
                    }
                    break;
                
                case 4: // JomonElec Chat BBS
                    switch (post)
                    {
                        case 0: return "Jomon - Greetings";
                        case 1: return "Shinya - New PET!";
                        case 2: return "Mitsu - RE: New PET!";
                        case 3: return "Hide - Jack In!";
                        case 4: return "Yuki - FW: Jack In!";
                        case 5: return "Yuji - Town Area";
                        case 6: return "Amayan - Old Man";
                        case 7: return "Carlton - RE: Old Man";
                        case 8: return "Purimiki - Oops!";
                        case 9: return "Nukki - RE: Oops!";
                        case 10: return "Kurotan - Question";
                        case 11: return "Bozu - RE: Question";
                        case 12: return "Bozu - BattleChips";
                        case 13: return "Jomon - RE: BattleChips";
                        case 14: return "Nukki - RE: BattleChips";
                        case 15: return "Bozu - RE: BattleChips";
                    }
                    break;
                
                case 5: // Under BBS
                    switch (post)
                    {
                        case 0: return "UnderRes - Post away";
                        case 1: return "NO NAME - Elmperor";
                        case 2: return "NO NAME - Somebody...!";
                        case 3: return "NO NAME - RE: Somebody...!";
                        case 4: return "NO NAME - RE: Somebody...!";
                        case 5: return "ExNebula - ShadeMan";
                        case 6: return "NO NAME - Useless Chip";
                        case 7: return "NO NAME - RE: Useless Chip";
                        case 8: return "NO NAME - Giant Hole";
                        case 9: return "NO NAME - Django?!";
                        case 10: return "NO NAME - RE: Django?!";
                        case 11: return "NO NAME - RE: Django?!";
                    }
                    break;
            }
            
            return fallbackIfNotFound? "Post #" + (post + 1) : "";
        }
        
        public override string getShopName(int shop, bool fallbackIfNotFound = false)
        {
            switch (shop)
            {
                case 0: return "Town Area 3 NetDealer";
                case 1: return "Netopia Area NetDealer";
                case 2: return "Undernet 1 NetDealer";
                case 3: return "Undernet 5 NetDealer";
                case 4: return "Higsby's";
                case 5: return "ACDC Area 2 NetDealer";
                case 6: return "Park Area 1 SubChip dealer";
                case 7: return "ACDC Town SubChip dealer";
                case 8: return "ElecTown SubChip dealer";
                case 9: return "TaleSquare SubChip dealer";
                case 10: return "Colosseum Ave SubChip dealer";
                case 11: return "YumRuins SubChip dealer";
                case 12: return "Park Area 3 BugFrag dealer";
                case 13: return "Undernet 4 BugFrag dealer";
                case 14: return "Castillo HP program dealer";
                case 15: return "Undernet 6 program dealer";
                case 16: return "Higsby's Chip Order";
            }
            
            return fallbackIfNotFound? "Shop #" + (shop + 1) : "";
        }
        
        public override string getChipOrderShopName()
        {
            return getShopName(16);
        }
        
        public override bool isBugFragShop(int shop, bool fallbackIfNotFound = false)
        {
            return shop == 12 || shop == 13;
        }
        
        public override string getChapterDesc(int chapter)
        {
            switch (chapter)
            {
                case 0: return "Start of game";
                case 1: return "After fighting tutorial viruses";
                case 2: return "After fixing Mr. Prog in oven";
                
                case 3: return "Shopping in ElecTown?";
                case 4: return "After first ShadeMan encounter?";
                case 5: return "Looking for ShadeMan?";
                case 6: return "Entered ElecTower Comp";
                case 7: return "After ElecTower Comp";
                
                case 8: return "Going to Den/City Tournament preliminary";
                case 9: return "Started Den/City Tournament preliminary";
                case 10: return "Finished Den/City preliminary, ready to view board";
                case 11: return "After Den/City Round 1 scenario";
                case 12: return "After Den/City Round 2 scenario";
                
                case 16: return "Going to Mayl's house";
                case 17: return "After threat to bring DarkChip to Park Area?";
                
                case 18: return "Going to Castillo";
                case 19: return "ToyRobo incident begun";
                case 20: return "Vampire ToyRobo activated?";
                
                case 21: return "Eagle/Hawk BattlePoints preliminary";
                case 22: return "Finished Eagle/Hawk preliminary, ready to view board";
                case 23: return "After Eagle/Hawk Round 1 scenario";
                case 24: return "After Eagle/Hawk Round 2 scenario";
                case 25: return "After Eagle/Hawk Round 3, LaserMan incident";
                
                case 32: return "Going to Netopia";
                case 33: return "Red Sun/Blue Moon kidnapping preliminary";
                case 34: return "Finished Red Sun/Blue Moon preliminary, ready to view board";
                case 35: return "After Red Sun/Blue Moon Round 1 scenario";
                case 36: return "After Red Sun/Blue Moon Round 2 scenario";
                case 37: return "After Red Sun/Blue Moon Round 3, taken to NAXA";
                
                case 38: return "Net connection incident";
                case 39: return "After fixing Net connections";
                case 40: return "After beating Net connection culprit";
                case 41: return "After returning to NAXA and entering Asteroid Comp";
                case 42: return "After beating LaserMan, before final battle";
                
                case 48: return "Den/City GutsMan scenario: Start";
                case 49: return "Den/City GutsMan scenario: Part 2";
                case 50: return "Den/City GutsMan scenario: Part 3";
                
                case 51: return "Den/City FireMan scenario: Start";
                case 52: return "Den/City FireMan scenario: Part 2";
                case 53: return "Den/City FireMan scenario: Part 3";
                
                case 54: return "Den/City SparkMan scenario: Start";
                case 55: return "Den/City SparkMan scenario: Part 2";
                
                case 56: return "Den/City TopMan scenario: Start";
                case 57: return "Den/City TopMan scenario: Part 2";
                
                case 58: return "Den/City AquaMan scenario: Start";
                case 59: return "Den/City AquaMan scenario: Part 2";
                case 60: return "Den/City AquaMan scenario: Part 3";
                
                case 61: return "Den/City Yuko scenario: Start";
                case 62: return "Den/City Yuko scenario: Part 2";
                case 63: return "Den/City Yuko scenario: Part 3";
                
                case 64: return "Den/City Tetsu scenario: Start";
                case 65: return "Den/City Tetsu scenario: Part 2";
                
                case 66: return "Den/City NumberMan scenario: Start";
                case 67: return "Den/City NumberMan scenario: Part 2";
                
                case 72: return "Den/City Riki & Crusher scenario: Start";
                case 73: return "Den/City Riki & Crusher scenario: Part 2";
                case 74: return "Den/City Riki & Crusher scenario: Part 3";
                
                case 75: return "Eagle/Hawk Roll scenario: Start";
                case 76: return "Eagle/Hawk Roll scenario: Part 2";
                
                case 77: return "Eagle/Hawk WindMan scenario: Start";
                case 78: return "Eagle/Hawk WindMan scenario: Part 2";
                
                case 79: return "Eagle/Hawk Tamako scenario: Start";
                case 80: return "Eagle/Hawk Tamako scenario: Part 2";
                case 81: return "Eagle/Hawk Tamako scenario: Part 3";
                
                case 82: return "Eagle/Hawk VideoMan scenario: Start";
                case 83: return "Eagle/Hawk VideoMan scenario: Part 2";
                
                case 84: return "Eagle/Hawk WoodMan scenario: Start";
                case 85: return "Eagle/Hawk WoodMan scenario: Part 2";
                
                case 86: return "Eagle/Hawk BurnerMan scenario: Start";
                case 87: return "Eagle/Hawk BurnerMan scenario: Part 2";
                case 88: return "Eagle/Hawk BurnerMan scenario: Part 3";
                case 89: return "Eagle/Hawk BurnerMan scenario: Part 4";
                case 90: return "Eagle/Hawk BurnerMan scenario: Part 5";
                
                case 91: return "Eagle/Hawk Flave scenario: Start";
                case 92: return "Eagle/Hawk Flave scenario: Part 2";
                case 93: return "Eagle/Hawk Flave scenario: Part 3";
                case 94: return "Eagle/Hawk Flave scenario: Part 4";
                case 95: return "Eagle/Hawk Flave scenario: Part 5";
                
                case 101: return "Sun/Moon ThunderMan scenario: Start";
                case 102: return "Sun/Moon ThunderMan scenario: Part 2";
                case 103: return "Sun/Moon ThunderMan scenario: Part 3";
                
                case 104: return "Sun/Moon Jack Bomber scenario: Start";
                case 105: return "Sun/Moon Jack Bomber scenario: Part 2";
                case 106: return "Sun/Moon Jack Bomber scenario: Part 3";
                
                case 107: return "Sun/Moon JunkMan scenario: Start";
                case 108: return "Sun/Moon JunkMan scenario: Part 2";
                case 109: return "Sun/Moon JunkMan scenario: Part 3";
                
                case 110: return "Sun/Moon KendoMan scenario: Start";
                case 111: return "Sun/Moon KendoMan scenario: Part 2";
                case 112: return "Sun/Moon KendoMan scenario: Part 3";
                case 113: return "Sun/Moon KendoMan scenario: Part 3";
                
                case 114: return "Sun/Moon Paulie & Jammer scenario: Start";
                case 115: return "Sun/Moon Paulie & Jammer scenario: Part 2";
                case 116: return "Sun/Moon Paulie & Jammer scenario: Part 3";
                
                case 117: return "Sun/Moon ColdMan scenario: Start";
                case 118: return "Sun/Moon ColdMan scenario: Part 2";
                case 119: return "Sun/Moon ColdMan scenario: Part 3";
                
                case 120: return "Sun/Moon SearchMan scenario: Start";
                case 121: return "Sun/Moon SearchMan scenario: Part 2";
                case 122: return "Sun/Moon SearchMan scenario: Part 3";
                
                case 123: return "Sun/Moon ProtoMan scenario: Start";
                case 124: return "Sun/Moon ProtoMan scenario: Part 2";
                case 125: return "Sun/Moon ProtoMan scenario: Part 3";
            }
            return "";
        }
        
        public override string getFlagDesc(int flag)
        {
            if (flag >= 3328 && flag <= 4254) // Mystery Data flags
            {
                string mdString = "";
                string[] mdContents = getMysteryDataLoopContents(flag);
                if (mdContents.Length > 0)
                {
                    mdString = mdContents[0] + ": " + mdContents[1]; // Type (BMD/PMD) and area
                    for (int i = 2; i < mdContents.Length; i++)
                        mdString += (i > 2? " / " : " (") + mdContents[i];
                    if (mdContents.Length > 2)
                        mdString += ")";
                }
                return mdString;
            }
            else if (flag >= 4608 && flag <= 5567) // BBS posts, BBS posts unread
            {
                bool unreadFlag = flag >= 5120;
                int startFlag = !unreadFlag? 4608 : 5120;
                int bbsNum = (flag - startFlag) / 64;
                int postNum = (flag - startFlag) % 64;
                if (bbsNum < bbsNames.Length)
                    return "Post" + (unreadFlag? " unread" : "") + ": " + bbsNames[bbsNum] + ", " + getBBSPost(bbsNum, postNum, true);
            }
            else if (flag >= 5568 && flag <= 5601) // Emails
                return "Email: " + getEmailName(flag - 5568, true);
            else if (flag >= 5696 && flag <= 5729) // Emails unread
                return "Email unread: " + getEmailName(flag - 5696, true);
            
            switch (flag)
            {
                case 1: return "GutsMan (as visitor) was selected in past tournament (has priority if not)";
                case 2: return "FireMan (as visitor) was selected in past tournament (has priority if not)";
                case 3: return "NumberMan (as visitor) was selected in past tournament (has priority if not)";
                case 4: return "AquaMan (as visitor) was selected in past tournament (has priority if not)";
                case 5: return "Roll (as visitor) was selected in past tournament (has priority if not)";
                case 6: return "WindMan (as visitor) was selected in past tournament (has priority if not)";
                case 7: return "MetalMan (as visitor) was selected in past tournament (has priority if not)";
                case 8: return "WoodMan (as visitor) was selected in past tournament (has priority if not)";
                case 9: return "ThunderMan (as visitor) was selected in past tournament (has priority if not)";
                case 10: return "SearchMan (as visitor) was selected in past tournament (has priority if not)";
                case 11: return "ProtoMan (as visitor) was selected in past tournament (has priority if not)";
                case 12: return "JunkMan (as visitor) was selected in past tournament (has priority if not)";
                case 13: return "SparkMan was selected in past tournament (has priority if not)";
                case 14: return "TopMan was selected in past tournament (has priority if not)";
                case 15: return "ColdMan was selected in past tournament (has priority if not)";
                case 16: return "BurnerMan was selected in past tournament (has priority if not)";
                case 17: return "VideoMan was selected in past tournament (has priority if not)";
                case 18: return "KendoMan was selected in past tournament (has priority if not)";
                
                case 21: return "Do normal opponent-picking in tournaments (set after forced GutsMan/AquaMan)";
                
                case 23: return "Obtained RollSoul (Red Sun only)";
                case 24: return "Obtained GutsSoul (Red Sun only)";
                case 25: return "Obtained WindSoul (Red Sun only)";
                case 26: return "Obtained SearchSoul (Red Sun only)";
                case 27: return "Obtained FireSoul (Red Sun only)";
                case 28: return "Obtained ThunderSoul (Red Sun only)";
                case 29: return "Obtained ProtoSoul (Blue Moon only)";
                case 30: return "Obtained NumberSoul (Blue Moon only)";
                case 31: return "Obtained MetalSoul (Blue Moon only)";
                case 32: return "Obtained JunkSoul (Blue Moon only)";
                case 33: return "Obtained AquaSoul (Blue Moon only)";
                case 34: return "Obtained WoodSoul (Blue Moon only)";
                
                case 67: return "Roll Omega added as random encounter after beating Beta";
                case 68: return "GutsMan Omega added as random encounter after beating Beta";
                case 69: return "WindMan Omega added as random encounter after beating Beta";
                case 70: return "SearchMan Omega added as random encounter after beating Beta";
                case 71: return "FireMan Omega added as random encounter after beating Beta";
                case 72: return "ThunderMan Omega added as random encounter after beating Beta";
                case 73: return "ProtoMan Omega added as random encounter after beating Beta";
                case 74: return "NumberMan Omega added as random encounter after beating Beta";
                case 75: return "MetalMan Omega added as random encounter after beating Beta";
                case 76: return "JunkMan Omega added as random encounter after beating Beta";
                case 77: return "AquaMan Omega added as random encounter after beating Beta";
                case 78: return "WoodMan Omega added as random encounter after beating Beta";
                case 79: return "TopMan Omega added as random encounter after beating Beta";
                case 80: return "SparkMan Omega added as random encounter after beating Beta";
                case 81: return "BurnerMan Omega added as random encounter after beating Beta";
                case 82: return "VideoMan Omega added as random encounter after beating Beta";
                case 83: return "ColdMan Omega added as random encounter after beating Beta";
                case 84: return "KendoMan Omega added as random encounter after beating Beta";
                case 85: return "ShadeMan Omega added as random encounter after Django quest";
                case 86: return "LaserMan Omega added as random encounter after beating Beta";
                
                case 110: return "Loop clear flag (prompts to start new loop on Continue)";
                case 112: return "Have Navi Customizer";
                case 113: return "Unlocked Records menu (auto-set if any times are set)";
                case 114: return "Unlocked Patch Cards menu (can still appear but behave oddly if not set)";
                
                case 133: return "Set Records time for Roll";
                case 134: return "Set Records time for GutsMan";
                case 135: return "Set Records time for WindMan";
                case 136: return "Set Records time for SearchMan";
                case 137: return "Set Records time for FireMan";
                case 138: return "Set Records time for ThunderMan";
                case 139: return "Set Records time for ProtoMan";
                case 140: return "Set Records time for NumberMan";
                case 141: return "Set Records time for MetalMan";
                case 142: return "Set Records time for JunkMan";
                case 143: return "Set Records time for AquaMan";
                case 144: return "Set Records time for WoodMan";
                case 145: return "Set Records time for TopMan";
                case 146: return "Set Records time for SparkMan";
                case 147: return "Set Records time for BurnerMan";
                case 148: return "Set Records time for VideoMan";
                case 149: return "Set Records time for ColdMan";
                case 150: return "Set Records time for KendoMan";
                case 151: return "Set Records time for ShadeMan";
                case 152: return "Set Records time for LaserMan";
                
                case 155: return "Game repeated SoulNavi for Eagle/Hawk or RS/BM in Loop 2 (one will be Loop 1 repeat, other will be new)";
                
                case 159: return "Bass Omega/XX added as random encounter after beating MegaManDS";
                
                case 256: return "ElecTown unlocked as destination";
                case 257: return "DenDome unlocked as destination";
                case 258: return "Castillo unlocked as destination";
                case 259: return "Airport unlocked as destination";
                case 260: return "Netopia unlocked as destination";
                case 261: return "Yumland unlocked as destination";
                case 262: return "Netfrica unlocked as destination";
                case 263: return "Sharo unlocked as destination";
                case 264: return "NAXA unlocked as destination";
                
                case 1280: return "On playthrough 2+?";
                
                // 3328-4254: BMD/PMD flags
                
                case 4256: return "VampireManor Django statue GunDelS1 G";
                case 4257: return "NetFrica house RegUP1";
                case 4258: return "DenDome Waiting Room folded chairs RegUP1";
                case 4259: return "NAXA Lobby spacesuit RegUP3";
                case 4260: return "Undernet 4 HeelNavi gave GunDelS2 G";
                
                case 4450: return "Freezes NPC objects";
                case 4454: return "Game has been saved once?";
                case 4458: return "Unlocker subchip being used";
                case 4459: return "Untrap subchip active";
                case 4460: return "SneakRun subchip active";
                case 4461: return "LocEnemy subchip active";
                case 4468: return "Show mugshot in textbox, locks movement if false";
                case 4470: return "Triggers C-Slider rail message?";
                case 4472: return "Causes fast sliding?";
                
                // 4608-5119: BBS posts
                // 5120-5567: BBS posts unread
                // 5568-5601: Emails
                // 5696-5729: Emails unread
            }
            return "";
        }
        
        // BN4 exclusive
        public static string[] getMysteryDataLoopContents(int flag)
        {
            // Note: GMDs are included here without defined contents for sake of flag names mroe than anything.
            // Also, definitions stop at the last unique item; all collections after that give the last defined item again.
            
            switch (flag)
            {
                case 3328: return new string[] { "BMD", "ACDC Area 1", "BugStop White", "RegUP2", "BugFrag x1", "1000z" };
                case 3329: return new string[] { "BMD", "ACDC Area 1", "MiniEnrg", "TripCrak *", "HP+50 Yellow", "BugFrag x1" };
                case 3330: return new string[] { "GMD", "ACDC Area 1" };
                case 3331: return new string[] { "GMD", "ACDC Area 1" };
                case 3336: return new string[] { "PMD", "ACDC Area 2", "Geyser L", "AntiElec H", "AntiWood M", "BugFrag x1" };
                case 3337: return new string[] { "GMD", "ACDC Area 2" };
                case 3338: return new string[] { "GMD", "ACDC Area 2" };
                case 3344: return new string[] { "BMD", "ACDC Area 3", "Jealousy J", "Charge+1 Pink", "BugFrag x3", "500z" };
                case 3345: return new string[] { "BMD", "ACDC Area 3", "CopyDmg *", "BugFrag x1", "MegEnBom D", "2000z" };
                case 3346: return new string[] { "GMD", "ACDC Area 3" };
                case 3347: return new string[] { "GMD", "ACDC Area 3" };
                case 3392: return new string[] { "PMD", "Town Area 1", "HPMemory", "SpinGrn", "BugFrag x3", "500z" };
                case 3393: return new string[] { "BMD", "Town Area 1", "SandRing *", "RegUP1", "BugFrag x1", "FullEnrg" };
                case 3394: return new string[] { "GMD", "Town Area 1" };
                case 3395: return new string[] { "GMD", "Town Area 1" };
                case 3400: return new string[] { "BMD", "Town Area 2", "Invis *", "3400z", "CustSwrd S", "1700z" };
                case 3401: return new string[] { "PMD", "Town Area 2", "Blinder *", "AntiDmg M", "SpinBlue", "BugFrag x1" };
                case 3402: return new string[] { "GMD", "Town Area 2" };
                case 3403: return new string[] { "GMD", "Town Area 2" };
                case 3408: return new string[] { "BMD", "Town Area 3", "Recov30 R", "HiCannon E", "BugFrag x1", "Untrap" };
                case 3409: return new string[] { "PMD", "Town Area 3", "CustSwrd B", "HP+400 Yellow", "HPMemory", "BugFrag x2" };
                case 3410: return new string[] { "GMD", "Town Area 3" };
                case 3411: return new string[] { "GMD", "Town Area 3" };
                case 3416: return new string[] { "PMD", "Town Area 4", "WindRack A", "AntiWatr D", "GrabRvng D", "BugFrag x2" };
                case 3417: return new string[] { "GMD", "Town Area 4" };
                case 3418: return new string[] { "GMD", "Town Area 4" };
                case 3456: return new string[] { "BMD", "Park Area 1", "AntiSwrd N", "RegUP2", "1800z", "1900z" };
                case 3457: return new string[] { "BMD", "Park Area 1", "RegUP2", "HPMemory", "BugFrag x1", "4000z" };
                case 3458: return new string[] { "GMD", "Park Area 1" };
                case 3459: return new string[] { "GMD", "Park Area 1" };
                case 3464: return new string[] { "BMD", "Park Area 2", "HPMemory", "BugFrag x1", "ColorPt *", "1200z" };
                case 3465: return new string[] { "PMD", "Park Area 2", "VarSwrd V", "BugFrag x5", "HP+200 Yellow", "BugFrag x3" };
                case 3466: return new string[] { "GMD", "Park Area 2" };
                case 3467: return new string[] { "GMD", "Park Area 2" };
                case 3472: return new string[] { "BMD", "Park Area 3", "MegFldr1 Green", "4000z", "1500z", "2000z" };
                case 3473: return new string[] { "BMD", "Park Area 3", "BugFrag x1", "Charge+1 White", "BugFrag x1", "1000z" };
                case 3474: return new string[] { "PMD", "Park Area 3", "ColorPt *", "DblPoint *", "HPMemory", "10000z" };
                case 3475: return new string[] { "GMD", "Park Area 3" };
                case 3476: return new string[] { "GMD", "Park Area 3" };
                
                case 3520: return new string[] { "BMD", "Yumland Area", "RegUP2", "1300z", "BugFrag x1", "2500z" };
                case 3521: return new string[] { "PMD", "Yumland Area", "Lance G", "BugFix B", "RegUP2", "BugFrag x1" };
                case 3522: return new string[] { "GMD", "Yumland Area" };
                case 3523: return new string[] { "GMD", "Yumland Area" };
                case 3528: return new string[] { "BMD", "Netopia Area", "SprArmr Red", "BugFrag x2", "Snake D", "BugFrag x1" };
                case 3529: return new string[] { "BMD", "Netopia Area", "HPMemory", "RegUP1", "BugFrag x1", "1400z" };
                case 3530: return new string[] { "GMD", "Netopia Area" };
                case 3531: return new string[] { "GMD", "Netopia Area" };
                case 3536: return new string[] { "BMD", "NetFrica Area", "Jungle Green", "2300z", "2800z", "800z" };
                case 3537: return new string[] { "BMD", "NetFrica Area", "Barr100 W", "AntiRecv D", "HPMemory", "3700z" };
                case 3538: return new string[] { "GMD", "NetFrica Area" };
                case 3539: return new string[] { "GMD", "NetFrica Area" };
                case 3544: return new string[] { "BMD", "Sharo Area", "HP+200 White", "HPMemory", "1500z", "4000z" };
                case 3545: return new string[] { "BMD", "Sharo Area", "HPMemory", "Speed+1 Yellow", "SubMemry", "BugFrag x1" };
                case 3546: return new string[] { "GMD", "Sharo Area" };
                case 3547: return new string[] { "GMD", "Sharo Area" };
                case 3548: return new string[] { "PMD", "Sharo Area", "BlkBomb Z", "BlkBomb Z", "BlkBomb Z", "BugFrag x3" };
                
                case 3584: return new string[] { "BMD", "Undernet 1", "RegUP1", "HPMemory", "BugFrag x2", "500z" };
                case 3585: return new string[] { "PMD", "Undernet 1", "Snake M", "GodHammr G", "HP+400 White", "BugFrag x1" };
                case 3586: return new string[] { "GMD", "Undernet 1" };
                case 3587: return new string[] { "GMD", "Undernet 1" };
                case 3592: return new string[] { "BMD", "Undernet 2", "ExpMemry", "RegUP1", "2900z", "900z" };
                case 3593: return new string[] { "BMD", "Undernet 2", "SpeedMAX White", "Barr200 U", "HP+300 White", "4400z" };
                case 3594: return new string[] { "GMD", "Undernet 2" };
                case 3595: return new string[] { "GMD", "Undernet 2" };
                case 3600: return new string[] { "BMD", "Undernet 3", "HPMemory", "3000z", "5000z", "BugFrag x1" };
                case 3601: return new string[] { "BMD", "Undernet 3", "Recov120 Q", "AntiFire K", "BugFrag x1", "2000z" };
                case 3602: return new string[] { "GMD", "Undernet 3" };
                case 3603: return new string[] { "GMD", "Undernet 3" };
                case 3604: return new string[] { "GMD", "Undernet 3" };
                case 3608: return new string[] { "BMD", "Undernet 4", "Custom1 Blue", "M-Cannon G", "BugFrag x1", "1400z" };
                case 3609: return new string[] { "PMD", "Undernet 4", "Guardian O", "DrkLine L", "HPMemory", "20000z" };
                case 3610: return new string[] { "BMD", "Undernet 4", "HPMemory", "BugBomb *", "1400z", "BugFrag x1" };
                case 3611: return new string[] { "GMD", "Undernet 4" };
                case 3612: return new string[] { "GMD", "Undernet 4" };
                case 3616: return new string[] { "BMD", "Undernet 5", "2000z", "1000z" };
                case 3617: return new string[] { "PMD", "Undernet 5", "NeoVari N", "BugFrag x2" };
                case 3618: return new string[] { "BMD", "Undernet 5", "BugFrag x3", "2400z" };
                case 3619: return new string[] { "PMD", "Undernet 5", "Snctuary S", "BugFrag x5" };
                case 3620: return new string[] { "GMD", "Undernet 5" };
                case 3621: return new string[] { "GMD", "Undernet 5" };
                case 3624: return new string[] { "BMD", "Undernet 6", "Hole *", "BugFrag x2", "2400z", "2100z" };
                case 3625: return new string[] { "BMD", "Undernet 6", "Attack+1 Yellow", "BlkBomb D", "BugFrag x1" };
                case 3626: return new string[] { "GMD", "Undernet 6" };
                case 3627: return new string[] { "GMD", "Undernet 6" };
                
                case 3632: return new string[] { "BMD", "Black Earth 1", "HPMemory", "BugFrag x1" };
                case 3633: return new string[] { "BMD", "Black Earth 1", "LifeAura D", "BugFrag x1" };
                case 3634: return new string[] { "GMD", "Black Earth 1" };
                case 3635: return new string[] { "GMD", "Black Earth 1" };
                case 3636: return new string[] { "GMD", "Black Earth 1" };
                case 3640: return new string[] { "BMD", "Black Earth 2", "3000z", "2000z" };
                case 3641: return new string[] { "BMD", "Black Earth 2", "HPMemory", "3200z" };
                case 3642: return new string[] { "BMD", "Black Earth 2", "BugFrag x5", "FullEnrg" };
                case 3643: return new string[] { "PMD", "Black Earth 2", "GigFldr1 Red", "BugFrag x5" };
                case 3644: return new string[] { "GMD", "Black Earth 2" };
                case 3645: return new string[] { "GMD", "Black Earth 2" };
                
                case 3712: return new string[] { "BMD", "ElecTower Comp 1", "700z", "BugFrag x1", "1400z", "BugFrag x1" };
                case 3713: return new string[] { "BMD", "ElecTower Comp 1", "RegUP2", "MegEnBom D", "Charge+1 Pink", "1400z" };
                case 3714: return new string[] { "BMD", "ElecTower Comp 1", "Spreader M", "RegUP1", "HPMemory", "1000z" };
                case 3720: return new string[] { "BMD", "ElecTower Comp 2", "LongSwrd S", "2300z", "BugFrag x1", "1000z" };
                case 3721: return new string[] { "BMD", "ElecTower Comp 2", "BugFrag x1", "WideBlde C", "2900z", "800z" };
                case 3722: return new string[] { "BMD", "ElecTower Comp 2", "HPMemory", "HPMemory", "RegUP2", "BugFrag x1" };
                
                case 3776: return new string[] { "BMD", "ToyRobo Comp 1", "HP+50 Pink", "3200z", "1000z", "1000z" };
                case 3777: return new string[] { "BMD", "ToyRobo Comp 1", "1400z", "RegUP1", "HPMemory", "700z" };
                case 3778: return new string[] { "BMD", "ToyRobo Comp 1", "RegUP1", "Counter3 V", "M-Cannon G", "BugFrag x1" };
                case 3784: return new string[] { "BMD", "ToyRobo Comp 2", "RockCube *", "1500z", "BugFrag x1", "400z" };
                case 3785: return new string[] { "BMD", "ToyRobo Comp 2", "HPMemory", "BugFrag x1", "BugBomb B", "2000z" };
                case 3786: return new string[] { "BMD", "ToyRobo Comp 2", "Vulcan2 B", "Recov150 C", "2200z", "BugFrag x1" };
                case 3793: return new string[] { "BMD", "ToyRobo Comp 3", "Charge+1 Yellow", "HPMemory", "HP+300 Yellow", "900z" };
                case 3794: return new string[] { "BMD", "ToyRobo Comp 3", "RegUP2", "Attack+1 White", "BugFrag x1", "1800z" };
                case 3801: return new string[] { "BMD", "ToyRobo Comp 4", "HPMemory", "RegUP2", "RegUP1", "BugFrag x1" };
                case 3802: return new string[] { "BMD", "ToyRobo Comp 4", "Recov80 J", "Vulcan3 W", "Vulcan3 W", "2200z" };
                
                case 3840: return new string[] { "BMD", "Asteroid Comp 1", "Geddon1 W", "1800z", "2000z", "1000z" };
                case 3841: return new string[] { "BMD", "Asteroid Comp 1", "HPMemory", "Recov200 M", "RegUP1", "BugFrag x1" };
                case 3842: return new string[] { "BMD", "Asteroid Comp 1", "HiCannon D", "SpinRed", "BugFrag x1", "1800z" };
                case 3848: return new string[] { "BMD", "Asteroid Comp 2", "1800z", "RegUP1", "3200z", "900z" };
                case 3849: return new string[] { "BMD", "Asteroid Comp 2", "WideBlde K", "BugFrag x2", "BugFix *", "BugFrag x2" };
                case 3850: return new string[] { "BMD", "Asteroid Comp 2", "RegUP3", "NrthWind E", "HPMemory", "2000z" };
                case 3856: return new string[] { "BMD", "Asteroid Comp 3", "Counter2 L", "HPMemory", "BugFrag x1", "1600z" };
                case 3857: return new string[] { "BMD", "Asteroid Comp 3", "HP+100 Pink", "3000z", "LongBlde R", "1000z" };
                case 3858: return new string[] { "BMD", "Asteroid Comp 3", "BugFrag x1", "M-Cannon E", "2500z", "BugFrag x1" };
                case 3864: return new string[] { "BMD", "Asteroid Comp 4", "FullEnrg", "BugFrag x1", "WindRack *", "BugFrag x1" };
                case 3865: return new string[] { "BMD", "Asteroid Comp 4", "Recov120 F", "HP+200 Pink", "1700z", "1000z" };
                case 3866: return new string[] { "BMD", "Asteroid Comp 4", "Attack+1 White", "FullEnrg", "FullEnrg", "2700z" };
                case 3867: return new string[] { "BMD", "Asteroid Comp 4", "VarSwrd V", "RegUP1", "BugFrag x1", "BugFrag x1" };
                
                case 4160: return new string[] { "BMD", "Lan's House Oven Comp", "500z", "1000z", "2000z", "BugFrag x1" };
                case 4162: return new string[] { "BMD", "ElecTown 2 Stereo Comp", "PanlGrab *", "BugFrag x1", "LocEnemy", "500z" };
                case 4163: return new string[] { "BMD", "ElecTown 2 Stereo Comp", "RegUP1", "FullEnrg", "BugFrag x1", "BugFrag x1" };
                case 4164: return new string[] { "BMD", "DenDome HotDog Comp", "HPMemory", "2600z", "BugFrag x1", "900z" };
                case 4166: return new string[] { "BMD", "DenDome NetBattle Comp", "Spreader N", "BugFrag x1", "1400z", "1500z" };
                case 4168: return new string[] { "BMD", "CyberTop Comp", "1600z", "2000z", "2400z", "1500z" };
                case 4170: return new string[] { "BMD", "ElecTown 2 LCD Comp", "RegUP2", "RegUP1", "BugFrag x1", "5000z" };
                case 4172: return new string[] { "BMD", "Castillo NetBattle Comp", "HPMemory", "SubMemry", "1000z", "BugFrag x1" };
                case 4174: return new string[] { "BMD", "Yum Ruins Statue Comp", "SpinWhit", "HPMemory", "2000z", "1000z" };
                case 4176: return new string[] { "BMD", "Nupopo Comp", "SubMemry", "LocEnemy", "FullEnrg" };
                case 4178: return new string[] { "BMD", "Sharo Computer Comp", "Speed+1 Pink", "RegUP1", "BugFrag x1", "1000z" };
                case 4180: return new string[] { "BMD", "Mayl's House Toy Comp", "MiniBomb *", "BugFrag x1", "800z", "LocEnemy" };
                case 4182: return new string[] { "BMD", "Colosseum NetBattle Comp", "SpinPink", "1800z", "Unlocker", "1800z" };
                case 4184: return new string[] { "BMD", "NetFrica Lion Comp", "RegUP2", "SneakRun", "BugFrag x2", "BugFrag x1" };
                
                case 4186: return new string[] { "BMD", "Doghouse Comp", "Barrier A", "HP+50 White", "BugFrag x1", "3000z" };
                case 4188: return new string[] { "BMD", "Dex's House Game Comp", "Counter1 T", "1000z", "Untrap", "1300z" };
                case 4190: return new string[] { "BMD", "DenDome Hall Vending Comp", "Recov50 S", "HPMemory", "1800z", "Unlocker" };
                case 4192: return new string[] { "BMD", "DenDome Card Comp", "Unlocker", "BugFrag x1", "2500z", "BugFrag x1" };
                case 4194: return new string[] { "BMD", "DenDome Waiting Water Comp", "Fish Blue", "Speed+1 White", "BugFrag x1", "2100z" };
                case 4196: return new string[] { "BMD", "Castillo Ticket Comp", "SubMemry", "Vulcan3 O", "Recov150 T", "1500z" };
                case 4198: return new string[] { "BMD", "Castillo Stand Comp", "HPMemory", "RegUP1", "1300z", "BugFrag x1" };
                case 4200: return new string[] { "BMD", "Sharo Antenna Comp 1", "RegUP1", "BugFrag x1", "BugFrag x1", "500z" };
                case 4202: return new string[] { "BMD", "Sharo Antenna Comp 2", "HPMemory", "BugFrag x1", "BugFrag x1", "500z" };
                case 4204: return new string[] { "BMD", "Sharo Antenna Comp 3", "BugBomb G", "BugFrag x1", "BugFrag x1", "500z" };
                case 4206: return new string[] { "BMD", "Sharo Antenna Comp 4", "Battery Yellow", "BugFrag x1", "BugFrag x1", "500z" };
                case 4208: return new string[] { "BMD", "Yum Ruins Buddha Comp", "2000z", "2000z", "2000z", "2500z" };
                case 4210: return new string[] { "BMD", "Netopia Goddess Comp", "Recov150 Z", "SpinYllw", "HolyPanl *", "BugFrag x1" };
                case 4212: return new string[] { "BMD", "Colosseum Hero Comp", "ExpMemry", "M-Cannon F", "Barr100 P", "BugFrag x1" };
                case 4214: return new string[] { "BMD", "Flave Cook Comp", "2500z" };
                
                case 4224: return new string[] { "BMD", "WaterGod Comp 1", "100z" };
                case 4226: return new string[] { "BMD", "WaterGod Comp 2", "100z" };
                case 4228: return new string[] { "BMD", "WaterGod Comp 3", "100z" };
                case 4230: return new string[] { "BMD", "WaterGod Comp 4", "100z" };
                case 4232: return new string[] { "BMD", "WaterGod Comp 5", "100z" };
                case 4234: return new string[] { "BMD", "WaterGod Comp 6", "100z" };
                case 4236: return new string[] { "BMD", "WaterGod Comp 7", "100z" };
                case 4238: return new string[] { "BMD", "WaterGod Comp 8", "100z" };
                case 4240: return new string[] { "BMD", "WaterGod Comp 9", "FullEnrg" };
                case 4242: return new string[] { "BMD", "WaterGod Comp 10", "100z" };
                case 4244: return new string[] { "BMD", "WaterGod Comp 11", "100z" };
                case 4246: return new string[] { "BMD", "WaterGod Comp 12", "FullCust *", "10000z" };
                case 4248: return new string[] { "BMD", "WaterGod Comp 13", "100z" };
                case 4250: return new string[] { "BMD", "WaterGod Comp 14", "100z" };
                case 4252: return new string[] { "BMD", "WaterGod Comp 15", "100z" };
                case 4254: return new string[] { "BMD", "WaterGod Comp 16", "10000z" };
            }
            return new string[0];
        }
    }
}
