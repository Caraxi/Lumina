using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Salvage", columnHash: 0xd870e208 )]
    public class Salvage : IExcelRow
    {
        
        public ushort OptimalSkill;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            OptimalSkill = parser.ReadColumn< ushort >( 0 );
        }
    }
}