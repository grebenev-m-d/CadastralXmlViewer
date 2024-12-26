using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class SpatialElement
    {
        [XmlElement(ElementName = "ordinates")]
        public Ordinates Ordinates { get; set; }
    }
}