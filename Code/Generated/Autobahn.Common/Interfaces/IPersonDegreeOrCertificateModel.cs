//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonDegreeOrCertificateModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDegreeOrCertificateModel Interface
     /// </summary>
    public partial interface IPersonDegreeOrCertificateModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonDegreeOrCertificate.DegreeOrCertificateTitleOrSubject non nullable property
        /// </summary>
        System.String DegreeOrCertificateTitleOrSubject { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDegreeOrCertificateType"/> model
        /// </summary>
        Guid? RefDegreeOrCertificateTypeId { get; set; }

        /// <summary>
        /// Defines the PersonDegreeOrCertificate.AwardDate nullable property
        /// </summary>
        System.DateTime? AwardDate { get; set; }

        /// <summary>
        /// Defines the PersonDegreeOrCertificate.NameOfInstitution non nullable property
        /// </summary>
        System.String NameOfInstitution { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHigherEducationInstitutionAccreditationStatus"/> model
        /// </summary>
        Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationVerificationMethod"/> model
        /// </summary>
        Guid? RefEducationVerificationMethodId { get; set; }

    }
}
