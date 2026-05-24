using System.Collections.Generic;

namespace MMBNSaveEditor
{
    /// <summary>An object that returns definitions for Battle Network 3.</summary>
    class BN3Definitions : BNDefinitions
    {
        public override string[] chipNames { get { return new string[] {
            "MegaBstr", "Cannon", "HiCannon", "M-Cannon", "AirShot1", "AirShot2", "AirShot3", "LavaCan1", "LavaCan2", "LavaCan3",
            "ShotGun", "V-Gun", "SideGun", "Spreader", "Bubbler", "Bub-V", "BublSide", "HeatShot", "Heat-V", "HeatSide",
            "MiniBomb", "SnglBomb", "DublBomb", "TrplBomb", "CannBall", "IceBall", "LavaBall", "BlkBomb1", "BlkBomb2", "BlkBomb3",
            "Sword", "WideSwrd", "LongSwrd", "FireSwrd", "AquaSwrd", "ElecSwrd", "BambSwrd", "CustSwrd", "VarSwrd", "StepSwrd",
            "StepCros", "Panic", "AirSwrd", "Slasher", "ShockWav", "SonicWav", "DynaWave", "GutPunch", "GutStrgt", "GutImpct",
            "AirStrm1", "AirStrm2", "AirStrm3", "DashAtk", "Burner", "Totem1", "Totem2", "Totem3", "Ratton1", "Ratton2",
            "Ratton3", "Wave", "RedWave", "MudWave", "Hammer", "Tornado", "ZapRing1", "ZapRing2", "ZapRing3", "Yo-Yo1",
            "Yo-Yo2", "Yo-Yo3", "Spice1", "Spice2", "Spice3", "Lance", "Scuttlst", "Momogra", "Rope1", "Rope2",
            "Rope3", "Magnum1", "Magnum2", "Magnum3", "Boomer1", "Boomer2", "Boomer3", "RndmMetr", "HoleMetr", "ShotMetr",
            "IceWave1", "IceWave2", "IceWave3", "Plasma1", "Plasma2", "Plasma3", "Arrow1", "Arrow2", "Arrow3", "TimeBomb",
            "Mine", "Sensor1", "Sensor2", "Sensor3", "CrsShld1", "CrsShld2", "CrsShld3", "Geyser", "PoisMask", "PoisFace",
            "Shake1", "Shake2", "Shake3", "BigWave", "Volcano", "Condor", "Burning", "FireRatn", "Guard", "PanlOut1",
            "PanlOut3", "Recov10", "Recov30", "Recov50", "Recov80", "Recov120", "Recov150", "Recov200", "Recov300", "PanlGrab",
            "AreaGrab", "Snake", "Team1", "MetaGel1", "MetaGel2", "MetaGel3", "GrabBack", "GrabRvng", "Geddon1", "Geddon2",
            "Geddon3", "RockCube", "Prism", "Wind", "Fan", "RockArm1", "RockArm2", "RockArm3", "NoBeam1", "NoBeam2",
            "NoBeam3", "Pawn", "Knight", "Rook", "Needler1", "Needler2", "Needler3", "SloGauge", "FstGauge", "Repair",
            "Invis", "Hole", "Mole1", "Mole2", "Mole3", "Shadow", "Mettaur", "Bunny", "AirShoes", "Team2",
            "Fanfare", "Discord", "Timpani", "Barrier", "Barr100", "Barr200", "Aura", "NrthWind", "HolyPanl", "LavaStge",
            "IceStage", "GrassStg", "SandStge", "MetlStge", "Snctuary", "Swordy", "Spikey", "Mushy", "Jelly", "KillrEye",
            "AntiNavi", "AntiDmg", "AntiSwrd", "AntiRecv", "CopyDmg", "Atk+10", "Fire+30", "Aqua+30", "Elec+30", "Wood+30",
            "Navi+20", "LifeAura", "Muramasa", "Guardian", "Anubis", "Atk+30", "Navi+40", "HeroSwrd", "ZeusHamr", "GodStone",
            "OldWood", "FullCust", "Meteors", "Poltrgst", "Jealousy", "StandOut", "WatrLine", "Ligtning", "GaiaSwrd", "Roll",
            "RollV2", "RollV3", "GutsMan", "GutsManV2", "GutsManV3", "GutsManV4", "GutsManV5", "ProtoMan", "ProtoMnV2", "ProtoMnV3",
            "ProtoMnV4", "ProtoMnV5", "FlashMan", "FlashMnV2", "FlashMnV3", "FlashMnV4", "FlashMnV5", "BeastMan", "BeastMnV2", "BeastMnV3",
            "BeastMnV4", "BeastMnV5", "BubblMan", "BubblMnV2", "BubblMnV3", "BubblMnV4", "BubblMnV5", "DesrtMan", "DesrtMnV2", "DesrtMnV3",
            "DesrtMnV4", "DesrtMnV5", "PlantMan", "PlantMnV2", "PlantMnV3", "PlantMnV4", "PlantMnV5", "FlameMan", "FlameMnV2", "FlameMnV3",
            "FlameMnV4", "FlameMnV5", "DrillMan", "DrillMnV2", "DrillMnV3", "DrillMnV4", "DrillMnV5", "MetalMan", "MetalMnV2", "MetalMnV3",
            "MetalMnV4", "MetalMnV5", "Punk", "Salamndr", "Fountain", "Bolt", "GaiaBlad", "KingMan", "KingManV2", "KingManV3",
            "KingManV4", "KingManV5", "MistMan", "MistManV2", "MistManV3", "MistManV4", "MistManV5", "BowlMan", "BowlManV2", "BowlManV3",
            "BowlManV4", "BowlManV5", "DarkMan", "DarkManV2", "DarkManV3", "DarkManV4", "DarkManV5", "YamatoMn", "YamatMnV2", "YamatMnV3",
            "YamatMnV4", "YamatMnV5", "DeltaRay", "FoldrBak", "NavRcycl", "AlphArmΣ", "Bass", "Serenade", "Balance", "DarkAura",
            "AlphArmΩ", "Bass+", "BassGS"
        }; } }
        
        public override string[] paNames { get { return new string[] {
            "Z-Canon1", "Z-Canon2", "Z-Canon3", "Z-Punch", "Z-Strght", "Z-Impact", "Z-Varibl", "Z-Yoyo1", "Z-Yoyo2", "Z-Yoyo3",
            "Z-Step1", "Z-Step2", "TimeBom+", "H-Burst", "BubSprd", "HeatSprd", "LifeSwrd", "ElemSwrd", "EvilCut", "2xHero",
            "HyperRat", "EverCrse", "GelRain", "PoisPhar", "BodyGrd", "500Barr", "BigHeart", "GtsShoot", "DeuxHero", "MomQuake",
            "PrixPowr", "MstrStyl"
        }; } }
        
        public override Dictionary<string, string[]> chipAliases { get {
            Dictionary<string, string[]> def = new Dictionary<string, string[]>();
            def["FlameMan"] = new string[] { "FlamMan" };
            def["FlameMnV2"] = new string[] { "FlamManV2", "FlameManV2" };
            def["FlameMnV3"] = new string[] { "FlamManV3", "FlameManV3" };
            def["FlameMnV4"] = new string[] { "FlamManV4", "FlameManV4" };
            def["FlameMnV5"] = new string[] { "FlamManV5", "FlameManV5" };
            def["YamatoMn"] = new string[] { "JapanMan", "YamatoMan" };
            def["YamatMnV2"] = new string[] { "JapanMnV2", "JapanManV2", "YamatoManV2", "YamatManV2", "YamatoMnV2" };
            def["YamatMnV3"] = new string[] { "JapanMnV3", "JapanManV3", "YamatoManV3", "YamatManV3", "YamatoMnV3" };
            def["YamatMnV4"] = new string[] { "JapanMnV4", "JapanManV4", "YamatoManV4", "YamatManV4", "YamatoMnV4" };
            def["YamatMnV5"] = new string[] { "JapanMnV5", "JapanManV5", "YamatoManV5", "YamatManV5", "YamatoMnV5" };
            def["ProtoMnV2"] = new string[] { "ProtoManV2" };
            def["ProtoMnV3"] = new string[] { "ProtoManV3" };
            def["ProtoMnV4"] = new string[] { "ProtoManV4" };
            def["ProtoMnV5"] = new string[] { "ProtoManV5" };
            def["FlashMnV2"] = new string[] { "FlashManV2" };
            def["FlashMnV3"] = new string[] { "FlashManV3" };
            def["FlashMnV4"] = new string[] { "FlashManV4" };
            def["FlashMnV5"] = new string[] { "FlashManV5" };
            def["BeastMnV2"] = new string[] { "BeastManV2" };
            def["BeastMnV3"] = new string[] { "BeastManV3" };
            def["BeastMnV4"] = new string[] { "BeastManV4" };
            def["BeastMnV5"] = new string[] { "BeastManV5" };
            def["BubblMan"] = new string[] { "BubbleMan", "BubbleMn" };
            def["BubblMnV2"] = new string[] { "BubbleManV2", "BubbleMnV2", "BubblManV2" };
            def["BubblMnV3"] = new string[] { "BubbleManV3", "BubbleMnV3", "BubblManV3" };
            def["BubblMnV4"] = new string[] { "BubbleManV4", "BubbleMnV4", "BubblManV4" };
            def["BubblMnV5"] = new string[] { "BubbleManV5", "BubbleMnV5", "BubblManV5" };
            def["DesrtMan"] = new string[] { "DesertMan", "DesertMn", "DesrtMn" };
            def["DesrtMnV2"] = new string[] { "DesertManV2", "DesertMnV2", "DesrtManV2" };
            def["DesrtMnV3"] = new string[] { "DesertManV3", "DesertMnV3", "DesrtManV3" };
            def["DesrtMnV4"] = new string[] { "DesertManV4", "DesertMnV4", "DesrtManV4" };
            def["DesrtMnV5"] = new string[] { "DesertManV5", "DesertMnV5", "DesrtManV5" };
            def["PlantMnV2"] = new string[] { "PlantManV2" };
            def["PlantMnV3"] = new string[] { "PlantManV3" };
            def["PlantMnV4"] = new string[] { "PlantManV4" };
            def["PlantMnV5"] = new string[] { "PlantManV5" };
            def["DrillMnV2"] = new string[] { "DrillManV2" };
            def["DrillMnV3"] = new string[] { "DrillManV3" };
            def["DrillMnV4"] = new string[] { "DrillManV4" };
            def["DrillMnV5"] = new string[] { "DrillManV5" };
            def["MetalMnV2"] = new string[] { "MetalManV2" };
            def["MetalMnV3"] = new string[] { "MetalManV3" };
            def["MetalMnV4"] = new string[] { "MetalManV4" };
            def["MetalMnV5"] = new string[] { "MetalManV5" };
            return def;
        } }
        
        public override string[] chipCodes { get { return new string[] {
            "------", // MegaBstr
            "ABCDE*", // Cannon
            "HIJKL*", // HiCannon
            "OPQRS-", // M-Cannon
            "*-----", // AirShot1
            "*-----", // AirShot2
            "*-----", // AirShot3
            "AGSTV-", // LavaCan1
            "BDFMO-", // LavaCan2
            "EHJRW-", // LavaCan3
            "BFJNT*", // ShotGun
            "DGLPV*", // V-Gun
            "CHMSY*", // SideGun
            "MNOPQ*", // Spreader
            "ACDEP*", // Bubbler
            "DEFSV-", // Bub-V
            "BEFGR-", // BublSide
            "BHIJP*", // HeatShot
            "FIJKV*", // Heat-V
            "CJKLT*", // HeatSide
            "BGLOS*", // MiniBomb
            "DFHJT*", // SnglBomb
            "ACHKQ*", // DublBomb
            "EINPW-", // TrplBomb
            "ADFLP*", // CannBall
            "FIMQS*", // IceBall
            "BCHNW*", // LavaBall
            "FLNPZ-", // BlkBomb1
            "DIKQS-", // BlkBomb2
            "CGLUY-", // BlkBomb3
            "EHLSY-", // Sword
            "CELQY-", // WideSwrd
            "EILRY-", // LongSwrd
            "FNPRU-", // FireSwrd
            "AHNPT-", // AquaSwrd
            "EKNPV-", // ElecSwrd
            "BLNPW-", // BambSwrd
            "BFRVZ-", // CustSwrd
            "BCDEF-", // VarSwrd
            "LMNOP-", // StepSwrd
            "PQRST-", // StepCros
            "ACLRZ-", // Panic
            "CEHJR*", // AirSwrd
            "BDGRS-", // Slasher
            "DHJLR-", // ShockWav
            "GIMSW-", // SonicWav
            "ENQTV-", // DynaWave
            "BCDEF-", // GutPunch
            "OPQRS-", // GutStrgt
            "GHIJK-", // GutImpct
            "AFHOS-", // AirStrm1
            "CGHMW-", // AirStrm2
            "AGINV-", // AirStrm3
            "CDGJZ*", // DashAtk
            "BFQSW-", // Burner
            "GHMOV-", // Totem1
            "ACETZ-", // Totem2
            "DIKNQ-", // Totem3
            "ACFHJ-", // Ratton1
            "ACFNO-", // Ratton2
            "ACFRS-", // Ratton3
            "EILST-", // Wave
            "BFJRU-", // RedWave
            "DGMVZ-", // MudWave
            "BGLPT*", // Hammer
            "CLRTU-", // Tornado
            "AMPQS*", // ZapRing1
            "BGNRW-", // ZapRing2
            "CEOTZ-", // ZapRing3
            "CDEFG*", // Yo-Yo1
            "HIJKL-", // Yo-Yo2
            "MNOPQ-", // Yo-Yo3
            "BDISZ*", // Spice1
            "CFIKR-", // Spice2
            "DFJOQ-", // Spice3
            "DEHRZ-", // Lance
            "ADEMR-", // Scuttlst
            "GMORU-", // Momogra
            "DGJMO*", // Rope1
            "EGOTU-", // Rope2
            "HITUV-", // Rope3
            "ACHTV-", // Magnum1
            "BGNOZ-", // Magnum2
            "DFISW-", // Magnum3
            "FHJMT*", // Boomer1
            "EIKNV*", // Boomer2
            "LOPUZ-", // Boomer3
            "EISVZ-", // RndmMetr
            "CHJNQ-", // HoleMetr
            "ADFSY-", // ShotMetr
            "AKMQW*", // IceWave1
            "DHLPR*", // IceWave2
            "CDJRV-", // IceWave3
            "BDJRT-", // Plasma1
            "AGKMQ-", // Plasma2
            "FINPS-", // Plasma3
            "BEMQT-", // Arrow1
            "FRSUZ-", // Arrow2
            "AHJNP-", // Arrow3
            "JKLMN-", // TimeBomb
            "ADLRS*", // Mine
            "CKLOP-", // Sensor1
            "AGHNS-", // Sensor2
            "BEJOP-", // Sensor3
            "ACHLP*", // CrsShld1
            "BCLST-", // CrsShld2
            "CELNR-", // CrsShld3
            "BCLSW-", // Geyser
            "AFNQV*", // PoisMask
            "ANQVW*", // PoisFace
            "EGRSU-", // Shake1
            "BFILQ-", // Shake2
            "DMRTZ-", // Shake3
            "EJMPY-", // BigWave
            "AGJYZ-", // Volcano
            "BILSZ-", // Condor
            "AFLRS-", // Burning
            "BFHMY-", // FireRatn
            "*-----", // Guard
            "ABDLS*", // PanlOut1
            "CENRY-", // PanlOut3
            "ACEGL*", // Recov10
            "BDFHM*", // Recov30
            "CEGIN*", // Recov50
            "DFHJO*", // Recov80
            "OQSUW*", // Recov120
            "NPRTV-", // Recov150
            "MNUVW-", // Recov200
            "ORVWZ-", // Recov300
            "AHLSY*", // PanlGrab
            "ELRSY*", // AreaGrab
            "DEIRY-", // Snake
            "ACETZ*", // Team1
            "BCDKY-", // MetaGel1
            "EFGPS-", // MetaGel2
            "GHSTU-", // MetaGel3
            "AEIKN-", // GrabBack
            "CGPRY-", // GrabRvng
            "DJMOS*", // Geddon1
            "FHNOW-", // Geddon2
            "CMUWY-", // Geddon3
            "ACEHR*", // RockCube
            "HJKQW-", // Prism
            "AEHOS*", // Wind
            "AGLRT*", // Fan
            "DHJOP*", // RockArm1
            "GMPSV*", // RockArm2
            "CILTZ-", // RockArm3
            "CFGTZ-", // NoBeam1
            "EISUY-", // NoBeam2
            "HMVWZ-", // NoBeam3
            "BENRY-", // Pawn
            "CHMUV-", // Knight
            "DFNQU*", // Rook
            "IJMRS-", // Needler1
            "FHMTV-", // Needler2
            "DLOUZ-", // Needler3
            "ACRSZ*", // SloGauge
            "BEJRY-", // FstGauge
            "ACDFS*", // Repair
            "BEFRS*", // Invis
            "ABSTZ*", // Hole
            "ADHJO*", // Mole1
            "BDIKR*", // Mole2
            "CELMQ-", // Mole3
            "HJNQU*", // Shadow
            "ELMOT-", // Mettaur
            "ABILR-", // Bunny
            "HINUY*", // AirShoes
            "DLPSZ*", // Team2
            "CEGLY*", // Fanfare
            "DFNTZ*", // Discord
            "ANQUW*", // Timpani
            "CELRS*", // Barrier
            "EJMRT*", // Barr100
            "EFHRU-", // Barr200
            "FISUY-", // Aura
            "ACNSZ-", // NrthWind
            "EJLRU*", // HolyPanl
            "AERTY*", // LavaStge
            "CGMQT*", // IceStage
            "EJRWZ*", // GrassStg
            "BCQUW-", // SandStge
            "DGMOS-", // MetlStge
            "ACELS-", // Snctuary
            "DIOSW-", // Swordy
            "AEGRU-", // Spikey
            "CHMSY-", // Mushy
            "EJLRY-", // Jelly
            "EIKLR-", // KillrEye
            "AMNVW-", // AntiNavi
            "CFHMS-", // AntiDmg
            "BKRUY-", // AntiSwrd
            "BDEOS-", // AntiRecv
            "AFHLY*", // CopyDmg
            "*-----", // Atk+10
            "*-----", // Fire+30
            "*-----", // Aqua+30
            "*-----", // Elec+30
            "*-----", // Wood+30
            "*-----", // Navi+20
            "D-----", // LifeAura
            "M-----", // Muramasa
            "O-----", // Guardian
            "A-----", // Anubis
            "*-----", // Atk+30
            "*-----", // Navi+40
            "P-----", // HeroSwrd
            "Z-----", // ZeusHamr
            "S-----", // GodStone
            "W-----", // OldWood
            "*-----", // FullCust
            "R-----", // Meteors
            "G-----", // Poltrgst
            "J-----", // Jealousy
            "P-----", // StandOut
            "C*----", // WatrLine
            "L*----", // Ligtning
            "G*----", // GaiaSwrd
            "R-----", // Roll
            "R-----", // RollV2
            "R-----", // RollV3
            "G-----", // GutsMan
            "G-----", // GutsManV2
            "G-----", // GutsManV3
            "G-----", // GutsManV4
            "G-----", // GutsManV5
            "B-----", // ProtoMan
            "B-----", // ProtoMnV2
            "B-----", // ProtoMnV3
            "B-----", // ProtoMnV4
            "B-----", // ProtoMnV5
            "F-----", // FlashMan
            "F-----", // FlashMnV2
            "F-----", // FlashMnV3
            "F-----", // FlashMnV4
            "F-----", // FlashMnV5
            "B-----", // BeastMan
            "B-----", // BeastMnV2
            "B-----", // BeastMnV3
            "B-----", // BeastMnV4
            "B-----", // BeastMnV5
            "B-----", // BubblMan
            "B-----", // BubblMnV2
            "B-----", // BubblMnV3
            "B-----", // BubblMnV4
            "B-----", // BubblMnV5
            "D-----", // DesrtMan
            "D-----", // DesrtMnV2
            "D-----", // DesrtMnV3
            "D-----", // DesrtMnV4
            "D-----", // DesrtMnV5
            "P-----", // PlantMan
            "P-----", // PlantMnV2
            "P-----", // PlantMnV3
            "P-----", // PlantMnV4
            "P-----", // PlantMnV5
            "F-----", // FlameMan
            "F-----", // FlameMnV2
            "F-----", // FlameMnV3
            "F-----", // FlameMnV4
            "F-----", // FlameMnV5
            "D-----", // DrillMan
            "D-----", // DrillMnV2
            "D-----", // DrillMnV3
            "D-----", // DrillMnV4
            "D-----", // DrillMnV5
            "M-----", // MetalMan
            "M-----", // MetalMnV2
            "M-----", // MetalMnV3
            "M-----", // MetalMnV4
            "M-----", // MetalMnV5
            "P-----", // Punk
            "S*----", // Salamndr
            "D*----", // Fountain
            "T*----", // Bolt
            "G*----", // GaiaBlad
            "K-----", // KingMan
            "K-----", // KingManV2
            "K-----", // KingManV3
            "K-----", // KingManV4
            "K-----", // KingManV5
            "M-----", // MistMan
            "M-----", // MistManV2
            "M-----", // MistManV3
            "M-----", // MistManV4
            "M-----", // MistManV5
            "B-----", // BowlMan
            "B-----", // BowlManV2
            "B-----", // BowlManV3
            "B-----", // BowlManV4
            "B-----", // BowlManV5
            "D-----", // DarkMan
            "D-----", // DarkManV2
            "D-----", // DarkManV3
            "D-----", // DarkManV4
            "D-----", // DarkManV5
            "Y-----", // YamatoMn
            "Y-----", // YamatMnV2
            "Y-----", // YamatMnV3
            "Y-----", // YamatMnV4
            "Y-----", // YamatMnV5
            "Z-----", // DeltaRay
            "*-----", // FoldrBak
            "*-----", // NavRcycl
            "V-----", // AlphArmΣ
            "X-----", // Bass
            "S-----", // Serenade
            "Y-----", // Balance
            "A-----", // DarkAura
            "V-----", // AlphArmΩ
            "X-----", // Bass+
            "X-----", // BassGS
        }; } }
        
        public override Dictionary<int, byte[]> unobtainableCodes { get {
            Dictionary<int, byte[]> def = new Dictionary<int, byte[]>();
            def[10] = new byte[] { 5 }; // ShotGun * (Extra Folder only)
            def[11] = new byte[] { 5 }; // V-Gun * (Extra Folder only)
            def[12] = new byte[] { 5 }; // SideGun * (Extra Folder only)
            def[14] = new byte[] { 5 }; // Bubbler * (Extra Folder only)
            def[15] = new byte[] { 5 }; // Bub-V *
            def[16] = new byte[] { 5 }; // BublSide *
            def[17] = new byte[] { 5 }; // HeatShot * (Extra Folder only)
            def[18] = new byte[] { 5 }; // Heat-V *
            def[19] = new byte[] { 5 }; // HeatSide *
            def[69] = new byte[] { 5 }; // Yo-Yo1 * (Extra Folder only)
            def[133] = new byte[] { 5 }; // MetaGel1 *
            def[41] = new byte[] { 5 }; // Panic *
            def[166] = new byte[] { 0, 2, 3 }; // Mettaur E, M, O
            def[167] = new byte[] { 0, 2, 3 }; // Bunny A, I, L
            def[186] = new byte[] { 0, 3, 4 }; // Spikey A, R, U
            def[185] = new byte[] { 0, 1, 2 };// Swordy D, I, O
            def[188] = new byte[] { 1, 2, 3 };// Jelly J, L, R
            def[187] = new byte[] { 2, 3, 4 };// Mushy M, S, Y
            def[77] = new byte[] { 1, 2, 4 };// Momogra M, O, U
            def[189] = new byte[] { 1, 3, 4 };// KillrEye I, L, R
            def[76] = new byte[] { 1, 2, 4 };// Scuttlst D, E, R
            def[182] = new byte[] { 5 }; // SandStge *
            def[183] = new byte[] { 5 }; // MetlStge *
            return def;
        } }
        
