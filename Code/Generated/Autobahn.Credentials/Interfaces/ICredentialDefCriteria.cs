//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefCriteria.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefCriteria Interface
     /// </summary>
    public partial interface ICredentialDefCriteria : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        Guid? CompetencySetId { get; set; }

        /// <summary>
        /// Credential Definition Alternate Name
        /// <para>
        /// An alias for the credential, which may include acronyms, alpha-numeric notations, and other forms of name abbreviations in common use such as PhD, MA, and BA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20717">Credential Definition Alternate Name</a>
        /// </para>
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// Credential Definition Criteria
        /// <para>
        /// The criteria for competency-based completion of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19896">Credential Definition Criteria</a>
        /// </para>
        /// </summary>
        System.String Criteria { get; set; }

        /// <summary>
        /// Credential Definition Criteria URL
        /// <para>
        /// The Uniform Resource Locator (URL) for the unique address of a web page describing the competency-based completion criteria for the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20113">Credential Definition Criteria URL</a>
        /// </para>
        /// </summary>
        System.String CriteriaUrl { get; set; }

        /// <summary>
        /// Credential Definition Estimated Duration
        /// <para>
        /// The estimated amount of time in minutes it will take to earn the credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20722">Credential Definition Estimated Duration</a>
        /// </para>
        /// </summary>
        System.String EstimatedDuration { get; set; }

        /// <summary>
        /// Credential Definition Maximum Duration
        /// <para>
        /// The maximum amount of time in minutes it will take to earn the described credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20727">Credential Definition Maximum Duration</a>
        /// </para>
        /// </summary>
        System.String MaximumDuration { get; set; }

        /// <summary>
        /// Credential Definition Minimum Age
        /// <para>
        /// The minimum allowed age in years at which a person is eligible for the credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20728">Credential Definition Minimum Age</a>
        /// </para>
        /// </summary>
        System.Int32? MinimumAge { get; set; }

        /// <summary>
        /// Credential Definition Minimum Duration
        /// <para>
        /// The minimum amount of time in minutes it will take to earn the described credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20729">Credential Definition Minimum Duration</a>
        /// </para>
        /// </summary>
        System.String MinimumDuration { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCredentialDefAssessMethodType"/> model
        /// </summary>
        Guid? RefCredentialDefAssessMethodTypeId { get; set; }

    }
}
