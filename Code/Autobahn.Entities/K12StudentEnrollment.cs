using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    public partial class K12StudentEnrollment
    {
        public int K12StudentEnrollmentId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public bool? DisplacedStudentStatus { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FirstEntryDateIntoUSSchool { get; set; }

        public bool? NSLPDirectCertificationIndicator { get; set; }

        public int? RefEntryGradeLevelId { get; set; }

        public int? RefPublicSchoolResidence { get; set; }

        public int? RefEnrollmentStatusId { get; set; }

        public int? RefEntryType { get; set; }

        public int? RefExitGradeLevelId { get; set; }

        public int? RefExitOrWithdrawalStatusId { get; set; }

        public int? RefExitOrWithdrawalTypeId { get; set; }

        public int? RefEndOfTermStatusId { get; set; }

        public int? RefPromotionReasonId { get; set; }

        public int? RefNonPromotionReasonId { get; set; }

        public int? RefFoodServiceEligibilityId { get; set; }

        public int? RefDirectoryInformationBlockStatusId { get; set; }

        public int? RefStudentEnrollmentAccessTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RefGradeLevel RefGradeLevel { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole1 { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefDirectoryInformationBlockStatu RefDirectoryInformationBlockStatu { get; set; }

        public virtual RefEndOfTermStatu RefEndOfTermStatu { get; set; }

        public virtual RefEnrollmentStatu RefEnrollmentStatu { get; set; }

        public virtual RefEntryType RefEntryType1 { get; set; }

        public virtual RefExitOrWithdrawalStatu RefExitOrWithdrawalStatu { get; set; }

        public virtual RefExitOrWithdrawalType RefExitOrWithdrawalType { get; set; }

        public virtual RefFoodServiceEligibility RefFoodServiceEligibility { get; set; }

        public virtual RefGradeLevel RefGradeLevel1 { get; set; }

        public virtual RefNonPromotionReason RefNonPromotionReason { get; set; }

        public virtual RefPromotionReason RefPromotionReason { get; set; }

        public virtual RefPublicSchoolResidence RefPublicSchoolResidence1 { get; set; }

        public virtual RefStudentEnrollmentAccessType RefStudentEnrollmentAccessType { get; set; }
    }
}
