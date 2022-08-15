//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfile Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedsProfile
    {
        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? AssignedSupportFlag { get; set; }

    }
}
