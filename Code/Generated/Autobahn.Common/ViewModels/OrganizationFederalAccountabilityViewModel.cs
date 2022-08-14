//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFederalAccountabilityViewModel.cs
//**********************************************************

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
        private System.String _AccountabilityReportTitle;

        // member variable for the AlternateAypApproachIndicator property
        private System.Boolean? _AlternateAypApproachIndicator;

        // member variable for the AmaoAypProgressAttainmentLepStudents property
        private System.Int32? _AmaoAypProgressAttainmentLepStudents;

        // member variable for the AmaoProficiencyAttainmentLepStudents property
        private System.Int32? _AmaoProficiencyAttainmentLepStudents;

        // member variable for the AmaoProgressAttainmentLepStudents property
        private System.Int32? _AmaoProgressAttainmentLepStudents;

        // member variable for the AypAppealChangedDesignation property
        private System.Boolean? _AypAppealChangedDesignation;

        // member variable for the AypAppealProcessDate property
        private System.DateTime? _AypAppealProcessDate;

        // member variable for the AypAppealProcessDesignation property
        private System.Boolean? _AypAppealProcessDesignation;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the PersistentlyDangerousStatus property
        private System.Boolean? _PersistentlyDangerousStatus;

        // member variable for the RefAdditionalTargetedSupportAndImprovementStatusId property
        private Guid? _RefAdditionalTargetedSupportAndImprovementStatusId;

        // member variable for the RefAypStatusId property
        private Guid? _RefAypStatusId;

        // member variable for the RefComprehensiveSupportAndImprovementStatusId property
        private Guid? _RefComprehensiveSupportAndImprovementStatusId;

        // member variable for the RefCteGraduationRateInclusionId property
        private Guid? _RefCteGraduationRateInclusionId;

        // member variable for the RefElementaryMiddleAdditionalId property
        private Guid? _RefElementaryMiddleAdditionalId;

        // member variable for the RefGunFreeSchoolsActReportingStatusId property
        private Guid? _RefGunFreeSchoolsActReportingStatusId;

        // member variable for the RefHighSchoolGraduationRateIndicatorId property
        private Guid? _RefHighSchoolGraduationRateIndicatorId;

        // member variable for the RefParticipationStatusMathId property
        private Guid? _RefParticipationStatusMathId;

        // member variable for the RefParticipationStatusRlaId property
        private Guid? _RefParticipationStatusRlaId;

        // member variable for the RefProficiencyTargetStatusMathId property
        private Guid? _RefProficiencyTargetStatusMathId;

        // member variable for the RefProficiencyTargetStatusRLAId property
        private Guid? _RefProficiencyTargetStatusRLAId;

        // member variable for the RefReconstitutedStatusId property
        private Guid? _RefReconstitutedStatusId;

        // member variable for the RefTargetedSupportAndImprovementStatusId property
        private Guid? _RefTargetedSupportAndImprovementStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationFederalAccountabilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.String AccountabilityReportTitle { get => _AccountabilityReportTitle; set => SetProperty(ref _AccountabilityReportTitle, value); }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.Boolean? AlternateAypApproachIndicator { get => _AlternateAypApproachIndicator; set => SetProperty(ref _AlternateAypApproachIndicator, value); }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.Int32? AmaoAypProgressAttainmentLepStudents { get => _AmaoAypProgressAttainmentLepStudents; set => SetProperty(ref _AmaoAypProgressAttainmentLepStudents, value); }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.Int32? AmaoProficiencyAttainmentLepStudents { get => _AmaoProficiencyAttainmentLepStudents; set => SetProperty(ref _AmaoProficiencyAttainmentLepStudents, value); }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.Int32? AmaoProgressAttainmentLepStudents { get => _AmaoProgressAttainmentLepStudents; set => SetProperty(ref _AmaoProgressAttainmentLepStudents, value); }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.Boolean? AypAppealChangedDesignation { get => _AypAppealChangedDesignation; set => SetProperty(ref _AypAppealChangedDesignation, value); }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.DateTime? AypAppealProcessDate { get => _AypAppealProcessDate; set => SetProperty(ref _AypAppealProcessDate, value); }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.Boolean? AypAppealProcessDesignation { get => _AypAppealProcessDesignation; set => SetProperty(ref _AypAppealProcessDesignation, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.Boolean? PersistentlyDangerousStatus { get => _PersistentlyDangerousStatus; set => SetProperty(ref _PersistentlyDangerousStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalTargetedSupportAndImprovementStatus"/> model
        /// </summary>
        public Guid? RefAdditionalTargetedSupportAndImprovementStatusId { get => _RefAdditionalTargetedSupportAndImprovementStatusId; set => SetProperty(ref _RefAdditionalTargetedSupportAndImprovementStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAypStatus"/> model
        /// </summary>
        public Guid? RefAypStatusId { get => _RefAypStatusId; set => SetProperty(ref _RefAypStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveSupportAndImprovementStatus"/> model
        /// </summary>
        public Guid? RefComprehensiveSupportAndImprovementStatusId { get => _RefComprehensiveSupportAndImprovementStatusId; set => SetProperty(ref _RefComprehensiveSupportAndImprovementStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCteGraduationRateInclusion"/> model
        /// </summary>
        public Guid? RefCteGraduationRateInclusionId { get => _RefCteGraduationRateInclusionId; set => SetProperty(ref _RefCteGraduationRateInclusionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefElementaryMiddleAdditional"/> model
        /// </summary>
        public Guid? RefElementaryMiddleAdditionalId { get => _RefElementaryMiddleAdditionalId; set => SetProperty(ref _RefElementaryMiddleAdditionalId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGunFreeSchoolsActReportingStatus"/> model
        /// </summary>
        public Guid? RefGunFreeSchoolsActReportingStatusId { get => _RefGunFreeSchoolsActReportingStatusId; set => SetProperty(ref _RefGunFreeSchoolsActReportingStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolGraduationRateIndicator"/> model
        /// </summary>
        public Guid? RefHighSchoolGraduationRateIndicatorId { get => _RefHighSchoolGraduationRateIndicatorId; set => SetProperty(ref _RefHighSchoolGraduationRateIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationStatusMath"/> model
        /// </summary>
        public Guid? RefParticipationStatusMathId { get => _RefParticipationStatusMathId; set => SetProperty(ref _RefParticipationStatusMathId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationStatusRla"/> model
        /// </summary>
        public Guid? RefParticipationStatusRlaId { get => _RefParticipationStatusRlaId; set => SetProperty(ref _RefParticipationStatusRlaId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyTargetStatusMath"/> model
        /// </summary>
        public Guid? RefProficiencyTargetStatusMathId { get => _RefProficiencyTargetStatusMathId; set => SetProperty(ref _RefProficiencyTargetStatusMathId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyTargetStatusRLA"/> model
        /// </summary>
        public Guid? RefProficiencyTargetStatusRLAId { get => _RefProficiencyTargetStatusRLAId; set => SetProperty(ref _RefProficiencyTargetStatusRLAId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReconstitutedStatus"/> model
        /// </summary>
        public Guid? RefReconstitutedStatusId { get => _RefReconstitutedStatusId; set => SetProperty(ref _RefReconstitutedStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTargetedSupportAndImprovementStatus"/> model
        /// </summary>
        public Guid? RefTargetedSupportAndImprovementStatusId { get => _RefTargetedSupportAndImprovementStatusId; set => SetProperty(ref _RefTargetedSupportAndImprovementStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationFederalAccountability model)
        {
            IsBusy = true;
            Id = model.Id;
            AccountabilityReportTitle = model.AccountabilityReportTitle;
            AlternateAypApproachIndicator = model.AlternateAypApproachIndicator;
            AmaoAypProgressAttainmentLepStudents = model.AmaoAypProgressAttainmentLepStudents;
            AmaoProficiencyAttainmentLepStudents = model.AmaoProficiencyAttainmentLepStudents;
            AmaoProgressAttainmentLepStudents = model.AmaoProgressAttainmentLepStudents;
            AypAppealChangedDesignation = model.AypAppealChangedDesignation;
            AypAppealProcessDate = model.AypAppealProcessDate;
            AypAppealProcessDesignation = model.AypAppealProcessDesignation;
            OrganizationId = model.OrganizationId;
            PersistentlyDangerousStatus = model.PersistentlyDangerousStatus;
            RefAdditionalTargetedSupportAndImprovementStatusId = model.RefAdditionalTargetedSupportAndImprovementStatusId;
            RefAypStatusId = model.RefAypStatusId;
            RefComprehensiveSupportAndImprovementStatusId = model.RefComprehensiveSupportAndImprovementStatusId;
            RefCteGraduationRateInclusionId = model.RefCteGraduationRateInclusionId;
            RefElementaryMiddleAdditionalId = model.RefElementaryMiddleAdditionalId;
            RefGunFreeSchoolsActReportingStatusId = model.RefGunFreeSchoolsActReportingStatusId;
            RefHighSchoolGraduationRateIndicatorId = model.RefHighSchoolGraduationRateIndicatorId;
            RefParticipationStatusMathId = model.RefParticipationStatusMathId;
            RefParticipationStatusRlaId = model.RefParticipationStatusRlaId;
            RefProficiencyTargetStatusMathId = model.RefProficiencyTargetStatusMathId;
            RefProficiencyTargetStatusRLAId = model.RefProficiencyTargetStatusRLAId;
            RefReconstitutedStatusId = model.RefReconstitutedStatusId;
            RefTargetedSupportAndImprovementStatusId = model.RefTargetedSupportAndImprovementStatusId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
