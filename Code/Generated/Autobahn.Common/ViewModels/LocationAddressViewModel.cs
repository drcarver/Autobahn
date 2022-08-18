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
            new ReferenceModelBase { Id=Guid.Parse("a98ac995-6bf9-44d6-98ab-35d6e5941c80"), Code="AK", Description="Alaska", Definition="Alaska", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("2fb479b5-6bce-47b3-9ca9-a47b317ea236"), Code="AL", Description="Alabama", Definition="Alabama", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("33d070fa-c968-4bd0-8e72-908d8bdddd93"), Code="AR", Description="Arkansas", Definition="Arkansas", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("8a813562-7579-464d-8138-8a89238c84b5"), Code="AS", Description="American Samoa", Definition="American Samoa", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("dcc689b2-dec8-49d8-a216-ea6fc3cea71b"), Code="AZ", Description="Arizona", Definition="Arizona", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("a10434a3-e9f1-49ef-81c1-ab3b2396e1d8"), Code="CA", Description="California", Definition="California", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("419386f3-14e5-4fab-8cff-e8dba77fd771"), Code="CO", Description="Colorado", Definition="Colorado", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("02f5843d-c7ab-439e-afd5-94e891446fa2"), Code="CT", Description="Connecticut", Definition="Connecticut", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("2e4d1e7e-63d3-4c06-915d-d7ec856d5ee8"), Code="DC", Description="District of Columbia", Definition="District of Columbia", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("99cf350a-994e-406c-8150-d69dba2eab2d"), Code="DE", Description="Delaware", Definition="Delaware", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("b858e18f-c4ed-477c-8adc-b0497af66f44"), Code="FL", Description="Florida", Definition="Florida", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("93ac4ce0-9102-47e7-a0d5-76b40c5b7101"), Code="FM", Description="Federated States of Micronesia", Definition="Federated States of Micronesia", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("75ef3cf9-c6e6-4c21-9eb7-c6350cee50fa"), Code="GA", Description="Georgia", Definition="Georgia", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("2a0e97ea-8e45-47e0-9fde-009c3bc0ee7f"), Code="GU", Description="Guam", Definition="Guam", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("d5dd4bd4-64f0-4fa5-9e3a-dacad2b13ab7"), Code="HI", Description="Hawaii", Definition="Hawaii", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("fb1e9e91-1d01-43c6-b59a-5f9a36c7d8e7"), Code="IA", Description="Iowa", Definition="Iowa", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("f64ade2c-9824-4bee-8ad0-1673a871684f"), Code="ID", Description="Idaho", Definition="Idaho", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("cab7866f-b8fb-4b98-a92d-641d1804c1ac"), Code="IL", Description="Illinois", Definition="Illinois", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("1540c0d0-eaa6-4541-9481-a789d0db15c6"), Code="IN", Description="Indiana", Definition="Indiana", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("5a4f5e58-bb15-4a48-b45d-011fe2aa9240"), Code="KS", Description="Kansas", Definition="Kansas", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("4d20f87b-1e0a-4416-bbfd-277c66fdfb15"), Code="KY", Description="Kentucky", Definition="Kentucky", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("034abffa-ce05-46bf-9a3c-2a49aa16e345"), Code="LA", Description="Louisiana", Definition="Louisiana", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("4d3ed90d-7fe0-477e-972f-216b02e626d6"), Code="MA", Description="Massachusetts", Definition="Massachusetts", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("de00a83f-ee96-4479-8c9f-3c9e93242a4a"), Code="MD", Description="Maryland", Definition="Maryland", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("8b030a8b-8e1b-4b78-99ed-e2a7f8d70746"), Code="ME", Description="Maine", Definition="Maine", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("792a4232-9992-42c8-b91f-7276ee9f214f"), Code="MH", Description="Marshall Islands", Definition="Marshall Islands", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("501a016c-71f6-442b-9be6-863222a5fb7a"), Code="MI", Description="Michigan", Definition="Michigan", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("a7b6c2ef-9be4-41f7-827d-fa590b370699"), Code="MN", Description="Minnesota", Definition="Minnesota", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("c0067161-cfb6-4eb8-ad9f-61814feec5cf"), Code="MO", Description="Missouri", Definition="Missouri", SortOrder=Convert.ToDecimal("29.00") },
            new ReferenceModelBase { Id=Guid.Parse("89de3f7c-0584-4dfd-a322-59d11243c03a"), Code="MP", Description="Northern Marianas", Definition="Northern Marianas", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("c1dcb82c-da8a-4130-bdfa-2da42485f7d3"), Code="MS", Description="Mississippi", Definition="Mississippi", SortOrder=Convert.ToDecimal("31.00") },
            new ReferenceModelBase { Id=Guid.Parse("9df2cc29-d21c-4311-8fe3-79a6c3f471ad"), Code="MT", Description="Montana", Definition="Montana", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("8252a643-3c08-445c-9318-faf1260ffb41"), Code="NC", Description="North Carolina", Definition="North Carolina", SortOrder=Convert.ToDecimal("33.00") },
            new ReferenceModelBase { Id=Guid.Parse("4414d45f-c562-4a9a-b179-4e3b92940500"), Code="ND", Description="North Dakota", Definition="North Dakota", SortOrder=Convert.ToDecimal("34.00") },
            new ReferenceModelBase { Id=Guid.Parse("94da4fc5-5935-4e90-9e97-267e938f0081"), Code="NE", Description="Nebraska", Definition="Nebraska", SortOrder=Convert.ToDecimal("35.00") },
            new ReferenceModelBase { Id=Guid.Parse("54f45ef4-12cc-4f60-91eb-bf4bdb82f4c9"), Code="NH", Description="New Hampshire", Definition="New Hampshire", SortOrder=Convert.ToDecimal("36.00") },
            new ReferenceModelBase { Id=Guid.Parse("ba939391-b740-4c85-8598-651a78e6c887"), Code="NJ", Description="New Jersey", Definition="New Jersey", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("79325ac3-c109-4415-9c99-a44bc1b8c438"), Code="NM", Description="New Mexico", Definition="New Mexico", SortOrder=Convert.ToDecimal("38.00") },
            new ReferenceModelBase { Id=Guid.Parse("bedea58c-12c6-4e53-944c-3043741a50fa"), Code="NV", Description="Nevada", Definition="Nevada", SortOrder=Convert.ToDecimal("39.00") },
            new ReferenceModelBase { Id=Guid.Parse("dfe89b29-69ac-4037-aff8-8e6c7ce0fa60"), Code="NY", Description="New York", Definition="New York", SortOrder=Convert.ToDecimal("40.00") },
            new ReferenceModelBase { Id=Guid.Parse("b3c14bdb-ee2a-4ff3-82ff-e444ec5a7df8"), Code="OH", Description="Ohio", Definition="Ohio", SortOrder=Convert.ToDecimal("41.00") },
            new ReferenceModelBase { Id=Guid.Parse("e83f4cf2-a41a-4093-8589-8c15166002cf"), Code="OK", Description="Oklahoma", Definition="Oklahoma", SortOrder=Convert.ToDecimal("42.00") },
            new ReferenceModelBase { Id=Guid.Parse("688caabe-dea0-4978-a388-1b8848c4545e"), Code="OR", Description="Oregon", Definition="Oregon", SortOrder=Convert.ToDecimal("43.00") },
            new ReferenceModelBase { Id=Guid.Parse("7b896384-0cd7-4646-87a3-53b67b37b7d9"), Code="PA", Description="Pennsylvania", Definition="Pennsylvania", SortOrder=Convert.ToDecimal("44.00") },
            new ReferenceModelBase { Id=Guid.Parse("6cf2322d-1055-4412-bde8-42594aa02476"), Code="PR", Description="Puerto Rico", Definition="Puerto Rico", SortOrder=Convert.ToDecimal("45.00") },
            new ReferenceModelBase { Id=Guid.Parse("11858b8d-ccf2-4e42-8f70-84312848229f"), Code="PW", Description="Palau", Definition="Palau", SortOrder=Convert.ToDecimal("46.00") },
            new ReferenceModelBase { Id=Guid.Parse("4e9e853c-2173-431b-ae59-a51b3ff4f7ea"), Code="RI", Description="Rhode Island", Definition="Rhode Island", SortOrder=Convert.ToDecimal("47.00") },
            new ReferenceModelBase { Id=Guid.Parse("19646237-f969-445c-86b5-948b11e1973e"), Code="SC", Description="South Carolina", Definition="South Carolina", SortOrder=Convert.ToDecimal("48.00") },
            new ReferenceModelBase { Id=Guid.Parse("fc1a1708-40b1-4503-af2f-a2663a221bbd"), Code="SD", Description="South Dakota", Definition="South Dakota", SortOrder=Convert.ToDecimal("49.00") },
            new ReferenceModelBase { Id=Guid.Parse("206b797c-b030-49b0-98fc-e3027f1d0579"), Code="TN", Description="Tennessee", Definition="Tennessee", SortOrder=Convert.ToDecimal("50.00") },
            new ReferenceModelBase { Id=Guid.Parse("83f6c14a-06cd-4652-9b6d-8a10faec051b"), Code="TX", Description="Texas", Definition="Texas", SortOrder=Convert.ToDecimal("51.00") },
            new ReferenceModelBase { Id=Guid.Parse("82745c54-6263-4c20-9660-c867a228872d"), Code="UT", Description="Utah", Definition="Utah", SortOrder=Convert.ToDecimal("52.00") },
            new ReferenceModelBase { Id=Guid.Parse("0387d322-ffa3-4cf2-b339-7e88b248fa45"), Code="VA", Description="Virginia", Definition="Virginia", SortOrder=Convert.ToDecimal("53.00") },
            new ReferenceModelBase { Id=Guid.Parse("36b851e7-fc56-47a5-954c-5be8014e0571"), Code="VI", Description="Virgin Islands", Definition="Virgin Islands", SortOrder=Convert.ToDecimal("54.00") },
            new ReferenceModelBase { Id=Guid.Parse("a9696f10-2b8a-4bcf-a4cd-b5e9ec645ee1"), Code="VT", Description="Vermont", Definition="Vermont", SortOrder=Convert.ToDecimal("55.00") },
            new ReferenceModelBase { Id=Guid.Parse("54b089f5-6fef-46c8-9fe9-c70ba77501a7"), Code="WA", Description="Washington", Definition="Washington", SortOrder=Convert.ToDecimal("56.00") },
            new ReferenceModelBase { Id=Guid.Parse("8fc2a3c6-71ae-4919-87a1-b98ff9618eed"), Code="WI", Description="Wisconsin", Definition="Wisconsin", SortOrder=Convert.ToDecimal("57.00") },
            new ReferenceModelBase { Id=Guid.Parse("c701f46d-0df2-4c0e-a7c9-8d3758e6213c"), Code="WV", Description="West Virginia", Definition="West Virginia", SortOrder=Convert.ToDecimal("58.00") },
            new ReferenceModelBase { Id=Guid.Parse("5c34cece-43f1-4db8-b453-4af8644238d0"), Code="WY", Description="Wyoming", Definition="Wyoming", SortOrder=Convert.ToDecimal("59.00") },
            new ReferenceModelBase { Id=Guid.Parse("1716e3f5-dc6b-4958-a34a-c3af99972933"), Code="AA", Description="Armed Forces America", Definition="Armed Forces America", SortOrder=Convert.ToDecimal("90.00") },
            new ReferenceModelBase { Id=Guid.Parse("35a8abb7-f971-42bb-b979-6078436524e3"), Code="AE", Description="Armed Forces Africa, Canada, Europe, and Mideast", Definition="Armed Forces Africa, Canada, Europe, and Mideast", SortOrder=Convert.ToDecimal("91.00") },
            new ReferenceModelBase { Id=Guid.Parse("55a85538-2765-4474-bdb1-ed07b7799953"), Code="AP", Description="Armed Forces Pacific", Definition="Armed Forces Pacific", SortOrder=Convert.ToDecimal("92.00") },
        };
        #endregion
    }
}
