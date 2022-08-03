//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsSectionLocation.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsSectionLocation
     /// </summary>
    public partial interface IPsSectionLocation
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

        /// <summary>
        /// Defines the PsSectionLocation.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsSectionLocation.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
