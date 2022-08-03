//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProfessionalDevelopmentSessionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProfessionalDevelopmentSessionViewModel
     /// </summary>
    public partial class ProfessionalDevelopmentSessionViewModel : BindableBase, IProfessionalDevelopmentSession
    {
#region "Backing Fields"
        // member variable for the SessionIdentifier property
        private System.String _SessionIdentifier;

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

        // member variable for the SponsoringAgencyName property
        private System.String _SponsoringAgencyName;

        // member variable for the FundingSource property
        private System.String _FundingSource;

        // member variable for the TrainingAndTechnicalAssistanceLevel property
        private System.String _TrainingAndTechnicalAssistanceLevel;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentActivityId"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get; set; }

        public System.String SessionIdentifier  { get => _SessionIdentifier; set => SetProperty(ref _SessionIdentifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDDeliveryMethodId"/> model
        /// </summary>
        public Guid? RefPDDeliveryMethodId { get; set; }

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
        public Guid? RefPDSessionStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDInstructionalDeliveryModeId"/> model
        /// </summary>
        public Guid? RefPDInstructionalDeliveryModeId { get; set; }

        public System.String SponsoringAgencyName  { get => _SponsoringAgencyName; set => SetProperty(ref _SponsoringAgencyName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguageId"/> model
        /// </summary>
        public Guid? RefLanguageId { get; set; }

        public System.String FundingSource  { get => _FundingSource; set => SetProperty(ref _FundingSource, value); }

        public System.String TrainingAndTechnicalAssistanceLevel  { get => _TrainingAndTechnicalAssistanceLevel; set => SetProperty(ref _TrainingAndTechnicalAssistanceLevel, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELTrainerCoreKnowledgeAreaId"/> model
        /// </summary>
        public Guid? RefELTrainerCoreKnowledgeAreaId { get; set; }

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
        public void Load(IProfessionalDevelopmentSession model)
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
