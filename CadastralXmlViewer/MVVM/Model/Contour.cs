using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class Contour
    {
        [XmlElement(ElementName = "entity_spatial")]
        public EntitySpatial EntitySpatial { get; set; }
    }
}