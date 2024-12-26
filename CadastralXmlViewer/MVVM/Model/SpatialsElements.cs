using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class SpatialsElements
    {
        [XmlElement(ElementName = "spatial_element")]
        public List<SpatialElement> SpatialElementList { get; set; }
    }
}