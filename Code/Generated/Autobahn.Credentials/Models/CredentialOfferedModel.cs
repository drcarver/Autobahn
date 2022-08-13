//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialOfferedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialOffered Model
     /// </summary>
    public partial class CredentialOfferedModel : AutobahnBase, Interfaces.ICredentialOffered
    {
        /// <summary>
        /// The first date a credential was offered.
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

        /// <summary>
        /// The first date a credential was offered.
        /// </summary>
        public Guid CredentialIssuerId { get; set; }

        /// <summary>
        /// The first date a credential was offered.
        /// </summary>
        public System.DateTime? CredentialOfferedEndDate { get; set; }

        /// <summary>
        /// The first date a credential was offered.
        /// </summary>
        public System.DateTime? CredentialOfferedStartDate { get; set; }

    }
}
