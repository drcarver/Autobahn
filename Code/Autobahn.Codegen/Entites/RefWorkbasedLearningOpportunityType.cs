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
    [Table("RefWorkbasedLearningOpportunityType")]
    public partial class RefWorkbasedLearningOpportunityType
    {
        public RefWorkbasedLearningOpportunityType()
        {
            K12courses = new HashSet<K12course>();
            ProgramParticipationAes = new HashSet<ProgramParticipationAe>();
            ProgramParticipationCtes = new HashSet<ProgramParticipationCte>();
            PsSections = new HashSet<PsSection>();
            PsstudentPrograms = new HashSet<PsstudentProgram>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int RefWorkbasedLearningOpportunityTypeId { get; set; }
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
        [StringLength(4000)]
        public string? Definition { get; set; }
        /// <summary>
        /// Surrogate key from Organization identifying the publisher of the reference value.
        /// </summary>
        public int? RefJurisdictionId { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SortOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }

        [ForeignKey("RefJurisdictionId")]
        [InverseProperty("RefWorkbasedLearningOpportunityTypes")]
        public virtual Organization? RefJurisdiction { get; set; }
        [InverseProperty("RefWorkbasedLearningOpportunityType")]
        public virtual ICollection<K12course> K12courses { get; set; }
        [InverseProperty("RefWorkbasedLearningOpportunityType")]
        public virtual ICollection<ProgramParticipationAe> ProgramParticipationAes { get; set; }
        [InverseProperty("RefWorkbasedLearningOpportunityType")]
        public virtual ICollection<ProgramParticipationCte> ProgramParticipationCtes { get; set; }
        [InverseProperty("RefWorkbasedLearningOpportunityType")]
        public virtual ICollection<PsSection> PsSections { get; set; }
        [InverseProperty("RefWorkbasedLearningOpportunityType")]
        public virtual ICollection<PsstudentProgram> PsstudentPrograms { get; set; }
    }
}
