﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("CredentialDefAgentCredential", Schema = "Credentials")]
    [Index("CredentialDefinitionId", "CredentialDefAgentId", Name = "IX_Credential_CredentialCreator", IsUnique = true)]
    public partial class CredentialDefAgentCredential
    {
        [Key]
        public int CredentialDefAgentCredentialId { get; set; }
        public int CredentialDefinitionId { get; set; }
        public int CredentialDefAgentId { get; set; }
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

        [ForeignKey("CredentialDefAgentId")]
        [InverseProperty("CredentialDefAgentCredentials")]
        public virtual CredentialDefAgent CredentialDefAgent { get; set; } = null!;
        [ForeignKey("CredentialDefinitionId")]
        [InverseProperty("CredentialDefAgentCredentials")]
        public virtual CredentialDefinition CredentialDefinition { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CredentialDefAgentCredentials")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CredentialDefAgentCredentials")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
