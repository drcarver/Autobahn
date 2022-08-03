//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionLevel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The CourseSectionLevel
     /// </summary>
    public partial class CourseSectionLevel : ICourseSectionLevel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSection"/> model
        /// </summary>
        public Guid CourseSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCourseLevelType"/> model
        /// </summary>
        public Guid RefCourseLevelTypeId { get; set; }

        /// <summary>
        /// Defines the CourseSectionLevel.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CourseSectionLevel.RecordEndDateTime nullable property
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
