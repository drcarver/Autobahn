//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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
        private System.String _BuildingInstitutionalEquipmentDescription;

        // member variable for the ComponentOrFixtureUsefulLife property
        private System.Int32? _ComponentOrFixtureUsefulLife;

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the InstallationDate property
        private System.String _InstallationDate;

        // member variable for the LifecycleCost property
        private System.Decimal? _LifecycleCost;

        // member variable for the RefFacilityFurnishingsTypeId property
        private Guid? _RefFacilityFurnishingsTypeId;

        // member variable for the RefFacilitySystemOrComponentConditionId property
        private Guid? _RefFacilitySystemOrComponentConditionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the BuildingSystemComponentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        public System.String BuildingInstitutionalEquipmentDescription { get => _BuildingInstitutionalEquipmentDescription; set => SetProperty(ref _BuildingInstitutionalEquipmentDescription, value); }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        public System.Int32? ComponentOrFixtureUsefulLife { get => _ComponentOrFixtureUsefulLife; set => SetProperty(ref _ComponentOrFixtureUsefulLife, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Facility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        public System.String InstallationDate { get => _InstallationDate; set => SetProperty(ref _InstallationDate, value); }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        public System.Decimal? LifecycleCost { get => _LifecycleCost; set => SetProperty(ref _LifecycleCost, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityFurnishingsType"/> model
        /// </summary>
        public Guid? RefFacilityFurnishingsTypeId { get => _RefFacilityFurnishingsTypeId; set => SetProperty(ref _RefFacilityFurnishingsTypeId, value); }

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
            BuildingInstitutionalEquipmentDescription = model.BuildingInstitutionalEquipmentDescription;
            ComponentOrFixtureUsefulLife = model.ComponentOrFixtureUsefulLife;
            FacilityId = model.FacilityId;
            Identifier = model.Identifier;
            InstallationDate = model.InstallationDate;
            LifecycleCost = model.LifecycleCost;
            RefFacilityFurnishingsTypeId = model.RefFacilityFurnishingsTypeId;
            RefFacilitySystemOrComponentConditionId = model.RefFacilitySystemOrComponentConditionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
