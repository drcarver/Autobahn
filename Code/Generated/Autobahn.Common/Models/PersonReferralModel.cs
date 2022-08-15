//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonReferralModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonReferral Model
     /// </summary>
    public partial class PersonReferralModel : AutobahnBase, Interfaces.IPersonReferral
    {
        /// <summary>
        /// The date of referral.
        /// </summary>
        public System.DateTime? ReferralDate { get; set; }

    }
}
