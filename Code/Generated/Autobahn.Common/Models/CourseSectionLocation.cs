//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionLocation.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The CourseSectionLocation
     /// </summary>
    public partial class CourseSectionLocation : ICourseSectionLocation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Classroom"/> model
        /// </summary>
        public Guid ClassroomId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSection"/> model
        /// </summary>
        public Guid CourseSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLocationType"/> model
        /// </summary>
        public Guid? RefInstructionLocationTypeId { get; set; }

        /// <summary>
        /// Defines the CourseSectionLocation.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CourseSectionLocation.RecordEndDateTime nullable property
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
