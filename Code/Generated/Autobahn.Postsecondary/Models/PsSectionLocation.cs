//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsSectionLocation.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsSectionLocation
     /// </summary>
    public partial class PsSectionLocation : IPsSectionLocation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PsSection"/> model
        /// </summary>
        public Guid PsSectionId { get; set; }

        /// <summary>
        /// Defines the PsSectionLocation.CourseInstructionSiteName non nullable property
        /// </summary>
        public System.String CourseInstructionSiteName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInstructionSiteType"/> model
        /// </summary>
        public Guid? RefCourseInstructionSiteTypeId { get; set; }

        /// <summary>
        /// Defines the PsSectionLocation.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsSectionLocation.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
