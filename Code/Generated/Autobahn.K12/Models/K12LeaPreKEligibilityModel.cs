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
        public Guid? RefPrekindergartenEligibilityId { get; set; }

    }
}
