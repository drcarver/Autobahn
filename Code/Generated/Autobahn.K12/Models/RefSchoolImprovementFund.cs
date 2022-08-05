//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefSchoolImprovementFund.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefSchoolImprovementFund Model
     /// </summary>
    public partial class RefSchoolImprovementFund : ReferenceModelBase, IRefSchoolImprovementFund
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefSchoolImprovementFunds"/> model
        /// </summary>
        public Guid RefSchoolImprovementFundsId { get; set; }

    }
}
