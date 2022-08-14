//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonMasterViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonMasterViewModel
     /// </summary>
    public partial class PersonMasterViewModel : ViewModelBase, Interfaces.IPersonMaster
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonMaster";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonMasterViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonMaster model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
