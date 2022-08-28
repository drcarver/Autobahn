//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAllergyModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The PersonAllergy Model
     /// </summary>
    public partial class PersonAllergyModel : IPersonAllergy
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

        #region IPersonAllergy
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Allergy Reaction Description
        /// <para>
        /// Describes symptoms know to be associated with a person's reaction to an allergen.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20247">Allergy Reaction Description</a>
        /// </para>
        /// </summary>
        public System.String ReactionDescription { get; set; }

        /// <summary>
        /// Allergy Severity
        /// <para>
        /// The level of severity of a person's reaction to an allergen.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20248">Allergy Severity</a>
        /// </para>
        /// </summary>
        public Guid? RefAllergySeverityId { get; set; }

        /// <summary>
        /// Allergy Type
        /// <para>
        /// Type of allergy condition attributed to a person as defined by the SNOWMED Clinical Terms(r) vocabulary.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20249">Allergy Type</a>
        /// </para>
        /// </summary>
        public Guid RefAllergyTypeId { get; set; }

        #endregion
    }
}
