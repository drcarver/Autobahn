//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentFormSectionAssessmentAsset.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentFormSectionAssessmentAsset Interface
     /// </summary>
    public partial interface IAssessmentFormSectionAssessmentAsset : IAutobahnBase
    {
        #region IAssessmentFormSectionAssessmentAsset
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentAsset"/> model
        /// </summary>
        Guid AssessmentAssetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
        /// </summary>
        Guid AssessmentFormSectionId { get; set; }

        #endregion
    }
}
