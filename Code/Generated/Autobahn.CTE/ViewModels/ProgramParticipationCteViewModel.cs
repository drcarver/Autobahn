//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   ProgramParticipationCteViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.CTE.ViewModels
{
     /// <summary>
     /// The ProgramParticipationCteViewModel
     /// </summary>
    public partial class ProgramParticipationCteViewModel : ViewModelBase, Interfaces.IProgramParticipationCte
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationCte";

        // member variable for the CareerPathwaysProgramParticipationExitDate property
        private  _CareerPathwaysProgramParticipationExitDate;

        // member variable for the CareerPathwaysProgramParticipationStartDate property
        private  _CareerPathwaysProgramParticipationStartDate;

        // member variable for the CteCompleter property
        private Guid? _CteCompleter;

        // member variable for the CteConcentrator property
        private  _CteConcentrator;

        // member variable for the CteNonTraditionalCompletion property
        private  _CteNonTraditionalCompletion;

        // member variable for the CteParticipant property
        private  _CteParticipant;

        // member variable for the DisplacedHomemakerIndicator property
        private  _DisplacedHomemakerIndicator;

        // member variable for the OutOfWorkforceIndicator property
        private  _OutOfWorkforceIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefNonTraditionalGenderStatusId property
        private  _RefNonTraditionalGenderStatusId;

        // member variable for the RefWorkbasedLearningOpportunityTypeId property
        private  _RefWorkbasedLearningOpportunityTypeId;

        // member variable for the SingleParentOrSinglePregnantWoman property
        private  _SingleParentOrSinglePregnantWoman;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  CareerPathwaysProgramParticipationExitDate { get => _CareerPathwaysProgramParticipationExitDate; set => SetProperty(ref _CareerPathwaysProgramParticipationExitDate, value); }

        /// <summary>
        /// </summary>
        public  CareerPathwaysProgramParticipationStartDate { get => _CareerPathwaysProgramParticipationStartDate; set => SetProperty(ref _CareerPathwaysProgramParticipationStartDate, value); }

        /// <summary>
        /// </summary>
        public Guid? CteCompleter { get => _CteCompleter; set => SetProperty(ref _CteCompleter, value); }

        /// <summary>
        /// </summary>
        public  CteConcentrator { get => _CteConcentrator; set => SetProperty(ref _CteConcentrator, value); }

        /// <summary>
        /// </summary>
        public  CteNonTraditionalCompletion { get => _CteNonTraditionalCompletion; set => SetProperty(ref _CteNonTraditionalCompletion, value); }

        /// <summary>
        /// </summary>
        public  CteParticipant { get => _CteParticipant; set => SetProperty(ref _CteParticipant, value); }

        /// <summary>
        /// </summary>
        public  DisplacedHomemakerIndicator { get => _DisplacedHomemakerIndicator; set => SetProperty(ref _DisplacedHomemakerIndicator, value); }

        /// <summary>
        /// </summary>
        public  OutOfWorkforceIndicator { get => _OutOfWorkforceIndicator; set => SetProperty(ref _OutOfWorkforceIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNonTraditionalGenderStatus"/> model
        /// </summary>
        public  RefNonTraditionalGenderStatusId { get => _RefNonTraditionalGenderStatusId; set => SetProperty(ref _RefNonTraditionalGenderStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        public  RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        /// <summary>
        /// </summary>
        public  SingleParentOrSinglePregnantWoman { get => _SingleParentOrSinglePregnantWoman; set => SetProperty(ref _SingleParentOrSinglePregnantWoman, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationCte model)
        {
            IsBusy = true;
            Id = model.Id;
            CareerPathwaysProgramParticipationExitDate = model.CareerPathwaysProgramParticipationExitDate; // 
            CareerPathwaysProgramParticipationStartDate = model.CareerPathwaysProgramParticipationStartDate; // 
            CteCompleter = model.CteCompleter; // 
            CteConcentrator = model.CteConcentrator; // 
            CteNonTraditionalCompletion = model.CteNonTraditionalCompletion; // 
            CteParticipant = model.CteParticipant; // 
            DisplacedHomemakerIndicator = model.DisplacedHomemakerIndicator; // 
            OutOfWorkforceIndicator = model.OutOfWorkforceIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefNonTraditionalGenderStatusId = model.RefNonTraditionalGenderStatusId; // 
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId; // 
            SingleParentOrSinglePregnantWoman = model.SingleParentOrSinglePregnantWoman; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
