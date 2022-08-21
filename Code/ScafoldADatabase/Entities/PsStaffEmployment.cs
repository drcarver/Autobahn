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
    [Table("PsStaffEmployment")]
    public partial class PsStaffEmployment
    {
        [Key]
        public int PsStaffEmploymentId { get; set; }
        /// <summary>
        /// PK - Foreign key from StaffEmployment
        /// </summary>
        public int StaffEmploymentId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? FacultyStatus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? InstructionalStaffStatus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? MedicalSchoolStaffStatus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? GraduateAssistantStatus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? AnnualBaseContractualSalary { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefFullTimeStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEmploymentContractTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIpedsOccupationalCategoryId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefInstructionalStaffContractLengthId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefInstructionalStaffFacultyTenureId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAcademicRankId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefInstructionCreditTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefGraduateAssistantIpedsCategoryId { get; set; }
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
        [InverseProperty("PsStaffEmployments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PsStaffEmployments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAcademicRankId")]
        [InverseProperty("PsStaffEmployments")]
        public virtual RefAcademicRank? RefAcademicRank { get; set; }
        [ForeignKey("RefEmploymentContractTypeId")]
        [InverseProperty("PsStaffEmployments")]
        public virtual RefEmploymentContractType? RefEmploymentContractType { get; set; }
        [ForeignKey("RefFullTimeStatusId")]
        [InverseProperty("PsStaffEmployments")]
        public virtual RefFullTimeStatus? RefFullTimeStatus { get; set; }
        [ForeignKey("RefGraduateAssistantIpedsCategoryId")]
        [InverseProperty("PsStaffEmployments")]
        public virtual RefGraduateAssistantIpedsCategory? RefGraduateAssistantIpedsCategory { get; set; }
        [ForeignKey("RefInstructionCreditTypeId")]
        [InverseProperty("PsStaffEmployments")]
        public virtual RefInstructionCreditType? RefInstructionCreditType { get; set; }
        [ForeignKey("RefInstructionalStaffContractLengthId")]
        [InverseProperty("PsStaffEmployments")]
        public virtual RefInstructionalStaffContractLength? RefInstructionalStaffContractLength { get; set; }
        [ForeignKey("RefInstructionalStaffFacultyTenureId")]
        [InverseProperty("PsStaffEmployments")]
        public virtual RefInstructionalStaffFacultyTenure? RefInstructionalStaffFacultyTenure { get; set; }
        [ForeignKey("RefIpedsOccupationalCategoryId")]
        [InverseProperty("PsStaffEmployments")]
        public virtual RefIpedsOccupationalCategory? RefIpedsOccupationalCategory { get; set; }
        [ForeignKey("StaffEmploymentId")]
        [InverseProperty("PsStaffEmployments")]
        public virtual StaffEmployment StaffEmployment { get; set; } = null!;
    }
}
