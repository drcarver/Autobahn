//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityFinance.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Facilities
{
     /// <summary>
     /// The IFacilityFinance Interface
     /// </summary>
    public partial interface IFacilityFinance : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Facility Replacement Value
        /// <para>
        /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20765">Facility Replacement Value</a>
        /// </para>
        /// </summary>
        Decimal? FacilityReplacementValue { get; set; }

        /// <summary>
        /// Indebtedness Amount Allowed
        /// <para>
        /// The amount of indebtedness allowed by law to be carried by the school district.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20874">Indebtedness Amount Allowed</a>
        /// </para>
        /// </summary>
        Decimal? IndebtednessAmountAllowed { get; set; }

        /// <summary>
        /// Insurance Deductible
        /// <para>
        /// The dollar amount a school district must pay before its insurance will compensate it for loss.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20875">Insurance Deductible</a>
        /// </para>
        /// </summary>
        Decimal? InsuranceDeductible { get; set; }

        /// <summary>
        /// Public Education Mill Rate
        /// <para>
        /// The millage rate used to calculate property tax revenue for K-12 public education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20876">Public Education Mill Rate</a>
        /// </para>
        /// </summary>
        Decimal? PublicEducationMillRate { get; set; }

    }
}
