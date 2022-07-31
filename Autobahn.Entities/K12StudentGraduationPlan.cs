using System;

namespace Autobahn.Entities
{
    public partial class K12StudentGraduationPlan
    {
        public int K12StudentGraduationPlanId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int K12CourseId { get; set; }

        public decimal? CreditsRequired { get; set; }

        public int? RefSCEDCourseSubjectAreaId { get; set; }

        public int? RefGradeLevelWhenCourseTakenId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual K12Course K12Course { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefGradeLevel RefGradeLevel { get; set; }

        public virtual RefSCEDCourseSubjectArea RefSCEDCourseSubjectArea { get; set; }
    }
}