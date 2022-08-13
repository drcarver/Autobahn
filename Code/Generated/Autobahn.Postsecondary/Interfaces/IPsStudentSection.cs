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
        /// The final grade awarded for participation in the course. 
        /// </summary>
        System.String AcademicGrade { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        System.String CourseOverrideSchool { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        System.Boolean? DegreeApplicability { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        System.Decimal? NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        System.Decimal? QualityPointsEarned { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        Guid? RefCourseRepeatCodeId { get; set; }

    }
}
