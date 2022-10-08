using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
    /// </summary>
    [Table("RefStudentSchoolAffiliationStateDefinedStatus", Schema = "K12")]
    public partial class RefStudentSchoolAffiliationStateDefinedStatus
    {
        public RefStudentSchoolAffiliationStateDefinedStatus()
        {
            K12organizationStudentResponsibilities = new HashSet<K12OrganizationStudentResponsibility>();
        }

        [Key]
        public int RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(150)]
        public string Description { get; set; } = null!;
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(50)]
        public string? Code { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(4000)]
        public string? Definition { get; set; }
        public int? RefJurisdictionId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefStudentSchoolAffiliationStateDefinedStatuses")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefStudentSchoolAffiliationStateDefinedStatus")]
        public virtual ICollection<K12OrganizationStudentResponsibility> K12organizationStudentResponsibilities { get; set; }
    }
}
