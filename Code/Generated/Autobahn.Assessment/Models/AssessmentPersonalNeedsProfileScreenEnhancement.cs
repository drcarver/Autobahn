//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentPersonalNeedsProfileScreenEnhancement.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileScreenEnhancement
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileScreenEnhancement : AutobahnBase, Interfaces.IAssessmentPersonalNeedsProfileScreenEnhancement
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
