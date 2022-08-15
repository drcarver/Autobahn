//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentItem Model
     /// </summary>
    public partial class AssessmentItemModel : AutobahnBase, Interfaces.IAssessmentItem
    {
        /// <summary>
        /// The specific type of assessment item.
        /// </summary>
        public Guid? RefAssessmentItemTypeId { get; set; }

    }
}
