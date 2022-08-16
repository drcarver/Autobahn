//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffEvaluationPart.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffEvaluationPart Interface
     /// </summary>
    public partial interface IStaffEvaluationPart : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         PartName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Scale { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ScoreOrRating { get; set; }

    }
}
