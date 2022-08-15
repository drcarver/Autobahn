//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipDisplayModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentNeedApipDisplay Model
     /// </summary>
    public partial class AssessmentNeedApipDisplayModel : AutobahnBase, Interfaces.IAssessmentNeedApipDisplay
    {
        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? EncouragementAssignedSupportIndicator { get; set; }

    }
}
