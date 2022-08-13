//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeCourseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeCourse Model
     /// </summary>
    public partial class AeCourseModel : AutobahnBase, Interfaces.IAeCourse
    {
        /// <summary>
        /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
        /// </summary>
        public Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
        /// </summary>
        public Guid? RefCourseLevelTypeId { get; set; }

    }
}
