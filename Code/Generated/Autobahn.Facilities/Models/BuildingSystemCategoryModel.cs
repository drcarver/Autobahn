//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemCategoryModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSystemCategory Model
     /// </summary>
    public partial class BuildingSystemCategoryModel : AutobahnBase, Interfaces.IBuildingSystemCategory
    {
        /// <summary>
        /// The primary means by which air is circulated, freshened, and exhausted.
        /// </summary>
        public Guid? RefBuildingAirDistributionSystemTypeId { get; set; }

    }
}
