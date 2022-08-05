//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaPreKEligibleAgesIDEA.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaPreKEligibleAgesIDEA
     /// </summary>
    public partial class K12LeaPreKEligibleAgesIDEA : AutobahnBase, Interfaces.IK12LeaPreKEligibleAgesIDEA
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12LEAPreKEligibleAgesIDEA"/> model
        /// </summary>
        public Guid K12LEAPreKEligibleAgesIDEAId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPreKEligibleAgesNonIDEA"/> model
        /// </summary>
        public Guid RefPreKEligibleAgesNonIDEAId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
