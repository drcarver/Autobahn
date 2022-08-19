using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentAdministration")]
    public partial class AssessmentAdministration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentAdministration()
        {
            AssessmentAssessmentAdministration = new HashSet<AssessmentAssessmentAdministration>();
            AssessmentAdministrationOrganization = new HashSet<AssessmentAdministrationOrganization>();
            AssessmentRegistrations = new HashSet<AssessmentRegistration>();
            AssessmentSessions = new HashSet<AssessmentSession>();
        }

        public int AssessmentAdministrationId { get; set; }

        public int? AssessmentId { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Code { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        public TimeSpan? StartTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FinishDate { get; set; }

        public TimeSpan? FinishTime { get; set; }

        public int? RefAssessmentReportingMethodId { get; set; }

        public bool? AssessmentSecureIndicator { get; set; }

        [StringLength(300)]
        public string AssessmentAdministrationPeriodDescription { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentAssessmentAdministration> AssessmentAssessmentAdministration { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentAdministrationOrganization> AssessmentAdministrationOrganization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentReportingMethod RefAssessmentReportingMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSession> AssessmentSessions { get; set; }
    }
}
