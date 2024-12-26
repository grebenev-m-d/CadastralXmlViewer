using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class BObjectZonesAndTerritories
    {
        [XmlElement("b_object")]
        public BObject BObject { get; set; }

        [XmlElement("type_zone")]
        public TypeZone TypeZone { get; set; }

        [XmlElement("number")]
        public string Number { get; set; }
    }
}