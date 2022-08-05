//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProfessionalDevelopmentSessionViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProfessionalDevelopmentSessionViewModel
     /// </summary>
    public partial class ProfessionalDevelopmentSessionViewModel : ViewModelBase, Interfaces.IProfessionalDevelopmentSession
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProfessionalDevelopmentSession";

        // member variable for the ProfessionalDevelopmentActivityId property
        private Guid _ProfessionalDevelopmentActivityId;

        // member variable for the SessionIdentifier property
        private System.String _SessionIdentifier;

        // member variable for the RefPDDeliveryMethodId property
        private Guid? _RefPDDeliveryMethodId;

        // member variable for the Capacity property
        private System.Int32? _Capacity;

        // member variable for the StartDate property
        private System.DateTime? _StartDate;

        // member variable for the StartTime property
        private System.String _StartTime;

        // member variable for the EndDate property
        private System.DateTime? _EndDate;

        // member variable for the EndTime property
        private System.String _EndTime;

        // member variable for the LocationName property
        private System.String _LocationName;

        // member variable for the EvaluationMethod property
        private System.String _EvaluationMethod;

        // member variable for the EvaluationScore property
        private System.String _EvaluationScore;

        // member variable for the ExpirationDate property
        private System.DateTime? _ExpirationDate;

        // member variable for the RefPDSessionStatusId property
        private Guid? _RefPDSessionStatusId;

        // member variable for the RefPDInstructionalDeliveryModeId property
        private Guid? _RefPDInstructionalDeliveryModeId;

        // member variable for the SponsoringAgencyName property
        private System.String _SponsoringAgencyName;

        // member variable for the RefLanguageId property
        private Guid? _RefLanguageId;

        // member variable for the FundingSource property
        private System.String _FundingSource;

        // member variable for the TrainingAndTechnicalAssistanceLevel property
        private System.String _TrainingAndTechnicalAssistanceLevel;

        // member variable for the RefELTrainerCoreKnowledgeAreaId property
        private Guid? _RefELTrainerCoreKnowledgeAreaId;

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
        /// The title of the ProfessionalDevelopmentSessionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentActivityId"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get => _ProfessionalDevelopmentActivityId; set => SetProperty(ref _ProfessionalDevelopmentActivityId, value); }

        public System.String SessionIdentifier  { get => _SessionIdentifier; set => SetProperty(ref _SessionIdentifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDDeliveryMethodId"/> model
        /// </summary>
        public Guid? RefPDDeliveryMethodId { get => _RefPDDeliveryMethodId; set => SetProperty(ref _RefPDDeliveryMethodId, value); }

        public System.Int32? Capacity { get => _Capacity; set => SetProperty(ref _Capacity, value); }

        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        public System.String StartTime  { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        public System.String EndTime  { get => _EndTime; set => SetProperty(ref _EndTime, value); }

        public System.String LocationName  { get => _LocationName; set => SetProperty(ref _LocationName, value); }

        public System.String EvaluationMethod  { get => _EvaluationMethod; set => SetProperty(ref _EvaluationMethod, value); }

        public System.String EvaluationScore  { get => _EvaluationScore; set => SetProperty(ref _EvaluationScore, value); }

        public System.DateTime? ExpirationDate { get => _ExpirationDate; set => SetProperty(ref _ExpirationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDSessionStatusId"/> model
        /// </summary>
        public Guid? RefPDSessionStatusId { get => _RefPDSessionStatusId; set => SetProperty(ref _RefPDSessionStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDInstructionalDeliveryModeId"/> model
        /// </summary>
        public Guid? RefPDInstructionalDeliveryModeId { get => _RefPDInstructionalDeliveryModeId; set => SetProperty(ref _RefPDInstructionalDeliveryModeId, value); }

        public System.String SponsoringAgencyName  { get => _SponsoringAgencyName; set => SetProperty(ref _SponsoringAgencyName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguageId"/> model
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        public System.String FundingSource  { get => _FundingSource; set => SetProperty(ref _FundingSource, value); }

        public System.String TrainingAndTechnicalAssistanceLevel  { get => _TrainingAndTechnicalAssistanceLevel; set => SetProperty(ref _TrainingAndTechnicalAssistanceLevel, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELTrainerCoreKnowledgeAreaId"/> model
        /// </summary>
        public Guid? RefELTrainerCoreKnowledgeAreaId { get => _RefELTrainerCoreKnowledgeAreaId; set => SetProperty(ref _RefELTrainerCoreKnowledgeAreaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProfessionalDevelopmentSession model)
        {
            IsBusy = true;
            Id = model.Id;
            ProfessionalDevelopmentActivityId = model.ProfessionalDevelopmentActivityId;
            SessionIdentifier = model.SessionIdentifier;
            RefPDDeliveryMethodId = model.RefPDDeliveryMethodId;
            Capacity = model.Capacity;
            StartDate = model.StartDate;
            StartTime = model.StartTime;
            EndDate = model.EndDate;
            EndTime = model.EndTime;
            LocationName = model.LocationName;
            EvaluationMethod = model.EvaluationMethod;
            EvaluationScore = model.EvaluationScore;
            ExpirationDate = model.ExpirationDate;
            RefPDSessionStatusId = model.RefPDSessionStatusId;
            RefPDInstructionalDeliveryModeId = model.RefPDInstructionalDeliveryModeId;
            SponsoringAgencyName = model.SponsoringAgencyName;
            RefLanguageId = model.RefLanguageId;
            FundingSource = model.FundingSource;
            TrainingAndTechnicalAssistanceLevel = model.TrainingAndTechnicalAssistanceLevel;
            RefELTrainerCoreKnowledgeAreaId = model.RefELTrainerCoreKnowledgeAreaId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
