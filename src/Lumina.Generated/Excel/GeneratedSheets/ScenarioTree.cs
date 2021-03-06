using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioTree", columnHash: 0xcc25b9f9 )]
    public class ScenarioTree : IExcelRow
    {
        
        public LazyRow< ScenarioType > Type;
        public LazyRow< ScreenImage > Image;
        public uint Unknown2;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Type = new LazyRow< ScenarioType >( lumina, parser.ReadColumn< byte >( 0 ) );
            Image = new LazyRow< ScreenImage >( lumina, parser.ReadColumn< ushort >( 1 ) );
            Unknown2 = parser.ReadColumn< uint >( 2 );
        }
    }
}