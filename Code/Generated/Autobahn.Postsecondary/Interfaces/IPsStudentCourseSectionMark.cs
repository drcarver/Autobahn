//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentCourseSectionMark.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentCourseSectionMark
     /// </summary>
    public partial interface IPsStudentCourseSectionMark : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PsStudentSection"/> model
        /// </summary>
        Guid PsStudentSectionId { get; set; }

        /// <summary>
        /// Defines the PsStudentCourseSectionMark.CourseNarrativeExplanationGrade non nullable property
        /// </summary>
        System.String CourseNarrativeExplanationGrade { get; set; }

        /// <summary>
        /// Defines the PsStudentCourseSectionMark.StudentCourseSectionGradeNarrative non nullable property
        /// </summary>
        System.String StudentCourseSectionGradeNarrative { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseAcademicGradeStatusCode"/> model
        /// </summary>
        Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

    }
}
