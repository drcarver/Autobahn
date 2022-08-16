//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IncidentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The Incident Model
     /// </summary>
    public partial class IncidentModel : AutobahnBase, Interfaces.IIncident
    {
        /// <summary>
        /// 
        /// </summary>
        public  IncidentCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IncidentDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IncidentDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? IncidentIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IncidentReporterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IncidentTime { get; set; }

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
        public  RefFirearmTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIncidentBehaviorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIncidentBehaviorSecondaryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIncidentInjuryTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIncidentLocationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIncidentMultipleOffenseTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIncidentPerpetratorInjuryTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIncidentReporterTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIncidentTimeDescriptionCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefWeaponTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RegulationViolatedDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RelatedToDisabilityManifestationInd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ReportedToLawEnforcementInd { get; set; }

    }
}
