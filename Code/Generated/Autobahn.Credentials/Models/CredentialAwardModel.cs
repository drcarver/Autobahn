//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialAward Model
     /// </summary>
    public partial class CredentialAwardModel : AutobahnBase, Interfaces.ICredentialAward
    {
        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.String AdvancedStandingDescription { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.String AdvancedStandingURL { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.String ApproverName { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.DateTime? CompletionDate { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.DateTime? CredentialAwardEndDate { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.DateTime? CredentialAwardStartDate { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public Guid CredentialIssuerId { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.String EvidenceURL { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public Guid? PersonId { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.DateTime? RevokedDate { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.Boolean? RevokedIndicator { get; set; }

        /// <summary>
        /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
        /// </summary>
        public System.String RevokedReason { get; set; }

    }
}
