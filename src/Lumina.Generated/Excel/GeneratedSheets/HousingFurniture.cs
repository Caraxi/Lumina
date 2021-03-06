using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingFurniture", columnHash: 0xccfbe5ff )]
    public class HousingFurniture : IExcelRow
    {
        
        public ushort ModelKey;
        public byte HousingItemCategory;
        public byte UsageType;
        public uint UsageParameter;
        public byte Unknown4;
        public byte AquariumTier;
        public LazyRow< CustomTalk > CustomTalk;
        public LazyRow< Item > Item;
        public bool DestroyOnRemoval;
        public LazyRow< HousingPlacement > Tooltip;
        public byte Unknown10;
        public byte Unknown11;
        public byte Unknown12;
        public bool Unknown13;
        public bool Unknown14;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ModelKey = parser.ReadColumn< ushort >( 0 );
            HousingItemCategory = parser.ReadColumn< byte >( 1 );
            UsageType = parser.ReadColumn< byte >( 2 );
            UsageParameter = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            AquariumTier = parser.ReadColumn< byte >( 5 );
            CustomTalk = new LazyRow< CustomTalk >( lumina, parser.ReadColumn< uint >( 6 ) );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 7 ) );
            DestroyOnRemoval = parser.ReadColumn< bool >( 8 );
            #warning generator error: the definition for this field (Tooltip) has an invalid type for a LazyRow
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
        }
    }
}