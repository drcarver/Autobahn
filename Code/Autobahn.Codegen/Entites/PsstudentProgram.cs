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
    [Table("PSStudentProgram")]
    public partial class PsstudentProgram
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("PSStudentProgramId")]
        public int PsstudentProgramId { get; set; }
        /// <summary>
        /// Foreign key - Organization
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCipUseId { get; set; }
        /// <summary>
        /// Foreign key - PsProgram
        /// </summary>
        public int? PsProgramId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefWorkbasedLearningOpportunityTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefTransferOutIndicatorId { get; set; }
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
        public int? RefCareerClusterId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("PsstudentPrograms")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("PsstudentPrograms")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("PsProgramId")]
        [InverseProperty("PsstudentPrograms")]
        public virtual PsProgram? PsProgram { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PsstudentPrograms")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCareerClusterId")]
        [InverseProperty("PsstudentPrograms")]
        public virtual RefCareerCluster? RefCareerCluster { get; set; }
        [ForeignKey("RefCipUseId")]
        [InverseProperty("PsstudentPrograms")]
        public virtual RefCipUse? RefCipUse { get; set; }
        [ForeignKey("RefTransferOutIndicatorId")]
        [InverseProperty("PsstudentPrograms")]
        public virtual RefTransferOutIndicator? RefTransferOutIndicator { get; set; }
        [ForeignKey("RefWorkbasedLearningOpportunityTypeId")]
        [InverseProperty("PsstudentPrograms")]
        public virtual RefWorkbasedLearningOpportunityType? RefWorkbasedLearningOpportunityType { get; set; }
    }
}
