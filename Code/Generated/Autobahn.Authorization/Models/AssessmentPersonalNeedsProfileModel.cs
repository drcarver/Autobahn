//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentPersonalNeedsProfileModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfile Model
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileModel : AutobahnBase, Interfaces.IAssessmentPersonalNeedsProfile
    {
        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? ActivateByDefault { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.String AssessmentNeedType { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? AssignedSupportFlag { get; set; }

    }
}
