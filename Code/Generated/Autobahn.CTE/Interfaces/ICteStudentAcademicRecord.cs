//***************************************************************************
//* DomainName: Career and Technical Education (CTE) Interfaces (used by both models and View Models
//* FileName:   ICteStudentAcademicRecord.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.CTE.Interfaces
{
     /// <summary>
     /// The ICteStudentAcademicRecord Interface
     /// </summary>
    public partial interface ICteStudentAcademicRecord : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DiplomaOrCredentialAwardDate { get; set; }

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
         RefProfessionalTechnicalCredentialTypeId { get; set; }

    }
}
