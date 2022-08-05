//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefAssessmentItemResponseScoreStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The RefAssessmentItemResponseScoreStatu Interface
     /// </summary>
    public partial interface IRefAssessmentItemResponseScoreStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentItemResponseScoreStatus"/> model
        /// </summary>
        Guid RefAssessmentItemResponseScoreStatusId { get; set; }

    }
}
