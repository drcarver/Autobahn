//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityHazard.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityHazard Interface
     /// </summary>
    public partial interface IFacilityHazard : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         FacilityHazardousCondExpectedRemediationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? FacilityLocationOfHazardousMaterials { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityNearbyEnvHazardDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HazardousMaterialOrConditionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HazardousMaterialOrConditionTestingDate { get; set; }

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
         RefFacilityHazardousMaterialsOrCondTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityNaturallyOccurringHazardTypeId { get; set; }

    }
}
