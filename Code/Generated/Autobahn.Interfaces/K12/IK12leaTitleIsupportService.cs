//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12leaTitleIsupportService.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12leaTitleIsupportService Interface
     /// </summary>
    public partial interface IK12leaTitleIsupportService : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        Guid K12leaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12leaTitleIsupportService"/> model
        /// </summary>
        Guid RefK12leaTitleIsupportServiceId { get; set; }

    }
}
