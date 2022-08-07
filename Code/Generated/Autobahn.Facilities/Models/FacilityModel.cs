//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The Facility Model
     /// </summary>
    public partial class FacilityModel : AutobahnBase, Interfaces.IFacilityModel
    {
        /// <summary>
        /// Defines the Facility.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Defines the Facility.BuildingName non nullable property
        /// </summary>
        public System.String BuildingName { get; set; }

        /// <summary>
        /// Defines the Facility.BuildingSiteNumber non nullable property
        /// </summary>
        public System.String BuildingSiteNumber { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingUseType"/> model
        /// </summary>
        public Guid? RefBuildingUseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Defines the Facility.BuildingArea non nullable property
        /// </summary>
        public System.String BuildingArea { get; set; }

        /// <summary>
        /// Defines the Facility.BuildingNumberOfStories non nullable property
        /// </summary>
        public System.String BuildingNumberOfStories { get; set; }

        /// <summary>
        /// Defines the Facility.BuildingYearBuilt non nullable property
        /// </summary>
        public System.String BuildingYearBuilt { get; set; }

        /// <summary>
        /// Defines the Facility.BuildingYearOfLastModernization non nullable property
        /// </summary>
        public System.String BuildingYearOfLastModernization { get; set; }

        /// <summary>
        /// Defines the Facility.FacilityAcquisitionDate nullable property
        /// </summary>
        public System.DateTime? FacilityAcquisitionDate { get; set; }

        /// <summary>
        /// Defines the Facility.FacilityBuildingPermanency non nullable property
        /// </summary>
        public System.String FacilityBuildingPermanency { get; set; }

        /// <summary>
        /// Defines the Facility.FacilityExpectedLife non nullable property
        /// </summary>
        public System.String FacilityExpectedLife { get; set; }

        /// <summary>
        /// Defines the Facility.FacilityOwnershipIndicator nullable property
        /// </summary>
        public System.Boolean? FacilityOwnershipIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingHistoricStatus"/> model
        /// </summary>
        public Guid? RefBuildingHistoricStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingPrimaryUseType"/> model
        /// </summary>
        public Guid? RefBuildingPrimaryUseTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusStatus"/> model
        /// </summary>
        public Guid? RefCampusStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusType"/> model
        /// </summary>
        public Guid? RefCampusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
