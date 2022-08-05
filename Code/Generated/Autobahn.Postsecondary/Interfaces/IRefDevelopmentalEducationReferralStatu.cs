//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefDevelopmentalEducationReferralStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The RefDevelopmentalEducationReferralStatu Interface
     /// </summary>
    public partial interface IRefDevelopmentalEducationReferralStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefDevelopmentalEducationReferralStatus"/> model
        /// </summary>
        Guid RefDevelopmentalEducationReferralStatusId { get; set; }

    }
}
