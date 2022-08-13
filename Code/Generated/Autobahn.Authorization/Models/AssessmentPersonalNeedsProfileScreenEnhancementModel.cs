//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentPersonalNeedsProfileScreenEnhancementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileScreenEnhancement Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileScreenEnhancementModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedsProfileScreenEnhancement
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get; set; }

    }
}
