//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefFinancialAidAwardStatusModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

using Autobahn.Invalid.Interfaces;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The RefFinancialAidAwardStatus Model
     /// </summary>
    public partial class RefFinancialAidAwardStatus : ReferenceModelBase, Interfaces.IRefFinancialAidAwardStatus
    {
        /// <summary>
        /// An indication of whether the financial aid type being reported is aid that has been awarded, accepted or dispersed.
        /// </summary>
        public Guid RefFinancialAidStatusId { get; set; }

    }
}
