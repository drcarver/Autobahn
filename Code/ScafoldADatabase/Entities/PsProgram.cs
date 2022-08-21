﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("PsProgram")]
    public partial class PsProgram
    {
        public PsProgram()
        {
            PsstudentPrograms = new HashSet<PsstudentProgram>();
        }

        /// <summary>
        /// Surrogate key
        /// </summary>
        [Key]
        public int PsProgramId { get; set; }
        /// <summary>
        /// Foreign key - Organization
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCipVersionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCipCodeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? ProgramLengthHours { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefProgramLengthHoursTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? NormalLengthTimeForCompletion { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefTimeForCompletionUnitsId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefPSProgramLevelId")]
        public int? RefPsprogramLevelId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefDQPCategoriesOfLearningId")]
        public int? RefDqpcategoriesOfLearningId { get; set; }
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
        [InverseProperty("PsPrograms")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("PsPrograms")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PsPrograms")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCipCodeId")]
        [InverseProperty("PsPrograms")]
        public virtual RefCipCode? RefCipCode { get; set; }
        [ForeignKey("RefCipVersionId")]
        [InverseProperty("PsPrograms")]
        public virtual RefCipVersion? RefCipVersion { get; set; }
        [ForeignKey("RefDqpcategoriesOfLearningId")]
        [InverseProperty("PsPrograms")]
        public virtual RefDqpcategoriesOfLearning? RefDqpcategoriesOfLearning { get; set; }
        [ForeignKey("RefProgramLengthHoursTypeId")]
        [InverseProperty("PsPrograms")]
        public virtual RefProgramLengthHoursType? RefProgramLengthHoursType { get; set; }
        [ForeignKey("RefPsprogramLevelId")]
        [InverseProperty("PsPrograms")]
        public virtual RefPsprogramLevel? RefPsprogramLevel { get; set; }
        [ForeignKey("RefTimeForCompletionUnitsId")]
        [InverseProperty("PsPrograms")]
        public virtual RefTimeForCompletionUnit? RefTimeForCompletionUnits { get; set; }
        [InverseProperty("PsProgram")]
        public virtual ICollection<PsstudentProgram> PsstudentPrograms { get; set; }
    }
}
