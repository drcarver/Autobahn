//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileContentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileContent Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileContentModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedsProfileContent
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
        /// </summary>
        public Guid? RefAssessmentNeedHazardTypeId { get; set; }

    }
}
