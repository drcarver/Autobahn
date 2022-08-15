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
        System.DateTime? ReferralDate { get; set; }

    }
}
