//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialAwardCredit.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialAwardCredit
     /// </summary>
    public partial class CredentialAwardCredit : AutobahnBase, Interfaces.ICredentialAwardCredit
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialAward"/> model
        /// </summary>
        public Guid CredentialAwardId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CredentialCriteriaCourse"/> model
        /// </summary>
        public Guid? CredentialCriteriaCourseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid? OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
