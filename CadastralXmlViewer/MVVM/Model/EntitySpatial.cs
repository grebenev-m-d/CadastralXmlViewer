using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class EntitySpatial
    {
        [XmlElement(ElementName = "sk_id")]
        public string SkId { get; set; }

        [XmlElement(ElementName = "spatials_elements")]
        public SpatialsElements SpatialsElements { get; set; }
    }
}