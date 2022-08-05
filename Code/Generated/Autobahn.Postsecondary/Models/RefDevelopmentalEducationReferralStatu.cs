//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefDevelopmentalEducationReferralStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefDevelopmentalEducationReferralStatu Model
     /// </summary>
    public partial class RefDevelopmentalEducationReferralStatu : ReferenceModelBase, IRefDevelopmentalEducationReferralStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefDevelopmentalEducationReferralStatus"/> model
        /// </summary>
        public Guid RefDevelopmentalEducationReferralStatusId { get; set; }

    }
}
