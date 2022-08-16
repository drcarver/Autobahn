//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolGradeLevelsApprovedModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolGradeLevelsApproved Model
     /// </summary>
    public partial class K12SchoolGradeLevelsApprovedModel : AutobahnBase, Interfaces.IK12SchoolGradeLevelsApproved
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefGradeLevelId { get; set; }

    }
}
