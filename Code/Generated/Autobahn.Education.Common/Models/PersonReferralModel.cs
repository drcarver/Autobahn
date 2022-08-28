//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonReferralModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The PersonReferral Model
     /// </summary>
    public partial class PersonReferralModel : IPersonReferral
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IPersonReferral
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
        public DateTime? ReferralDate { get; set; }

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
        /// Referral Outcome
        /// <para>
        /// The outcome of the referral.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20454">Referral Outcome</a>
        /// </para>
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

        #endregion
    }
}
