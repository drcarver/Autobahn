//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSystemComponentViewModel
     /// </summary>
    public partial class BuildingSystemComponentViewModel : ViewModelBase, Interfaces.IBuildingSystemComponent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSystemComponent";

        // member variable for the BuildingInstitutionalEquipmentDescription property
        private  _BuildingInstitutionalEquipmentDescription;

        // member variable for the ComponentOrFixtureUsefulLife property
        private  _ComponentOrFixtureUsefulLife;

        // member variable for the Identifier property
        private  _Identifier;

        // member variable for the InstallationDate property
        private  _InstallationDate;

        // member variable for the LifecycleCost property
        private  _LifecycleCost;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFacilityFurnishingsTypeId property
        private  _RefFacilityFurnishingsTypeId;

        // member variable for the RefFacilitySystemOrComponentConditionId property
        private Guid? _RefFacilitySystemOrComponentConditionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  BuildingInstitutionalEquipmentDescription { get => _BuildingInstitutionalEquipmentDescription; set => SetProperty(ref _BuildingInstitutionalEquipmentDescription, value); }

        /// <summary>
        /// </summary>
        public  ComponentOrFixtureUsefulLife { get => _ComponentOrFixtureUsefulLife; set => SetProperty(ref _ComponentOrFixtureUsefulLife, value); }

        /// <summary>
        /// </summary>
        public  Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// </summary>
        public  InstallationDate { get => _InstallationDate; set => SetProperty(ref _InstallationDate, value); }

        /// <summary>
        /// </summary>
        public  LifecycleCost { get => _LifecycleCost; set => SetProperty(ref _LifecycleCost, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityFurnishingsType"/> model
        /// </summary>
        public  RefFacilityFurnishingsTypeId { get => _RefFacilityFurnishingsTypeId; set => SetProperty(ref _RefFacilityFurnishingsTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySystemOrComponentCondition"/> model
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
            BuildingInstitutionalEquipmentDescription = model.BuildingInstitutionalEquipmentDescription; // 
            ComponentOrFixtureUsefulLife = model.ComponentOrFixtureUsefulLife; // 
            Identifier = model.Identifier; // 
            InstallationDate = model.InstallationDate; // 
            LifecycleCost = model.LifecycleCost; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFacilityFurnishingsTypeId = model.RefFacilityFurnishingsTypeId; // 
            RefFacilitySystemOrComponentConditionId = model.RefFacilitySystemOrComponentConditionId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
