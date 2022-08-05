//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentItemResponseScoreStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The RefAssessmentItemResponseScoreStatu Model
     /// </summary>
    public partial class RefAssessmentItemResponseScoreStatu : ReferenceModelBase, IRefAssessmentItemResponseScoreStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentItemResponseScoreStatus"/> model
        /// </summary>
        public Guid RefAssessmentItemResponseScoreStatusId { get; set; }

    }
}
