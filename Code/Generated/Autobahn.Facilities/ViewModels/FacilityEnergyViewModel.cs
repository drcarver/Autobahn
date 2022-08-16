//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityEnergyViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private Guid? _BuildingEnergyServiceCompanyName;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefBuildingEnergySourceTypeId property
        private  _RefBuildingEnergySourceTypeId;

        // member variable for the RefFacilityUtilityProviderTypeId property
        private  _RefFacilityUtilityProviderTypeId;

        // member variable for the RefFacilityUtilityTypeId property
        private  _RefFacilityUtilityTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? BuildingEnergyServiceCompanyName { get => _BuildingEnergyServiceCompanyName; set => SetProperty(ref _BuildingEnergyServiceCompanyName, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnergySourceType"/> model
        /// </summary>
        public  RefBuildingEnergySourceTypeId { get => _RefBuildingEnergySourceTypeId; set => SetProperty(ref _RefBuildingEnergySourceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityProviderType"/> model
        /// </summary>
        public  RefFacilityUtilityProviderTypeId { get => _RefFacilityUtilityProviderTypeId; set => SetProperty(ref _RefFacilityUtilityProviderTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityType"/> model
        /// </summary>
        public  RefFacilityUtilityTypeId { get => _RefFacilityUtilityTypeId; set => SetProperty(ref _RefFacilityUtilityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityEnergy model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingEnergyServiceCompanyName = model.BuildingEnergyServiceCompanyName; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefBuildingEnergySourceTypeId = model.RefBuildingEnergySourceTypeId; // 
            RefFacilityUtilityProviderTypeId = model.RefFacilityUtilityProviderTypeId; // 
            RefFacilityUtilityTypeId = model.RefFacilityUtilityTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
