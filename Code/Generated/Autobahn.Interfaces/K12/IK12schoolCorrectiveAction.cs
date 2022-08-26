//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12schoolCorrectiveAction.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12schoolCorrectiveAction Interface
     /// </summary>
    public partial interface IK12schoolCorrectiveAction : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12school"/> model
        /// </summary>
        Guid K12schoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCorrectiveActionType"/> model
        /// </summary>
        Guid RefCorrectiveActionTypeId { get; set; }

    }
}
