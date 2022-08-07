//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtest_CompetencyDefinitionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentSubtest_CompetencyDefinition Model
     /// </summary>
    public partial class AssessmentSubtest_CompetencyDefinitionModel : AutobahnBase, Interfaces.IAssessmentSubtest_CompetencyDefinitionModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencyDefinition"/> model
        /// </summary>
        public Guid CompetencyDefinitionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