        public override int[] chipSizes { get { return new int[] {
            99, // MegaBstr
            12, // Cannon
            24, // HiCannon
            36, // M-Cannon
            4, // AirShot1
            12, // AirShot2
            18, // AirShot3
            34, // LavaCan1
            42, // LavaCan2
            60, // LavaCan3
            8, // ShotGun
            8, // V-Gun
            8, // SideGun
            16, // Spreader
            14, // Bubbler
            22, // Bub-V
            30, // BublSide
            16, // HeatShot
            24, // Heat-V
            32, // HeatSide
            6, // MiniBomb
            12, // SnglBomb
            24, // DublBomb
            36, // TrplBomb
            33, // CannBall
            18, // IceBall
            20, // LavaBall
            60, // BlkBomb1
            70, // BlkBomb2
            80, // BlkBomb3
            10, // Sword
            16, // WideSwrd
            24, // LongSwrd
            20, // FireSwrd
            25, // AquaSwrd
            23, // ElecSwrd
            18, // BambSwrd
            21, // CustSwrd
            68, // VarSwrd
            43, // StepSwrd
            74, // StepCros
            14, // Panic
            30, // AirSwrd
            12, // Slasher
            10, // ShockWav
            26, // SonicWav
            42, // DynaWave
            14, // GutPunch
            30, // GutStrgt
            50, // GutImpct
            26, // AirStrm1
            35, // AirStrm2
            44, // AirStrm3
            11, // DashAtk
            15, // Burner
            29, // Totem1
            38, // Totem2
            47, // Totem3
            14, // Ratton1
            24, // Ratton2
            34, // Ratton3
            60, // Wave
            72, // RedWave
            84, // MudWave
            16, // Hammer
            18, // Tornado
            8, // ZapRing1
            18, // ZapRing2
            28, // ZapRing3
            72, // Yo-Yo1
            80, // Yo-Yo2
            88, // Yo-Yo3
            22, // Spice1
            34, // Spice2
            46, // Spice3
            46, // Lance
            52, // Scuttlst
            38, // Momogra
            45, // Rope1
            55, // Rope2
            65, // Rope3
            35, // Magnum1
            55, // Magnum2
            75, // Magnum3
            15, // Boomer1
            22, // Boomer2
            30, // Boomer3
            28, // RndmMetr
            48, // HoleMetr
            38, // ShotMetr
            14, // IceWave1
            22, // IceWave2
            30, // IceWave3
            14, // Plasma1
            26, // Plasma2
            34, // Plasma3
            40, // Arrow1
            60, // Arrow2
            80, // Arrow3
            32, // TimeBomb
            16, // Mine
            62, // Sensor1
            70, // Sensor2
            72, // Sensor3
            25, // CrsShld1
            33, // CrsShld2
            41, // CrsShld3
            22, // Geyser
            30, // PoisMask
            38, // PoisFace
            34, // Shake1
            40, // Shake2
            50, // Shake3
            82, // BigWave
            75, // Volcano
            44, // Condor
            42, // Burning
            35, // FireRatn
            5, // Guard
            4, // PanlOut1
            7, // PanlOut3
            5, // Recov10
            8, // Recov30
            14, // Recov50
            20, // Recov80
            35, // Recov120
            50, // Recov150
            65, // Recov200
            80, // Recov300
            10, // PanlGrab
            15, // AreaGrab
            20, // Snake
            16, // Team1
            18, // MetaGel1
            28, // MetaGel2
            38, // MetaGel3
            10, // GrabBack
            30, // GrabRvng
            10, // Geddon1
            50, // Geddon2
            90, // Geddon3
            9, // RockCube
            60, // Prism
            14, // Wind
            14, // Fan
            23, // RockArm1
            35, // RockArm2
            47, // RockArm3
            66, // NoBeam1
            77, // NoBeam2
            88, // NoBeam3
            44, // Pawn
            64, // Knight
            30, // Rook
            32, // Needler1
            52, // Needler2
            72, // Needler3
            20, // SloGauge
            40, // FstGauge
            8, // Repair
            11, // Invis
            55, // Hole
            28, // Mole1
            35, // Mole2
            42, // Mole3
            60, // Shadow
            30, // Mettaur
            32, // Bunny
            26, // AirShoes
            20, // Team2
            32, // Fanfare
            38, // Discord
            42, // Timpani
            7, // Barrier
            25, // Barr100
            50, // Barr200
            55, // Aura
            43, // NrthWind
            14, // HolyPanl
            22, // LavaStge
            20, // IceStage
            10, // GrassStg
            18, // SandStge
            26, // MetlStge
            54, // Snctuary
            30, // Swordy
            34, // Spikey
            38, // Mushy
            46, // Jelly
            50, // KillrEye
            60, // AntiNavi
            45, // AntiDmg
            68, // AntiSwrd
            73, // AntiRecv
            18, // CopyDmg
            4, // Atk+10
            20, // Fire+30
            21, // Aqua+30
            23, // Elec+30
            26, // Wood+30
            34, // Navi+20
            77, // LifeAura
            74, // Muramasa
            82, // Guardian
            90, // Anubis
            50, // Atk+30
            60, // Navi+40
            65, // HeroSwrd
            90, // ZeusHamr
            66, // GodStone
            72, // OldWood
            10, // FullCust
            86, // Meteors
            58, // Poltrgst
            64, // Jealousy
            22, // StandOut
            18, // WatrLine
            30, // Ligtning
            28, // GaiaSwrd
            10, // Roll
            22, // RollV2
            34, // RollV3
            15, // GutsMan
            41, // GutsManV2
            57, // GutsManV3
            63, // GutsManV4
            79, // GutsManV5
            68, // ProtoMan
            76, // ProtoMnV2
            82, // ProtoMnV3
            90, // ProtoMnV4
            98, // ProtoMnV5
            39, // FlashMan
            59, // FlashMnV2
            69, // FlashMnV3
            79, // FlashMnV4
            89, // FlashMnV5
            38, // BeastMan
            60, // BeastMnV2
            68, // BeastMnV3
            76, // BeastMnV4
            84, // BeastMnV5
            50, // BubblMan
            62, // BubblMnV2
            74, // BubblMnV3
            80, // BubblMnV4
            86, // BubblMnV5
            38, // DesrtMan
            52, // DesrtMnV2
            64, // DesrtMnV3
            72, // DesrtMnV4
            80, // DesrtMnV5
            60, // PlantMan
            65, // PlantMnV2
            70, // PlantMnV3
            75, // PlantMnV4
            80, // PlantMnV5
            32, // FlameMan
            52, // FlameMnV2
            62, // FlameMnV3
            72, // FlameMnV4
            82, // FlameMnV5
            66, // DrillMan
            70, // DrillMnV2
            74, // DrillMnV3
            78, // DrillMnV4
            82, // DrillMnV5
            40, // MetalMan
            60, // MetalMnV2
            70, // MetalMnV3
            80, // MetalMnV4
            90, // MetalMnV5
            92, // Punk
            50, // Salamndr
            48, // Fountain
            52, // Bolt
            55, // GaiaBlad
            36, // KingMan
            48, // KingManV2
            60, // KingManV3
            72, // KingManV4
            84, // KingManV5
            68, // MistMan
            71, // MistManV2
            74, // MistManV3
            77, // MistManV4
            80, // MistManV5
            80, // BowlMan
            82, // BowlManV2
            84, // BowlManV3
            86, // BowlManV4
            88, // BowlManV5
            72, // DarkMan
            76, // DarkManV2
            80, // DarkManV3
            84, // DarkManV4
            88, // DarkManV5
            82, // YamatoMn
            85, // YamatMnV2
            88, // YamatMnV3
            91, // YamatMnV4
            94, // YamatMnV5
            92, // DeltaRay
            99, // FoldrBak
            50, // NavRcycl
            97, // AlphArmΣ
            98, // Bass
            97, // Serenade
            60, // Balance
            55, // DarkAura
            97, // AlphArmΩ
            98, // Bass+
            99 // BassGS
        }; } }
        
        public override int[] gameOrderStandardChips { get { return new int[] {
            1, // Cannon
            2, // HiCannon
            3, // M-Cannon
            4, // AirShot1
            5, // AirShot2
            6, // AirShot3
            7, // LavaCan1
            8, // LavaCan2
            9, // LavaCan3
            114, // Volcano
            10, // ShotGun
            11, // V-Gun
            12, // SideGun
            13, // Spreader
            14, // Bubbler
            15, // Bub-V
            16, // BublSide
            17, // HeatShot
            18, // Heat-V
            19, // HeatSide
            20, // MiniBomb
            21, // SnglBomb
            22, // DublBomb
            23, // TrplBomb
            24, // CannBall
            25, // IceBall
            26, // LavaBall
            27, // BlkBomb1
            28, // BlkBomb2
            29, // BlkBomb3
            30, // Sword
            31, // WideSwrd
            32, // LongSwrd
            33, // FireSwrd
            34, // AquaSwrd
            35, // ElecSwrd
            36, // BambSwrd
            37, // CustSwrd
            38, // VarSwrd
            42, // AirSwrd
            39, // StepSwrd
            40, // StepCros
            43, // Slasher
            44, // ShockWav
            45, // SonicWav
            46, // DynaWave
            113, // BigWave
            47, // GutPunch
            48, // GutStrgt
            49, // GutImpct
            53, // DashAtk
            54, // Burner
            115, // Condor
            116, // Burning
            66, // ZapRing1
            67, // ZapRing2
            68, // ZapRing3
            90, // IceWave1
            91, // IceWave2
            92, // IceWave3
            69, // Yo-Yo1
            70, // Yo-Yo2
            71, // Yo-Yo3
            50, // AirStrm1
            51, // AirStrm2
            52, // AirStrm3
            96, // Arrow1
            97, // Arrow2
            98, // Arrow3
            58, // Ratton1
            59, // Ratton2
            60, // Ratton3
            117, // FireRatn
            61, // Wave
            62, // RedWave
            63, // MudWave
            65, // Tornado
            72, // Spice1
            73, // Spice2
            74, // Spice3
            110, // Shake1
            111, // Shake2
            112, // Shake3
            148, // NoBeam1
            149, // NoBeam2
            150, // NoBeam3
            64, // Hammer
            107, // Geyser
            78, // Rope1
            79, // Rope2
            80, // Rope3
            84, // Boomer1
            85, // Boomer2
            86, // Boomer3
            108, // PoisMask
            109, // PoisFace
            145, // RockArm1
            146, // RockArm2
            147, // RockArm3
            104, // CrsShld1
            105, // CrsShld2
            106, // CrsShld3
            81, // Magnum1
            82, // Magnum2
            83, // Magnum3
            93, // Plasma1
            94, // Plasma2
            95, // Plasma3
            87, // RndmMetr
            88, // HoleMetr
            89, // ShotMetr
            154, // Needler1
            155, // Needler2
            156, // Needler3
            55, // Totem1
            56, // Totem2
            57, // Totem3
            101, // Sensor1
            102, // Sensor2
            103, // Sensor3
            133, // MetaGel1
            134, // MetaGel2
            135, // MetaGel3
            151, // Pawn
            152, // Knight
            153, // Rook
            132, // Team1
            169, // Team2
            99, // TimeBomb
            100, // Mine
            75, // Lance
            131, // Snake
            118, // Guard
            119, // PanlOut1
            120, // PanlOut3
            129, // PanlGrab
            130, // AreaGrab
            136, // GrabBack
            137, // GrabRvng
            141, // RockCube
            142, // Prism
            143, // Wind
            144, // Fan
            170, // Fanfare
            171, // Discord
            172, // Timpani
            121, // Recov10
            122, // Recov30
            123, // Recov50
            124, // Recov80
            125, // Recov120
            126, // Recov150
            127, // Recov200
            128, // Recov300
            159, // Repair
            157, // SloGauge
            158, // FstGauge
            41, // Panic
            138, // Geddon1
            139, // Geddon2
            140, // Geddon3
            194, // CopyDmg
            160, // Invis
            165, // Shadow
            162, // Mole1
            163, // Mole2
            164, // Mole3
            168, // AirShoes
            173, // Barrier
            174, // Barr100
            175, // Barr200
            176, // Aura
            177, // NrthWind
            166, // Mettaur
            167, // Bunny
            186, // Spikey
            185, // Swordy
            188, // Jelly
            77, // Momogra
            187, // Mushy
            189, // KillrEye
            76, // Scuttlst
            161, // Hole
            178, // HolyPanl
            179, // LavaStge
            180, // IceStage
            181, // GrassStg
            182, // SandStge
            183, // MetlStge
            184, // Snctuary
            191, // AntiDmg
            192, // AntiSwrd
            190, // AntiNavi
            193, // AntiRecv
            195, // Atk+10
            196, // Fire+30
            197, // Aqua+30
            198, // Elec+30
            199, // Wood+30
            200, // Navi+20
        }; } }
        
        public override int[] gameOrderMegaChipsAll { get { return new int[] {
            202, // Muramasa
            207, // HeroSwrd
            208, // ZeusHamr
            215, // StandOut
            273, // Salamndr
            216, // WatrLine
            274, // Fountain
            217, // Ligtning
            275, // Bolt
            218, // GaiaSwrd
            276, // GaiaBlad
            212, // Meteors
            203, // Guardian
            204, // Anubis
            209, // GodStone
            210, // OldWood
            214, // Jealousy
            213, // Poltrgst
            201, // LifeAura
            211, // FullCust
            205, // Atk+30
            206, // Navi+40
            219, // Roll
            220, // RollV2
            221, // RollV3
            222, // GutsMan
            223, // GutsManV2
            224, // GutsManV3
            225, // GutsManV4
            227, // ProtoMan
            228, // ProtoMnV2
            229, // ProtoMnV3
            230, // ProtoMnV4
            232, // FlashMan
            233, // FlashMnV2
            234, // FlashMnV3
            235, // FlashMnV4
            237, // BeastMan
            238, // BeastMnV2
            239, // BeastMnV3
            240, // BeastMnV4
            242, // BubblMan
            243, // BubblMnV2
            244, // BubblMnV3
            245, // BubblMnV4
            247, // DesrtMan
            248, // DesrtMnV2
            249, // DesrtMnV3
            250, // DesrtMnV4
            252, // PlantMan
            253, // PlantMnV2
            254, // PlantMnV3
            255, // PlantMnV4
            257, // FlameMan
            258, // FlameMnV2
            259, // FlameMnV3
            260, // FlameMnV4
            262, // DrillMan
            263, // DrillMnV2
            264, // DrillMnV3
            265, // DrillMnV4
            267, // MetalMan
            268, // MetalMnV2
            269, // MetalMnV3
            270, // MetalMnV4
            277, // KingMan
            278, // KingManV2
            279, // KingManV3
            280, // KingManV4
            282, // MistMan
            283, // MistManV2
            284, // MistManV3
            285, // MistManV4
            287, // BowlMan
            288, // BowlManV2
            289, // BowlManV3
            290, // BowlManV4
            292, // DarkMan
            293, // DarkManV2
            294, // DarkManV3
            295, // DarkManV4
            297, // YamatoMn
            298, // YamatMnV2
            299, // YamatMnV3
            300, // YamatMnV4
            272, // Punk [unregistered]
        }; } }
        
        public override int[] gameOrderGigaChipsMain { get { return new int[] {
            303, // FoldrBak
            311, // Bass+
            309, // DarkAura
            302, // DeltaRay
            310, // AlphArmΩ
            226, // GutsManV5
            231, // ProtoMnV5
            236, // FlashMnV5
            241, // BeastMnV5
            246, // BubblMnV5
            251, // DesrtMnV5
            256, // PlantMnV5
            261, // FlameMnV5
            266, // DrillMnV5
            271, // MetalMnV5
            281, // KingManV5
            286, // MistManV5
            291, // BowlManV5
            296, // DarkManV5
            301, // YamatMnV5
            312, // BassGS [replaces GigaChip #2]
        }; } }
        
        public override int[] gameOrderGigaChipsSub { get { return new int[] {
            304, // NavRcycl
            306, // Bass
            307, // Serenade
            308, // Balance
            305, // AlphArmΣ
            226, // GutsManV5
            231, // ProtoMnV5
            236, // FlashMnV5
            241, // BeastMnV5
            246, // BubblMnV5
            251, // DesrtMnV5
            256, // PlantMnV5
            261, // FlameMnV5
            266, // DrillMnV5
            271, // MetalMnV5
            281, // KingManV5
            286, // MistManV5
            291, // BowlManV5
            296, // DarkManV5
            301, // YamatMnV5
            312, // BassGS [replaces GigaChip #2]
        }; } }
        
        public override int[] gameOrderGigaChipsAll { get { return new int[] {
            304, // NavRcycl [White]
            306, // Bass [White]
            307, // Serenade [White]
            308, // Balance [White]
            310, // AlphArmΩ [White]
            303, // FoldrBak [Blue]
            311, // Bass+ [Blue]
            309, // DarkAura [Blue]
            302, // DeltaRay [Blue]
            305, // AlphArmΣ [Blue]
            226, // GutsManV5
            231, // ProtoMnV5
            236, // FlashMnV5
            241, // BeastMnV5
            246, // BubblMnV5
            251, // DesrtMnV5
            256, // PlantMnV5
            261, // FlameMnV5
            266, // DrillMnV5
            271, // MetalMnV5
            281, // KingManV5
            286, // MistManV5
            291, // BowlManV5
            296, // DarkManV5
            301, // YamatMnV5
            312, // BassGS [replaces GigaChip #2]
        }; } }
        
        public override int[] gameOrderPAs { get { return new int[] {
            0, // Z-Canon1
            1, // Z-Canon2
            2, // Z-Canon3
            3, // Z-Punch
            4, // Z-Strght
            5, // Z-Impact
            6, // Z-Varibl
            7, // Z-Yoyo1
            8, // Z-Yoyo2
            9, // Z-Yoyo3
            10, // Z-Step1
            11, // Z-Step2
            14, // BubSprd
            15, // HeatSprd
            13, // H-Burst
            16, // LifeSwrd
            17, // ElemSwrd
            18, // EvilCut
            20, // HyperRat
            12, // TimeBom+
            22, // GelRain
            21, // EverCrse
            29, // MomQuake
            23, // PoisPhar
            24, // BodyGrd
            25, // 500Barr
            26, // BigHeart
            27, // GtsShoot
            28, // DeuxHero
            19, // 2xHero
            30, // PrixPowr
            31, // MstrStyl
        }; } }
        
        public override string[] keyItemNames { get { return new string[] {
            "PET", "O data", "X data", "Parasol", "KeydataA", "KeydataB", "KeydataC", "PasswrdA", "PasswrdB", "PasswrdC",
            "SubPET", "Bag", "OrderSys", "PresData", "Needle", "DataDisk", "PET Case", "HadesKey", "VictData", "InsrData",
            "MapScrap", "Tally", "Tea", "BsmntKey", "FireData", "HeatData", "FlamData", "Rank 10", "Rank 9", "Rank 8",
            "Rank 7", "Rank 3", "Rank 2", "Origami", "GigFreez", "OfclPass", "DadsNote", "CardKey", "Aspirin", "ID-DataA",
            "ID-DataB", "ID-DataC", "ID-DataD", "GramNote", "OldTools", "CashData", "Old Doll", "WWW-ID", "SkyTome", "LandTome",
            "SeaTome", "StmpCard", "Will", "Photo", "Camera", "ModTools", "Hammer", "WrstBand", "Rank 1", "",
            "", "", "", "", "", "", "", "", "", "",
            "", "SpinWhit", "SpinPink", "SpinYllw", "SpinRed", "SpinBlue", "SpinGrn", "SpinOrng", "SpinPrpl", "SpinDark",
            "MaylCode", "DexCode", "YaiCode", "TamaCode", "HospCode", "", "", "", "ACDCPass", "SciPass",
            "YokaPass", "BeachPas", "CACDCPas", "CSciPass", "CYokaPas", "CBeacPas", "HPMemory", "ExpMemry", "RegUP1", "RegUP2",
            "RegUP3", "SubMem", "", "", "", "", "", "", "", "",
            "", "", "MiniEnrg", "FullEnrg", "SneakRun", "Untrap", "LocEnemy", "Unlocker", "", "",
            "", "", "", "", "", "", "", ""
        }; } } // Includes upgrade items and SubChips for things that use IDs relative to start of key items
        
        public override string[] upgradeItemNames { get { return new string[] {
            "HPMemory", "ExpMemry", "RegUP1", "RegUP2", "RegUP3", "SubMem"
        }; } }
        
        public override int[][] upgradeItemFlags { get {
            int[][] flags = new int[upgradeItemNames.Length][];
            // HPMemory
            flags[0] = new int[] { 381, 3465, 3600, 3616, 3633, 3722, 3791, 3841, 3913, 3937,
                                   3971, 3993, 4169, 4245, 4280, 4292, 4318, 4323, 4326, 5761,
                                   5767, 5769, 5781 };
            // ExpMemry
            flags[1] = new int[] { -4493 /* "Good luck!!" email from Dad */, 5777 };
            // RegUP1
            flags[2] = new int[] { 3782, 3905, 4228, 4257, 4276, 4296, 4320, 4322, 4324, 4327 };
            // RegUP2
            flags[3] = new int[] { 3400, 3592, 3865, 3977, 4185, 4232, 4268, 4281, 4321, 4325, 4328, 4329 };
            // RegUP3
            flags[4] = new int[] { 380, 3529, 5760, 5765 };
            // SubMem
            flags[5] = new int[] { 3624, 3922, 4288, 5774 };
            return flags;
        } }
        
        public override Dictionary<int, int[]> shopHPMemoryPrices { get {
            Dictionary<int, int[]> def = new Dictionary<int, int[]>();
            def[0] = new int[] { 10, 30 }; // ACDC Area 2
            def[1] = new int[] { 20, 50 }; // ACDC Square
            def[3] = new int[] { 20, 40, 80 }; // SciLab Square
            def[5] = new int[] { 40, 80, 120 }; // Yoka Square
            def[8] = new int[] { 50, 90, 130 }; // Beach Square
            def[11] = new int[] { 80, 120, 160 }; // Undernet 4
            def[13] = new int[] { 120, 160, 200 }; // Under Square
            def[15] = new int[] { 200, 300, 400 }; // Secret Area 2
            return def;
        } }
        
        public override int[][] libraryFlagRanges { get { return new int[][] {
            null, null, new int[] { 2816, 3135 }, new int[] { 3136, 3183 } // Chips are separate, PAs are seperate, shared chips, shared PAs
        }; } }
        
        public override string[] subchipNames { get { return new string[] {
            "MiniEnrg", "FullEnrg", "SneakRun", "Untrap", "LocEnemy", "Unlocker"
        }; } }
        
        public override string[] presetFolderNames { get { return new string[] {
            "Fldr1", "Fldr2", "PreFoldr", "HdesFldr", "N1-FldrA", "N1-FldrB", "N1-FldrC", "N1-FldrD", "FamFoldr", "ApprFldr", "XtraFldr"
        }; } }
        
