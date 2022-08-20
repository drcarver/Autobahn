//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefEarlyChildhoodCredential.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.EarlyLearning
{
    [Table("RefEarlyChildhoodCredential", Schema = "EarlyLearning")]
    public partial class RefEarlyChildhoodCredential : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefEarlyChildhoodCredential()
        {
            EarlyChildhoodCredentials = new HashSet<EarlyChildhoodCredential>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EarlyChildhoodCredential> EarlyChildhoodCredentials { get; set; }
    }
}
