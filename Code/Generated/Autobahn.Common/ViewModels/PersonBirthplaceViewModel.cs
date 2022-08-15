//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonBirthplaceViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonBirthplaceViewModel
     /// </summary>
    public partial class PersonBirthplaceViewModel : ViewModelBase, Interfaces.IPersonBirthplace
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonBirthplace";

        // member variable for the RefCountryId property
        private Guid? _RefCountryId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonBirthplaceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountry"/> model
        /// </summary>
        public Guid? RefCountryId { get => _RefCountryId; set => SetProperty(ref _RefCountryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonBirthplace model)
        {
            IsBusy = true;
            Id = model.Id;
            RefCountryId = model.RefCountryId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
