//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   Facility.cs
//**********************************************************

using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The Facility
     /// </summary>
    public partial class Facility : IFacility
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Defines the Facility.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Defines the Facility.BuildingName non nullable property
        /// </summary>
        public System.String BuildingName { get; set; }

        /// <summary>
        /// The number of the building on the site, if more than one building shares the same address.
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
        /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
        /// </summary>
    public System.String BuildingArea { get; set; }

        /// <summary>
        /// The number of stories in a building, excluding the basement if its ceiling is less than three feet above ground level.
        /// </summary>
    public System.String BuildingNumberOfStories { get; set; }

        /// <summary>
        /// The year a building was constructed, as indicated by cornerstone or official government records.
        /// </summary>
    public System.String BuildingYearBuilt { get; set; }

        /// <summary>
        /// The most recent year that a comprehensive upgrade of ALL major building systems and components was completed, such that it functions as a modern building, as measured by a facility condition index not greater than 15%.
        /// </summary>
    public System.String BuildingYearOfLastModernization { get; set; }

        /// <summary>
        /// The date the property/facility was acquired.
        /// </summary>
    public System.DateTime? FacilityAcquisitionDate { get; set; }

        /// <summary>
        /// An indication of whether the building is built for permanent use in the same location or is relocatable.
        /// </summary>
    public System.String FacilityBuildingPermanency { get; set; }

        /// <summary>
        /// The time, in years, of the expected useful life of a facility for the purposes of depreciation.
        /// </summary>
    public System.String FacilityExpectedLife { get; set; }

        /// <summary>
        /// Indicates the public or private entity holds legal title to the building and/or site.
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
        /// Defines the Facility.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the Facility.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
