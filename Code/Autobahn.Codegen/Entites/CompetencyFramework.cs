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
    [Table("CompetencyFramework")]
    public partial class CompetencyFramework
    {
        public CompetencyFramework()
        {
            CompetencyDefinitions = new HashSet<CompetencyDefinition>();
        }

        [Key]
        public int CompetencyFrameworkId { get; set; }
        [Column("URI")]
        [StringLength(512)]
        public string? Uri { get; set; }
        [StringLength(120)]
        public string? Title { get; set; }
        [StringLength(30)]
        public string? Subject { get; set; }
        [StringLength(30)]
        public string? Version { get; set; }
        [StringLength(120)]
        public string? Creator { get; set; }
        [StringLength(120)]
        public string? Jurisdiction { get; set; }
        [StringLength(300)]
        public string? Description { get; set; }
        [StringLength(30)]
        public string? Publisher { get; set; }
        public int? RefCompetencyFrameworkPublicationStatusId { get; set; }
        [Column(TypeName = "date")]
        public DateTime ValidStartDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime ValidEndDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefLanguageId { get; set; }
        [StringLength(300)]
        public string? License { get; set; }
        [StringLength(300)]
        public string? Rights { get; set; }
        [StringLength(30)]
        public string? RightsHolder { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CompetencyFrameworkPublicationDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? CompetencyFrameworkSourceUrl { get; set; }
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
        [InverseProperty("CompetencyFrameworks")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CompetencyFrameworks")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCompetencyFrameworkPublicationStatusId")]
        [InverseProperty("CompetencyFrameworks")]
        public virtual RefCompetencyFrameworkPublicationStatus? RefCompetencyFrameworkPublicationStatus { get; set; }
        [ForeignKey("RefLanguageId")]
        [InverseProperty("CompetencyFrameworks")]
        public virtual RefLanguage? RefLanguage { get; set; }
        [InverseProperty("CompetencyFramework")]
        public virtual ICollection<CompetencyDefinition> CompetencyDefinitions { get; set; }
    }
}
