//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentEnrollmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentEnrollmentViewModel
     /// </summary>
    public partial class K12StudentEnrollmentViewModel : ViewModelBase, Interfaces.IK12StudentEnrollment
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentEnrollment";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the DisplacedStudentStatus property
        private System.Boolean? _DisplacedStudentStatus;

        // member variable for the FirstEntryDateIntoUSSchool property
        private System.DateTime? _FirstEntryDateIntoUSSchool;

        // member variable for the NSLPDirectCertificationIndicator property
        private System.Boolean? _NSLPDirectCertificationIndicator;

        // member variable for the RefEntryGradeLevelId property
        private Guid? _RefEntryGradeLevelId;

        // member variable for the RefPublicSchoolResidence property
        private System.Int32? _RefPublicSchoolResidence;

        // member variable for the RefEnrollmentStatusId property
        private Guid? _RefEnrollmentStatusId;

        // member variable for the RefEntryType property
        private System.Int32? _RefEntryType;

        // member variable for the RefExitGradeLevelId property
        private Guid? _RefExitGradeLevelId;

        // member variable for the RefExitOrWithdrawalStatusId property
        private Guid? _RefExitOrWithdrawalStatusId;

        // member variable for the RefExitOrWithdrawalTypeId property
        private Guid? _RefExitOrWithdrawalTypeId;

        // member variable for the RefEndOfTermStatusId property
        private Guid? _RefEndOfTermStatusId;

        // member variable for the RefPromotionReasonId property
        private Guid? _RefPromotionReasonId;

        // member variable for the RefNonPromotionReasonId property
        private Guid? _RefNonPromotionReasonId;

        // member variable for the RefFoodServiceEligibilityId property
        private Guid? _RefFoodServiceEligibilityId;

        // member variable for the RefDirectoryInformationBlockStatusId property
        private Guid? _RefDirectoryInformationBlockStatusId;

        // member variable for the RefStudentEnrollmentAccessTypeId property
        private Guid? _RefStudentEnrollmentAccessTypeId;

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
        /// The title of the K12StudentEnrollmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Boolean? DisplacedStudentStatus { get => _DisplacedStudentStatus; set => SetProperty(ref _DisplacedStudentStatus, value); }

        public System.DateTime? FirstEntryDateIntoUSSchool { get => _FirstEntryDateIntoUSSchool; set => SetProperty(ref _FirstEntryDateIntoUSSchool, value); }

        public System.Boolean? NSLPDirectCertificationIndicator { get => _NSLPDirectCertificationIndicator; set => SetProperty(ref _NSLPDirectCertificationIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEntryGradeLevelId"/> model
        /// </summary>
        public Guid? RefEntryGradeLevelId { get => _RefEntryGradeLevelId; set => SetProperty(ref _RefEntryGradeLevelId, value); }

        public System.Int32? RefPublicSchoolResidence { get => _RefPublicSchoolResidence; set => SetProperty(ref _RefPublicSchoolResidence, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnrollmentStatusId"/> model
        /// </summary>
        public Guid? RefEnrollmentStatusId { get => _RefEnrollmentStatusId; set => SetProperty(ref _RefEnrollmentStatusId, value); }

        public System.Int32? RefEntryType { get => _RefEntryType; set => SetProperty(ref _RefEntryType, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitGradeLevelId"/> model
        /// </summary>
        public Guid? RefExitGradeLevelId { get => _RefExitGradeLevelId; set => SetProperty(ref _RefExitGradeLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatusId"/> model
        /// </summary>
        public Guid? RefExitOrWithdrawalStatusId { get => _RefExitOrWithdrawalStatusId; set => SetProperty(ref _RefExitOrWithdrawalStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalTypeId"/> model
        /// </summary>
        public Guid? RefExitOrWithdrawalTypeId { get => _RefExitOrWithdrawalTypeId; set => SetProperty(ref _RefExitOrWithdrawalTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEndOfTermStatusId"/> model
        /// </summary>
        public Guid? RefEndOfTermStatusId { get => _RefEndOfTermStatusId; set => SetProperty(ref _RefEndOfTermStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPromotionReasonId"/> model
        /// </summary>
        public Guid? RefPromotionReasonId { get => _RefPromotionReasonId; set => SetProperty(ref _RefPromotionReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNonPromotionReasonId"/> model
        /// </summary>
        public Guid? RefNonPromotionReasonId { get => _RefNonPromotionReasonId; set => SetProperty(ref _RefNonPromotionReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFoodServiceEligibilityId"/> model
        /// </summary>
        public Guid? RefFoodServiceEligibilityId { get => _RefFoodServiceEligibilityId; set => SetProperty(ref _RefFoodServiceEligibilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDirectoryInformationBlockStatusId"/> model
        /// </summary>
        public Guid? RefDirectoryInformationBlockStatusId { get => _RefDirectoryInformationBlockStatusId; set => SetProperty(ref _RefDirectoryInformationBlockStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentEnrollmentAccessTypeId"/> model
        /// </summary>
        public Guid? RefStudentEnrollmentAccessTypeId { get => _RefStudentEnrollmentAccessTypeId; set => SetProperty(ref _RefStudentEnrollmentAccessTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentEnrollment model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            DisplacedStudentStatus = model.DisplacedStudentStatus;
            FirstEntryDateIntoUSSchool = model.FirstEntryDateIntoUSSchool;
            NSLPDirectCertificationIndicator = model.NSLPDirectCertificationIndicator;
            RefEntryGradeLevelId = model.RefEntryGradeLevelId;
            RefPublicSchoolResidence = model.RefPublicSchoolResidence;
            RefEnrollmentStatusId = model.RefEnrollmentStatusId;
            RefEntryType = model.RefEntryType;
            RefExitGradeLevelId = model.RefExitGradeLevelId;
            RefExitOrWithdrawalStatusId = model.RefExitOrWithdrawalStatusId;
            RefExitOrWithdrawalTypeId = model.RefExitOrWithdrawalTypeId;
            RefEndOfTermStatusId = model.RefEndOfTermStatusId;
            RefPromotionReasonId = model.RefPromotionReasonId;
            RefNonPromotionReasonId = model.RefNonPromotionReasonId;
            RefFoodServiceEligibilityId = model.RefFoodServiceEligibilityId;
            RefDirectoryInformationBlockStatusId = model.RefDirectoryInformationBlockStatusId;
            RefStudentEnrollmentAccessTypeId = model.RefStudentEnrollmentAccessTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
