//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDegreeOrCertificateModel.cs
//* Name:       Diploma or Credential Award Date
//* Definition: The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
     /// </summary>
    public partial class PersonDegreeOrCertificateModel : AutobahnBase, Interfaces.IPersonDegreeOrCertificate
    {
        /// <summary>
        /// Diploma or Credential Award Date
        /// <para>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? AwardDate { get; set; }

        /// <summary>
        /// Degree or Certificate Title or Subject
        /// <para>
        /// The name of the degree or certificate earned by a person. This includes honorary degrees conferred upon an individual.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19341">Degree or Certificate Title or Subject</a>
        /// </para>
        /// </summary>
        public System.String DegreeOrCertificateTitleOrSubject { get; set; }

        /// <summary>
        /// Name of Institution
        /// <para>
        /// The full legally accepted name of the institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19191">Name of Institution</a>
        /// </para>
        /// </summary>
        public System.String NameOfInstitution { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDegreeOrCertificateType"/> model
        /// </summary>
        public Guid? RefDegreeOrCertificateTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationVerificationMethod"/> model
        /// </summary>
        public Guid? RefEducationVerificationMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHigherEducationInstitutionAccreditationStatus"/> model
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

    }
}
