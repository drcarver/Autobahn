//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardEvidenceModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The CredentialAwardEvidence Model
     /// </summary>
    public partial class CredentialAwardEvidenceModel : AutobahnBase, Interfaces.ICredentialAwardEvidence
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
        /// </summary>
        public Guid? AssessmentResultId { get; set; }

        /// <summary>
        /// Credential Advanced Standing Description
        /// <para>
        /// A description of a credential that reduced the time or cost of attaining this credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20715">Credential Advanced Standing Description</a>
        /// </para>
        /// </summary>
        public Guid CredentialAwardId { get; set; }

        /// <summary>
        /// Credential Evidence Statement
        /// <para>
        /// A statement or reference describing the evidence that the learner met the criteria for attainment of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19901">Credential Evidence Statement</a>
        /// </para>
        /// </summary>
        public System.String Statement { get; set; }

    }
}
