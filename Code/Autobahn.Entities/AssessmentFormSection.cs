using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("AssessmentFormSection")]
    public partial class AssessmentFormSection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssessmentFormSection()
        {
            AssessmentForm_AssessmentFormSection = new HashSet<AssessmentForm_AssessmentFormSection>();
            AssessmentFormSection_AssessmentAsset = new HashSet<AssessmentFormSection_AssessmentAsset>();
            AssessmentFormSection_AssessmentItem = new HashSet<AssessmentFormSection_AssessmentItem>();
            AssessmentParticipantSessions = new HashSet<AssessmentParticipantSession>();
            AssessmentFormSection1 = new HashSet<AssessmentFormSection>();
        }

        public int AssessmentFormSectionId { get; set; }

        [StringLength(40)]
        public string Identifier { get; set; }

        public int? RefAssessmentFormSectionIdentificationSystemId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PublishedDate { get; set; }

        [StringLength(30)]
        public string Version { get; set; }

        public TimeSpan? SectionTimeLimit { get; set; }

        public bool? SectionSealed { get; set; }

        public bool? SectionReentry { get; set; }

        [StringLength(40)]
        public string AssessmentItemBankIdentifier { get; set; }

        [StringLength(60)]
        public string AssessmentItemBankName { get; set; }

        public int? ChildOf_FormSectionId { get; set; }

        public int? LearningResourceId { get; set; }

        [StringLength(40)]
        public string GUID { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentForm_AssessmentFormSection> AssessmentForm_AssessmentFormSection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentFormSection_AssessmentAsset> AssessmentFormSection_AssessmentAsset { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentFormSection_AssessmentItem> AssessmentFormSection_AssessmentItem { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual LearningResource LearningResource { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAssessmentFormSectionIdentificationSystem RefAssessmentFormSectionIdentificationSystem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentParticipantSession> AssessmentParticipantSessions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentFormSection> AssessmentFormSection1 { get; set; }

        public virtual AssessmentFormSection AssessmentFormSection2 { get; set; }
    }
}
