//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsSectionLocationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsSectionLocationModel Interface
     /// </summary>
    public partial interface IPsSectionLocationModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PsSection"/> model
        /// </summary>
        Guid PsSectionId { get; set; }

        /// <summary>
        /// Defines the PsSectionLocation.CourseInstructionSiteName non nullable property
        /// </summary>
        System.String CourseInstructionSiteName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInstructionSiteType"/> model
        /// </summary>
        Guid? RefCourseInstructionSiteTypeId { get; set; }

    }
}
