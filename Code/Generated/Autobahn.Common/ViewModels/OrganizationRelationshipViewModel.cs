//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationRelationshipViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationRelationshipViewModel
     /// </summary>
    public partial class OrganizationRelationshipViewModel : ViewModelBase, Interfaces.IOrganizationRelationship
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationRelationship";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the Parent_OrganizationId property
        private Guid _Parent_OrganizationId;

        // member variable for the RefOrganizationRelationshipId property
        private Guid? _RefOrganizationRelationshipId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationRelationshipViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Parent_Organization"/> model
        /// </summary>
        public Guid Parent_OrganizationId { get => _Parent_OrganizationId; set => SetProperty(ref _Parent_OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationRelationship"/> model
        /// </summary>
        public Guid? RefOrganizationRelationshipId { get => _RefOrganizationRelationshipId; set => SetProperty(ref _RefOrganizationRelationshipId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationRelationship model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            Parent_OrganizationId = model.Parent_OrganizationId;
            RefOrganizationRelationshipId = model.RefOrganizationRelationshipId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
