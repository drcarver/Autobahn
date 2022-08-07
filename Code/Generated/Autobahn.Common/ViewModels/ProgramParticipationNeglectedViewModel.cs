//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationNeglectedViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationNeglectedViewModel
     /// </summary>
    public partial class ProgramParticipationNeglectedViewModel : ViewModelBase, Interfaces.IProgramParticipationNeglectedViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationNeglected";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the RefNeglectedProgramTypeId property
        private Guid? _RefNeglectedProgramTypeId;

        // member variable for the AchievementIndicator property
        private System.Boolean? _AchievementIndicator;

        // member variable for the OutcomeIndicator property
        private System.Boolean? _OutcomeIndicator;

        // member variable for the ObtainedEmployment property
        private System.Boolean? _ObtainedEmployment;

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
        /// The title of the ProgramParticipationNeglectedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNeglectedProgramTypeId"/> model
        /// </summary>
        public Guid? RefNeglectedProgramTypeId { get => _RefNeglectedProgramTypeId; set => SetProperty(ref _RefNeglectedProgramTypeId, value); }

        public System.Boolean? AchievementIndicator { get => _AchievementIndicator; set => SetProperty(ref _AchievementIndicator, value); }

        public System.Boolean? OutcomeIndicator { get => _OutcomeIndicator; set => SetProperty(ref _OutcomeIndicator, value); }

        public System.Boolean? ObtainedEmployment { get => _ObtainedEmployment; set => SetProperty(ref _ObtainedEmployment, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationNeglected model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            RefNeglectedProgramTypeId = model.RefNeglectedProgramTypeId;
            AchievementIndicator = model.AchievementIndicator;
            OutcomeIndicator = model.OutcomeIndicator;
            ObtainedEmployment = model.ObtainedEmployment;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
