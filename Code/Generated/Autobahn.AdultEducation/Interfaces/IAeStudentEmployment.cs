//***************************************************************************
//* DomainName: Adult Education (AE) Interfaces (used by both models and View Models
//* FileName:   IAeStudentEmployment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeStudentEmployment Interface
     /// </summary>
    public partial interface IAeStudentEmployment : IAutobahnBase
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

    }
}
