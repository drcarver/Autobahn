//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonAddress.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonAddress Interface
     /// </summary>
    public partial interface IPersonAddress : IAutobahnBase
    {
        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String AddressCountyName { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String ApartmentRoomOrSuiteNumber { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String City { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String Latitude { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        System.String Longitude { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        Guid PersonId { get; set; }

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
        Guid? RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        Guid RefPersonLocationTypeId { get; set; }

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
