using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuickChatTransient", columnHash: 0xdebb20e3 )]
    public class QuickChatTransient : IExcelRow
    {
        
        public string TextOutput;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            TextOutput = parser.ReadColumn< string >( 0 );
        }
    }
}