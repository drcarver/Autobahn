//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IRubricCriterionLevel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IRubricCriterionLevel Interface
     /// </summary>
    public partial interface IRubricCriterionLevel : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Feedback { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Quality { get; set; }

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
         Score { get; set; }

    }
}
