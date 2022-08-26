//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentAssetModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentFormAssessmentAsset Model
     /// </summary>
    public partial class AssessmentFormAssessmentAssetModel : AutobahnBase, IAssessmentFormAssessmentAsset
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAsset"/> model
        /// </summary>
        public Guid AssessmentAssetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
        /// </summary>
        public Guid AssessmentFormId { get; set; }

    }
}
