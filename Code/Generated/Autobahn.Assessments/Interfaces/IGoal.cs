//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IGoal.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IGoal Interface
     /// </summary>
    public partial interface IGoal : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EndDate { get; set; }

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
         StartDate { get; set; }

    }
}
