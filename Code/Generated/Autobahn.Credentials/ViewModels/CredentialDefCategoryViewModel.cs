//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCategoryViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private Guid? _Category;

        // member variable for the CategorySystem property
        private  _CategorySystem;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? Category { get => _Category; set => SetProperty(ref _Category, value); }

        /// <summary>
        /// </summary>
        public  CategorySystem { get => _CategorySystem; set => SetProperty(ref _CategorySystem, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICredentialDefCategory model)
        {
            IsBusy = true;
            Id = model.Id;
            Category = model.Category; // 
            CategorySystem = model.CategorySystem; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
