//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAdmissionTestModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentAdmissionTest Model
     /// </summary>
    public partial class PsStudentAdmissionTestModel : AutobahnBase, Interfaces.IPsStudentAdmissionTest
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
        public  RefStandardizedAdmissionTestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? StandardizedAdmissionTestScore { get; set; }

    }
}
