//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentPersonalNeedsProfileControl.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentPersonalNeedsProfileControl Interface
     /// </summary>
    public partial interface IAssessmentPersonalNeedsProfileControl : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

    }
}
