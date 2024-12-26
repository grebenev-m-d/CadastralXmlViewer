﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CadastralXmlViewer.Data.XmlModels
{
    public class PermittedUseEstablished
    {
        [XmlElement("by_document")]
        public string ByDocument { get; set; }

        [XmlElement("land_use")]
        public LandUse LandUse { get; set; }
    }
}
