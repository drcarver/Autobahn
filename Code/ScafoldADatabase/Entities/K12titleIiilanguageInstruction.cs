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
    [Table("K12TitleIIILanguageInstruction")]
    [Index("OrganizationId", "RefTitleIiilanguageInstructionProgramTypeId", Name = "IX_K12LeaTitleIIILanguageInstruction", IsUnique = true)]
    public partial class K12titleIiilanguageInstruction
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        [Column("K12TitleIIILanguageInstructionId")]
        public int K12titleIiilanguageInstructionId { get; set; }
        /// <summary>
        /// Foreign key - Organization
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefTitleIIILanguageInstructionProgramTypeId")]
        public int RefTitleIiilanguageInstructionProgramTypeId { get; set; }
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
        [InverseProperty("K12titleIiilanguageInstructions")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("K12titleIiilanguageInstructions")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12titleIiilanguageInstructions")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefTitleIiilanguageInstructionProgramTypeId")]
        [InverseProperty("K12titleIiilanguageInstructions")]
        public virtual RefTitleIiilanguageInstructionProgramType RefTitleIiilanguageInstructionProgramType { get; set; } = null!;
    }
}
