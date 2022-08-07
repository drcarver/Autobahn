//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentForm_AssessmentAssetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentForm_AssessmentAssetModel Interface
     /// </summary>
    public partial interface IAssessmentForm_AssessmentAssetModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentForm"/> model
        /// </summary>
        Guid AssessmentFormId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAsset"/> model
        /// </summary>
        Guid AssessmentAssetId { get; set; }

    }
}
