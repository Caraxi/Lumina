using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZContentBriefingBNpc", columnHash: 0xfc0810d7 )]
    public class AOZContentBriefingBNpc : IExcelRow
    {
        
        public LazyRow< BNpcName > BNpcName;
        public uint TargetSmall;
        public uint TargetLarge;
        public bool Unknown3;
        public byte Endurance;
        public byte Fire;
        public byte Ice;
        public byte Wind;
        public byte Earth;
        public byte Thunder;
        public byte Water;
        public byte Slashing;
        public byte Piercing;
        public byte Blunt;
        public byte Magic;
        public bool SlowResistance;
        public bool PetrificationResistance;
        public bool ParalysisResistance;
        public bool SilenceResistance;
        public bool BlindResistance;
        public bool StunResistance;
        public bool SleepResistance;
        public bool BindResistance;
        public bool HeavyResistance;
        public bool InstaDeathResistance;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            BNpcName = new LazyRow< BNpcName >( lumina, parser.ReadColumn< uint >( 0 ) );
            TargetSmall = parser.ReadColumn< uint >( 1 );
            TargetLarge = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Endurance = parser.ReadColumn< byte >( 4 );
            Fire = parser.ReadColumn< byte >( 5 );
            Ice = parser.ReadColumn< byte >( 6 );
            Wind = parser.ReadColumn< byte >( 7 );
            Earth = parser.ReadColumn< byte >( 8 );
            Thunder = parser.ReadColumn< byte >( 9 );
            Water = parser.ReadColumn< byte >( 10 );
            Slashing = parser.ReadColumn< byte >( 11 );
            Piercing = parser.ReadColumn< byte >( 12 );
            Blunt = parser.ReadColumn< byte >( 13 );
            Magic = parser.ReadColumn< byte >( 14 );
            SlowResistance = parser.ReadColumn< bool >( 15 );
            PetrificationResistance = parser.ReadColumn< bool >( 16 );
            ParalysisResistance = parser.ReadColumn< bool >( 17 );
            SilenceResistance = parser.ReadColumn< bool >( 18 );
            BlindResistance = parser.ReadColumn< bool >( 19 );
            StunResistance = parser.ReadColumn< bool >( 20 );
            SleepResistance = parser.ReadColumn< bool >( 21 );
            BindResistance = parser.ReadColumn< bool >( 22 );
            HeavyResistance = parser.ReadColumn< bool >( 23 );
            InstaDeathResistance = parser.ReadColumn< bool >( 24 );
        }
    }
}