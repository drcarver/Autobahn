//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialCriteriaCourse.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Credentials
{
     /// <summary>
     /// The ICredentialCriteriaCourse Interface
     /// </summary>
    public partial interface ICredentialCriteriaCourse : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourse"/> model
        /// </summary>
        Guid CourseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefCriteria"/> model
        /// </summary>
        Guid CredentialDefCriteriaId { get; set; }

    }
}
