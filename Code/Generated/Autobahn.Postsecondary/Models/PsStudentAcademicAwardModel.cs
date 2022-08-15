//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicAwardModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentAcademicAward Model
     /// </summary>
    public partial class PsStudentAcademicAwardModel : AutobahnBase, Interfaces.IPsStudentAcademicAward
    {
        /// <summary>
        /// The year, month and day or year and month on which the academic award was conferred.
        /// </summary>
        public System.String AcademicAwardDate { get; set; }

    }
}
