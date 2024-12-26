using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class TypeZone
    {
        [XmlElement("code")]
        public string Code { get; set; }

        [XmlElement("value")]
        public string Value { get; set; }
    }
}