//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   ILocationAddress.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The ILocationAddress Interface
     /// </summary>
    public partial interface ILocationAddress : IAutobahnBase
    {
        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String ApartmentRoomOrSuiteNumber { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String BuildingSiteNumber { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String City { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String CountyName { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String FacilityBlockNumberArea { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String FacilityCensusTract { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String Latitude { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        Guid LocationId { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String Longitude { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String PostalCode { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        Guid? RefCountryId { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        Guid? RefCountyId { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        Guid? RefERSRuralUrbanContinuumCodeId { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        Guid? RefStateId { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String StreetNumberAndName { get; set; }

    }
}
