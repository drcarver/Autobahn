//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12FederalFundAllocationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12FederalFundAllocation Model
     /// </summary>
    public partial class K12FederalFundAllocationModel : AutobahnBase, Interfaces.IK12FederalFundAllocation
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
