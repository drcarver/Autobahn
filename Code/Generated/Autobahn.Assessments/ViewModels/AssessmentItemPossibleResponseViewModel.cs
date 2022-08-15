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

        // member variable for the FeedbackMessage property
        private System.String _FeedbackMessage;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemPossibleResponseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19904">Assessment Item Possible Response Feedback Message</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Item Possible Response Feedback Message")]
        public System.String FeedbackMessage { get => _FeedbackMessage; set => SetProperty(ref _FeedbackMessage, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemPossibleResponse model)
        {
            IsBusy = true;
            Id = model.Id;
            FeedbackMessage = model.FeedbackMessage; // Assessment Item Possible Response Feedback Message
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
