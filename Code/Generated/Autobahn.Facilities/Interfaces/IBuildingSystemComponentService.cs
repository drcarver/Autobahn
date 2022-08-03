//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IBuildingSystemComponentService.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IBuildingSystemComponentService
     /// </summary>
    public partial interface IBuildingSystemComponentService
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

        /// <summary>
        /// Defines the BuildingSystemComponentService.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the BuildingSystemComponentService.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
