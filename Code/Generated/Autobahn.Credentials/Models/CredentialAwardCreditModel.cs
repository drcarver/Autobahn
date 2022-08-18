//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardCreditModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialAwardCredit Model
     /// </summary>
    public partial class CredentialAwardCreditModel : AutobahnBase, Interfaces.ICredentialAwardCredit
    {
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
        /// Reference to an optional instance of the <see cref="ICredentialCriteriaCourse"/> model
        /// </summary>
        public Guid? CredentialCriteriaCourseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid? OrganizationPersonRoleId { get; set; }

    }
}
