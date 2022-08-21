//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEducationLevel.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("RefEducationLevel", Schema= "Common")]
    public partial class RefEducationLevel : EntityReferenceBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefEducationLevel()
        {
            CompetencyDefEducationLevels = new HashSet<CompetencyDefEducationLevel>();
            LearningResourceEducationLevels = new HashSet<LearningResourceEducationLevel>();
            PersonDetails = new HashSet<PersonDetail>();
            PersonFamilies = new HashSet<PersonFamily>();
            PsStudentDemographics = new HashSet<PsStudentDemographic>();
            PsStudentDemographics1 = new HashSet<PsStudentDemographic>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencyDefEducationLevel> CompetencyDefEducationLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LearningResourceEducationLevel> LearningResourceEducationLevels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonDetail> PersonDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonFamily> PersonFamilies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PsStudentDemographic> PsStudentDemographics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PsStudentDemographic> PsStudentDemographics1 { get; set; }

        public virtual RefEducationLevelType RefEducationLevelType { get; set; }
    }
}
