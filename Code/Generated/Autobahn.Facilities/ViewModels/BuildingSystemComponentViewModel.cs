//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSystemComponentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSystemComponentViewModel
     /// </summary>
    public partial class BuildingSystemComponentViewModel : ViewModelBase, Interfaces.IBuildingSystemComponentViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSystemComponent";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the InstallationDate property
        private System.String _InstallationDate;

        // member variable for the LifecycleCost property
        private System.Decimal? _LifecycleCost;

        // member variable for the ComponentOrFixtureUsefulLife property
        private System.Int32? _ComponentOrFixtureUsefulLife;

        // member variable for the BuildingInstitutionalEquipmentDescription property
        private System.String _BuildingInstitutionalEquipmentDescription;

        // member variable for the RefFacilityFurnishingsTypeId property
        private Guid? _RefFacilityFurnishingsTypeId;

        // member variable for the RefFacilitySystemOrComponentConditionId property
        private Guid? _RefFacilitySystemOrComponentConditionId;

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
        /// The title of the BuildingSystemComponentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String InstallationDate  { get => _InstallationDate; set => SetProperty(ref _InstallationDate, value); }

        public System.Decimal? LifecycleCost { get => _LifecycleCost; set => SetProperty(ref _LifecycleCost, value); }

        public System.Int32? ComponentOrFixtureUsefulLife { get => _ComponentOrFixtureUsefulLife; set => SetProperty(ref _ComponentOrFixtureUsefulLife, value); }

        public System.String BuildingInstitutionalEquipmentDescription  { get => _BuildingInstitutionalEquipmentDescription; set => SetProperty(ref _BuildingInstitutionalEquipmentDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityFurnishingsTypeId"/> model
        /// </summary>
        public Guid? RefFacilityFurnishingsTypeId { get => _RefFacilityFurnishingsTypeId; set => SetProperty(ref _RefFacilityFurnishingsTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySystemOrComponentConditionId"/> model
        /// </summary>
        public Guid? RefFacilitySystemOrComponentConditionId { get => _RefFacilitySystemOrComponentConditionId; set => SetProperty(ref _RefFacilitySystemOrComponentConditionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSystemComponent model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            Identifier = model.Identifier;
            Description = model.Description;
            InstallationDate = model.InstallationDate;
            LifecycleCost = model.LifecycleCost;
            ComponentOrFixtureUsefulLife = model.ComponentOrFixtureUsefulLife;
            BuildingInstitutionalEquipmentDescription = model.BuildingInstitutionalEquipmentDescription;
            RefFacilityFurnishingsTypeId = model.RefFacilityFurnishingsTypeId;
            RefFacilitySystemOrComponentConditionId = model.RefFacilitySystemOrComponentConditionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
