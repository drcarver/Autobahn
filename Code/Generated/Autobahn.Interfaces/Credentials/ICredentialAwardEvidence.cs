//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialAwardEvidence.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Credentials
{
     /// <summary>
     /// The ICredentialAwardEvidence Interface
     /// </summary>
    public partial interface ICredentialAwardEvidence : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
        /// </summary>
        Guid? AssessmentResultId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialAward"/> model
        /// </summary>
        Guid CredentialAwardId { get; set; }

        /// <summary>
        /// Credential Evidence Statement
        /// <para>
        /// A statement or reference describing the evidence that the learner met the criteria for attainment of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19901">Credential Evidence Statement</a>
        /// </para>
        /// </summary>
        System.String Statement { get; set; }

    }
}
