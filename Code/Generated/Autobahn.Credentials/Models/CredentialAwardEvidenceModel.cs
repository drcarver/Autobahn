//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardEvidenceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialAwardEvidence Model
     /// </summary>
    public partial class CredentialAwardEvidenceModel : AutobahnBase, Interfaces.ICredentialAwardEvidence
    {
        /// <summary>
        /// A statement or reference describing the evidence that the learner met the criteria for attainment of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public Guid? AssessmentResultId { get; set; }

        /// <summary>
        /// A statement or reference describing the evidence that the learner met the criteria for attainment of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public Guid CredentialAwardId { get; set; }

        /// <summary>
        /// A statement or reference describing the evidence that the learner met the criteria for attainment of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        public System.String Statement { get; set; }

    }
}
