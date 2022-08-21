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
    [Table("CredentialOffered")]
    [Index("CredentialDefinitionId", "CredentialIssuerId", Name = "IX_Credential_CredentialIssuer", IsUnique = true)]
    public partial class CredentialOffered
    {
        [Key]
        public int CredentialOfferedId { get; set; }
        public int CredentialDefinitionId { get; set; }
        public int CredentialIssuerId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? CredentialOfferedStartDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? CredentialOfferedEndDate { get; set; }
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

        [ForeignKey("CredentialDefinitionId")]
        [InverseProperty("CredentialOffereds")]
        public virtual CredentialDefinition CredentialDefinition { get; set; } = null!;
        [ForeignKey("CredentialIssuerId")]
        [InverseProperty("CredentialOffereds")]
        public virtual CredentialIssuer CredentialIssuer { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CredentialOffereds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CredentialOffereds")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
