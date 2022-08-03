//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ICourseSectionLevel.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ICourseSectionLevel
     /// </summary>
    public partial interface ICourseSectionLevel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSection"/> model
        /// </summary>
        Guid CourseSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCourseLevelType"/> model
        /// </summary>
        Guid RefCourseLevelTypeId { get; set; }

        /// <summary>
        /// Defines the CourseSectionLevel.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CourseSectionLevel.RecordEndDateTime nullable property
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
