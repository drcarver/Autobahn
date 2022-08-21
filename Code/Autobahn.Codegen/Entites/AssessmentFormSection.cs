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
    [Table("AssessmentFormSection")]
    public partial class AssessmentFormSection
    {
        public AssessmentFormSection()
        {
            AssessmentFormAssessmentFormSections = new HashSet<AssessmentFormAssessmentFormSection>();
            AssessmentFormSectionAssessmentAssets = new HashSet<AssessmentFormSectionAssessmentAsset>();
            AssessmentFormSectionAssessmentItems = new HashSet<AssessmentFormSectionAssessmentItem>();
            AssessmentParticipantSessions = new HashSet<AssessmentParticipantSession>();
            InverseChildOfFormSection = new HashSet<AssessmentFormSection>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int AssessmentFormSectionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? Identifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefAssessmentFormSectionIdentificationSystemId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? PublishedDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Version { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public TimeSpan? SectionTimeLimit { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? SectionSealed { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? SectionReentry { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? AssessmentItemBankIdentifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? AssessmentItemBankName { get; set; }
        /// <summary>
        /// Foreign key - AssessmentFormSection (this table)
        /// </summary>
        [Column("ChildOf_FormSectionId")]
        public int? ChildOfFormSectionId { get; set; }
        /// <summary>
        /// Foreign key - LearningResource
        /// </summary>
        public int? LearningResourceId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("GUID")]
        [StringLength(40)]
        public string? Guid { get; set; }
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

        [ForeignKey("ChildOfFormSectionId")]
        [InverseProperty("InverseChildOfFormSection")]
        public virtual AssessmentFormSection? ChildOfFormSection { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("AssessmentFormSections")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("LearningResourceId")]
        [InverseProperty("AssessmentFormSections")]
        public virtual LearningResource? LearningResource { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AssessmentFormSections")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAssessmentFormSectionIdentificationSystemId")]
        [InverseProperty("AssessmentFormSections")]
        public virtual RefAssessmentFormSectionIdentificationSystem? RefAssessmentFormSectionIdentificationSystem { get; set; }
        [InverseProperty("AssessmentFormSection")]
        public virtual ICollection<AssessmentFormAssessmentFormSection> AssessmentFormAssessmentFormSections { get; set; }
        [InverseProperty("AssessmentFormSection")]
        public virtual ICollection<AssessmentFormSectionAssessmentAsset> AssessmentFormSectionAssessmentAssets { get; set; }
        [InverseProperty("AssessmentFormSection")]
        public virtual ICollection<AssessmentFormSectionAssessmentItem> AssessmentFormSectionAssessmentItems { get; set; }
        [InverseProperty("AssessmentFormSection")]
        public virtual ICollection<AssessmentParticipantSession> AssessmentParticipantSessions { get; set; }
        [InverseProperty("ChildOfFormSection")]
        public virtual ICollection<AssessmentFormSection> InverseChildOfFormSection { get; set; }
    }
}
