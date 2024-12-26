using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class DetailsStatement
    {
        [XmlElement("group_top_requisites")]
        public GroupTopRequisites GroupTopRequisites { get; set; }
    }
}
