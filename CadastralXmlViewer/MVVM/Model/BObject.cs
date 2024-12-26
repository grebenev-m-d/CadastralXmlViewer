using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class BObject
    {
        [XmlElement(ElementName = "reg_numb_border")]
        public string RegNumbBorder { get; set; }

        [XmlElement(ElementName = "type_boundary")]
        public TypeBoundary TypeBoundary { get; set; }
    }
}