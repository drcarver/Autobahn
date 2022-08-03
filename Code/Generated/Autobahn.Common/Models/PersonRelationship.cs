//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonRelationship.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonRelationship
     /// </summary>
    public partial class PersonRelationship : IPersonRelationship
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RelatedPerson"/> model
        /// </summary>
        public Guid RelatedPersonId { get; set; }

        /// <summary>
        /// Defines the PersonRelationship.CustodialRelationshipIndicator nullable property
        /// </summary>
        public System.Boolean? CustodialRelationshipIndicator { get; set; }

        /// <summary>
        /// Defines the PersonRelationship.EmergencyContactInd nullable property
        /// </summary>
        public System.Boolean? EmergencyContactInd { get; set; }

        /// <summary>
        /// Defines the PersonRelationship.ContactPriorityNumber nullable property
        /// </summary>
        public System.Int32? ContactPriorityNumber { get; set; }

        /// <summary>
        /// Defines the PersonRelationship.ContactRestrictions non nullable property
        /// </summary>
        public System.String ContactRestrictions { get; set; }

        /// <summary>
        /// Defines the PersonRelationship.LivesWithIndicator nullable property
        /// </summary>
        public System.Boolean? LivesWithIndicator { get; set; }

        /// <summary>
        /// Defines the PersonRelationship.PrimaryContactIndicator nullable property
        /// </summary>
        public System.Boolean? PrimaryContactIndicator { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonRelationshipType"/> model
        /// </summary>
        public Guid RefPersonRelationshipTypeId { get; set; }

        /// <summary>
        /// Defines the PersonRelationship.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonRelationship.RecordEndDateTime nullable property
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
