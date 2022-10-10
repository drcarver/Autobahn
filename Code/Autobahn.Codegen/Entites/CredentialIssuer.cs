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
    [Table("CredentialIssuer", Schema = "Common")]
    public partial class CredentialIssuer
    {
        public CredentialIssuer()
        {
            CredentialAwards = new HashSet<CredentialAward>();
            CredentialOffereds = new HashSet<CredentialOffered>();
        }

        [Key]
        public int CredentialIssuerId { get; set; }
        public int OrganizationId { get; set; }
        [StringLength(512)]
        public string? AwardIssuerOriginURL { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(512)]
        public string? RevocationListURL { get; set; }
        public int? RefCTDLOrganizationTypeId { get; set; }
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
        [InverseProperty("CredentialIssuers")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("CredentialIssuers")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CredentialIssuers")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCtdlorganizationTypeId")]
        [InverseProperty("CredentialIssuers")]
        public virtual RefCTDLOrganizationType? RefCtdlorganizationType { get; set; }
        [InverseProperty("CredentialIssuer")]
        public virtual ICollection<CredentialAward> CredentialAwards { get; set; }
        [InverseProperty("CredentialIssuer")]
        public virtual ICollection<CredentialOffered> CredentialOffereds { get; set; }
    }
}
