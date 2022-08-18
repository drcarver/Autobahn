//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCredentialModel.cs
//* Name:       Cardiopulmonary Resuscitation Certification Expiration Date
//* Definition: The date an individual's cardiopulmonary resuscitation (CPR) training certification expires.
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The date an individual's cardiopulmonary resuscitation (CPR) training certification expires.
     /// </summary>
    public partial class StaffCredentialModel : AutobahnBase, Interfaces.IStaffCredential
    {
        /// <summary>
        /// Cardiopulmonary Resuscitation Certification Expiration Date
        /// <para>
        /// The date an individual's cardiopulmonary resuscitation (CPR) training certification expires.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20065">Cardiopulmonary Resuscitation Certification Expiration Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? CardiopulmonaryResuscitationCertification { get; set; }

        /// <summary>
        /// Career and Technical Education Instructor Industry Certification
        /// <para>
        /// An indication of whether a Career and Technical Education (CTE) instructor holds a current industry-recognized credential related to their teaching field.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20284">Career and Technical Education Instructor Industry Certification</a>
        /// </para>
        /// </summary>
        public System.Boolean? CTEInstructorIndustryCertification { get; set; }

        /// <summary>
        /// Diploma or Credential Award Date
        /// <para>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
        /// </para>
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// First Aid Certification Expiration Date
        /// <para>
        /// The date an individual's first aid training certification expires.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20066">First Aid Certification Expiration Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? FirstAidCertification { get; set; }

        /// <summary>
        /// Name of Professional Credential or License
        /// <para>
        /// The name of the license/credential awarded by a given profession.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20064">Name of Professional Credential or License</a>
        /// </para>
        /// </summary>
        public Guid PersonCredentialId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeCertificationType"/> model
        /// </summary>
        public Guid? RefAeCertificationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefChildDevAssociateType"/> model
        /// </summary>
        public Guid? RefChildDevAssociateTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParaprofessionalQualification"/> model
        /// </summary>
        public Guid? RefParaprofessionalQualificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramSponsorType"/> model
        /// </summary>
        public Guid? RefProgramSponsorTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        public Guid? RefTeachingCredentialBasisId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialType"/> model
        /// </summary>
        public Guid? RefTeachingCredentialTypeId { get; set; }

        /// <summary>
        /// Technology Skills Standards Met
        /// <para>
        /// An indication that the person has achieved acceptable performance on a standards-based profile of technology user skills as defined by the state.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19537">Technology Skills Standards Met</a>
        /// </para>
        /// </summary>
        public System.Boolean? TechnologySkillsStandardsMet { get; set; }

    }
}
