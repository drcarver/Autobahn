//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSessionStaffRoleViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentSessionStaffRoleViewModel
     /// </summary>
    public partial class AssessmentSessionStaffRoleViewModel : ViewModelBase, Interfaces.IAssessmentSessionStaffRole
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSessionStaffRole";

        // member variable for the RefAssessmentSessionStaffRoleTypeId property
        private Guid? _RefAssessmentSessionStaffRoleTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentSessionStaffRoleViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionStaffRoleType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20179">Assessment Session Staff Role Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Session Staff Role Type")]
        public Guid? RefAssessmentSessionStaffRoleTypeId { get => _RefAssessmentSessionStaffRoleTypeId; set => SetProperty(ref _RefAssessmentSessionStaffRoleTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSessionStaffRole model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAssessmentSessionStaffRoleTypeId = model.RefAssessmentSessionStaffRoleTypeId; // Assessment Session Staff Role Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
