using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonLanguage")]
    public partial class PersonLanguage
    {
        public int PersonLanguageId { get; set; }

        public int PersonId { get; set; }

        public int RefLanguageId { get; set; }

        public int RefLanguageUseTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }

        public virtual RefLanguageUseType RefLanguageUseType { get; set; }
    }
}
