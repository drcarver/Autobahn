//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialAwardEvidence.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialAwardEvidence Interface
     /// </summary>
    public partial interface ICredentialAwardEvidence : IAutobahnBase
    {
        /// <summary>
        /// A statement or reference describing the evidence that the learner met the criteria for attainment of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        Guid? AssessmentResultId { get; set; }

        /// <summary>
        /// A statement or reference describing the evidence that the learner met the criteria for attainment of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        Guid CredentialAwardId { get; set; }

        /// <summary>
        /// A statement or reference describing the evidence that the learner met the criteria for attainment of the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </summary>
        System.String Statement { get; set; }

    }
}
