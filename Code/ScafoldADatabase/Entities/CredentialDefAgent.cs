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
    [Table("CredentialDefAgent")]
    public partial class CredentialDefAgent
    {
        public CredentialDefAgent()
        {
            CredentialDefAgentCredentials = new HashSet<CredentialDefAgentCredential>();
        }

        [Key]
        public int CredentialDefAgentId { get; set; }
        public int? OrganizationId { get; set; }
        public int? PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefCTDLOrganizationTypeId")]
        public int? RefCtdlorganizationTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCredentialDefAgentRoleTypeId { get; set; }
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
        [InverseProperty("CredentialDefAgents")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("CredentialDefAgents")]
        public virtual Organization? Organization { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("CredentialDefAgents")]
        public virtual Person? Person { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("CredentialDefAgents")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCredentialDefAgentRoleTypeId")]
        [InverseProperty("CredentialDefAgents")]
        public virtual RefCredentialDefAgentRoleType? RefCredentialDefAgentRoleType { get; set; }
        [ForeignKey("RefCtdlorganizationTypeId")]
        [InverseProperty("CredentialDefAgents")]
        public virtual RefCtdlorganizationType? RefCtdlorganizationType { get; set; }
        [InverseProperty("CredentialDefAgent")]
        public virtual ICollection<CredentialDefAgentCredential> CredentialDefAgentCredentials { get; set; }
    }
}
