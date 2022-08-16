//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProfessionalDevelopmentSessionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
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
        private  _Capacity;

        // member variable for the EndDate property
        private  _EndDate;

        // member variable for the EndTime property
        private  _EndTime;

        // member variable for the EvaluationMethod property
        private  _EvaluationMethod;

        // member variable for the EvaluationScore property
        private  _EvaluationScore;

        // member variable for the ExpirationDate property
        private  _ExpirationDate;

        // member variable for the FundingSource property
        private  _FundingSource;

        // member variable for the LocationName property
        private  _LocationName;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefELTrainerCoreKnowledgeAreaId property
        private  _RefELTrainerCoreKnowledgeAreaId;

        // member variable for the RefLanguageId property
        private Guid? _RefLanguageId;

        // member variable for the RefPDDeliveryMethodId property
        private  _RefPDDeliveryMethodId;

        // member variable for the RefPDInstructionalDeliveryModeId property
        private  _RefPDInstructionalDeliveryModeId;

        // member variable for the RefPDSessionStatusId property
        private  _RefPDSessionStatusId;

        // member variable for the SessionIdentifier property
        private  _SessionIdentifier;

        // member variable for the SponsoringAgencyName property
        private  _SponsoringAgencyName;

        // member variable for the StartDate property
        private  _StartDate;

        // member variable for the StartTime property
        private  _StartTime;

        // member variable for the TrainingAndTechnicalAssistanceLevel property
        private  _TrainingAndTechnicalAssistanceLevel;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  Capacity { get => _Capacity; set => SetProperty(ref _Capacity, value); }

        /// <summary>
        /// </summary>
        public  EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// </summary>
        public  EndTime { get => _EndTime; set => SetProperty(ref _EndTime, value); }

        /// <summary>
        /// </summary>
        public  EvaluationMethod { get => _EvaluationMethod; set => SetProperty(ref _EvaluationMethod, value); }

        /// <summary>
        /// </summary>
        public  EvaluationScore { get => _EvaluationScore; set => SetProperty(ref _EvaluationScore, value); }

        /// <summary>
        /// </summary>
        public  ExpirationDate { get => _ExpirationDate; set => SetProperty(ref _ExpirationDate, value); }

        /// <summary>
        /// </summary>
        public  FundingSource { get => _FundingSource; set => SetProperty(ref _FundingSource, value); }

        /// <summary>
        /// </summary>
        public  LocationName { get => _LocationName; set => SetProperty(ref _LocationName, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELTrainerCoreKnowledgeArea"/> model
        /// </summary>
        public  RefELTrainerCoreKnowledgeAreaId { get => _RefELTrainerCoreKnowledgeAreaId; set => SetProperty(ref _RefELTrainerCoreKnowledgeAreaId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDDeliveryMethod"/> model
        /// </summary>
        public  RefPDDeliveryMethodId { get => _RefPDDeliveryMethodId; set => SetProperty(ref _RefPDDeliveryMethodId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDInstructionalDeliveryMode"/> model
        /// </summary>
        public  RefPDInstructionalDeliveryModeId { get => _RefPDInstructionalDeliveryModeId; set => SetProperty(ref _RefPDInstructionalDeliveryModeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDSessionStatus"/> model
        /// </summary>
        public  RefPDSessionStatusId { get => _RefPDSessionStatusId; set => SetProperty(ref _RefPDSessionStatusId, value); }

        /// <summary>
        /// </summary>
        public  SessionIdentifier { get => _SessionIdentifier; set => SetProperty(ref _SessionIdentifier, value); }

        /// <summary>
        /// </summary>
        public  SponsoringAgencyName { get => _SponsoringAgencyName; set => SetProperty(ref _SponsoringAgencyName, value); }

        /// <summary>
        /// </summary>
        public  StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        /// <summary>
        /// </summary>
        public  StartTime { get => _StartTime; set => SetProperty(ref _StartTime, value); }

        /// <summary>
        /// </summary>
        public  TrainingAndTechnicalAssistanceLevel { get => _TrainingAndTechnicalAssistanceLevel; set => SetProperty(ref _TrainingAndTechnicalAssistanceLevel, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProfessionalDevelopmentSession model)
        {
            IsBusy = true;
            Id = model.Id;
            Capacity = model.Capacity; // 
            EndDate = model.EndDate; // 
            EndTime = model.EndTime; // 
            EvaluationMethod = model.EvaluationMethod; // 
            EvaluationScore = model.EvaluationScore; // 
            ExpirationDate = model.ExpirationDate; // 
            FundingSource = model.FundingSource; // 
            LocationName = model.LocationName; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefELTrainerCoreKnowledgeAreaId = model.RefELTrainerCoreKnowledgeAreaId; // 
            RefLanguageId = model.RefLanguageId; // 
            RefPDDeliveryMethodId = model.RefPDDeliveryMethodId; // 
            RefPDInstructionalDeliveryModeId = model.RefPDInstructionalDeliveryModeId; // 
            RefPDSessionStatusId = model.RefPDSessionStatusId; // 
            SessionIdentifier = model.SessionIdentifier; // 
            SponsoringAgencyName = model.SponsoringAgencyName; // 
            StartDate = model.StartDate; // 
            StartTime = model.StartTime; // 
            TrainingAndTechnicalAssistanceLevel = model.TrainingAndTechnicalAssistanceLevel; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
