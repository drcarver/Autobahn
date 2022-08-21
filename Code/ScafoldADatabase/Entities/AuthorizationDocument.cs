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
    [Table("AuthorizationDocument")]
    public partial class AuthorizationDocument
    {
        public AuthorizationDocument()
        {
            Iepauthorizations = new HashSet<Iepauthorization>();
        }

        [Key]
        public int AuthorizationDocumentId { get; set; }
        public int OrganizationPersonRoleId { get; set; }
        public bool? AcceptanceIndicator { get; set; }
        [Column(TypeName = "date")]
        public DateTime? AuthorizationDate { get; set; }
        public string? DecisionExplanation { get; set; }
        public int? RefAuthorizerTypeId { get; set; }
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
        [InverseProperty("AuthorizationDocuments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("AuthorizationDocuments")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("AuthorizationDocuments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefAuthorizerTypeId")]
        [InverseProperty("AuthorizationDocuments")]
        public virtual RefAuthorizerType? RefAuthorizerType { get; set; }
        [InverseProperty("AuthorizationDocument")]
        public virtual ICollection<Iepauthorization> Iepauthorizations { get; set; }
    }
}
