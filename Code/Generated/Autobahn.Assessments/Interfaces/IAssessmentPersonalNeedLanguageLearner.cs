//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedLanguageLearner.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedLanguageLearner Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedLanguageLearner : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ActivateByDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? AssignedSupport { get; set; }

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
         RefAssessmentNeedsProfileContentLanguageLearnerTypeId { get; set; }

    }
}
