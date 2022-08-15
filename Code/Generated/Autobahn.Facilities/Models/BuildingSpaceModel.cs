//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSpace Model
     /// </summary>
    public partial class BuildingSpaceModel : AutobahnBase, Interfaces.IBuildingSpace
    {
        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// </summary>
        public System.String SpaceDescription { get; set; }

    }
}
