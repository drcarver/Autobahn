//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentLanguage.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentLanguage Interface
     /// </summary>
    public partial interface IAssessmentLanguage : IAutobahnBase
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
