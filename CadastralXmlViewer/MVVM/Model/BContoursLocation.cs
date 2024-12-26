using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class BContoursLocation
    {
        [XmlElement(ElementName = "contours")]
        public Contours Contours { get; set; }
    }

}