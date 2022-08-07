//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDegreeOrCertificateModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDegreeOrCertificate Model
     /// </summary>
    public partial class PersonDegreeOrCertificateModel : AutobahnBase, Interfaces.IPersonDegreeOrCertificateModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonDegreeOrCertificate.DegreeOrCertificateTitleOrSubject non nullable property
        /// </summary>
        public System.String DegreeOrCertificateTitleOrSubject { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDegreeOrCertificateType"/> model
        /// </summary>
        public Guid? RefDegreeOrCertificateTypeId { get; set; }

        /// <summary>
        /// Defines the PersonDegreeOrCertificate.AwardDate nullable property
        /// </summary>
        public System.DateTime? AwardDate { get; set; }

        /// <summary>
        /// Defines the PersonDegreeOrCertificate.NameOfInstitution non nullable property
        /// </summary>
        public System.String NameOfInstitution { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHigherEducationInstitutionAccreditationStatus"/> model
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationVerificationMethod"/> model
        /// </summary>
        public Guid? RefEducationVerificationMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
