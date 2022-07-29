using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CompetencySet")]
    public partial class CompetencySet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompetencySet()
        {
            CompetencyDefinition_CompetencySet = new HashSet<CompetencyDefinition_CompetencySet>();
            CompetencySet1 = new HashSet<CompetencySet>();
            CompetencySet_Rubric = new HashSet<CompetencySet_Rubric>();
            CompetencySet_RubricCriterion = new HashSet<CompetencySet_RubricCriterion>();
            CredentialDefCriterias = new HashSet<CredentialDefCriteria>();
            Goals = new HashSet<Goal>();
            ProfessionalDevelopmentRequirements = new HashSet<ProfessionalDevelopmentRequirement>();
        }

        public int CompetencySetId { get; set; }

        public int? ChildOf_CompetencySet { get; set; }

        public int? RefCompletionCriteriaId { get; set; }

        public int? CompletionCriteriaThreshold { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencyDefinition_CompetencySet> CompetencyDefinition_CompetencySet { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencySet> CompetencySet1 { get; set; }

        public virtual CompetencySet CompetencySet2 { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCompetencySetCompletionCriteria RefCompetencySetCompletionCriteria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencySet_Rubric> CompetencySet_Rubric { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencySet_RubricCriterion> CompetencySet_RubricCriterion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialDefCriteria> CredentialDefCriterias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goal> Goals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfessionalDevelopmentRequirement> ProfessionalDevelopmentRequirements { get; set; }
    }
}
