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
        /// An indication of the time of day the class begins.
        /// </summary>
        public System.TimeSpan? ClassBeginningTime { get; set; }

    }
}
