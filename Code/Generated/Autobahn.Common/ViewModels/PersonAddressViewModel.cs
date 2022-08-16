//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

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
        private  _AddressCountyName;

        // member variable for the ApartmentRoomOrSuiteNumber property
        private Guid? _ApartmentRoomOrSuiteNumber;

        // member variable for the City property
        private  _City;

        // member variable for the DoNotPublishIndicator property
        private  _DoNotPublishIndicator;

        // member variable for the Latitude property
        private  _Latitude;

        // member variable for the Longitude property
        private  _Longitude;

        // member variable for the PostalCode property
        private  _PostalCode;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCountryId property
        private  _RefCountryId;

        // member variable for the RefPersonalInformationVerificationId property
        private  _RefPersonalInformationVerificationId;

        // member variable for the RefPersonLocationTypeId property
        private  _RefPersonLocationTypeId;

        // member variable for the RefStateId property
        private  _RefStateId;

        // member variable for the StreetNumberAndName property
        private  _StreetNumberAndName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AddressCountyName { get => _AddressCountyName; set => SetProperty(ref _AddressCountyName, value); }

        /// <summary>
        /// </summary>
        public Guid? ApartmentRoomOrSuiteNumber { get => _ApartmentRoomOrSuiteNumber; set => SetProperty(ref _ApartmentRoomOrSuiteNumber, value); }

        /// <summary>
        /// </summary>
        public  City { get => _City; set => SetProperty(ref _City, value); }

        /// <summary>
        /// </summary>
        public  DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// </summary>
        public  Latitude { get => _Latitude; set => SetProperty(ref _Latitude, value); }

        /// <summary>
        /// </summary>
        public  Longitude { get => _Longitude; set => SetProperty(ref _Longitude, value); }

        /// <summary>
        /// </summary>
        public  PostalCode { get => _PostalCode; set => SetProperty(ref _PostalCode, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountry"/> model
        /// </summary>
        public  RefCountryId { get => _RefCountryId; set => SetProperty(ref _RefCountryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        public  RefPersonalInformationVerificationId { get => _RefPersonalInformationVerificationId; set => SetProperty(ref _RefPersonalInformationVerificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonLocationType"/> model
        /// </summary>
        public  RefPersonLocationTypeId { get => _RefPersonLocationTypeId; set => SetProperty(ref _RefPersonLocationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefState"/> model
        /// </summary>
        public  RefStateId { get => _RefStateId; set => SetProperty(ref _RefStateId, value); }

        /// <summary>
        /// </summary>
        public  StreetNumberAndName { get => _StreetNumberAndName; set => SetProperty(ref _StreetNumberAndName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAddress model)
        {
            IsBusy = true;
            Id = model.Id;
            AddressCountyName = model.AddressCountyName; // 
            ApartmentRoomOrSuiteNumber = model.ApartmentRoomOrSuiteNumber; // 
            City = model.City; // 
            DoNotPublishIndicator = model.DoNotPublishIndicator; // 
            Latitude = model.Latitude; // 
            Longitude = model.Longitude; // 
            PostalCode = model.PostalCode; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCountryId = model.RefCountryId; // 
            RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId; // 
            RefPersonLocationTypeId = model.RefPersonLocationTypeId; // 
            RefStateId = model.RefStateId; // 
            StreetNumberAndName = model.StreetNumberAndName; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
