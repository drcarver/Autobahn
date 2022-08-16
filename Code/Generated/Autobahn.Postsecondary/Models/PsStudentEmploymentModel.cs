//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentEmploymentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentEmployment Model
     /// </summary>
    public partial class PsStudentEmploymentModel : AutobahnBase, Interfaces.IPsStudentEmployment
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

        /// <summary>
        /// 
        /// </summary>
        public  RefEmploymentStatusWhileEnrolledId { get; set; }

    }
}
