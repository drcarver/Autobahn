//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityDesign.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityDesign
     /// </summary>
    public partial interface IFacilityDesign : IAutobahnBase
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

    }
}
