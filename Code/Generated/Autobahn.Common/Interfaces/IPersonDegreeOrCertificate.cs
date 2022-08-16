//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonDegreeOrCertificate.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDegreeOrCertificate Interface
     /// </summary>
    public partial interface IPersonDegreeOrCertificate : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? AwardDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DegreeOrCertificateTitleOrSubject { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NameOfInstitution { get; set; }

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
         RefDegreeOrCertificateTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefEducationVerificationMethodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefHigherEducationInstitutionAccreditationStatusId { get; set; }

    }
}
