//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentNeedScreenEnhancementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentNeedScreenEnhancement Model
     /// </summary>
    public partial class AssessmentNeedScreenEnhancementModel : AutobahnBase, Interfaces.IAssessmentNeedScreenEnhancement
    {
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// </summary>
        public Guid? AssessmentPersonalNeedsProfileScreenEnhancementId { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// </summary>
        public System.String ForegroundColor { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// </summary>
        public System.Boolean? InvertColorChoice { get; set; }

        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
        /// </summary>
        public System.Decimal? Magnification { get; set; }

    }
}
