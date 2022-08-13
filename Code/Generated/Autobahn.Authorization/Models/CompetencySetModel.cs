//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   CompetencySetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The CompetencySet Model
     /// </summary>
    public partial class CompetencySetModel : AutobahnBase, Interfaces.ICompetencySet
    {
        /// <summary>
        /// The criteria for the set of competencies that represent completion or partial completion of a unit, course, program, degree, certification, or other achievement/award. Specifies whether completion requires achievement of all items in the set or some number of items.
        /// </summary>
        public System.Int32? ChildOf_CompetencySet { get; set; }

        /// <summary>
        /// The criteria for the set of competencies that represent completion or partial completion of a unit, course, program, degree, certification, or other achievement/award. Specifies whether completion requires achievement of all items in the set or some number of items.
        /// </summary>
        public System.Int32? CompletionCriteriaThreshold { get; set; }

        /// <summary>
        /// The criteria for the set of competencies that represent completion or partial completion of a unit, course, program, degree, certification, or other achievement/award. Specifies whether completion requires achievement of all items in the set or some number of items.
        /// </summary>
        public Guid? RefCompletionCriteriaId { get; set; }

    }
}
