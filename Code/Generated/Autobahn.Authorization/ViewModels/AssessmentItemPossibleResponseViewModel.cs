//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentItemPossibleResponseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentItemPossibleResponseViewModel
     /// </summary>
    public partial class AssessmentItemPossibleResponseViewModel : ViewModelBase, Interfaces.IAssessmentItemPossibleResponse
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemPossibleResponse";

        // member variable for the AssessmentItemId property
        private Guid _AssessmentItemId;

        // member variable for the CorrectIndicator property
        private System.Boolean? _CorrectIndicator;

        // member variable for the FeedbackMessage property
        private System.String _FeedbackMessage;

        // member variable for the PossibleResponseOption property
        private System.String _PossibleResponseOption;

        // member variable for the SequenceNumber property
        private System.Int32? _SequenceNumber;

        // member variable for the Value property
        private System.String _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemPossibleResponseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get => _AssessmentItemId; set => SetProperty(ref _AssessmentItemId, value); }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        public System.Boolean? CorrectIndicator { get => _CorrectIndicator; set => SetProperty(ref _CorrectIndicator, value); }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        public System.String FeedbackMessage { get => _FeedbackMessage; set => SetProperty(ref _FeedbackMessage, value); }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        public System.String PossibleResponseOption { get => _PossibleResponseOption; set => SetProperty(ref _PossibleResponseOption, value); }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        public System.Int32? SequenceNumber { get => _SequenceNumber; set => SetProperty(ref _SequenceNumber, value); }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        public System.String Value { get => _Value; set => SetProperty(ref _Value, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemPossibleResponse model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemId = model.AssessmentItemId;
            CorrectIndicator = model.CorrectIndicator;
            FeedbackMessage = model.FeedbackMessage;
            PossibleResponseOption = model.PossibleResponseOption;
            SequenceNumber = model.SequenceNumber;
            Value = model.Value;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
