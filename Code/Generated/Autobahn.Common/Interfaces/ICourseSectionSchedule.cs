//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ICourseSectionSchedule.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ICourseSectionSchedule
     /// </summary>
    public partial interface ICourseSectionSchedule
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSection"/> model
        /// </summary>
        Guid CourseSectionId { get; set; }

        /// <summary>
        /// Defines the CourseSectionSchedule.ClassMeetingDays non nullable property
        /// </summary>
        System.String ClassMeetingDays { get; set; }

        /// <summary>
        /// Defines the CourseSectionSchedule.ClassBeginningTime nullable property
        /// </summary>
        System.TimeSpan? ClassBeginningTime { get; set; }

        /// <summary>
        /// Defines the CourseSectionSchedule.ClassEndingTime nullable property
        /// </summary>
        System.TimeSpan? ClassEndingTime { get; set; }

        /// <summary>
        /// Defines the CourseSectionSchedule.ClassPeriod non nullable property
        /// </summary>
        System.String ClassPeriod { get; set; }

        /// <summary>
        /// Defines the CourseSectionSchedule.TimeDayIdentifier non nullable property
        /// </summary>
        System.String TimeDayIdentifier { get; set; }

        /// <summary>
        /// Defines the CourseSectionSchedule.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CourseSectionSchedule.RecordEndDateTime nullable property
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
