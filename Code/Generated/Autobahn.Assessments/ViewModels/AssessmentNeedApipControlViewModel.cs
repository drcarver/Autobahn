//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipControlViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentNeedApipControlViewModel
     /// </summary>
    public partial class AssessmentNeedApipControlViewModel : ViewModelBase, Interfaces.IAssessmentNeedApipControl
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedApipControl";

        // member variable for the AssessmentNeedTimeMultiplier property
        private System.String _AssessmentNeedTimeMultiplier;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentNeedApipControlViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20055">Assessment Need Time Multiplier</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Need Time Multiplier")]
        public System.String AssessmentNeedTimeMultiplier { get => _AssessmentNeedTimeMultiplier; set => SetProperty(ref _AssessmentNeedTimeMultiplier, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedApipControl model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentNeedTimeMultiplier = model.AssessmentNeedTimeMultiplier; // Assessment Need Time Multiplier
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
