using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonRelationship")]
    public partial class PersonRelationship
    {
        public int PersonRelationshipId { get; set; }

        public int PersonId { get; set; }

        public int RelatedPersonId { get; set; }

        public bool? CustodialRelationshipIndicator { get; set; }

        public bool? EmergencyContactInd { get; set; }

        public int? ContactPriorityNumber { get; set; }

        [StringLength(2000)]
        public string ContactRestrictions { get; set; }

        public bool? LivesWithIndicator { get; set; }

        public bool? PrimaryContactIndicator { get; set; }

        public int RefPersonRelationshipTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual Person Person1 { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefPersonRelationshipType RefPersonRelationshipType { get; set; }
    }
}
