//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentCourseSectionMarkModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentCourseSectionMark Model
     /// </summary>
    public partial class PsStudentCourseSectionMarkModel : AutobahnBase, Interfaces.IPsStudentCourseSectionMarkModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PsStudentSection"/> model
        /// </summary>
        public Guid PsStudentSectionId { get; set; }

        /// <summary>
        /// Defines the PsStudentCourseSectionMark.CourseNarrativeExplanationGrade non nullable property
        /// </summary>
        public System.String CourseNarrativeExplanationGrade { get; set; }

        /// <summary>
        /// Defines the PsStudentCourseSectionMark.StudentCourseSectionGradeNarrative non nullable property
        /// </summary>
        public System.String StudentCourseSectionGradeNarrative { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseAcademicGradeStatusCode"/> model
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
