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
    [Table("CredentialAward", Schema = "Postsecondary")]
    public partial class CredentialAward
    {
        public CredentialAward()
        {
            CredentialAwardCredits = new HashSet<CredentialAwardCredit>();
            CredentialAwardEvidences = new HashSet<CredentialAwardEvidence>();
        }

        [Key]
        public int CredentialAwardId { get; set; }
        public int CredentialDefinitionId { get; set; }
        public int CredentialIssuerId { get; set; }
        public int? PersonId { get; set; }
        public string? AdvancedStandingDescription { get; set; }
        [StringLength(512)]
        public string? AdvancedStandingURL { get; set; }
        [StringLength(300)]
        public string? ApproverName { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CompletionDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? CredentialAwardEndDate { get; set; }
        [StringLength(512)]
        public string? EvidenceURL { get; set; }
        [Column(TypeName = "date")]
        public DateTime? RevokedDate { get; set; }
        public bool? RevokedIndicator { get; set; }
        public string? RevokedReason { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? CredentialAwardStartDate { get; set; }
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
        public int? OrganizationId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("CredentialDefinitionId")]
        [InverseProperty("CredentialAwards")]
        public virtual CredentialDefinition CredentialDefinition { get; set; } = null!;
        [ForeignKey("CredentialIssuerId")]
        [InverseProperty("CredentialAwards")]
        public virtual CredentialIssuer CredentialIssuer { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CredentialAwards")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("CredentialAwards")]
        public virtual Organization? Organization { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("CredentialAwards")]
        public virtual Person? Person { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CredentialAwards")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("CredentialAward")]
        public virtual ICollection<CredentialAwardCredit> CredentialAwardCredits { get; set; }
        [InverseProperty("CredentialAward")]
        public virtual ICollection<CredentialAwardEvidence> CredentialAwardEvidences { get; set; }
    }
}
