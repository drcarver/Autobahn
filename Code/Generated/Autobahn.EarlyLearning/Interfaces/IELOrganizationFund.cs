//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELOrganizationFund.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELOrganizationFund Interface
     /// </summary>
    public partial interface IELOrganizationFund : IAutobahnBase
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
        Guid ELOrganizationFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBillableBasisType"/> model
        /// </summary>
        Guid? RefBillableBasisTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFederalFundingType"/> model
        /// </summary>
        Guid? RefELFederalFundingTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELLocalRevenueSource"/> model
        /// </summary>
        Guid? RefELLocalRevenueSourceId { get; set; }

        /// <summary>
        /// Early Learning Other Federal Funding Sources
        /// <para>
        /// The other contributing funding sources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20302">Early Learning Other Federal Funding Sources</a>
        /// </para>
        /// </summary>
        Guid? RefELOtherFederalFundingSourcesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELStateRevenueSource"/> model
        /// </summary>
        Guid? RefELStateRevenueSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReimbursementType"/> model
        /// </summary>
        Guid? RefReimbursementTypeId { get; set; }

    }
}
