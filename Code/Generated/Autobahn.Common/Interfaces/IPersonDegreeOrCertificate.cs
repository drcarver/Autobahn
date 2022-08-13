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
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        System.DateTime? AwardDate { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        System.String DegreeOrCertificateTitleOrSubject { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        System.String NameOfInstitution { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        Guid? RefDegreeOrCertificateTypeId { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        Guid? RefEducationVerificationMethodId { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

    }
}
