//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentSection.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentSection Interface
     /// </summary>
    public partial interface IPsStudentSection : IAutobahnBase
    {
        /// <summary>
        /// The final grade awarded for participation in the course. 
        /// </summary>
        System.String AcademicGrade { get; set; }

    }
}
