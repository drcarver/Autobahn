//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramServiceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramServiceViewModel
     /// </summary>
    public partial class IndividualizedProgramServiceViewModel : BindableBase, IIndividualizedProgramService
    {
#region "Backing Fields"
        // member variable for the PlannedServiceDuration property
        private System.Decimal? _PlannedServiceDuration;

        // member variable for the PlannedServiceStartDate property
        private System.DateTime? _PlannedServiceStartDate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramPlannedServiceTypeId"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramPlannedServiceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMethodOfServiceDeliveryId"/> model
        /// </summary>
        public Guid? RefMethodOfServiceDeliveryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceFrequencyId"/> model
        /// </summary>
        public Guid? RefServiceFrequencyId { get; set; }

        public System.Decimal? PlannedServiceDuration { get => _PlannedServiceDuration; set => SetProperty(ref _PlannedServiceDuration, value); }

        public System.DateTime? PlannedServiceStartDate { get => _PlannedServiceStartDate; set => SetProperty(ref _PlannedServiceStartDate, value); }

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
        public void Load(IIndividualizedProgramService model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefIndividualizedProgramPlannedServiceTypeId = model.RefIndividualizedProgramPlannedServiceTypeId;
            RefMethodOfServiceDeliveryId = model.RefMethodOfServiceDeliveryId;
            RefServiceFrequencyId = model.RefServiceFrequencyId;
            PlannedServiceDuration = model.PlannedServiceDuration;
            PlannedServiceStartDate = model.PlannedServiceStartDate;
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
