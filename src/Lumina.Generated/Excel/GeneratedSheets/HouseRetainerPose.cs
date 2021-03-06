using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HouseRetainerPose", columnHash: 0xd870e208 )]
    public class HouseRetainerPose : IExcelRow
    {
        
        public LazyRow< ActionTimeline > ActionTimeline;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ActionTimeline = new LazyRow< ActionTimeline >( lumina, parser.ReadColumn< ushort >( 0 ) );
        }
    }
}