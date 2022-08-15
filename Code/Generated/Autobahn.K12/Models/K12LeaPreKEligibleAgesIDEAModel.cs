//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaPreKEligibleAgesIDEAModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaPreKEligibleAgesIDEA Model
     /// </summary>
    public partial class K12LeaPreKEligibleAgesIDEAModel : AutobahnBase, Interfaces.IK12LeaPreKEligibleAgesIDEA
    {
        /// <summary>
        /// The ages of children not served under IDEA to whom the LEA's pre-kindergarten services are available.  
        /// </summary>
        public Guid RefPreKEligibleAgesNonIDEAId { get; set; }

    }
}
