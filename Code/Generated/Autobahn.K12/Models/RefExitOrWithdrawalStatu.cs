//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefExitOrWithdrawalStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefExitOrWithdrawalStatu Model
     /// </summary>
    public partial class RefExitOrWithdrawalStatu : ReferenceModelBase, IRefExitOrWithdrawalStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefExitOrWithdrawalStatus"/> model
        /// </summary>
        public Guid RefExitOrWithdrawalStatusId { get; set; }

    }
}
