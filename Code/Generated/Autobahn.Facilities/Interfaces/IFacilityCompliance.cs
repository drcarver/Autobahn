//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityCompliance.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityCompliance Interface
     /// </summary>
    public partial interface IFacilityCompliance : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ComponentOrFixtureCheckDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityComplianceDeterminationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityComplianceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityComponentDeficiencyDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityEstimatedCostToEliminateDeferredMaint { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityInspectionScoreResultDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FacilityInspectionViolationDescription { get; set; }

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
        Guid? RefFacilityComplianceStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefFacilityMaintStandardTypeId { get; set; }

    }
}
