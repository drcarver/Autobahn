//**********************************************************
//* DomainName: Autobahn.LearningResources
//* FileName:   RefLearnerActivityType.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.LearningResources
{
    [Table("RefLearnerActivityType")]
    public partial class RefLearnerActivityType : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefLearnerActivityType()
        {
            LearnerActivities = new HashSet<LearnerActivity>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearnerActivity> LearnerActivities { get; set; }
    }
}
