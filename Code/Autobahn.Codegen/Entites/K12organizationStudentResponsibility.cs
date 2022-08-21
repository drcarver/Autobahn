using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("K12OrganizationStudentResponsibility")]
    [Index("OrganizationPersonRoleId", "RefK12responsibilityTypeId", Name = "IX_K12OrganizationStudentResponsibility", IsUnique = true)]
    public partial class K12organizationStudentResponsibility
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("K12OrganizationStudentResponsibilityId")]
        public int K12organizationStudentResponsibilityId { get; set; }
        /// <summary>
        /// Surrogate key - OrganizationPersonRole
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefK12ResponsibilityTypeId")]
        public int RefK12responsibilityTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("K12organizationStudentResponsibilities")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("K12organizationStudentResponsibilities")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12organizationStudentResponsibilities")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefK12responsibilityTypeId")]
        [InverseProperty("K12organizationStudentResponsibilities")]
        public virtual RefK12responsibilityType RefK12responsibilityType { get; set; } = null!;
        [ForeignKey("RefStudentSchoolAffiliationStateDefinedStatusId")]
        [InverseProperty("K12organizationStudentResponsibilities")]
        public virtual RefStudentSchoolAffiliationStateDefinedStatus? RefStudentSchoolAffiliationStateDefinedStatus { get; set; }
    }
}
