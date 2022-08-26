//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardCreditModel.cs
//***************************************************************************

using Autobahn.Interfaces.Credentials;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialAwardCredit Model
     /// </summary>
    public partial class CredentialAwardCreditModel : AutobahnBase, ICredentialAwardCredit
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialAward"/> model
        /// </summary>
        public Guid CredentialAwardId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialCriteriaCourse"/> model
        /// </summary>
        public Guid? CredentialCriteriaCourseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid? OrganizationPersonRoleId { get; set; }

    }
}
