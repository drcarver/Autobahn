//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentAssetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentFormAssessmentAsset Model
     /// </summary>
    public partial class AssessmentFormAssessmentAssetModel : AutobahnBase, Interfaces.IAssessmentFormAssessmentAsset
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
