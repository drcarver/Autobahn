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

    }
}
