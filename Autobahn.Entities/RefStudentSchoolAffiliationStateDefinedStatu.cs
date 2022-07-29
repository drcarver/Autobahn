using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Autobahn.Entities
{
    public partial class RefStudentSchoolAffiliationStateDefinedStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefStudentSchoolAffiliationStateDefinedStatu()
        {
            K12OrganizationStudentResponsibility = new HashSet<K12OrganizationStudentResponsibility>();
        }

        [Key]
        public int RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }

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
        public virtual ICollection<K12OrganizationStudentResponsibility> K12OrganizationStudentResponsibility { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
