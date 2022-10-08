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
    [Table("CredentialDefIdentifier", Schema = "Credentials")]
    public partial class CredentialDefIdentifier
    {
        [Key]
        public int CredentialDefIdentifierId { get; set; }
        public int CredentialDefinitionId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? Identifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCredentialIdentifierSystemId { get; set; }
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
        [InverseProperty("CredentialDefIdentifiers")]
        public virtual CredentialDefinition CredentialDefinition { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("CredentialDefIdentifiers")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CredentialDefIdentifiers")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCredentialIdentifierSystemId")]
        [InverseProperty("CredentialDefIdentifiers")]
        public virtual RefCredentialIdentifierSystem? RefCredentialIdentifierSystem { get; set; }
    }
}
