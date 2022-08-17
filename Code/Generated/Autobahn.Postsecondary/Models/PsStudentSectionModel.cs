//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentSectionModel.cs
//* Name:       Course Academic Grade
//* Definition: The final grade awarded for participation in the course. 
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The final grade awarded for participation in the course. 
     /// </summary>
    public partial class PsStudentSectionModel : AutobahnBase, Interfaces.IPsStudentSection
    {
        /// <summary>
        /// Course Academic Grade
        /// <para>
        /// The final grade awarded for participation in the course. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19053">Course Academic Grade</a>
        /// </para>
        /// </summary>
        public System.String AcademicGrade { get; set; }

        /// <summary>
        /// Course Override School
        /// <para>
        /// The school where the credit was earned if different from the institution reporting. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19063">Course Override School</a>
        /// </para>
        /// </summary>
        public System.String CourseOverrideSchool { get; set; }

        /// <summary>
        /// Degree Applicability
        /// <para>
        /// An indication that the course is a part of a degree program. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19077">Degree Applicability</a>
        /// </para>
        /// </summary>
        public System.Boolean? DegreeApplicability { get; set; }

        /// <summary>
        /// Number of Credits Attempted
        /// <para>
        /// The number of credits that a student can earn for enrolling in and completing a given course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19199">Number of Credits Attempted</a>
        /// </para>
        /// </summary>
        public System.Decimal? NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// Number of Credits Earned
        /// <para>
        /// The number of credits an individual earns by the successful completion of a course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19200">Number of Credits Earned</a>
        /// </para>
        /// </summary>
        public System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Course Quality Points Earned
        /// <para>
        /// The numerical value assigned to a letter grade to provide a basis of quantitative determination of an average. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19064">Course Quality Points Earned</a>
        /// </para>
        /// </summary>
        public System.Decimal? QualityPointsEarned { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCourseAcademicGradeStatusCode"/> model
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCourseRepeatCode"/> model
        /// </summary>
        public Guid? RefCourseRepeatCodeId { get; set; }

    }
}
