using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class MunicipalBoundaries
    {
        [XmlElement(ElementName = "municipal_boundary_record")]
        public List<MunicipalBoundaryRecord> MunicipalBoundaryRecords { get; set; }
    }
}