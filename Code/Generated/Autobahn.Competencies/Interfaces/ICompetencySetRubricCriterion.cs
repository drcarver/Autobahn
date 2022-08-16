//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencySetRubricCriterion.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencySetRubricCriterion Interface
     /// </summary>
    public partial interface ICompetencySetRubricCriterion : IAutobahnBase
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
