//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonReferral.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonReferral Interface
     /// </summary>
    public partial interface IPersonReferral : IAutobahnBase
    {
        /// <summary>
        /// The date of referral.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The date of referral.
        /// </summary>
        System.String Reason { get; set; }

        /// <summary>
        /// The date of referral.
        /// </summary>
        System.DateTime? ReferralDate { get; set; }

        /// <summary>
        /// The date of referral.
        /// </summary>
        System.String ReferralTypeReceived { get; set; }

        /// <summary>
        /// The date of referral.
        /// </summary>
        System.String ReferredTo { get; set; }

        /// <summary>
        /// The date of referral.
        /// </summary>
        Guid? RefReferralOutcomeId { get; set; }

        /// <summary>
        /// The date of referral.
        /// </summary>
        System.String Source { get; set; }

    }
}
