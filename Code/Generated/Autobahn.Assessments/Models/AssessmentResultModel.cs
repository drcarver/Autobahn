//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentResult Model
     /// </summary>
    public partial class AssessmentResultModel : AutobahnBase, Interfaces.IAssessmentResult
    {
        /// <summary>
        /// The score given to a person's response to an assessment item.
        /// </summary>
        public System.String ScoreValue { get; set; }

    }
}
