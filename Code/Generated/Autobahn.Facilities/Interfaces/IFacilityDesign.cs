//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityDesign.cs
//**********************************************************

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityDesign
     /// </summary>
    public partial interface IFacilityDesign
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the FacilityDesign.BuildingArchitectName non nullable property
        /// </summary>
        System.String BuildingArchitectName { get; set; }

        /// <summary>
        /// Defines the FacilityDesign.BuildingArchitecturalFirmName non nullable property
        /// </summary>
        System.String BuildingArchitecturalFirmName { get; set; }

        /// <summary>
        /// Defines the FacilityDesign.BuildingDateOfCertificateOfOccupancy nullable property
        /// </summary>
        System.DateTime? BuildingDateOfCertificateOfOccupancy { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingDesignType"/> model
        /// </summary>
        Guid? RefBuildingDesignTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnvOrEnergyPerformanceRatingCat"/> model
        /// </summary>
        Guid? RefBuildingEnvOrEnergyPerformanceRatingCatId { get; set; }

        /// <summary>
        /// Defines the FacilityDesign.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FacilityDesign.RecordEndDateTime nullable property
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
