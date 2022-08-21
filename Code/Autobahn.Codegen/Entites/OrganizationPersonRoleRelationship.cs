using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("OrganizationPersonRoleRelationship")]
    public partial class OrganizationPersonRoleRelationship
    {
        [Key]
        public int OrganizationPersonRoleRelationshipId { get; set; }
        public int OrganizationPersonRoleId { get; set; }
        [Column("OrganizationPersonRoleId_Parent")]
        public int OrganizationPersonRoleIdParent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("OrganizationPersonRoleRelationships")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("OrganizationPersonRoleRelationshipOrganizationPersonRoles")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("OrganizationPersonRoleIdParent")]
        [InverseProperty("OrganizationPersonRoleRelationshipOrganizationPersonRoleIdParentNavigations")]
        public virtual OrganizationPersonRole OrganizationPersonRoleIdParentNavigation { get; set; } = null!;
    }
}
