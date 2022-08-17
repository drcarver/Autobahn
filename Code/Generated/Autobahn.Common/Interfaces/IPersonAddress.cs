//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonAddress.cs
//* Name:       Address County Name
//* Definition: 
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IPersonAddress : IAutobahnBase
    {
        /// <summary>
        /// Address County Name
        /// <para>
        /// The name of the county, parish, borough, or comparable unit (within a state) in which an address is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19190">Address County Name</a>
        /// </para>
        /// </summary>
        System.String AddressCountyName { get; set; }

        /// <summary>
        /// Address Apartment Room or Suite Number
        /// <para>
        /// The apartment, room, or suite number of an address.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19019">Address Apartment Room or Suite Number</a>
        /// </para>
        /// </summary>
        System.String ApartmentRoomOrSuiteNumber { get; set; }

        /// <summary>
        /// Address City
        /// <para>
        /// The name of the city in which an address is located.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19040">Address City</a>
        /// </para>
        /// </summary>
        System.String City { get; set; }

        /// <summary>
        /// Do Not Publish Indicator
        /// <para>
        /// An indication that the record should not be published.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// Latitude
        /// <para>
        /// The north or south angular distance from the equator that, when combined with longitude, reflects an estimation of where the address is physically situated.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19599">Latitude</a>
        /// </para>
        /// </summary>
        System.String Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// <para>
        /// The east or west angular distance from the prime meridian that, when combined with latitude, reflects an estimation of where the address is physically situated.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19600">Longitude</a>
        /// </para>
        /// </summary>
        System.String Longitude { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Address Postal Code
        /// <para>
        /// A number that identifies each postal delivery area in the United States used as a portion of an address.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19214">Address Postal Code</a>
        /// </para>
        /// </summary>
        System.String PostalCode { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCountry"/> model
        /// </summary>
        Guid? RefCountryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCounty"/> model
        /// </summary>
        Guid? RefCountyId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPersonalInformationVerification"/> model
        /// </summary>
        Guid? RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPersonLocationType"/> model
        /// </summary>
        Guid RefPersonLocationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefState"/> model
        /// </summary>
        Guid? RefStateId { get; set; }

        /// <summary>
        /// Address Street Number and Name
        /// <para>
        /// The street number and street name or post office box number of an address.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19269">Address Street Number and Name</a>
        /// </para>
        /// </summary>
        System.String StreetNumberAndName { get; set; }

    }
}
