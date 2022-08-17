//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationFundsModel.cs
//* Name:       Record End Date Time
//* Definition: The end date and, optionally, time that a record is active as used to support version control.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The end date and, optionally, time that a record is active as used to support version control.
     /// </summary>
    public partial class ELOrganizationFundsModel : AutobahnBase, Interfaces.IELOrganizationFunds
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBillableBasisType"/> model
        /// </summary>
        public  RefBillableBasisTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefELFederalFundingType"/> model
        /// </summary>
        public  RefELFederalFundingTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefELLocalRevenueSource"/> model
        /// </summary>
        public  RefELLocalRevenueSourceId { get; set; }

        /// <summary>
        /// Early Learning Other Federal Funding Sources
        /// <para>
        /// The other contributing funding sources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20302">Early Learning Other Federal Funding Sources</a>
        /// </para>
        /// </summary>
        public  RefELOtherFederalFundingSourcesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefELStateRevenueSource"/> model
        /// </summary>
        public  RefELStateRevenueSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefReimbursementType"/> model
        /// </summary>
        public  RefReimbursementTypeId { get; set; }

    }
}
