//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityDesign.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityDesign Interface
     /// </summary>
    public partial interface IFacilityDesign : IAutobahnBase
    {
        /// <summary>
        /// The primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
        /// </summary>
        Guid? RefBuildingDesignTypeId { get; set; }

    }
}
