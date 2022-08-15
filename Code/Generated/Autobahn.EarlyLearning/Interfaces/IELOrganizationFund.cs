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

    }
}
