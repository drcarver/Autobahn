//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAllergyModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAllergy Model
     /// </summary>
    public partial class PersonAllergyModel : AutobahnBase, Interfaces.IPersonAllergy
    {
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
        /// Reference to an optional instance of the <see cref="RefAllergySeverity"/> model
        /// </summary>
        public Guid? RefAllergySeverityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAllergyType"/> model
        /// </summary>
        public Guid RefAllergyTypeId { get; set; }

    }
}
