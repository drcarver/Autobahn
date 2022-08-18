//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityEnergyViewModel.cs
//* Name:       Building Energy Service Company Name
//* Definition: The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
     /// </summary>
    public partial class FacilityEnergyViewModel : ViewModelBase, Interfaces.IFacilityEnergy
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityEnergy";

        // BuildingEnergyServiceCompanyName -- (backing property for Building Energy Service Company Name)
        private System.String _BuildingEnergyServiceCompanyName;

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // RefBuildingEnergySourceTypeId -- (backing property for Building Energy Source Type)
        private Guid? _RefBuildingEnergySourceTypeId;

        // RefFacilityUtilityProviderTypeId -- (backing property for Facility Utility Provider Type)
        private Guid? _RefFacilityUtilityProviderTypeId;

        // RefFacilityUtilityTypeId -- (backing property for Facility Utility Type)
        private Guid? _RefFacilityUtilityTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Building Energy Service Company Name
        /// <para>
        /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20850">Building Energy Service Company Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingEnergyServiceCompanyName { get => _BuildingEnergyServiceCompanyName; set => SetProperty(ref _BuildingEnergyServiceCompanyName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Building Energy Source Type
        /// <para>
        /// The source of energy that directly powers a school district facility or building system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20851">Building Energy Source Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingEnergySourceTypeId { get => _RefBuildingEnergySourceTypeId; set => SetProperty(ref _RefBuildingEnergySourceTypeId, value); }

        /// <summary>
        /// Facility Utility Provider Type
        /// <para>
        /// An indication of how utilities are supplied to a site or a building by a company or provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20859">Facility Utility Provider Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityUtilityProviderTypeId { get => _RefFacilityUtilityProviderTypeId; set => SetProperty(ref _RefFacilityUtilityProviderTypeId, value); }

        /// <summary>
        /// Facility Utility Type
        /// <para>
        /// The type of utility used in the operation of a facility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20860">Facility Utility Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFacilityUtilityTypeId { get => _RefFacilityUtilityTypeId; set => SetProperty(ref _RefFacilityUtilityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityEnergy model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingEnergyServiceCompanyName = model.BuildingEnergyServiceCompanyName; // Building Energy Service Company Name
            FacilityId = model.FacilityId; // 
            RefBuildingEnergySourceTypeId = model.RefBuildingEnergySourceTypeId; // Building Energy Source Type
            RefFacilityUtilityProviderTypeId = model.RefFacilityUtilityProviderTypeId; // Facility Utility Provider Type
            RefFacilityUtilityTypeId = model.RefFacilityUtilityTypeId; // Facility Utility Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
