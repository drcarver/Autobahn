//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentCourseSectionMark.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentCourseSectionMark Interface
     /// </summary>
    public partial interface IPsStudentCourseSectionMark : IAutobahnBase
    {
        /// <summary>
        /// Additional information regarding the context of the given grade.
        /// </summary>
        Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

    }
}
