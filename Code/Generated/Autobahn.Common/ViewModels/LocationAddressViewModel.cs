//**********************************************************
//* DomainName: Common Models
//* FileName:   LocationAddressViewModel.cs
//* Name:       Address Apartment Room or Suite Number
//* Definition: The apartment, room, or suite number of an address.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The apartment, room, or suite number of an address.
     /// </summary>
    public partial class LocationAddressViewModel : ViewModelBase, Interfaces.ILocationAddress
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LocationAddress";

        // ApartmentRoomOrSuiteNumber -- (backing property for Address Apartment Room or Suite Number)
        private System.String _ApartmentRoomOrSuiteNumber;

        // BuildingSiteNumber -- (backing property for Building Site Number)
        private System.String _BuildingSiteNumber;

        // City -- (backing property for Address City)
        private System.String _City;

        // CountyName -- (backing property for Address County Name)
        private System.String _CountyName;

        // DoNotPublishIndicator -- (backing property for Do Not Publish Indicator)
        private System.Boolean? _DoNotPublishIndicator;

        // FacilityBlockNumberArea -- (backing property for Facility Block Number Area)
        private System.String _FacilityBlockNumberArea;

        // FacilityCensusTract -- (backing property for Facility Census Tract)
        private System.String _FacilityCensusTract;

        // Latitude -- (backing property for Latitude)
        private System.String _Latitude;

        // member variable for the LocationId property
        private Guid _LocationId;

        // Longitude -- (backing property for Longitude)
        private System.String _Longitude;

        // PostalCode -- (backing property for Address Postal Code)
        private System.String _PostalCode;

        // member variable for the RefCountryId property
        private Guid? _RefCountryId;

        // member variable for the RefCountyId property
        private Guid? _RefCountyId;

        // RefERSRuralUrbanContinuumCodeId -- (backing property for Economic Research Service Rural-Urban Continuum Code)
        private Guid? _RefERSRuralUrbanContinuumCodeId;

        // member variable for the RefStateId property
        private Guid? _RefStateId;

        // StreetNumberAndName -- (backing property for Address Street Number and Name)
        private System.String _StreetNumberAndName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Address Apartment Room or Suite Number
        /// <para>
        /// The apartment, room, or suite number of an address.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19019">Address Apartment Room or Suite Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ApartmentRoomOrSuiteNumber { get => _ApartmentRoomOrSuiteNumber; set => SetProperty(ref _ApartmentRoomOrSuiteNumber, value); }

        /// <summary>
        /// Building Site Number
        /// <para>
        /// The number of the building on the site, if more than one building shares the same address.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19595">Building Site Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingSiteNumber { get => _BuildingSiteNumber; set => SetProperty(ref _BuildingSiteNumber, value); }

        /// <summary>
        /// Address City
        /// <para>
        /// The name of the city in which an address is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19040">Address City</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String City { get => _City; set => SetProperty(ref _City, value); }

        /// <summary>
        /// Address County Name
        /// <para>
        /// The name of the county, parish, borough, or comparable unit (within a state) in which an address is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19190">Address County Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CountyName { get => _CountyName; set => SetProperty(ref _CountyName, value); }

        /// <summary>
        /// Do Not Publish Indicator
        /// <para>
        /// An indication that the record should not be published.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// Facility Block Number Area
        /// <para>
        /// The informal description of location sometimes used in rural areas, for example, "from the highway to the railroad tracks."
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20755">Facility Block Number Area</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilityBlockNumberArea { get => _FacilityBlockNumberArea; set => SetProperty(ref _FacilityBlockNumberArea, value); }

        /// <summary>
        /// Facility Census Tract
        /// <para>
        /// The census tract number of the school site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20760">Facility Census Tract</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FacilityCensusTract { get => _FacilityCensusTract; set => SetProperty(ref _FacilityCensusTract, value); }

        /// <summary>
        /// Latitude
        /// <para>
        /// The north or south angular distance from the equator that, when combined with longitude, reflects an estimation of where the address is physically situated.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19599">Latitude</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Latitude { get => _Latitude; set => SetProperty(ref _Latitude, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILocation"/> model
        /// </summary>
        public Guid LocationId { get => _LocationId; set => SetProperty(ref _LocationId, value); }

        /// <summary>
        /// Longitude
        /// <para>
        /// The east or west angular distance from the prime meridian that, when combined with latitude, reflects an estimation of where the address is physically situated.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19600">Longitude</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Longitude { get => _Longitude; set => SetProperty(ref _Longitude, value); }

        /// <summary>
        /// Address Postal Code
        /// <para>
        /// A number that identifies each postal delivery area in the United States used as a portion of an address.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19214">Address Postal Code</a>
        /// </para>
        /// </summary>
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
        /// Economic Research Service Rural-Urban Continuum Code
        /// <para>
        /// Rural-Urban Continuum Codes form a classification scheme that distinguishes metropolitan (metro) counties by the population size of their metro area, and nonmetropolitan (nonmetro) counties by degree of urbanization and adjacency to a metro area or areas. The metro and nonmetro categories have been subdivided into three metro and six nonmetro groupings, resulting in a nine-part county codification. The codes allow researchers working with county data to break such data into finer residential groups beyond a simple metro-nonmetro dichotomy, particularly for the analysis of trends in nonmetro areas that may be related to degree of rurality and metro proximity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19862">Economic Research Service Rural-Urban Continuum Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefERSRuralUrbanContinuumCodeId { get => _RefERSRuralUrbanContinuumCodeId; set => SetProperty(ref _RefERSRuralUrbanContinuumCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefState"/> model
        /// </summary>
        public Guid? RefStateId { get => _RefStateId; set => SetProperty(ref _RefStateId, value); }

        /// <summary>
        /// Address Street Number and Name
        /// <para>
        /// The street number and street name or post office box number of an address.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19269">Address Street Number and Name</a>
        /// </para>
        /// </summary>
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
            ApartmentRoomOrSuiteNumber = model.ApartmentRoomOrSuiteNumber; // Address Apartment Room or Suite Number
            BuildingSiteNumber = model.BuildingSiteNumber; // Building Site Number
            City = model.City; // Address City
            CountyName = model.CountyName; // Address County Name
            DoNotPublishIndicator = model.DoNotPublishIndicator; // Do Not Publish Indicator
            FacilityBlockNumberArea = model.FacilityBlockNumberArea; // Facility Block Number Area
            FacilityCensusTract = model.FacilityCensusTract; // Facility Census Tract
            Latitude = model.Latitude; // Latitude
            LocationId = model.LocationId; // 
            Longitude = model.Longitude; // Longitude
            PostalCode = model.PostalCode; // Address Postal Code
            RefCountryId = model.RefCountryId; // 
            RefCountyId = model.RefCountyId; // 
            RefERSRuralUrbanContinuumCodeId = model.RefERSRuralUrbanContinuumCodeId; // Economic Research Service Rural-Urban Continuum Code
            RefStateId = model.RefStateId; // 
            StreetNumberAndName = model.StreetNumberAndName; // Address Street Number and Name
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefState List
        /// <summary>
        /// The complete Address Apartment Room or Suite Number List
        /// </summary>
        private static List<ReferenceModelBase> RefStateList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("3082afc0-9bf6-413d-9b27-56f0fb0e0e7a"), Code="AK", Description="Alaska", Definition="Alaska", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("636183df-090c-4749-a986-20cb7c025e6d"), Code="AL", Description="Alabama", Definition="Alabama", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("01e591b3-4690-4428-8386-ec280ae4fbc8"), Code="AR", Description="Arkansas", Definition="Arkansas", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("405931dd-8d52-4d3d-bb92-d7673a8711d4"), Code="AS", Description="American Samoa", Definition="American Samoa", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("f5fa1174-a508-4531-a6c7-31488cf333bd"), Code="AZ", Description="Arizona", Definition="Arizona", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("a15317cc-6901-46f7-b152-222eb0aeb9b1"), Code="CA", Description="California", Definition="California", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("319da4a5-8a04-4ec9-bb20-3a5c5192db30"), Code="CO", Description="Colorado", Definition="Colorado", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("1fe29ef3-371d-43ba-acd4-c29c4c832574"), Code="CT", Description="Connecticut", Definition="Connecticut", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("2692d4d4-9ad0-481f-a5c5-798e8c30566a"), Code="DC", Description="District of Columbia", Definition="District of Columbia", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("39479fd4-b9bd-48ed-a113-3ebdd38e3a10"), Code="DE", Description="Delaware", Definition="Delaware", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("ff6b8523-5f7f-48ea-9024-828f89c96cf3"), Code="FL", Description="Florida", Definition="Florida", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("6bcc893f-8771-401b-a001-f8f3c35f2229"), Code="FM", Description="Federated States of Micronesia", Definition="Federated States of Micronesia", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("ee767589-a7e7-434a-a877-50046a43a5b8"), Code="GA", Description="Georgia", Definition="Georgia", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("e7bc3695-ace3-4d36-b873-1c52fe119f45"), Code="GU", Description="Guam", Definition="Guam", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("67589f8d-bd60-4ea2-a934-70450e6a9b47"), Code="HI", Description="Hawaii", Definition="Hawaii", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("a0fcaa26-aa12-4c01-95d6-59697a75581e"), Code="IA", Description="Iowa", Definition="Iowa", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("e5c4fcf6-321a-4c14-a09d-265eda3cc90a"), Code="ID", Description="Idaho", Definition="Idaho", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("958b1038-8877-4a66-887d-39e2a330279a"), Code="IL", Description="Illinois", Definition="Illinois", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("a380dafc-8046-4d11-94fb-7e803d885489"), Code="IN", Description="Indiana", Definition="Indiana", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("10c7f1f1-e052-4e19-917b-c919ab48c96f"), Code="KS", Description="Kansas", Definition="Kansas", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("e6be32c2-1902-4d71-8e70-bd07958dba97"), Code="KY", Description="Kentucky", Definition="Kentucky", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("f2a5dbd0-9d75-4e09-b765-e0dae508df16"), Code="LA", Description="Louisiana", Definition="Louisiana", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("cdca4c9a-4da0-42ec-b5a9-48dc09be42f5"), Code="MA", Description="Massachusetts", Definition="Massachusetts", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("7d02b7a8-ed30-477a-9b64-2ea403263232"), Code="MD", Description="Maryland", Definition="Maryland", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("fd25aa2b-4644-4d12-aa42-055d112756a0"), Code="ME", Description="Maine", Definition="Maine", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("d01314b0-a980-47d2-92fc-5f7596c88233"), Code="MH", Description="Marshall Islands", Definition="Marshall Islands", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("fc60576c-ceb8-45af-b3e0-98cdc81bf884"), Code="MI", Description="Michigan", Definition="Michigan", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("0cf042be-b146-407a-a8dd-445cf29d154f"), Code="MN", Description="Minnesota", Definition="Minnesota", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("1a6eaf00-b3db-4d92-954c-9d8f9ac7db4d"), Code="MO", Description="Missouri", Definition="Missouri", SortOrder=Convert.ToDecimal("29.00") },
            new ReferenceModelBase { Id=Guid.Parse("02cfd7e7-bd18-48fd-bbab-d1acc1ae25bf"), Code="MP", Description="Northern Marianas", Definition="Northern Marianas", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("2203a07a-5565-483f-bfa1-b6fb9a8e090e"), Code="MS", Description="Mississippi", Definition="Mississippi", SortOrder=Convert.ToDecimal("31.00") },
            new ReferenceModelBase { Id=Guid.Parse("137ad5c8-4b55-412e-b17d-1df84a7dc38d"), Code="MT", Description="Montana", Definition="Montana", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("525e2ca1-1715-40ab-a212-5f833c5ebb5a"), Code="NC", Description="North Carolina", Definition="North Carolina", SortOrder=Convert.ToDecimal("33.00") },
            new ReferenceModelBase { Id=Guid.Parse("2d133f30-11b3-47c5-ba45-02bcddf3f0e0"), Code="ND", Description="North Dakota", Definition="North Dakota", SortOrder=Convert.ToDecimal("34.00") },
            new ReferenceModelBase { Id=Guid.Parse("d8bfd828-1763-4142-bc70-74c79dc1b07a"), Code="NE", Description="Nebraska", Definition="Nebraska", SortOrder=Convert.ToDecimal("35.00") },
            new ReferenceModelBase { Id=Guid.Parse("34978935-1963-46c0-8550-c372a36fd632"), Code="NH", Description="New Hampshire", Definition="New Hampshire", SortOrder=Convert.ToDecimal("36.00") },
            new ReferenceModelBase { Id=Guid.Parse("b08753f1-2ce7-4d7b-afdd-1958e1c3396c"), Code="NJ", Description="New Jersey", Definition="New Jersey", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("f19b8fce-c2df-4faa-b536-43643242b1f0"), Code="NM", Description="New Mexico", Definition="New Mexico", SortOrder=Convert.ToDecimal("38.00") },
            new ReferenceModelBase { Id=Guid.Parse("f66fa456-a7ea-470f-bdbb-802c237b3420"), Code="NV", Description="Nevada", Definition="Nevada", SortOrder=Convert.ToDecimal("39.00") },
            new ReferenceModelBase { Id=Guid.Parse("00aa24ee-f65a-4499-91ea-8e73c7ad4abb"), Code="NY", Description="New York", Definition="New York", SortOrder=Convert.ToDecimal("40.00") },
            new ReferenceModelBase { Id=Guid.Parse("aefa6de8-f11f-41c3-b30f-4a586205d000"), Code="OH", Description="Ohio", Definition="Ohio", SortOrder=Convert.ToDecimal("41.00") },
            new ReferenceModelBase { Id=Guid.Parse("21b07b10-1adf-4107-b247-4e3410d6fcd0"), Code="OK", Description="Oklahoma", Definition="Oklahoma", SortOrder=Convert.ToDecimal("42.00") },
            new ReferenceModelBase { Id=Guid.Parse("26886c9e-b223-46d8-8629-489e8042f3f2"), Code="OR", Description="Oregon", Definition="Oregon", SortOrder=Convert.ToDecimal("43.00") },
            new ReferenceModelBase { Id=Guid.Parse("afabac44-26b6-4189-94ac-ffd13c65cd29"), Code="PA", Description="Pennsylvania", Definition="Pennsylvania", SortOrder=Convert.ToDecimal("44.00") },
            new ReferenceModelBase { Id=Guid.Parse("1fb73621-af66-4943-9ea0-6203f897da8c"), Code="PR", Description="Puerto Rico", Definition="Puerto Rico", SortOrder=Convert.ToDecimal("45.00") },
            new ReferenceModelBase { Id=Guid.Parse("1a27c082-dc7a-40a6-b3a1-ded74a798155"), Code="PW", Description="Palau", Definition="Palau", SortOrder=Convert.ToDecimal("46.00") },
            new ReferenceModelBase { Id=Guid.Parse("95762cd9-1e31-4908-871d-0074e861fe9f"), Code="RI", Description="Rhode Island", Definition="Rhode Island", SortOrder=Convert.ToDecimal("47.00") },
            new ReferenceModelBase { Id=Guid.Parse("f5990f9c-0837-4c8a-9ffb-cc923dee0960"), Code="SC", Description="South Carolina", Definition="South Carolina", SortOrder=Convert.ToDecimal("48.00") },
            new ReferenceModelBase { Id=Guid.Parse("6d7e50e3-572a-4721-8714-b95a4bf41a81"), Code="SD", Description="South Dakota", Definition="South Dakota", SortOrder=Convert.ToDecimal("49.00") },
            new ReferenceModelBase { Id=Guid.Parse("a1685660-ad23-4b41-a9d9-d372e6a576e6"), Code="TN", Description="Tennessee", Definition="Tennessee", SortOrder=Convert.ToDecimal("50.00") },
            new ReferenceModelBase { Id=Guid.Parse("17423532-02c7-4519-af73-58535f35eb9b"), Code="TX", Description="Texas", Definition="Texas", SortOrder=Convert.ToDecimal("51.00") },
            new ReferenceModelBase { Id=Guid.Parse("42f7d7d3-b801-40a2-9d6c-aace322bf261"), Code="UT", Description="Utah", Definition="Utah", SortOrder=Convert.ToDecimal("52.00") },
            new ReferenceModelBase { Id=Guid.Parse("31e7c68f-549a-43dd-b2b3-53487a53af88"), Code="VA", Description="Virginia", Definition="Virginia", SortOrder=Convert.ToDecimal("53.00") },
            new ReferenceModelBase { Id=Guid.Parse("a5b1bf20-2ff5-4bb2-afb9-7773d1af79a6"), Code="VI", Description="Virgin Islands", Definition="Virgin Islands", SortOrder=Convert.ToDecimal("54.00") },
            new ReferenceModelBase { Id=Guid.Parse("847f4740-b84d-4f5b-a7ef-f144e062f3ac"), Code="VT", Description="Vermont", Definition="Vermont", SortOrder=Convert.ToDecimal("55.00") },
            new ReferenceModelBase { Id=Guid.Parse("fde7c9ee-cb80-4be5-b52f-c5702b6ef1c4"), Code="WA", Description="Washington", Definition="Washington", SortOrder=Convert.ToDecimal("56.00") },
            new ReferenceModelBase { Id=Guid.Parse("9c3d40bd-f1d9-4049-bb79-09ba6b0aabc9"), Code="WI", Description="Wisconsin", Definition="Wisconsin", SortOrder=Convert.ToDecimal("57.00") },
            new ReferenceModelBase { Id=Guid.Parse("e079c1e8-bcbd-472b-bf1c-78c07302e3a1"), Code="WV", Description="West Virginia", Definition="West Virginia", SortOrder=Convert.ToDecimal("58.00") },
            new ReferenceModelBase { Id=Guid.Parse("cafcad54-e6c8-4ca5-bfa7-e7c1342d2d3c"), Code="WY", Description="Wyoming", Definition="Wyoming", SortOrder=Convert.ToDecimal("59.00") },
            new ReferenceModelBase { Id=Guid.Parse("ad77f2a3-bbb5-405a-ba2c-d07bbd4485d4"), Code="AA", Description="Armed Forces America", Definition="Armed Forces America", SortOrder=Convert.ToDecimal("90.00") },
            new ReferenceModelBase { Id=Guid.Parse("30592d03-fe14-490c-a78b-b835e7d2a791"), Code="AE", Description="Armed Forces Africa, Canada, Europe, and Mideast", Definition="Armed Forces Africa, Canada, Europe, and Mideast", SortOrder=Convert.ToDecimal("91.00") },
            new ReferenceModelBase { Id=Guid.Parse("a1441c7b-c560-4ca1-b7b7-e9d140eb33cc"), Code="AP", Description="Armed Forces Pacific", Definition="Armed Forces Pacific", SortOrder=Convert.ToDecimal("92.00") },
        };
        #endregion
    }
}
