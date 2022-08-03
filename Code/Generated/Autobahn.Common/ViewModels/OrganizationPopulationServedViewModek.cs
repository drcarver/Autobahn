//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPopulationServedViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPopulationServedViewModel
     /// </summary>
    public partial class OrganizationPopulationServedViewModel : BindableBase, IOrganizationPopulationServed
    {
#region "Backing Fields"
        // member variable for the AgeUnit property
        private System.String _AgeUnit;

        // member variable for the OldestAgeServed property
        private System.Int32? _OldestAgeServed;

        // member variable for the YoungestAgeServed property
        private System.Int32? _YoungestAgeServed;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        public System.String AgeUnit  { get => _AgeUnit; set => SetProperty(ref _AgeUnit, value); }

        public System.Int32? OldestAgeServed { get => _OldestAgeServed; set => SetProperty(ref _OldestAgeServed, value); }

        public System.Int32? YoungestAgeServed { get => _YoungestAgeServed; set => SetProperty(ref _YoungestAgeServed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPopulationServedId"/> model
        /// </summary>
        public Guid? RefPopulationServedId { get; set; }

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
        public void Load(IOrganizationPopulationServed model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            AgeUnit = model.AgeUnit;
            OldestAgeServed = model.OldestAgeServed;
            YoungestAgeServed = model.YoungestAgeServed;
            RefPopulationServedId = model.RefPopulationServedId;
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
