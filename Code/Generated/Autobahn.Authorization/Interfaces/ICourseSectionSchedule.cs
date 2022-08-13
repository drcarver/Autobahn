//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   ICourseSectionSchedule.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The ICourseSectionSchedule Interface
     /// </summary>
    public partial interface ICourseSectionSchedule : IAutobahnBase
    {
        /// <summary>
        /// An indication of the time of day the class begins.
        /// </summary>
        System.TimeSpan? ClassBeginningTime { get; set; }

        /// <summary>
        /// An indication of the time of day the class begins.
        /// </summary>
        System.TimeSpan? ClassEndingTime { get; set; }

        /// <summary>
        /// An indication of the time of day the class begins.
        /// </summary>
        System.String ClassMeetingDays { get; set; }

        /// <summary>
        /// An indication of the time of day the class begins.
        /// </summary>
        System.String ClassPeriod { get; set; }

        /// <summary>
        /// An indication of the time of day the class begins.
        /// </summary>
        Guid CourseSectionId { get; set; }

        /// <summary>
        /// An indication of the time of day the class begins.
        /// </summary>
        System.String TimeDayIdentifier { get; set; }

    }
}
