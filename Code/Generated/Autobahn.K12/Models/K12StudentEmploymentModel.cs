//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentEmploymentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentEmployment Model
     /// </summary>
    public partial class K12StudentEmploymentModel : AutobahnBase, Interfaces.IK12StudentEmployment
    {
        /// <summary>
        /// 
        /// </summary>
        public  EmploymentNaicsCode { get; set; }

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
        public  RefEmployedAfterExitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefEmployedWhileEnrolledId { get; set; }

    }
}
