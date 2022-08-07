//**********************************************************
//* DomainName: Autobahn.CareerandTechnical
//* FileName:   ProgramParticipationCteViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.CareerandTechnical.ViewModels
{
     /// <summary>
     /// The ProgramParticipationCteViewModel
     /// </summary>
    public partial class ProgramParticipationCteViewModel : ViewModelBase, Interfaces.IProgramParticipationCteViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationCte";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the CteParticipant property
        private System.Boolean? _CteParticipant;

        // member variable for the CteConcentrator property
        private System.Boolean? _CteConcentrator;

        // member variable for the CteCompleter property
        private System.Boolean? _CteCompleter;

        // member variable for the SingleParentOrSinglePregnantWoman property
        private System.Boolean? _SingleParentOrSinglePregnantWoman;

        // member variable for the DisplacedHomemakerIndicator property
        private System.Boolean? _DisplacedHomemakerIndicator;

        // member variable for the CteNonTraditionalCompletion property
        private System.Boolean? _CteNonTraditionalCompletion;

        // member variable for the RefNonTraditionalGenderStatusId property
        private Guid? _RefNonTraditionalGenderStatusId;

        // member variable for the RefWorkbasedLearningOpportunityTypeId property
        private Guid? _RefWorkbasedLearningOpportunityTypeId;

        // member variable for the CareerPathwaysProgramParticipationExitDate property
        private System.DateTime? _CareerPathwaysProgramParticipationExitDate;

        // member variable for the CareerPathwaysProgramParticipationStartDate property
        private System.DateTime? _CareerPathwaysProgramParticipationStartDate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the OutOfWorkforceIndicator property
        private System.Boolean? _OutOfWorkforceIndicator;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationCteViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        public System.Boolean? CteParticipant { get => _CteParticipant; set => SetProperty(ref _CteParticipant, value); }

        public System.Boolean? CteConcentrator { get => _CteConcentrator; set => SetProperty(ref _CteConcentrator, value); }

        public System.Boolean? CteCompleter { get => _CteCompleter; set => SetProperty(ref _CteCompleter, value); }

        public System.Boolean? SingleParentOrSinglePregnantWoman { get => _SingleParentOrSinglePregnantWoman; set => SetProperty(ref _SingleParentOrSinglePregnantWoman, value); }

        public System.Boolean? DisplacedHomemakerIndicator { get => _DisplacedHomemakerIndicator; set => SetProperty(ref _DisplacedHomemakerIndicator, value); }

        public System.Boolean? CteNonTraditionalCompletion { get => _CteNonTraditionalCompletion; set => SetProperty(ref _CteNonTraditionalCompletion, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNonTraditionalGenderStatusId"/> model
        /// </summary>
        public Guid? RefNonTraditionalGenderStatusId { get => _RefNonTraditionalGenderStatusId; set => SetProperty(ref _RefNonTraditionalGenderStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityTypeId"/> model
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        public System.DateTime? CareerPathwaysProgramParticipationExitDate { get => _CareerPathwaysProgramParticipationExitDate; set => SetProperty(ref _CareerPathwaysProgramParticipationExitDate, value); }

        public System.DateTime? CareerPathwaysProgramParticipationStartDate { get => _CareerPathwaysProgramParticipationStartDate; set => SetProperty(ref _CareerPathwaysProgramParticipationStartDate, value); }

        public System.Boolean? OutOfWorkforceIndicator { get => _OutOfWorkforceIndicator; set => SetProperty(ref _OutOfWorkforceIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationCte model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            CteParticipant = model.CteParticipant;
            CteConcentrator = model.CteConcentrator;
            CteCompleter = model.CteCompleter;
            SingleParentOrSinglePregnantWoman = model.SingleParentOrSinglePregnantWoman;
            DisplacedHomemakerIndicator = model.DisplacedHomemakerIndicator;
            CteNonTraditionalCompletion = model.CteNonTraditionalCompletion;
            RefNonTraditionalGenderStatusId = model.RefNonTraditionalGenderStatusId;
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId;
            CareerPathwaysProgramParticipationExitDate = model.CareerPathwaysProgramParticipationExitDate;
            CareerPathwaysProgramParticipationStartDate = model.CareerPathwaysProgramParticipationStartDate;
            OutOfWorkforceIndicator = model.OutOfWorkforceIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
