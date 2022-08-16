//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentNeedScreenEnhancement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedScreenEnhancement Interface
     /// </summary>
    public partial interface IAssessmentNeedScreenEnhancement : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ForegroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? InvertColorChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Magnification { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
