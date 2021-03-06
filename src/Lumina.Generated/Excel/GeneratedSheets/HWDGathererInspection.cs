using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDGathererInspection", columnHash: 0x79936cf0 )]
    public class HWDGathererInspection : IExcelRow
    {
        
        public LazyRow< GatheringItem >[] ItemRequired;
        public LazyRow< FishParameter >[] FishParameter;
        public byte[] AmountRequired;
        public LazyRow< Item >[] ItemReceived;
        public LazyRow< HWDGathererInspectionReward >[] Reward1;
        public LazyRow< HWDGathererInspectionReward >[] Reward2;
        public LazyRow< HWDGathereInspectTerm >[] Phase;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ItemRequired = new LazyRow< GatheringItem >[ 32 ];
            for( var i = 0; i < 32; i++ )
                ItemRequired[ i ] = new LazyRow< GatheringItem >( lumina, parser.ReadColumn< uint >( 0 + i ) );
            FishParameter = new LazyRow< FishParameter >[ 32 ];
            for( var i = 0; i < 32; i++ )
                FishParameter[ i ] = new LazyRow< FishParameter >( lumina, parser.ReadColumn< uint >( 32 + i ) );
            AmountRequired = new byte[ 32 ];
            for( var i = 0; i < 32; i++ )
                AmountRequired[ i ] = parser.ReadColumn< byte >( 64 + i );
            ItemReceived = new LazyRow< Item >[ 32 ];
            for( var i = 0; i < 32; i++ )
                ItemReceived[ i ] = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 96 + i ) );
            Reward1 = new LazyRow< HWDGathererInspectionReward >[ 32 ];
            for( var i = 0; i < 32; i++ )
                Reward1[ i ] = new LazyRow< HWDGathererInspectionReward >( lumina, parser.ReadColumn< ushort >( 128 + i ) );
            Reward2 = new LazyRow< HWDGathererInspectionReward >[ 32 ];
            for( var i = 0; i < 32; i++ )
                Reward2[ i ] = new LazyRow< HWDGathererInspectionReward >( lumina, parser.ReadColumn< ushort >( 160 + i ) );
            Phase = new LazyRow< HWDGathereInspectTerm >[ 32 ];
            for( var i = 0; i < 32; i++ )
                Phase[ i ] = new LazyRow< HWDGathereInspectTerm >( lumina, parser.ReadColumn< byte >( 192 + i ) );
        }
    }
}