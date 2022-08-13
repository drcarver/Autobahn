//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSystemComponentService Model
     /// </summary>
    public partial class BuildingSystemComponentServiceModel : AutobahnBase, Interfaces.IBuildingSystemComponentService
    {
        /// <summary>
        /// The month, day, and year a system, component, equipment, or fixture was serviced for repair or routine maintenance.
        /// </summary>
        public Guid BuildingSystemComponentId { get; set; }

        /// <summary>
        /// The month, day, and year a system, component, equipment, or fixture was serviced for repair or routine maintenance.
        /// </summary>
        public System.DateTime? ComponentOrFixtureScheduledServicedDate { get; set; }

        /// <summary>
        /// The month, day, and year a system, component, equipment, or fixture was serviced for repair or routine maintenance.
        /// </summary>
        public System.DateTime? ComponentOrFixtureServicedDate { get; set; }

    }
}
