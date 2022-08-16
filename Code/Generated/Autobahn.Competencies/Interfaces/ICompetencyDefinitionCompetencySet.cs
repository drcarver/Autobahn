//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencyDefinitionCompetencySet.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencyDefinitionCompetencySet Interface
     /// </summary>
    public partial interface ICompetencyDefinitionCompetencySet : IAutobahnBase
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
