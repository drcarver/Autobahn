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
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Referral Reason
        /// <para>
        /// The reason for the referral.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20455">Referral Reason</a>
        /// </para>
        /// </summary>
        System.String Reason { get; set; }

        /// <summary>
        /// Referral Date
        /// <para>
        /// The date of referral.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20453">Referral Date</a>
        /// </para>
        /// </summary>
        System.DateTime? ReferralDate { get; set; }

        /// <summary>
        /// Referral Type Received
        /// <para>
        /// A type of service that a child or family has received a referral for.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20457">Referral Type Received</a>
        /// </para>
        /// </summary>
        System.String ReferralTypeReceived { get; set; }

        /// <summary>
        /// Referred To
        /// <para>
        /// The program or organization to which the child/family was referred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20458">Referred To</a>
        /// </para>
        /// </summary>
        System.String ReferredTo { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReferralOutcome"/> model
        /// </summary>
        Guid? RefReferralOutcomeId { get; set; }

        /// <summary>
        /// Referral Source
        /// <para>
        /// The person, program, or organization making the initial referral.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20456">Referral Source</a>
        /// </para>
        /// </summary>
        System.String Source { get; set; }

    }
}
