//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityEnergyViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityEnergyViewModel
     /// </summary>
    public partial class FacilityEnergyViewModel : ViewModelBase, Interfaces.IFacilityEnergy
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityEnergy";

        // member variable for the BuildingEnergyServiceCompanyName property
        private System.String _BuildingEnergyServiceCompanyName;

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the RefBuildingEnergySourceTypeId property
        private Guid? _RefBuildingEnergySourceTypeId;

        // member variable for the RefFacilityUtilityProviderTypeId property
        private Guid? _RefFacilityUtilityProviderTypeId;

        // member variable for the RefFacilityUtilityTypeId property
        private Guid? _RefFacilityUtilityTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityEnergyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
        /// </summary>
        public System.String BuildingEnergyServiceCompanyName { get => _BuildingEnergyServiceCompanyName; set => SetProperty(ref _BuildingEnergyServiceCompanyName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnergySourceType"/> model
        /// </summary>
        public Guid? RefBuildingEnergySourceTypeId { get => _RefBuildingEnergySourceTypeId; set => SetProperty(ref _RefBuildingEnergySourceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityProviderType"/> model
        /// </summary>
        public Guid? RefFacilityUtilityProviderTypeId { get => _RefFacilityUtilityProviderTypeId; set => SetProperty(ref _RefFacilityUtilityProviderTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityType"/> model
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
            BuildingEnergyServiceCompanyName = model.BuildingEnergyServiceCompanyName;
            FacilityId = model.FacilityId;
            RefBuildingEnergySourceTypeId = model.RefBuildingEnergySourceTypeId;
            RefFacilityUtilityProviderTypeId = model.RefFacilityUtilityProviderTypeId;
            RefFacilityUtilityTypeId = model.RefFacilityUtilityTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
