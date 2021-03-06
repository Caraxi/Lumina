using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ClassJob", columnHash: 0xc6d83eda )]
    public class ClassJob : IExcelRow
    {
        
        public string Name;
        public string Abbreviation;
        public string Unknown2;
        public LazyRow< ClassJobCategory > ClassJobCategory;
        public sbyte ExpArrayIndex;
        public sbyte BattleClassIndex;
        public byte Unknown6;
        public byte JobIndex;
        public sbyte Unknown8;
        public ushort ModifierHitPoints;
        public ushort ModifierManaPoints;
        public ushort ModifierStrength;
        public ushort ModifierVitality;
        public ushort ModifierDexterity;
        public ushort ModifierIntelligence;
        public ushort ModifierMind;
        public ushort ModifierPiety;
        public ushort Unknown17;
        public ushort Unknown18;
        public ushort Unknown19;
        public ushort Unknown20;
        public ushort Unknown21;
        public ushort Unknown22;
        public byte Unknown23;
        public byte Unknown24;
        public byte Unknown25;
        public LazyRow< ClassJob > ClassJobParent;
        public string NameEnglish;
        public LazyRow< Item > ItemStartingWeapon;
        public int Unknown29;
        public byte Role;
        public LazyRow< Town > StartingTown;
        public LazyRow< MonsterNote > MonsterNote;
        public byte PrimaryStat;
        public LazyRow< Action > LimitBreak1;
        public LazyRow< Action > LimitBreak2;
        public LazyRow< Action > LimitBreak3;
        public byte UIPriority;
        public LazyRow< Item > ItemSoulCrystal;
        public LazyRow< Quest > UnlockQuest;
        public LazyRow< Quest > RelicQuest;
        public LazyRow< Quest > Prerequisite;
        public byte StartingLevel;
        public byte PartyBonus;
        public bool IsLimitedJob;
        public bool CanQueueForDuty;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Abbreviation = parser.ReadColumn< string >( 1 );
            Unknown2 = parser.ReadColumn< string >( 2 );
            ClassJobCategory = new LazyRow< ClassJobCategory >( lumina, parser.ReadColumn< byte >( 3 ) );
            ExpArrayIndex = parser.ReadColumn< sbyte >( 4 );
            BattleClassIndex = parser.ReadColumn< sbyte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            JobIndex = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< sbyte >( 8 );
            ModifierHitPoints = parser.ReadColumn< ushort >( 9 );
            ModifierManaPoints = parser.ReadColumn< ushort >( 10 );
            ModifierStrength = parser.ReadColumn< ushort >( 11 );
            ModifierVitality = parser.ReadColumn< ushort >( 12 );
            ModifierDexterity = parser.ReadColumn< ushort >( 13 );
            ModifierIntelligence = parser.ReadColumn< ushort >( 14 );
            ModifierMind = parser.ReadColumn< ushort >( 15 );
            ModifierPiety = parser.ReadColumn< ushort >( 16 );
            Unknown17 = parser.ReadColumn< ushort >( 17 );
            Unknown18 = parser.ReadColumn< ushort >( 18 );
            Unknown19 = parser.ReadColumn< ushort >( 19 );
            Unknown20 = parser.ReadColumn< ushort >( 20 );
            Unknown21 = parser.ReadColumn< ushort >( 21 );
            Unknown22 = parser.ReadColumn< ushort >( 22 );
            Unknown23 = parser.ReadColumn< byte >( 23 );
            Unknown24 = parser.ReadColumn< byte >( 24 );
            Unknown25 = parser.ReadColumn< byte >( 25 );
            ClassJobParent = new LazyRow< ClassJob >( lumina, parser.ReadColumn< byte >( 26 ) );
            NameEnglish = parser.ReadColumn< string >( 27 );
            ItemStartingWeapon = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 28 ) );
            Unknown29 = parser.ReadColumn< int >( 29 );
            Role = parser.ReadColumn< byte >( 30 );
            StartingTown = new LazyRow< Town >( lumina, parser.ReadColumn< byte >( 31 ) );
            MonsterNote = new LazyRow< MonsterNote >( lumina, parser.ReadColumn< sbyte >( 32 ) );
            PrimaryStat = parser.ReadColumn< byte >( 33 );
            LimitBreak1 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 34 ) );
            LimitBreak2 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 35 ) );
            LimitBreak3 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 36 ) );
            UIPriority = parser.ReadColumn< byte >( 37 );
            ItemSoulCrystal = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 38 ) );
            UnlockQuest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 39 ) );
            RelicQuest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 40 ) );
            Prerequisite = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 41 ) );
            StartingLevel = parser.ReadColumn< byte >( 42 );
            PartyBonus = parser.ReadColumn< byte >( 43 );
            IsLimitedJob = parser.ReadColumn< bool >( 44 );
            CanQueueForDuty = parser.ReadColumn< bool >( 45 );
        }
    }
}