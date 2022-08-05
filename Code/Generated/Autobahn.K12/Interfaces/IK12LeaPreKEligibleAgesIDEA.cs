//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12LeaPreKEligibleAgesIDEA.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaPreKEligibleAgesIDEA
     /// </summary>
    public partial interface IK12LeaPreKEligibleAgesIDEA : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12LEAPreKEligibleAgesIDEA"/> model
        /// </summary>
        Guid K12LEAPreKEligibleAgesIDEAId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPreKEligibleAgesNonIDEA"/> model
        /// </summary>
        Guid RefPreKEligibleAgesNonIDEAId { get; set; }

    }
}
