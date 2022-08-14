//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLanguageViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonLanguageViewModel
     /// </summary>
    public partial class PersonLanguageViewModel : ViewModelBase, Interfaces.IPersonLanguage
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonLanguage";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefLanguageId property
        private Guid _RefLanguageId;

        // member variable for the RefLanguageUseTypeId property
        private Guid _RefLanguageUseTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonLanguageViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguageUseType"/> model
        /// </summary>
        public Guid RefLanguageUseTypeId { get => _RefLanguageUseTypeId; set => SetProperty(ref _RefLanguageUseTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonLanguage model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefLanguageId = model.RefLanguageId;
            RefLanguageUseTypeId = model.RefLanguageUseTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
