using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastralXmlViewer.MVVM.Model
{
    public enum RecordType : byte
    {
        LandRecords,
        BuildRecords,
        ConstructionRecords,
        SpatialData,
        MunicipalBoundaries,
        ZonesAndTerritoriesRecords
    }
}
