//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencyDefAssociation.cs
//* Name:       Competency Definition Prerequisite Identifier
//* Definition: The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
     /// </summary>
    public partial interface ICompetencyDefAssociation : IAutobahnBase
    {
    }
}
