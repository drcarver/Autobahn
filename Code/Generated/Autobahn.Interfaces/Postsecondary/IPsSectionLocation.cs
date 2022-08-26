//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsSectionLocation.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Postsecondary
{
     /// <summary>
     /// The IPsSectionLocation Interface
     /// </summary>
    public partial interface IPsSectionLocation : IAutobahnBase
    {
        /// <summary>
        /// Course Instruction Site Name
        /// <para>
        /// The name of the location at which the course is taught.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20275">Course Instruction Site Name</a>
        /// </para>
        /// </summary>
        System.String CourseInstructionSiteName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPsSection"/> model
        /// </summary>
        Guid PsSectionId { get; set; }

        /// <summary>
        /// Course Instruction Site Type
        /// <para>
        /// An indication of the type of location at which the course is taught.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20276">Course Instruction Site Type</a>
        /// </para>
        /// </summary>
        Guid? RefCourseInstructionSiteTypeId { get; set; }

    }
}
