//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   ICredentialCriteriaCourse.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialCriteriaCourse
     /// </summary>
    public partial interface ICredentialCriteriaCourse : IAutobahnBase
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
