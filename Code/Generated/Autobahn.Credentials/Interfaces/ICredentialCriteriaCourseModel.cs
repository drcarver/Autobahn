//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialCriteriaCourseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialCriteriaCourseModel Interface
     /// </summary>
    public partial interface ICredentialCriteriaCourseModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CredentialDefCriteria"/> model
        /// </summary>
        Guid CredentialDefCriteriaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        Guid CourseId { get; set; }

    }
}
