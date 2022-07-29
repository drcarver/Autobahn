using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("Incident")]
    public partial class Incident
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Incident()
        {
            IncidentPersons = new HashSet<IncidentPerson>();
            K12StudentDiscipline = new HashSet<K12StudentDiscipline>();
        }

        public int IncidentId { get; set; }

        [StringLength(40)]
        public string IncidentIdentifier { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IncidentDate { get; set; }

        public TimeSpan? IncidentTime { get; set; }

        public int? RefIncidentTimeDescriptionCodeId { get; set; }

        public string IncidentDescription { get; set; }

        public int? RefIncidentBehaviorId { get; set; }

        public int? RefIncidentBehaviorSecondaryId { get; set; }

        public int? RefIncidentInjuryTypeId { get; set; }

        public int? RefWeaponTypeId { get; set; }

        [StringLength(30)]
        public string IncidentCost { get; set; }

        public int? OrganizationPersonRoleId { get; set; }

        public int? IncidentReporterId { get; set; }

        public int? RefIncidentReporterTypeId { get; set; }

        public int? RefIncidentLocationId { get; set; }

        public int? RefFirearmTypeId { get; set; }

        [StringLength(100)]
        public string RegulationViolatedDescription { get; set; }

        public bool? RelatedToDisabilityManifestationInd { get; set; }

        public bool? ReportedToLawEnforcementInd { get; set; }

        public int? RefIncidentMultipleOffenseTypeId { get; set; }

        public int? RefIncidentPerpetratorInjuryTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefFirearmType RefFirearmType { get; set; }

        public virtual RefIncidentInjuryType RefIncidentInjuryType { get; set; }

        public virtual RefIncidentLocation RefIncidentLocation { get; set; }

        public virtual RefIncidentMultipleOffenseType RefIncidentMultipleOffenseType { get; set; }

        public virtual RefIncidentPerpetratorInjuryType RefIncidentPerpetratorInjuryType { get; set; }

        public virtual RefIncidentReporterType RefIncidentReporterType { get; set; }

        public virtual RefIncidentTimeDescriptionCode RefIncidentTimeDescriptionCode { get; set; }

        public virtual RefIncidentBehavior RefIncidentBehavior { get; set; }

        public virtual RefIncidentBehaviorSecondary RefIncidentBehaviorSecondary { get; set; }

        public virtual RefWeaponType RefWeaponType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncidentPerson> IncidentPersons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12StudentDiscipline> K12StudentDiscipline { get; set; }
    }
}
