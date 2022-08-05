//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialAwardCredit.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialAwardCredit
     /// </summary>
    public partial interface ICredentialAwardCredit : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialAward"/> model
        /// </summary>
        Guid CredentialAwardId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CredentialCriteriaCourse"/> model
        /// </summary>
        Guid? CredentialCriteriaCourseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid? OrganizationPersonRoleId { get; set; }

    }
}
