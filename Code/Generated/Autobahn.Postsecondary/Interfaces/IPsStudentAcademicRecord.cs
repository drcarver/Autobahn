//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentAcademicRecord.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentAcademicRecord Interface
     /// </summary>
    public partial interface IPsStudentAcademicRecord : IAutobahnBase
    {
        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        System.Int32? AdvancedPlacementCreditsAwarded { get; set; }

    }
}
