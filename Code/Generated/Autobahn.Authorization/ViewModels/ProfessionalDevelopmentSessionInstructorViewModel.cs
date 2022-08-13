//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProfessionalDevelopmentSessionInstructorViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ProfessionalDevelopmentSessionInstructorViewModel
     /// </summary>
    public partial class ProfessionalDevelopmentSessionInstructorViewModel : ViewModelBase, Interfaces.IProfessionalDevelopmentSessionInstructor
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProfessionalDevelopmentSessionInstructor";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the ProfessionalDevelopmentSessionId property
        private Guid _ProfessionalDevelopmentSessionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProfessionalDevelopmentSessionInstructorViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ProfessionalDevelopmentSession"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentSessionId { get => _ProfessionalDevelopmentSessionId; set => SetProperty(ref _ProfessionalDevelopmentSessionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProfessionalDevelopmentSessionInstructor model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            ProfessionalDevelopmentSessionId = model.ProfessionalDevelopmentSessionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
