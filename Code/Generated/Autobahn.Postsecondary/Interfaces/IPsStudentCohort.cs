//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentCohort.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentCohort Interface
     /// </summary>
    public partial interface IPsStudentCohort : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? CohortGraduationYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
