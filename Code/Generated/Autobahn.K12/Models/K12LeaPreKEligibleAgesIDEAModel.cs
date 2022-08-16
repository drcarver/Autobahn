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
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefPreKEligibleAgesNonIDEAId { get; set; }

    }
}
