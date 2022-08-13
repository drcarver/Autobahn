//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialCriteriaCourseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialCriteriaCourse Model
     /// </summary>
    public partial class CredentialCriteriaCourseModel : AutobahnBase, Interfaces.ICredentialCriteriaCourse
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid CourseId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid CredentialDefCriteriaId { get; set; }

    }
}
