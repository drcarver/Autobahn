//**********************************************************
//* DomainName: Autobahn.LearningResources
//* FileName:   RefLearnerActivityMaximumTimeAllowedUnit.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.LearningResources
{
    [Table("RefLearnerActivityMaximumTimeAllowedUnit")]
    public partial class RefLearnerActivityMaximumTimeAllowedUnit : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefLearnerActivityMaximumTimeAllowedUnit()
        {
            LearnerActivities = new HashSet<LearnerActivity>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearnerActivity> LearnerActivities { get; set; }
    }
}
