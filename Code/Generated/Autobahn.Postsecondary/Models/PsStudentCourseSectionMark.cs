//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentCourseSectionMark.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentCourseSectionMark
     /// </summary>
    public partial class PsStudentCourseSectionMark : IPsStudentCourseSectionMark
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
        /// Defines the PsStudentCourseSectionMark.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentCourseSectionMark.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
