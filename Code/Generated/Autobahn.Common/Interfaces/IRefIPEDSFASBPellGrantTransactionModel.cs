//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefIPEDSFASBPellGrantTransactionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefIPEDSFASBPellGrantTransaction Interface Model
     /// </summary>
    public partial interface IRefIPEDSFASBPellGrantTransactionModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefIPEDSFASBPellGrantTransactions"/> model
        /// </summary>
        Guid RefIPEDSFASBPellGrantTransactionsId { get; set; }

    }
}
