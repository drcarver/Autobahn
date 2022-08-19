using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("Assessment")]
    public partial class Assessment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Assessment()
        {
            AssessmentAssessmentAdministration = new HashSet<AssessmentAssessmentAdministration>();
            AssessmentELDevelopmentalDomains = new HashSet<AssessmentELDevelopmentalDomain>();
            AssessmentLevelsForWhichDesigneds = new HashSet<AssessmentLevelsForWhichDesigned>();
            AssessmentForms = new HashSet<AssessmentForm>();
            AssessmentLanguages = new HashSet<AssessmentLanguage>();
            IndividualizedProgramAssessments = new HashSet<IndividualizedProgramAssessment>();
        }

        public int AssessmentId { get; set; }

        [StringLength(40)]
        public string Identifier { get; set; }

        public int? IdentificationSystem { get; set; }

        [StringLength(40)]
        public string GUID { get; set; }

        [StringLength(60)]
        public string Title { get; set; }

        [StringLength(30)]
        public string ShortName { get; set; }

        public int RefAcademicSubjectId { get; set; }

        [StringLength(100)]
        public string Objective { get; set; }

        [StringLength(30)]
        public string Provider { get; set; }

        public int? RefAssessmentPurposeId { get; set; }

        public int? RefAssessmentTypeId { get; set; }

        public int? RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AssessmentRevisionDate { get; set; }

        [Required]
        [StringLength(60)]
        public string AssessmentFamilyTitle { get; set; }

        [StringLength(30)]
        public string AssessmentFamilyShortName { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentAssessmentAdministration> AssessmentAssessmentAdministration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentELDevelopmentalDomain> AssessmentELDevelopmentalDomains { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentLevelsForWhichDesigned> AssessmentLevelsForWhichDesigneds { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentPurpose RefAssessmentPurpose { get; set; }

        public virtual RefAssessmentType RefAssessmentType { get; set; }

        public virtual RefAssessmentTypeChildrenWithDisability RefAssessmentTypeChildrenWithDisability { get; set; }

        public virtual RefAcademicSubject RefAcademicSubject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentForm> AssessmentForms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentLanguage> AssessmentLanguages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramAssessment> IndividualizedProgramAssessments { get; set; }
    }
}
