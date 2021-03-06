using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CustomTalkDynamicIcon", columnHash: 0x5d58cc84 )]
    public class CustomTalkDynamicIcon : IExcelRow
    {
        
        public uint SmallIcon;
        public uint LargeIcon;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            SmallIcon = parser.ReadColumn< uint >( 0 );
            LargeIcon = parser.ReadColumn< uint >( 1 );
        }
    }
}