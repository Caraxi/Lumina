using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestChapter", columnHash: 0x5edc18ea )]
    public class QuestChapter : IExcelRow
    {
        
        public LazyRow< Quest > Quest;
        public ushort Redo;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 0 ) );
            Redo = parser.ReadColumn< ushort >( 1 );
        }
    }
}