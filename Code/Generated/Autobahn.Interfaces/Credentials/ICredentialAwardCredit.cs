//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialAwardCredit.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Credentials
{
     /// <summary>
     /// The ICredentialAwardCredit Interface
     /// </summary>
    public partial interface ICredentialAwardCredit : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialAward"/> model
        /// </summary>
        Guid CredentialAwardId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialCriteriaCourse"/> model
        /// </summary>
        Guid? CredentialCriteriaCourseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid? OrganizationPersonRoleId { get; set; }

    }
}
