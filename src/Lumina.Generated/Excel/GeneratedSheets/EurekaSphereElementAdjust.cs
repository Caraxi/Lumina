using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaSphereElementAdjust", columnHash: 0xd870e208 )]
    public class EurekaSphereElementAdjust : IExcelRow
    {
        
        public ushort PowerModifier;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            PowerModifier = parser.ReadColumn< ushort >( 0 );
        }
    }
}