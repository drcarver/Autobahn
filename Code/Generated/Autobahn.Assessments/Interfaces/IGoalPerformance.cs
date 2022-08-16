//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IGoalPerformance.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IGoalPerformance Interface
     /// </summary>
    public partial interface IGoalPerformance : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? CurrentPerformanceDescription { get; set; }

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
         RefGoalStatusTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Status { get; set; }

    }
}
