//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonAddressViewModel
     /// </summary>
    public partial class PersonAddressViewModel : ViewModelBase, Interfaces.IPersonAddress
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonAddress";

        // member variable for the AddressCountyName property
        private System.String _AddressCountyName;

        // member variable for the ApartmentRoomOrSuiteNumber property
        private System.String _ApartmentRoomOrSuiteNumber;

        // member variable for the City property
        private System.String _City;

        // member variable for the DoNotPublishIndicator property
        private System.Boolean? _DoNotPublishIndicator;

        // member variable for the Latitude property
        private System.String _Latitude;

        // member variable for the Longitude property
        private System.String _Longitude;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the PostalCode property
        private System.String _PostalCode;

        // member variable for the RefCountryId property
        private Guid? _RefCountryId;

        // member variable for the RefCountyId property
        private Guid? _RefCountyId;

        // member variable for the RefPersonalInformationVerificationId property
        private Guid? _RefPersonalInformationVerificationId;

        // member variable for the RefPersonLocationTypeId property
        private Guid _RefPersonLocationTypeId;

        // member variable for the RefStateId property
        private Guid? _RefStateId;

        // member variable for the StreetNumberAndName property
        private System.String _StreetNumberAndName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonAddressViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String AddressCountyName { get => _AddressCountyName; set => SetProperty(ref _AddressCountyName, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String ApartmentRoomOrSuiteNumber { get => _ApartmentRoomOrSuiteNumber; set => SetProperty(ref _ApartmentRoomOrSuiteNumber, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String City { get => _City; set => SetProperty(ref _City, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String Latitude { get => _Latitude; set => SetProperty(ref _Latitude, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String Longitude { get => _Longitude; set => SetProperty(ref _Longitude, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String PostalCode { get => _PostalCode; set => SetProperty(ref _PostalCode, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountry"/> model
        /// </summary>
        public Guid? RefCountryId { get => _RefCountryId; set => SetProperty(ref _RefCountryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCounty"/> model
        /// </summary>
        public Guid? RefCountyId { get => _RefCountyId; set => SetProperty(ref _RefCountyId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get => _RefPersonalInformationVerificationId; set => SetProperty(ref _RefPersonalInformationVerificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonLocationType"/> model
        /// </summary>
        public Guid RefPersonLocationTypeId { get => _RefPersonLocationTypeId; set => SetProperty(ref _RefPersonLocationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefState"/> model
        /// </summary>
        public Guid? RefStateId { get => _RefStateId; set => SetProperty(ref _RefStateId, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String StreetNumberAndName { get => _StreetNumberAndName; set => SetProperty(ref _StreetNumberAndName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAddress model)
        {
            IsBusy = true;
            Id = model.Id;
            AddressCountyName = model.AddressCountyName;
            ApartmentRoomOrSuiteNumber = model.ApartmentRoomOrSuiteNumber;
            City = model.City;
            DoNotPublishIndicator = model.DoNotPublishIndicator;
            Latitude = model.Latitude;
            Longitude = model.Longitude;
            PersonId = model.PersonId;
            PostalCode = model.PostalCode;
            RefCountryId = model.RefCountryId;
            RefCountyId = model.RefCountyId;
            RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId;
            RefPersonLocationTypeId = model.RefPersonLocationTypeId;
            RefStateId = model.RefStateId;
            StreetNumberAndName = model.StreetNumberAndName;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
