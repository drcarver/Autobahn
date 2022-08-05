//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedsProfileDisplay.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileDisplay
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileDisplay : AutobahnBase, Interfaces.IAssessmentPersonalNeedsProfileDisplay
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfile"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
