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
    [Table("ELClassSection", Schema = "EarlyLearning")]
    public partial class ELClassSection
    {
        public ELClassSection()
        {
            ElclassSectionServices = new HashSet<ELClassSectionService>();
            Elenrollments = new HashSet<ELEnrollment>();
        }

        [Key]
        public int ELClassSectionId { get; set; }
        /// <summary>
        /// Surrogate key from Organization
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? HoursAvailablePerDay { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? DaysAvailablePerWeek { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? ELProgramAnnualOperatingWeeks { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? LanguageTranslationPolicy { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? GroupSize { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefServiceOptionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEnvironmentSettingId { get; set; }
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
        [InverseProperty("ElclassSections")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("ElclassSections")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ElclassSections")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefEnvironmentSettingId")]
        [InverseProperty("ElclassSections")]
        public virtual RefEnvironmentSetting? RefEnvironmentSetting { get; set; }
        [ForeignKey("RefServiceOptionId")]
        [InverseProperty("ElclassSections")]
        public virtual RefServiceOption? RefServiceOption { get; set; }
        [InverseProperty("ElclassSection")]
        public virtual ICollection<ELClassSectionService> ElclassSectionServices { get; set; }
        [InverseProperty("ElclassSection")]
        public virtual ICollection<ELEnrollment> Elenrollments { get; set; }
    }
}
