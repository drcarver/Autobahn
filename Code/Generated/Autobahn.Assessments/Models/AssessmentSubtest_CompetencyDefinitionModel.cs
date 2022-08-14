//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtest_CompetencyDefinitionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentSubtest_CompetencyDefinition Model
     /// </summary>
    public partial class AssessmentSubtest_CompetencyDefinitionModel : AutobahnBase, Interfaces.IAssessmentSubtest_CompetencyDefinition
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
