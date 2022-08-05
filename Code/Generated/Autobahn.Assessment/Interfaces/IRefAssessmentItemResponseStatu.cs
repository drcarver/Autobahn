//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefAssessmentItemResponseStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The RefAssessmentItemResponseStatu Interface
     /// </summary>
    public partial interface IRefAssessmentItemResponseStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentItemResponseStatus"/> model
        /// </summary>
        Guid RefAssessmentItemResponseStatusId { get; set; }

    }
}
