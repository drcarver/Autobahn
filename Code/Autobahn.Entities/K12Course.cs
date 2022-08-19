using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12Course")]
    public partial class K12Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public K12Course()
        {
            K12StudentGraduationPlan = new HashSet<K12StudentGraduationPlan>();
        }

        public int K12CourseId { get; set; }

        public int CourseId { get; set; }

        public bool? HighSchoolCourseRequirement { get; set; }

        public decimal? AvailableCarnegieUnitCredit { get; set; }

        public bool? CoreAcademicCourse { get; set; }

        public bool? CourseAlignedWithStandards { get; set; }

        [StringLength(30)]
        public string FundingProgram { get; set; }

        public bool? FamilyConsumerSciencesCourseInd { get; set; }

        [StringLength(5)]
        public string SCEDCourseCode { get; set; }

        [StringLength(4)]
        public string SCEDGradeSpan { get; set; }

        [StringLength(60)]
        public string CourseDepartmentName { get; set; }

        public int? RefCreditTypeEarnedId { get; set; }

        public int? RefAdditionalCreditTypeId { get; set; }

        public int? RefCourseGPAApplicabilityId { get; set; }

        public int? RefCurriculumFrameworkTypeId { get; set; }

        public int? RefSCEDCourseLevelId { get; set; }

        public int? RefSCEDCourseSubjectAreaId { get; set; }

        public int? RefCareerClusterId { get; set; }

        public int? RefBlendedLearningModelTypeId { get; set; }

        public int? RefCourseInteractionModeId { get; set; }

        public int? RefK12EndOfCourseRequirementId { get; set; }

        public int? RefWorkbasedLearningOpportunityTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual Course Course { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAdditionalCreditType RefAdditionalCreditType { get; set; }

        public virtual RefBlendedLearningModelType RefBlendedLearningModelType { get; set; }

        public virtual RefCareerCluster RefCareerCluster { get; set; }

        public virtual RefCourseGpaApplicability RefCourseGpaApplicability { get; set; }

        public virtual RefCourseInteractionMode RefCourseInteractionMode { get; set; }

        public virtual RefCreditTypeEarned RefCreditTypeEarned { get; set; }

        public virtual RefCurriculumFrameworkType RefCurriculumFrameworkType { get; set; }

        public virtual RefK12EndOfCourseRequirement RefK12EndOfCourseRequirement { get; set; }

        public virtual RefSCEDCourseLevel RefSCEDCourseLevel { get; set; }

        public virtual RefSCEDCourseSubjectArea RefSCEDCourseSubjectArea { get; set; }

        public virtual RefWorkbasedLearningOpportunityType RefWorkbasedLearningOpportunityType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<K12StudentGraduationPlan> K12StudentGraduationPlan { get; set; }
    }
}
