using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RefCourseCreditUnit")]
    public partial class RefCourseCreditUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefCourseCreditUnit()
        {
            Courses = new HashSet<Course>();
            ProfessionalDevelopmentActivities = new HashSet<ProfessionalDevelopmentActivity>();
            StaffProfessionalDevelopmentActivities = new HashSet<StaffProfessionalDevelopmentActivity>();
        }

        public int RefCourseCreditUnitId { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(4000)]
        public string Definition { get; set; }

        public int? RefJurisdictionId { get; set; }

        public decimal? SortOrder { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }

        public virtual Organization Organization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfessionalDevelopmentActivity> ProfessionalDevelopmentActivities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffProfessionalDevelopmentActivity> StaffProfessionalDevelopmentActivities { get; set; }
    }
}
