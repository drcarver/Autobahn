//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionSchedule.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The CourseSectionSchedule
     /// </summary>
    public partial class CourseSectionSchedule : ICourseSectionSchedule
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
        /// Defines the CourseSectionSchedule.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the CourseSectionSchedule.RecordEndDateTime nullable property
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
