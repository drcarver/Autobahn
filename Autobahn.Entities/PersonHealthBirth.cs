using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonHealthBirth")]
    public partial class PersonHealthBirth
    {
        public int PersonHealthBirthId { get; set; }

        public int PersonId { get; set; }

        public int? WeeksOfGestation { get; set; }

        public bool? MultipleBirthIndicator { get; set; }

        [StringLength(20)]
        public string WeightAtBirth { get; set; }

        public int? RefTrimesterWhenPrenatalCareBeganId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefTrimesterWhenPrenatalCareBegan RefTrimesterWhenPrenatalCareBegan { get; set; }
    }
}
