using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class TypeBoundary
    {
        [XmlElement(ElementName = "code")]
        public int Code { get; set; }

        [XmlElement(ElementName = "value")]
        public string Value { get; set; }
    }

}