using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class GroupTopRequisites
    {
        [XmlElement("organ_registr_rights")]
        public string OrganRegistrRights { get; set; }

        [XmlElement("date_formation")]
        public DateTime DateFormation { get; set; }

        [XmlElement("registration_number")]
        public string RegistrationNumber { get; set; }
    }
}
