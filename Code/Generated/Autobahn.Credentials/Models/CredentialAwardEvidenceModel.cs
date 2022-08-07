//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialAwardEvidenceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialAwardEvidence Model
     /// </summary>
    public partial class CredentialAwardEvidenceModel : AutobahnBase, Interfaces.ICredentialAwardEvidenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialAward"/> model
        /// </summary>
        public Guid CredentialAwardId { get; set; }

        /// <summary>
        /// Defines the CredentialAwardEvidence.Statement non nullable property
        /// </summary>
        public System.String Statement { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentResult"/> model
        /// </summary>
        public Guid? AssessmentResultId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
