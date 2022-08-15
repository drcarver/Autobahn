//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileViewModel : ViewModelBase, Interfaces.IAssessmentPersonalNeedsProfile
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPersonalNeedsProfile";

        // member variable for the AssignedSupportFlag property
        private System.Boolean? _AssignedSupportFlag;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentPersonalNeedsProfileViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20007">Assessment Personal Needs Profile Assigned Support</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Personal Needs Profile Assigned Support")]
        public System.Boolean? AssignedSupportFlag { get => _AssignedSupportFlag; set => SetProperty(ref _AssignedSupportFlag, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedsProfile model)
        {
            IsBusy = true;
            Id = model.Id;
            AssignedSupportFlag = model.AssignedSupportFlag; // Assessment Personal Needs Profile Assigned Support
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
