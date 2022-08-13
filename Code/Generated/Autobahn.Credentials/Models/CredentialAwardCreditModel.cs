//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardCreditModel.cs
//**********************************************************

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
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid CredentialAwardId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? CredentialCriteriaCourseId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? OrganizationPersonRoleId { get; set; }

    }
}
