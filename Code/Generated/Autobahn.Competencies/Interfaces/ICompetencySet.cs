//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencySet.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencySet Interface
     /// </summary>
    public partial interface ICompetencySet : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         CompletionCriteriaThreshold { get; set; }

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
        Guid? RefCompletionCriteriaId { get; set; }

    }
}
