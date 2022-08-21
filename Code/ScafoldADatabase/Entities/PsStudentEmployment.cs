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
    [Table("PsStudentEmployment")]
    public partial class PsStudentEmployment
    {
        [Key]
        public int PsStudentEmploymentId { get; set; }
        /// <summary>
        /// Surrogate Key - Foreign key: OrganizationPersonRole
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(6)]
        public string? EmploymentNaicsCode { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEmployedWhileEnrolledId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEmployedAfterExitId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEmploymentStatusWhileEnrolledId { get; set; }
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
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("PsStudentEmployments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("PsStudentEmployments")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PsStudentEmployments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefEmployedAfterExitId")]
        [InverseProperty("PsStudentEmployments")]
        public virtual RefEmployedAfterExit? RefEmployedAfterExit { get; set; }
        [ForeignKey("RefEmployedWhileEnrolledId")]
        [InverseProperty("PsStudentEmployments")]
        public virtual RefEmployedWhileEnrolled? RefEmployedWhileEnrolled { get; set; }
        [ForeignKey("RefEmploymentStatusWhileEnrolledId")]
        [InverseProperty("PsStudentEmployments")]
        public virtual RefEmploymentStatusWhileEnrolled? RefEmploymentStatusWhileEnrolled { get; set; }
    }
}
