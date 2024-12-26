using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class ConstructionParams
    {
        [XmlElement("category")]
        public Category Category { get; set; }

        [XmlElement("intended_use")]
        public string IntendedUse { get; set; }
    }
}