//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionLocationModel.cs
//***************************************************************************

using Autobahn.Interfaces.Postsecondary;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsSectionLocation Model
     /// </summary>
    public partial class PsSectionLocationModel : AutobahnBase, IPsSectionLocation
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
        /// Course Instruction Site Type
        /// <para>
        /// An indication of the type of location at which the course is taught.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20276">Course Instruction Site Type</a>
        /// </para>
        /// </summary>
        public Guid? RefCourseInstructionSiteTypeId { get; set; }

    }
}
