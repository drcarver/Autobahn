//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialCriteriaCourseModel.cs
//***************************************************************************

using Autobahn.Interfaces.Credentials;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialCriteriaCourse Model
     /// </summary>
    public partial class CredentialCriteriaCourseModel : AutobahnBase, ICredentialCriteriaCourse
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourse"/> model
        /// </summary>
        public Guid CourseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefCriteria"/> model
        /// </summary>
        public Guid CredentialDefCriteriaId { get; set; }

    }
}
