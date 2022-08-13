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
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        Guid? BuildingSystemComponentId { get; set; }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        System.DateTime? ComponentOrFixtureCheckDate { get; set; }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        System.DateTime? FacilityComplianceDeterminationDate { get; set; }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        System.String FacilityComplianceName { get; set; }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        System.String FacilityComponentDeficiencyDescription { get; set; }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        System.Decimal? FacilityEstimatedCostToEliminateDeferredMaint { get; set; }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        System.String FacilityInspectionScoreResultDescription { get; set; }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        System.String FacilityInspectionViolationDescription { get; set; }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        Guid? FacilityMandateId { get; set; }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        Guid? RefFacilityComplianceStatusId { get; set; }

        /// <summary>
        /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
        /// </summary>
        Guid? RefFacilityMaintStandardTypeId { get; set; }

    }
}
