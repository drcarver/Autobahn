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
        /// 
        /// </summary>
        Guid ELOrganizationFundsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefBillableBasisTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefELFederalFundingTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefELLocalRevenueSourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefELOtherFederalFundingSourcesId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefELStateRevenueSourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefReimbursementTypeId { get; set; }

    }
}
