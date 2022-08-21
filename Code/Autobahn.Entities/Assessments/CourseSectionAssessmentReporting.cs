//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   CourseSectionAssessmentReporting.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Entities.Common;

namespace Autobahn.Entities.Assessments
{
    [Table("CourseSectionAssessmentReporting", Schema = "Assessments")]
    public partial class CourseSectionAssessmentReporting : EntityBase
    {
        [ForeignKey("CourseSection")]
        public Guid? CourseSectionId { get; set; }

        [ForeignKey("RefCourseSectionAssessmentReportingMethod")]
        public Guid? RefCourseSectionAssessmentReportingMethodId { get; set; }

        public virtual CourseSection CourseSection { get; set; }

        public virtual RefCourseSectionAssessmentReportingMethod RefCourseSectionAssessmentReportingMethod { get; set; }
    }
}
