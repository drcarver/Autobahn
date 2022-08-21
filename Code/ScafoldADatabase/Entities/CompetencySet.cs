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
    [Table("CompetencySet")]
    public partial class CompetencySet
    {
        public CompetencySet()
        {
            CompetencyDefinitionCompetencySets = new HashSet<CompetencyDefinitionCompetencySet>();
            CompetencySetRubricCriteria = new HashSet<CompetencySetRubricCriterion>();
            CompetencySetRubrics = new HashSet<CompetencySetRubric>();
            CredentialDefCriteria = new HashSet<CredentialDefCriterion>();
            Goals = new HashSet<Goal>();
            InverseChildOfCompetencySetNavigation = new HashSet<CompetencySet>();
            ProfessionalDevelopmentRequirements = new HashSet<ProfessionalDevelopmentRequirement>();
        }

        /// <summary>
        /// Surrogate key
        /// </summary>
        [Key]
        public int CompetencySetId { get; set; }
        /// <summary>
        /// Foreign key - CompentencySet (this table)
        /// </summary>
        [Column("ChildOf_CompetencySet")]
        public int? ChildOfCompetencySet { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCompletionCriteriaId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? CompletionCriteriaThreshold { get; set; }
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

        [ForeignKey("ChildOfCompetencySet")]
        [InverseProperty("InverseChildOfCompetencySetNavigation")]
        public virtual CompetencySet? ChildOfCompetencySetNavigation { get; set; }
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CompetencySets")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CompetencySets")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCompletionCriteriaId")]
        [InverseProperty("CompetencySets")]
        public virtual RefCompetencySetCompletionCriterion? RefCompletionCriteria { get; set; }
        [InverseProperty("CompetencySet")]
        public virtual ICollection<CompetencyDefinitionCompetencySet> CompetencyDefinitionCompetencySets { get; set; }
        [InverseProperty("CompetencySet")]
        public virtual ICollection<CompetencySetRubricCriterion> CompetencySetRubricCriteria { get; set; }
        [InverseProperty("CompetencySet")]
        public virtual ICollection<CompetencySetRubric> CompetencySetRubrics { get; set; }
        [InverseProperty("CompetencySet")]
        public virtual ICollection<CredentialDefCriterion> CredentialDefCriteria { get; set; }
        [InverseProperty("CompetencySet")]
        public virtual ICollection<Goal> Goals { get; set; }
        [InverseProperty("ChildOfCompetencySetNavigation")]
        public virtual ICollection<CompetencySet> InverseChildOfCompetencySetNavigation { get; set; }
        [InverseProperty("CompetencySet")]
        public virtual ICollection<ProfessionalDevelopmentRequirement> ProfessionalDevelopmentRequirements { get; set; }
    }
}
