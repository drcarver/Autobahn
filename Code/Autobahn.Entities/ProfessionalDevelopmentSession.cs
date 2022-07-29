using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ProfessionalDevelopmentSession")]
    public partial class ProfessionalDevelopmentSession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProfessionalDevelopmentSession()
        {
            ProfessionalDevelopmentSessionInstructors = new HashSet<ProfessionalDevelopmentSessionInstructor>();
            StaffProfessionalDevelopmentActivities = new HashSet<StaffProfessionalDevelopmentActivity>();
        }

        public int ProfessionalDevelopmentSessionId { get; set; }

        public int ProfessionalDevelopmentActivityId { get; set; }

        [StringLength(40)]
        public string SessionIdentifier { get; set; }

        public int? RefPDDeliveryMethodId { get; set; }

        public int? Capacity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [StringLength(15)]
        public string StartTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [StringLength(15)]
        public string EndTime { get; set; }

        [StringLength(60)]
        public string LocationName { get; set; }

        [StringLength(30)]
        public string EvaluationMethod { get; set; }

        [StringLength(30)]
        public string EvaluationScore { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpirationDate { get; set; }

        public int? RefPDSessionStatusId { get; set; }

        public int? RefPDInstructionalDeliveryModeId { get; set; }

        [StringLength(60)]
        public string SponsoringAgencyName { get; set; }

        public int? RefLanguageId { get; set; }

        [StringLength(30)]
        public string FundingSource { get; set; }

        [StringLength(100)]
        public string TrainingAndTechnicalAssistanceLevel { get; set; }

        public int? RefELTrainerCoreKnowledgeAreaId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual ProfessionalDevelopmentActivity ProfessionalDevelopmentActivity { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }

        public virtual RefPDInstructionalDeliveryMode RefPDInstructionalDeliveryMode { get; set; }

        public virtual RefPDSessionStatu RefPDSessionStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfessionalDevelopmentSessionInstructor> ProfessionalDevelopmentSessionInstructors { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefELTrainerCoreKnowledgeArea RefELTrainerCoreKnowledgeArea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffProfessionalDevelopmentActivity> StaffProfessionalDevelopmentActivities { get; set; }
    }
}
