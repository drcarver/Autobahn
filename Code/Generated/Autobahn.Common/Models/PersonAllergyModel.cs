//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAllergyModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAllergy Model
     /// </summary>
    public partial class PersonAllergyModel : AutobahnBase, Interfaces.IPersonAllergy
    {
        /// <summary>
        /// Describes symptoms know to be associated with a person's reaction to an allergen.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Describes symptoms know to be associated with a person's reaction to an allergen.
        /// </summary>
        public System.String ReactionDescription { get; set; }

        /// <summary>
        /// Describes symptoms know to be associated with a person's reaction to an allergen.
        /// </summary>
        public Guid? RefAllergySeverityId { get; set; }

        /// <summary>
        /// Describes symptoms know to be associated with a person's reaction to an allergen.
        /// </summary>
        public Guid RefAllergyTypeId { get; set; }

    }
}
