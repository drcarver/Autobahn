//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProfessionalDevelopmentRequirementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ProfessionalDevelopmentRequirementViewModel
     /// </summary>
    public partial class ProfessionalDevelopmentRequirementViewModel : ViewModelBase, Interfaces.IProfessionalDevelopmentRequirement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProfessionalDevelopmentRequirement";

        // member variable for the CompetencySetId property
        private Guid? _CompetencySetId;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RequiredTrainingClockHours property
        private System.Decimal? _RequiredTrainingClockHours;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProfessionalDevelopmentRequirementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySet"/> model
        /// </summary>
        public Guid? CompetencySetId { get => _CompetencySetId; set => SetProperty(ref _CompetencySetId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Number of clock hours of training required for providers to meet requirements of the state.
        /// </summary>
        public System.Decimal? RequiredTrainingClockHours { get => _RequiredTrainingClockHours; set => SetProperty(ref _RequiredTrainingClockHours, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProfessionalDevelopmentRequirement model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencySetId = model.CompetencySetId;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RequiredTrainingClockHours = model.RequiredTrainingClockHours;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
