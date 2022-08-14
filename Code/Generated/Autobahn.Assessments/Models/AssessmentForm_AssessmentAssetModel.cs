//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentForm_AssessmentAssetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentForm_AssessmentAsset Model
     /// </summary>
    public partial class AssessmentForm_AssessmentAssetModel : AutobahnBase, Interfaces.IAssessmentForm_AssessmentAsset
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentAssetId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentFormId { get; set; }

    }
}
