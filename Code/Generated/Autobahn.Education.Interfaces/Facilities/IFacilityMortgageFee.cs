//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityMortgageFee.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Facilities
{
     /// <summary>
     /// The IFacilityMortgageFee Interface
     /// </summary>
    public partial interface IFacilityMortgageFee : IAutobahnBase
    {
        #region IFacilityMortgageFee
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityMortgage"/> model
        /// </summary>
        Guid FacilityMortgageId { get; set; }

        /// <summary>
        /// Facility Financing Fee Type
        /// <para>
        /// The type of fee that one must pay when getting a mortgage.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20867">Facility Financing Fee Type</a>
        /// </para>
        /// </summary>
        Guid RefFacilityFinancingFeeTypeId { get; set; }

        #endregion
    }
}
