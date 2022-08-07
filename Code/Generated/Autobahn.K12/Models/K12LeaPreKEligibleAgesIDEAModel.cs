//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaPreKEligibleAgesIDEAModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaPreKEligibleAgesIDEA Model
     /// </summary>
    public partial class K12LeaPreKEligibleAgesIDEAModel : AutobahnBase, Interfaces.IK12LeaPreKEligibleAgesIDEAModel
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
