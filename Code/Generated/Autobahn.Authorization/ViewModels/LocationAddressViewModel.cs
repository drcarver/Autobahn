//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LocationAddressViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The LocationAddressViewModel
     /// </summary>
    public partial class LocationAddressViewModel : ViewModelBase, Interfaces.ILocationAddress
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LocationAddress";

        // member variable for the ApartmentRoomOrSuiteNumber property
        private System.String _ApartmentRoomOrSuiteNumber;

        // member variable for the BuildingSiteNumber property
        private System.String _BuildingSiteNumber;

        // member variable for the City property
        private System.String _City;

        // member variable for the CountyName property
        private System.String _CountyName;

        // member variable for the DoNotPublishIndicator property
        private System.Boolean? _DoNotPublishIndicator;

        // member variable for the FacilityBlockNumberArea property
        private System.String _FacilityBlockNumberArea;

        // member variable for the FacilityCensusTract property
        private System.String _FacilityCensusTract;

        // member variable for the Latitude property
        private System.String _Latitude;

        // member variable for the LocationId property
        private Guid _LocationId;

        // member variable for the Longitude property
        private System.String _Longitude;

        // member variable for the PostalCode property
        private System.String _PostalCode;

        // member variable for the RefCountryId property
        private Guid? _RefCountryId;

        // member variable for the RefCountyId property
        private Guid? _RefCountyId;

        // member variable for the RefERSRuralUrbanContinuumCodeId property
        private Guid? _RefERSRuralUrbanContinuumCodeId;

        // member variable for the RefStateId property
        private Guid? _RefStateId;

        // member variable for the StreetNumberAndName property
        private System.String _StreetNumberAndName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LocationAddressViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String ApartmentRoomOrSuiteNumber { get => _ApartmentRoomOrSuiteNumber; set => SetProperty(ref _ApartmentRoomOrSuiteNumber, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String BuildingSiteNumber { get => _BuildingSiteNumber; set => SetProperty(ref _BuildingSiteNumber, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String City { get => _City; set => SetProperty(ref _City, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String CountyName { get => _CountyName; set => SetProperty(ref _CountyName, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String FacilityBlockNumberArea { get => _FacilityBlockNumberArea; set => SetProperty(ref _FacilityBlockNumberArea, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String FacilityCensusTract { get => _FacilityCensusTract; set => SetProperty(ref _FacilityCensusTract, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String Latitude { get => _Latitude; set => SetProperty(ref _Latitude, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Location"/> model
        /// </summary>
        public Guid LocationId { get => _LocationId; set => SetProperty(ref _LocationId, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String Longitude { get => _Longitude; set => SetProperty(ref _Longitude, value); }

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
        /// Reference to an optional instance of the <see cref="RefERSRuralUrbanContinuumCode"/> model
        /// </summary>
        public Guid? RefERSRuralUrbanContinuumCodeId { get => _RefERSRuralUrbanContinuumCodeId; set => SetProperty(ref _RefERSRuralUrbanContinuumCodeId, value); }

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
        public void Load(Interfaces.ILocationAddress model)
        {
            IsBusy = true;
            Id = model.Id;
            ApartmentRoomOrSuiteNumber = model.ApartmentRoomOrSuiteNumber;
            BuildingSiteNumber = model.BuildingSiteNumber;
            City = model.City;
            CountyName = model.CountyName;
            DoNotPublishIndicator = model.DoNotPublishIndicator;
            FacilityBlockNumberArea = model.FacilityBlockNumberArea;
            FacilityCensusTract = model.FacilityCensusTract;
            Latitude = model.Latitude;
            LocationId = model.LocationId;
            Longitude = model.Longitude;
            PostalCode = model.PostalCode;
            RefCountryId = model.RefCountryId;
            RefCountyId = model.RefCountyId;
            RefERSRuralUrbanContinuumCodeId = model.RefERSRuralUrbanContinuumCodeId;
            RefStateId = model.RefStateId;
            StreetNumberAndName = model.StreetNumberAndName;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
