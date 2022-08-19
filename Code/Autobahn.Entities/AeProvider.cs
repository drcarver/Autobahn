using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AeProvider")]
    public partial class AeProvider
    {
        public int AeProviderId { get; set; }

        public Guid OrganizationId { get; set; }

        public int RefLevelOfInstitutionId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefLevelOfInstitution RefLevelOfInstitution { get; set; }
    }
}
