//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PSStudentEnrollmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PSStudentEnrollment Model
     /// </summary>
    public partial class PSStudentEnrollmentModel : AutobahnBase, Interfaces.IPSStudentEnrollment
    {
        /// <summary>
        /// 
        /// </summary>
        public  DisplacedStudentStatus { get; set; }

    }
}
