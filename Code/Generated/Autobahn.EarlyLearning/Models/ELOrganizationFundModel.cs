//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELOrganizationFundModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELOrganizationFund Model
     /// </summary>
    public partial class ELOrganizationFundModel : AutobahnBase, Interfaces.IELOrganizationFundModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ELOrganizationFunds"/> model
        /// </summary>
        public Guid ELOrganizationFundsId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFederalFundingType"/> model
        /// </summary>
        public Guid? RefELFederalFundingTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELLocalRevenueSource"/> model
        /// </summary>
        public Guid? RefELLocalRevenueSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELOtherFederalFundingSources"/> model
        /// </summary>
        public Guid? RefELOtherFederalFundingSourcesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELStateRevenueSource"/> model
        /// </summary>
        public Guid? RefELStateRevenueSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBillableBasisType"/> model
        /// </summary>
        public Guid? RefBillableBasisTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReimbursementType"/> model
        /// </summary>
        public Guid? RefReimbursementTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
