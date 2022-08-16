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

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentSessionStaffRoleTypeId property
        private Guid? _RefAssessmentSessionStaffRoleTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSessionStaffRoleType"/> model
        /// </summary>
        public Guid? RefAssessmentSessionStaffRoleTypeId { get => _RefAssessmentSessionStaffRoleTypeId; set => SetProperty(ref _RefAssessmentSessionStaffRoleTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSessionStaffRole model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentSessionStaffRoleTypeId = model.RefAssessmentSessionStaffRoleTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
