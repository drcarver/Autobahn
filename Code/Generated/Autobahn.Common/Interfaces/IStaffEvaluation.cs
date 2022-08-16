//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffEvaluation.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffEvaluation Interface
     /// </summary>
    public partial interface IStaffEvaluation : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Outcome { get; set; }

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
         RefStaffPerformanceLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Scale { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ScoreOrRating { get; set; }

        /// <summary>
        /// 
        /// </summary>
         System { get; set; }

    }
}
