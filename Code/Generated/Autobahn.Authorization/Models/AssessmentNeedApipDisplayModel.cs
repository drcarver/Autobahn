//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentNeedApipDisplayModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentNeedApipDisplay Model
     /// </summary>
    public partial class AssessmentNeedApipDisplayModel : AutobahnBase, Interfaces.IAssessmentNeedApipDisplay
    {
        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? EncouragementActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? EncouragementAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.String EncouragementSoundFileUrl { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.String EncouragementTextMessagingString { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? MaskingActivateByDefaultIndicator { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? MaskingAssignedSupportIndicator { get; set; }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public Guid? RefAssessmentNeedMaskingTypeId { get; set; }

    }
}
