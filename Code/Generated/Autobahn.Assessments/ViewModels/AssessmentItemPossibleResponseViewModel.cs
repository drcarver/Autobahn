//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemPossibleResponseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentItemPossibleResponseViewModel
     /// </summary>
    public partial class AssessmentItemPossibleResponseViewModel : ViewModelBase, Interfaces.IAssessmentItemPossibleResponse
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemPossibleResponse";

        // member variable for the CorrectIndicator property
        private  _CorrectIndicator;

        // member variable for the FeedbackMessage property
        private Guid? _FeedbackMessage;

        // member variable for the PossibleResponseOption property
        private  _PossibleResponseOption;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the SequenceNumber property
        private  _SequenceNumber;

        // member variable for the Value property
        private  _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  CorrectIndicator { get => _CorrectIndicator; set => SetProperty(ref _CorrectIndicator, value); }

        /// <summary>
        /// </summary>
        public Guid? FeedbackMessage { get => _FeedbackMessage; set => SetProperty(ref _FeedbackMessage, value); }

        /// <summary>
        /// </summary>
        public  PossibleResponseOption { get => _PossibleResponseOption; set => SetProperty(ref _PossibleResponseOption, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  SequenceNumber { get => _SequenceNumber; set => SetProperty(ref _SequenceNumber, value); }

        /// <summary>
        /// </summary>
        public  Value { get => _Value; set => SetProperty(ref _Value, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemPossibleResponse model)
        {
            IsBusy = true;
            Id = model.Id;
            CorrectIndicator = model.CorrectIndicator; // 
            FeedbackMessage = model.FeedbackMessage; // 
            PossibleResponseOption = model.PossibleResponseOption; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            SequenceNumber = model.SequenceNumber; // 
            Value = model.Value; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
