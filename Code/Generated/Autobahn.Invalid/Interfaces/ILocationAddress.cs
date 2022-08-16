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
        /// 
        /// </summary>
        Guid? ApartmentRoomOrSuiteNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingSiteNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         City { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CountyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DoNotPublishIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityBlockNumberArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityCensusTract { get; set; }

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
         RefERSRuralUrbanContinuumCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StreetNumberAndName { get; set; }

    }
}
