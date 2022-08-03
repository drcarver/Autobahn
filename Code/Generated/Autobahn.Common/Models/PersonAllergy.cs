//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonAllergy.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAllergy
     /// </summary>
    public partial class PersonAllergy : IPersonAllergy
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
        /// Defines the PersonAllergy.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonAllergy.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
