//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentRegistrationCompletionStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefAssessmentRegistrationCompletionStatu Model
     /// </summary>
    public partial class RefAssessmentRegistrationCompletionStatu : ReferenceModelBase, IRefAssessmentRegistrationCompletionStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentRegistrationCompletionStatus"/> model
        /// </summary>
        public Guid RefAssessmentRegistrationCompletionStatusId { get; set; }

    }
}
