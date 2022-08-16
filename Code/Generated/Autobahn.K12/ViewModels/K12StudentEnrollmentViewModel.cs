//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentEnrollmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the DisplacedStudentStatus property
        private  _DisplacedStudentStatus;

        // member variable for the FirstEntryDateIntoUSSchool property
        private  _FirstEntryDateIntoUSSchool;

        // member variable for the NSLPDirectCertificationIndicator property
        private  _NSLPDirectCertificationIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefDirectoryInformationBlockStatusId property
        private  _RefDirectoryInformationBlockStatusId;

        // member variable for the RefEndOfTermStatusId property
        private  _RefEndOfTermStatusId;

        // member variable for the RefEnrollmentStatusId property
        private  _RefEnrollmentStatusId;

        // member variable for the RefEntryGradeLevelId property
        private  _RefEntryGradeLevelId;

        // member variable for the RefEntryType property
        private  _RefEntryType;

        // member variable for the RefExitGradeLevelId property
        private  _RefExitGradeLevelId;

        // member variable for the RefExitOrWithdrawalStatusId property
        private  _RefExitOrWithdrawalStatusId;

        // member variable for the RefExitOrWithdrawalTypeId property
        private  _RefExitOrWithdrawalTypeId;

        // member variable for the RefFoodServiceEligibilityId property
        private Guid? _RefFoodServiceEligibilityId;

        // member variable for the RefNonPromotionReasonId property
        private  _RefNonPromotionReasonId;

        // member variable for the RefPromotionReasonId property
        private  _RefPromotionReasonId;

        // member variable for the RefPublicSchoolResidence property
        private  _RefPublicSchoolResidence;

        // member variable for the RefStudentEnrollmentAccessTypeId property
        private  _RefStudentEnrollmentAccessTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  DisplacedStudentStatus { get => _DisplacedStudentStatus; set => SetProperty(ref _DisplacedStudentStatus, value); }

        /// <summary>
        /// </summary>
        public  FirstEntryDateIntoUSSchool { get => _FirstEntryDateIntoUSSchool; set => SetProperty(ref _FirstEntryDateIntoUSSchool, value); }

        /// <summary>
        /// </summary>
        public  NSLPDirectCertificationIndicator { get => _NSLPDirectCertificationIndicator; set => SetProperty(ref _NSLPDirectCertificationIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDirectoryInformationBlockStatus"/> model
        /// </summary>
        public  RefDirectoryInformationBlockStatusId { get => _RefDirectoryInformationBlockStatusId; set => SetProperty(ref _RefDirectoryInformationBlockStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEndOfTermStatus"/> model
        /// </summary>
        public  RefEndOfTermStatusId { get => _RefEndOfTermStatusId; set => SetProperty(ref _RefEndOfTermStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnrollmentStatus"/> model
        /// </summary>
        public  RefEnrollmentStatusId { get => _RefEnrollmentStatusId; set => SetProperty(ref _RefEnrollmentStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEntryGradeLevel"/> model
        /// </summary>
        public  RefEntryGradeLevelId { get => _RefEntryGradeLevelId; set => SetProperty(ref _RefEntryGradeLevelId, value); }

        /// <summary>
        /// </summary>
        public  RefEntryType { get => _RefEntryType; set => SetProperty(ref _RefEntryType, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitGradeLevel"/> model
        /// </summary>
        public  RefExitGradeLevelId { get => _RefExitGradeLevelId; set => SetProperty(ref _RefExitGradeLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
        /// </summary>
        public  RefExitOrWithdrawalStatusId { get => _RefExitOrWithdrawalStatusId; set => SetProperty(ref _RefExitOrWithdrawalStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalType"/> model
        /// </summary>
        public  RefExitOrWithdrawalTypeId { get => _RefExitOrWithdrawalTypeId; set => SetProperty(ref _RefExitOrWithdrawalTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFoodServiceEligibility"/> model
        /// </summary>
        public Guid? RefFoodServiceEligibilityId { get => _RefFoodServiceEligibilityId; set => SetProperty(ref _RefFoodServiceEligibilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNonPromotionReason"/> model
        /// </summary>
        public  RefNonPromotionReasonId { get => _RefNonPromotionReasonId; set => SetProperty(ref _RefNonPromotionReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPromotionReason"/> model
        /// </summary>
        public  RefPromotionReasonId { get => _RefPromotionReasonId; set => SetProperty(ref _RefPromotionReasonId, value); }

        /// <summary>
        /// </summary>
        public  RefPublicSchoolResidence { get => _RefPublicSchoolResidence; set => SetProperty(ref _RefPublicSchoolResidence, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentEnrollmentAccessType"/> model
        /// </summary>
        public  RefStudentEnrollmentAccessTypeId { get => _RefStudentEnrollmentAccessTypeId; set => SetProperty(ref _RefStudentEnrollmentAccessTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentEnrollment model)
        {
            IsBusy = true;
            Id = model.Id;
            DisplacedStudentStatus = model.DisplacedStudentStatus; // 
            FirstEntryDateIntoUSSchool = model.FirstEntryDateIntoUSSchool; // 
            NSLPDirectCertificationIndicator = model.NSLPDirectCertificationIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefDirectoryInformationBlockStatusId = model.RefDirectoryInformationBlockStatusId; // 
            RefEndOfTermStatusId = model.RefEndOfTermStatusId; // 
            RefEnrollmentStatusId = model.RefEnrollmentStatusId; // 
            RefEntryGradeLevelId = model.RefEntryGradeLevelId; // 
            RefEntryType = model.RefEntryType; // 
            RefExitGradeLevelId = model.RefExitGradeLevelId; // 
            RefExitOrWithdrawalStatusId = model.RefExitOrWithdrawalStatusId; // 
            RefExitOrWithdrawalTypeId = model.RefExitOrWithdrawalTypeId; // 
            RefFoodServiceEligibilityId = model.RefFoodServiceEligibilityId; // 
            RefNonPromotionReasonId = model.RefNonPromotionReasonId; // 
            RefPromotionReasonId = model.RefPromotionReasonId; // 
            RefPublicSchoolResidence = model.RefPublicSchoolResidence; // 
            RefStudentEnrollmentAccessTypeId = model.RefStudentEnrollmentAccessTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
