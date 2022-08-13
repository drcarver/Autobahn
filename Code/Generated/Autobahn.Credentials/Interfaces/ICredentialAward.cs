//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialAward.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialAward Interface
     /// </summary>
    public partial interface ICredentialAward : IAutobahnBase
    {
        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        System.String AdvancedStandingDescription { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        System.String AdvancedStandingURL { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        System.String ApproverName { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        System.DateTime? CompletionDate { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        System.DateTime? CredentialAwardEndDate { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        System.DateTime? CredentialAwardStartDate { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        Guid CredentialIssuerId { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        System.String EvidenceURL { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        Guid? OrganizationId { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        Guid? PersonId { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        System.DateTime? RevokedDate { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        System.Boolean? RevokedIndicator { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        System.String RevokedReason { get; set; }

    }
}
