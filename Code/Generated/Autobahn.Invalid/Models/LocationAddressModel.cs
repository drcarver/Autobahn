//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   LocationAddressModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The LocationAddress Model
     /// </summary>
    public partial class LocationAddressModel : AutobahnBase, Interfaces.ILocationAddress
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? ApartmentRoomOrSuiteNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingSiteNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CountyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DoNotPublishIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityBlockNumberArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityCensusTract { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Latitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Longitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefERSRuralUrbanContinuumCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StreetNumberAndName { get; set; }

    }
}
