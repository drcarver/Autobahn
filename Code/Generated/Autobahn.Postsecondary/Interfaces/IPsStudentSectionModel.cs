//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentSectionModel Interface
     /// </summary>
    public partial interface IPsStudentSectionModel : IAutobahnBase
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
        /// Defines the PsStudentSection.NumberOfCreditsAttempted nullable property
        /// </summary>
        System.Decimal? NumberOfCreditsAttempted { get; set; }

    }
}
