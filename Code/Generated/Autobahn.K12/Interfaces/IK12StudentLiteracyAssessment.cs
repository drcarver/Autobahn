//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentLiteracyAssessment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentLiteracyAssessment Interface
     /// </summary>
    public partial interface IK12StudentLiteracyAssessment : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         LiteracyGoalMetStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LiteracyPostTestStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LiteracyPreTestStatus { get; set; }

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
        Guid? RefLiteracyAssessmentId { get; set; }

    }
}
