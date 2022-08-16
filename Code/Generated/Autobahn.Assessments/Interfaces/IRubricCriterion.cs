//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IRubricCriterion.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IRubricCriterion Interface
     /// </summary>
    public partial interface IRubricCriterion : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Position { get; set; }

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
         Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Weight { get; set; }

    }
}
