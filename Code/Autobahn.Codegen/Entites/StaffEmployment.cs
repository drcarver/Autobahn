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
    [Table("StaffEmployment")]
    public partial class StaffEmployment
    {
        public StaffEmployment()
        {
            ElstaffEmployments = new HashSet<ElstaffEmployment>();
            K12staffEmployments = new HashSet<K12staffEmployment>();
            PsStaffEmployments = new HashSet<PsStaffEmployment>();
            StaffCompensations = new HashSet<StaffCompensation>();
        }

        /// <summary>
        /// Surrogate key.
        /// </summary>
        [Key]
        public int StaffEmploymentId { get; set; }
        /// <summary>
        /// Foreign key - OrganizationPersonRole.
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? HireDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(45)]
        public string? PositionTitle { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(200)]
        public string? UnionMembershipName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? WeeksEmployedPerYear { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(7)]
        public string? StandardOccupationalClassification { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEmploymentSeparationTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEmploymentSeparationReasonId { get; set; }
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
        [Column(TypeName = "decimal(5, 4)")]
        public decimal? FullTimeEquivalency { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("StaffEmployments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("StaffEmployments")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("StaffEmployments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefEmploymentSeparationReasonId")]
        [InverseProperty("StaffEmployments")]
        public virtual RefEmploymentSeparationReason? RefEmploymentSeparationReason { get; set; }
        [ForeignKey("RefEmploymentSeparationTypeId")]
        [InverseProperty("StaffEmployments")]
        public virtual RefEmploymentSeparationType? RefEmploymentSeparationType { get; set; }
        [InverseProperty("StaffEmployment")]
        public virtual ICollection<ElstaffEmployment> ElstaffEmployments { get; set; }
        [InverseProperty("StaffEmployment")]
        public virtual ICollection<K12staffEmployment> K12staffEmployments { get; set; }
        [InverseProperty("StaffEmployment")]
        public virtual ICollection<PsStaffEmployment> PsStaffEmployments { get; set; }
        [InverseProperty("StaffEmployment")]
        public virtual ICollection<StaffCompensation> StaffCompensations { get; set; }
    }
}
