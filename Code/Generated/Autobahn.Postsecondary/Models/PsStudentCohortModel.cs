//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCohortModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentCohort Model
     /// </summary>
    public partial class PsStudentCohortModel : AutobahnBase, Interfaces.IPsStudentCohort
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? CohortGraduationYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
