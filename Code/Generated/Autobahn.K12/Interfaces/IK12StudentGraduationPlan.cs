//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentGraduationPlan.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentGraduationPlan Interface
     /// </summary>
    public partial interface IK12StudentGraduationPlan : IAutobahnBase
    {
        /// <summary>
        /// Student's grade level at time of course.
        /// </summary>
        System.Decimal? CreditsRequired { get; set; }

        /// <summary>
        /// Student's grade level at time of course.
        /// </summary>
        Guid K12CourseId { get; set; }

        /// <summary>
        /// Student's grade level at time of course.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Student's grade level at time of course.
        /// </summary>
        Guid? RefGradeLevelWhenCourseTakenId { get; set; }

        /// <summary>
        /// Student's grade level at time of course.
        /// </summary>
        Guid? RefSCEDCourseSubjectAreaId { get; set; }

    }
}
