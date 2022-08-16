//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityComplianceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityCompliance Model
     /// </summary>
    public partial class FacilityComplianceModel : AutobahnBase, Interfaces.IFacilityCompliance
    {
        /// <summary>
        /// 
        /// </summary>
        public  ComponentOrFixtureCheckDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityComplianceDeterminationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityComplianceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityComponentDeficiencyDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityEstimatedCostToEliminateDeferredMaint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityInspectionScoreResultDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilityInspectionViolationDescription { get; set; }

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
        public Guid? RefFacilityComplianceStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilityMaintStandardTypeId { get; set; }

    }
}
