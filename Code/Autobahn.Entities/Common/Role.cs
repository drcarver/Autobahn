//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Role.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("Role", Schema = "Common")]
    public partial class Role : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Role()
        {
            OrganizationPersonRoles = new HashSet<OrganizationPersonRole>();
        }

        [StringLength(50)]
        public string Name { get; set; }

        [ForeignKey("RefRole")]
        public Guid? RefRoleId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationPersonRole> OrganizationPersonRoles { get; set; }

        public virtual RefRole RefRole { get; set; }
    }
}
