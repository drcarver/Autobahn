//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefAssessmentRegistrationCompletionStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The RefAssessmentRegistrationCompletionStatu Interface
     /// </summary>
    public partial interface IRefAssessmentRegistrationCompletionStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentRegistrationCompletionStatus"/> model
        /// </summary>
        Guid RefAssessmentRegistrationCompletionStatusId { get; set; }

    }
}
