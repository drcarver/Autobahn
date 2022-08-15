//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceUtilizationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSpaceUtilization Model
     /// </summary>
    public partial class BuildingSpaceUtilizationModel : AutobahnBase, Interfaces.IBuildingSpaceUtilization
    {
        /// <summary>
        /// A designation as to whether the space is considered an instructional space under state or local guidelines.
        /// </summary>
        public Guid? RefBuildingInstructionalSpaceFactorTypeId { get; set; }

    }
}
