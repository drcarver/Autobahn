//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IBuildingSystemComponentService.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSystemComponentService
     /// </summary>
    public partial interface IBuildingSystemComponentService : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="BuildingSystemComponent"/> model
        /// </summary>
        Guid BuildingSystemComponentId { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponentService.ComponentOrFixtureScheduledServicedDate nullable property
        /// </summary>
        System.DateTime? ComponentOrFixtureScheduledServicedDate { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponentService.ComponentOrFixtureServicedDate nullable property
        /// </summary>
        System.DateTime? ComponentOrFixtureServicedDate { get; set; }

    }
}
