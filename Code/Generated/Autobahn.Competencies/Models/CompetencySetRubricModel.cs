//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricModel.cs
//***************************************************************************

using Autobahn.Interfaces.Competencies;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencySetRubric Model
     /// </summary>
    public partial class CompetencySetRubricModel : AutobahnBase, ICompetencySetRubric
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
        /// </summary>
        public Guid CompetencySetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRubric"/> model
        /// </summary>
        public Guid RubricId { get; set; }

    }
}
