//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffEmploymentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the HourlyWage property
        private System.Decimal? _HourlyWage;

        // member variable for the HoursWorkedPerWeek property
        private System.Decimal? _HoursWorkedPerWeek;

        // member variable for the RefELEducationStaffClassificationId property
        private Guid? _RefELEducationStaffClassificationId;

        // member variable for the RefELEmploymentSeparationReasonId property
        private Guid? _RefELEmploymentSeparationReasonId;

        // member variable for the RefELServiceProfessionalStaffClassificationId property
        private Guid? _RefELServiceProfessionalStaffClassificationId;

        // member variable for the RefEmploymentStatusId property
        private Guid? _RefEmploymentStatusId;

        // member variable for the RefWageCollectionMethodId property
        private Guid? _RefWageCollectionMethodId;

        // member variable for the RefWageVerificationId property
        private Guid? _RefWageVerificationId;

        // member variable for the StaffApprovalIndicator property
        private System.Boolean? _StaffApprovalIndicator;

        // member variable for the StaffEmploymentId property
        private Guid _StaffEmploymentId;

        // member variable for the UnionMembershipStatus property
        private System.Boolean? _UnionMembershipStatus;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELStaffEmploymentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public System.Decimal? HourlyWage { get => _HourlyWage; set => SetProperty(ref _HourlyWage, value); }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public System.Decimal? HoursWorkedPerWeek { get => _HoursWorkedPerWeek; set => SetProperty(ref _HoursWorkedPerWeek, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELEducationStaffClassification"/> model
        /// </summary>
        public Guid? RefELEducationStaffClassificationId { get => _RefELEducationStaffClassificationId; set => SetProperty(ref _RefELEducationStaffClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELEmploymentSeparationReason"/> model
        /// </summary>
        public Guid? RefELEmploymentSeparationReasonId { get => _RefELEmploymentSeparationReasonId; set => SetProperty(ref _RefELEmploymentSeparationReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELServiceProfessionalStaffClassification"/> model
        /// </summary>
        public Guid? RefELServiceProfessionalStaffClassificationId { get => _RefELServiceProfessionalStaffClassificationId; set => SetProperty(ref _RefELServiceProfessionalStaffClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
        /// </summary>
        public Guid? RefEmploymentStatusId { get => _RefEmploymentStatusId; set => SetProperty(ref _RefEmploymentStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWageCollectionMethod"/> model
        /// </summary>
        public Guid? RefWageCollectionMethodId { get => _RefWageCollectionMethodId; set => SetProperty(ref _RefWageCollectionMethodId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWageVerification"/> model
        /// </summary>
        public Guid? RefWageVerificationId { get => _RefWageVerificationId; set => SetProperty(ref _RefWageVerificationId, value); }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public System.Boolean? StaffApprovalIndicator { get => _StaffApprovalIndicator; set => SetProperty(ref _StaffApprovalIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="StaffEmployment"/> model
        /// </summary>
        public Guid StaffEmploymentId { get => _StaffEmploymentId; set => SetProperty(ref _StaffEmploymentId, value); }

        /// <summary>
        /// The condition under which a person has agreed to serve as an employee.
        /// </summary>
        public System.Boolean? UnionMembershipStatus { get => _UnionMembershipStatus; set => SetProperty(ref _UnionMembershipStatus, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELStaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            HourlyWage = model.HourlyWage;
            HoursWorkedPerWeek = model.HoursWorkedPerWeek;
            RefELEducationStaffClassificationId = model.RefELEducationStaffClassificationId;
            RefELEmploymentSeparationReasonId = model.RefELEmploymentSeparationReasonId;
            RefELServiceProfessionalStaffClassificationId = model.RefELServiceProfessionalStaffClassificationId;
            RefEmploymentStatusId = model.RefEmploymentStatusId;
            RefWageCollectionMethodId = model.RefWageCollectionMethodId;
            RefWageVerificationId = model.RefWageVerificationId;
            StaffApprovalIndicator = model.StaffApprovalIndicator;
            StaffEmploymentId = model.StaffEmploymentId;
            UnionMembershipStatus = model.UnionMembershipStatus;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
