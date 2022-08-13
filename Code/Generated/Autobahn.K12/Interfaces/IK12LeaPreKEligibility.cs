//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12LeaPreKEligibility.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaPreKEligibility Interface
     /// </summary>
    public partial interface IK12LeaPreKEligibility : IAutobahnBase
    {
        /// <summary>
        /// The groups of students for whom pre-kindergarten programs are available.
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// The groups of students for whom pre-kindergarten programs are available.
        /// </summary>
        Guid K12LEAPreKEligibilityId { get; set; }

        /// <summary>
        /// The groups of students for whom pre-kindergarten programs are available.
        /// </summary>
        Guid RefPrekindergartenEligibilityId { get; set; }

    }
}
