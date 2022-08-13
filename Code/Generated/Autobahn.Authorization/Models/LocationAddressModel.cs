//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LocationAddressModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The LocationAddress Model
     /// </summary>
    public partial class LocationAddressModel : AutobahnBase, Interfaces.ILocationAddress
    {
        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String ApartmentRoomOrSuiteNumber { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String BuildingSiteNumber { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String City { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String CountyName { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String FacilityBlockNumberArea { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String FacilityCensusTract { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String Latitude { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public Guid LocationId { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String Longitude { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String PostalCode { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public Guid? RefCountryId { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public Guid? RefCountyId { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public Guid? RefERSRuralUrbanContinuumCodeId { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public Guid? RefStateId { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String StreetNumberAndName { get; set; }

    }
}
