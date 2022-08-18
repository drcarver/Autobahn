//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityViewModel.cs
//* Name:       Building Area
//* Definition: The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
     /// </summary>
    public partial class FacilityViewModel : ViewModelBase, Interfaces.IFacility
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Facility";

        // BuildingArea -- (backing property for Building Area)
        private System.String _BuildingArea;

        // BuildingName -- (backing property for Site Name)
        private System.String _BuildingName;

        // BuildingNumberOfStories -- (backing property for Building Number of Stories)
        private System.String _BuildingNumberOfStories;

        // BuildingSiteNumber -- (backing property for Building Site Number)
        private System.String _BuildingSiteNumber;

        // BuildingYearBuilt -- (backing property for Building Year Built)
        private System.String _BuildingYearBuilt;

        // BuildingYearOfLastModernization -- (backing property for Building Year of Last Modernization)
        private System.String _BuildingYearOfLastModernization;

        // FacilityAcquisitionDate -- (backing property for Facility Acquisition Date)
        private System.DateTime? _FacilityAcquisitionDate;

        // FacilityBuildingPermanency -- (backing property for Facility Building Permanency)
        private System.String _FacilityBuildingPermanency;

        // FacilityExpectedLife -- (backing property for Facility Expected Life)
        private System.String _FacilityExpectedLife;

        // FacilityOwnershipIndicator -- (backing property for Facility Ownership Indicator)
        private System.Boolean? _FacilityOwnershipIndicator;

        // Identifier -- (backing property for Facilities Identifier)
        private System.String _Identifier;

        // member variable for the OrganizationId property
        private Guid? _OrganizationId;

        // RefBuildingHistoricStatusId -- (backing property for Building Historic Status)
        private Guid? _RefBuildingHistoricStatusId;

        // RefBuildingPrimaryUseTypeId -- (backing property for Building Primary Use Type)
        private Guid? _RefBuildingPrimaryUseTypeId;

        // RefBuildingUseTypeId -- (backing property for Building Use Type)
        private Guid? _RefBuildingUseTypeId;

        // RefCampusStatusId -- (backing property for Campus Status)
        private Guid? _RefCampusStatusId;

        // RefCampusTypeId -- (backing property for Campus Facility Type)
        private Guid? _RefCampusTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Building Area
        /// <para>
        /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20745">Building Area</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingArea { get => _BuildingArea; set => SetProperty(ref _BuildingArea, value); }

        /// <summary>
        /// Site Name
        /// <para>
        /// The full, legally accepted  name of the institution at the site level.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19625">Site Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingName { get => _BuildingName; set => SetProperty(ref _BuildingName, value); }

        /// <summary>
        /// Building Number of Stories
        /// <para>
        /// The number of stories in a building, excluding the basement if its ceiling is less than three feet above ground level.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20766">Building Number of Stories</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingNumberOfStories { get => _BuildingNumberOfStories; set => SetProperty(ref _BuildingNumberOfStories, value); }

        /// <summary>
        /// Building Site Number
        /// <para>
        /// The number of the building on the site, if more than one building shares the same address.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19595">Building Site Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingSiteNumber { get => _BuildingSiteNumber; set => SetProperty(ref _BuildingSiteNumber, value); }

        /// <summary>
        /// Building Year Built
        /// <para>
        /// The year a building was constructed, as indicated by cornerstone or official government records.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20769">Building Year Built</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingYearBuilt { get => _BuildingYearBuilt; set => SetProperty(ref _BuildingYearBuilt, value); }

        /// <summary>
        /// Building Year of Last Modernization
        /// <para>
        /// The most recent year that a comprehensive upgrade of ALL major building systems and components was completed, such that it functions as a modern building, as measured by a facility condition index not greater than 15%.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20770">Building Year of Last Modernization</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingYearOfLastModernization { get => _BuildingYearOfLastModernization; set => SetProperty(ref _BuildingYearOfLastModernization, value); }

        /// <summary>
        /// Facility Acquisition Date
        /// <para>
        /// The date the property/facility was acquired.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20749">Facility Acquisition Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? FacilityAcquisitionDate { get => _FacilityAcquisitionDate; set => SetProperty(ref _FacilityAcquisitionDate, value); }

        /// <summary>
        /// Facility Building Permanency
        /// <para>
        /// An indication of whether the building is built for permanent use in the same location or is relocatable.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20751">Facility Building Permanency</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilityBuildingPermanency { get => _FacilityBuildingPermanency; set => SetProperty(ref _FacilityBuildingPermanency, value); }

        /// <summary>
        /// Facility Expected Life
        /// <para>
        /// The time, in years, of the expected useful life of a facility for the purposes of depreciation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20764">Facility Expected Life</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilityExpectedLife { get => _FacilityExpectedLife; set => SetProperty(ref _FacilityExpectedLife, value); }

        /// <summary>
        /// Facility Ownership Indicator
        /// <para>
        /// Indicates the public or private entity holds legal title to the building and/or site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20887">Facility Ownership Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? FacilityOwnershipIndicator { get => _FacilityOwnershipIndicator; set => SetProperty(ref _FacilityOwnershipIndicator, value); }

        /// <summary>
        /// Facilities Identifier
        /// <para>
        /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19495">Facilities Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid? OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Building Historic Status
        /// <para>
        /// An indication of whether or not a building is eligible to be or has been declared a landmark or historic building.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20753">Building Historic Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingHistoricStatusId { get => _RefBuildingHistoricStatusId; set => SetProperty(ref _RefBuildingHistoricStatusId, value); }

        /// <summary>
        /// Building Primary Use Type
        /// <para>
        /// The primary use type of the building in which a school is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20758">Building Primary Use Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingPrimaryUseTypeId { get => _RefBuildingPrimaryUseTypeId; set => SetProperty(ref _RefBuildingPrimaryUseTypeId, value); }

        /// <summary>
        /// Building Use Type
        /// <para>
        /// How a building is principally used, regardless of its original design.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20173">Building Use Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingUseTypeId { get => _RefBuildingUseTypeId; set => SetProperty(ref _RefBuildingUseTypeId, value); }

        /// <summary>
        /// Campus Status
        /// <para>
        /// The generalized use or control of a campus, independent of program type.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20759">Campus Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCampusStatusId { get => _RefCampusStatusId; set => SetProperty(ref _RefCampusStatusId, value); }

        /// <summary>
        /// Campus Facility Type
        /// <para>
        /// The primary purpose for which a campus is designed and/or used.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20878">Campus Facility Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCampusTypeId { get => _RefCampusTypeId; set => SetProperty(ref _RefCampusTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacility model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingArea = model.BuildingArea; // Building Area
            BuildingName = model.BuildingName; // Site Name
            BuildingNumberOfStories = model.BuildingNumberOfStories; // Building Number of Stories
            BuildingSiteNumber = model.BuildingSiteNumber; // Building Site Number
            BuildingYearBuilt = model.BuildingYearBuilt; // Building Year Built
            BuildingYearOfLastModernization = model.BuildingYearOfLastModernization; // Building Year of Last Modernization
            FacilityAcquisitionDate = model.FacilityAcquisitionDate; // Facility Acquisition Date
            FacilityBuildingPermanency = model.FacilityBuildingPermanency; // Facility Building Permanency
            FacilityExpectedLife = model.FacilityExpectedLife; // Facility Expected Life
            FacilityOwnershipIndicator = model.FacilityOwnershipIndicator; // Facility Ownership Indicator
            Identifier = model.Identifier; // Facilities Identifier
            OrganizationId = model.OrganizationId; // 
            RefBuildingHistoricStatusId = model.RefBuildingHistoricStatusId; // Building Historic Status
            RefBuildingPrimaryUseTypeId = model.RefBuildingPrimaryUseTypeId; // Building Primary Use Type
            RefBuildingUseTypeId = model.RefBuildingUseTypeId; // Building Use Type
            RefCampusStatusId = model.RefCampusStatusId; // Campus Status
            RefCampusTypeId = model.RefCampusTypeId; // Campus Facility Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
