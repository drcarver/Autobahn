//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IBuildingSystemComponentService.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSystemComponentService Interface
     /// </summary>
    public partial interface IBuildingSystemComponentService : IAutobahnBase
    {
        /// <summary>
        /// The month, day, and year a system, component, equipment, or fixture was serviced for repair or routine maintenance.
        /// </summary>
        Guid BuildingSystemComponentId { get; set; }

        /// <summary>
        /// The month, day, and year a system, component, equipment, or fixture was serviced for repair or routine maintenance.
        /// </summary>
        System.DateTime? ComponentOrFixtureScheduledServicedDate { get; set; }

        /// <summary>
        /// The month, day, and year a system, component, equipment, or fixture was serviced for repair or routine maintenance.
        /// </summary>
        System.DateTime? ComponentOrFixtureServicedDate { get; set; }

    }
}
