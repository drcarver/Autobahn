//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonAllergyModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAllergy Model
     /// </summary>
    public partial class PersonAllergyModel : AutobahnBase, Interfaces.IPersonAllergyModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAllergyType"/> model
        /// </summary>
        public Guid RefAllergyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAllergySeverity"/> model
        /// </summary>
        public Guid? RefAllergySeverityId { get; set; }

        /// <summary>
        /// Defines the PersonAllergy.ReactionDescription non nullable property
        /// </summary>
        public System.String ReactionDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
