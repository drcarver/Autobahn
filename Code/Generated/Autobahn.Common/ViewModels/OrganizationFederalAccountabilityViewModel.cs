//**********************************************************
//* DomainName: Autobahn.Common
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

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the AlternateAypApproachIndicator property
        private System.Boolean? _AlternateAypApproachIndicator;

        // member variable for the AypAppealChangedDesignation property
        private System.Boolean? _AypAppealChangedDesignation;

        // member variable for the AypAppealProcessDate property
        private System.DateTime? _AypAppealProcessDate;

        // member variable for the AypAppealProcessDesignation property
        private System.Boolean? _AypAppealProcessDesignation;

        // member variable for the AmaoAypProgressAttainmentLepStudents property
        private System.Int32? _AmaoAypProgressAttainmentLepStudents;

        // member variable for the AmaoProficiencyAttainmentLepStudents property
        private System.Int32? _AmaoProficiencyAttainmentLepStudents;

        // member variable for the AmaoProgressAttainmentLepStudents property
        private System.Int32? _AmaoProgressAttainmentLepStudents;

        // member variable for the PersistentlyDangerousStatus property
        private System.Boolean? _PersistentlyDangerousStatus;

        // member variable for the AccountabilityReportTitle property
        private System.String _AccountabilityReportTitle;

        // member variable for the RefAypStatusId property
        private Guid? _RefAypStatusId;

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

        // member variable for the RefElementaryMiddleAdditionalId property
        private Guid? _RefElementaryMiddleAdditionalId;

        // member variable for the RefCteGraduationRateInclusionId property
        private Guid? _RefCteGraduationRateInclusionId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RefAdditionalTargetedSupportAndImprovementStatusId property
        private Guid? _RefAdditionalTargetedSupportAndImprovementStatusId;

        // member variable for the RefComprehensiveSupportAndImprovementStatusId property
        private Guid? _RefComprehensiveSupportAndImprovementStatusId;

        // member variable for the RefTargetedSupportAndImprovementStatusId property
        private Guid? _RefTargetedSupportAndImprovementStatusId;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationFederalAccountabilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.Boolean? AlternateAypApproachIndicator { get => _AlternateAypApproachIndicator; set => SetProperty(ref _AlternateAypApproachIndicator, value); }

        public System.Boolean? AypAppealChangedDesignation { get => _AypAppealChangedDesignation; set => SetProperty(ref _AypAppealChangedDesignation, value); }

        public System.DateTime? AypAppealProcessDate { get => _AypAppealProcessDate; set => SetProperty(ref _AypAppealProcessDate, value); }

        public System.Boolean? AypAppealProcessDesignation { get => _AypAppealProcessDesignation; set => SetProperty(ref _AypAppealProcessDesignation, value); }

        public System.Int32? AmaoAypProgressAttainmentLepStudents { get => _AmaoAypProgressAttainmentLepStudents; set => SetProperty(ref _AmaoAypProgressAttainmentLepStudents, value); }

        public System.Int32? AmaoProficiencyAttainmentLepStudents { get => _AmaoProficiencyAttainmentLepStudents; set => SetProperty(ref _AmaoProficiencyAttainmentLepStudents, value); }

        public System.Int32? AmaoProgressAttainmentLepStudents { get => _AmaoProgressAttainmentLepStudents; set => SetProperty(ref _AmaoProgressAttainmentLepStudents, value); }

        public System.Boolean? PersistentlyDangerousStatus { get => _PersistentlyDangerousStatus; set => SetProperty(ref _PersistentlyDangerousStatus, value); }

        public System.String AccountabilityReportTitle  { get => _AccountabilityReportTitle; set => SetProperty(ref _AccountabilityReportTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAypStatusId"/> model
        /// </summary>
        public Guid? RefAypStatusId { get => _RefAypStatusId; set => SetProperty(ref _RefAypStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGunFreeSchoolsActReportingStatusId"/> model
        /// </summary>
        public Guid? RefGunFreeSchoolsActReportingStatusId { get => _RefGunFreeSchoolsActReportingStatusId; set => SetProperty(ref _RefGunFreeSchoolsActReportingStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolGraduationRateIndicatorId"/> model
        /// </summary>
        public Guid? RefHighSchoolGraduationRateIndicatorId { get => _RefHighSchoolGraduationRateIndicatorId; set => SetProperty(ref _RefHighSchoolGraduationRateIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationStatusMathId"/> model
        /// </summary>
        public Guid? RefParticipationStatusMathId { get => _RefParticipationStatusMathId; set => SetProperty(ref _RefParticipationStatusMathId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationStatusRlaId"/> model
        /// </summary>
        public Guid? RefParticipationStatusRlaId { get => _RefParticipationStatusRlaId; set => SetProperty(ref _RefParticipationStatusRlaId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyTargetStatusMathId"/> model
        /// </summary>
        public Guid? RefProficiencyTargetStatusMathId { get => _RefProficiencyTargetStatusMathId; set => SetProperty(ref _RefProficiencyTargetStatusMathId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyTargetStatusRLAId"/> model
        /// </summary>
        public Guid? RefProficiencyTargetStatusRLAId { get => _RefProficiencyTargetStatusRLAId; set => SetProperty(ref _RefProficiencyTargetStatusRLAId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReconstitutedStatusId"/> model
        /// </summary>
        public Guid? RefReconstitutedStatusId { get => _RefReconstitutedStatusId; set => SetProperty(ref _RefReconstitutedStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefElementaryMiddleAdditionalId"/> model
        /// </summary>
        public Guid? RefElementaryMiddleAdditionalId { get => _RefElementaryMiddleAdditionalId; set => SetProperty(ref _RefElementaryMiddleAdditionalId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCteGraduationRateInclusionId"/> model
        /// </summary>
        public Guid? RefCteGraduationRateInclusionId { get => _RefCteGraduationRateInclusionId; set => SetProperty(ref _RefCteGraduationRateInclusionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalTargetedSupportAndImprovementStatusId"/> model
        /// </summary>
        public Guid? RefAdditionalTargetedSupportAndImprovementStatusId { get => _RefAdditionalTargetedSupportAndImprovementStatusId; set => SetProperty(ref _RefAdditionalTargetedSupportAndImprovementStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveSupportAndImprovementStatusId"/> model
        /// </summary>
        public Guid? RefComprehensiveSupportAndImprovementStatusId { get => _RefComprehensiveSupportAndImprovementStatusId; set => SetProperty(ref _RefComprehensiveSupportAndImprovementStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTargetedSupportAndImprovementStatusId"/> model
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
            OrganizationId = model.OrganizationId;
            AlternateAypApproachIndicator = model.AlternateAypApproachIndicator;
            AypAppealChangedDesignation = model.AypAppealChangedDesignation;
            AypAppealProcessDate = model.AypAppealProcessDate;
            AypAppealProcessDesignation = model.AypAppealProcessDesignation;
            AmaoAypProgressAttainmentLepStudents = model.AmaoAypProgressAttainmentLepStudents;
            AmaoProficiencyAttainmentLepStudents = model.AmaoProficiencyAttainmentLepStudents;
            AmaoProgressAttainmentLepStudents = model.AmaoProgressAttainmentLepStudents;
            PersistentlyDangerousStatus = model.PersistentlyDangerousStatus;
            AccountabilityReportTitle = model.AccountabilityReportTitle;
            RefAypStatusId = model.RefAypStatusId;
            RefGunFreeSchoolsActReportingStatusId = model.RefGunFreeSchoolsActReportingStatusId;
            RefHighSchoolGraduationRateIndicatorId = model.RefHighSchoolGraduationRateIndicatorId;
            RefParticipationStatusMathId = model.RefParticipationStatusMathId;
            RefParticipationStatusRlaId = model.RefParticipationStatusRlaId;
            RefProficiencyTargetStatusMathId = model.RefProficiencyTargetStatusMathId;
            RefProficiencyTargetStatusRLAId = model.RefProficiencyTargetStatusRLAId;
            RefReconstitutedStatusId = model.RefReconstitutedStatusId;
            RefElementaryMiddleAdditionalId = model.RefElementaryMiddleAdditionalId;
            RefCteGraduationRateInclusionId = model.RefCteGraduationRateInclusionId;
            RefAdditionalTargetedSupportAndImprovementStatusId = model.RefAdditionalTargetedSupportAndImprovementStatusId;
            RefComprehensiveSupportAndImprovementStatusId = model.RefComprehensiveSupportAndImprovementStatusId;
            RefTargetedSupportAndImprovementStatusId = model.RefTargetedSupportAndImprovementStatusId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
