using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class BObjectMunicipalBoundary
    {
        [XmlElement(ElementName = "b_object")]
        public BObject BObject { get; set; }
    }
}