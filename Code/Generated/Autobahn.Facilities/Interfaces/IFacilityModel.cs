//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IFacilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityModel Interface
     /// </summary>
    public partial interface IFacilityModel : IAutobahnBase
    {
        /// <summary>
        /// Defines the Facility.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Defines the Facility.BuildingName non nullable property
        /// </summary>
        System.String BuildingName { get; set; }

        /// <summary>
        /// Defines the Facility.BuildingSiteNumber non nullable property
        /// </summary>
        System.String BuildingSiteNumber { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingUseType"/> model
        /// </summary>
        Guid? RefBuildingUseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// Defines the Facility.BuildingArea non nullable property
        /// </summary>
        System.String BuildingArea { get; set; }

        /// <summary>
        /// Defines the Facility.BuildingNumberOfStories non nullable property
        /// </summary>
        System.String BuildingNumberOfStories { get; set; }

        /// <summary>
        /// Defines the Facility.BuildingYearBuilt non nullable property
        /// </summary>
        System.String BuildingYearBuilt { get; set; }

        /// <summary>
        /// Defines the Facility.BuildingYearOfLastModernization non nullable property
        /// </summary>
        System.String BuildingYearOfLastModernization { get; set; }

        /// <summary>
        /// Defines the Facility.FacilityAcquisitionDate nullable property
        /// </summary>
        System.DateTime? FacilityAcquisitionDate { get; set; }

        /// <summary>
        /// Defines the Facility.FacilityBuildingPermanency non nullable property
        /// </summary>
        System.String FacilityBuildingPermanency { get; set; }

        /// <summary>
        /// Defines the Facility.FacilityExpectedLife non nullable property
        /// </summary>
        System.String FacilityExpectedLife { get; set; }

        /// <summary>
        /// Defines the Facility.FacilityOwnershipIndicator nullable property
        /// </summary>
        System.Boolean? FacilityOwnershipIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingHistoricStatus"/> model
        /// </summary>
        Guid? RefBuildingHistoricStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPrimaryUseType"/> model
        /// </summary>
        Guid? RefBuildingPrimaryUseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusStatus"/> model
        /// </summary>
        Guid? RefCampusStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusType"/> model
        /// </summary>
        Guid? RefCampusTypeId { get; set; }

    }
}
