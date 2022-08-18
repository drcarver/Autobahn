//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignConstructionViewModel.cs
//* Name:       Building Addition Code
//* Definition: A unique number or alphanumeric code assigned to a building addition by a school, school system, state, or other agency or entity.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// A unique number or alphanumeric code assigned to a building addition by a school, school system, state, or other agency or entity.
     /// </summary>
    public partial class FacilityDesignConstructionViewModel : ViewModelBase, Interfaces.IFacilityDesignConstruction
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityDesignConstruction";

        // BuildingAdditionCode -- (backing property for Building Addition Code)
        private System.String _BuildingAdditionCode;

        // BuildingAdditionDescription -- (backing property for Building Addition Description)
        private System.String _BuildingAdditionDescription;

        // BuildingSiteImprovementDescription -- (backing property for Building Site Improvement Description)
        private System.String _BuildingSiteImprovementDescription;

        // FacilityAdditionYear -- (backing property for Facility Addition Year)
        private System.String _FacilityAdditionYear;

        // FacilityConstructionDate -- (backing property for Facility Construction Date)
        private System.DateTime? _FacilityConstructionDate;

        // FacilityConstructionYear -- (backing property for Facility Construction Year)
        private System.String _FacilityConstructionYear;

        // member variable for the FacilityDesignId property
        private Guid _FacilityDesignId;

        // RefBuildingEnergyConservationMeasureTypeId -- (backing property for Building Energy Conservation Measure Type)
        private Guid? _RefBuildingEnergyConservationMeasureTypeId;

        // RefFacilityConstructionDateTypeId -- (backing property for Facility Construction Date Type)
        private Guid? _RefFacilityConstructionDateTypeId;

        // RefFacilityConstructionMaterialTypeId -- (backing property for Facility Construction Material Type)
        private Guid? _RefFacilityConstructionMaterialTypeId;

        // RefFacilityJointDevelopmentTypeId -- (backing property for Facility Joint Development Type)
        private Guid? _RefFacilityJointDevelopmentTypeId;

        // RefFacilitySiteImprovementLocationTypeId -- (backing property for Facility Site Improvement Location Type)
        private Guid? _RefFacilitySiteImprovementLocationTypeId;

        // RefFacilityStandardTypeId -- (backing property for Facility Standard Type)
        private Guid? _RefFacilityStandardTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Building Addition Code
        /// <para>
        /// A unique number or alphanumeric code assigned to a building addition by a school, school system, state, or other agency or entity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20757">Building Addition Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingAdditionCode { get => _BuildingAdditionCode; set => SetProperty(ref _BuildingAdditionCode, value); }

        /// <summary>
        /// Building Addition Description
        /// <para>
        /// A description of the permanent structure added to the original building.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20756">Building Addition Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingAdditionDescription { get => _BuildingAdditionDescription; set => SetProperty(ref _BuildingAdditionDescription, value); }

        /// <summary>
        /// Building Site Improvement Description
        /// <para>
        /// A description of the designed and constructed improvements made to a site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20831">Building Site Improvement Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingSiteImprovementDescription { get => _BuildingSiteImprovementDescription; set => SetProperty(ref _BuildingSiteImprovementDescription, value); }

        /// <summary>
        /// Facility Addition Year
        /// <para>
        /// The year the construction on the addition was completed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20750">Facility Addition Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilityAdditionYear { get => _FacilityAdditionYear; set => SetProperty(ref _FacilityAdditionYear, value); }

        /// <summary>
        /// Facility Construction Date
        /// <para>
        /// The month, day, and year on which construction of a building, addition, or improvement was completed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20761">Facility Construction Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? FacilityConstructionDate { get => _FacilityConstructionDate; set => SetProperty(ref _FacilityConstructionDate, value); }

        /// <summary>
        /// Facility Construction Year
        /// <para>
        /// The year the building was first constructed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20752">Facility Construction Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilityConstructionYear { get => _FacilityConstructionYear; set => SetProperty(ref _FacilityConstructionYear, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityDesign"/> model
        /// </summary>
        public Guid FacilityDesignId { get => _FacilityDesignId; set => SetProperty(ref _FacilityDesignId, value); }

        /// <summary>
        /// Building Energy Conservation Measure Type
        /// <para>
        /// The type of modification to, or replacement of, a piece of equipment or building shell/system that increases energy efficiency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20849">Building Energy Conservation Measure Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingEnergyConservationMeasureTypeId { get => _RefBuildingEnergyConservationMeasureTypeId; set => SetProperty(ref _RefBuildingEnergyConservationMeasureTypeId, value); }

        /// <summary>
        /// Facility Construction Date Type
        /// <para>
        /// Designation of the nature of the construction completion date.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20762">Facility Construction Date Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityConstructionDateTypeId { get => _RefFacilityConstructionDateTypeId; set => SetProperty(ref _RefFacilityConstructionDateTypeId, value); }

        /// <summary>
        /// Facility Construction Material Type
        /// <para>
        /// The primary material used for the construction of a building.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20763">Facility Construction Material Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityConstructionMaterialTypeId { get => _RefFacilityConstructionMaterialTypeId; set => SetProperty(ref _RefFacilityConstructionMaterialTypeId, value); }

        /// <summary>
        /// Facility Joint Development Type
        /// <para>
        /// The type of development where two or more entities partner to plan, site, design, and/or build a new school or renovate an existing school to better support the joint use of the building and/or land.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20856">Facility Joint Development Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityJointDevelopmentTypeId { get => _RefFacilityJointDevelopmentTypeId; set => SetProperty(ref _RefFacilityJointDevelopmentTypeId, value); }

        /// <summary>
        /// Facility Site Improvement Location Type
        /// <para>
        /// The type of location of the designed and constructed improvements made to a site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20768">Facility Site Improvement Location Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilitySiteImprovementLocationTypeId { get => _RefFacilitySiteImprovementLocationTypeId; set => SetProperty(ref _RefFacilitySiteImprovementLocationTypeId, value); }

        /// <summary>
        /// Facility Standard Type
        /// <para>
        /// An indication of the district or state requirements or guidelines for the design and construction of school facilities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20865">Facility Standard Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityStandardTypeId { get => _RefFacilityStandardTypeId; set => SetProperty(ref _RefFacilityStandardTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityDesignConstruction model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingAdditionCode = model.BuildingAdditionCode; // Building Addition Code
            BuildingAdditionDescription = model.BuildingAdditionDescription; // Building Addition Description
            BuildingSiteImprovementDescription = model.BuildingSiteImprovementDescription; // Building Site Improvement Description
            FacilityAdditionYear = model.FacilityAdditionYear; // Facility Addition Year
            FacilityConstructionDate = model.FacilityConstructionDate; // Facility Construction Date
            FacilityConstructionYear = model.FacilityConstructionYear; // Facility Construction Year
            FacilityDesignId = model.FacilityDesignId; // 
            RefBuildingEnergyConservationMeasureTypeId = model.RefBuildingEnergyConservationMeasureTypeId; // Building Energy Conservation Measure Type
            RefFacilityConstructionDateTypeId = model.RefFacilityConstructionDateTypeId; // Facility Construction Date Type
            RefFacilityConstructionMaterialTypeId = model.RefFacilityConstructionMaterialTypeId; // Facility Construction Material Type
            RefFacilityJointDevelopmentTypeId = model.RefFacilityJointDevelopmentTypeId; // Facility Joint Development Type
            RefFacilitySiteImprovementLocationTypeId = model.RefFacilitySiteImprovementLocationTypeId; // Facility Site Improvement Location Type
            RefFacilityStandardTypeId = model.RefFacilityStandardTypeId; // Facility Standard Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
