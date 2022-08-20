//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IReferenceBase.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefDataCollectionStatus", Schema = "Common")]
    public partial class RefDataCollectionStatus : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefDataCollectionStatus()
        {
            DataCollections = new HashSet<DataCollection>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataCollection> DataCollections { get; set; }
    }
}