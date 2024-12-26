using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class SpatialData
    {
        [XmlElement("entity_spatial")]
        public List<EntitySpatial> EntitySpatials { get; set; }
    }
}