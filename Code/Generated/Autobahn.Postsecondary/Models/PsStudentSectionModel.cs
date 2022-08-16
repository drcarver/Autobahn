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
        /// 
        /// </summary>
        public Guid? AcademicGrade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CourseOverrideSchool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DegreeApplicability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfCreditsAttempted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfCreditsEarned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  QualityPointsEarned { get; set; }

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
        public  RefCourseAcademicGradeStatusCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseRepeatCodeId { get; set; }

    }
}
