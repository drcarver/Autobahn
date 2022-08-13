//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionLocationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsSectionLocation Model
     /// </summary>
    public partial class PsSectionLocationModel : AutobahnBase, Interfaces.IPsSectionLocation
    {
        /// <summary>
        /// The name of the location at which the course is taught.
        /// </summary>
        public System.String CourseInstructionSiteName { get; set; }

        /// <summary>
        /// The name of the location at which the course is taught.
        /// </summary>
        public Guid PsSectionId { get; set; }

        /// <summary>
        /// The name of the location at which the course is taught.
        /// </summary>
        public Guid? RefCourseInstructionSiteTypeId { get; set; }

    }
}
