//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaPreKeligibleAgesIdeaModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12leaPreKeligibleAgesIdea Model
     /// </summary>
    public partial class K12leaPreKeligibleAgesIdeaModel : AutobahnBase, IK12leaPreKeligibleAgesIdea
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        public Guid K12leaId { get; set; }

        public System.Int32 K12leapreKeligibleAgesIdeaid { get; set; }

        public System.Int32 RefPreKeligibleAgesNonIdeaid { get; set; }

    }
}
