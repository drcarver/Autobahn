//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityCompliance.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityCompliance
     /// </summary>
    public partial class FacilityCompliance : AutobahnBase, Interfaces.IFacilityCompliance
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMandate"/> model
        /// </summary>
        public Guid? FacilityMandateId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="BuildingSystemComponent"/> model
        /// </summary>
        public Guid? BuildingSystemComponentId { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.FacilityComplianceName non nullable property
        /// </summary>
        public System.String FacilityComplianceName { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.FacilityComplianceDeterminationDate nullable property
        /// </summary>
        public System.DateTime? FacilityComplianceDeterminationDate { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.ComponentOrFixtureCheckDate nullable property
        /// </summary>
        public System.DateTime? ComponentOrFixtureCheckDate { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.FacilityComponentDeficiencyDescription non nullable property
        /// </summary>
        public System.String FacilityComponentDeficiencyDescription { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.FacilityEstimatedCostToEliminateDeferredMaint nullable property
        /// </summary>
        public System.Decimal? FacilityEstimatedCostToEliminateDeferredMaint { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.FacilityInspectionScoreResultDescription non nullable property
        /// </summary>
        public System.String FacilityInspectionScoreResultDescription { get; set; }

        /// <summary>
        /// Defines the FacilityCompliance.FacilityInspectionViolationDescription non nullable property
        /// </summary>
        public System.String FacilityInspectionViolationDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityComplianceStatus"/> model
        /// </summary>
        public Guid? RefFacilityComplianceStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityMaintStandardType"/> model
        /// </summary>
        public Guid? RefFacilityMaintStandardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
