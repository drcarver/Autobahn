//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialAidAwardStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefFinancialAidAwardStatu Model
     /// </summary>
    public partial class RefFinancialAidAwardStatu : ReferenceModelBase, IRefFinancialAidAwardStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefFinancialAidStatus"/> model
        /// </summary>
        public Guid RefFinancialAidStatusId { get; set; }

    }
}
