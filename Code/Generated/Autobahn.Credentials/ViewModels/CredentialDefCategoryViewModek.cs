//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialDefCategoryViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Credentials.Interfaces;

namespace Autobahn.Credentials.ViewModels
{
     /// <summary>
     /// The CredentialDefCategoryViewModel
     /// </summary>
    public partial class CredentialDefCategoryViewModel : BindableBase, ICredentialDefCategory
    {
#region "Backing Fields"
        // member variable for the Category property
        private System.String _Category;

        // member variable for the CategorySystem property
        private System.String _CategorySystem;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefinitionId"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

        public System.String Category  { get => _Category; set => SetProperty(ref _Category, value); }

        public System.String CategorySystem  { get => _CategorySystem; set => SetProperty(ref _CategorySystem, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(ICredentialDefCategory model)
        {
            IsBusy = true;
            Id = model.Id;
            CredentialDefinitionId = model.CredentialDefinitionId;
            Category = model.Category;
            CategorySystem = model.CategorySystem;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
