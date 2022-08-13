//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAddress Model
     /// </summary>
    public partial class PersonAddressModel : AutobahnBase, Interfaces.IPersonAddress
    {
        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String AddressCountyName { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String ApartmentRoomOrSuiteNumber { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String City { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String Latitude { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public System.String Longitude { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public Guid PersonId { get; set; }

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
        public Guid? RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        public Guid RefPersonLocationTypeId { get; set; }

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
