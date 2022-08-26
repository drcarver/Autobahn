//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentFormAssessmentAsset.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentFormAssessmentAsset Interface
     /// </summary>
    public partial interface IAssessmentFormAssessmentAsset : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAsset"/> model
        /// </summary>
        Guid AssessmentAssetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
        /// </summary>
        Guid AssessmentFormId { get; set; }

    }
}
