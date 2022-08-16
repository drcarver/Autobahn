//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacility.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacility Interface
     /// </summary>
    public partial interface IFacility : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         BuildingArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingNumberOfStories { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingSiteNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingYearBuilt { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BuildingYearOfLastModernization { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityAcquisitionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityBuildingPermanency { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityExpectedLife { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityOwnershipIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? Identifier { get; set; }

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
         RefBuildingHistoricStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingPrimaryUseTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBuildingUseTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCampusStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCampusTypeId { get; set; }

    }
}
