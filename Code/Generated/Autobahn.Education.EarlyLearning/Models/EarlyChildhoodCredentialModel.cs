//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodCredentialModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.EarlyLearning;

namespace Autobahn.Education.EarlyLearning.Models
{
     /// <summary>
     /// The EarlyChildhoodCredential Model
     /// </summary>
    public partial class EarlyChildhoodCredentialModel : IEarlyChildhoodCredential
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

        #region IEarlyChildhoodCredential
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonCredential"/> model
        /// </summary>
        public Guid PersonCredentialId { get; set; }

        /// <summary>
        /// Early Childhood Credential
        /// <para>
        /// The credential related to early childhood education or development held by a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19344">Early Childhood Credential</a>
        /// </para>
        /// </summary>
        public Guid RefEarlyChildhoodCredentialId { get; set; }

        #endregion
    }
}
