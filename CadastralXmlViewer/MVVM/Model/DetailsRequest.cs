using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class DetailsRequest
    {
        [XmlElement("date_received_request")]
        public DateTime DateReceivedRequest { get; set; }

        [XmlElement("date_receipt_request_reg_authority_rights")]
        public DateTime DateReceiptRequestRegAuthorityRights { get; set; }
    }
}
