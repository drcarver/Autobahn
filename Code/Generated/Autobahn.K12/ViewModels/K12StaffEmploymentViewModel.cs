//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffEmploymentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StaffEmploymentViewModel
     /// </summary>
    public partial class K12StaffEmploymentViewModel : ViewModelBase, Interfaces.IK12StaffEmployment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StaffEmployment";

        // member variable for the ContractDaysOfServicePerYear property
        private Guid? _ContractDaysOfServicePerYear;

        // member variable for the MepPersonnelIndicator property
        private  _MepPersonnelIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefEmploymentStatusId property
        private  _RefEmploymentStatusId;

        // member variable for the RefK12StaffClassificationId property
        private  _RefK12StaffClassificationId;

        // member variable for the SalaryForTeachingAssignmentOnlyIndicator property
        private  _SalaryForTeachingAssignmentOnlyIndicator;

        // member variable for the TitleITargetedAssistanceStaffFunded property
        private  _TitleITargetedAssistanceStaffFunded;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? ContractDaysOfServicePerYear { get => _ContractDaysOfServicePerYear; set => SetProperty(ref _ContractDaysOfServicePerYear, value); }

        /// <summary>
        /// </summary>
        public  MepPersonnelIndicator { get => _MepPersonnelIndicator; set => SetProperty(ref _MepPersonnelIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
        /// </summary>
        public  RefEmploymentStatusId { get => _RefEmploymentStatusId; set => SetProperty(ref _RefEmploymentStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12StaffClassification"/> model
        /// </summary>
        public  RefK12StaffClassificationId { get => _RefK12StaffClassificationId; set => SetProperty(ref _RefK12StaffClassificationId, value); }

        /// <summary>
        /// </summary>
        public  SalaryForTeachingAssignmentOnlyIndicator { get => _SalaryForTeachingAssignmentOnlyIndicator; set => SetProperty(ref _SalaryForTeachingAssignmentOnlyIndicator, value); }

        /// <summary>
        /// </summary>
        public  TitleITargetedAssistanceStaffFunded { get => _TitleITargetedAssistanceStaffFunded; set => SetProperty(ref _TitleITargetedAssistanceStaffFunded, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            ContractDaysOfServicePerYear = model.ContractDaysOfServicePerYear; // 
            MepPersonnelIndicator = model.MepPersonnelIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefEmploymentStatusId = model.RefEmploymentStatusId; // 
            RefK12StaffClassificationId = model.RefK12StaffClassificationId; // 
            SalaryForTeachingAssignmentOnlyIndicator = model.SalaryForTeachingAssignmentOnlyIndicator; // 
            TitleITargetedAssistanceStaffFunded = model.TitleITargetedAssistanceStaffFunded; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
