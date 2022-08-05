//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefFinancialAidVeteransBenefitStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefFinancialAidVeteransBenefitStatu Model
     /// </summary>
    public partial class RefFinancialAidVeteransBenefitStatu : ReferenceModelBase, IRefFinancialAidVeteransBenefitStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefFinancialAidVeteransBenefitStatus"/> model
        /// </summary>
        public Guid RefFinancialAidVeteransBenefitStatusId { get; set; }

    }
}
