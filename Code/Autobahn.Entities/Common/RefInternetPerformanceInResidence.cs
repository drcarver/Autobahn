//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   AutobahnCommonContext.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefInternetPerformanceInResidence", Schema = "Common")]
    public partial class RefInternetPerformanceInResidence : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefInternetPerformanceInResidence()
        {
            PersonDigitalAccesses = new HashSet<PersonDigitalAccess>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonDigitalAccess> PersonDigitalAccesses { get; set; }
    }
}
