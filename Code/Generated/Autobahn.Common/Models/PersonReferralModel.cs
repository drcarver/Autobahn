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
        public Guid PersonId { get; set; }

        /// <summary>
        /// The date of referral.
        /// </summary>
        public System.String Reason { get; set; }

        /// <summary>
        /// The date of referral.
        /// </summary>
        public System.DateTime? ReferralDate { get; set; }

        /// <summary>
        /// The date of referral.
        /// </summary>
        public System.String ReferralTypeReceived { get; set; }

        /// <summary>
        /// The date of referral.
        /// </summary>
        public System.String ReferredTo { get; set; }

        /// <summary>
        /// The date of referral.
        /// </summary>
        public Guid? RefReferralOutcomeId { get; set; }

        /// <summary>
        /// The date of referral.
        /// </summary>
        public System.String Source { get; set; }

    }
}
