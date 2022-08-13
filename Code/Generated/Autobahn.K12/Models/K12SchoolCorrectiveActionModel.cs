//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolCorrectiveActionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolCorrectiveAction Model
     /// </summary>
    public partial class K12SchoolCorrectiveActionModel : AutobahnBase, Interfaces.IK12SchoolCorrectiveAction
    {
        /// <summary>
        /// The types of corrective actions under ESEA as amended.
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// The types of corrective actions under ESEA as amended.
        /// </summary>
        public Guid RefCorrectiveActionTypeId { get; set; }

    }
}
