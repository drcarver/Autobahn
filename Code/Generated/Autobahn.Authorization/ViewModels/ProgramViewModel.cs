//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ProgramViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ProgramViewModel
     /// </summary>
    public partial class ProgramViewModel : ViewModelBase, Interfaces.IProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Program";

        // member variable for the CreditsRequired property
        private System.Decimal? _CreditsRequired;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The total number of credits required for a student to graduate from the school of enrollment or complete a program.
        /// </summary>
        public System.Decimal? CreditsRequired { get => _CreditsRequired; set => SetProperty(ref _CreditsRequired, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            CreditsRequired = model.CreditsRequired;
            OrganizationId = model.OrganizationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
