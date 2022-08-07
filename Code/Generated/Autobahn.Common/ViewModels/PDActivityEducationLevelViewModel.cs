//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PDActivityEducationLevelViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PDActivityEducationLevelViewModel
     /// </summary>
    public partial class PDActivityEducationLevelViewModel : ViewModelBase, Interfaces.IPDActivityEducationLevelViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PDActivityEducationLevel";

        // member variable for the ProfessionalDevelopmentActivityId property
        private Guid _ProfessionalDevelopmentActivityId;

        // member variable for the RefPDActivityEducationLevelsAddressedId property
        private Guid _RefPDActivityEducationLevelsAddressedId;

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
        /// The title of the PDActivityEducationLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentActivityId"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get => _ProfessionalDevelopmentActivityId; set => SetProperty(ref _ProfessionalDevelopmentActivityId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPDActivityEducationLevelsAddressedId"/> model
        /// </summary>
        public Guid RefPDActivityEducationLevelsAddressedId { get => _RefPDActivityEducationLevelsAddressedId; set => SetProperty(ref _RefPDActivityEducationLevelsAddressedId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPDActivityEducationLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            ProfessionalDevelopmentActivityId = model.ProfessionalDevelopmentActivityId;
            RefPDActivityEducationLevelsAddressedId = model.RefPDActivityEducationLevelsAddressedId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
