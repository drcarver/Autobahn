//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPEDSFinanceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The IPEDSFinance Model
     /// </summary>
    public partial class IPEDSFinanceModel : AutobahnBase, Interfaces.IIPEDSFinance
    {
        /// <summary>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </summary>
        public Guid? RefIPEDSFASBFunctionalExpenseId { get; set; }

    }
}
