//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileControlModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileControl Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileControlModel : AutobahnBase, IAssessmentPersonalNeedsProfileControl
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get; set; }

    }
}
