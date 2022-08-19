using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CoreKnowledgeArea")]
    public partial class CoreKnowledgeArea
    {
        public int CoreKnowledgeAreaId { get; set; }

        public int ProfessionalDevelopmentActivityId { get; set; }

        public int RefCoreKnowledgeAreaId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual StaffProfessionalDevelopmentActivity StaffProfessionalDevelopmentActivity { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCoreKnowledgeArea RefCoreKnowledgeArea { get; set; }
    }
}
