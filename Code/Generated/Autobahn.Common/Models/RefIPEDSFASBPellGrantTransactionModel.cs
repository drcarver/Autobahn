//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSFASBPellGrantTransactionModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefIPEDSFASBPellGrantTransaction Model
     /// </summary>
    public partial class RefIPEDSFASBPellGrantTransactionModel : ReferenceModelBase, IRefIPEDSFASBPellGrantTransactionModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefIPEDSFASBPellGrantTransactions"/> model
        /// </summary>
        public Guid RefIPEDSFASBPellGrantTransactionsId { get; set; }

    }
}
