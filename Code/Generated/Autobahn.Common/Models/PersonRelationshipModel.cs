//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonRelationshipModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonRelationship Model
     /// </summary>
    public partial class PersonRelationshipModel : AutobahnBase, Interfaces.IPersonRelationship
    {
        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public System.Int32? ContactPriorityNumber { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public System.String ContactRestrictions { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public System.Boolean? CustodialRelationshipIndicator { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public System.Boolean? EmergencyContactInd { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public System.Boolean? LivesWithIndicator { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public System.Boolean? PrimaryContactIndicator { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public Guid RefPersonRelationshipTypeId { get; set; }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// </summary>
        public Guid RelatedPersonId { get; set; }

    }
}
