//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentAdmissionTest.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentAdmissionTest Interface
     /// </summary>
    public partial interface IPsStudentAdmissionTest : IAutobahnBase
    {
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
         RefStandardizedAdmissionTestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? StandardizedAdmissionTestScore { get; set; }

    }
}
