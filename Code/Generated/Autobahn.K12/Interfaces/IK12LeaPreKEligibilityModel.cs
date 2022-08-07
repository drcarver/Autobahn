//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12LeaPreKEligibilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaPreKEligibilityModel Interface
     /// </summary>
    public partial interface IK12LeaPreKEligibilityModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12LEAPreKEligibility"/> model
        /// </summary>
        Guid K12LEAPreKEligibilityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPrekindergartenEligibility"/> model
        /// </summary>
        Guid RefPrekindergartenEligibilityId { get; set; }

    }
}
