using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonAllergy")]
    public partial class PersonAllergy
    {
        public int PersonAllergyId { get; set; }

        public int PersonId { get; set; }

        public int RefAllergyTypeId { get; set; }

        public int? RefAllergySeverityId { get; set; }

        [StringLength(2000)]
        public string ReactionDescription { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAllergySeverity RefAllergySeverity { get; set; }

        public virtual RefAllergyType RefAllergyType { get; set; }
    }
}
