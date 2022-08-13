//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsSectionLocation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsSectionLocation Interface
     /// </summary>
    public partial interface IPsSectionLocation : IAutobahnBase
    {
        /// <summary>
        /// The name of the location at which the course is taught.
        /// </summary>
        System.String CourseInstructionSiteName { get; set; }

        /// <summary>
        /// The name of the location at which the course is taught.
        /// </summary>
        Guid PsSectionId { get; set; }

        /// <summary>
        /// The name of the location at which the course is taught.
        /// </summary>
        Guid? RefCourseInstructionSiteTypeId { get; set; }

    }
}
