//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProfessionalDevelopmentRequirementViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProfessionalDevelopmentRequirementViewModel
     /// </summary>
    public partial class ProfessionalDevelopmentRequirementViewModel : ViewModelBase, Interfaces.IProfessionalDevelopmentRequirement
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProfessionalDevelopmentRequirement";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RequiredTrainingClockHours property
        private System.Decimal? _RequiredTrainingClockHours;

        // member variable for the CompetencySetId property
        private Guid? _CompetencySetId;

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
        /// The title of the ProfessionalDevelopmentRequirementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Decimal? RequiredTrainingClockHours { get => _RequiredTrainingClockHours; set => SetProperty(ref _RequiredTrainingClockHours, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySetId"/> model
        /// </summary>
        public Guid? CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProfessionalDevelopmentRequirement model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RequiredTrainingClockHours = model.RequiredTrainingClockHours;
            CompetencySetId = model.CompetencySetId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
