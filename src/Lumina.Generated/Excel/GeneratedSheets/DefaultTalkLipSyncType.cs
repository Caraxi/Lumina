using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DefaultTalkLipSyncType", columnHash: 0xda365c51 )]
    public class DefaultTalkLipSyncType : IExcelRow
    {
        
        public LazyRow< ActionTimeline > ActionTimeline;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ActionTimeline = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< int >( 0 ) );
        }
    }
}