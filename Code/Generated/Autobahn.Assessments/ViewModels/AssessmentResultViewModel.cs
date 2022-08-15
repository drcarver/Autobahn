//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentResultViewModel
     /// </summary>
    public partial class AssessmentResultViewModel : ViewModelBase, Interfaces.IAssessmentResult
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentResult";

        // member variable for the ScoreValue property
        private System.String _ScoreValue;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentResultViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The score given to a person's response to an assessment item.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19700">Assessment Item Response Score Value</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Item Response Score Value")]
        public System.String ScoreValue { get => _ScoreValue; set => SetProperty(ref _ScoreValue, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentResult model)
        {
            IsBusy = true;
            Id = model.Id;
            ScoreValue = model.ScoreValue; // Assessment Item Response Score Value
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
