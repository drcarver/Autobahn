namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("K12TitleIIILanguageInstruction", Schema = "K12")]
    [Index("OrganizationId", "RefTitleIiilanguageInstructionProgramTypeId", Name = "IX_K12LeaTitleIIILanguageInstruction", IsUnique = true)]
    public partial class K12TitleIIILanguageInstruction
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int K12TitleIIILanguageInstructionId { get; set; }
        /// <summary>
        /// Foreign key - Organization
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefTitleIIILanguageInstructionProgramTypeId { get; set; }
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
        public virtual RefTitleIIILanguageInstructionProgramType RefTitleIiilanguageInstructionProgramType { get; set; } = null!;
    }
}
