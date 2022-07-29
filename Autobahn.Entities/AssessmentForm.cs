using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentForm")]
    public partial class AssessmentForm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentForm()
        {
            AssessmentForm_AssessmentAsset = new HashSet<AssessmentForm_AssessmentAsset>();
            AssessmentForm_AssessmentFormSection = new HashSet<AssessmentForm_AssessmentFormSection>();
            AssessmentRegistrations = new HashSet<AssessmentRegistration>();
            AssessmentSubtests = new HashSet<AssessmentSubtest>();
        }

        public int AssessmentFormId { get; set; }

        public int AssessmentId { get; set; }

        [StringLength(30)]
        public string FormNumber { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Version { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PublishedDate { get; set; }

        public string AccommodationList { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IntendedAdministrationStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IntendedAdministrationEndDate { get; set; }

        [StringLength(40)]
        public string AssessmentItemBankIdentifier { get; set; }

        [StringLength(60)]
        public string AssessmentItemBankName { get; set; }

        public string PlatformsSupported { get; set; }

        public int? RefAssessmentLanguageId { get; set; }

        public bool? AssessmentSecureIndicator { get; set; }

        public int? LearningResourceId { get; set; }

        public bool? AssessmentFormAdaptiveIndicator { get; set; }

        [StringLength(40)]
        public string AssessmentFormAlgorithmIdentifier { get; set; }

        [StringLength(40)]
        public string AssessmentFormAlgorithmVersion { get; set; }

        [StringLength(40)]
        public string AssessmentFormGUID { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual Assessment Assessment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentForm_AssessmentAsset> AssessmentForm_AssessmentAsset { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentForm_AssessmentFormSection> AssessmentForm_AssessmentFormSection { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual LearningResource LearningResource { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentRegistration> AssessmentRegistrations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSubtest> AssessmentSubtests { get; set; }
    }
}
