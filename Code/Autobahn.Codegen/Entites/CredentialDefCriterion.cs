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
    [Table("CredentialDefCriterion")]
    public partial class CredentialDefCriterion
    {
        public CredentialDefCriterion()
        {
            CredentialCriteriaCourses = new HashSet<CredentialCriteriaCourse>();
        }

        [Key]
        public int CredentialDefCriteriaId { get; set; }
        public int CredentialDefinitionId { get; set; }
        public int? CompetencySetId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? Criteria { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? CriteriaUrl { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(5)]
        [Unicode(false)]
        public string? EstimatedDuration { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(5)]
        [Unicode(false)]
        public string? MaximumDuration { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? MinimumAge { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(5)]
        [Unicode(false)]
        public string? MinimumDuration { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCredentialDefAssessMethodTypeId { get; set; }
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

        [ForeignKey("CompetencySetId")]
        [InverseProperty("CredentialDefCriteria")]
        public virtual CompetencySet? CompetencySet { get; set; }
        [ForeignKey("CredentialDefinitionId")]
        [InverseProperty("CredentialDefCriteria")]
        public virtual CredentialDefinition CredentialDefinition { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CredentialDefCriteria")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CredentialDefCriteria")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCredentialDefAssessMethodTypeId")]
        [InverseProperty("CredentialDefCriteria")]
        public virtual RefCredentialDefAssessMethodType? RefCredentialDefAssessMethodType { get; set; }
        [InverseProperty("CredentialDefCriteria")]
        public virtual ICollection<CredentialCriteriaCourse> CredentialCriteriaCourses { get; set; }
    }
}
