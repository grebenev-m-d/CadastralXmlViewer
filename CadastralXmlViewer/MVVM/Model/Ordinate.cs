using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class Ordinate
    {
        [XmlElement("x")]
        public double X { get; set; }

        [XmlElement("y")]
        public double Y { get; set; }

        [XmlElement("ord_nmb")]
        public int OrdNmb { get; set; }

        [XmlElement("num_geopoint")]
        public int NumGeopoint { get; set; }

        [XmlElement("geopoint_opred")]
        public GeopointOpred GeopointOpred { get; set; }

        [XmlElement("delta_geopoint")]
        public double DeltaGeopoint { get; set; }
    }
}