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
    [Table("K12StaffEmployment", Schema = "K12")]
    public partial class K12StaffEmployment
    {
        [Key]
        public int K12StaffEmploymentId { get; set; }
        /// <summary>
        /// Foreign key - StaffEmployment
        /// </summary>
        public int StaffEmploymentId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ContractDaysOfServicePerYear { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? MepPersonnelIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? TitleITargetedAssistanceStaffFunded { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? SalaryForTeachingAssignmentOnlyIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefK12StaffClassificationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEmploymentStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("K12staffEmployments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12staffEmployments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefEmploymentStatusId")]
        [InverseProperty("K12staffEmployments")]
        public virtual RefEmploymentStatus? RefEmploymentStatus { get; set; }
        [ForeignKey("RefK12staffClassificationId")]
        [InverseProperty("K12staffEmployments")]
        public virtual RefK12StaffClassification? RefK12staffClassification { get; set; }
        [ForeignKey("StaffEmploymentId")]
        [InverseProperty("K12staffEmployments")]
        public virtual StaffEmployment StaffEmployment { get; set; } = null!;
    }
}
