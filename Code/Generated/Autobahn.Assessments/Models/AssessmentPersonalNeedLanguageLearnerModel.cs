//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedLanguageLearnerModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedLanguageLearner Model
     /// </summary>
    public partial class AssessmentPersonalNeedLanguageLearnerModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedLanguageLearner
    {
        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? ActivateByDefault { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public Guid AssessmentNeedsProfileContentId { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? AssignedSupport { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public Guid RefAssessmentNeedsProfileContentLanguageLearnerTypeId { get; set; }

    }
}
