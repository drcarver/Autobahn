//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonAddress.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAddress
     /// </summary>
    public partial class PersonAddress : AutobahnBase, Interfaces.IPersonAddress
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonLocationType"/> model
        /// </summary>
        public Guid RefPersonLocationTypeId { get; set; }

        /// <summary>
        /// Defines the PersonAddress.StreetNumberAndName non nullable property
        /// </summary>
        public System.String StreetNumberAndName { get; set; }

        /// <summary>
        /// Defines the PersonAddress.ApartmentRoomOrSuiteNumber non nullable property
        /// </summary>
        public System.String ApartmentRoomOrSuiteNumber { get; set; }

        /// <summary>
        /// Defines the PersonAddress.City non nullable property
        /// </summary>
        public System.String City { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefState"/> model
        /// </summary>
        public Guid? RefStateId { get; set; }

        /// <summary>
        /// Defines the PersonAddress.PostalCode non nullable property
        /// </summary>
        public System.String PostalCode { get; set; }

        /// <summary>
        /// Defines the PersonAddress.AddressCountyName non nullable property
        /// </summary>
        public System.String AddressCountyName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCounty"/> model
        /// </summary>
        public Guid? RefCountyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountry"/> model
        /// </summary>
        public Guid? RefCountryId { get; set; }

        /// <summary>
        /// Defines the PersonAddress.Latitude non nullable property
        /// </summary>
        public System.String Latitude { get; set; }

        /// <summary>
        /// Defines the PersonAddress.Longitude non nullable property
        /// </summary>
        public System.String Longitude { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// Defines the PersonAddress.DoNotPublishIndicator nullable property
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
