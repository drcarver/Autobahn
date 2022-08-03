//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityEnergyViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityEnergyViewModel
     /// </summary>
    public partial class FacilityEnergyViewModel : BindableBase, IFacilityEnergy
    {
#region "Backing Fields"
        // member variable for the BuildingEnergyServiceCompanyName property
        private System.String _BuildingEnergyServiceCompanyName;

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

        public System.String BuildingEnergyServiceCompanyName  { get => _BuildingEnergyServiceCompanyName; set => SetProperty(ref _BuildingEnergyServiceCompanyName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnergySourceTypeId"/> model
        /// </summary>
        public Guid? RefBuildingEnergySourceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityProviderTypeId"/> model
        /// </summary>
        public Guid? RefFacilityUtilityProviderTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityUtilityTypeId"/> model
        /// </summary>
        public Guid? RefFacilityUtilityTypeId { get; set; }

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
        public void Load(IFacilityEnergy model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId;
            BuildingEnergyServiceCompanyName = model.BuildingEnergyServiceCompanyName;
            RefBuildingEnergySourceTypeId = model.RefBuildingEnergySourceTypeId;
            RefFacilityUtilityProviderTypeId = model.RefFacilityUtilityProviderTypeId;
            RefFacilityUtilityTypeId = model.RefFacilityUtilityTypeId;
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
