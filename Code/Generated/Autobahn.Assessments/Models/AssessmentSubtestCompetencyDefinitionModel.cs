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
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
