using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CompetencySet")]
    public partial class CompetencySet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompetencySet()
        {
            CompetencyDefinitionCompetencySet = new HashSet<CompetencyDefinitionCompetencySet>();
            CompetencySet1 = new HashSet<CompetencySet>();
            CompetencySetRubric = new HashSet<CompetencySetRubric>();
            CompetencySetRubricCriterion = new HashSet<CompetencySetRubricCriterion>();
            CredentialDefCriterias = new HashSet<CredentialDefCriteria>();
            Goals = new HashSet<Goal>();
            ProfessionalDevelopmentRequirements = new HashSet<ProfessionalDevelopmentRequirement>();
        }

        public int CompetencySetId { get; set; }

        public int? ChildOfCompetencySet { get; set; }

        public int? RefCompletionCriteriaId { get; set; }

        public int? CompletionCriteriaThreshold { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencyDefinitionCompetencySet> CompetencyDefinitionCompetencySet { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencySet> CompetencySet1 { get; set; }

        public virtual CompetencySet CompetencySet2 { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCompetencySetCompletionCriteria RefCompetencySetCompletionCriteria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencySetRubric> CompetencySetRubric { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencySetRubricCriterion> CompetencySetRubricCriterion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredentialDefCriteria> CredentialDefCriterias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goal> Goals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfessionalDevelopmentRequirement> ProfessionalDevelopmentRequirements { get; set; }
    }
}
