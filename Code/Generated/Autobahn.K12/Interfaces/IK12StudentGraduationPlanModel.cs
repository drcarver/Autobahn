//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentGraduationPlanModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentGraduationPlanModel Interface
     /// </summary>
    public partial interface IK12StudentGraduationPlanModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12Course"/> model
        /// </summary>
        Guid K12CourseId { get; set; }

        /// <summary>
        /// Defines the K12StudentGraduationPlan.CreditsRequired nullable property
        /// </summary>
        System.Decimal? CreditsRequired { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseSubjectArea"/> model
        /// </summary>
        Guid? RefSCEDCourseSubjectAreaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
        /// </summary>
        Guid? RefGradeLevelWhenCourseTakenId { get; set; }

    }
}
