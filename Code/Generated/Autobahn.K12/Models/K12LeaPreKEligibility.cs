//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaPreKEligibility.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaPreKEligibility
     /// </summary>
    public partial class K12LeaPreKEligibility : AutobahnBase, Interfaces.IK12LeaPreKEligibility
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12LEAPreKEligibility"/> model
        /// </summary>
        public Guid K12LEAPreKEligibilityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPrekindergartenEligibility"/> model
        /// </summary>
        public Guid RefPrekindergartenEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
