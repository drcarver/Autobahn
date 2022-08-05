//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationTitleIIILepViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationTitleIIILepViewModel
     /// </summary>
    public partial class ProgramParticipationTitleIIILepViewModel : ViewModelBase, Interfaces.IProgramParticipationTitleIIILep
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationTitleIIILep";

        // member variable for the RefTitleIIIAccountabilityId property
        private Guid? _RefTitleIIIAccountabilityId;

        // member variable for the RefTitleIIILanguageInstructionProgramTypeId property
        private Guid? _RefTitleIIILanguageInstructionProgramTypeId;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the ProgramParticipationTitleIiiLepId property
        private Guid _ProgramParticipationTitleIiiLepId;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationTitleIIILepViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIIAccountabilityId"/> model
        /// </summary>
        public Guid? RefTitleIIIAccountabilityId { get => _RefTitleIIIAccountabilityId; set => SetProperty(ref _RefTitleIIIAccountabilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIILanguageInstructionProgramTypeId"/> model
        /// </summary>
        public Guid? RefTitleIIILanguageInstructionProgramTypeId { get => _RefTitleIIILanguageInstructionProgramTypeId; set => SetProperty(ref _RefTitleIIILanguageInstructionProgramTypeId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProgramParticipationTitleIiiLepId"/> model
        /// </summary>
        public Guid ProgramParticipationTitleIiiLepId { get => _ProgramParticipationTitleIiiLepId; set => SetProperty(ref _ProgramParticipationTitleIiiLepId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationTitleIIILep model)
        {
            IsBusy = true;
            Id = model.Id;
            RefTitleIIIAccountabilityId = model.RefTitleIIIAccountabilityId;
            RefTitleIIILanguageInstructionProgramTypeId = model.RefTitleIIILanguageInstructionProgramTypeId;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            ProgramParticipationTitleIiiLepId = model.ProgramParticipationTitleIiiLepId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
