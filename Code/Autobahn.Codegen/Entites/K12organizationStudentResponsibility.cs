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
    [Table("K12OrganizationStudentResponsibility", Schema = "K12")]
    [Index("OrganizationPersonRoleId", "RefK12ResponsibilityTypeId", Name = "IX_K12OrganizationStudentResponsibility", IsUnique = true)]
    public partial class K12OrganizationStudentResponsibility
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int K12OrganizationStudentResponsibilityId { get; set; }
        /// <summary>
        /// Surrogate key - OrganizationPersonRole
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefK12ResponsibilityTypeId { get; set; }
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
        public virtual RefK12ResponsibilityType RefK12ResponsibilityType { get; set; } = null!;
        [ForeignKey("RefStudentSchoolAffiliationStateDefinedStatusId")]
        [InverseProperty("K12organizationStudentResponsibilities")]
        public virtual RefStudentSchoolAffiliationStateDefinedStatus? RefStudentSchoolAffiliationStateDefinedStatus { get; set; }
    }
}
