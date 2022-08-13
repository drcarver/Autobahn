//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProfessionalDevelopmentSessionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ProfessionalDevelopmentSessionViewModel
     /// </summary>
    public partial class ProfessionalDevelopmentSessionViewModel : ViewModelBase, Interfaces.IProfessionalDevelopmentSession
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProfessionalDevelopmentSession";

        // member variable for the Capacity property
        private System.Int32? _Capacity;

        // member variable for the EndDate property
        private System.DateTime? _EndDate;

        // member variable for the EndTime property
        private System.String _EndTime;

        // member variable for the EvaluationMethod property
        private System.String _EvaluationMethod;

        // member variable for the EvaluationScore property
        private System.String _EvaluationScore;

        // member variable for the ExpirationDate property
        private System.DateTime? _ExpirationDate;

        // member variable for the FundingSource property
        private System.String _FundingSource;

        // member variable for the LocationName property
        private System.String _LocationName;

        // member variable for the ProfessionalDevelopmentActivityId property
        private Guid _ProfessionalDevelopmentActivityId;

        // member variable for the RefELTrainerCoreKnowledgeAreaId property
        private Guid? _RefELTrainerCoreKnowledgeAreaId;

        // member variable for the RefLanguageId property
        private Guid? _RefLanguageId;

        // member variable for the RefPDDeliveryMethodId property
        private Guid? _RefPDDeliveryMethodId;

        // member variable for the RefPDInstructionalDeliveryModeId property
        private Guid? _RefPDInstructionalDeliveryModeId;

        // member variable for the RefPDSessionStatusId property
        private Guid? _RefPDSessionStatusId;

        // member variable for the SessionIdentifier property
        private System.String _SessionIdentifier;

        // member variable for the SponsoringAgencyName property
        private System.String _SponsoringAgencyName;

        // member variable for the StartDate property
        private System.DateTime? _StartDate;

        // member variable for the StartTime property
        private System.String _StartTime;

        // member variable for the TrainingAndTechnicalAssistanceLevel property
        private System.String _TrainingAndTechnicalAssistanceLevel;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProfessionalDevelopmentSessionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.Int32? Capacity { get => _Capacity; set => SetProperty(ref _Capacity, value); }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String EndTime { get => _EndTime; set => SetProperty(ref _EndTime, value); }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String EvaluationMethod { get => _EvaluationMethod; set => SetProperty(ref _EvaluationMethod, value); }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String EvaluationScore { get => _EvaluationScore; set => SetProperty(ref _EvaluationScore, value); }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.DateTime? ExpirationDate { get => _ExpirationDate; set => SetProperty(ref _ExpirationDate, value); }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String FundingSource { get => _FundingSource; set => SetProperty(ref _FundingSource, value); }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String LocationName { get => _LocationName; set => SetProperty(ref _LocationName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ProfessionalDevelopmentActivity"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get => _ProfessionalDevelopmentActivityId; set => SetProperty(ref _ProfessionalDevelopmentActivityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELTrainerCoreKnowledgeArea"/> model
        /// </summary>
        public Guid? RefELTrainerCoreKnowledgeAreaId { get => _RefELTrainerCoreKnowledgeAreaId; set => SetProperty(ref _RefELTrainerCoreKnowledgeAreaId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDDeliveryMethod"/> model
        /// </summary>
        public Guid? RefPDDeliveryMethodId { get => _RefPDDeliveryMethodId; set => SetProperty(ref _RefPDDeliveryMethodId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDInstructionalDeliveryMode"/> model
        /// </summary>
        public Guid? RefPDInstructionalDeliveryModeId { get => _RefPDInstructionalDeliveryModeId; set => SetProperty(ref _RefPDInstructionalDeliveryModeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDSessionStatus"/> model
        /// </summary>
        public Guid? RefPDSessionStatusId { get => _RefPDSessionStatusId; set => SetProperty(ref _RefPDSessionStatusId, value); }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String SessionIdentifier { get => _SessionIdentifier; set => SetProperty(ref _SessionIdentifier, value); }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String SponsoringAgencyName { get => _SponsoringAgencyName; set => SetProperty(ref _SponsoringAgencyName, value); }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        /// <summary>
        /// The language in which the professional development session is delivered.
        /// </summary>
        public System.String TrainingAndTechnicalAssistanceLevel { get => _TrainingAndTechnicalAssistanceLevel; set => SetProperty(ref _TrainingAndTechnicalAssistanceLevel, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProfessionalDevelopmentSession model)
        {
            IsBusy = true;
            Id = model.Id;
            Capacity = model.Capacity;
            EndDate = model.EndDate;
            EndTime = model.EndTime;
            EvaluationMethod = model.EvaluationMethod;
            EvaluationScore = model.EvaluationScore;
            ExpirationDate = model.ExpirationDate;
            FundingSource = model.FundingSource;
            LocationName = model.LocationName;
            ProfessionalDevelopmentActivityId = model.ProfessionalDevelopmentActivityId;
            RefELTrainerCoreKnowledgeAreaId = model.RefELTrainerCoreKnowledgeAreaId;
            RefLanguageId = model.RefLanguageId;
            RefPDDeliveryMethodId = model.RefPDDeliveryMethodId;
            RefPDInstructionalDeliveryModeId = model.RefPDInstructionalDeliveryModeId;
            RefPDSessionStatusId = model.RefPDSessionStatusId;
            SessionIdentifier = model.SessionIdentifier;
            SponsoringAgencyName = model.SponsoringAgencyName;
            StartDate = model.StartDate;
            StartTime = model.StartTime;
            TrainingAndTechnicalAssistanceLevel = model.TrainingAndTechnicalAssistanceLevel;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
