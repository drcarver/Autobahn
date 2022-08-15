//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefAssociationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefAssociation Model
     /// </summary>
    public partial class CompetencyDefAssociationModel : AutobahnBase, Interfaces.ICompetencyDefAssociation
    {
        /// <summary>
        /// The unique identifier of an immediate prerequisite Competency Definition, a competency needed prior to learning this one. (Some items may have no prerequisites while others may have one or more prerequisites. This should only be used to represent the immediate predecessors in a competency-based pathway, i.e. not prerequisites of prerequisites.)
        /// </summary>
        public Guid AssociatedEntityId { get; set; }

    }
}
