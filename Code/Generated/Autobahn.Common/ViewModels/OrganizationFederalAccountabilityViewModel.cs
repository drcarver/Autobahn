//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFederalAccountabilityViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationFederalAccountabilityViewModel
     /// </summary>
    public partial class OrganizationFederalAccountabilityViewModel : ViewModelBase, Interfaces.IOrganizationFederalAccountability
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationFederalAccountability";

        // member variable for the AccountabilityReportTitle property
        private Guid? _AccountabilityReportTitle;

        // member variable for the AlternateAypApproachIndicator property
        private  _AlternateAypApproachIndicator;

        // member variable for the AmaoAypProgressAttainmentLepStudents property
        private  _AmaoAypProgressAttainmentLepStudents;

        // member variable for the AmaoProficiencyAttainmentLepStudents property
        private  _AmaoProficiencyAttainmentLepStudents;

        // member variable for the AmaoProgressAttainmentLepStudents property
        private  _AmaoProgressAttainmentLepStudents;

        // member variable for the AypAppealChangedDesignation property
        private  _AypAppealChangedDesignation;

        // member variable for the AypAppealProcessDate property
        private  _AypAppealProcessDate;

        // member variable for the AypAppealProcessDesignation property
        private  _AypAppealProcessDesignation;

        // member variable for the PersistentlyDangerousStatus property
        private  _PersistentlyDangerousStatus;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAdditionalTargetedSupportAndImprovementStatusId property
        private  _RefAdditionalTargetedSupportAndImprovementStatusId;

        // member variable for the RefAypStatusId property
        private  _RefAypStatusId;

        // member variable for the RefComprehensiveSupportAndImprovementStatusId property
        private  _RefComprehensiveSupportAndImprovementStatusId;

        // member variable for the RefCteGraduationRateInclusionId property
        private  _RefCteGraduationRateInclusionId;

        // member variable for the RefElementaryMiddleAdditionalId property
        private  _RefElementaryMiddleAdditionalId;

        // member variable for the RefGunFreeSchoolsActReportingStatusId property
        private  _RefGunFreeSchoolsActReportingStatusId;

        // member variable for the RefHighSchoolGraduationRateIndicatorId property
        private  _RefHighSchoolGraduationRateIndicatorId;

        // member variable for the RefParticipationStatusMathId property
        private  _RefParticipationStatusMathId;

        // member variable for the RefParticipationStatusRlaId property
        private  _RefParticipationStatusRlaId;

        // member variable for the RefProficiencyTargetStatusMathId property
        private  _RefProficiencyTargetStatusMathId;

        // member variable for the RefProficiencyTargetStatusRLAId property
        private  _RefProficiencyTargetStatusRLAId;

        // member variable for the RefReconstitutedStatusId property
        private  _RefReconstitutedStatusId;

        // member variable for the RefTargetedSupportAndImprovementStatusId property
        private  _RefTargetedSupportAndImprovementStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? AccountabilityReportTitle { get => _AccountabilityReportTitle; set => SetProperty(ref _AccountabilityReportTitle, value); }

        /// <summary>
        /// </summary>
        public  AlternateAypApproachIndicator { get => _AlternateAypApproachIndicator; set => SetProperty(ref _AlternateAypApproachIndicator, value); }

        /// <summary>
        /// </summary>
        public  AmaoAypProgressAttainmentLepStudents { get => _AmaoAypProgressAttainmentLepStudents; set => SetProperty(ref _AmaoAypProgressAttainmentLepStudents, value); }

        /// <summary>
        /// </summary>
        public  AmaoProficiencyAttainmentLepStudents { get => _AmaoProficiencyAttainmentLepStudents; set => SetProperty(ref _AmaoProficiencyAttainmentLepStudents, value); }

        /// <summary>
        /// </summary>
        public  AmaoProgressAttainmentLepStudents { get => _AmaoProgressAttainmentLepStudents; set => SetProperty(ref _AmaoProgressAttainmentLepStudents, value); }

        /// <summary>
        /// </summary>
        public  AypAppealChangedDesignation { get => _AypAppealChangedDesignation; set => SetProperty(ref _AypAppealChangedDesignation, value); }

        /// <summary>
        /// </summary>
        public  AypAppealProcessDate { get => _AypAppealProcessDate; set => SetProperty(ref _AypAppealProcessDate, value); }

        /// <summary>
        /// </summary>
        public  AypAppealProcessDesignation { get => _AypAppealProcessDesignation; set => SetProperty(ref _AypAppealProcessDesignation, value); }

        /// <summary>
        /// </summary>
        public  PersistentlyDangerousStatus { get => _PersistentlyDangerousStatus; set => SetProperty(ref _PersistentlyDangerousStatus, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalTargetedSupportAndImprovementStatus"/> model
        /// </summary>
        public  RefAdditionalTargetedSupportAndImprovementStatusId { get => _RefAdditionalTargetedSupportAndImprovementStatusId; set => SetProperty(ref _RefAdditionalTargetedSupportAndImprovementStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAypStatus"/> model
        /// </summary>
        public  RefAypStatusId { get => _RefAypStatusId; set => SetProperty(ref _RefAypStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveSupportAndImprovementStatus"/> model
        /// </summary>
        public  RefComprehensiveSupportAndImprovementStatusId { get => _RefComprehensiveSupportAndImprovementStatusId; set => SetProperty(ref _RefComprehensiveSupportAndImprovementStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCteGraduationRateInclusion"/> model
        /// </summary>
        public  RefCteGraduationRateInclusionId { get => _RefCteGraduationRateInclusionId; set => SetProperty(ref _RefCteGraduationRateInclusionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefElementaryMiddleAdditional"/> model
        /// </summary>
        public  RefElementaryMiddleAdditionalId { get => _RefElementaryMiddleAdditionalId; set => SetProperty(ref _RefElementaryMiddleAdditionalId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGunFreeSchoolsActReportingStatus"/> model
        /// </summary>
        public  RefGunFreeSchoolsActReportingStatusId { get => _RefGunFreeSchoolsActReportingStatusId; set => SetProperty(ref _RefGunFreeSchoolsActReportingStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolGraduationRateIndicator"/> model
        /// </summary>
        public  RefHighSchoolGraduationRateIndicatorId { get => _RefHighSchoolGraduationRateIndicatorId; set => SetProperty(ref _RefHighSchoolGraduationRateIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationStatusMath"/> model
        /// </summary>
        public  RefParticipationStatusMathId { get => _RefParticipationStatusMathId; set => SetProperty(ref _RefParticipationStatusMathId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationStatusRla"/> model
        /// </summary>
        public  RefParticipationStatusRlaId { get => _RefParticipationStatusRlaId; set => SetProperty(ref _RefParticipationStatusRlaId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyTargetStatusMath"/> model
        /// </summary>
        public  RefProficiencyTargetStatusMathId { get => _RefProficiencyTargetStatusMathId; set => SetProperty(ref _RefProficiencyTargetStatusMathId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyTargetStatusRLA"/> model
        /// </summary>
        public  RefProficiencyTargetStatusRLAId { get => _RefProficiencyTargetStatusRLAId; set => SetProperty(ref _RefProficiencyTargetStatusRLAId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReconstitutedStatus"/> model
        /// </summary>
        public  RefReconstitutedStatusId { get => _RefReconstitutedStatusId; set => SetProperty(ref _RefReconstitutedStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTargetedSupportAndImprovementStatus"/> model
        /// </summary>
        public  RefTargetedSupportAndImprovementStatusId { get => _RefTargetedSupportAndImprovementStatusId; set => SetProperty(ref _RefTargetedSupportAndImprovementStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationFederalAccountability model)
        {
            IsBusy = true;
            Id = model.Id;
            AccountabilityReportTitle = model.AccountabilityReportTitle; // 
            AlternateAypApproachIndicator = model.AlternateAypApproachIndicator; // 
            AmaoAypProgressAttainmentLepStudents = model.AmaoAypProgressAttainmentLepStudents; // 
            AmaoProficiencyAttainmentLepStudents = model.AmaoProficiencyAttainmentLepStudents; // 
            AmaoProgressAttainmentLepStudents = model.AmaoProgressAttainmentLepStudents; // 
            AypAppealChangedDesignation = model.AypAppealChangedDesignation; // 
            AypAppealProcessDate = model.AypAppealProcessDate; // 
            AypAppealProcessDesignation = model.AypAppealProcessDesignation; // 
            PersistentlyDangerousStatus = model.PersistentlyDangerousStatus; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAdditionalTargetedSupportAndImprovementStatusId = model.RefAdditionalTargetedSupportAndImprovementStatusId; // 
            RefAypStatusId = model.RefAypStatusId; // 
            RefComprehensiveSupportAndImprovementStatusId = model.RefComprehensiveSupportAndImprovementStatusId; // 
            RefCteGraduationRateInclusionId = model.RefCteGraduationRateInclusionId; // 
            RefElementaryMiddleAdditionalId = model.RefElementaryMiddleAdditionalId; // 
            RefGunFreeSchoolsActReportingStatusId = model.RefGunFreeSchoolsActReportingStatusId; // 
            RefHighSchoolGraduationRateIndicatorId = model.RefHighSchoolGraduationRateIndicatorId; // 
            RefParticipationStatusMathId = model.RefParticipationStatusMathId; // 
            RefParticipationStatusRlaId = model.RefParticipationStatusRlaId; // 
            RefProficiencyTargetStatusMathId = model.RefProficiencyTargetStatusMathId; // 
            RefProficiencyTargetStatusRLAId = model.RefProficiencyTargetStatusRLAId; // 
            RefReconstitutedStatusId = model.RefReconstitutedStatusId; // 
            RefTargetedSupportAndImprovementStatusId = model.RefTargetedSupportAndImprovementStatusId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
