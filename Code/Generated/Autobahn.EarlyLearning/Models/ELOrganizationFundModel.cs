//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationFundModel.cs
//**********************************************************

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
        /// 
        /// </summary>
        public Guid ELOrganizationFundsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefBillableBasisTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefELFederalFundingTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefELLocalRevenueSourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefELOtherFederalFundingSourcesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefELStateRevenueSourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefReimbursementTypeId { get; set; }

    }
}
