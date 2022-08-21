//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDetail.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("PersonDetail", Schema = "Common")]
    public partial class PersonDetail : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonDetail()
        {
            PersonPersonalInformationVerifications = new HashSet<PersonPersonalInformationVerification>();
        }

        [ForeignKey("Person")]
        public Guid PersonId { get; set; }

        [StringLength(75)]
        public string FirstName { get; set; }

        [StringLength(75)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(75)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string GenerationCode { get; set; }

        [StringLength(30)]
        public string Prefix { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthdate { get; set; }

        [ForeignKey("RefSex")]
        public Guid? RefSexId { get; set; }

        public bool? HispanicLatinoEthnicity { get; set; }

        [ForeignKey("RefUSCitizenshipStatus")]
        public Guid? RefUSCitizenshipStatusId { get; set; }

        [ForeignKey("RefVisaType")]
        public Guid? RefVisaTypeId { get; set; }

        [ForeignKey("RefState")]
        public Guid? RefStateOfResidenceId { get; set; }

        [ForeignKey("RefProofOfResidencyType")]
        public Guid? RefProofOfResidencyTypeId { get; set; }

        [ForeignKey("RefHighestEducationLevelCompleted")]
        public Guid? RefHighestEducationLevelCompletedId { get; set; }

        [StringLength(60)]
        public string BirthdateVerification { get; set; }

        [ForeignKey("RefTribalAffiliation")]
        public Guid? RefTribalAffiliationId { get; set; }

        public virtual Person Person { get; set; }

        public virtual RefEducationLevel RefEducationLevel { get; set; }

        public virtual RefProofOfResidencyType RefProofOfResidencyType { get; set; }

        public virtual RefSex RefSex { get; set; }

        public virtual RefState RefState { get; set; }

        public virtual RefTribalAffiliation RefTribalAffiliation { get; set; }

        public virtual RefUSCitizenshipStatus RefUSCitizenshipStatus { get; set; }

        public virtual RefVisaType RefVisaType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonPersonalInformationVerification> PersonPersonalInformationVerifications { get; set; }
    }
}
