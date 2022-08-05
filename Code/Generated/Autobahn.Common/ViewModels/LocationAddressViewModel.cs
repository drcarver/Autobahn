//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   LocationAddressViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The LocationAddressViewModel
     /// </summary>
    public partial class LocationAddressViewModel : ViewModelBase, Interfaces.ILocationAddress
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LocationAddress";

        // member variable for the LocationId property
        private Guid _LocationId;

        // member variable for the StreetNumberAndName property
        private System.String _StreetNumberAndName;

        // member variable for the ApartmentRoomOrSuiteNumber property
        private System.String _ApartmentRoomOrSuiteNumber;

        // member variable for the BuildingSiteNumber property
        private System.String _BuildingSiteNumber;

        // member variable for the City property
        private System.String _City;

        // member variable for the PostalCode property
        private System.String _PostalCode;

        // member variable for the CountyName property
        private System.String _CountyName;

        // member variable for the Latitude property
        private System.String _Latitude;

        // member variable for the Longitude property
        private System.String _Longitude;

        // member variable for the FacilityBlockNumberArea property
        private System.String _FacilityBlockNumberArea;

        // member variable for the FacilityCensusTract property
        private System.String _FacilityCensusTract;

        // member variable for the RefStateId property
        private Guid? _RefStateId;

        // member variable for the RefCountyId property
        private Guid? _RefCountyId;

        // member variable for the RefCountryId property
        private Guid? _RefCountryId;

        // member variable for the RefERSRuralUrbanContinuumCodeId property
        private Guid? _RefERSRuralUrbanContinuumCodeId;

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
        /// The title of the LocationAddressViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="LocationId"/> model
        /// </summary>
        public Guid LocationId { get => _LocationId; set => SetProperty(ref _LocationId, value); }

        public System.String StreetNumberAndName  { get => _StreetNumberAndName; set => SetProperty(ref _StreetNumberAndName, value); }

        public System.String ApartmentRoomOrSuiteNumber  { get => _ApartmentRoomOrSuiteNumber; set => SetProperty(ref _ApartmentRoomOrSuiteNumber, value); }

        public System.String BuildingSiteNumber  { get => _BuildingSiteNumber; set => SetProperty(ref _BuildingSiteNumber, value); }

        public System.String City  { get => _City; set => SetProperty(ref _City, value); }

        public System.String PostalCode  { get => _PostalCode; set => SetProperty(ref _PostalCode, value); }

        public System.String CountyName  { get => _CountyName; set => SetProperty(ref _CountyName, value); }

        public System.String Latitude  { get => _Latitude; set => SetProperty(ref _Latitude, value); }

        public System.String Longitude  { get => _Longitude; set => SetProperty(ref _Longitude, value); }

        public System.String FacilityBlockNumberArea  { get => _FacilityBlockNumberArea; set => SetProperty(ref _FacilityBlockNumberArea, value); }

        public System.String FacilityCensusTract  { get => _FacilityCensusTract; set => SetProperty(ref _FacilityCensusTract, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStateId"/> model
        /// </summary>
        public Guid? RefStateId { get => _RefStateId; set => SetProperty(ref _RefStateId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountyId"/> model
        /// </summary>
        public Guid? RefCountyId { get => _RefCountyId; set => SetProperty(ref _RefCountyId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountryId"/> model
        /// </summary>
        public Guid? RefCountryId { get => _RefCountryId; set => SetProperty(ref _RefCountryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefERSRuralUrbanContinuumCodeId"/> model
        /// </summary>
        public Guid? RefERSRuralUrbanContinuumCodeId { get => _RefERSRuralUrbanContinuumCodeId; set => SetProperty(ref _RefERSRuralUrbanContinuumCodeId, value); }

        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILocationAddress model)
        {
            IsBusy = true;
            Id = model.Id;
            LocationId = model.LocationId;
            StreetNumberAndName = model.StreetNumberAndName;
            ApartmentRoomOrSuiteNumber = model.ApartmentRoomOrSuiteNumber;
            BuildingSiteNumber = model.BuildingSiteNumber;
            City = model.City;
            PostalCode = model.PostalCode;
            CountyName = model.CountyName;
            Latitude = model.Latitude;
            Longitude = model.Longitude;
            FacilityBlockNumberArea = model.FacilityBlockNumberArea;
            FacilityCensusTract = model.FacilityCensusTract;
            RefStateId = model.RefStateId;
            RefCountyId = model.RefCountyId;
            RefCountryId = model.RefCountryId;
            RefERSRuralUrbanContinuumCodeId = model.RefERSRuralUrbanContinuumCodeId;
            DoNotPublishIndicator = model.DoNotPublishIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
