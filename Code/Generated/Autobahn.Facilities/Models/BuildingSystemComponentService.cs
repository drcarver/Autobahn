//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSystemComponentService.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSystemComponentService
     /// </summary>
    public partial class BuildingSystemComponentService : AutobahnBase, Interfaces.IBuildingSystemComponentService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="BuildingSystemComponent"/> model
        /// </summary>
        public Guid BuildingSystemComponentId { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponentService.ComponentOrFixtureScheduledServicedDate nullable property
        /// </summary>
        public System.DateTime? ComponentOrFixtureScheduledServicedDate { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponentService.ComponentOrFixtureServicedDate nullable property
        /// </summary>
        public System.DateTime? ComponentOrFixtureServicedDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
