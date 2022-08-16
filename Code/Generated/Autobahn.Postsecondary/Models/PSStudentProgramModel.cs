//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PSStudentProgramModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PSStudentProgram Model
     /// </summary>
    public partial class PSStudentProgramModel : AutobahnBase, Interfaces.IPSStudentProgram
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
        public  RefCareerClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefCipUseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTransferOutIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
