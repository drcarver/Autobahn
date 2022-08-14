//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestCompetencyDefinitionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSubtestCompetencyDefinition Model
     /// </summary>
    public partial class AssessmentSubtestCompetencyDefinitionModel : AutobahnBase, Interfaces.IAssessmentSubtestCompetencyDefinition
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

    }
}
