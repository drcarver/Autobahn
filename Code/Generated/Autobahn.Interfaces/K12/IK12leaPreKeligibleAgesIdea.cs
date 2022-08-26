//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12leaPreKeligibleAgesIdea.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12leaPreKeligibleAgesIdea Interface
     /// </summary>
    public partial interface IK12leaPreKeligibleAgesIdea : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        Guid K12leaId { get; set; }

        System.Int32 K12leapreKeligibleAgesIdeaid { get; set; }

        System.Int32 RefPreKeligibleAgesNonIdeaid { get; set; }

    }
}