        public override Dictionary<string, string[]> presetFolders { get {
            Dictionary<string, string[]> def = new Dictionary<string, string[]>();
            def["Fldr1"] = new string[] {
                "Cannon A", "Cannon A", "Cannon B", "Cannon B", "ShotGun J", "ShotGun J", "ShotGun J", "V-Gun D", "V-Gun D", "V-Gun D",
                "SideGun S", "AirShot1 *", "AirShot1 *", "AirShot1 *", "MiniBomb B", "MiniBomb B", "MiniBomb S", "Sword L", "Sword L", "Sword L",
                "WideSwrd L", "PanlOut1 B", "PanlOut1 B", "AreaGrab L", "Recov10 A", "Recov10 A", "Recov10 L", "Recov10 L", "Atk+10 *", "Atk+10 *"
            };
            def["Fldr2"] = new string[] {
                "Ratton1 H", "Ratton1 H", "Ratton1 H", "Ratton1 H", "ZapRing1 S", "ZapRing1 S", "ZapRing1 S", "ZapRing2 W", "ZapRing2 W", "ZapRing2 W",
                "IceWave1 W", "IceWave1 W", "IceWave1 W", "IceWave1 W", "MiniBomb *", "MiniBomb *", "MiniBomb *", "WideSwrd E", "CustSwrd V", "Slasher D",
                "Pawn E", "Knight U", "Rook Q", "AreaGrab L", "Recov50 *", "Recov50 *", "Recov50 *", "Recov50 *", "Atk+10 *", "Atk+10 *"
            };
            def["XtraFldr"] = new string[] {
                "Cannon A", "Cannon A", "Cannon A", "Cannon A", "ShotGun J", "ShotGun J", "ShotGun J", "ShotGun J", "V-Gun D", "V-Gun D",
                "V-Gun D", "V-Gun D", "SideGun S", "SideGun S", "SideGun S", "SideGun S", "AirShot1 *", "AirShot1 *", "AirShot1 *", "AirShot1 *",
                "MiniBomb B", "MiniBomb B", "MiniBomb B", "MiniBomb B", "Sword L", "Sword L", "Sword L", "Sword L", "WideSwrd L", "AreaGrab L"
            };
            def["PreFoldr"] = new string[] {
                "Ratton1 A", "Ratton1 A", "Ratton1 F", "Ratton1 F", "ShotGun F", "ShotGun F", "ShotGun *", "V-Gun G", "V-Gun G", "V-Gun *",
                "SideGun Y", "SideGun Y", "SideGun *", "Spreader M", "Spreader N", "Spreader O", "DashAtk G", "Lance H", "PanlGrab Y", "PanlGrab Y",
                "Guard *", "Guard *", "Guard *", "Guard *", "Sword Y", "WideSwrd Y", "LongSwrd Y", "Atk+10 *", "Atk+10 *", "Atk+10 *"
            };
            def["HdesFldr"] = new string[] {
                "Bubbler A", "Bubbler A", "HeatShot B", "HeatShot B", "SnglBomb D", "SnglBomb D", "SnglBomb D", "CannBall D", "CannBall D", "CannBall D",
                "Burner S", "Burner S", "Burner S", "Burner S", "Boomer1 H", "Boomer1 H", "Boomer1 H", "Boomer1 H", "WideSwrd Q", "LongSwrd E",
                "FireSwrd F", "AquaSwrd N", "ElecSwrd V", "BambSwrd W", "Recov80 D", "Recov80 D", "Atk+10 *", "Roll R", "GutsMan G", "GutsManV2 G"
            };
            def["N1-FldrA"] = new string[] {
                "HiCannon H", "HiCannon H", "HiCannon I", "HiCannon J", "SonicWav G", "SonicWav G", "SonicWav G", "ZapRing1 A", "ZapRing1 A", "ZapRing1 *",
                "Lance Z", "Boomer1 H", "Burner F", "Invis *", "Invis *", "Sword Y", "WideSwrd Y", "LongSwrd Y", "LongSwrd L", "LongSwrd R",
                "FireSwrd F", "AquaSwrd A", "ElecSwrd E", "BambSwrd W", "VarSwrd C", "AreaGrab *", "AreaGrab *", "Roll R", "FlashMan F", "BeastMan B"
            };
            def["N1-FldrB"] = new string[] {
                "Cannon A", "Cannon B", "Cannon B", "Cannon C", "AirShot1 *", "AirShot1 *", "AirShot1 *", "AirShot1 *", "Bubbler *", "Bubbler *",
                "Bubbler *", "Bubbler *", "HeatShot *", "HeatShot *", "HeatShot *", "HeatShot *", "ZapRing1 A", "ZapRing1 M", "ZapRing1 P", "ZapRing1 *",
                "Yo-Yo1 C", "Yo-Yo1 E", "Yo-Yo1 G", "Yo-Yo1 *", "Recov30 F", "Recov30 H", "Recov30 M", "Recov80 D", "Roll R", "GutsMan G"
            };
            def["N1-FldrC"] = new string[] {
                "MiniBomb *", "MiniBomb *", "SnglBomb H", "SnglBomb H", "SnglBomb H", "SnglBomb H", "CannBall P", "CannBall P", "CannBall P", "CannBall P",
                "Hammer T", "Hammer T", "PanlOut3 *", "PanlOut3 *", "PanlOut3 *", "PanlOut3 *", "Recov10 *", "Recov30 *", "Recov50 *", "Recov80 *",
                "PanlGrab *", "PanlGrab *", "AreaGrab E", "AreaGrab E", "Repair *", "Snake I", "Snake I", "Snake I", "Atk+10 *", "Wood+30 *"
            };
            def["N1-FldrD"] = new string[] {
                "Sword Y", "Sword Y", "Sword Y", "Sword Y", "WideSwrd L", "WideSwrd L", "WideSwrd L", "WideSwrd L", "PanlGrab *", "PanlGrab *",
                "AreaGrab *", "SnglBomb T", "CannBall P", "AirSword R", "ShockWav D", "GutPunch C", "DashAtk Z", "Burner Q", "Ratton1 A", "Hammer G",
                "ZapRing1 M", "Yo-Yo1 F", "Lance H", "Boomer1 J", "Plasma1 B", "Wind *", "Fan *", "Atk+10 *", "FlashMan F", "BubblMan B"
            };
            def["FamFoldr"] = new string[] {
                "ZapRing1 A", "ZapRing1 A", "MetaGel1 C", "MetaGel1 C", "MetaGel1 C", "Boomer1 F", "Boomer1 F", "Boomer1 F", "Tornado T", "Tornado T",
                "Spice1 S", "Spice1 S", "Spice1 S", "Plasma1 J", "Plasma1 J", "Plasma1 J", "Burner Q", "LavaStge T", "IceStage G", "GrassStg *",
                "SandStge B", "Fire+30 *", "Aqua+30 *", "Elec+30 *", "Wood+30 *", "FlashMan F", "BubblMan B", "BeastMan B", "FlameMan F", "PlantMan P"
            };
            def["ApprFldr"] = new string[] {
                "AirShot1 *", "AirShot1 *", "AirShot1 *", "AirShot1 *", "GutPunch D", "GutPunch D", "GutPunch D", "GutPunch D", "Bubbler E", "Bub-V E",
                "BublSide E", "HeatShot J", "Heat-V J", "HeatSide J", "RndmMetr S", "RndmMetr S", "RndmMetr S", "Plasma1 J", "Plasma1 J", "Plasma1 J",
                "TimeBomb K", "Mine D", "RockCube *", "RockCube *", "RockCube *", "Prism K", "Prism W", "MetalMan M", "MetalManV2 M", "MetalManV3 M"
            };
            return def;
        } }
        
        public override string[] programNames { get { return new string[] {
            "NONE", "SprArmor", "BrakBust", "BrakChrg", // 1A80
            "SetGreen", "SetIce", "SetLava", "SetSand", // 1A90
            "SetMetal", "SetHoly", "Custom1", "Custom2", // 1AA0
            "MegFldr1", "MegFldr2", "Block", "Shield", // 1AB0
            "Reflect", "ShdwShoe", "FlotShoe", "AntiDmg", // 1AC0
            "Press", "EngyChng", "Alpha", "SneakRun", // 1AD0
            "OilBody", "Fish", "Battery", "Jungle", // 1AE0
            "Collect", "AirShoes", "UnderSht", "FstGauge", // 1AF0
            "Rush", "Beat", "Tango", "WeapLV+1", // 1B00
            "HP+100", "HP+200", "HP+300", "HP+500", // 1B10
            "Reg+5", "Atk+1", "Speed+1", "Charge+1", // 1B20
            "BugStop", "Humor", "DarkMind", "BustrMAX", // 1B30
            "GigFldr1", "HubBatc", "DarkLcns" // 1B40
        }; } }
        
