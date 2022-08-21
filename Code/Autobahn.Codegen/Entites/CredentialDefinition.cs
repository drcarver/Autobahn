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
    [Table("CredentialDefinition")]
    public partial class CredentialDefinition
    {
        public CredentialDefinition()
        {
            CredentialAwards = new HashSet<CredentialAward>();
            CredentialDefAgentCredentials = new HashSet<CredentialDefAgentCredential>();
            CredentialDefCategories = new HashSet<CredentialDefCategory>();
            CredentialDefCriteria = new HashSet<CredentialDefCriterion>();
            CredentialDefIdentifiers = new HashSet<CredentialDefIdentifier>();
            CredentialOffereds = new HashSet<CredentialOffered>();
        }

        [Key]
        public int CredentialDefinitionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? AlternateName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("CredentialNAICSIndustryType")]
        [StringLength(6)]
        public string? CredentialNaicsindustryType { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? Description { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("EmploymentNAICSCode")]
        [StringLength(6)]
        public string? EmploymentNaicscode { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? ImageUrl { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(2000)]
        public string? JurisdictionRegion { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(2000)]
        public string? JurisdictionRegionException { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? Keywords { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(300)]
        public string? Title { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public string? ValidationMethodDescription { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? Version { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? CredentialDefDateEffective { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCareerClusterId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCipCodeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCredentialDefIntendedPurposeTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCredentialDefStatusTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCredentialDefVerificationTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefONETSOCOccupationTypeId")]
        public int? RefOnetsococcupationTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefCTDLAudienceLevelTypeId")]
        public int? RefCtdlaudienceLevelTypeId { get; set; }
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
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? CredentialDefinitionTerminalDegreeIndicator { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("CredentialDefinitions")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CredentialDefinitions")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCareerClusterId")]
        [InverseProperty("CredentialDefinitions")]
        public virtual RefCareerCluster? RefCareerCluster { get; set; }
        [ForeignKey("RefCipCodeId")]
        [InverseProperty("CredentialDefinitions")]
        public virtual RefCipCode? RefCipCode { get; set; }
        [ForeignKey("RefCredentialDefIntendedPurposeTypeId")]
        [InverseProperty("CredentialDefinitions")]
        public virtual RefCredentialDefIntendedPurposeType? RefCredentialDefIntendedPurposeType { get; set; }
        [ForeignKey("RefCredentialDefStatusTypeId")]
        [InverseProperty("CredentialDefinitions")]
        public virtual RefCredentialDefStatusType? RefCredentialDefStatusType { get; set; }
        [ForeignKey("RefCredentialDefVerificationTypeId")]
        [InverseProperty("CredentialDefinitions")]
        public virtual RefCredentialDefVerificationType? RefCredentialDefVerificationType { get; set; }
        [ForeignKey("RefCtdlaudienceLevelTypeId")]
        [InverseProperty("CredentialDefinitions")]
        public virtual RefCtdlaudienceLevelType? RefCtdlaudienceLevelType { get; set; }
        [ForeignKey("RefOnetsococcupationTypeId")]
        [InverseProperty("CredentialDefinitions")]
        public virtual RefOnetsococcupationType? RefOnetsococcupationType { get; set; }
        [InverseProperty("CredentialDefinition")]
        public virtual ICollection<CredentialAward> CredentialAwards { get; set; }
        [InverseProperty("CredentialDefinition")]
        public virtual ICollection<CredentialDefAgentCredential> CredentialDefAgentCredentials { get; set; }
        [InverseProperty("CredentialDefinition")]
        public virtual ICollection<CredentialDefCategory> CredentialDefCategories { get; set; }
        [InverseProperty("CredentialDefinition")]
        public virtual ICollection<CredentialDefCriterion> CredentialDefCriteria { get; set; }
        [InverseProperty("CredentialDefinition")]
        public virtual ICollection<CredentialDefIdentifier> CredentialDefIdentifiers { get; set; }
        [InverseProperty("CredentialDefinition")]
        public virtual ICollection<CredentialOffered> CredentialOffereds { get; set; }
    }
}
