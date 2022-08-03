//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   LocationAddress.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The LocationAddress
     /// </summary>
    public partial class LocationAddress : ILocationAddress
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Location"/> model
        /// </summary>
        public Guid LocationId { get; set; }

        /// <summary>
        /// Defines the LocationAddress.StreetNumberAndName non nullable property
        /// </summary>
        public System.String StreetNumberAndName { get; set; }

        /// <summary>
        /// Defines the LocationAddress.ApartmentRoomOrSuiteNumber non nullable property
        /// </summary>
        public System.String ApartmentRoomOrSuiteNumber { get; set; }

        /// <summary>
        /// Defines the LocationAddress.BuildingSiteNumber non nullable property
        /// </summary>
        public System.String BuildingSiteNumber { get; set; }

        /// <summary>
        /// Defines the LocationAddress.City non nullable property
        /// </summary>
        public System.String City { get; set; }

        /// <summary>
        /// Defines the LocationAddress.PostalCode non nullable property
        /// </summary>
        public System.String PostalCode { get; set; }

        /// <summary>
        /// Defines the LocationAddress.CountyName non nullable property
        /// </summary>
        public System.String CountyName { get; set; }

        /// <summary>
        /// Defines the LocationAddress.Latitude non nullable property
        /// </summary>
        public System.String Latitude { get; set; }

        /// <summary>
        /// Defines the LocationAddress.Longitude non nullable property
        /// </summary>
        public System.String Longitude { get; set; }

        /// <summary>
        /// Defines the LocationAddress.FacilityBlockNumberArea non nullable property
        /// </summary>
        public System.String FacilityBlockNumberArea { get; set; }

        /// <summary>
        /// Defines the LocationAddress.FacilityCensusTract non nullable property
        /// </summary>
        public System.String FacilityCensusTract { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefState"/> model
        /// </summary>
        public Guid? RefStateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCounty"/> model
        /// </summary>
        public Guid? RefCountyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountry"/> model
        /// </summary>
        public Guid? RefCountryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefERSRuralUrbanContinuumCode"/> model
        /// </summary>
        public Guid? RefERSRuralUrbanContinuumCodeId { get; set; }

        /// <summary>
        /// Defines the LocationAddress.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the LocationAddress.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the LocationAddress.DoNotPublishIndicator nullable property
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
