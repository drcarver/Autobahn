//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentSection Model
     /// </summary>
    public partial class PsStudentSectionModel : AutobahnBase, Interfaces.IPsStudentSection
    {
        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        public System.String AcademicGrade { get; set; }

    }
}
