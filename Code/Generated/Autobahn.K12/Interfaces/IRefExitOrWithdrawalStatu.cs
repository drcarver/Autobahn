//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefExitOrWithdrawalStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefExitOrWithdrawalStatu Interface
     /// </summary>
    public partial interface IRefExitOrWithdrawalStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefExitOrWithdrawalStatus"/> model
        /// </summary>
        Guid RefExitOrWithdrawalStatusId { get; set; }

    }
}
