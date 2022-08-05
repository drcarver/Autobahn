//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffExperienceViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffExperienceViewModel
     /// </summary>
    public partial class StaffExperienceViewModel : ViewModelBase, Interfaces.IStaffExperience
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffExperience";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the YearsOfPriorTeachingExperience property
        private System.Decimal? _YearsOfPriorTeachingExperience;

        // member variable for the YearsOfPriorAETeachingExperience property
        private System.Decimal? _YearsOfPriorAETeachingExperience;

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
        /// The title of the StaffExperienceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Decimal? YearsOfPriorTeachingExperience { get => _YearsOfPriorTeachingExperience; set => SetProperty(ref _YearsOfPriorTeachingExperience, value); }

        public System.Decimal? YearsOfPriorAETeachingExperience { get => _YearsOfPriorAETeachingExperience; set => SetProperty(ref _YearsOfPriorAETeachingExperience, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffExperience model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            YearsOfPriorTeachingExperience = model.YearsOfPriorTeachingExperience;
            YearsOfPriorAETeachingExperience = model.YearsOfPriorAETeachingExperience;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}