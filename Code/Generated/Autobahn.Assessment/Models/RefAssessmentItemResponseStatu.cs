//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentItemResponseStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefAssessmentItemResponseStatu Model
     /// </summary>
    public partial class RefAssessmentItemResponseStatu : ReferenceModelBase, IRefAssessmentItemResponseStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentItemResponseStatus"/> model
        /// </summary>
        public Guid RefAssessmentItemResponseStatusId { get; set; }

    }
}
