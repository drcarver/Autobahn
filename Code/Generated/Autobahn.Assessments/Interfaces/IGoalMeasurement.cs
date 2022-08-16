//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IGoalMeasurement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IGoalMeasurement Interface
     /// </summary>
    public partial interface IGoalMeasurement : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         Description { get; set; }

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
         RefGoalMeasurementTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Schedule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? SuccessCriteria { get; set; }

    }
}
