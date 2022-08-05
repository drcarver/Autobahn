//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionSchedule.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The CourseSectionSchedule
     /// </summary>
    public partial class CourseSectionSchedule : AutobahnBase, Interfaces.ICourseSectionSchedule
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSection"/> model
        /// </summary>
        public Guid CourseSectionId { get; set; }

        /// <summary>
        /// Defines the CourseSectionSchedule.ClassMeetingDays non nullable property
        /// </summary>
        public System.String ClassMeetingDays { get; set; }

        /// <summary>
        /// Defines the CourseSectionSchedule.ClassBeginningTime nullable property
        /// </summary>
        public System.TimeSpan? ClassBeginningTime { get; set; }

        /// <summary>
        /// Defines the CourseSectionSchedule.ClassEndingTime nullable property
        /// </summary>
        public System.TimeSpan? ClassEndingTime { get; set; }

        /// <summary>
        /// Defines the CourseSectionSchedule.ClassPeriod non nullable property
        /// </summary>
        public System.String ClassPeriod { get; set; }

        /// <summary>
        /// Defines the CourseSectionSchedule.TimeDayIdentifier non nullable property
        /// </summary>
        public System.String TimeDayIdentifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
