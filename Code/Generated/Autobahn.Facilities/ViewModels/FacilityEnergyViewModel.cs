//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityEnergyViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityEnergyViewModel
     /// </summary>
    public partial class FacilityEnergyViewModel : ViewModelBase, Interfaces.IFacilityEnergyViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityEnergy";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the BuildingEnergyServiceCompanyName property
        private System.String _BuildingEnergyServiceCompanyName;

        // member variable for the RefBuildingEnergySourceTypeId property
        private Guid? _RefBuildingEnergySourceTypeId;

        // member variable for the RefFacilityUtilityProviderTypeId property
        private Guid? _RefFacilityUtilityProviderTypeId;

        // member variable for the RefFacilityUtilityTypeId property
        private Guid? _RefFacilityUtilityTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityEnergyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        public System.String BuildingEnergyServiceCompanyName  { get => _BuildingEnergyServiceCompanyName; set => SetProperty(ref _BuildingEnergyServiceCompanyName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnergySourceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingEnergySourceTypeId { get => _RefBuildingEnergySourceTypeId; set => SetProperty(ref _RefBuildingEnergySourceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityProviderTypeId"/> model
        /// </summary>
        public Guid? RefFacilityUtilityProviderTypeId { get => _RefFacilityUtilityProviderTypeId; set => SetProperty(ref _RefFacilityUtilityProviderTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityTypeId"/> model
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
            FacilityId = model.FacilityId;
            BuildingEnergyServiceCompanyName = model.BuildingEnergyServiceCompanyName;
            RefBuildingEnergySourceTypeId = model.RefBuildingEnergySourceTypeId;
            RefFacilityUtilityProviderTypeId = model.RefFacilityUtilityProviderTypeId;
            RefFacilityUtilityTypeId = model.RefFacilityUtilityTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
