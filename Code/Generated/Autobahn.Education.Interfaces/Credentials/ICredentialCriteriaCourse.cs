//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialCriteriaCourse.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Credentials
{
     /// <summary>
     /// The ICredentialCriteriaCourse Interface
     /// </summary>
    public partial interface ICredentialCriteriaCourse : IAutobahnBase
    {
        #region ICredentialCriteriaCourse
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourse"/> model
        /// </summary>
        Guid CourseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefCriteria"/> model
        /// </summary>
        Guid CredentialDefCriteriaId { get; set; }

        #endregion
    }
}
