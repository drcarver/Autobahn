//***************************************************************************
//* DomainName: Adult Education (AE) Interfaces (used by both models and View Models
//* FileName:   IAeCourse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeCourse Interface
     /// </summary>
    public partial interface IAeCourse : IAutobahnBase
    {
        /// <summary>
        /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
        /// </summary>
        Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
        /// </summary>
        Guid? RefCourseLevelTypeId { get; set; }

    }
}
