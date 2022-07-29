using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsProgram")]
    public partial class PsProgram
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PsProgram()
        {
            PSStudentPrograms = new HashSet<PSStudentProgram>();
        }

        public int PsProgramId { get; set; }

        public int OrganizationId { get; set; }

        public int? RefCipVersionId { get; set; }

        public int? RefCipCodeId { get; set; }

        public decimal? ProgramLengthHours { get; set; }

        public int? RefProgramLengthHoursTypeId { get; set; }

        [StringLength(60)]
        public string NormalLengthTimeForCompletion { get; set; }

        public int? RefTimeForCompletionUnitsId { get; set; }

        public int? RefPSProgramLevelId { get; set; }

        public int? RefDQPCategoriesOfLearningId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCipCode RefCipCode { get; set; }

        public virtual RefCipVersion RefCipVersion { get; set; }

        public virtual RefDQPCategoriesOfLearning RefDQPCategoriesOfLearning { get; set; }

        public virtual RefProgramLengthHoursType RefProgramLengthHoursType { get; set; }

        public virtual RefPSProgramLevel RefPSProgramLevel { get; set; }

        public virtual RefTimeForCompletionUnit RefTimeForCompletionUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PSStudentProgram> PSStudentPrograms { get; set; }
    }
}
