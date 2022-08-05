//**********************************************************
//* DomainName: Autobahn.Common
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
        /// The title of the PersonLanguageViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLanguageId"/> model
        /// </summary>
        public Guid RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLanguageUseTypeId"/> model
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
