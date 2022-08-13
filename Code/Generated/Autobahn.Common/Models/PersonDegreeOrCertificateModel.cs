//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDegreeOrCertificateModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDegreeOrCertificate Model
     /// </summary>
    public partial class PersonDegreeOrCertificateModel : AutobahnBase, Interfaces.IPersonDegreeOrCertificate
    {
        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public System.DateTime? AwardDate { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public System.String DegreeOrCertificateTitleOrSubject { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public System.String NameOfInstitution { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public Guid? RefDegreeOrCertificateTypeId { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public Guid? RefEducationVerificationMethodId { get; set; }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

    }
}
