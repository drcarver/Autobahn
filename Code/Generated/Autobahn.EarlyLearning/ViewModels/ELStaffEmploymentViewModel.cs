//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELStaffEmploymentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELStaffEmploymentViewModel
     /// </summary>
    public partial class ELStaffEmploymentViewModel : ViewModelBase, Interfaces.IELStaffEmployment
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELStaffEmployment";

        // member variable for the StaffEmploymentId property
        private Guid _StaffEmploymentId;

        // member variable for the HoursWorkedPerWeek property
        private System.Decimal? _HoursWorkedPerWeek;

        // member variable for the HourlyWage property
        private System.Decimal? _HourlyWage;

        // member variable for the UnionMembershipStatus property
        private System.Boolean? _UnionMembershipStatus;

        // member variable for the StaffApprovalIndicator property
        private System.Boolean? _StaffApprovalIndicator;

        // member variable for the RefEmploymentStatusId property
        private Guid? _RefEmploymentStatusId;

        // member variable for the RefWageCollectionMethodId property
        private Guid? _RefWageCollectionMethodId;

        // member variable for the RefWageVerificationId property
        private Guid? _RefWageVerificationId;

        // member variable for the RefELEducationStaffClassificationId property
        private Guid? _RefELEducationStaffClassificationId;

        // member variable for the RefELEmploymentSeparationReasonId property
        private Guid? _RefELEmploymentSeparationReasonId;

        // member variable for the RefELServiceProfessionalStaffClassificationId property
        private Guid? _RefELServiceProfessionalStaffClassificationId;

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
        /// The title of the ELStaffEmploymentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="StaffEmploymentId"/> model
        /// </summary>
        public Guid StaffEmploymentId { get => _StaffEmploymentId; set => SetProperty(ref _StaffEmploymentId, value); }

        public System.Decimal? HoursWorkedPerWeek { get => _HoursWorkedPerWeek; set => SetProperty(ref _HoursWorkedPerWeek, value); }

        public System.Decimal? HourlyWage { get => _HourlyWage; set => SetProperty(ref _HourlyWage, value); }

        public System.Boolean? UnionMembershipStatus { get => _UnionMembershipStatus; set => SetProperty(ref _UnionMembershipStatus, value); }

        public System.Boolean? StaffApprovalIndicator { get => _StaffApprovalIndicator; set => SetProperty(ref _StaffApprovalIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatusId"/> model
        /// </summary>
        public Guid? RefEmploymentStatusId { get => _RefEmploymentStatusId; set => SetProperty(ref _RefEmploymentStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWageCollectionMethodId"/> model
        /// </summary>
        public Guid? RefWageCollectionMethodId { get => _RefWageCollectionMethodId; set => SetProperty(ref _RefWageCollectionMethodId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWageVerificationId"/> model
        /// </summary>
        public Guid? RefWageVerificationId { get => _RefWageVerificationId; set => SetProperty(ref _RefWageVerificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELEducationStaffClassificationId"/> model
        /// </summary>
        public Guid? RefELEducationStaffClassificationId { get => _RefELEducationStaffClassificationId; set => SetProperty(ref _RefELEducationStaffClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELEmploymentSeparationReasonId"/> model
        /// </summary>
        public Guid? RefELEmploymentSeparationReasonId { get => _RefELEmploymentSeparationReasonId; set => SetProperty(ref _RefELEmploymentSeparationReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELServiceProfessionalStaffClassificationId"/> model
        /// </summary>
        public Guid? RefELServiceProfessionalStaffClassificationId { get => _RefELServiceProfessionalStaffClassificationId; set => SetProperty(ref _RefELServiceProfessionalStaffClassificationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELStaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            StaffEmploymentId = model.StaffEmploymentId;
            HoursWorkedPerWeek = model.HoursWorkedPerWeek;
            HourlyWage = model.HourlyWage;
            UnionMembershipStatus = model.UnionMembershipStatus;
            StaffApprovalIndicator = model.StaffApprovalIndicator;
            RefEmploymentStatusId = model.RefEmploymentStatusId;
            RefWageCollectionMethodId = model.RefWageCollectionMethodId;
            RefWageVerificationId = model.RefWageVerificationId;
            RefELEducationStaffClassificationId = model.RefELEducationStaffClassificationId;
            RefELEmploymentSeparationReasonId = model.RefELEmploymentSeparationReasonId;
            RefELServiceProfessionalStaffClassificationId = model.RefELServiceProfessionalStaffClassificationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
