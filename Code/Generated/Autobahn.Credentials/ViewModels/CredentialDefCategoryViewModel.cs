//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCategoryViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefCategoryViewModel
     /// </summary>
    public partial class CredentialDefCategoryViewModel : ViewModelBase, Interfaces.ICredentialDefCategory
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CredentialDefCategory";

        // member variable for the Category property
        private System.String _Category;

        // member variable for the CategorySystem property
        private System.String _CategorySystem;

        // member variable for the CredentialDefinitionId property
        private Guid _CredentialDefinitionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CredentialDefCategoryViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String Category { get => _Category; set => SetProperty(ref _Category, value); }

        /// <summary>
        /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String CategorySystem { get => _CategorySystem; set => SetProperty(ref _CategorySystem, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefCategory model)
        {
            IsBusy = true;
            Id = model.Id;
            Category = model.Category;
            CategorySystem = model.CategorySystem;
            CredentialDefinitionId = model.CredentialDefinitionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