        public override string[] programColors { get { return new string[] {
            "----", "---R", "---R", "O--R", // 1A80
            "---G", "---G", "---G", "---G", // 1A90
            "---G", "---G", "--YB", "---B", // 1AA0
            "-P-G", "---G", "---B", "---B", // 1AB0
            "---B", "---R", "---R", "---R", // 1AC0
            "W---", "W---", "-P--", "--Y-", // 1AD0
            "---Y", "-P--", "---Y", "W---", // 1AE0
            "-P--", "W---", "W---", "-P--", // 1AF0
            "--Y-", "W---", "-P--", "WPY-", // 1B00
            "WPY-", "WPY-", "WPY-", "WPY-", // 1B10
            "WPY-", "WPY-", "WPY-", "WPY-", // 1B20
            "W---", "-P--", "W---", "-P--", // 1B30
            "U---", "O---", "D---" // 1B40; U = purple, D = dark (gray)
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
            
            def[0x01] = new object[] { "superArmor", "SuprArmor", 0x01 };
            def[0x02] = new object[] { "shadowType", "Shadow Program", 0x00, "None", 0x01, "ShdwShoe", 0x02, "FlotShoe" };
            def[0x03] = new object[] { "airShoes", "AirShoes", 0x01 };
            def[0x04] = new object[] { "underShirt", "UnderSht", 0x01 };
            def[0x06] = new object[] { "breakBuster", "BrakBust", 0x01 };
            def[0x07] = new object[] { "humor", "Humor", 0x01 };
            def[0x08] = new object[] { "attackPlus", "Attack +" };
            def[0x09] = new object[] { "speedPlus", "Speed +" };
            def[0x0A] = new object[] { "chargePlus", "Charge +" };
            def[0x0D] = new object[] { "weaponLevel", "Weapon Lv", ">1" };
            def[0x0E] = new object[] { "breakCharge", "BrakChrg", 0x01 };
            def[0x0F] = new object[] { "shieldType", "Shield Program", 0x00, "None", 0x02, "Block", 0x04, "Shield", 0x06, "Reflect", 0x08, "AntiDmg" };
            def[0x11] = new object[] { "bugEffect", "Bug Effect" };
            def[0x12] = new object[] { "regularPlus", "Regular Memory +" };
            def[0x13] = new object[] { "startingChips", "Starting Chip Slots", "" }; // Already displayed elsewhere, has non-zero value even without programs
            def[0x14] = new object[] { "megaChipLimit", "MegaChip Folder Limit", "" }; // Same as above
            def[0x15] = new object[] { "gigaChipLimit", "GigaChip Folder Limit", "" }; // Same as above
            def[0x17] = new object[] { "groundType", "Ground Program", "%10", 0x00, "None", 0x05, "SetMetal", 0x06, "SetGreen", 0x07, "SetIce", 0x08, "SetLava", 0x09, "SetHoly", 0x0A, "SetSand" };
            def[0x18] = new object[] { "fastGauge", "FstGauge", 0x01 };
            def[0x1A] = new object[] { "sneakRun", "SneakRun", 0x01 };
            def[0x1B] = new object[] { "attractType", "Attract Program", 0xFF, "None", 0x01, "Battery", 0x02, "OilBody", 0x03, "Fish", 0x04, "Jungle" };
            def[0x1C] = new object[] { "supportType", "Support Program", 0x00, "None", 0x01, "Rush", 0x02, "Beat", 0x03, "Tango" };
            def[0x1D] = new object[] { "rewardType", "Rewards Program", 0x00, "None", 0x01, "Zenny only", 0x02, "Collect" };
            def[0x1E] = new object[] { "busterMax", "BustrMAX", "", 0x01 }; // Seems to do nothing on its own, so no point in showing
            def[0x20] = new object[] { "darkLicense", "DarkLcns", 0x01 };
            def[0x21] = new object[] { "darkMind", "DarkMind", 0x01 };
            def[0x23] = new object[] { "bugStop", "BugStop", 0x01 };
            def[0x24] = new object[] { "energyChange", "EngyChng", 0x01 };
            def[0x25] = new object[] { "alpha", "Alpha", 0x01 };
            def[0x26] = new object[] { "activeStyle", "Current Style Equipped", "", 0x01, "Normal", 0x02, "Registered style" }; // Not really program-related
            def[0x28] = new object[] { "press", "Press", 0x01 };
            def[0x2C] = new object[] { "totalHP", "HP+", "addedHP" };
            def[0x2D] = new object[] { "totalHPByte2", "HP+", "" }; // Don't show again for second byte
            return def;
        } }
        
        public override string[] numberTraderCodes { get { return new string[] {
            "MiniEnrg (86508964)",
            "MinEnrg (57789423)",
            "FullEnrg (56892168)",
            "FullEnrg (99826471)",
            "SneakRun (24586483)",
            "Untrap (46823480)",
            "Untrap (05088930)",
            "LocEnemy (87824510)",
            "LocEnemy (09234782)",
            "Unlocker (35331089)",
            "HiCannon * (21247895)",
            "Spreader * (31549798)",
            "Salamndr * (65497812)",
            "Fountain * (88543997)",
            "Bolt * (54390805)",
            "GaiaBlad * (33157825)",
            "CopyDmg * (01697824)",
            "VarSwrd F (63997824)",
            "StepCros S (76889120)",
            "AirShot3 * (15789208)",
            "GutStrgt S (95913876)",
            "SetSand (19878934)",
            "WeapLV+1 (41465278)",
            "AirShoes (23415891)",
            "FstGauge (67918452)",
            "SpinRed (72563938)",
            "SpinBlue (11002540)",
            "SpinGrn (28274283)",
            "SpinWhit (77955025)",
            "HeroSwrd P (03284579)",
            "Muramasa M (50098263)",
            "WrstBand (90690648)"
        }; } }
        
        public override string[] bbsNames { get { return new string[] {
            "Job BBS", "ACDC Chat BBS", "ACDC Battle BBS", "SciLab Battle BBS", "Yoka Chat BBS", "Beach Chat BBS", "Under BBS"
        }; } }
        
        public override string[] styleTypes { get { return new string[] {
            "Guts", "Custom", "Team", "Shield", "Ground", "Shadow", "Bug"
        }; } }
        
        public override string[] timeTrialNames { get { return new string[] {
            "FlashMan", "BeastMan", "BubbleMan", "DesertMan", "PlantMan", "FlameMan", "DrillMan",
            "GutsMan", "MetalMan", "KingMan", "MistMan/BowlMan", "DarkMan", "YamatoMan", "ProtoMan"
        }; } }
        
        public override object[] safeLocationLansRoom { get { return new object[] { 0x00, 0x03, 0, 48, 0, 0x01 }; } }
        public override object[] startLocationForFreshSave { get { return new object[] { 0x02, 0x02, -30, 42, 0, 0x01 }; } } // Center of Virus Lab
        public override object[] uninitializedJackInLocation { get { return new object[] { 0x02, 0x02, 0, 0, 0, 0x01 }; } } // Center of Virus Lab
        
        public override int[] getGameStartFlags(char version = 'M')
        {
            List<int> flags = new List<int>();
            
            bool blue = version == 'M';
            
            flags.Add(135);
            flags.Add(140);
            flags.Add(250);
            flags.Add(340);
            flags.Add(399);
            flags.Add(769); // First cutscene ended
            flags.Add(2778);
            for (int i = 2780; i <= 2783; i++)
                flags.Add(i);
            flags.Add(4608);
            flags.Add(4642);
            for (int i = 4655; i <= 4657; i++)
                flags.Add(i);
            flags.Add(4691); // PET menu open
            flags.Add(4694); // Enable movement
            flags.Add(4701); // Have MegaMan with you
            if (blue)
                flags.Add(4702); // Blue version flag
            flags.Add(4720);
            for (int i = 4801; i <= 4804; i++)
                flags.Add(i);
            for (int i = 4864; i <= 4865; i++)
                flags.Add(i);
            for (int i = 5313; i <= 5316; i++)
                flags.Add(i);
            for (int i = 5376; i <= 5377; i++)
                flags.Add(i);
            
            return flags.ToArray();
        }
        
        public override ShopItem[][] getInitialShopInventories(char version = 'M')
        {
            ShopItem[][] shops = new ShopItem[22][];
            
            bool blue = version == 'M';
            
            // Shops that differ between versions.
            if (blue)
            {
                shops[0] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 10, 1), new ShopItem(0x01, 0x60, 0xFF, 30, 1),
                    new ShopItem(0x02, 0x0E, 0x04, 6, 3), new ShopItem(0x02, 0x7A, 0x05, 8, 3),
                    new ShopItem(0x02, 0x82, 0x1A, 12, 1), new ShopItem(0x02, 0x35, 0x02, 14, 1),
                    new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[1] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 20, 1), new ShopItem(0x01, 0x60, 0xFF, 50, 1),
                    new ShopItem(0x02, 0xA0, 0x1A, 6, 3), new ShopItem(0x02, 0xB7, 0x03, 30, 3),
                    new ShopItem(0x02, 0x23, 0x0D, 38, 1), new ShopItem(0x02, 0x25, 0x01, 50, 1),
                    new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[3] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 20, 1), new ShopItem(0x01, 0x60, 0xFF, 40, 1),
                    new ShopItem(0x01, 0x60, 0xFF, 80, 1), new ShopItem(0x02, 0xA2, 0x1A, 10, 3),
                    new ShopItem(0x02, 0x41, 0x02, 30, 3), new ShopItem(0x02, 0xBF, 0x0C, 38, 1),
                    new ShopItem(0x02, 0x63, 0x0A, 52, 1), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[4] = new ShopItem[] {
                    new ShopItem(0x02, 0xB3, 0x00, 35, 1), new ShopItem(0x02, 0x30, 0x0F, 50, 1),
                    new ShopItem(0x02, 0x1D, 0x06, 90, 1), new ShopItem(0x02, 0x26, 0x02, 90, 1),
                    new ShopItem(0x02, 0x28, 0x13, 95, 1), new ShopItem(0x02, 0x31, 0x08, 100, 1),
                    new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[5] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 40, 1), new ShopItem(0x01, 0x60, 0xFF, 80, 1),
                    new ShopItem(0x01, 0x60, 0xFF, 120, 1), new ShopItem(0x02, 0x9A, 0x09, 32, 1),
                    new ShopItem(0x02, 0x24, 0x0F, 35, 1), new ShopItem(0x02, 0x4B, 0x19, 40, 1),
                    new ShopItem(0x02, 0x6E, 0x11, 50, 1), new ShopItem(0x02, 0x27, 0x0F, 64, 1)
                };
                shops[8] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 50, 1), new ShopItem(0x01, 0x60, 0xFF, 90, 1),
                    new ShopItem(0x01, 0x60, 0xFF, 130, 1), new ShopItem(0x02, 0xB5, 0x11, 10, 3),
                    new ShopItem(0x02, 0x63, 0x09, 40, 1), new ShopItem(0x02, 0xAF, 0x11, 60, 1),
                    new ShopItem(0x02, 0x26, 0x03, 100, 1), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[10] = new ShopItem[] {
                    new ShopItem(0x02, 0xC6, 0x1A, 15, 1), new ShopItem(0x02, 0xC7, 0x1A, 15, 1),
                    new ShopItem(0x02, 0xD3, 0x1A, 30, 1), new ShopItem(0x02, 0xD1, 0x12, 80, 1),
                    new ShopItem(0x02, 0xD4, 0x11, 150, 1), new ShopItem(0x02, 0x12F, 0x1A, 200, 1),
                    new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[11] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 80, 1), new ShopItem(0x01, 0x60, 0xFF, 120, 1),
                    new ShopItem(0x01, 0x60, 0xFF, 160, 1), new ShopItem(0x02, 0x6A, 0x0D, 75, 1),
                    new ShopItem(0x02, 0x75, 0x01, 90, 1), new ShopItem(0x02, 0x7E, 0x1A, 120, 1),
                    new ShopItem(0x02, 0x28, 0x0F, 130, 1), new ShopItem(0x02, 0xCD, 0x1A, 140, 1)
                };
                shops[13] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 120, 1), new ShopItem(0x01, 0x60, 0xFF, 160, 1),
                    new ShopItem(0x01, 0x60, 0xFF, 200, 1), new ShopItem(0x02, 0x63, 0x0B, 40, 1),
                    new ShopItem(0x02, 0x2A, 0x1A, 60, 1), new ShopItem(0x02, 0xC8, 0x1A, 75, 1),
                    new ShopItem(0x02, 0xD2, 0x16, 150, 1), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[15] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 200, 1), new ShopItem(0x01, 0x60, 0xFF, 300, 1),
                    new ShopItem(0x01, 0x60, 0xFF, 400, 1), new ShopItem(0x02, 0x34, 0x08, 90, 3),
                    new ShopItem(0x02, 0x71, 0x09, 110, 1), new ShopItem(0x02, 0xB1, 0x02, 120, 1),
                    new ShopItem(0x02, 0x31, 0x06, 120, 1), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[18] = new ShopItem[] {
                    new ShopItem(0x02, 0x7C, 0x1A, 50, 1), new ShopItem(0x02, 0x3E, 0x09, 75, 1),
                    new ShopItem(0x02, 0xD7, 0x1A, 60, 1), new ShopItem(0x02, 0xD8, 0x1A, 60, 1),
                    new ShopItem(0x02, 0xD9, 0x1A, 60, 1), new ShopItem(0x02, 0xDA, 0x1A, 60, 1),
                    new ShopItem(0x02, 0x64, 0x11, 100, 3), new ShopItem(0x02, 0xCC, 0x00, 800, 1)
                };
            }
            else
            {
                shops[0] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 10, 1), new ShopItem(0x01, 0x60, 0xFF, 30, 1),
                    new ShopItem(0x02, 0x0B, 0x0B, 2, 3), new ShopItem(0x02, 0xAD, 0x0B, 5, 3),
                    new ShopItem(0x02, 0x79, 0x1A, 5, 3), new ShopItem(0x02, 0x11, 0x01, 8, 3),
                    new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[1] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 20, 1), new ShopItem(0x01, 0x60, 0xFF, 50, 1),
                    new ShopItem(0x02, 0xC3, 0x1A, 3, 3), new ShopItem(0x02, 0x81, 0x0B, 6, 3),
                    new ShopItem(0x02, 0xB5, 0x1A, 10, 3), new ShopItem(0x02, 0x24, 0x0F, 50, 1),
                    new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[3] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 20, 1), new ShopItem(0x01, 0x60, 0xFF, 40, 1),
                    new ShopItem(0x01, 0x60, 0xFF, 80, 1), new ShopItem(0x02, 0x8D, 0x1A, 5, 3),
                    new ShopItem(0x02, 0x01, 0x02, 8, 3), new ShopItem(0x02, 0x8F, 0x00, 10, 3),
                    new ShopItem(0x02, 0x27, 0x0F, 70, 1), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[4] = new ShopItem[] {
                    new ShopItem(0x02, 0x05, 0x1A, 20, 1), new ShopItem(0x02, 0xC7, 0x1A, 40, 1),
                    new ShopItem(0x02, 0xAE, 0x1A, 50, 1), new ShopItem(0x02, 0x63, 0x0A, 60, 1),
                    new ShopItem(0x02, 0xB3, 0x1A, 80, 1), new ShopItem(0x02, 0x64, 0x00, 100, 3),
                    new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[5] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 40, 1), new ShopItem(0x01, 0x60, 0xFF, 80, 1),
                    new ShopItem(0x01, 0x60, 0xFF, 120, 1), new ShopItem(0x02, 0x82, 0x1A, 16, 3),
                    new ShopItem(0x02, 0x16, 0x07, 20, 3), new ShopItem(0x02, 0x45, 0x06, 30, 3),
                    new ShopItem(0x02, 0x23, 0x0D, 50, 1), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[8] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 50, 1), new ShopItem(0x01, 0x60, 0xFF, 90, 1),
                    new ShopItem(0x01, 0x60, 0xFF, 130, 1), new ShopItem(0x02, 0xB7, 0x12, 28, 1),
                    new ShopItem(0x02, 0x63, 0x0B, 40, 1), new ShopItem(0x02, 0x25, 0x01, 50, 1),
                    new ShopItem(0x02, 0xD1, 0x12, 80, 1), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[10] = new ShopItem[] {
                    new ShopItem(0x02, 0x40, 0x1A, 20, 1), new ShopItem(0x02, 0x30, 0x0F, 40, 1),
                    new ShopItem(0x02, 0xC8, 0x1A, 40, 1), new ShopItem(0x02, 0x28, 0x0F, 90, 1),
                    new ShopItem(0x02, 0xCC, 0x00, 150, 1), new ShopItem(0x02, 0x130, 0x1A, 200, 1),
                    new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[11] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 80, 1), new ShopItem(0x01, 0x60, 0xFF, 120, 1),
                    new ShopItem(0x01, 0x60, 0xFF, 160, 1), new ShopItem(0x02, 0x97, 0x0D, 50, 3),
                    new ShopItem(0x02, 0xBF, 0x0C, 50, 1), new ShopItem(0x02, 0x7F, 0x16, 100, 1),
                    new ShopItem(0x02, 0x26, 0x03, 100, 1), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[13] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 120, 1), new ShopItem(0x01, 0x60, 0xFF, 160, 1),
                    new ShopItem(0x01, 0x60, 0xFF, 200, 1), new ShopItem(0x02, 0x26, 0x04, 80, 1),
                    new ShopItem(0x02, 0x98, 0x15, 100, 1), new ShopItem(0x02, 0xB1, 0x19, 130, 1),
                    new ShopItem(0x02, 0xD3, 0x1A, 50, 1), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[15] = new ShopItem[] {
                    new ShopItem(0x01, 0x60, 0xFF, 200, 1), new ShopItem(0x01, 0x60, 0xFF, 300, 1),
                    new ShopItem(0x01, 0x60, 0xFF, 400, 1), new ShopItem(0x02, 0x1D, 0x0B, 100, 1),
                    new ShopItem(0x02, 0x31, 0x08, 130, 1), new ShopItem(0x02, 0xCD, 0x1A, 150, 1),
                    new ShopItem(0x02, 0xD4, 0x11, 300, 1), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
                shops[18] = new ShopItem[] {
                    new ShopItem(0x02, 0xC6, 0x1A, 50, 1), new ShopItem(0x02, 0x63, 0x0C, 60, 1),
                    new ShopItem(0x02, 0xD7, 0x1A, 60, 1), new ShopItem(0x02, 0xD8, 0x1A, 60, 1),
                    new ShopItem(0x02, 0xD9, 0x1A, 60, 1), new ShopItem(0x02, 0xDA, 0x1A, 60, 1),
                    new ShopItem(0x02, 0x2A, 0x11, 140, 1), new ShopItem(0x02, 0xD2, 0x16, 400, 1)
                };
            }
            
            // Shops that are the same in both versions.
            shops[2] = new ShopItem[] {
                new ShopItem(0x01, 0x70, 0xFF, 1, 255), new ShopItem(0x01, 0x71, 0xFF, 10, 255),
                new ShopItem(0x01, 0x72, 0xFF, 2, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[6] = new ShopItem[] {
                new ShopItem(0x01, 0x70, 0xFF, 1, 255), new ShopItem(0x01, 0x71, 0xFF, 10, 255),
                new ShopItem(0x01, 0x75, 0xFF, 40, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[7] = new ShopItem[] {
                new ShopItem(0x01, 0x71, 0xFF, 10, 255), new ShopItem(0x01, 0x72, 0xFF, 2, 255),
                new ShopItem(0x01, 0x73, 0xFF, 1, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[9] = new ShopItem[] {
                new ShopItem(0x03, 0xA4, 0x01, 30, 1), new ShopItem(0x03, 0xAC, 0x01, 20, 1),
                new ShopItem(0x03, 0xA0, 0x01, 50, 1), new ShopItem(0x03, 0x64, 0x02, 80, 1),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
            shops[12] = new ShopItem[] {
                new ShopItem(0x03, 0xA8, 0x02, 40, 1), new ShopItem(0x03, 0x90, 0x01, 50, 1),
                new ShopItem(0x03, 0xA0, 0x03, 70, 1), new ShopItem(0x03, 0x94, 0x03, 80, 1),
                new ShopItem(0x03, 0x80, 0x03, 100, 1), new ShopItem(0x03, 0xBC, 0x02, 150, 1),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[14] = new ShopItem[] {
                new ShopItem(0x03, 0x68, 0x03, 80, 1), new ShopItem(0x03, 0x98, 0x02, 200, 1),
                new ShopItem(0x03, 0x84, 0x01, 100, 1), new ShopItem(0x03, 0x88, 0x02, 100, 1),
                new ShopItem(0x03, 0x20, 0x06, 50, 1), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[16] = new ShopItem[] {
                new ShopItem(0x01, 0x70, 0xFF, 1, 255), new ShopItem(0x01, 0x71, 0xFF, 10, 255),
                new ShopItem(0x01, 0x74, 0xFF, 100, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
                };
            shops[17] = new ShopItem[] {
                new ShopItem(0x01, 0x71, 0xFF, 10, 255), new ShopItem(0x01, 0x74, 0xFF, 100, 255),
                new ShopItem(0x01, 0x75, 0xFF, 40, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            
            shops[19] = new ShopItem[] {
                new ShopItem(0x01, 0x70, 0xFF, 1, 255), new ShopItem(0x01, 0x72, 0xFF, 2, 255),
                new ShopItem(0x01, 0x74, 0xFF, 100, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[20] = new ShopItem[] {
                new ShopItem(0x01, 0x70, 0xFF, 1, 255), new ShopItem(0x01, 0x72, 0xFF, 2, 255),
                new ShopItem(0x01, 0x73, 0xFF, 1, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            shops[21] = new ShopItem[] {
                new ShopItem(0x01, 0x70, 0xFF, 1, 255), new ShopItem(0x01, 0x71, 0xFF, 10, 255),
                new ShopItem(0x01, 0x75, 0xFF, 40, 255), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
            
            return shops;
        }
        
        public override ShopItem[] getInitialChipOrderInventory(char version = 'M')
        {
            bool blue = version == 'M';
            
            return new ShopItem[] {
                new ShopItem(0x02, 0x01, 0x02, 2, 1), new ShopItem(0x02, 0x02, 0x09, 5, 1),
                new ShopItem(0x02, 0x03, 0x10, 10, 1), new ShopItem(0x02, 0x04, 0x1A, 6, 1),
                new ShopItem(0x02, 0x05, 0x1A, 12, 1), new ShopItem(0x02, 0x06, 0x1A, 30, 1),
                new ShopItem(0x02, 0x07, 0x12, 40, 1), new ShopItem(0x02, 0x08, 0x05, 55, 1),
                new ShopItem(0x02, 0x09, 0x09, 80, 1), new ShopItem(0x02, 0x0A, 0x09, 2, 1),
                new ShopItem(0x02, 0x0B, 0x0B, 3, 1), new ShopItem(0x02, 0x0C, 0x0C, 4, 1),
                new ShopItem(0x02, 0x0D, 0x0E, 10, 1), new ShopItem(0x02, 0x0E, 0x03, 5, 1),
                new ShopItem(0x02, 0x0F, 0x05, 10, 1), new ShopItem(0x02, 0x10, 0x05, 15, 1),
                new ShopItem(0x02, 0x11, 0x08, 5, 1), new ShopItem(0x02, 0x12, 0x09, 10, 1),
                new ShopItem(0x02, 0x13, 0x0A, 15, 1), new ShopItem(0x02, 0x14, 0x0B, 1, 1),
                new ShopItem(0x02, 0x15, 0x07, 8, 1), new ShopItem(0x02, 0x16, 0x07, 22, 1),
                new ShopItem(0x02, 0x17, 0x0D, 43, 1), new ShopItem(0x02, 0x18, 0x05, 50, 1),
                new ShopItem(0x02, 0x19, 0x0C, 64, 1), new ShopItem(0x02, 0x1A, 0x07, 80, 1),
                new ShopItem(0x02, 0x1B, 0x0D, 35, 1), new ShopItem(0x02, 0x1C, 0x0A, 50, 1),
                new ShopItem(0x02, 0x1D, 0x0B, 80, 1), new ShopItem(0x02, 0x1E, 0x12, 9, 1),
                new ShopItem(0x02, 0x1F, 0x02, 17, 1), new ShopItem(0x02, 0x20, 0x18, 21, 1),
                new ShopItem(0x02, 0x21, 0x0D, 44, 1), new ShopItem(0x02, 0x22, 0x0D, 53, 1),
                new ShopItem(0x02, 0x23, 0x0D, 79, 1), new ShopItem(0x02, 0x24, 0x0D, 70, 1),
                new ShopItem(0x02, 0x25, 0x01, 36, 1), new ShopItem(0x02, 0x26, 0x01, 100, 1),
                new ShopItem(0x02, 0x27, 0x0D, 78, 1), new ShopItem(0x02, 0x28, 0x11, 118, 1),
                new ShopItem(0x02, 0x29, 0x0B, 60, 1), new ShopItem(0x02, 0x2A, 0x07, 50, 1),
                new ShopItem(0x02, 0x2B, 0x01, 36, 1), new ShopItem(0x02, 0x2C, 0x09, 6, 1),
                new ShopItem(0x02, 0x2D, 0x0C, 10, 1), new ShopItem(0x02, 0x2E, 0x15, 24, 1),
                new ShopItem(0x02, 0x2F, 0x01, 12, 1), new ShopItem(0x02, 0x30, 0x0E, 24, 1),
                new ShopItem(0x02, 0x31, 0x06, 40, 1), new ShopItem(0x02, 0x32, 0x00, 10, 1),
                new ShopItem(0x02, 0x33, 0x02, 30, 1), new ShopItem(0x02, 0x34, 0x00, 44, 1),
                new ShopItem(0x02, 0x35, 0x06, 9, 1), new ShopItem(0x02, 0x36, 0x10, 16, 1),
                new ShopItem(0x02, 0x37, 0x07, 8, 1), new ShopItem(0x02, 0x38, 0x02, 28, 1),
                new ShopItem(0x02, 0x39, 0x08, 35, 1), new ShopItem(0x02, 0x3A, 0x05, 10, 1),
                new ShopItem(0x02, 0x3B, 0x05, 22, 1), new ShopItem(0x02, 0x3C, 0x05, 30, 1),
                new ShopItem(0x02, 0x3D, 0x0B, 90, 1), new ShopItem(0x02, 0x3E, 0x09, 115, 1),
                new ShopItem(0x02, 0x3F, 0x0C, 132, 1), new ShopItem(0x02, 0x40, 0x0F, 8, 1),
                new ShopItem(0x02, 0x41, 0x14, 14, 1), new ShopItem(0x02, 0x42, 0x12, 6, 1),
                new ShopItem(0x02, 0x43, 0x16, 15, 1), new ShopItem(0x02, 0x44, 0x19, 25, 1),
                new ShopItem(0x02, 0x45, 0x04, 28, 1), new ShopItem(0x02, 0x46, 0x09, 45, 1),
                new ShopItem(0x02, 0x47, 0x0E, 80, 1), new ShopItem(0x02, 0x48, 0x12, 30, 1),
                new ShopItem(0x02, 0x49, 0x0A, 46, 1), new ShopItem(0x02, 0x4A, 0x0E, 89, 1),
                new ShopItem(0x02, 0x4B, 0x07, 78, 1), new ShopItem(0x02, 0x4C, 0x0C, 200, 0),
                new ShopItem(0x02, 0x4D, 0x11, 100, 0), new ShopItem(0x02, 0x4E, 0x06, 70, 1),
                new ShopItem(0x02, 0x4F, 0x14, 90, 1), new ShopItem(0x02, 0x50, 0x14, 100, 1),
                new ShopItem(0x02, 0x51, 0x07, 70, 1), new ShopItem(0x02, 0x52, 0x0D, 90, 1),
                new ShopItem(0x02, 0x53, 0x08, 100, 1), new ShopItem(0x02, 0x54, 0x13, 16, 1),
                new ShopItem(0x02, 0x55, 0x15, 28, 1), new ShopItem(0x02, 0x56, 0x19, 46, 1),
                new ShopItem(0x02, 0x57, 0x08, 40, 1), new ShopItem(0x02, 0x58, 0x07, 60, 1),
                new ShopItem(0x02, 0x59, 0x03, 55, 1), new ShopItem(0x02, 0x5A, 0x00, 20, 1),
                new ShopItem(0x02, 0x5B, 0x03, 40, 1), new ShopItem(0x02, 0x5C, 0x02, 60, 1),
                new ShopItem(0x02, 0x5D, 0x11, 13, 1), new ShopItem(0x02, 0x5E, 0x0C, 40, 1),
                new ShopItem(0x02, 0x5F, 0x0F, 58, 1), new ShopItem(0x02, 0x60, 0x01, 69, 1),
                new ShopItem(0x02, 0x61, 0x05, 85, 1), new ShopItem(0x02, 0x62, 0x00, 105, 1),
                new ShopItem(0x02, 0x63, 0x0D, 70, 1), new ShopItem(0x02, 0x64, 0x12, 110, 1),
                new ShopItem(0x02, 0x65, 0x0A, 82, 1), new ShopItem(0x02, 0x66, 0x06, 100, 1),
                new ShopItem(0x02, 0x67, 0x04, 130, 1), new ShopItem(0x02, 0x68, 0x02, 30, 1),
                new ShopItem(0x02, 0x69, 0x02, 62, 1), new ShopItem(0x02, 0x6A, 0x02, 99, 1),
                new ShopItem(0x02, 0x6B, 0x02, 40, 1), new ShopItem(0x02, 0x6C, 0x00, 30, 1),
                new ShopItem(0x02, 0x6D, 0x00, 50, 1), new ShopItem(0x02, 0x6E, 0x12, 44, 1),
                new ShopItem(0x02, 0x6F, 0x0B, 66, 1), new ShopItem(0x02, 0x70, 0x13, 90, 1),
                new ShopItem(0x02, 0x71, 0x09, 130, 1), new ShopItem(0x02, 0x72, 0x00, 148, 1),
                new ShopItem(0x02, 0x73, 0x08, 135, 1), new ShopItem(0x02, 0x74, 0x0B, 150, 1),
                new ShopItem(0x02, 0x75, 0x05, 65, 1), new ShopItem(0x02, 0x76, 0x1A, 1, 1),
                new ShopItem(0x02, 0x77, 0x00, 1, 1), new ShopItem(0x02, 0x78, 0x02, 9, 1),
                new ShopItem(0x02, 0x79, 0x02, 1, 1), new ShopItem(0x02, 0x7A, 0x05, 5, 1),
                new ShopItem(0x02, 0x7B, 0x04, 10, 1), new ShopItem(0x02, 0x7C, 0x03, 15, 1),
                new ShopItem(0x02, 0x7D, 0x12, 30, 1), new ShopItem(0x02, 0x7E, 0x0D, 60, 1),
                new ShopItem(0x02, 0x7F, 0x0C, 90, 1), new ShopItem(0x02, 0x80, 0x0E, 120, 1),
                new ShopItem(0x02, 0x81, 0x00, 2, 1), new ShopItem(0x02, 0x82, 0x04, 20, 1),
                new ShopItem(0x02, 0x83, 0x18, 28, 1), new ShopItem(0x02, 0x84, 0x19, 30, 1),
                new ShopItem(0x02, 0x85, 0x02, 15, 1), new ShopItem(0x02, 0x86, 0x05, 39, 1),
                new ShopItem(0x02, 0x87, 0x13, 65, 1), new ShopItem(0x02, 0x88, 0x0A, 57, 1),
                new ShopItem(0x02, 0x89, 0x0F, 117, 1), new ShopItem(0x02, 0x8A, 0x09, 10, 1),
                new ShopItem(0x02, 0x8B, 0x05, 56, 1), new ShopItem(0x02, 0x8C, 0x02, 88, 1),
                new ShopItem(0x02, 0x8D, 0x00, 4, 1), new ShopItem(0x02, 0x8E, 0x07, 90, 1),
                new ShopItem(0x02, 0x8F, 0x12, 7, 1), new ShopItem(0x02, 0x90, 0x0B, 8, 1),
                new ShopItem(0x02, 0x91, 0x0F, 10, 1), new ShopItem(0x02, 0x92, 0x15, 40, 1),
                new ShopItem(0x02, 0x93, 0x19, 70, 1), new ShopItem(0x02, 0x94, 0x0A, 82, 1),
                new ShopItem(0x02, 0x95, 0x14, 100, 1), new ShopItem(0x02, 0x96, 0x16, 123, 1),
                new ShopItem(0x02, 0x97, 0x01, 40, 1), new ShopItem(0x02, 0x98, 0x02, 60, 1),
                new ShopItem(0x02, 0x99, 0x03, 48, 1), new ShopItem(0x02, 0x9A, 0x11, 36, 1),
                new ShopItem(0x02, 0x9B, 0x13, 52, 1), new ShopItem(0x02, 0x9C, 0x14, 70, 1),
                new ShopItem(0x02, 0x9D, 0x1A, 30, 1), new ShopItem(0x02, 0x9E, 0x1A, 90, 1),
                new ShopItem(0x02, 0x9F, 0x12, 10, 1), new ShopItem(0x02, 0xA0, 0x1A, 34, 1),
                new ShopItem(0x02, 0xA1, 0x19, 130, 1), new ShopItem(0x02, 0xA2, 0x09, 28, 1),
                new ShopItem(0x02, 0xA3, 0x0A, 47, 1), new ShopItem(0x02, 0xA4, 0x0C, 62, 1),
                new ShopItem(0x02, 0xA5, 0x07, 125, 1), new ShopItem(0x02, 0xA6, 0x0B, 100, 0),
                new ShopItem(0x02, 0xA7, 0x01, 100, 0), new ShopItem(0x02, 0xA8, 0x0D, 80, 1),
                new ShopItem(0x02, 0xA9, 0x03, 60, 1), new ShopItem(0x02, 0xAA, 0x04, 32, 1),
                new ShopItem(0x02, 0xAB, 0x05, 64, 1), new ShopItem(0x02, 0xAC, 0x0D, 96, 1),
                new ShopItem(0x02, 0xAD, 0x11, 2, 1), new ShopItem(0x02, 0xAE, 0x11, 32, 1),
                new ShopItem(0x02, 0xAF, 0x11, 62, 1), new ShopItem(0x02, 0xB0, 0x08, 120, 1),
                new ShopItem(0x02, 0xB1, 0x00, 98, 1), new ShopItem(0x02, 0xB2, 0x14, 60, 1),
                new ShopItem(0x02, 0xB3, 0x00, 72, 1), new ShopItem(0x02, 0xB4, 0x02, 50, 1), // Note: LavaStge (0xB3)'s code corrected from J to A
                new ShopItem(0x02, 0xB5, 0x04, 20, 1), new ShopItem(0x02, 0xB6, 0x16, 38, 1),
                new ShopItem(0x02, 0xB7, 0x0C, 45, 1), new ShopItem(0x02, 0xB8, 0x00, 180, 1),
                new ShopItem(0x02, 0xB9, 0x12, 100, 0), new ShopItem(0x02, 0xBA, 0x06, 100, 0),
                new ShopItem(0x02, 0xBB, 0x02, 100, 0), new ShopItem(0x02, 0xBC, 0x04, 100, 0), // Note: Jelly (0xBC)'s code corrected from I to E
                new ShopItem(0x02, 0xBD, 0x04, 100, 0), new ShopItem(0x02, 0xBE, 0x0D, 111, 1),
                new ShopItem(0x02, 0xBF, 0x12, 79, 1), new ShopItem(0x02, 0xC0, 0x0A, 92, 1),
                new ShopItem(0x02, 0xC1, 0x03, 88, 1), new ShopItem(0x02, 0xC2, 0x05, 31, 1),
                new ShopItem(0x02, 0xC3, 0x1A, 20, 1), new ShopItem(0x02, 0xC4, 0x1A, 43, 1),
                new ShopItem(0x02, 0xC5, 0x1A, 40, 1), new ShopItem(0x02, 0xC6, 0x1A, 52, 1),
                new ShopItem(0x02, 0xC7, 0x1A, 50, 1), new ShopItem(0x02, 0xC8, 0x1A, 80, 1),
                new ShopItem(0x02, 0xC9, 0x03, 150, 1), new ShopItem(0x02, 0xCA, 0x0C, 170, 1),
                new ShopItem(0x02, 0xCB, 0x0E, 162, 1), new ShopItem(0x02, 0xCC, 0x00, 180, 1),
                new ShopItem(0x02, 0xCD, 0x1A, 130, 1), new ShopItem(0x02, 0xCE, 0x1A, 130, 1),
                new ShopItem(0x02, 0xCF, 0x0F, 143, 1), new ShopItem(0x02, 0xD0, 0x19, 189, 1),
                new ShopItem(0x02, 0xD1, 0x12, 120, 1), new ShopItem(0x02, 0xD2, 0x16, 134, 1),
                new ShopItem(0x02, 0xD3, 0x1A, 100, 1), new ShopItem(0x02, 0xD4, 0x11, 170, 1),
                new ShopItem(0x02, 0xD5, 0x06, 180, 1), new ShopItem(0x02, 0xD6, 0x09, 162, 1),
                new ShopItem(0x02, 0xD7, 0x0F, 90, 1), new ShopItem(0x02, 0xD8, 0x02, 88, 1),
                new ShopItem(0x02, 0xD9, 0x0B, 94, 1), new ShopItem(0x02, 0xDA, 0x06, 98, 1),
                new ShopItem(0x02, 0xDB, 0x11, 50, 1), new ShopItem(0x02, 0xDC, 0x11, 80, 1),
                new ShopItem(0x02, 0xDD, 0x11, 110, 1), new ShopItem(0x02, 0xDE, 0x06, 60, 1),
                new ShopItem(0x02, 0xDF, 0x06, 90, 1), new ShopItem(0x02, 0xE0, 0x06, 120, 1),
                new ShopItem(0x02, 0xE1, 0x06, 150, 1), new ShopItem(0x02, 0xE2, 0x06, 300, 0),
                new ShopItem(0x02, 0xE3, 0x01, 100, 1), new ShopItem(0x02, 0xE4, 0x01, 130, 1),
                new ShopItem(0x02, 0xE5, 0x01, 160, 1), new ShopItem(0x02, 0xE6, 0x01, 190, 1),
                new ShopItem(0x02, 0xE7, 0x01, 300, 0), new ShopItem(0x02, 0xE8, 0x05, 50, 1),
                new ShopItem(0x02, 0xE9, 0x05, 80, 1), new ShopItem(0x02, 0xEA, 0x05, 110, 1),
                new ShopItem(0x02, 0xEB, 0x05, 140, 1), new ShopItem(0x02, 0xEC, 0x05, 300, 0),
                new ShopItem(0x02, 0xED, 0x01, 60, 1), new ShopItem(0x02, 0xEE, 0x01, 90, 1),
                new ShopItem(0x02, 0xEF, 0x01, 120, 1), new ShopItem(0x02, 0xF0, 0x01, 150, 1),
                new ShopItem(0x02, 0xF1, 0x01, 300, 0), new ShopItem(0x02, 0xF2, 0x01, 70, 1),
                new ShopItem(0x02, 0xF3, 0x01, 100, 1), new ShopItem(0x02, 0xF4, 0x01, 130, 1),
                new ShopItem(0x02, 0xF5, 0x01, 160, 1), new ShopItem(0x02, 0xF6, 0x01, 300, 0),
                new ShopItem(0x02, 0xF7, 0x03, 80, 1), new ShopItem(0x02, 0xF8, 0x03, 110, 1),
                new ShopItem(0x02, 0xF9, 0x03, 140, 1), new ShopItem(0x02, 0xFA, 0x03, 170, 1),
                new ShopItem(0x02, 0xFB, 0x03, 300, 0), new ShopItem(0x02, 0xFC, 0x0F, 90, 1),
                new ShopItem(0x02, 0xFD, 0x0F, 120, 1), new ShopItem(0x02, 0xFE, 0x0F, 150, 1),
                new ShopItem(0x02, 0xFF, 0x0F, 180, 1), new ShopItem(0x02, 0x100, 0x0F, 300, 0),
                new ShopItem(0x02, 0x101, 0x05, 100, 1), new ShopItem(0x02, 0x102, 0x05, 130, 1),
                new ShopItem(0x02, 0x103, 0x05, 160, 1), new ShopItem(0x02, 0x104, 0x05, 190, 1),
                new ShopItem(0x02, 0x105, 0x05, 300, 0), new ShopItem(0x02, 0x106, 0x03, 110, 1),
                new ShopItem(0x02, 0x107, 0x03, 140, 1), new ShopItem(0x02, 0x108, 0x03, 170, 1),
                new ShopItem(0x02, 0x109, 0x03, 200, 1), new ShopItem(0x02, 0x10A, 0x03, 300, 0),
                new ShopItem(0x02, 0x10B, 0x0C, 60, 1), new ShopItem(0x02, 0x10C, 0x0C, 90, 1),
                new ShopItem(0x02, 0x10D, 0x0C, 120, 1), new ShopItem(0x02, 0x10E, 0x0C, 150, 1),
                new ShopItem(0x02, 0x10F, 0x0C, 300, 0), new ShopItem(0x02, 0x110, 0x0F, 300, 0),
                new ShopItem(0x02, 0x111, 0x1A, 100, 0), new ShopItem(0x02, 0x112, 0x1A, 100, 0),
                new ShopItem(0x02, 0x113, 0x1A, 100, 0), new ShopItem(0x02, 0x114, 0x1A, 100, 0),
                new ShopItem(0x02, 0x115, 0x0A, 80, 1), new ShopItem(0x02, 0x116, 0x0A, 110, 1),
                new ShopItem(0x02, 0x117, 0x0A, 140, 1), new ShopItem(0x02, 0x118, 0x0A, 170, 1),
                new ShopItem(0x02, 0x119, 0x0A, 300, 0), new ShopItem(0x02, 0x11A, 0x0C, 100, 1),
                new ShopItem(0x02, 0x11B, 0x0C, 130, 1), new ShopItem(0x02, 0x11C, 0x0C, 160, 1),
                new ShopItem(0x02, 0x11D, 0x0C, 190, 1), new ShopItem(0x02, 0x11E, 0x0C, 300, 0),
                new ShopItem(0x02, 0x11F, 0x01, 100, 1), new ShopItem(0x02, 0x120, 0x01, 130, 1),
                new ShopItem(0x02, 0x121, 0x01, 160, 1), new ShopItem(0x02, 0x122, 0x01, 190, 1),
                new ShopItem(0x02, 0x123, 0x01, 300, 0), new ShopItem(0x02, 0x124, 0x03, 120, 1),
                new ShopItem(0x02, 0x125, 0x03, 150, 1), new ShopItem(0x02, 0x126, 0x03, 180, 1),
                new ShopItem(0x02, 0x127, 0x03, 210, 1), new ShopItem(0x02, 0x128, 0x03, 300, 0),
                new ShopItem(0x02, 0x129, 0x18, 130, 1), new ShopItem(0x02, 0x12A, 0x18, 160, 1),
                new ShopItem(0x02, 0x12B, 0x18, 190, 1), new ShopItem(0x02, 0x12C, 0x18, 210, 1),
                new ShopItem(0x02, 0x12D, 0x18, 300, 0),
                new ShopItem(0x02, (ushort)(blue? 0x12E : 0x130), (ushort)(blue? 0x19 : 0x1A), 300, 0),
                new ShopItem(0x02, (ushort)(blue? 0x12F : 0x131), (ushort)(blue? 0x1A : 0x15), (uint)(blue? 300 : 500), 0),
                new ShopItem(0x02, (ushort)(blue? 0x135 : 0x132), (ushort)(blue? 0x00 : 0x17), 400, 0),
                new ShopItem(0x02, (ushort)(blue? 0x136 : 0x133), (ushort)(blue? 0x15 : 0x12), (uint)(blue? 500 : 400), 0),
                new ShopItem(0x02, (ushort)(blue? 0x137 : 0x134), (ushort)(blue? 0x17 : 0x18), (uint)(blue? 400 : 300), 0),
                new ShopItem(0x02, 0x138, 0x17, 500, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0),
                new ShopItem(0x00, 0x00, 0x00, 0, 0), new ShopItem(0x00, 0x00, 0x00, 0, 0)
            };
        }
        
        public override byte[] getInitialBBSPostsList()
        {
            byte[] postBytes = new byte[0x200];
            for (int i = 0; i < postBytes.Length; i++)
                postBytes[i] = 0x40;
            
            int bbsNum = 1; // ACDC Chat BBS
            for (byte i = 0; i < 4; i++) // 01 to 04
                postBytes[(bbsNum * 0x40) + i] = (byte)(i + 1);
            
            bbsNum = 2; // ACDC Battle BBS
            for (byte i = 0x00; i <= 0x01; i++) // 00 and 01
                postBytes[(bbsNum * 0x40) + i] = i;
            
            return postBytes;
        }
        
        public override uint getBaseEncounterPointerForArea(byte area, byte subsection = 0xFF, char version = 'M', string language = "en", bool lc = false)
        {
            int baseAddress = 0x0;
            switch (area)
            {
                // Type 0: GBA English Blue, type 1: Legacy Collection Blue/Black (in labels_b.bin)
                case 0x80: baseAddress = !lc? 0x801B240 : 0x3C280; break; // Principal's PC
                case 0x81: baseAddress = !lc? 0x801B478 : 0x3C488; break; // Zoo Comp
                case 0x82: baseAddress = !lc? 0x801BA8C : 0x3CA08; break; // Hospital Comp
                case 0x83: baseAddress = !lc? 0x801C1E0 : 0x3D098; break; // WWW Comp
                case 0x84: baseAddress = !lc? 0x801C88C : 0x3D698; break; // (Unused)
                case 0x85: baseAddress = !lc? 0x801CAC4 : 0x3D8A0; break; // (Unused)
                case 0x86: baseAddress = !lc? 0x801CCFC : 0x3DAA8; break; // (Unused)
                case 0x87: baseAddress = !lc? 0x801CF34 : 0x3DCB0; break; // (Unused)
                case 0x88: baseAddress = !lc? 0x801D16C : 0x3DEB8; break; // Home Pages
                case 0x89: baseAddress = !lc? 0x801D570 : 0x3E260; break; // (Unused)
                case 0x8A: baseAddress = !lc? 0x801D7A8 : 0x3E468; break; // Cyberworlds A
                case 0x8B: baseAddress = !lc? 0x801DB68 : 0x3E7C8; break; // (Unused)
                case 0x8C: baseAddress = !lc? 0x801DDA0 : 0x3E9D0; break; // Cyberworlds B
                case 0x8D: baseAddress = !lc? 0x801EC88 : 0x3F720; break; // Cyberworlds C
                case 0x8E: baseAddress = !lc? 0x801F20C : 0x3FC18; break; // (Unused)
                case 0x8F: baseAddress = !lc? 0x801F444 : 0x3FE20; break; // (Unused)
                case 0x90: baseAddress = !lc? 0x801F67C : 0x40028; break; // ACDC Area
                case 0x91: baseAddress = !lc? 0x801FA1C : 0x40378; break; // SciLab Area
                case 0x92: baseAddress = !lc? 0x801FD18 : 0x40630; break; // Yoka Area
                case 0x93: baseAddress = !lc? 0x80200EC : 0x409B0; break; // Beach Area
                case 0x94: baseAddress = !lc? 0x8020724 : 0x40F58; break; // Undernet
                case 0x95: baseAddress = !lc? 0x8021144 : 0x41868; break; // Secret Area
            }
            
            if (baseAddress == 0)
                return 0;
            
            if (!lc) // Offsets from GBA English Blue
            {
                if (language == "jp")
                {
                    if (version == 'M') // Black
                        baseAddress -= 0x9C;
                    else // Original
                        baseAddress -= 0x8C;
                }
                else if (version == 'S') // White
                    baseAddress += 0x18;
            }
            else if (version == 'S') // Offset from LC Blue/Black to LC White/original
                baseAddress += 0x18;
            
            return (uint)(baseAddress);
        }
        
        public override Dictionary<int, string> getDefinedEncounters()
        {
            Dictionary<int, string> encounters = new Dictionary<int, string>();
            
            // Define "encounter IDs" (a thing I made up, not really a thing in-game) by adding area value * 0x10000 to the offset within that area.
            int areaIDMult = 0x10000;
            
            int hospitalCompID = 0x82 * areaIDMult;
            int cyberworldsBID = 0x8C * areaIDMult;
            int cyberworldsCID = 0x8D * areaIDMult;
            int acdcAreaID = 0x90 * areaIDMult;
            int yokaAreaID = 0x92 * areaIDMult;
            int beachAreaID = 0x93 * areaIDMult;
            int undernetID = 0x94 * areaIDMult;
            
            encounters[acdcAreaID + 0x124] = "FlashMan Beta";
            encounters[cyberworldsBID + 0x498] = "BeastMan Beta";
            encounters[beachAreaID + 0x1C4] = "BubbleMan Beta";
            encounters[cyberworldsBID + 0x4FC] = "DesertMan Beta";
            encounters[hospitalCompID + 0x284] = "PlantMan Beta";
            encounters[yokaAreaID + 0x140] = "FlameMan Beta";
            encounters[beachAreaID + 0x268] = "DrillMan Beta";
            encounters[undernetID + 0x34C] = "DarkMan Beta";
            encounters[cyberworldsCID + 0x1C4] = "YamatoMan Beta";
            
            return encounters;
        }
        
        public override int saveAreaLengthGBA {get { return 0x57B0; } }
        public override int saveFileSizeLC {get { return 0x57B8; } }
        
        // BN3 exclusive
        public static string[] virusBreederNames { get { return new string[] {
            "Mettaur", "Mettaur2", "Mettaur3", "MettaurΩ",
            "Bunny", "TuffBunny", "MegaBunny", "BunnyΩ",
            "Swordy", "Swordy2", "Swordy3", "SwordyΩ",
            "Spikey", "Spikey2", "Spikey3", "SpikeyΩ",
            "Mushy", "Mashy", "Moshy", "MushyΩ",
            "Jelly", "HeatJelly", "ErthJelly", "JellyΩ",
            "KillerEye", "DemonEye", "JokerEye", "KillerEyeΩ",
            "Momogra", "Momogro", "Momogre", "MomograΩ",
            "Scuttlest", "Scutz", "Scuttle", "Scuttler", "Scuttzer", "ScuttleΩ"
        }; } }
        
        public static string[] errorCodeNames { get { return new string[] {
            "", "A1", "A2", "A3", "B1", "B2", "B3", "B4", "B5", "B6", "C1", "C2", "E1", "E2", "F1", "F2",
            "F3", "H1", "H2", "H3", "G2G", "G2C", "G2S", "S2G", "S2C", "S2S", "D2G", "D2C", "D2S", "", "", ""
        }; } }
        
        public static string[] errorCodeAssociations { get { return new string[] {
            "",
            "SprArmor", "BrakBust", "BrakChrg", "SetGreen", "SetIce", "SetLava", "SetSand", "SetMetal", "SetHoly", "Custom1", "Custom2", // A1-3, B1-6, C1-2
            "MegaFldr1", "MegaFldr2", "Block", "Shield", "Reflect", "ShdwShoe", "FlotShoe", "AntiDmg", // E1-2, F1-3, H1-3
            "GigFldr1 Normal/Bug", "GigFldr1 Cus/Tm/Gr", "GigFldr1 Gu/Shl/Shdw", // G2G/C/S
            "HubBatch Normal/Bug", "HubBatch Cus/Tm/Gr", "HubBatch Gu/Shl/Shdw", // S2G/C/S
            "DarkLcns Normal/Bug", "DarkLcns Cus/Tm/Gr", "DarkLcns Gu/Shl/Shdw", // D2G/C/S
            "", "", ""
        }; } }
        
        public static byte[] errorCodeSaveBytes { get { return new byte[] {
            0x00, 0x28, 0x5A, 0x34, 0x04, 0xC1, 0x44, 0x57, 0x7C, 0xE9, 0x93, 0x39, 0x22, 0x82, 0x36, 0x6F,
            0xDD, 0x89, 0x87, 0xFE, 0x94, 0x3B, 0xB6, 0x55, 0x29, 0x67, 0xD1, 0xEE, 0x13, 0x00, 0x00, 0x00 // 00 = unused
        }; } }
        
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
                        case 0x01: return "ACDC Station";
                        case 0x02: return "Lan's House";
                        case 0x03: return "Lan's Room";
                        case 0x04: return "Mayl's House";
                        case 0x05: return "Mayl's Room";
                        case 0x06: return "Dex's Room";
                        case 0x07: return "Yai's Room";
                        case 0x08: return "Higsby's";
                    }
                    break;
                
                case 0x01:
                    if (returnArea)
                        return "ACDC School";
                    switch (subarea)
                    {
                        case 0x00: return "Class 5-A";
                        case 0x01: return "Class 5-B";
                        case 0x02: return "Class Hall";
                        case 0x03: return "Cross Hall";
                        case 0x04: return "Staff Lounge";
                        case 0x05: return "Principal's Office";
                        case 0x06: return "Lounge Hall";
                    }
                    break;
                
                case 0x02:
                    if (returnArea)
                        return "SciLab";
                    switch (subarea)
                    {
                        case 0x00: return "SciLab Station";
                        case 0x01: return "SciLab Lobby";
                        case 0x02: return "Virus Lab";
                        case 0x03: return "Dad's Lab";
                        case 0x04: return "Archives";
                    }
                    break;
                
                case 0x03:
                    if (returnArea)
                        return "Yoka";
                    switch (subarea)
                    {
                        case 0x00: return "Yoka Station";
                        case 0x01: return "Zoo Front";
                        case 0x02: return "Inn Front";
                        case 0x03: return "Inn Lobby";
                        case 0x04: return "Inn Hall";
                        case 0x05: return "Guest Room";
                        case 0x06: return "Outdoor Bath";
                        case 0x07: return "Zoo 1";
                        case 0x08: return "Zoo 2";
                        case 0x09: return "Secret Cave";
                    }
                    break;
                
                case 0x04:
                    if (returnArea)
                        return "Beach Street";
                    switch (subarea)
                    {
                        case 0x00: return "Beach Station";
                        case 0x01: return "Beach Street";
                        case 0x02: return "TV Station Lobby";
                        case 0x03: return "TV Station Hall 1";
                        case 0x04: return "TV Studio";
                        case 0x05: return "TV Station Hall 2";
                        case 0x06: return "Editing Room";
                    }
                    break;
                
                case 0x05:
                    if (returnArea)
                        return "Hades Isle";
                    switch (subarea)
                    {
                        case 0x00: return "Hades Isle";
                        case 0x01: return "Mount Hades";
                        case 0x02: return "Four Hades";
                        case 0x03: return "Eternal Hades";
                    }
                    break;
                
                case 0x06:
                    if (returnArea)
                        return "Beach Hospital";
                    switch (subarea)
                    {
                        case 0x00: return "Shoreline";
                        case 0x01: return "Hospital Lobby";
                        case 0x02: return "Hospital 2F";
                        case 0x03: return "Hospital Room";
                        case 0x04: return "Hospital 3F";
                        case 0x05: return "Basement";
                    }
                    break;
                
                case 0x07:
                    if (returnArea)
                        return "WWW Base";
                    switch (subarea)
                    {
                        case 0x00: return "SciLab (Past)";
                        case 0x01: return "Castle Wily";
                        case 0x02: return "Wily Lab";
                        case 0x03: return "Monitor Room";
                        case 0x04: return "Lab Hall";
                        case 0x05: return "Server Room";
                    }
                    break;
                
                case 0x80:
                    if (returnArea)
                        return "Principal's PC";
                    switch (subarea)
                    {
                        case 0x00: return "Principal's PC 1";
                        case 0x01: return "Principal's PC 2";
                    }
                    break;
                
                case 0x81:
                    if (returnArea)
                        return "Zoo Comp";
                    switch (subarea)
                    {
                        case 0x00: return "Zoo Comp 1";
                        case 0x01: return "Zoo Comp 2";
                        case 0x02: return "Zoo Comp 3";
                        case 0x03: return "Zoo Comp 4";
                    }
                    break;
                
                case 0x82:
                    if (returnArea)
                        return "Hospital Comp";
                    switch (subarea)
                    {
                        case 0x00: return "Hospital Comp 1";
                        case 0x01: return "Hospital Comp 2";
                        case 0x02: return "Hospital Comp 3";
                        case 0x03: return "Hospital Comp 4";
                        case 0x04: return "Hospital Comp 5";
                    }
                    break;
                
                case 0x83:
                    if (returnArea)
                        return "WWW Comp";
                    switch (subarea)
                    {
                        case 0x00: return "WWW Comp 1";
                        case 0x01: return "WWW Comp 2";
                        case 0x02: return "WWW Comp 3";
                        case 0x03: return "WWW Comp 4";
                        case 0x04: return "Alpha";
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
                        case 0x04: return "Tamako's HP";
                        //case 0x05: return "???'s HP";
                        //case 0x06: return "???'s HP";
                        //case 0x07: return "???'s HP";
                        case 0x08: return "Breeder 1 Comp";
                        case 0x09: return "Breeder 2 Comp";
                        case 0x0A: return "Breeder 3 Comp";
                        case 0x0B: return "Breeder 4 Comp";
                        case 0x0C: return "Breeder 5 Comp";
                        case 0x0D: return "Breeder 6 Comp";
                    }
                    break;
                
                case 0x8A:
                    if (returnArea)
                        return "Cyberworlds A";
                    switch (subarea)
                    {
                        case 0x00: return "Zoo Education Comp";
                        case 0x01: return "Bath Lion Comp";
                        case 0x02: return "Demon Statue Comp";
                        case 0x03: return "Editing Comp";
                        case 0x04: return "Monitor Comp";
                    }
                    break;
                
                case 0x8C:
                    if (returnArea)
                        return "Cyberworlds B";
                    switch (subarea)
                    {
                        case 0x00: return "Doghouse Comp";
                        case 0x01: return "Blackboard Comp";
                        case 0x02: return "SciLab Vending Comp";
                        case 0x03: return "SciLab Computer Comp";
                        case 0x04: return "Board Comp";
                        case 0x05: return "School Server Comp";
                        case 0x06: return "TV Relay Comp";
                        case 0x07: return "NetBattle Comp";
                        case 0x08: return "TV Board Comp";
                        case 0x09: return "Phone Comp";
                        case 0x0A: return "TV Comp";
                        case 0x0B: return "Hospital Bed Comp";
                        case 0x0C: return "Hospital Vending Comp";
                        case 0x0D: return "Ticket Comp";
                        case 0x0E: return "Tank Comp";
                        case 0x0F: return "Old TV Comp";
                    }
                    break;
                
                case 0x8D:
                    if (returnArea)
                        return "Cyberworlds C";
                    switch (subarea)
                    {
                        case 0x00: return "Armor Comp";
                        case 0x01: return "Sign Comp";
                        case 0x02: return "Broken Alarm Comp";
                        case 0x03: return "Door Sensor Comp";
                        case 0x04: return "Wall Comp";
                    }
                    break;
                
                case 0x90:
                    if (returnArea)
                        return "ACDC Area";
                    switch (subarea)
                    {
                        case 0x00: return "ACDC Area 1";
                        case 0x01: return "ACDC Area 2";
                        case 0x02: return "ACDC Area 3";
                        case 0x03: return "ACDC Square";
                    }
                    break;
                
                case 0x91:
                    if (returnArea)
                        return "SciLab Area";
                    switch (subarea)
                    {
                        case 0x00: return "SciLab Area 1";
                        case 0x01: return "SciLab Area 2";
                        case 0x02: return "SciLab Square";
                    }
                    break;
                
                case 0x92:
                    if (returnArea)
                        return "Yoka Area";
                    switch (subarea)
                    {
                        case 0x00: return "Yoka Area 1";
                        case 0x01: return "Yoka Area 2";
                        case 0x02: return "Yoka Square";
                    }
                    break;
                
                case 0x93:
                    if (returnArea)
                        return "Beach Area";
                    switch (subarea)
                    {
                        case 0x00: return "Beach Area 1";
                        case 0x01: return "Beach Area 2";
                        case 0x02: return "Beach Square";
                        case 0x03: return "Hades Isle Comp";
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
                        case 0x07: return "Under Square";
                    }
                    break;
                
                case 0x95:
                    if (returnArea)
                        return "Secret Area";
                    switch (subarea)
                    {
                        case 0x00: return "Secret Area 1";
                        case 0x01: return "Secret Area 2";
                        case 0x02: return "Secret Area 3";
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
                case 0x01: return "WWW Theme";
                case 0x02: return "ACDC Town";
                case 0x03: return "ACDC School";
                case 0x04: return "Inside House";
                case 0x05: return "Tree of Life";
                case 0x06: return "Yoka Village";
                case 0x07: return "Beach Street";
                case 0x08: return "SciLab (Scientific Forefront)";
                case 0x09: return "DNN Station";
                case 0x0A: return "N1 Grand Prix";
                case 0x0B: return "Hades Isle";
                case 0x0C: return "Suspicious Mood";
                case 0x0D: return "Incident Occurrence!";
                case 0x0E: return "Wiping Tears";
                case 0x0F: return "Proof Of Courage";
                case 0x10: return "Transmission!";
                case 0x11: return "Principal's PC (Blind Mode)";
                case 0x12: return "Zoo Comp (Maze Of Wilderness)";
                case 0x13: return "Hospital Comp (Save a Life)";
                case 0x15: return "Alpha (Final Transmission)";
                case 0x16: return "Internet (Network is Spreading)";
                case 0x17: return "Undernet (Dangerous Black)";
                case 0x18: return "Secret Area (Shine in the Dark)";
                case 0x19: return "Virus Battle (Shooting Enemy)";
                case 0x1A: return "Boss Battle";
                case 0x1B: return "VS Alpha";
                case 0x1C: return "N1 Battle (Great Battlers)";
                case 0x1E: return "Victory!";
                case 0x1F: return "Style Change";
                case 0x21: return "Game Over";
                case 0x22: return "Showdown";
                case 0x23: return "Credits (farewell)";
                case 0x24: return "WWW Base";
                case 0x25: return "Navi Customizer";
            }
            
            return fallbackIfNotFound? "[" + music.ToString("X2") + "]" : "";
        }
        
        public override string getStyleName(int style, bool fallbackIfNotFound = false, bool includeLevel = false)
        {
            // As a holdover from BN2, multiples of 0x40 are read as the same style.
            // But level is a separate value, so this seems to determine nothing and is not normally set that high by the game.
            style = style % 0x40;
            
            switch (style)
            {
                case 0x00: return "NormStyl";
                case 0x01: return "Normal";
                case 0x09: return "ElecGuts";
                case 0x0A: return "HeatGuts";
                case 0x0B: return "AquaGuts";
                case 0x0C: return "WoodGuts";
                case 0x11: return "ElecCust";
                case 0x12: return "HeatCust";
                case 0x13: return "AquaCust";
                case 0x14: return "WoodCust";
                case 0x19: return "ElecTeam";
                case 0x1A: return "HeatTeam";
                case 0x1B: return "AquaTeam";
                case 0x1C: return "WoodTeam";
                case 0x21: return "ElecShld";
                case 0x22: return "HeatShld";
                case 0x23: return "AquaShld";
                case 0x24: return "WoodShld";
                case 0x29: return "ElecGrnd";
                case 0x2A: return "HeatGrnd";
                case 0x2B: return "AquaGrnd";
                case 0x2C: return "WoodGrnd";
                case 0x31: return "ElecShdw";
                case 0x32: return "HeatShdw";
                case 0x33: return "AquaShdw";
                case 0x34: return "WoodShdw";
                case 0x39: return "ElecBug";
                case 0x3A: return "HeatBug";
                case 0x3B: return "AquaBug";
                case 0x3C: return "WoodBug";
            }
            
            return fallbackIfNotFound? "Style #" + style : "";
        }
        
        public override string getEmailName(int email, bool fallbackIfNotFound = false)
        {
            switch (email)
            {
                case 0: return "NetCrime alert (MailNews)";
                case 1: return "I'm starting! (Dex)";
                case 2: return "It's opened! (Mayl)";
                case 3: return "Let's battle! (Dex)";
                case 4: return "Fixed it! (Dad)";
                case 5: return "Help, huh!! (Higsby)";
                case 6: return "N1 preliminary (DNN)";
                case 7: return "Business trip (Dad)";
                case 8: return "Use this (Mayl)";
                case 9: return "Hurry, huh!! (Higsby)";
                case 10: return "Recording (DNN)";
                case 11: return "C-Beach Pass (DNN)";
                case 12: return "N1 time!! (Dex)";
                case 13: return "Good luck!! (Dad)";
                case 14: return "Upon arrival (Sunayama)";
                case 15: return "Yai in trouble (Mayl)";
                case 16: return "Killer plants? (MailNews)";
                case 17: return "Need to talk... (Dex)";
                case 18: return "Thanks! (Mamoru)";
                case 19: return "Mamoru (Hospital)";
                case 20: return "Hurry! (Mr. Match)";
                case 21: return "Next!! (Mr. Match)";
                case 22: return "Waiting@Square (Anon)";
                case 23: return "Newsflash (DNN)";
                case 24: return "Fire alert! (DNN)";
                case 25: return "Come quickly! (Mayl)";
                case 26: return "The Rank9 Navi (Ex-Rank 10)";
                case 27: return "Head to Square (Chaud)";
                case 28: return "Virus breeder (SciLab)";
                case 29: return "Emergency (SciLab)";
                case 30: return "Use this (Dad)";
                case 31: return "New shortcut! (Dex)";
                case 32: return "New shortcut! (Mayl)";
                case 33: return "New shortcut! (Yai)";
                case 34: return "A shortcut (Tamako)";
                case 35: return "Guts Style (Dad)";
                case 36: return "Custom Style (Dad)";
                case 37: return "Team Style (Dad)";
                case 38: return "Shield Style (Dad)";
                case 39: return "Ground Style (Dad)";
                case 40: return "Shadow Style (Dad)";
                case 41: return "Customizing (Dad)";
                case 42: return "Bug Style (Dad)";
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
                        case 0: return "Finding a friend (Tora)";
                        case 1: return "Stuntmen wanted! (Tora)";
                        case 2: return "Riot stopping (Tora)";
                        case 3: return "Recovering data (Tora)";
                        case 4: return "Please deliver this";
                        case 5: return "My Navi is sick";
                        case 6: return "Help me with my son!";
                        case 7: return "Transfer mishap";
                        case 8: return "Chip prices";
                        case 9: return "I'm broke...!";
                        case 10: return "Rare chip for cheap!";
                        case 11: return "Be my boyfriend!";
                        case 12: return "Will you deliver?";
                        case 13: return "Somebody, please help!";
                        case 14: return "Looking for condor";
                        case 15: return "Help with rehab";
                        case 16: return "My old master";
                        case 17: return "Catching gang members";
                        case 18: return "Adopt stray viruses!";
                        case 19: return "Legendary tomes";
                        case 20: return "Hide and seek!";
                        case 21: return "Seeking the blue Navi";
                        case 22: return "Give your support!";
                        case 23: return "Stamp contest";
                        case 24: return "Mysterious will";
                    }
                    break;
                
                case 1: // ACDC Chat BBS
                    switch (post)
                    {
                        case 0: return "NO NAME - From No. 3";
                        case 1: return "Miki - N1 Grand Prix!";
                        case 2: return "Gayan - RE:N1 Grand Prix!";
                        case 3: return "Crosser - Reg. System";
                        case 4: return "Pon - SubMemory";
                        case 5: return "Mole - Sighting?!";
                        case 6: return "ChunG - RE:Sighting?!";
                        case 7: return "Mayumi - Busting Level";
                        case 8: return "Nukky - RE:Busting Level";
                        case 9: return "Koetsu - Counter!";
                        case 10: return "Turner - Regular Chips";
                        case 11: return "Amayan - RE:Regular Chips";
                        case 12: return "KingKoma - RE:Regular Chips";
                        case 13: return "Hassy - Beach Street";
                        case 14: return "Maki - Who will win?";
                        case 15: return "HigHig - RE:Who will win?";
                        case 16: return "Takayan - RE:Who will win?";
                        case 17: return "Yai - I will win!";
                        case 18: return "HigHig - New rare chip";
                        case 19: return "Miki - RE:New rare chip";
                        case 20: return "Haru - Number Trader";
                        case 21: return "U-pon - RE:Number Trader";
                        case 22: return "MEGAoka - RE:Number Trader";
                        case 23: return "Higsby - RE:Number Trader";
                        case 24: return "Haru - Seriously?!";
                        case 25: return "Junko - Chip trades?";
                        case 26: return "Arima - Quizzes";
                        case 27: return "NO NAME - The Undernet";
                        case 28: return "Axel - RE:The Undernet";
                        case 29: return "NO NAME - NO SUBJECT";
                        case 30: return "Cartan - Unbelievable!";
                        case 31: return "KingKoma - RE:Unbelievable!";
                        case 32: return "Amayan - RE:Unbelievable!";
                        case 33: return "HigHig - Either way...";
                    }
                    break;
                
                case 2: // ACDC Battle BBS
                    switch (post)
                    {
                        case 0: return "Cartan - Battle BBS!";
                        case 1: return "Kitager - My favorite!";
                        case 2: return "Beltz - NO SUBJECT";
                        case 3: return "Cartan - Be mindful!";
                        case 4: return "Koetsu - Eleball";
                        case 5: return "Cartan - RE:Eleball";
                        case 6: return "Beltz - I'm sorry";
                        case 7: return "Bozu - NaviCust?!";
                        case 8: return "Beltz - Bought it!";
                        case 9: return "Dex - Me too!";
                        case 10: return "GutsMan - Feel strange...";
                        case 11: return "Koetsu - Don't worry!";
                        case 12: return "Dex - Fixed!!!";
                        case 13: return "Poteno - N1 Grand Prix!";
                        case 14: return "Nukky - RE:N1 Grand Prix!";
                        case 15: return "Koetsu - Too good!";
                        case 16: return "Cartan - MetalMan?";
                        case 17: return "Tamako - RE:MetalMan?";
                        case 18: return "Cartan - Thanks!!!";
                        case 19: return "Hassy - Breaking";
                        case 20: return "Tessan - LavaPanels";
                        case 21: return "Axel - ModCodes?";
                        case 22: return "Kakky - RE:ModCodes?";
                        case 23: return "Bozu - I know one!";
                        case 24: return "Nukky - RE:I know one!";
                        case 25: return "Poteno - Who knew!";
                        case 26: return "Nukky - A kind soul";
                        case 27: return "Poteno - RE:A kind soul";
                    }
                    break;
                
                case 3: // SciLab Battle BBS
                    switch (post)
                    {
                        case 0: return "Sakasso - Battle BBS";
                        case 1: return "Pachy - Hello";
                        case 2: return "Brake - Ice panels";
                        case 3: return "Sakasso - NaviCust!";
                        case 4: return "Yusuke - RE:NaviCust!";
                        case 5: return "Takayan - Mole virus";
                        case 6: return "DrHikari - Customization";
                        case 7: return "Harrun - Wonderful!";
                        case 8: return "ChunG - ModTools";
                        case 9: return "Mole - RE:ModTools";
                        case 10: return "Haru - New ModCode!";
                        case 11: return "U-pon - Vine virus";
                        case 12: return "Heylon - Floating";
                        case 13: return "Maki - RE:Floating";
                        case 14: return "Takken - Half damage!";
                        case 15: return "Shira-bo - Me too, then";
                        case 16: return "Kuro - Help!";
                        case 17: return "Haru - RE:Help!";
                        case 18: return "Dohma - No way...";
                        case 19: return "Chaud - Just give up";
                        case 20: return "Kuro - WOW!!";
                        case 21: return "Arima - PA info!";
                        case 22: return "Ogata - RE:PA info!";
                    }
                    break;
                
                case 4: // Yoka Chat BBS
                    switch (post)
                    {
                        case 0: return "Junko - I got it!";
                        case 1: return "Mayumi - RE:I got it!";
                        case 2: return "Crosser - * (asterisk)";
                        case 3: return "Miki - RE:I got it!";
                        case 4: return "Axel - No kidding!";
                        case 5: return "Harrun - Can't be...";
                        case 6: return "Koetsu - RE:* (asterisk)";
                        case 7: return "Ogata - Hey, Koetsu!";
                        case 8: return "Heylon - Extra Folders";
                        case 9: return "Takayan - RE:Extra Folders";
                        case 10: return "Koetsu - RE:Extra Folders";
                        case 11: return "Koetsu - Asterisks & PAs";
                        case 12: return "Poteno - Oh, come on!";
                        case 13: return "Nukky - No, no, no!";
                        case 14: return "Poteno - RE:No, no, no!";
                        case 15: return "Poteno - Hah!";
                        case 16: return "Higsby - Oh,oh!";
                        case 17: return "Cartan - Wow...";
                        case 18: return "Koetsu - Go easy";
                        case 19: return "Tetsuya - Strange virus";
                        case 20: return "Yama - RE:Strange virus";
                        case 21: return "ChunG - RE:Strange virus";
                    }
                    break;
                
                case 5: // Beach Chat BBS
                    switch (post)
                    {
                        case 0: return "MetroHQ - Roads closed";
                        case 1: return "DNN - N1 starts!";
                        case 2: return "Goh - RE:N1 starts!";
                        case 3: return "Goh - NO SUBJECT";
                        case 4: return "Tessan - What's wrong?";
                        case 5: return "MEGAoka - Warning";
                        case 6: return "Arima - Scary!!!";
                        case 7: return "BattleML - Investigating";
                        case 8: return "KingKoma - Gambler";
                        case 9: return "Ponzu - RE:Gambler";
                        case 10: return "Micchan - Why there?";
                        case 11: return "Taka - RE:Why there?";
                        case 12: return "Madmad - RE:Why there?";
                        case 13: return "Mohe - RE:Why there?";
                        case 14: return "DNN - WWW activity";
                        case 15: return "Cartan - RE:WWW activity";
                        case 16: return "Hassy - RE:WWW activity";
                        case 17: return "MEGAoka - RE:WWW activity";
                        case 18: return "DNN - Urgent report";
                        case 19: return "Arima - RE:Urgent report";
                        case 20: return "Take&Ebi - RE:Urgent report";
                        case 21: return "Tessan - RE:RE:N1 starts!";
                    }
                    break;
                
                case 6: // Under BBS
                    switch (post)
                    {
                        case 0: return "NO NAME - UnderBoard";
                        case 1: return "NO NAME - Dark chips";
                        case 2: return "NO NAME - Dominerd";
                        case 3: return "NO NAME - An amoeba?";
                        case 4: return "NO NAME - RE:An amoeba?";
                        case 5: return "NO NAME - LifeVirus?";
                        case 6: return "NO NAME - GigFldr1";
                        case 7: return "NO NAME - RE:GigFldr1";
                        case 8: return "NO NAME - Wrong!";
                        case 9: return "NO NAME - Arrow3";
                        case 10: return "NO NAME - RE:Arrow3";
                        case 11: return "NO NAME - Error H2";
                        case 12: return "NO NAME - RE:Error H2";
                        case 13: return "NO NAME - Bugs...";
                        case 14: return "NO NAME - The UnderLord";
                    }
                    break;
            }
            
            return fallbackIfNotFound? "Post #" + (post + 1) : "";
        }
        
        public override string getShopName(int shop, bool fallbackIfNotFound = false)
        {
            switch (shop)
            {
                case 0: return "ACDC Area 2 NetDealer";
                case 1: return "ACDC Square NetDealer";
                case 2: return "ACDC Square SubChip dealer";
                case 3: return "SciLab Square NetDealer";
                case 4: return "Yoka Area 1 BugFrag Trader";
                case 5: return "Yoka Square NetDealer";
                case 6: return "Yoka Square SubChip dealer";
                case 7: return "Beach Area 2 SubChip dealer";
                case 8: return "Beach Square NetDealer";
                case 9: return "Beach Square program dealer";
                case 10: return "Undernet 2 BugFrag Trader";
                case 11: return "Undernet 4 NetDealer";
                case 12: return "Undernet 6 BugFrag program dealer";
                case 13: return "Under Square NetDealer";
                case 14: return "Under Square program dealer";
                case 15: return "Secret Area 2 NetDealer";
                case 16: return "Hospital TV SubChip dealer";
                case 17: return "WWW Wall Comp SubChip dealer";
                case 18: return "Higsby's";
                case 19: return "ACDC Town SubChip dealer";
                case 20: return "Zoo Front SubChip dealer";
                case 21: return "SciLab Lobby SubChip dealer";
                case 22: return "Higsby's Chip Order";
            }
            
            return fallbackIfNotFound? "Shop #" + (shop + 1) : "";
        }
        
        public override string getChipOrderShopName()
        {
            return getShopName(22);
        }
        
        public override bool isBugFragShop(int shop, bool fallbackIfNotFound = false)
        {
            return shop == 4 || shop == 10 || shop == 12;
        }
        
        public override string getChapterDesc(int chapter)
        {
            switch (chapter)
            {
                case 0: return "In Virus Lab intro";
                case 1: return "After Virus Lab intro";
                case 2: return "After park meeting and learning about N1";
                case 3: return "After Prelims Round 1";
                case 4: return "After chat session, deciding to get Dex's disk";
                case 5: return "After unlocking school gate";
                case 6: return "After entering school at night";
                case 7: return "After hearing noise at school";
                case 8: return "After friends get hypnotized";
                case 9: return "After blocking Hypno Flash to enter Principal's PC";
                case 10: return "After beating FlashMan";
                
                case 16: return "Start of day after FlashMan";
                case 17: return "Talked to Chisao about #1 NetBattler";
                case 18: return "After fighting Dex for Chisao";
                case 19: return "Encountered Sunayama at SciLab, onto Prelims Round 2";
                case 20: return "In Prelims Round 2";
                case 21: return "On Prelims Round 2, Mission 3";
                case 22: return "After Prelims Round 2";
                
                case 23: return "Start of Yoka field trip day";
                case 24: return "Start of Yoka Zoo day";
                case 25: return "After NaviCust tutorial";
                case 26: return "After animal outbreak";
                case 27: return "After being told to enter zoo network";
                
                case 32: return "Start of day after BeastMan";
                case 33: return "Doing jobs for Higsby";
                case 34: return "In Prelims Round 3";
                
                case 35: return "Start of BubbleMan day";
                case 36: return "After first BubbleMan encounter";
                case 37: return "After second BubbleMan encounter (Bubble Door)";
                case 38: return "After obtaining Needle";
                case 39: return "After beating BubbleMan";
                
                case 48: return "Start of Beach Area TV shoot day";
                case 49: return "After TV shoot in Beach Square";
                case 50: return "Delivering DataDisk to Dad";
                
                case 51: return "Start of N1 Grand Prix day";
                case 52: return "Arrived at Hades Isle";
                case 53: return "After Hades Isle Round 1 (VictData search)";
                case 54: return "Back from Hades Isle for semi-finals";
                case 55: return "After beating Tora in semi-finals";
                
                case 64: return "Start of Yai hospital visit day";
                case 65: return "Getting tea for Yai";
                case 66: return "Helping Tora with jobs";
                case 67: return "Dex moving day";
                case 68: return "Start of Mamoru hospital visit day";
                
                case 69: return "Start of PlantMan day";
                case 70: return "Hospital incident begun";
                case 71: return "After stopping tree growth";
                
                case 80: return "Start of FlameMan day";
                case 81: return "WWW Net attacks begun";
                case 82: return "After WWW Net attacks";
                case 83: return "Helping Mr. Match";
                case 84: return "After hearing about fire at SciLab";
                case 85: return "Putting out Net fires";
                case 86: return "After putting out all Net fires";
                case 87: return "After talking to Dad post-fire";
                
                case 96: return "Start of Undernet day";
                case 97: return "After talking to Chaud outside house";
                case 98: return "After talking to Chaud in Virus Lab";
                case 99: return "After refighting BeastMan (Rank 8)";
                case 100: return "After fighting CopyMan (Rank 3)";
                case 101: return "After MistMan/BowlMan (Rank 2), looking for Undernet server";
                case 102: return "After obtaining Forbidden Program, Alpha stolen";
                
                case 112: return "Start of AutoTank day";
                case 113: return "ACDC AutoTank stopped";
                case 114: return "After talking to Mom at hospital, searching for Dad";
                case 115: return "After talking to Dad in SciLab Archives";
                
                case 116: return "Start of final day";
                case 117: return "Arrived at WWW Base";
                case 118: return "After stopping first WWW Base tank";
                case 119: return "After stopping second WWW Base tank";
                case 120: return "After stopping third WWW Base tank";
                case 121: return "Ready for final battle";
            }
            return "";
        }
        
        public override string getFlagDesc(int flag)
        {
            if (flag >= 2816 && flag <= 3135) // Library chip "shared" flags
                return "Data Library shared: " + getChipName(flag - 2816);
            else if (flag >= 3136 && flag <= 3183) // Library PA "shared" flags
                return "Data Library shared: " + getPAName(flag - 3136);
            else if (flag >= 4352 && flag <= 4394) // Emails
                return "Email: " + getEmailName(flag - 4352, true);
            else if (flag >= 4480 && flag <= 4522) // Emails unread
                return "Email unread: " + getEmailName(flag - 4480, true);
            else if (flag >= 4608 && flag <= 4687) // Deactivate map object
                return "Deactivates various map objects";
            else if (flag >= 4736 && flag <= 5759) // BBS posts, BBS posts unread
            {
                bool unreadFlag = flag >= 5248;
                int startFlag = !unreadFlag? 4736 : 5248;
                int bbsNum = (flag - startFlag) / 64;
                int postNum = (flag - startFlag) % 64;
                if (bbsNum < bbsNames.Length)
                    return "Post" + (unreadFlag? " unread" : "") + ": " + bbsNames[bbsNum] + ", " + getBBSPost(bbsNum, postNum, true);
            }
            else if (flag >= 5760 && flag <= 5784) // Job complete
                return "Job complete: " + getBBSPost(0, flag - 5760, true);
            else if (flag >= 5824 && flag <= 5848) // Job taken
                return "Job taken: " + getBBSPost(0, flag - 5824, true);
            
            switch (flag)
            {
                case 0: return "Opened Mayl's security cube";
                case 1: return "Opened Dex's security cube";
                case 2: return "Opened Yai's security cube";
                case 3: return "Opened Tamako's security cube";
                case 4: return "Opened WWW door in ACDC 1";
                case 5: return "Opened WWW door in SciLab 1";
                case 7: return "Opened WWW door in Yoka 1";
                case 8: return "Control locked for map change";
                case 9: return "MegaMan in Cyberworld";
                case 10: return "Metroline ticket bought";
                case 15: return "Job BBS request active";
                case 17: return "Tamako's Beach Square shortcut open";
                case 18: return "Mayl's Yoka Square shortcut open";
                case 19: return "Dex's ACDC Square shortcut open";
                case 20: return "Yai's SciLab Square shortcut open";
                case 25: return "In capsule warp animation";
                //case 26: return "Cleared when going to bed at end of FlashMan day, maybe related to night ACDC";
                //case 28: return "Set when going to bed at end of FlashMan day, maybe related to night ACDC";
                case 30: return "Prevents jacking in until intro park meeting";
                case 38: return "Puts away futons or screen in Inn Guest Room";
                case 53: return "Talking to CyberMetro Mr. Prog";
                case 89: return "Puts away futons or screen in Inn Guest Room";
                case 91: return "Entered Yoka Zoo?";
                
                case 93: return "Mettaur in breeder";
                case 94: return "Mettaur2 in breeder";
                case 95: return "Mettaur3 in breeder";
                case 96: return "Mettaur Omega in breeder";
                case 97: return "Bunny in breeder";
                case 98: return "TuffBunny in breeder";
                case 99: return "MegaBunny in breeder";
                case 100: return "Bunny Omega in breeder";
                case 101: return "Swordy in breeder";
                case 102: return "Swordy2 in breeder";
                case 103: return "Swordy3 in breeder";
                case 104: return "Swordy Omega in breeder";
                case 105: return "Spikey in breeder";
                case 106: return "Spikey2 in breeder";
                case 107: return "Spikey3 in breeder";
                case 108: return "Spikey Omega in breeder";
                case 109: return "Mushy in breeder";
                case 110: return "Mashy in breeder";
                case 111: return "Moshy in breeder";
                case 112: return "Mushy Omega in breeder";
                case 113: return "Jelly in breeder";
                case 114: return "HeatJelly in breeder";
                case 115: return "ErthJelly in breeder";
                case 116: return "Jelly Omega in breeder";
                case 117: return "KillerEye in breeder";
                case 118: return "DemonEye in breeder";
                case 119: return "JokerEye in breeder";
                case 120: return "KillerEye Omega in breeder";
                case 121: return "Momogra in breeder";
                case 122: return "Momogro in breeder";
                case 123: return "Momogre in breeder";
                case 124: return "Momogra Omega in breeder";
                case 125: return "Scuttlest in breeder";
                case 126: return "Scutz in breeder";
                case 127: return "Scuttle in breeder";
                case 128: return "Scuttler in breeder";
                case 129: return "Scuttzer in breeder";
                case 130: return "Scuttle Omega in breeder";
                
                case 131: return "Folder locked from switching";
                case 132: return "Trail of bubbles appeared on Net";
                case 133: return "Bubble Door in Yoka Area appeared";
                case 134: return "Bubble Door in Yoka Area popped";
                //case 135: return "Set on game start, not always on";
                case 136: return "Have Navi Customizer";
                //case 140: return "Set immediately on booting";
                
                case 160: return "Deactivates hospital vines #1";
                case 161: return "Deactivates hospital vines #2";
                case 163: return "Used to show indicators in NaviCust tutorial";
                case 164: return "Used to show indicators in NaviCust tutorial";
                case 167: return "Deactivates hospital vines #3";
                
                //case 250: return "Set immediately on booting, not always on";
                case 251: return "Flames appeared on Net";
                
                case 257: return "Let through by Undernet 2 Navi";
                case 258: return "Let through by Undernet 3 Navi";
                
                case 259: return "FlashMan defeated";
                case 260: return "FlashMan Alpha defeated";
                case 261: return "FlashMan Beta defeated";
                case 262: return "FlashMan Omega defeated";
                case 263: return "BeastMan defeated";
                case 264: return "BeastMan Alpha defeated";
                case 265: return "BeastMan Beta defeated";
                case 266: return "BeastMan Omega defeated";
                case 267: return "BubbleMan defeated";
                case 268: return "BubbleMan Alpha defeated";
                case 269: return "BubbleMan Beta defeated";
                case 270: return "BubbleMan Omega defeated";
                case 271: return "DesertMan defeated";
                case 272: return "DesertMan Alpha defeated";
                case 273: return "DesertMan Beta defeated";
                case 274: return "DesertMan Omega defeated";
                case 275: return "PlantMan defeated";
                case 276: return "PlantMan Alpha defeated";
                case 277: return "PlantMan Beta defeated";
                case 278: return "PlantMan Omega defeated";
                case 279: return "FlameMan defeated";
                case 280: return "FlameMan Alpha defeated";
                case 281: return "FlameMan Beta defeated";
                case 282: return "FlameMan Omega defeated";
                case 283: return "DrillMan defeated";
                case 284: return "DrillMan Alpha defeated";
                case 285: return "DrillMan Beta defeated";
                case 286: return "DrillMan Omega defeated";
                case 287: return "ProtoMan defeated";
                case 288: return "ProtoMan Alpha defeated";
                case 289: return "ProtoMan Beta defeated";
                case 290: return "ProtoMan Omega defeated";
                case 291: return "MetalMan defeated";
                case 292: return "MetalMan Alpha defeated";
                case 293: return "MetalMan Beta defeated";
                case 294: return "MetalMan Omega defeated";
                case 295: return "Punk defeated";
                case 296: return "Punk Alpha defeated";
                case 297: return "Punk Beta defeated";
                case 298: return "Punk Omega defeated";
                case 299: return "KingMan defeated";
                case 300: return "KingMan Alpha defeated";
                case 301: return "KingMan Beta defeated";
                case 302: return "KingMan Omega defeated";
                case 303: return "MistMan/BowlMan defeated";
                case 304: return "MistMan/BowlMan Alpha defeated";
                case 305: return "MistMan/BowlMan Beta defeated";
                case 306: return "MistMan/BowlMan Omega defeated";
                
                case 312: return "BassGS defeated";
                case 313: return "Bass defeated";
                case 315: return "DarkMan defeated";
                case 316: return "DarkMan Alpha defeated";
                case 317: return "DarkMan Beta defeated";
                case 318: return "DarkMan Omega defeated";
                case 319: return "YamatoMan defeated";
                case 320: return "YamatoMan Alpha defeated";
                case 321: return "YamatoMan Beta defeated";
                case 322: return "YamatoMan Omega defeated";
                case 323: return "Serenade defeated";
                case 324: return "Serenade 'Alpha' defeated (unused)";
                case 325: return "Serenade 'Beta' defeated (unused)";
                case 326: return "Serenade 'Omega' defeated (unused)";
                
                case 327: return "FlashMan Beta cube opened";
                case 328: return "BeastMan Beta cube opened";
                case 329: return "BubbleMan Beta cube opened";
                case 330: return "DesertMan Beta cube opened";
                case 331: return "PlantMan Beta cube opened";
                case 332: return "FlameMan Beta cube opened";
                case 333: return "DrillMan Beta cube opened";
                case 334: return "Let through by Undernet 5 Navi";
                case 335: return "Opened Undernet 6 curtain #1";
                case 336: return "Opened Undernet 6 curtain #2";
                case 337: return "Opened Undernet 6 champion door";
                case 338: return "Let through by Undernet 6 Spikey";
                
                //case 340: return "Set immediately on booting, not always on";
                
                case 345: return "Fed 300+ BugFrags to trader and haven't gotten message";
                case 346: return "Got 300 BugFrags activation message";
                //case 349: return "Cleared by debug scripts for defeating DarkMan and YamatoMan, makes Chaud at Hades Isle say you need experience";
                
                case 353: return "Opened Secret Area all quizzes door";
                case 354: return "Opened Secret Area 140-chip door";
                case 355: return "Opened Secret Area all jobs door";
                case 356: return "Opened Secret Area GigaChip door";
                case 357: return "Opened Secret Area friendly virus door";
                case 358: return "Opened Secret Area all Standard chips door";
                
                case 365: return "Destroyed Secret Area monolith 1";
                case 366: return "Destroyed Secret Area monolith 2";
                case 367: return "Destroyed Secret Area monolith 3";
                case 368: return "Destroyed Secret Area monolith 4";
                case 369: return "Destroyed Secret Area monolith 5";
                case 370: return "Triggers Secret Area monolith 1 battles";
                case 371: return "Triggers Secret Area monolith 2 battles";
                case 372: return "Triggers Secret Area monolith 3 battles";
                case 373: return "Triggers Secret Area monolith 4 battles";
                case 374: return "Triggers Secret Area monolith 5 battles";
                case 375: return "Checking Secret Area monolith 1";
                case 376: return "Checking Secret Area monolith 2";
                case 377: return "Checking Secret Area monolith 3";
                case 378: return "Checking Secret Area monolith 4";
                case 379: return "Checking Secret Area monolith 5";
                
                case 380: return "Defeated Mr. Quiz at Yoka Inn (reward: RegUP3)";
                case 381: return "Defeated Quiz Master behind Yoka bath (reward: HPMemory)";
                case 382: return "Defeated Quiz Queen at hospital";
                case 383: return "Defeated Quiz King at Hades Isle";
                
                case 393: return "Triggers Secret Area security system 1 battles";
                case 394: return "Triggers Secret Area security system 2 battles";
                case 395: return "Triggers Secret Area security system 3 battles";
                case 396: return "Triggers Secret Area security system 4 battles";
                case 397: return "Triggers Secret Area security system 5 battles";
                case 398: return "Triggers Secret Area security system 6 battles";
                
                //case 399: return "Set immediately on booting, not always on";
                case 400: return "Higsby's Chip Order available";
                case 401: return "Told by Higsby about Chip Order being available";
                //case 402: return "Set by 'key command ON'";
                
                case 403: return "Fed 100 BugFrags to Mettaurs in breeder";
                case 404: return "Fed 100 BugFrags to Bunnys in breeder";
                case 405: return "Fed 100 BugFrags to Swordys in breeder";
                case 406: return "Fed 100 BugFrags to Spikeys in breeder";
                case 407: return "Fed 100 BugFrags to Mushys in breeder";
                case 408: return "Fed 100 BugFrags to Jellys in breeder";
                case 409: return "Fed 100 BugFrags to KillerEyes in breeder";
                case 410: return "Fed 100 BugFrags to Momogras in breeder";
                case 411: return "Fed 100 BugFrags to Scuttlests in breeder";
                
                case 416: return "Triggers entering hole to Secret Area";
                case 428: return "Got friendly Bunnys from job";
                case 429: return "Met requirements for BassGS to appear";
                
                case 610: return "Put out ACDC Area fire #1";
                case 611: return "Put out ACDC Area fire #2";
                case 612: return "Put out ACDC Area fire #3";
                case 613: return "Put out ACDC Area fire #4";
                case 614: return "Put out ACDC Area fire #5";
                case 615: return "Put out ACDC Area fire #6";
                case 616: return "Put out ACDC Area fire #7";
                case 617: return "Put out ACDC Area fire #8";
                case 618: return "Put out ACDC Area fire #9";
                case 619: return "Put out SciLab Area fire #1";
                case 620: return "Put out SciLab Area fire #2";
                case 621: return "Put out SciLab Area fire #3";
                case 622: return "Put out SciLab Area fire #4";
                case 623: return "Put out SciLab Area fire #5";
                case 624: return "Put out SciLab Area fire #6";
                case 625: return "Put out Yoka Area fire #1";
                case 626: return "Put out Yoka Area fire #2";
                case 627: return "Put out Yoka Area fire #3";
                case 628: return "Put out Yoka Area fire #4";
                case 629: return "Put out Yoka Area fire #5";
                case 630: return "Put out Yoka Area fire #6";
                case 631: return "Put out Beach Area fire #1";
                case 632: return "Put out Beach Area fire #2";
                case 633: return "Put out Beach Area fire #3";
                case 634: return "Put out Beach Area fire #4";
                case 635: return "Put out Beach Area fire #5";
                case 636: return "Put out Beach Area fire #6";
                
                case 768: return "Went to bed at end of FlashMan day";
                case 769: return "First cutscene ended";
                case 770: return "Intro: Talked to Dex";
                case 771: return "Intro: Talked to Mayl";
                case 772: return "Intro: Talked to Yai";
                case 773: return "Battle tutorial done";
                case 775: return "Makes Lan turn to face Yai";
                case 776: return "Makes Lan jump with surprise";
                case 777: return "Makes Lan turn to face Mayl";
                case 778: return "Makes Dex turn to face others";
                case 779: return "Makes Mayl turn to face Lan";
                case 780: return "Set on entering first tutorial battle";
                case 781: return "Set on entering third tutorial battle";
                case 782: return "Homework-assigning scene done";
                //case 784: return "Some sort of cutscene helper flag";
                //case 786: return "Some sort of cutscene helper flag";
                //case 787: return "Some sort of cutscene helper flag";
                //case 788: return "Some sort of cutscene helper flag";
                case 790: return "Holding O or X data in Prelims Round 1";
                case 791: return "Started Mission 1 in Prelims Round 1";
                case 792: return "Cleared Mission 1 in Prelims Round 1";
                case 793: return "Started Mission 2 in Prelims Round 1";
                case 794: return "Cleared Mission 2 in Prelims Round 1";
                case 795: return "Started Mission 3 in Prelims Round 1";
                case 796: return "Finished Prelims Round 1";
                case 797: return "Picked up O data in Prelims Round 1";
                case 798: return "Picked up X data in Prelims Round 1";
                case 799: return "Talked to Mom after Prelims Round 1";
                case 800: return "Ready for chat at Yai's HP";
                case 801: return "Started chat at Yai's HP";
                case 803: return "Asked to unlock school gate";
                case 807: return "Found Dex's disk";
                case 808: return "Found Dex's disk";
                case 824: return "Friends hypnotized by FlashMan";
                case 828: return "Got the Parasol";
                //case 830: return "Set by Demo 00 17";
                case 831: return "Beat FlashMan";
                case 833: return "Ready for bed at end of FlashMan day";
                
                case 834: return "Virus Lab intro: Talked to email boy";
                case 835: return "Virus Lab intro: Talked to Ms. Mari";
                case 836: return "Virus Lab intro: Talked to Dad-respecting boy";
                case 837: return "Virus Lab intro: Talked to email boy (duplicate)";
                case 838: return "Virus Lab intro: Talked to Regular System boy";
                case 839: return "Virus Lab intro: Talked to L Button girl";
                case 840: return "Virus Lab intro: Talked to inexperienced girl";
                case 841: return "Got SubPet from Dad's lab";
                case 843: return "Talked to Mom after intro";
                
                //case 1025: return "Cutscene helper for end of zoo day?";
                case 1026: return "Talked to Mayl outside Chisao-blocked ACDC Station";
                case 1027: return "Talked to Yai outside Chisao-blocked ACDC Station";
                //case 1032: return "Set by Demo 01 01";
                case 1034: return "Talked to everyone outside Chisao-blocked ACDC Station";
                case 1035: return "Talked to Chisao outside ACDC Station";
                case 1047: return "Beat the Virus King in Prelims Round 2";
                //case 1049: return "Set by Demo 01 09";
                //case 1050: return "Set by Demo 01 0A";
                case 1051: return "Started Mission 3 in Prelims Round 2";
                case 1056: return "Finished Prelims Round 2";
                case 1057: return "Finished scene after Prelims Round 2";
                case 1058: return "Went to bed at end of Prelims Round 2 day";
                
                //case 1063: return "Set by Demo 01 11";
                case 1065: return "Saw waking up cutscene at start of zoo day";
                case 1066: return "Saw cutscene with class outside zoo";
                case 1067: return "Looked at zoo gorillas";
                case 1068: return "Looked at zoo condor";
                case 1069: return "Looked at zoo giraffe";
                case 1070: return "Looked at zoo birds";
                case 1071: return "Looked at zoo parrots";
                case 1072: return "Looked at zoo squirrels";
                case 1073: return "Looked at empty koala cage";
                case 1074: return "Looked at zoo female python";
                case 1075: return "Looked at zoo male python";
                case 1076: return "Looked at zoo elephant";
                case 1077: return "Looked at zoo flamingos";
                case 1082: return "Entered Zoo Comp";
                //case 1083: return "Set by Demo 01 19";
                //case 1084: return "Set by Demo 01 1A";
                case 1180: return "Started NaviCust tutorial";
                case 1181: return "NaviCust tutorial complete";
                case 1182: return "Looked at zoo panda";
                case 1183: return "Talked to Dex at zoo about lunch meetup";
                
                //case 1297: return "Set by Demo 02 03, finished Prelims Round 2?";
                case 1306: return "Finished Prelims Round 3";
                case 1311: return "Went to bed at end of Prelims Round 3 day";
                
                case 1313: return "Saw BubbleMan Press-path cutscene";
                case 1319: return "Talked to Higsby about compression";
                case 1320: return "Got Press program from Cossack";
                case 1328: return "Ready for bed on BubbleMan day";
                case 1330: return "Went to bed at end of BubbleMan day";
                
                case 1546: return "Saw Beach Square TV shoot cutscene";
                case 1551: return "Rescued GutsMan in Beach Area";
                case 1558: return "Delivered DataDisk to Dad's lab";
                case 1559: return "Ready for bed on TV shoot day";
                case 1560: return "Went to bed at end of TV shoot day";
                
                //case 1564: return "Set by Demo 03 0B";
                case 1570: return "Saw NetBattler Q reveal cutscene";
                //case 1585: return "Set by Demo 03 1B";
                case 1586: return "Finished quarter-finals on Hades Isle";
                
                case 1800: return "Asked by Yai to buy tea";
                case 1801: return "Asked by nurse to look for Mamoru";
                case 1802: return "Met Mamoru on beach";
                case 1803: return "Delivered tea to Yai";
                //case 1804: return "Set by Demo 04 07";
                case 1806: return "Came home to Tora visiting";
                case 1807: return "Talked to Tora at house, asked to do jobs";
                case 1808: return "Talked to Tora after finishing jobs";
                case 1810: return "Saw Dex moving cutscene in classroom";
                case 1813: return "Talked to Mamoru on beach (had attack)";
                case 1814: return "Got IceBall M for Mamoru";
                case 1822: return "Went to bed on Mamoru visiting day";
                
                case 1823: return "Talked to Mayl on Dex moving day";
                case 1824: return "Talked to blue-shirt boy on Dex moving day";
                case 1825: return "Talked to Caskett Kids boy on Dex moving day";
                case 1826: return "Talked to orange-shirt boy on Dex moving day";
                case 1827: return "Talked to timely girl on Dex moving day";
                case 1828: return "Talked to unstudious girl on Dex moving day";
                
                case 1830: return "Told doctor about Mamoru's attack";
                case 1832: return "Talked with Mamoru after attack";
                case 1834: return "Learned about Mamoru's emergency operation";
                case 1835: return "Saw cutscene for start of Mamoru's operation";
                //case 1836: return "Set by Demo 04 16";
                case 1837: return "Able to jack in to hospital emergency exit";
                case 1839: return "Opened hospital emergency exit";
                //case 1840: return "Set by Demo 04 1A";
                //case 1849: return "Set by Demo 04 23";
                case 1852: return "Went to bed at end of PlantMan day";
                
                case 1863: return "Finding a friend (Tora): Talked to client";
                case 1864: return "Finding a friend (Tora): Talked to friend's Navi";
                case 1865: return "Finding a friend (Tora): Talked to friend";
                case 1866: return "Stuntmen wanted! (Tora): Talked to client";
                case 1867: return "Stuntmen wanted! (Tora): Triggers viruses";
                case 1868: return "Riot stopping (Tora): Talked to client";
                case 1869: return "Riot stopping (Tora): Fought Navi #1";
                case 1870: return "Riot stopping (Tora): Fought Navi #2";
                case 1871: return "Riot stopping (Tora): Fought Navi #3";
                case 1872: return "Recovering data (Tora): Talked to client";
                case 1873: return "Recovering data (Tora): Traded for data (2)";
                case 1874: return "Recovering data (Tora): Talked to carrier Mr. Prog";
                case 1875: return "Recovering data (Tora): Talked to Navi who found data";
                case 1876: return "Recovering data (Tora): Traded for data";
                
                case 2050: return "Received commendation at Virus Lab";
                case 2051: return "WWW Navis appeared in Yoka 1";
                case 2052: return "Defeated WWW Navis in Yoka Area";
                case 2053: return "Defeated WWW Navis in Beach Area";
                case 2054: return "Defeated WWW Navis in SciLab Area";
                case 2055: return "Talked to weird Navi at ACDC Square";
                case 2056: return "Asked to help Mr. Match";
                case 2057: return "Asked to install HeatData in vending machine";
                case 2058: return "Asked to install FlamData in Dad's lab";
                case 2065: return "Put out all ACDC fires";
                case 2066: return "Put out all SciLab fires";
                case 2067: return "Put out all Yoka fires";
                case 2068: return "Put out all Beach fires";
                case 2070: return "Saw cutscene after putting out all fires";
                case 2076: return "Beat FlameMan";
                case 2079: return "Talked to Cossack in SciLab Station";
                case 2080: return "Defeated WWW Navi #1 in Yoka Area";
                case 2081: return "Defeated WWW Navi #2 in Yoka Area";
                case 2082: return "Defeated WWW Navi #1 in Beach Area";
                case 2083: return "Defeated WWW Navi #2 in Beach Area";
                case 2084: return "Defeated WWW Navi #1 in SciLab Area";
                case 2085: return "Defeated WWW Navi #2 in SciLab Area";
                case 2102: return "Went to bed at end of FLameMan day";
                
                case 2315: return "Saw cutscene with Dad and Sean in hospital";
                case 2316: return "Talked to Chaud about Undernet ranking";
                case 2317: return "Begun Under-ranking challenge";
                //case 2318: return "Set by Demo 06 08";
                case 2319: return "Told clue for finding Rank 10";
                case 2320: return "Got fake Zoo Comp email from Mayl";
                case 2322: return "Told clue for finding Rank 9";
                case 2323: return "Told clue for finding Rank 8";
                case 2324: return "Told clue for finding Rank 7";
                case 2325: return "Told clue for finding Rank 6";
                case 2328: return "Beat CopyMan";
                case 2329: return "Told clue for finding Rank 2";
                //case 2331: return "Set by Demo 06 15";
                //case 2332: return "Set by Demo 06 16";
                //case 2333: return "Set by Demo 06 17";
                case 2349: return "Beat MistMan/BowlMan";
                case 2352: return "Defeated Under-ranking contender #1";
                case 2353: return "Defeated Under-ranking contender #2";
                case 2354: return "Defeated Under-ranking contender #3";
                case 2355: return "Defeated Under-ranking contender #4";
                case 2356: return "Defeated Under-ranking contender #5";
                case 2357: return "Defeated Under-ranking contender #6";
                
                case 2439: return "Talked to hidden girl outside hospital for SpinOrng";
                case 2441: return "Talked to hidden woman at Beach Street shop for SpinPrpl";
                case 2447: return "Talked to hidden Undernet 4 Mr. Prog for SpinDark";
                
                case 2471: return "Talked to Virus Breeder man (enables special virus encounters)";
                //case 2473: return "Set by 'breeding cleared', checked by all-viruses door";
                //case 2474: return "Set by 'breeding cleared', checked by all-viruses door";
                //case 2475: return "Set by 'breeding cleared', checked by all-viruses door";
                //case 2476: return "Set by 'breeding cleared', checked by all-viruses door";
                //case 2477: return "Set by 'breeding cleared', checked by all-viruses door";
                //case 2478: return "Set by 'breeding cleared', checked by all-viruses door";
                //case 2479: return "Set by 'breeding cleared', checked by all-viruses door";
                //case 2480: return "Set by 'breeding cleared', checked by all-viruses door";
                //case 2481: return "Set by 'breeding cleared', checked by all-viruses door";
                //case 2482: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2483: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2484: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2485: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2486: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2487: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2488: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2489: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2490: return "Set by 'all viruses gotten' (alongside 2473-2481) (related to Scuttlest)";
                //case 2491: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2492: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2493: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2494: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2495: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2496: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2497: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2498: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2499: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                //case 2500: return "Set by 'all viruses gotten' (alongside 2473-2481)";
                case 2501: return "Got message about boss from Mettaur Mr. Prog";
                case 2502: return "Got message about boss from Bunny Mr. Prog";
                case 2503: return "Got message about boss from Swordy Mr. Prog";
                case 2504: return "Got message about boss from Spikey Mr. Prog";
                case 2505: return "Got message about boss from Mushy Mr. Prog";
                case 2506: return "Got message about boss from Jelly Mr. Prog";
                case 2507: return "Got message about boss from KillerEye Mr. Prog";
                case 2508: return "Got message about boss from Momogra Mr. Prog";
                case 2509: return "Got message about boss from Scuttlest Mr. Prog";
                
                case 2512: return "Talking to FlashMan time trial Navi";
                case 2513: return "Talking to BeastMan time trial Navi";
                case 2514: return "Talking to BubbleMan time trial Navi";
                case 2515: return "Talking to DesertMan time trial Navi";
                case 2516: return "Talking to PlantMan time trial Navi";
                case 2517: return "Talking to FlameMan time trial Navi";
                case 2518: return "Talking to DrillMan time trial Navi";
                case 2519: return "Talking to GutsMan time trial Navi";
                case 2520: return "Talking to MetalMan time trial Navi";
                case 2521: return "Talking to KingMan time trial Navi";
                case 2522: return "Talking to MistMan/BowlMan time trial Navi";
                case 2523: return "Talking to DarkMan time trial Navi";
                case 2524: return "Talking to YamatoMan time trial Navi";
                case 2525: return "Talking to ProtoMan time trial Navi";
                case 2526: return "Talking to Serenade time trial Navi";
                
                case 2560: return "Game cleared (Star ID)";
                //case 2561: return "Set by 'Demo 00'";
                //case 2562: return "Set by 'Demo 01'";
                case 2563: return "Learned about tank emergency";
                case 2564: return "Encountered AutoTank in ACDC";
                //case 2565: return "Set by 'Demo 04'";
                //case 2566: return "Set by 'Demo 05'";
                //case 2567: return "Set by 'Demo 06'";
                case 2568: return "Learned about location of WWW Base";
                //case 2569: return "Set by 'Demo 08'";
                //case 2570: return "Set by 'Demo 09'";
                //case 2571: return "Set by 'Demo 0A'";
                case 2572: return "Arrived at WWW Base";
                case 2573: return "Learned about Pulse Transmission System";
                //case 2574: return "Set by 'Demo 0D'";
                case 2575: return "Saw cutscene with Cossack using Pulse system";
                //case 2576: return "Set by 'Demo 0F'";
                case 2577: return "WWW Base robot #1 activated";
                //case 2578: return "Set by 'Demo 11'";
                case 2579: return "WWW Base robot #1 stopped";
                //case 2580: return "Set by 'Demo 13'";
                //case 2581: return "Set by 'Demo 14'";
                //case 2582: return "Set by 'Demo 15'";
                case 2583: return "WWW Base robot #2 activated";
                case 2584: return "Beat BubbleMan in WWW Comp 2";
                //case 2585: return "Set by 'Demo 18'";
                case 2586: return "WWW Base robot #2 stopped";
                //case 2587: return "Set by 'Demo 1A'";
                //case 2588: return "Set by 'Demo 1B'";
                case 2589: return "WWW Base robot #3 activated";
                //case 2590: return "Set by 'Demo 1D'";
                //case 2591: return "Set by 'Demo 1E'";
                //case 2592: return "Set by 'Demo 1F'";
                //case 2593: return "Set by 'Demo 20'";
                //case 2594: return "Set by 'Demo 21'";
                case 2595: return "WWW Base robot #4 activated";
                //case 2596: return "Set by 'Demo 23'";
                case 2597: return "WWW Base robot #4 stopped";
                
                case 2608: return "Talked to Dex on AutoTank day";
                case 2609: return "Talked to Mayl on AutoTank day";
                case 2610: return "Talked to Yai on AutoTank day";
                case 2611: return "Showed OfclPass to Metroline worker";
                case 2612: return "Briefly set when trying to enter ACDC Metroline on final days";
                case 2613: return "Fought virus in AutoTank";
                case 2615: return "Checked Beach Street boat after learning about WWW Base";
                case 2616: return "Talked to Yai about the boat engine";
                case 2617: return "Went to bed at end of AutoTank day";
                
                case 2618: return "Checked heavy Wily statue";
                //case 2625: return "Some sort of cutscene helper flag";
                //case 2626: return "Some sort of cutscene helper flag";
                //case 2627: return "Some sort of cutscene helper flag";
                //case 2628: return "Some sort of cutscene helper flag";
                //case 2629: return "Some sort of cutscene helper flag";
                //case 2630: return "Makes Mom face Dad in ending scenes";
                case 2640: return "Took WWW Base elevator down";
                
                case 2656: return "Please deliver this: Talked to client";
                case 2657: return "My Navi is sick: Talked to client";
                case 2658: return "Transfer mishap: Triggers virus battle";
                case 2660: return "Transfer mishap: Talked to client";
                case 2661: return "Chip prices: Talked to client";
                case 2662: return "I'm broke...!: Talked to client";
                case 2665: return "Will you deliver?: Talked to client";
                case 2666: return "Somebody, please help!: Talked to client";
                case 2667: return "Somebody, please help!: Activated virus bomb #1";
                case 2668: return "Somebody, please help!: Activated virus bomb #2";
                case 2669: return "Somebody, please help!: Activated virus bomb #3";
                case 2673: return "Looking for condor: Talked to client";
                case 2674: return "Looking for condor: Talked to handler old man";
                case 2675: return "Help with rehab: Triggers virus battle";
                case 2676: return "Help with rehab: Beat viruses";
                case 2677: return "My old master: Talked to client";
                case 2678: return "Catching gang members: Talked to client";
                case 2679: return "Adopt stray viruses!: Talked to client";
                case 2680: return "Legendary tomes: Talked to client";
                case 2681: return "Hide and seek!: Talked to client";
                case 2682: return "Seeking the blue Navi: Triggers virus battle";
                case 2684: return "Give your support!: Triggers virus battle";
                case 2685: return "Stamp contest: Talked to client";
                case 2686: return "Be my boyfriend!: Talked to client";
                
                case 2697: return "Opened ID-DataA door in WWW Comp 1";
                case 2698: return "Opened ID-DataB door in WWW Comp 2";
                case 2699: return "Opened ID-DataC door in WWW Comp 3";
                case 2700: return "Opened ID-DataD door in WWW Comp 4";
                
                case 2709: return "Please deliver this: Got OldTools";
                case 2711: return "Help me with my son!: Talked to client";
                case 2712: return "Help me with my son!: Triggers virus battle";
                case 2713: return "Transfer mishap: Talked to client";
                case 2714: return "Transfer mishap: Found virus";
                case 2715: return "Chip prices: Talked to client";
                case 2716: return "Chip prices: Talked to brother first time";
                case 2717: return "Chip prices: Talked to client second time";
                case 2718: return "Chip prices: Talked to brother second time";
                case 2719: return "I'm broke...!: Talked to client about lost Navi";
                case 2720: return "I'm broke...!: Back after giving money";
                case 2721: return "I'm broke...!: Triggers virus battle";
                case 2722: return "I'm broke...!: Gave money to client";
                case 2723: return "Rare chip for cheap!: Triggers virus battle";
                case 2724: return "Be my boyfriend!: Triggers virus battle #1";
                case 2725: return "Be my boyfriend!: Triggers virus battle #2";
                case 2726: return "Be my boyfriend!: Finished normally";
                case 2729: return "Will you deliver?: Delivered first chip to businessman";
                case 2730: return "Will you deliver?: Talked to client after first delivery";
                case 2731: return "Will you deliver?: Delivered correct chip to Navi";
                case 2732: return "Somebody, please help!: Talked to client";
                case 2733: return "Somebody, please help!: Disabled virus bomb #1";
                case 2734: return "Somebody, please help!: Disabled virus bomb #2";
                case 2735: return "Somebody, please help!: Disabled virus bomb #3";
                case 2736: return "Looking for condor: Talked to client";
                case 2737: return "Looking for condor: Placed doll in park";
                case 2738: return "Looking for condor: Back after placing doll";
                case 2739: return "Looking for condor: Caught condor";
                case 2740: return "My old master: Talked to client";
                case 2742: return "My old master: Checked yearbook";
                case 2743: return "My old master: Talked to Anna";
                case 2744: return "Catching gang members: Talked to client";
                case 2745: return "Catching gang members: Fought Navi #1";
                case 2746: return "Catching gang members: Fought Navi #2";
                case 2747: return "Catching gang members: Fought Navi #3";
                case 2748: return "Catching gang members: Fought Navi #4";
                case 2749: return "Catching gang members: Fought all Navis";
                case 2750: return "Legendary tomes: Talked to client";
                case 2751: return "Legendary tomes: Talked to SkyTome Navi";
                case 2752: return "Legendary tomes: Talked to LandTome Navi";
                case 2753: return "Legendary tomes: Triggers SeaTome battle";
                case 2756: return "Hide and seek!: Talked to client";
                case 2757: return "Hide and seek!: Found Navi #1";
                case 2758: return "Hide and seek!: Found Navi #2";
                case 2759: return "Hide and seek!: Found Navi #3";
                case 2760: return "Hide and seek!: Found Navi #4";
                case 2762: return "Stamp contest: Talked to client";
                case 2763: return "Stamp contest: Obtained stamp card";
                case 2764: return "Stamp contest: Got SciLab stamp";
                case 2765: return "Stamp contest: Got Yoka stamp";
                case 2766: return "Stamp contest: Got Beach stamp";
                case 2767: return "Stamp contest: Showed completed card";
                case 2768: return "Be my boyfriend!: Talked to client";
                case 2769: return "Mysterious will: Checked cyber squirrel";
                case 2770: return "Mysterious will: Checked armor";
                case 2771: return "Mysterious will: Checked water heater";
                case 2772: return "Mysterious will: Checked gargoyle";
                case 2773: return "Mysterious will: Checked cyber squirrel";
                case 2774: return "Mysterious will: Checked armor";
                case 2775: return "Mysterious will: Checked water heater";
                case 2776: return "Mysterious will: Checked gargoyle";
                case 2777: return "Mysterious will: Checked top of pillar";
                
                //case 2778: return "Set immediately on booting";
                //case 2780: return "Set immediately on booting, not always on";
                //case 2781: return "Set immediately on booting";
                //case 2782: return "Set immediately on booting, not always on";
                //case 2783: return "Set immediately on booting";
                
                // 2816-3219: Shared Data Library flags
                
                case 3328: return "BMD: ACDC Area 1 WideSwrd L";
                case 3329: return "BMD: ACDC Area 1 MiniEnrg";
                case 3330: return "PMD: ACDC Area 1 Panic C";
                case 3331: return "GMD: ACDC Area 1";
                case 3332: return "GMD: ACDC Area 1";
                case 3336: return "BMD: ACDC Area 2 CopyDmg *";
                case 3337: return "BMD: ACDC Area 2 800 Zennys";
                case 3338: return "GMD: ACDC Area 2";
                case 3339: return "GMD: ACDC Area 2";
                case 3344: return "BMD: ACDC Area 3 LongSwrd E";
                case 3345: return "BMD: ACDC Area 3 PanlOut3 *";
                case 3346: return "GMD: ACDC Area 3";
                case 3347: return "GMD: ACDC Area 3";
                case 3393: return "BMD: SciLab Area 1 CustSwrd Z";
                case 3394: return "GMD: SciLab Area 1";
                case 3395: return "GMD: SciLab Area 1";
                case 3392: return "BMD: SciLab Area 1 Invis *";
                case 3400: return "BMD: SciLab Area 2 RegUP2";
                case 3401: return "BMD: SciLab Area 2 GrabBack A";
                case 3402: return "GMD: SciLab Area 2";
                case 3403: return "GMD: SciLab Area 2";
                case 3456: return "BMD: Yoka Area 1 Speed+1";
                case 3457: return "PMD: Yoka Area 1 Tornado L";
                case 3458: return "BMD: Yoka Area 1 Prism Q";
                case 3459: return "GMD: Yoka Area 1";
                case 3460: return "GMD: Yoka Area 1";
                case 3464: return "BMD: Yoka Area 2 FullEnrg";
                case 3465: return "BMD: Yoka Area 2 HPMemory";
                case 3466: return "GMD: Yoka Area 2";
                case 3467: return "GMD: Yoka Area 2";
                case 3520: return "BMD: Beach Area 1 Charge+1";
                case 3521: return "PMD: Beach Area 1 SpinPink";
                case 3522: return "GMD: Beach Area 1";
                case 3523: return "GMD: Beach Area 1";
                case 3528: return "BMD: Beach Area 2 Recov50 G";
                case 3529: return "BMD: Beach Area 2 RegUP3";
                case 3530: return "GMD: Beach Area 2";
                case 3531: return "GMD: Beach Area 2";
                case 3544: return "Item: Hades Isle VictData";
                case 3545: return "BMD: Hades Isle HadesKey";
                case 3546: return "BMD: Hades Isle BlkBomb1 P";
                case 3547: return "GMD: Hades Isle";
                case 3548: return "GMD: Hades Isle";
                case 3584: return "BMD: Undernet 1 1200 Zennys";
                case 3585: return "BMD: Undernet 1 HP+200";
                case 3586: return "GMD: Undernet 1";
                case 3587: return "GMD: Undernet 1";
                case 3592: return "BMD: Undernet 2 RegUP2";
                case 3593: return "BMD: Undernet 2 BlkBomb2 S";
                case 3594: return "GMD: Undernet 2";
                case 3595: return "GMD: Undernet 2";
                case 3600: return "BMD: Undernet 3 HPMemory";
                case 3601: return "BMD: Undernet 3 Lance S";
                case 3602: return "GMD: Undernet 3";
                case 3603: return "GMD: Undernet 3";
                case 3608: return "BMD: Undernet 4 Speed+1";
                case 3609: return "BMD: Undernet 4 Recov200 N";
                case 3610: return "BMD: Undernet 4 StepSwrd M";
                case 3611: return "GMD: Undernet 4";
                case 3612: return "GMD: Undernet 4";
                case 3616: return "BMD: Undernet 5 HPMemory";
                case 3617: return "BMD: Undernet 5 SandStge C";
                case 3618: return "GMD: Undernet 5";
                case 3619: return "GMD: Undernet 5";
                case 3624: return "BMD: Undernet 6 SubMem";
                case 3625: return "BMD: Undernet 6 Aura F";
                case 3626: return "BMD: Undernet 6 WeapLV+1";
                case 3627: return "GMD: Undernet 6";
                case 3628: return "GMD: Undernet 6";
                case 3632: return "BMD: Undernet 7 GutImpct J";
                case 3633: return "BMD: Undernet 7 HPMemory";
                case 3634: return "BMD: Undernet 7 Guardian O";
                case 3635: return "PMD: Undernet 7 GigFldr1";
                case 3636: return "GMD: Undernet 7";
                case 3637: return "GMD: Undernet 7";
                case 3638: return "GMD: Undernet 7";
                case 3639: return "BMD: Undernet 7 Hammer";
                case 3712: return "BMD: Secret Area 1 Geddon3 U";
                case 3713: return "BMD: Secret Area 1 StepCros R";
                case 3714: return "BMD: Secret Area 1 50000 Zennys";
                case 3715: return "GMD: Secret Area 1";
                case 3716: return "GMD: Secret Area 1";
                case 3720: return "BMD: Secret Area 2 HP+500";
                case 3721: return "BMD: Secret Area 2 AntiNavi M";
                case 3722: return "BMD: Secret Area 2 HPMemory";
                case 3723: return "GMD: Secret Area 2";
                case 3724: return "GMD: Secret Area 2";
                case 3728: return "BMD: Secret Area 3 Hole *";
                case 3729: return "BMD: Secret Area 3 Sanctuary C";
                case 3730: return "BMD: Secret Area 3 HubBatch";
                case 3731: return "GMD: Secret Area 3";
                case 3732: return "GMD: Secret Area 3";
                case 3776: return "BMD: Principal's PC 1 KeydataA";
                case 3777: return "BMD: Principal's PC 1 KeydataB";
                case 3778: return "BMD: Principal's PC 1 KeydataC";
                case 3779: return "Principal's PC 1 intruder ejection #1";
                case 3780: return "Principal's PC 1 intruder ejection #2";
                case 3781: return "BMD: Principal's PC 1 600 Zennys";
                case 3782: return "BMD: Principal's PC 1 RegUP1";
                case 3783: return "BMD: Principal's PC 1 Recov10 *";
                case 3784: return "BMD: Principal's PC 2 PasswrdA";
                case 3785: return "BMD: Principal's PC 2 PasswrdB";
                case 3786: return "BMD: Principal's PC 2 PasswrdC";
                case 3787: return "Principal's PC 2 intruder ejection #1";
                case 3788: return "Principal's PC 2 intruder ejection #2";
                case 3789: return "BMD: Principal's PC 2 1200 Zennys";
                case 3790: return "BMD: Principal's PC 2 Spreader P";
                case 3791: return "BMD: Principal's PC 2 HPMemory";
                case 3840: return "BMD: Zoo Comp 1 1000 Zennys";
                case 3841: return "BMD: Zoo Comp 1 HPMemory";
                case 3842: return "BMD: Zoo Comp 1 Geddon1 D";
                case 3848: return "BMD: Zoo Comp 2 600 Zennys";
                case 3849: return "BMD: Zoo Comp 2 Charge+1";
                case 3850: return "BMD: Zoo Comp 2 CopyDmg *";
                case 3856: return "BMD: Zoo Comp 3 Recov30 *";
                case 3857: return "BMD: Zoo Comp 3 800 Zennys";
                case 3858: return "BMD: Zoo Comp 3 SneakRun";
                case 3859: return "BMD: Zoo Comp 3 Cannon C";
                case 3864: return "BMD: Zoo Comp 4 Hammer T";
                case 3865: return "BMD: Zoo Comp 4 RegUP2";
                case 3866: return "BMD: Zoo Comp 4 HP+100";
                case 3904: return "BMD: Hospital Comp 1 OilBody";
                case 3905: return "BMD: Hospital Comp 1 RegUP1";
                case 3906: return "BMD: Hospital Comp 1 Recov120 O";
                case 3912: return "BMD: Hospital Comp 2 Atk+1";
                case 3913: return "BMD: Hospital Comp 2 HPMemory";
                case 3914: return "BMD: Hospital Comp 2 GutStrgt Q";
                case 3920: return "BMD: Hospital Comp 3 HeatSide T";
                case 3921: return "BMD: Hospital Comp 3 1600 Zennys";
                case 3922: return "BMD: Hospital Comp 3 SubMem";
                case 3928: return "BMD: Hospital Comp 4 FullEnrg";
                case 3929: return "BMD: Hospital Comp 4 Barr100 E";
                case 3930: return "BMD: Hospital Comp 4 2000 Zennys";
                case 3936: return "BMD: Hospital Comp 5 FireSwrd R";
                case 3937: return "BMD: Hospital Comp 5 HPMemory";
                case 3938: return "BMD: Hospital Comp 5 Charge+1";
                case 3968: return "BMD: WWW Comp 1 ID-DataA";
                case 3969: return "BMD: WWW Comp 1 1800 Zennys";
                case 3970: return "BMD: WWW Comp 1 Recov150 P";
                case 3971: return "BMD: WWW Comp 1 HPMemory";
                case 3976: return "BMD: WWW Comp 2 ID-DataB";
                case 3977: return "BMD: WWW Comp 2 RegUP2";
                case 3978: return "BMD: WWW Comp 2 3000 Zennys";
                case 3984: return "BMD: WWW Comp 3 ID-DataC";
                case 3985: return "BMD: WWW Comp 3 Jungle";
                case 3986: return "BMD: WWW Comp 3 FullEnrg";
                case 3992: return "BMD: WWW Comp 4 ID-DataD";
                case 3993: return "BMD: WWW Comp 4 HPMemory";
                case 3994: return "BMD: WWW Comp 4 1400 Zennys";
                case 4168: return "BMD: Mayl's HP 500 Zennys";
                case 4169: return "PMD: Mayl's HP HPMemory";
                case 4176: return "BMD: Dex's HP 200 Zennys";
                case 4177: return "BMD: Dex's HP GutPunch B";
                case 4184: return "BMD: Yai's HP SideGun S";
                case 4185: return "BMD: Yai's HP RegUP2";
                case 4192: return "BMD: Tamako's HP 900 Zennys";
                case 4193: return "PMD: Tamako's HP Snake D";
                case 4208: return "VirusChip: Mettaur T";
                case 4209: return "VirusChip: Bunny R";
                case 4210: return "VirusChip: Swordy W";
                case 4211: return "VirusChip: Spikey E";
                case 4212: return "VirusChip: Mushy H";
                case 4213: return "VirusChip: Jelly Y";
                case 4214: return "VirusChip: KillrEye K";
                case 4215: return "VirusChip: Momogra G";
                case 4216: return "VirusChip: Scuttlst A";
                case 4224: return "BMD: Doghouse Comp Barrier L";
                case 4228: return "BMD: Blackboard Comp RegUP1";
                case 4232: return "BMD: SciLab Vending Comp RegUP2";
                case 4236: return "BMD: SciLab Dad's Lab Computer 1000 Zennys";
                case 4237: return "PMD: SciLab Dad's Lab Computer BambSwrd N";
                case 4244: return "BMD: School Server Comp RockCube *";
                case 4245: return "BMD: School Server Comp HPMemory";
                case 4248: return "BMD: Relay Comp HP+100";
                case 4252: return "BMD: NetBattle Comp FireRatn H";
                case 4256: return "PMD: TV Board Comp Atk+1";
                case 4257: return "BMD: TV Board Comp RegUP1";
                case 4260: return "BMD: Phone Comp Repair A";
                case 4264: return "BMD: Hospital TV Comp Recov120 *";
                case 4268: return "BMD: Hospital Bed Comp RegUP2";
                case 4272: return "BMD: Hospital Vending Comp 9000 Zennys";
                case 4276: return "BMD: Ticket Comp RegUP1";
                case 4280: return "BMD: Tank Comp HPMemory";
                case 4281: return "BMD: Tank Comp RegUP2";
                case 4284: return "BMD: Old TV Comp Unlocker";
                case 4288: return "BMD: Armor Comp SubMem";
                case 4292: return "BMD: Higsby's Sign Comp HPMemory";
                case 4296: return "BMD: Alarm Comp RegUP1";
                case 4297: return "PMD: Alarm Comp Geyser B";
                case 4300: return "BMD: Door Sensor Comp AirShoes *";
                case 4301: return "BMD: Door Sensor Comp 700 Zennys";
                case 4304: return "BMD: Wall Comp Collect";
                case 4312: return "BMD: Education Comp StepSwrd N";
                case 4314: return "BMD: Bath Lion Comp Fire+30 *";
                case 4316: return "BMD: Demon Statue Comp WeapLV+1";
                case 4318: return "BMD: Editing Comp HPMemory";
                case 4319: return "PMD: Editing Comp Jealousy J";
                
                case 4320: return "Inn Guest Room jar RegUP1";
                case 4321: return "Class 5-B bookshelf RegUP2";
                case 4322: return "TV Station Hall 1 props RegUP1";
                case 4323: return "Hades Isle boat ramp crab HPMemory";
                case 4324: return "SciLab Station trash can RegUP1";
                case 4325: return "Seaside Hospital monument plaque RegUP2";
                case 4326: return "Hospital 3F Tree of Life HPMemory";
                case 4327: return "ACDC Staff Lounge teachers' desks RegUP1";
                case 4328: return "TV Station Editing Room schedules RegUP2";
                case 4329: return "WWW Base Monitor Room cables RegUP2";
                case 4330: return "Used Humor with Yoka comedian Navi for Team1 *";
                case 4331: return "Used DarkMind with Beach Square bad-guy actor for Team2 *";
                case 4332: return "Yoka Zoo garbage Repair *";
                case 4333: return "Beach Hospital 1F door Geddon1 *";
                case 4334: return "WWW Base keyboard Magnum1 V";
                case 4336: return "TV Station zoo employee BrakChrg";
                case 4337: return "ACDC Staff Lounge tomes secret 300000 Zennys";
                
                // 4352-4394: Emails
                // 4480-4522: Emails unread
                
                // 4608-4687: Deactivating various map objects
                
                case 4688: return "Disables warp activation, used for Cyberworld warp animation";
                case 4691: return "PET menu open";
                //case 4693: return "Set then quickly cleared when entering Cyberworld in intro";
                //case 4695: return "Set on entering first tutorial battle";
                case 4694: return "Show mugshot in textbox, locks movement if false";
                case 4699: return "Show countdown timer";
                case 4700: return "Used in can't-jack-in cases to abort jack-in after box closes";
                case 4701: return "Have MegaMan with you";
                case 4702: return "Game is Blue version";
                case 4703: return "Unlocker subchip being used";
                case 4704: return "Untrap subchip active";
                case 4705: return "SneakRun subchip active";
                case 4706: return "LocEnemy subchip active";
                case 4709: return "Showing chip obtained from trader";
                case 4710: return "Game has been saved once";
                case 4711: return "Used BugFrag Trader";
                //case 4712: return "Set to false when checking BBS, unsure what sets it to true (not related to new-messages message)";
                case 4713: return "Talking to time trial Navi";
                case 4714: return "MegaMan on his own";
                
                // The following flags seem to only change on map change, so likely no practical reason to change these in save, but...
                //case 4720: return "Related to presence of position-trigger cutscene, even after it happens? Or presence of Dex??";
                //case 4721: return "Related to presence of position-trigger cutscene and/or story-advancing NPC?";
                //case 4722: return "True in SciLab Lobby, TV Station Hall 1, Hospital Lobby";
                //case 4723: return "True in ACDC outdoors";
                //case 4724: return "Set on first exiting school into ACDC, cleared on entering Lan's house";
                //case 4725: return "Set on first exiting school into ACDC, cleared on entering Lan's house";
                //case 4726: return "Set on first exiting school into ACDC, cleared on entering Lan's house";
                //case 4734: return "Thought it was for being on a homepage, but checking again, that doesn't seem true at all...?";
                
                // 4736-5247: BBS posts
                // 5248-5759: BBS posts unread
                // 5760-5784: Job complete
                // 5824-5848: Job taken
            }
            return "";
        }
        
        // BN3 exclusive
        public static string getErrorCodeName(int error, bool withAssociation = true)
        {
            string result = error < errorCodeNames.Length? errorCodeNames[error] : "";
            if (result != "")
            {
                string association = withAssociation && error < errorCodeAssociations.Length? errorCodeAssociations[error] : "";
                return result + (association != ""? " (" + association + ")" : "");
            }
            return "";
        }
    }
}
