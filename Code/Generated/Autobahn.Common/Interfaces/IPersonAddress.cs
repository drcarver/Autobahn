//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonAddress.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonAddress
     /// </summary>
    public partial interface IPersonAddress : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonLocationType"/> model
        /// </summary>
        Guid RefPersonLocationTypeId { get; set; }

        /// <summary>
        /// Defines the PersonAddress.StreetNumberAndName non nullable property
        /// </summary>
        System.String StreetNumberAndName { get; set; }

        /// <summary>
        /// Defines the PersonAddress.ApartmentRoomOrSuiteNumber non nullable property
        /// </summary>
        System.String ApartmentRoomOrSuiteNumber { get; set; }

        /// <summary>
        /// Defines the PersonAddress.City non nullable property
        /// </summary>
        System.String City { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefState"/> model
        /// </summary>
        Guid? RefStateId { get; set; }

        /// <summary>
        /// Defines the PersonAddress.PostalCode non nullable property
        /// </summary>
        System.String PostalCode { get; set; }

        /// <summary>
        /// Defines the PersonAddress.AddressCountyName non nullable property
        /// </summary>
        System.String AddressCountyName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCounty"/> model
        /// </summary>
        Guid? RefCountyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountry"/> model
        /// </summary>
        Guid? RefCountryId { get; set; }

        /// <summary>
        /// Defines the PersonAddress.Latitude non nullable property
        /// </summary>
        System.String Latitude { get; set; }

        /// <summary>
        /// Defines the PersonAddress.Longitude non nullable property
        /// </summary>
        System.String Longitude { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// </summary>
        Guid? RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// Defines the PersonAddress.DoNotPublishIndicator nullable property
        /// </summary>
        System.Boolean? DoNotPublishIndicator { get; set; }

    }
}
