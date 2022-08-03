//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentSection.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentSection
     /// </summary>
    public partial class PsStudentSection : IPsStudentSection
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.CourseOverrideSchool non nullable property
        /// </summary>
        public System.String CourseOverrideSchool { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.DegreeApplicability nullable property
        /// </summary>
        public System.Boolean? DegreeApplicability { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.AcademicGrade non nullable property
        /// </summary>
        public System.String AcademicGrade { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.NumberOfCreditsEarned nullable property
        /// </summary>
        public System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.QualityPointsEarned nullable property
        /// </summary>
        public System.Decimal? QualityPointsEarned { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseRepeatCode"/> model
        /// </summary>
        public Guid? RefCourseRepeatCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseAcademicGradeStatusCode"/> model
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentSection.NumberOfCreditsAttempted nullable property
        /// </summary>
        public System.Decimal? NumberOfCreditsAttempted { get; set; }

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
