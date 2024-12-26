using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class BuildRecord
    {
        [XmlElement("object")]
        public BuildObject Object { get; set; }

        [XmlElement("params")]
        public BuildParams Params { get; set; }
    }
}