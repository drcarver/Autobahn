//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemResponseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentItemResponseViewModel
     /// </summary>
    public partial class AssessmentItemResponseViewModel : ViewModelBase, Interfaces.IAssessmentItemResponse
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemResponse";

        // member variable for the Duration property
        private System.TimeSpan? _Duration;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemResponseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19394">Assessment Item Response Duration</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Item Response Duration")]
        public System.TimeSpan? Duration { get => _Duration; set => SetProperty(ref _Duration, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemResponse model)
        {
            IsBusy = true;
            Id = model.Id;
            Duration = model.Duration; // Assessment Item Response Duration
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
