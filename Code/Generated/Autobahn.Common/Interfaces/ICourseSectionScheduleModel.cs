//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ICourseSectionScheduleModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ICourseSectionScheduleModel Interface
     /// </summary>
    public partial interface ICourseSectionScheduleModel : IAutobahnBase
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

    }
}
