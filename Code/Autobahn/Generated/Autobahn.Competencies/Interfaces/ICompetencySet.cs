//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencySet.cs
//* Name:       Competency Set Completion Criteria
//* Definition: The criteria for the set of competencies that represent completion or partial completion of a unit, course, program, degree, certification, or other achievement/award. Specifies whether completion requires achievement of all items in the set or some number of items.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The criteria for the set of competencies that represent completion or partial completion of a unit, course, program, degree, certification, or other achievement/award. Specifies whether completion requires achievement of all items in the set or some number of items.
     /// </summary>
    public partial interface ICompetencySet : IAutobahnBase
    {
    }
}
