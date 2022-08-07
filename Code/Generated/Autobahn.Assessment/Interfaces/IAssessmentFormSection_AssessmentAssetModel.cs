//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentFormSection_AssessmentAssetModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentFormSection_AssessmentAssetModel Interface
     /// </summary>
    public partial interface IAssessmentFormSection_AssessmentAssetModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentFormSection"/> model
        /// </summary>
        Guid AssessmentFormSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentAsset"/> model
        /// </summary>
        Guid AssessmentAssetId { get; set; }

    }
}
