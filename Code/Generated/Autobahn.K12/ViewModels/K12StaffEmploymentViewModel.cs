//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StaffEmploymentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the StaffEmploymentId property
        private Guid _StaffEmploymentId;

        // member variable for the ContractDaysOfServicePerYear property
        private System.Decimal? _ContractDaysOfServicePerYear;

        // member variable for the MepPersonnelIndicator property
        private System.Boolean? _MepPersonnelIndicator;

        // member variable for the TitleITargetedAssistanceStaffFunded property
        private System.Boolean? _TitleITargetedAssistanceStaffFunded;

        // member variable for the SalaryForTeachingAssignmentOnlyIndicator property
        private System.Boolean? _SalaryForTeachingAssignmentOnlyIndicator;

        // member variable for the RefK12StaffClassificationId property
        private Guid? _RefK12StaffClassificationId;

        // member variable for the RefEmploymentStatusId property
        private Guid? _RefEmploymentStatusId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the K12StaffEmploymentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="StaffEmploymentId"/> model
        /// </summary>
        public Guid StaffEmploymentId { get => _StaffEmploymentId; set => SetProperty(ref _StaffEmploymentId, value); }

        public System.Decimal? ContractDaysOfServicePerYear { get => _ContractDaysOfServicePerYear; set => SetProperty(ref _ContractDaysOfServicePerYear, value); }

        public System.Boolean? MepPersonnelIndicator { get => _MepPersonnelIndicator; set => SetProperty(ref _MepPersonnelIndicator, value); }

        public System.Boolean? TitleITargetedAssistanceStaffFunded { get => _TitleITargetedAssistanceStaffFunded; set => SetProperty(ref _TitleITargetedAssistanceStaffFunded, value); }

        public System.Boolean? SalaryForTeachingAssignmentOnlyIndicator { get => _SalaryForTeachingAssignmentOnlyIndicator; set => SetProperty(ref _SalaryForTeachingAssignmentOnlyIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12StaffClassificationId"/> model
        /// </summary>
        public Guid? RefK12StaffClassificationId { get => _RefK12StaffClassificationId; set => SetProperty(ref _RefK12StaffClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatusId"/> model
        /// </summary>
        public Guid? RefEmploymentStatusId { get => _RefEmploymentStatusId; set => SetProperty(ref _RefEmploymentStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            StaffEmploymentId = model.StaffEmploymentId;
            ContractDaysOfServicePerYear = model.ContractDaysOfServicePerYear;
            MepPersonnelIndicator = model.MepPersonnelIndicator;
            TitleITargetedAssistanceStaffFunded = model.TitleITargetedAssistanceStaffFunded;
            SalaryForTeachingAssignmentOnlyIndicator = model.SalaryForTeachingAssignmentOnlyIndicator;
            RefK12StaffClassificationId = model.RefK12StaffClassificationId;
            RefEmploymentStatusId = model.RefEmploymentStatusId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
