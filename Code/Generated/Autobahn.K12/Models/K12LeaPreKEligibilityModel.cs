//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaPreKeligibilityModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12leaPreKeligibility Model
     /// </summary>
    public partial class K12leaPreKeligibilityModel : AutobahnBase, IK12leaPreKeligibility
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        public Guid K12leaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12leapreKeligibility"/> model
        /// </summary>
        public Guid K12leapreKeligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrekindergartenEligibility"/> model
        /// </summary>
        public Guid RefPrekindergartenEligibilityId { get; set; }

    }
}
