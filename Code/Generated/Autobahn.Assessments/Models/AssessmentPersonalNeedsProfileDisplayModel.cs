//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileDisplayModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileDisplay Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileDisplayModel : AutobahnBase, IAssessmentPersonalNeedsProfileDisplay
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get; set; }

    }
}
