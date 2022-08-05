//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefFinancialAidVeteransBenefitStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The RefFinancialAidVeteransBenefitStatu Interface
     /// </summary>
    public partial interface IRefFinancialAidVeteransBenefitStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefFinancialAidVeteransBenefitStatus"/> model
        /// </summary>
        Guid RefFinancialAidVeteransBenefitStatusId { get; set; }

    }
}
