//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffExperienceViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

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

        // member variable for the YearsOfPriorAETeachingExperience property
        private System.Decimal? _YearsOfPriorAETeachingExperience;

        // member variable for the YearsOfPriorTeachingExperience property
        private System.Decimal? _YearsOfPriorTeachingExperience;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the StaffExperienceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.
        /// </summary>
        public System.Decimal? YearsOfPriorAETeachingExperience { get => _YearsOfPriorAETeachingExperience; set => SetProperty(ref _YearsOfPriorAETeachingExperience, value); }

        /// <summary>
        /// The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.
        /// </summary>
        public System.Decimal? YearsOfPriorTeachingExperience { get => _YearsOfPriorTeachingExperience; set => SetProperty(ref _YearsOfPriorTeachingExperience, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffExperience model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            YearsOfPriorAETeachingExperience = model.YearsOfPriorAETeachingExperience;
            YearsOfPriorTeachingExperience = model.YearsOfPriorTeachingExperience;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
