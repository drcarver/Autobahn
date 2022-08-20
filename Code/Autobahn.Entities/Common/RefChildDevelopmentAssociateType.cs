//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefChildDevelopmentAssociateType.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Entities.EarlyLearning;

namespace Autobahn.Entities.Common
{
    [Table("RefChildDevelopmentAssociateType")]
    public partial class RefChildDevelopmentAssociateType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefChildDevelopmentAssociateType()
        {
            ELStaffs = new HashSet<ELStaff>();
            StaffCredentials = new HashSet<StaffCredential>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELStaff> ELStaffs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffCredential> StaffCredentials { get; set; }
    }
}
