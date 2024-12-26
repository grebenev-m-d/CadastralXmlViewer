using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class RecordInfo
    {
        [XmlElement(ElementName = "registration_date")]
        public DateTime RegistrationDate { get; set; }
    }
}