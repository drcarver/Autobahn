//***************************************************************************
//* DomainName: Adult Education (AE) Interfaces (used by both models and View Models
//* FileName:   IAeStudentAcademicRecord.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeStudentAcademicRecord Interface
     /// </summary>
    public partial interface IAeStudentAcademicRecord : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? DiplomaOrCredentialAwardDate { get; set; }

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
         RefHighSchoolDiplomaTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProfessionalTechnicalCredentialTypeId { get; set; }

    }
}
