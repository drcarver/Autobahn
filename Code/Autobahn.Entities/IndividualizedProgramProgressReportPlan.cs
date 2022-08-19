using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IndividualizedProgramProgressReportPlan")]
    public partial class IndividualizedProgramProgressReportPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IndividualizedProgramProgressReportPlan()
        {
            IndividualizedProgramProgressReports = new HashSet<IndividualizedProgramProgressReport>();
        }

        public int IndividualizedProgramProgressReportPlanId { get; set; }

        public int IndividualizedProgramId { get; set; }

        public int? RefIPSPProgressReportScheduleId { get; set; }

        public int? RefIPSPProgressReportTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual IndividualizedProgram IndividualizedProgram { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramProgressReport> IndividualizedProgramProgressReports { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefIPSPProgressReportSchedule RefIPSPProgressReportSchedule { get; set; }

        public virtual RefIPSPProgressReportType RefIPSPProgressReportType { get; set; }
    }
}
