//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramEligibilityViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramEligibilityViewModel
     /// </summary>
    public partial class IndividualizedProgramEligibilityViewModel : BindableBase, IIndividualizedProgramEligibility
    {
#region "Backing Fields"
        // member variable for the ConsentToEvaluateDate property
        private System.DateTime? _ConsentToEvaluateDate;

        // member variable for the ConsentToEvaluateIndicator property
        private System.Boolean? _ConsentToEvaluateIndicator;

        // member variable for the ParentObservations property
        private System.String _ParentObservations;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramId"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        public System.DateTime? ConsentToEvaluateDate { get => _ConsentToEvaluateDate; set => SetProperty(ref _ConsentToEvaluateDate, value); }

        public System.Boolean? ConsentToEvaluateIndicator { get => _ConsentToEvaluateIndicator; set => SetProperty(ref _ConsentToEvaluateIndicator, value); }

        public System.String ParentObservations  { get => _ParentObservations; set => SetProperty(ref _ParentObservations, value); }

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
        public void Load(IIndividualizedProgramEligibility model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId;
            ConsentToEvaluateDate = model.ConsentToEvaluateDate;
            ConsentToEvaluateIndicator = model.ConsentToEvaluateIndicator;
            ParentObservations = model.ParentObservations;
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
