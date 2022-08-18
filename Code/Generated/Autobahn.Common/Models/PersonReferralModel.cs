//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonReferralModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonReferral Model
     /// </summary>
    public partial class PersonReferralModel : AutobahnBase, Interfaces.IPersonReferral
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Referral Reason
        /// <para>
        /// The reason for the referral.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20455">Referral Reason</a>
        /// </para>
        /// </summary>
        public System.String Reason { get; set; }

        /// <summary>
        /// Referral Date
        /// <para>
        /// The date of referral.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20453">Referral Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ReferralDate { get; set; }

        /// <summary>
        /// Referral Type Received
        /// <para>
        /// A type of service that a child or family has received a referral for.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20457">Referral Type Received</a>
        /// </para>
        /// </summary>
        public System.String ReferralTypeReceived { get; set; }

        /// <summary>
        /// Referred To
        /// <para>
        /// The program or organization to which the child/family was referred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20458">Referred To</a>
        /// </para>
        /// </summary>
        public System.String ReferredTo { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefReferralOutcome"/> model
        /// </summary>
        public Guid? RefReferralOutcomeId { get; set; }

        /// <summary>
        /// Referral Source
        /// <para>
        /// The person, program, or organization making the initial referral.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20456">Referral Source</a>
        /// </para>
        /// </summary>
        public System.String Source { get; set; }

    }
}
