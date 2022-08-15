//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemResponseModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentItemResponse Model
     /// </summary>
    public partial class AssessmentItemResponseModel : AutobahnBase, Interfaces.IAssessmentItemResponse
    {
        /// <summary>
        /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
        /// </summary>
        public System.TimeSpan? Duration { get; set; }

    }
}
