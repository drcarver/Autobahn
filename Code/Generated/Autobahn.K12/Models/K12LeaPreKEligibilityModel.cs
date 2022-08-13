//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaPreKEligibilityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaPreKEligibility Model
     /// </summary>
    public partial class K12LeaPreKEligibilityModel : AutobahnBase, Interfaces.IK12LeaPreKEligibility
    {
        /// <summary>
        /// The groups of students for whom pre-kindergarten programs are available.
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// The groups of students for whom pre-kindergarten programs are available.
        /// </summary>
        public Guid K12LEAPreKEligibilityId { get; set; }

        /// <summary>
        /// The groups of students for whom pre-kindergarten programs are available.
        /// </summary>
        public Guid RefPrekindergartenEligibilityId { get; set; }

    }
}
