//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationWIOAViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationWIOAViewModel
     /// </summary>
    public partial class ProgramParticipationWIOAViewModel : ViewModelBase, Interfaces.IProgramParticipationWIOAViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationWIOA";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the WIOACareerServices property
        private System.Boolean? _WIOACareerServices;

        // member variable for the WIOATrainingServices property
        private System.Boolean? _WIOATrainingServices;

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
        /// The title of the ProgramParticipationWIOAViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        public System.Boolean? WIOACareerServices { get => _WIOACareerServices; set => SetProperty(ref _WIOACareerServices, value); }

        public System.Boolean? WIOATrainingServices { get => _WIOATrainingServices; set => SetProperty(ref _WIOATrainingServices, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationWIOA model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            WIOACareerServices = model.WIOACareerServices;
            WIOATrainingServices = model.WIOATrainingServices;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
