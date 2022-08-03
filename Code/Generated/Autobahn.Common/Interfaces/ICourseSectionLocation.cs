//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ICourseSectionLocation.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ICourseSectionLocation
     /// </summary>
    public partial interface ICourseSectionLocation
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Classroom"/> model
        /// </summary>
        Guid ClassroomId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSection"/> model
        /// </summary>
        Guid CourseSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLocationType"/> model
        /// </summary>
        Guid? RefInstructionLocationTypeId { get; set; }

        /// <summary>
        /// Defines the CourseSectionLocation.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CourseSectionLocation.RecordEndDateTime nullable property
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
