//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStudentEmploymentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeStudentEmployment Model
     /// </summary>
    public partial class AeStudentEmploymentModel : AutobahnBase, Interfaces.IAeStudentEmployment
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
