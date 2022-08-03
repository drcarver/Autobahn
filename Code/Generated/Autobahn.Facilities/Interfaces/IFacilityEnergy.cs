//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityEnergy.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityEnergy
     /// </summary>
    public partial interface IFacilityEnergy
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityEnergy.BuildingEnergyServiceCompanyName non nullable property
        /// </summary>
        System.String BuildingEnergyServiceCompanyName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnergySourceType"/> model
        /// </summary>
        Guid? RefBuildingEnergySourceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityProviderType"/> model
        /// </summary>
        Guid? RefFacilityUtilityProviderTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityType"/> model
        /// </summary>
        Guid? RefFacilityUtilityTypeId { get; set; }

        /// <summary>
        /// Defines the FacilityEnergy.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityEnergy.RecordEndDateTime nullable property
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
