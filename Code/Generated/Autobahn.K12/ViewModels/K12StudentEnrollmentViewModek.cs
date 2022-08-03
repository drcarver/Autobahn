//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentEnrollmentViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentEnrollmentViewModel
     /// </summary>
    public partial class K12StudentEnrollmentViewModel : BindableBase, IK12StudentEnrollment
    {
#region "Backing Fields"
        // member variable for the DisplacedStudentStatus property
        private System.Boolean? _DisplacedStudentStatus;

        // member variable for the FirstEntryDateIntoUSSchool property
        private System.DateTime? _FirstEntryDateIntoUSSchool;

        // member variable for the NSLPDirectCertificationIndicator property
        private System.Boolean? _NSLPDirectCertificationIndicator;

        // member variable for the RefPublicSchoolResidence property
        private System.Int32? _RefPublicSchoolResidence;

        // member variable for the RefEntryType property
        private System.Int32? _RefEntryType;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.Boolean? DisplacedStudentStatus { get => _DisplacedStudentStatus; set => SetProperty(ref _DisplacedStudentStatus, value); }

        public System.DateTime? FirstEntryDateIntoUSSchool { get => _FirstEntryDateIntoUSSchool; set => SetProperty(ref _FirstEntryDateIntoUSSchool, value); }

        public System.Boolean? NSLPDirectCertificationIndicator { get => _NSLPDirectCertificationIndicator; set => SetProperty(ref _NSLPDirectCertificationIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEntryGradeLevelId"/> model
        /// </summary>
        public Guid? RefEntryGradeLevelId { get; set; }

        public System.Int32? RefPublicSchoolResidence { get => _RefPublicSchoolResidence; set => SetProperty(ref _RefPublicSchoolResidence, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEnrollmentStatusId"/> model
        /// </summary>
        public Guid? RefEnrollmentStatusId { get; set; }

        public System.Int32? RefEntryType { get => _RefEntryType; set => SetProperty(ref _RefEntryType, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitGradeLevelId"/> model
        /// </summary>
        public Guid? RefExitGradeLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatusId"/> model
        /// </summary>
        public Guid? RefExitOrWithdrawalStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalTypeId"/> model
        /// </summary>
        public Guid? RefExitOrWithdrawalTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEndOfTermStatusId"/> model
        /// </summary>
        public Guid? RefEndOfTermStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPromotionReasonId"/> model
        /// </summary>
        public Guid? RefPromotionReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNonPromotionReasonId"/> model
        /// </summary>
        public Guid? RefNonPromotionReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFoodServiceEligibilityId"/> model
        /// </summary>
        public Guid? RefFoodServiceEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDirectoryInformationBlockStatusId"/> model
        /// </summary>
        public Guid? RefDirectoryInformationBlockStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentEnrollmentAccessTypeId"/> model
        /// </summary>
        public Guid? RefStudentEnrollmentAccessTypeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IK12StudentEnrollment model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
