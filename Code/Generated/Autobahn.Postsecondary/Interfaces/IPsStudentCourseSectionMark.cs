//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentCourseSectionMark.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentCourseSectionMark
     /// </summary>
    public partial interface IPsStudentCourseSectionMark
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

        /// <summary>
        /// Defines the PsStudentCourseSectionMark.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentCourseSectionMark.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
