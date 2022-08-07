//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELOrganizationFundModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELOrganizationFundModel Interface
     /// </summary>
    public partial interface IELOrganizationFundModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ELOrganizationFunds"/> model
        /// </summary>
        Guid ELOrganizationFundsId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFederalFundingType"/> model
        /// </summary>
        Guid? RefELFederalFundingTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELLocalRevenueSource"/> model
        /// </summary>
        Guid? RefELLocalRevenueSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELOtherFederalFundingSources"/> model
        /// </summary>
        Guid? RefELOtherFederalFundingSourcesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELStateRevenueSource"/> model
        /// </summary>
        Guid? RefELStateRevenueSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBillableBasisType"/> model
        /// </summary>
        Guid? RefBillableBasisTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReimbursementType"/> model
        /// </summary>
        Guid? RefReimbursementTypeId { get; set; }

    }
}
