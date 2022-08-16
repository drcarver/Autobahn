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
        /// 
        /// </summary>
         AddressCountyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? ApartmentRoomOrSuiteNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         City { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DoNotPublishIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Latitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Longitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCountryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPersonLocationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefStateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StreetNumberAndName { get; set; }

    }
}
