//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityDesign Model
     /// </summary>
    public partial class FacilityDesignModel : AutobahnBase, Interfaces.IFacilityDesign
    {
        /// <summary>
        /// The primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
        /// </summary>
        public Guid? RefBuildingDesignTypeId { get; set; }

    }
}
