//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefSchoolImprovementFundModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefSchoolImprovementFund Model
     /// </summary>
    public partial class RefSchoolImprovementFundModel : ReferenceModelBase, IRefSchoolImprovementFundModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefSchoolImprovementFunds"/> model
        /// </summary>
        public Guid RefSchoolImprovementFundsId { get; set; }

    }
}
