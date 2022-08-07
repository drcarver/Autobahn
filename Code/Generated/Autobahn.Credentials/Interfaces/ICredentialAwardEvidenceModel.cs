//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialAwardEvidenceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialAwardEvidenceModel Interface
     /// </summary>
    public partial interface ICredentialAwardEvidenceModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialAward"/> model
        /// </summary>
        Guid CredentialAwardId { get; set; }

        /// <summary>
        /// Defines the CredentialAwardEvidence.Statement non nullable property
        /// </summary>
        System.String Statement { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentResult"/> model
        /// </summary>
        Guid? AssessmentResultId { get; set; }

    }
}
