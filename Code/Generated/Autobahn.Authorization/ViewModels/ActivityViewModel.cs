//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ActivityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ActivityViewModel
     /// </summary>
    public partial class ActivityViewModel : ViewModelBase, Interfaces.IActivity
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Activity";

        // member variable for the ActivityDescription property
        private System.String _ActivityDescription;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ActivityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A description of the events and procedures that take place under the purview of an organized activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </summary>
        public System.String ActivityDescription { get => _ActivityDescription; set => SetProperty(ref _ActivityDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivityDescription = model.ActivityDescription;
            OrganizationId = model.OrganizationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
