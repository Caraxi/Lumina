using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCProfile", columnHash: 0x5eb59ccb )]
    public class FCProfile : IExcelRow
    {
        
        public byte Priority;
        public string Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Priority = parser.ReadColumn< byte >( 0 );
            Name = parser.ReadColumn< string >( 1 );
        }
    }
}