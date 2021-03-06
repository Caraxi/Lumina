using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WeaponTimeline", columnHash: 0x9ab94c53 )]
    public class WeaponTimeline : IExcelRow
    {
        
        public string File;
        public short NextWeaponTimeline;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            File = parser.ReadColumn< string >( 0 );
            NextWeaponTimeline = parser.ReadColumn< short >( 1 );
        }
    }
}