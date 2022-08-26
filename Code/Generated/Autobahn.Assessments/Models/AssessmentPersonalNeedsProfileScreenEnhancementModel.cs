//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileScreenEnhancementModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileScreenEnhancement Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileScreenEnhancementModel : AutobahnBase, IAssessmentPersonalNeedsProfileScreenEnhancement
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get; set; }

    }
}
