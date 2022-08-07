//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonAddressViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonAddressViewModel
     /// </summary>
    public partial class PersonAddressViewModel : ViewModelBase, Interfaces.IPersonAddressViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonAddress";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefPersonLocationTypeId property
        private Guid _RefPersonLocationTypeId;

        // member variable for the StreetNumberAndName property
        private System.String _StreetNumberAndName;

        // member variable for the ApartmentRoomOrSuiteNumber property
        private System.String _ApartmentRoomOrSuiteNumber;

        // member variable for the City property
        private System.String _City;

        // member variable for the RefStateId property
        private Guid? _RefStateId;

        // member variable for the PostalCode property
        private System.String _PostalCode;

        // member variable for the AddressCountyName property
        private System.String _AddressCountyName;

        // member variable for the RefCountyId property
        private Guid? _RefCountyId;

        // member variable for the RefCountryId property
        private Guid? _RefCountryId;

        // member variable for the Latitude property
        private System.String _Latitude;

        // member variable for the Longitude property
        private System.String _Longitude;

        // member variable for the RefPersonalInformationVerificationId property
        private Guid? _RefPersonalInformationVerificationId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the DoNotPublishIndicator property
        private System.Boolean? _DoNotPublishIndicator;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PersonAddressViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonLocationTypeId"/> model
        /// </summary>
        public Guid RefPersonLocationTypeId { get => _RefPersonLocationTypeId; set => SetProperty(ref _RefPersonLocationTypeId, value); }

        public System.String StreetNumberAndName  { get => _StreetNumberAndName; set => SetProperty(ref _StreetNumberAndName, value); }

        public System.String ApartmentRoomOrSuiteNumber  { get => _ApartmentRoomOrSuiteNumber; set => SetProperty(ref _ApartmentRoomOrSuiteNumber, value); }

        public System.String City  { get => _City; set => SetProperty(ref _City, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStateId"/> model
        /// </summary>
        public Guid? RefStateId { get => _RefStateId; set => SetProperty(ref _RefStateId, value); }

        public System.String PostalCode  { get => _PostalCode; set => SetProperty(ref _PostalCode, value); }

        public System.String AddressCountyName  { get => _AddressCountyName; set => SetProperty(ref _AddressCountyName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountyId"/> model
        /// </summary>
        public Guid? RefCountyId { get => _RefCountyId; set => SetProperty(ref _RefCountyId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountryId"/> model
        /// </summary>
        public Guid? RefCountryId { get => _RefCountryId; set => SetProperty(ref _RefCountryId, value); }

        public System.String Latitude  { get => _Latitude; set => SetProperty(ref _Latitude, value); }

        public System.String Longitude  { get => _Longitude; set => SetProperty(ref _Longitude, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerificationId"/> model
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get => _RefPersonalInformationVerificationId; set => SetProperty(ref _RefPersonalInformationVerificationId, value); }

        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAddress model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefPersonLocationTypeId = model.RefPersonLocationTypeId;
            StreetNumberAndName = model.StreetNumberAndName;
            ApartmentRoomOrSuiteNumber = model.ApartmentRoomOrSuiteNumber;
            City = model.City;
            RefStateId = model.RefStateId;
            PostalCode = model.PostalCode;
            AddressCountyName = model.AddressCountyName;
            RefCountyId = model.RefCountyId;
            RefCountryId = model.RefCountryId;
            Latitude = model.Latitude;
            Longitude = model.Longitude;
            RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId;
            DoNotPublishIndicator = model.DoNotPublishIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
