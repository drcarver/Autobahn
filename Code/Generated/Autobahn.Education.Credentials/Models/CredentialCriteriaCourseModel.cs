//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialCriteriaCourseModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Credentials;

namespace Autobahn.Education.Credentials.Models
{
     /// <summary>
     /// The CredentialCriteriaCourse Model
     /// </summary>
    public partial class CredentialCriteriaCourseModel : ICredentialCriteriaCourse
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region ICredentialCriteriaCourse
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourse"/> model
        /// </summary>
        public Guid CourseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICredentialDefCriteria"/> model
        /// </summary>
        public Guid CredentialDefCriteriaId { get; set; }

        #endregion
    }
}
