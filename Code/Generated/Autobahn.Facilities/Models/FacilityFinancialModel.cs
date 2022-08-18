//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinancialModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityFinancial Model
     /// </summary>
    public partial class FacilityFinancialModel : AutobahnBase, Interfaces.IFacilityFinancial
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityLease"/> model
        /// </summary>
        public Guid? FacilityLeaseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityMortgageFee"/> model
        /// </summary>
        public Guid? FacilityMortgageFeeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityMortgage"/> model
        /// </summary>
        public Guid? FacilityMortgageId { get; set; }

        /// <summary>
        /// Financial Accounting Period Actual Value
        /// <para>
        /// The actual value of a financial account for the specified accounting period or fiscal year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20317">Financial Accounting Period Actual Value</a>
        /// </para>
        /// </summary>
        public Guid OrganizationFinancialId { get; set; }

    }
}
