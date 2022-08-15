//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SchoolCorrectiveAction.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolCorrectiveAction Interface
     /// </summary>
    public partial interface IK12SchoolCorrectiveAction : IAutobahnBase
    {
        /// <summary>
        /// The types of corrective actions under ESEA as amended.
        /// </summary>
        Guid RefCorrectiveActionTypeId { get; set; }

    }
}
