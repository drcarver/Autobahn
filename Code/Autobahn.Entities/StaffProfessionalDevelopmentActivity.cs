using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("StaffProfessionalDevelopmentActivity")]
    public partial class StaffProfessionalDevelopmentActivity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StaffProfessionalDevelopmentActivity()
        {
            CoreKnowledgeAreas = new HashSet<CoreKnowledgeArea>();
        }

        public int StaffProfessionalDevelopmentActivityId { get; set; }

        public int ProfessionalDevelopmentRequirementId { get; set; }

        [StringLength(60)]
        public string ActivityTitle { get; set; }

        [StringLength(40)]
        public string ActivityIdentifier { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ActivityStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ActivityCompletionDate { get; set; }

        public bool? ScholarshipStatus { get; set; }

        public int? RefProfessionalDevelopmentFinancialSupportId { get; set; }

        public decimal? NumberOfCreditsEarned { get; set; }

        public int? RefCourseCreditUnitId { get; set; }

        public int ProfessionalDevelopmentActivityId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int ProfessionalDevelopmentSessionId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoreKnowledgeArea> CoreKnowledgeAreas { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual ProfessionalDevelopmentActivity ProfessionalDevelopmentActivity { get; set; }

        public virtual ProfessionalDevelopmentRequirement ProfessionalDevelopmentRequirement { get; set; }

        public virtual ProfessionalDevelopmentSession ProfessionalDevelopmentSession { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCourseCreditUnit RefCourseCreditUnit { get; set; }

        public virtual RefProfessionalDevelopmentFinancialSupport RefProfessionalDevelopmentFinancialSupport { get; set; }
    }
}
