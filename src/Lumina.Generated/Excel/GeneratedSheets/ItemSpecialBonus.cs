using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemSpecialBonus", columnHash: 0xdebb20e3 )]
    public class ItemSpecialBonus : IExcelRow
    {
        
        public string Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
        }
    }
}