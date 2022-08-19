using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PDActivityEducationLevel")]
    public partial class PDActivityEducationLevel
    {
        public int PDActivityEducationLevelId { get; set; }

        public int ProfessionalDevelopmentActivityId { get; set; }

        public int RefPDActivityEducationLevelsAddressedId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual ProfessionalDevelopmentActivity ProfessionalDevelopmentActivity { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
