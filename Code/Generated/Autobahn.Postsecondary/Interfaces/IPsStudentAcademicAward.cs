//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentAcademicAward.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentAcademicAward Interface
     /// </summary>
    public partial interface IPsStudentAcademicAward : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day or year and month on which the academic award was conferred.
        /// </summary>
        System.String AcademicAwardDate { get; set; }

    }
}
