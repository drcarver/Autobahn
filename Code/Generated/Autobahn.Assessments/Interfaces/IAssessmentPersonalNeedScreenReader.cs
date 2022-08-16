//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedScreenReader.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedScreenReader Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedScreenReader : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         Pitch { get; set; }

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
         RefAssessmentNeedLinkIndicationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefAssessmentNeedUsageTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SpeechRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Volume { get; set; }

    }
}
