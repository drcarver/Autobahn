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
        /// 
        /// </summary>
         CourseNarrativeExplanationGrade { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StudentCourseSectionGradeNarrative { get; set; }

    }
}
