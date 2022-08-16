//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIncident.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIncident Interface
     /// </summary>
    public partial interface IIncident : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         IncidentCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IncidentDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IncidentDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? IncidentIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IncidentReporterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IncidentTime { get; set; }

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
         RefFirearmTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIncidentBehaviorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIncidentBehaviorSecondaryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIncidentInjuryTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIncidentLocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIncidentMultipleOffenseTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIncidentPerpetratorInjuryTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIncidentReporterTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIncidentTimeDescriptionCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefWeaponTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RegulationViolatedDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RelatedToDisabilityManifestationInd { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ReportedToLawEnforcementInd { get; set; }

    }
}
