using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RefDataCollectionStatus")]
    public partial class RefDataCollectionStatus : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefDataCollectionStatus()
        {
            DataCollections = new HashSet<DataCollection>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataCollection> DataCollections { get; set; }

        public virtual Organization Organization { get; set; }
    }
}