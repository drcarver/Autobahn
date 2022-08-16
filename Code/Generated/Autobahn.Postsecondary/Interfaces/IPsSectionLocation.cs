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
        /// 
        /// </summary>
        Guid? CourseInstructionSiteName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseInstructionSiteTypeId { get; set; }

    }
}
