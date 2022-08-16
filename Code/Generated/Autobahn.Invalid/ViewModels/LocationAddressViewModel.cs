//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   LocationAddressViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
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
        private Guid? _ApartmentRoomOrSuiteNumber;

        // member variable for the BuildingSiteNumber property
        private  _BuildingSiteNumber;

        // member variable for the City property
        private  _City;

        // member variable for the CountyName property
        private  _CountyName;

        // member variable for the DoNotPublishIndicator property
        private  _DoNotPublishIndicator;

        // member variable for the FacilityBlockNumberArea property
        private  _FacilityBlockNumberArea;

        // member variable for the FacilityCensusTract property
        private  _FacilityCensusTract;

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

        // member variable for the RefERSRuralUrbanContinuumCodeId property
        private  _RefERSRuralUrbanContinuumCodeId;

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
        public Guid? ApartmentRoomOrSuiteNumber { get => _ApartmentRoomOrSuiteNumber; set => SetProperty(ref _ApartmentRoomOrSuiteNumber, value); }

        /// <summary>
        /// </summary>
        public  BuildingSiteNumber { get => _BuildingSiteNumber; set => SetProperty(ref _BuildingSiteNumber, value); }

        /// <summary>
        /// </summary>
        public  City { get => _City; set => SetProperty(ref _City, value); }

        /// <summary>
        /// </summary>
        public  CountyName { get => _CountyName; set => SetProperty(ref _CountyName, value); }

        /// <summary>
        /// </summary>
        public  DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// </summary>
        public  FacilityBlockNumberArea { get => _FacilityBlockNumberArea; set => SetProperty(ref _FacilityBlockNumberArea, value); }

        /// <summary>
        /// </summary>
        public  FacilityCensusTract { get => _FacilityCensusTract; set => SetProperty(ref _FacilityCensusTract, value); }

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
        /// Reference to an optional instance of the <see cref="RefERSRuralUrbanContinuumCode"/> model
        /// </summary>
        public  RefERSRuralUrbanContinuumCodeId { get => _RefERSRuralUrbanContinuumCodeId; set => SetProperty(ref _RefERSRuralUrbanContinuumCodeId, value); }

        /// <summary>
        /// </summary>
        public  StreetNumberAndName { get => _StreetNumberAndName; set => SetProperty(ref _StreetNumberAndName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILocationAddress model)
        {
            IsBusy = true;
            Id = model.Id;
            ApartmentRoomOrSuiteNumber = model.ApartmentRoomOrSuiteNumber; // 
            BuildingSiteNumber = model.BuildingSiteNumber; // 
            City = model.City; // 
            CountyName = model.CountyName; // 
            DoNotPublishIndicator = model.DoNotPublishIndicator; // 
            FacilityBlockNumberArea = model.FacilityBlockNumberArea; // 
            FacilityCensusTract = model.FacilityCensusTract; // 
            Latitude = model.Latitude; // 
            Longitude = model.Longitude; // 
            PostalCode = model.PostalCode; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefERSRuralUrbanContinuumCodeId = model.RefERSRuralUrbanContinuumCodeId; // 
            StreetNumberAndName = model.StreetNumberAndName; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
