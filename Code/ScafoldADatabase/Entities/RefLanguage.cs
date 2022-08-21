using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
    /// </summary>
    [Table("RefLanguage")]
    public partial class RefLanguage
    {
        public RefLanguage()
        {
            AssessmentAssets = new HashSet<AssessmentAsset>();
            AssessmentForms = new HashSet<AssessmentForm>();
            AssessmentItemApipDescriptions = new HashSet<AssessmentItemApipDescription>();
            AssessmentLanguages = new HashSet<AssessmentLanguage>();
            AssessmentNeedApipContentItemTranslationDisplayLanguageTypes = new HashSet<AssessmentNeedApipContent>();
            AssessmentNeedApipContentKeywordTranslationLanguageTypes = new HashSet<AssessmentNeedApipContent>();
            AssessmentParticipantSessions = new HashSet<AssessmentParticipantSession>();
            AssessmentPersonalNeedsProfileContents = new HashSet<AssessmentPersonalNeedsProfileContent>();
            CompetencyDefinitions = new HashSet<CompetencyDefinition>();
            CompetencyFrameworks = new HashSet<CompetencyFramework>();
            CourseSections = new HashSet<CourseSection>();
            Courses = new HashSet<Course>();
            LearningResources = new HashSet<LearningResource>();
            PersonLanguages = new HashSet<PersonLanguage>();
            ProfessionalDevelopmentSessions = new HashSet<ProfessionalDevelopmentSession>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefLanguageId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(150)]
        public string Description { get; set; } = null!;
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [StringLength(50)]
        public string? Code { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public string? Definition { get; set; }
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefLanguages")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefAssessmentLanguage")]
        public virtual ICollection<AssessmentAsset> AssessmentAssets { get; set; }
        [InverseProperty("RefAssessmentLanguage")]
        public virtual ICollection<AssessmentForm> AssessmentForms { get; set; }
        [InverseProperty("RefKeywordTranslationLanguage")]
        public virtual ICollection<AssessmentItemApipDescription> AssessmentItemApipDescriptions { get; set; }
        [InverseProperty("RefLanguage")]
        public virtual ICollection<AssessmentLanguage> AssessmentLanguages { get; set; }
        [InverseProperty("ItemTranslationDisplayLanguageType")]
        public virtual ICollection<AssessmentNeedApipContent> AssessmentNeedApipContentItemTranslationDisplayLanguageTypes { get; set; }
        [InverseProperty("KeywordTranslationLanguageType")]
        public virtual ICollection<AssessmentNeedApipContent> AssessmentNeedApipContentKeywordTranslationLanguageTypes { get; set; }
        [InverseProperty("RefLanguage")]
        public virtual ICollection<AssessmentParticipantSession> AssessmentParticipantSessions { get; set; }
        [InverseProperty("RefKeywordTranslationsLanguage")]
        public virtual ICollection<AssessmentPersonalNeedsProfileContent> AssessmentPersonalNeedsProfileContents { get; set; }
        [InverseProperty("RefLanguage")]
        public virtual ICollection<CompetencyDefinition> CompetencyDefinitions { get; set; }
        [InverseProperty("RefLanguage")]
        public virtual ICollection<CompetencyFramework> CompetencyFrameworks { get; set; }
        [InverseProperty("RefInstructionLanguage")]
        public virtual ICollection<CourseSection> CourseSections { get; set; }
        [InverseProperty("RefInstructionLanguage")]
        public virtual ICollection<Course> Courses { get; set; }
        [InverseProperty("RefLanguage")]
        public virtual ICollection<LearningResource> LearningResources { get; set; }
        [InverseProperty("RefLanguage")]
        public virtual ICollection<PersonLanguage> PersonLanguages { get; set; }
        [InverseProperty("RefLanguage")]
        public virtual ICollection<ProfessionalDevelopmentSession> ProfessionalDevelopmentSessions { get; set; }
    }
}
