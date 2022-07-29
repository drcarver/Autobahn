using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("WorkforceProgramParticipantCohort")]
    public partial class WorkforceProgramParticipantCohort
    {
        public int WorkforceProgramParticipantCohortId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [StringLength(30)]
        public string CohortDescription { get; set; }

        public decimal? CohortMedianEarnings { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
