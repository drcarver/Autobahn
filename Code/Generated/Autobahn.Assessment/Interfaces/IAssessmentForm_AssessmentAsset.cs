//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentForm_AssessmentAsset.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentForm_AssessmentAsset
     /// </summary>
    public partial interface IAssessmentForm_AssessmentAsset : IAutobahnBase
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
