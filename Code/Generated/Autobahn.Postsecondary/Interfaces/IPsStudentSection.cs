//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentSection.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentSection
     /// </summary>
    public partial interface IPsStudentSection
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.CourseOverrideSchool non nullable property
        /// </summary>
        System.String CourseOverrideSchool { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.DegreeApplicability nullable property
        /// </summary>
        System.Boolean? DegreeApplicability { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.AcademicGrade non nullable property
        /// </summary>
        System.String AcademicGrade { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.NumberOfCreditsEarned nullable property
        /// </summary>
        System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.QualityPointsEarned nullable property
        /// </summary>
        System.Decimal? QualityPointsEarned { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseRepeatCode"/> model
        /// </summary>
        Guid? RefCourseRepeatCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseAcademicGradeStatusCode"/> model
        /// </summary>
        Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.NumberOfCreditsAttempted nullable property
        /// </summary>
        System.Decimal? NumberOfCreditsAttempted { get; set; }

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
