using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("RefActivityRecognitionType")]
    public partial class RefActivityRecognitionType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefActivityRecognitionType()
        {
            ActivityRecognitions = new HashSet<ActivityRecognition>();
        }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityRecognition> ActivityRecognitions { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
