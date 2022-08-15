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
        /// An indication of the time of day the class begins.
        /// </summary>
        System.TimeSpan? ClassBeginningTime { get; set; }

    }
}
