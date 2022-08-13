//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentSection Model
     /// </summary>
    public partial class PsStudentSectionModel : AutobahnBase, Interfaces.IPsStudentSection
    {
        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public System.String AcademicGrade { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public System.String CourseOverrideSchool { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public System.Boolean? DegreeApplicability { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public System.Decimal? NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public System.Decimal? NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public System.Decimal? QualityPointsEarned { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public Guid? RefCourseRepeatCodeId { get; set; }

    }
}
