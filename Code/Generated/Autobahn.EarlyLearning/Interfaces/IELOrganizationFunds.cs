//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELOrganizationFunds.cs
//* Name:       Record End Date Time
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IELOrganizationFunds : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBillableBasisType"/> model
        /// </summary>
         RefBillableBasisTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefELFederalFundingType"/> model
        /// </summary>
         RefELFederalFundingTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefELLocalRevenueSource"/> model
        /// </summary>
         RefELLocalRevenueSourceId { get; set; }

        /// <summary>
        /// Early Learning Other Federal Funding Sources
        /// <para>
        /// The other contributing funding sources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20302">Early Learning Other Federal Funding Sources</a>
        /// </para>
        /// </summary>
         RefELOtherFederalFundingSourcesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefELStateRevenueSource"/> model
        /// </summary>
         RefELStateRevenueSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefReimbursementType"/> model
        /// </summary>
         RefReimbursementTypeId { get; set; }

    }
}
