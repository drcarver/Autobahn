//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentPersonalNeedsProfileControlModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileControl Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileControlModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedsProfileControl
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get; set; }

    }
}
