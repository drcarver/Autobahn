using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12TitleIIILanguageInstruction")]
    public partial class K12TitleIIILanguageInstruction
    {
        public int K12TitleIIILanguageInstructionId { get; set; }

        public Guid OrganizationId { get; set; }

        public int RefTitleIIILanguageInstructionProgramTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RefTitleIIILanguageInstructionProgramType RefTitleIIILanguageInstructionProgramType { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
