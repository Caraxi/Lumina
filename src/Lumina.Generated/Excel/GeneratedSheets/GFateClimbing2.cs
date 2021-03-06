using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GFateClimbing2", columnHash: 0xdbf43666 )]
    public class GFateClimbing2 : IExcelRow
    {
        
        public uint ContentEntry;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ContentEntry = parser.ReadColumn< uint >( 0 );
        }
    }
}