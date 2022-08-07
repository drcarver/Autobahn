//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   CredentialCriteriaCourseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialCriteriaCourse Model
     /// </summary>
    public partial class CredentialCriteriaCourseModel : AutobahnBase, Interfaces.ICredentialCriteriaCourseModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefCriteria"/> model
        /// </summary>
        public Guid CredentialDefCriteriaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        public Guid CourseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
