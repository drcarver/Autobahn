using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("WorkforceEmploymentQuarterlyData")]
    public partial class WorkforceEmploymentQuarterlyData
    {
        public int WorkforceEmploymentQuarterlyDataId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public decimal? EmployedInMultipleJobsCount { get; set; }

        public bool? MilitaryEnlistmentAfterExit { get; set; }

        public int? RefEmployedWhileEnrolledId { get; set; }

        public int? RefEmployedAfterExitId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
