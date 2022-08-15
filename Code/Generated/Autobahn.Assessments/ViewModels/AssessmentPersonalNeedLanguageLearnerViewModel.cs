//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedLanguageLearnerViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedLanguageLearnerViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedLanguageLearnerViewModel : ViewModelBase, Interfaces.IAssessmentPersonalNeedLanguageLearner
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPersonalNeedLanguageLearner";

        // member variable for the AssignedSupport property
        private System.Boolean? _AssignedSupport;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentPersonalNeedLanguageLearnerViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20007">Assessment Personal Needs Profile Assigned Support</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Personal Needs Profile Assigned Support")]
        public System.Boolean? AssignedSupport { get => _AssignedSupport; set => SetProperty(ref _AssignedSupport, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedLanguageLearner model)
        {
            IsBusy = true;
            Id = model.Id;
            AssignedSupport = model.AssignedSupport; // Assessment Personal Needs Profile Assigned Support
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
