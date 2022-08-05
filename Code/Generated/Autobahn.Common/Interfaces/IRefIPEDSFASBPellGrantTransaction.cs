//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefIPEDSFASBPellGrantTransaction.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefIPEDSFASBPellGrantTransaction Interface
     /// </summary>
    public partial interface IRefIPEDSFASBPellGrantTransaction : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefIPEDSFASBPellGrantTransactions"/> model
        /// </summary>
        Guid RefIPEDSFASBPellGrantTransactionsId { get; set; }

    }
}
