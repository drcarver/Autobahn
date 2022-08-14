//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IRefFinancialAidAwardStatus.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The RefFinancialAidAwardStatus Interface Model
     /// </summary>
    public partial interface IRefFinancialAidAwardStatus : IReferenceModel
    {
        /// <summary>
        /// An indication of whether the financial aid type being reported is aid that has been awarded, accepted or dispersed.
        /// </summary>
        Guid RefFinancialAidStatusId { get; set; }

    }
}
