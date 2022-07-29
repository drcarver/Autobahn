using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CteCourse")]
    public partial class CteCourse
    {
        public int CteCourseId { get; set; }

        public int CourseId { get; set; }

        public decimal? AvailableCarnegieUnitCredit { get; set; }

        public bool? HighSchoolCourseRequirement { get; set; }

        public bool? CoreAcademicCourse { get; set; }

        public bool? CourseAlignedWithStandards { get; set; }

        [StringLength(5)]
        public string SCEDCourseCode { get; set; }

        [StringLength(60)]
        public string CourseDepartmentName { get; set; }

        public int? RefAdditionalCreditTypeId { get; set; }

        public int? RefCreditTypeEarnedId { get; set; }

        public int? RefCourseGPAApplicabilityId { get; set; }

        public int? RefCurriculumFrameworkTypeId { get; set; }

        public int? RefSCEDCourseLevelId { get; set; }

        public int? RefSCEDCourseSubjectAreaId { get; set; }

        public int? RefCareerClusterId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual Course Course { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAdditionalCreditType RefAdditionalCreditType { get; set; }

        public virtual RefCareerCluster RefCareerCluster { get; set; }

        public virtual RefCourseGpaApplicability RefCourseGpaApplicability { get; set; }

        public virtual RefCreditTypeEarned RefCreditTypeEarned { get; set; }

        public virtual RefCurriculumFrameworkType RefCurriculumFrameworkType { get; set; }

        public virtual RefSCEDCourseLevel RefSCEDCourseLevel { get; set; }

        public virtual RefSCEDCourseSubjectArea RefSCEDCourseSubjectArea { get; set; }
    }
}
