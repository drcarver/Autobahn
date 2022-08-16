//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionScheduleModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The CourseSectionSchedule Model
     /// </summary>
    public partial class CourseSectionScheduleModel : AutobahnBase, Interfaces.ICourseSectionSchedule
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? ClassBeginningTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ClassEndingTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ClassMeetingDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ClassPeriod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TimeDayIdentifier { get; set; }

    }
}
