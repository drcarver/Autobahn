//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemPossibleResponseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentItemPossibleResponseViewModel
     /// </summary>
    public partial class AssessmentItemPossibleResponseViewModel : ViewModelBase, Interfaces.IAssessmentItemPossibleResponseViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemPossibleResponse";

        // member variable for the AssessmentItemId property
        private Guid _AssessmentItemId;

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

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemPossibleResponseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemId"/> model
        /// </summary>
        public Guid AssessmentItemId { get => _AssessmentItemId; set => SetProperty(ref _AssessmentItemId, value); }

        public System.String PossibleResponseOption  { get => _PossibleResponseOption; set => SetProperty(ref _PossibleResponseOption, value); }

        public System.String Value  { get => _Value; set => SetProperty(ref _Value, value); }

        public System.Boolean? CorrectIndicator { get => _CorrectIndicator; set => SetProperty(ref _CorrectIndicator, value); }

        public System.String FeedbackMessage  { get => _FeedbackMessage; set => SetProperty(ref _FeedbackMessage, value); }

        public System.Int32? SequenceNumber { get => _SequenceNumber; set => SetProperty(ref _SequenceNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemPossibleResponse model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemId = model.AssessmentItemId;
            PossibleResponseOption = model.PossibleResponseOption;
            Value = model.Value;
            CorrectIndicator = model.CorrectIndicator;
            FeedbackMessage = model.FeedbackMessage;
            SequenceNumber = model.SequenceNumber;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
