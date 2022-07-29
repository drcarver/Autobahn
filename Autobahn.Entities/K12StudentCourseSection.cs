using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    public partial class K12StudentCourseSection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public K12StudentCourseSection()
        {
            K12StudentCourseSectionMark = new HashSet<K12StudentCourseSectionMark>();
            TeacherStudentDataLinkExclusions = new HashSet<TeacherStudentDataLinkExclusion>();
        }

        public int K12StudentCourseSectionId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        [StringLength(15)]
        public string GradeEarned { get; set; }

        [StringLength(100)]
        public string GradeValueQualifier { get; set; }

        public decimal? NumberOfCreditsAttempted { get; set; }

        public decimal? NumberOfCreditsEarned { get; set; }

        public bool? TuitionFunded { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExitWithdrawalDate { get; set; }

        public int? RefCourseRepeatCodeId { get; set; }

        public int? RefCourseSectionEnrollmentStatusTypeId { get; set; }

        public int? RefCourseSectionEntryTypeId { get; set; }

        public int? RefCourseSectionExitTypeId { get; set; }

        public int? RefExitOrWithdrawalStatusId { get; set; }

        public int? RefGradeLevelWhenCourseTakenId { get; set; }

        public int? RefCreditTypeEarnedId { get; set; }

        public int? RefAdditionalCreditTypeId { get; set; }

        public int? RefPreAndPostTestIndicatorId { get; set; }

        public int? RefProgressLevelId { get; set; }

        public int? RefCourseGPAApplicabilityId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RefCourseGpaApplicability RefCourseGpaApplicability { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAdditionalCreditType RefAdditionalCreditType { get; set; }

        public virtual RefCourseRepeatCode RefCourseRepeatCode { get; set; }

        public virtual RefCourseSectionEnrollmentStatusType RefCourseSectionEnrollmentStatusType { get; set; }

        public virtual RefCourseSectionEntryType RefCourseSectionEntryType { get; set; }

        public virtual RefCourseSectionExitType RefCourseSectionExitType { get; set; }

        public virtual RefCreditTypeEarned RefCreditTypeEarned { get; set; }

        public virtual RefExitOrWithdrawalStatu RefExitOrWithdrawalStatu { get; set; }

        public virtual RefGradeLevel RefGradeLevel { get; set; }

        public virtual RefPreAndPostTestIndicator RefPreAndPostTestIndicator { get; set; }

        public virtual RefProgressLevel RefProgressLevel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12StudentCourseSectionMark> K12StudentCourseSectionMark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherStudentDataLinkExclusion> TeacherStudentDataLinkExclusions { get; set; }
    }
}
