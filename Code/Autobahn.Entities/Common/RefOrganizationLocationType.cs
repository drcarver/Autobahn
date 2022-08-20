//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefOrganizationLocationType.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefOrganizationLocationType")]
    public partial class RefOrganizationLocationType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefOrganizationLocationType()
        {
            OrganizationLocations = new HashSet<OrganizationLocation>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationLocation> OrganizationLocations { get; set; }
    }
}
