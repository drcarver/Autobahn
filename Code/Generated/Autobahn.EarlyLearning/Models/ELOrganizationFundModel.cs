//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationFundModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELOrganizationFund Model
     /// </summary>
    public partial class ELOrganizationFundModel : AutobahnBase, Interfaces.IELOrganizationFund
    {
        /// <summary>
        /// Record End Date Time
        /// <para>
        /// The end date and, optionally, time that a record is active as used to support version control.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20899">Record End Date Time</a>
        /// </para>
        /// </summary>
        public Guid ELOrganizationFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBillableBasisType"/> model
        /// </summary>
        public Guid? RefBillableBasisTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFederalFundingType"/> model
        /// </summary>
        public Guid? RefELFederalFundingTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELLocalRevenueSource"/> model
        /// </summary>
        public Guid? RefELLocalRevenueSourceId { get; set; }

        /// <summary>
        /// Early Learning Other Federal Funding Sources
        /// <para>
        /// The other contributing funding sources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20302">Early Learning Other Federal Funding Sources</a>
        /// </para>
        /// </summary>
        public Guid? RefELOtherFederalFundingSourcesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELStateRevenueSource"/> model
        /// </summary>
        public Guid? RefELStateRevenueSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReimbursementType"/> model
        /// </summary>
        public Guid? RefReimbursementTypeId { get; set; }

    }
}
