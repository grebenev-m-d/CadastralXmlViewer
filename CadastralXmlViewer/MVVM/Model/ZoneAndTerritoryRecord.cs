using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class ZoneAndTerritoryRecord
    {
        [XmlElement("record_info")]
        public RecordInfo RecordInfo { get; set; }

        [XmlElement("b_object_zones_and_territories")]
        public BObjectZonesAndTerritories BObjectZonesAndTerritories { get; set; }

        [XmlElement("b_contours_location")]
        public BContoursLocation BContoursLocation { get; set; }
    }
}