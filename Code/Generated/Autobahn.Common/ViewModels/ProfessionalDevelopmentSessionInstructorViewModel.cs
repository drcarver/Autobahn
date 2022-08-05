//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProfessionalDevelopmentSessionInstructorViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProfessionalDevelopmentSessionInstructorViewModel
     /// </summary>
    public partial class ProfessionalDevelopmentSessionInstructorViewModel : ViewModelBase, Interfaces.IProfessionalDevelopmentSessionInstructor
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProfessionalDevelopmentSessionInstructor";

        // member variable for the ProfessionalDevelopmentSessionId property
        private Guid _ProfessionalDevelopmentSessionId;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

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
        /// The title of the ProfessionalDevelopmentSessionInstructorViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentSessionId"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentSessionId { get => _ProfessionalDevelopmentSessionId; set => SetProperty(ref _ProfessionalDevelopmentSessionId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProfessionalDevelopmentSessionInstructor model)
        {
            IsBusy = true;
            Id = model.Id;
            ProfessionalDevelopmentSessionId = model.ProfessionalDevelopmentSessionId;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
