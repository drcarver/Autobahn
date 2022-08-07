//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonOtherNameViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonOtherNameViewModel
     /// </summary>
    public partial class PersonOtherNameViewModel : ViewModelBase, Interfaces.IPersonOtherNameViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonOtherName";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefOtherNameTypeId property
        private Guid? _RefOtherNameTypeId;

        // member variable for the OtherName property
        private System.String _OtherName;

        // member variable for the FirstName property
        private System.String _FirstName;

        // member variable for the MiddleName property
        private System.String _MiddleName;

        // member variable for the LastName property
        private System.String _LastName;

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
        /// The title of the PersonOtherNameViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOtherNameTypeId"/> model
        /// </summary>
        public Guid? RefOtherNameTypeId { get => _RefOtherNameTypeId; set => SetProperty(ref _RefOtherNameTypeId, value); }

        public System.String OtherName  { get => _OtherName; set => SetProperty(ref _OtherName, value); }

        public System.String FirstName  { get => _FirstName; set => SetProperty(ref _FirstName, value); }

        public System.String MiddleName  { get => _MiddleName; set => SetProperty(ref _MiddleName, value); }

        public System.String LastName  { get => _LastName; set => SetProperty(ref _LastName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonOtherName model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefOtherNameTypeId = model.RefOtherNameTypeId;
            OtherName = model.OtherName;
            FirstName = model.FirstName;
            MiddleName = model.MiddleName;
            LastName = model.LastName;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
