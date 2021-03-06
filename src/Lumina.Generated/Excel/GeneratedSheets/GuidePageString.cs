using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuidePageString", columnHash: 0xdebb20e3 )]
    public class GuidePageString : IExcelRow
    {
        
        public string String;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            String = parser.ReadColumn< string >( 0 );
        }
    }
}