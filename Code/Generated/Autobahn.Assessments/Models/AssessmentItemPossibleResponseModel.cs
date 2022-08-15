//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemPossibleResponseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentItemPossibleResponse Model
     /// </summary>
    public partial class AssessmentItemPossibleResponseModel : AutobahnBase, Interfaces.IAssessmentItemPossibleResponse
    {
        /// <summary>
        /// A message provided to the person being assessed after giving a response that matches the possible response.
        /// </summary>
        public System.String FeedbackMessage { get; set; }

    }
}
