//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySet Model
     /// </summary>
    public partial class CompetencySetModel : AutobahnBase, Interfaces.ICompetencySet
    {
        /// <summary>
        /// The criteria for the set of competencies that represent completion or partial completion of a unit, course, program, degree, certification, or other achievement/award. Specifies whether completion requires achievement of all items in the set or some number of items.
        /// </summary>
        public Guid? RefCompletionCriteriaId { get; set; }

    }
}
