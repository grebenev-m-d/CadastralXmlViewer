using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class Contours
    {
        [XmlElement(ElementName = "contour")]
        public List<Contour> ContourList { get; set; }
    }
}