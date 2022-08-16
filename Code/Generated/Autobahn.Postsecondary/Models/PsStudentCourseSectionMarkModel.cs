//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCourseSectionMarkModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentCourseSectionMark Model
     /// </summary>
    public partial class PsStudentCourseSectionMarkModel : AutobahnBase, Interfaces.IPsStudentCourseSectionMark
    {
        /// <summary>
        /// 
        /// </summary>
        public  CourseNarrativeExplanationGrade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StudentCourseSectionGradeNarrative { get; set; }

    }
}
