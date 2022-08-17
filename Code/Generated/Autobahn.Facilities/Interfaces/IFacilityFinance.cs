//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityFinance.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilityFinance Interface
     /// </summary>
    public partial interface IFacilityFinance : IAutobahnBase
    {
        /// <summary>
        /// Building Area
        /// <para>
        /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20745">Building Area</a>
        /// </para>
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
        System.Decimal? FacilityReplacementValue { get; set; }

        /// <summary>
        /// Indebtedness Amount Allowed
        /// <para>
        /// The amount of indebtedness allowed by law to be carried by the school district.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20874">Indebtedness Amount Allowed</a>
        /// </para>
        /// </summary>
        System.Decimal? IndebtednessAmountAllowed { get; set; }

        /// <summary>
        /// Insurance Deductible
        /// <para>
        /// The dollar amount a school district must pay before its insurance will compensate it for loss.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20875">Insurance Deductible</a>
        /// </para>
        /// </summary>
        System.Decimal? InsuranceDeductible { get; set; }

        /// <summary>
        /// Public Education Mill Rate
        /// <para>
        /// The millage rate used to calculate property tax revenue for K-12 public education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20876">Public Education Mill Rate</a>
        /// </para>
        /// </summary>
        System.Decimal? PublicEducationMillRate { get; set; }

    }
}
