//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentSection.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentSection Interface
     /// </summary>
    public partial interface IPsStudentSection : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? AcademicGrade { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CourseOverrideSchool { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DegreeApplicability { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// 
        /// </summary>
         QualityPointsEarned { get; set; }

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
         RefCourseAcademicGradeStatusCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseRepeatCodeId { get; set; }

    }
}
