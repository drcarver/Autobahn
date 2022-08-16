//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentEmployment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentEmployment Interface
     /// </summary>
    public partial interface IPsStudentEmployment : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         EmploymentNaicsCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefEmployedAfterExitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefEmployedWhileEnrolledId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefEmploymentStatusWhileEnrolledId { get; set; }

    }
}
