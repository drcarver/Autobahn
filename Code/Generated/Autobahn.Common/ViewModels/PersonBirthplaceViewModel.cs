//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonBirthplaceViewModel.cs
//**********************************************************

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

        // member variable for the City property
        private System.String _City;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefCountryId property
        private Guid? _RefCountryId;

        // member variable for the RefStateId property
        private Guid? _RefStateId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonBirthplaceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
        /// </summary>
        public System.String City { get => _City; set => SetProperty(ref _City, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountry"/> model
        /// </summary>
        public Guid? RefCountryId { get => _RefCountryId; set => SetProperty(ref _RefCountryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefState"/> model
        /// </summary>
        public Guid? RefStateId { get => _RefStateId; set => SetProperty(ref _RefStateId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonBirthplace model)
        {
            IsBusy = true;
            Id = model.Id;
            City = model.City;
            PersonId = model.PersonId;
            RefCountryId = model.RefCountryId;
            RefStateId = model.RefStateId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
