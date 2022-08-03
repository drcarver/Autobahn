//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemPossibleResponseViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentItemPossibleResponseViewModel
     /// </summary>
    public partial class AssessmentItemPossibleResponseViewModel : BindableBase, IAssessmentItemPossibleResponse
    {
#region "Backing Fields"
        // member variable for the PossibleResponseOption property
        private System.String _PossibleResponseOption;

        // member variable for the Value property
        private System.String _Value;

        // member variable for the CorrectIndicator property
        private System.Boolean? _CorrectIndicator;

        // member variable for the FeedbackMessage property
        private System.String _FeedbackMessage;

        // member variable for the SequenceNumber property
        private System.Int32? _SequenceNumber;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemId"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        public System.String PossibleResponseOption  { get => _PossibleResponseOption; set => SetProperty(ref _PossibleResponseOption, value); }

        public System.String Value  { get => _Value; set => SetProperty(ref _Value, value); }

        public System.Boolean? CorrectIndicator { get => _CorrectIndicator; set => SetProperty(ref _CorrectIndicator, value); }

        public System.String FeedbackMessage  { get => _FeedbackMessage; set => SetProperty(ref _FeedbackMessage, value); }

        public System.Int32? SequenceNumber { get => _SequenceNumber; set => SetProperty(ref _SequenceNumber, value); }

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
        public void Load(IAssessmentItemPossibleResponse model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemId = model.AssessmentItemId;
            PossibleResponseOption = model.PossibleResponseOption;
            Value = model.Value;
            CorrectIndicator = model.CorrectIndicator;
            FeedbackMessage = model.FeedbackMessage;
            SequenceNumber = model.SequenceNumber;
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
