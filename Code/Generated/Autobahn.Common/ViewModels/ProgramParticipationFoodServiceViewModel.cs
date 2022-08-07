//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramParticipationFoodServiceViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationFoodServiceViewModel
     /// </summary>
    public partial class ProgramParticipationFoodServiceViewModel : ViewModelBase, Interfaces.IProgramParticipationFoodServiceViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationFoodService";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // member variable for the RefSchoolFoodServiceProgramId property
        private Guid _RefSchoolFoodServiceProgramId;

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
        /// The title of the ProgramParticipationFoodServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonProgramParticipationId"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefSchoolFoodServiceProgramId"/> model
        /// </summary>
        public Guid RefSchoolFoodServiceProgramId { get => _RefSchoolFoodServiceProgramId; set => SetProperty(ref _RefSchoolFoodServiceProgramId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationFoodService model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId;
            RefSchoolFoodServiceProgramId = model.RefSchoolFoodServiceProgramId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
