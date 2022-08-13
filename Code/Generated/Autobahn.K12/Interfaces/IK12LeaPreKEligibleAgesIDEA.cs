//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12LeaPreKEligibleAgesIDEA.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaPreKEligibleAgesIDEA Interface
     /// </summary>
    public partial interface IK12LeaPreKEligibleAgesIDEA : IAutobahnBase
    {
        /// <summary>
        /// The ages of children not served under IDEA to whom the LEA's pre-kindergarten services are available.  
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// The ages of children not served under IDEA to whom the LEA's pre-kindergarten services are available.  
        /// </summary>
        Guid K12LEAPreKEligibleAgesIDEAId { get; set; }

        /// <summary>
        /// The ages of children not served under IDEA to whom the LEA's pre-kindergarten services are available.  
        /// </summary>
        Guid RefPreKEligibleAgesNonIDEAId { get; set; }

    }
}
