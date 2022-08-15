//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipDisplayViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentNeedApipDisplayViewModel
     /// </summary>
    public partial class AssessmentNeedApipDisplayViewModel : ViewModelBase, Interfaces.IAssessmentNeedApipDisplay
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedApipDisplay";

        // member variable for the EncouragementAssignedSupportIndicator property
        private System.Boolean? _EncouragementAssignedSupportIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentNeedApipDisplayViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20007">Assessment Personal Needs Profile Assigned Support</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Personal Needs Profile Assigned Support")]
        public System.Boolean? EncouragementAssignedSupportIndicator { get => _EncouragementAssignedSupportIndicator; set => SetProperty(ref _EncouragementAssignedSupportIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedApipDisplay model)
        {
            IsBusy = true;
            Id = model.Id;
            EncouragementAssignedSupportIndicator = model.EncouragementAssignedSupportIndicator; // Assessment Personal Needs Profile Assigned Support
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
