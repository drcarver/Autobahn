//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The Facility Model
     /// </summary>
    public partial class FacilityModel : AutobahnBase, Interfaces.IFacility
    {
        /// <summary>
        /// 
        /// </summary>
        public  BuildingArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingNumberOfStories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingSiteNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingYearBuilt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BuildingYearOfLastModernization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityAcquisitionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityBuildingPermanency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityExpectedLife { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityOwnershipIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? Identifier { get; set; }

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
        public  RefBuildingHistoricStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingPrimaryUseTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingUseTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCampusStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCampusTypeId { get; set; }

    }
}
