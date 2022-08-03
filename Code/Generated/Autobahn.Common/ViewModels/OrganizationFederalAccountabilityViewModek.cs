//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationFederalAccountabilityViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationFederalAccountabilityViewModel
     /// </summary>
    public partial class OrganizationFederalAccountabilityViewModel : BindableBase, IOrganizationFederalAccountability
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

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
        public Guid? RefAypStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGunFreeSchoolsActReportingStatusId"/> model
        /// </summary>
        public Guid? RefGunFreeSchoolsActReportingStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolGraduationRateIndicatorId"/> model
        /// </summary>
        public Guid? RefHighSchoolGraduationRateIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationStatusMathId"/> model
        /// </summary>
        public Guid? RefParticipationStatusMathId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParticipationStatusRlaId"/> model
        /// </summary>
        public Guid? RefParticipationStatusRlaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyTargetStatusMathId"/> model
        /// </summary>
        public Guid? RefProficiencyTargetStatusMathId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProficiencyTargetStatusRLAId"/> model
        /// </summary>
        public Guid? RefProficiencyTargetStatusRLAId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReconstitutedStatusId"/> model
        /// </summary>
        public Guid? RefReconstitutedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefElementaryMiddleAdditionalId"/> model
        /// </summary>
        public Guid? RefElementaryMiddleAdditionalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCteGraduationRateInclusionId"/> model
        /// </summary>
        public Guid? RefCteGraduationRateInclusionId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalTargetedSupportAndImprovementStatusId"/> model
        /// </summary>
        public Guid? RefAdditionalTargetedSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefComprehensiveSupportAndImprovementStatusId"/> model
        /// </summary>
        public Guid? RefComprehensiveSupportAndImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTargetedSupportAndImprovementStatusId"/> model
        /// </summary>
        public Guid? RefTargetedSupportAndImprovementStatusId { get; set; }

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
        public void Load(IOrganizationFederalAccountability model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RefAdditionalTargetedSupportAndImprovementStatusId = model.RefAdditionalTargetedSupportAndImprovementStatusId;
            RefComprehensiveSupportAndImprovementStatusId = model.RefComprehensiveSupportAndImprovementStatusId;
            RefTargetedSupportAndImprovementStatusId = model.RefTargetedSupportAndImprovementStatusId;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
