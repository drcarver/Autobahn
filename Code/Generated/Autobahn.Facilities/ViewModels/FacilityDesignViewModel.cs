//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignViewModel.cs
//* Name:       Building Architect Name
//* Definition: The name of the architect of record for the building.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The name of the architect of record for the building.
     /// </summary>
    public partial class FacilityDesignViewModel : ViewModelBase, Interfaces.IFacilityDesign
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityDesign";

        // BuildingArchitectName -- (backing property for Building Architect Name)
        private System.String _BuildingArchitectName;

        // BuildingArchitecturalFirmName -- (backing property for Building Architectural Firm Name)
        private System.String _BuildingArchitecturalFirmName;

        // BuildingDateOfCertificateOfOccupancy -- (backing property for Building Date of Certificate of Occupancy)
        private System.DateTime? _BuildingDateOfCertificateOfOccupancy;

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // RefBuildingDesignTypeId -- (backing property for Building Design Type)
        private Guid? _RefBuildingDesignTypeId;

        // RefBuildingEnvOrEnergyPerformanceRatingCatId -- (backing property for Building Environmental or Energy Performance Rating Category)
        private Guid? _RefBuildingEnvOrEnergyPerformanceRatingCatId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Building Architect Name
        /// <para>
        /// The name of the architect of record for the building.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20815">Building Architect Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingArchitectName { get => _BuildingArchitectName; set => SetProperty(ref _BuildingArchitectName, value); }

        /// <summary>
        /// Building Architectural Firm Name
        /// <para>
        /// The name of the architectural firm responsible for the building design.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20816">Building Architectural Firm Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingArchitecturalFirmName { get => _BuildingArchitecturalFirmName; set => SetProperty(ref _BuildingArchitecturalFirmName, value); }

        /// <summary>
        /// Building Date of Certificate of Occupancy
        /// <para>
        /// The month, day and year in which a certificate of occupancy was granted by the appropriate local authority.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20861">Building Date of Certificate of Occupancy</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? BuildingDateOfCertificateOfOccupancy { get => _BuildingDateOfCertificateOfOccupancy; set => SetProperty(ref _BuildingDateOfCertificateOfOccupancy, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Building Design Type
        /// <para>
        /// The primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20797">Building Design Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingDesignTypeId { get => _RefBuildingDesignTypeId; set => SetProperty(ref _RefBuildingDesignTypeId, value); }

        /// <summary>
        /// Building Environmental or Energy Performance Rating Category
        /// <para>
        /// The primary groupings that rating organizations use to evaluate environmental sustainability and energy use.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20800">Building Environmental or Energy Performance Rating Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingEnvOrEnergyPerformanceRatingCatId { get => _RefBuildingEnvOrEnergyPerformanceRatingCatId; set => SetProperty(ref _RefBuildingEnvOrEnergyPerformanceRatingCatId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityDesign model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingArchitectName = model.BuildingArchitectName; // Building Architect Name
            BuildingArchitecturalFirmName = model.BuildingArchitecturalFirmName; // Building Architectural Firm Name
            BuildingDateOfCertificateOfOccupancy = model.BuildingDateOfCertificateOfOccupancy; // Building Date of Certificate of Occupancy
            FacilityId = model.FacilityId; // 
            RefBuildingDesignTypeId = model.RefBuildingDesignTypeId; // Building Design Type
            RefBuildingEnvOrEnergyPerformanceRatingCatId = model.RefBuildingEnvOrEnergyPerformanceRatingCatId; // Building Environmental or Energy Performance Rating Category
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
