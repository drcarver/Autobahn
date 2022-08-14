using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("QuarterlyEmploymentRecord")]
    public partial class QuarterlyEmploymentRecord
    {
        public int QuarterlyEmploymentRecordId { get; set; }

        public int PersonId { get; set; }

        public decimal? Earnings { get; set; }

        [StringLength(50)]
        public string EmploymentNAICSCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReferencePeriodStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReferencePeriodEndDate { get; set; }

        public int? RefERAdministrativeDataSourceId { get; set; }

        public int? RefEmploymentLocationId { get; set; }

        public int? RefEmployedPriorToEnrollmentId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefEmployedPriorToEnrollment RefEmployedPriorToEnrollment { get; set; }

        public virtual RefEmploymentLocation RefEmploymentLocation { get; set; }

        public virtual RefERAdministrativeDataSource RefERAdministrativeDataSource { get; set; }
    }
}
