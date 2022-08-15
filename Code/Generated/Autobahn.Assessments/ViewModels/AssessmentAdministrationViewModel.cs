//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAdministrationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentAdministrationViewModel
     /// </summary>
    public partial class AssessmentAdministrationViewModel : ViewModelBase, Interfaces.IAssessmentAdministration
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentAdministration";

        // member variable for the AssessmentSecureIndicator property
        private System.Boolean? _AssessmentSecureIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentAdministrationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Indicates whether or not the assessment is a secure assessment.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19375">Assessment Secure Indicator</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Secure Indicator")]
        public System.Boolean? AssessmentSecureIndicator { get => _AssessmentSecureIndicator; set => SetProperty(ref _AssessmentSecureIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentAdministration model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentSecureIndicator = model.AssessmentSecureIndicator; // Assessment Secure Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
