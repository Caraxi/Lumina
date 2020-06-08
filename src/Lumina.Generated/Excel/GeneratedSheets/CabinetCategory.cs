using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CabinetCategory", columnHash: 0xc6207018 )]
    public class CabinetCategory : IExcelRow
    {
        
        public byte MenuOrder;
        public int Icon;
        public LazyRow< Addon > Category;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            MenuOrder = parser.ReadColumn< byte >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Category = new LazyRow< Addon >( lumina, parser.ReadColumn< int >( 2 ) );
        }
    }
}