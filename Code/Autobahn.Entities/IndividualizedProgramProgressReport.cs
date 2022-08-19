using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IndividualizedProgramProgressReport")]
    public partial class IndividualizedProgramProgressReport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IndividualizedProgramProgressReport()
        {
            IndividualizedProgramProgressGoals = new HashSet<IndividualizedProgramProgressGoal>();
        }

        public int IndividualizedProgramProgressReportId { get; set; }

        public int IndividualizedProgramId { get; set; }

        public int IndividualizedProgramProgressReportPlanId { get; set; }

        public string ProgressDescription { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProgressReportDate { get; set; }

        public int? RefIPSPProgressReportTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual IndividualizedProgram IndividualizedProgram { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramProgressGoal> IndividualizedProgramProgressGoals { get; set; }

        public virtual IndividualizedProgramProgressReportPlan IndividualizedProgramProgressReportPlan { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefIPSPProgressReportType RefIPSPProgressReportType { get; set; }
    }
}
