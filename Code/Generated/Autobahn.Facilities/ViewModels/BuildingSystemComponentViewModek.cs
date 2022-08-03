//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   BuildingSystemComponentViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSystemComponentViewModel
     /// </summary>
    public partial class BuildingSystemComponentViewModel : BindableBase, IBuildingSystemComponent
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityId"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String InstallationDate  { get => _InstallationDate; set => SetProperty(ref _InstallationDate, value); }

        public System.Decimal? LifecycleCost { get => _LifecycleCost; set => SetProperty(ref _LifecycleCost, value); }

        public System.Int32? ComponentOrFixtureUsefulLife { get => _ComponentOrFixtureUsefulLife; set => SetProperty(ref _ComponentOrFixtureUsefulLife, value); }

        public System.String BuildingInstitutionalEquipmentDescription  { get => _BuildingInstitutionalEquipmentDescription; set => SetProperty(ref _BuildingInstitutionalEquipmentDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityFurnishingsTypeId"/> model
        /// </summary>
        public Guid? RefFacilityFurnishingsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySystemOrComponentConditionId"/> model
        /// </summary>
        public Guid? RefFacilitySystemOrComponentConditionId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IBuildingSystemComponent model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
