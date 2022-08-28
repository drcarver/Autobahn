//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentFormAssessmentAsset.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentFormAssessmentAsset Interface
     /// </summary>
    public partial interface IAssessmentFormAssessmentAsset : IAutobahnBase
    {
        #region IAssessmentFormAssessmentAsset
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAsset"/> model
        /// </summary>
        Guid AssessmentAssetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
        /// </summary>
        Guid AssessmentFormId { get; set; }

        #endregion
    }
}
