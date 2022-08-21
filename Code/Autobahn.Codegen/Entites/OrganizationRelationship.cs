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
    [Table("OrganizationRelationship")]
    public partial class OrganizationRelationship
    {
        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int OrganizationRelationshipId { get; set; }
        /// <summary>
        /// Foreign key - Organization
        /// </summary>
        [Column("Parent_OrganizationId")]
        public int ParentOrganizationId { get; set; }
        /// <summary>
        /// Foreign key - Organization
        /// </summary>
        public int OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefOrganizationRelationshipId { get; set; }
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
        [InverseProperty("OrganizationRelationships")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("OrganizationRelationshipOrganizations")]
        public virtual Organization Organization { get; set; } = null!;
        [ForeignKey("ParentOrganizationId")]
        [InverseProperty("OrganizationRelationshipParentOrganizations")]
        public virtual Organization ParentOrganization { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("OrganizationRelationships")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefOrganizationRelationshipId")]
        [InverseProperty("OrganizationRelationships")]
        public virtual RefOrganizationRelationship? RefOrganizationRelationship { get; set; }
    }
}
