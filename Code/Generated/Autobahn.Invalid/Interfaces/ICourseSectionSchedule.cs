//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   ICourseSectionSchedule.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The ICourseSectionSchedule Interface
     /// </summary>
    public partial interface ICourseSectionSchedule : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? ClassBeginningTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ClassEndingTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ClassMeetingDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ClassPeriod { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TimeDayIdentifier { get; set; }

    }
}
