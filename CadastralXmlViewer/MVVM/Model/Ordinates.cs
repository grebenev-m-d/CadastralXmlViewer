using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class Ordinates
    {
        [XmlElement(ElementName = "ordinate")]
        public List<Ordinate> OrdinateList { get; set; }
    }
}