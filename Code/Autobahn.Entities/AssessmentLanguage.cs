using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentLanguage")]
    public partial class AssessmentLanguage
    {
        public int AssessmentLanguageId { get; set; }

        public int AssessmentId { get; set; }

        public int RefLanguageId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual Assessment Assessment { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }
    }
}
