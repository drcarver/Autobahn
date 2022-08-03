//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ILocationAddress.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ILocationAddress
     /// </summary>
    public partial interface ILocationAddress
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Location"/> model
        /// </summary>
        Guid LocationId { get; set; }

        /// <summary>
        /// Defines the LocationAddress.StreetNumberAndName non nullable property
        /// </summary>
        System.String StreetNumberAndName { get; set; }

        /// <summary>
        /// Defines the LocationAddress.ApartmentRoomOrSuiteNumber non nullable property
        /// </summary>
        System.String ApartmentRoomOrSuiteNumber { get; set; }

        /// <summary>
        /// Defines the LocationAddress.BuildingSiteNumber non nullable property
        /// </summary>
        System.String BuildingSiteNumber { get; set; }

        /// <summary>
        /// Defines the LocationAddress.City non nullable property
        /// </summary>
        System.String City { get; set; }

        /// <summary>
        /// Defines the LocationAddress.PostalCode non nullable property
        /// </summary>
        System.String PostalCode { get; set; }

        /// <summary>
        /// Defines the LocationAddress.CountyName non nullable property
        /// </summary>
        System.String CountyName { get; set; }

        /// <summary>
        /// Defines the LocationAddress.Latitude non nullable property
        /// </summary>
        System.String Latitude { get; set; }

        /// <summary>
        /// Defines the LocationAddress.Longitude non nullable property
        /// </summary>
        System.String Longitude { get; set; }

        /// <summary>
        /// Defines the LocationAddress.FacilityBlockNumberArea non nullable property
        /// </summary>
        System.String FacilityBlockNumberArea { get; set; }

        /// <summary>
        /// Defines the LocationAddress.FacilityCensusTract non nullable property
        /// </summary>
        System.String FacilityCensusTract { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefState"/> model
        /// </summary>
        Guid? RefStateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCounty"/> model
        /// </summary>
        Guid? RefCountyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountry"/> model
        /// </summary>
        Guid? RefCountryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefERSRuralUrbanContinuumCode"/> model
        /// </summary>
        Guid? RefERSRuralUrbanContinuumCodeId { get; set; }

        /// <summary>
        /// Defines the LocationAddress.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the LocationAddress.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the LocationAddress.DoNotPublishIndicator nullable property
        /// </summary>
        System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
