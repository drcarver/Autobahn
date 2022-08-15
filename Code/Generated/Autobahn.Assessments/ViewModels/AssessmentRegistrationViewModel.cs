//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentRegistrationViewModel
     /// </summary>
    public partial class AssessmentRegistrationViewModel : ViewModelBase, Interfaces.IAssessmentRegistration
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentRegistration";

        // member variable for the RefAssessmentParticipationIndicatorId property
        private Guid? _RefAssessmentParticipationIndicatorId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentRegistrationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentParticipationIndicator"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19025">Assessment Registration Participation Indicator</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Registration Participation Indicator")]
        public Guid? RefAssessmentParticipationIndicatorId { get => _RefAssessmentParticipationIndicatorId; set => SetProperty(ref _RefAssessmentParticipationIndicatorId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentRegistration model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAssessmentParticipationIndicatorId = model.RefAssessmentParticipationIndicatorId; // Assessment Registration Participation Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
