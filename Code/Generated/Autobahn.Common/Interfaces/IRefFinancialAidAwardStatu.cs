//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefFinancialAidAwardStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefFinancialAidAwardStatu Interface
     /// </summary>
    public partial interface IRefFinancialAidAwardStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefFinancialAidStatus"/> model
        /// </summary>
        Guid RefFinancialAidStatusId { get; set; }

    }
}
