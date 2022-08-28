//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12leaPreKeligibility.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.K12
{
     /// <summary>
     /// The IK12leaPreKeligibility Interface
     /// </summary>
    public partial interface IK12leaPreKeligibility : IAutobahnBase
    {
        #region IK12leaPreKeligibility
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        Guid K12leaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12leapreKeligibility"/> model
        /// </summary>
        Guid K12leapreKeligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrekindergartenEligibility"/> model
        /// </summary>
        Guid RefPrekindergartenEligibilityId { get; set; }

        #endregion
    }
}
