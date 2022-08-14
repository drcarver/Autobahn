using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("EarlyChildhoodProgramTypeOffered")]
    public partial class EarlyChildhoodProgramTypeOffered
    {
        public int EarlyChildhoodProgramTypeOfferedId { get; set; }

        public int OrganizationId { get; set; }

        public int RefEarlyChildhoodProgramEnrollmentTypeId { get; set; }

        public bool? InclusiveSettingIndicator { get; set; }

        public int? RefCommunityBasedTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCommunityBasedType RefCommunityBasedType { get; set; }

        public virtual RefEarlyChildhoodProgramEnrollmentType RefEarlyChildhoodProgramEnrollmentType { get; set; }
    }
}
