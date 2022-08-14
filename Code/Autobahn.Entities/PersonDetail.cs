using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonDetail")]
    public partial class PersonDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonDetail()
        {
            PersonPersonalInformationVerifications = new HashSet<PersonPersonalInformationVerification>();
        }

        public int PersonDetailId { get; set; }

        public int PersonId { get; set; }

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

        public int? RefSexId { get; set; }

        public bool? HispanicLatinoEthnicity { get; set; }

        public int? RefUSCitizenshipStatusId { get; set; }

        public int? RefVisaTypeId { get; set; }

        public int? RefStateOfResidenceId { get; set; }

        public int? RefProofOfResidencyTypeId { get; set; }

        public int? RefHighestEducationLevelCompletedId { get; set; }

        [StringLength(60)]
        public string BirthdateVerification { get; set; }

        public int? RefTribalAffiliationId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

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
