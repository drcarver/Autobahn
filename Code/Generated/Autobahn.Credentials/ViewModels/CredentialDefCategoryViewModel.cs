//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefCategoryViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the CredentialDefinitionId property
        private Guid _CredentialDefinitionId;

        // member variable for the Category property
        private System.String _Category;

        // member variable for the CategorySystem property
        private System.String _CategorySystem;

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
        /// The title of the CredentialDefCategoryViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinitionId"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get => _CredentialDefinitionId; set => SetProperty(ref _CredentialDefinitionId, value); }

        public System.String Category  { get => _Category; set => SetProperty(ref _Category, value); }

        public System.String CategorySystem  { get => _CategorySystem; set => SetProperty(ref _CategorySystem, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefCategory model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialDefinitionId = model.CredentialDefinitionId;
            Category = model.Category;
            CategorySystem = model.CategorySystem;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
