//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleStatus.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RoleStatus", Schema = "Common")]
    public partial class RoleStatus : EntityReferenceBase
    {
        [Column(TypeName = "date")]
        public DateTime StatusStartDate { get; set; }

        public DateTime? StatusEndDate { get; set; }

        [ForeignKey("RefRoleStatus")]
        public Guid? RefRoleStatusId { get; set; }

        [ForeignKey("OrganizationPersonRole")]
        public Guid OrganizationPersonRoleId { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RefRoleStatus RefRoleStatus { get; set; }
    }
}
