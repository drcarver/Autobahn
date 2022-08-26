//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestCompetencyDefinitionModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSubtestCompetencyDefinition Model
     /// </summary>
    public partial class AssessmentSubtestCompetencyDefinitionModel : AutobahnBase, IAssessmentSubtestCompetencyDefinition
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

    }
}
