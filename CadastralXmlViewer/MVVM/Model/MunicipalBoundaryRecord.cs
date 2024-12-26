using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class MunicipalBoundaryRecord
    {
        [XmlElement(ElementName = "record_info")]
        public RecordInfo RecordInfo { get; set; }

        [XmlElement(ElementName = "b_object_municipal_boundary")]
        public BObjectMunicipalBoundary BObjectMunicipalBoundary { get; set; }

        [XmlElement(ElementName = "b_contours_location")]
        public BContoursLocation BContoursLocation { get; set; }
    }
}