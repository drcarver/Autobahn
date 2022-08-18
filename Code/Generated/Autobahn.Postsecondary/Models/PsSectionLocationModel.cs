//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionLocationModel.cs
//* Name:       Course Instruction Site Name
//* Definition: The name of the location at which the course is taught.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The name of the location at which the course is taught.
     /// </summary>
    public partial class PsSectionLocationModel : AutobahnBase, Interfaces.IPsSectionLocation
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
        public System.String CourseInstructionSiteName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPsSection"/> model
        /// </summary>
        public Guid PsSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInstructionSiteType"/> model
        /// </summary>
        public Guid? RefCourseInstructionSiteTypeId { get; set; }

    }
}
