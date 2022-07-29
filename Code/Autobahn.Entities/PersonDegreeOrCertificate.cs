using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonDegreeOrCertificate")]
    public partial class PersonDegreeOrCertificate
    {
        public int PersonDegreeOrCertificateId { get; set; }

        public int PersonId { get; set; }

        [StringLength(45)]
        public string DegreeOrCertificateTitleOrSubject { get; set; }

        public int? RefDegreeOrCertificateTypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AwardDate { get; set; }

        [StringLength(60)]
        public string NameOfInstitution { get; set; }

        public int? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

        public int? RefEducationVerificationMethodId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefDegreeOrCertificateType RefDegreeOrCertificateType { get; set; }

        public virtual RefEducationVerificationMethod RefEducationVerificationMethod { get; set; }

        public virtual RefHigherEducationInstitutionAccreditationStatu RefHigherEducationInstitutionAccreditationStatu { get; set; }
    }
}
