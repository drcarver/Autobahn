//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IStaffCredential.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffCredential
     /// </summary>
    public partial interface IStaffCredential : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonCredential"/> model
        /// </summary>
        Guid PersonCredentialId { get; set; }

        /// <summary>
        /// Defines the StaffCredential.TechnologySkillsStandardsMet nullable property
        /// </summary>
        System.Boolean? TechnologySkillsStandardsMet { get; set; }

        /// <summary>
        /// Defines the StaffCredential.DiplomaOrCredentialAwardDate non nullable property
        /// </summary>
        System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Defines the StaffCredential.CTEInstructorIndustryCertification nullable property
        /// </summary>
        System.Boolean? CTEInstructorIndustryCertification { get; set; }

        /// <summary>
        /// Defines the StaffCredential.CardiopulmonaryResuscitationCertification nullable property
        /// </summary>
        System.DateTime? CardiopulmonaryResuscitationCertification { get; set; }

        /// <summary>
        /// Defines the StaffCredential.FirstAidCertification nullable property
        /// </summary>
        System.DateTime? FirstAidCertification { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialType"/> model
        /// </summary>
        Guid? RefTeachingCredentialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        Guid? RefTeachingCredentialBasisId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefChildDevAssociateType"/> model
        /// </summary>
        Guid? RefChildDevAssociateTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParaprofessionalQualification"/> model
        /// </summary>
        Guid? RefParaprofessionalQualificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramSponsorType"/> model
        /// </summary>
        Guid? RefProgramSponsorTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeCertificationType"/> model
        /// </summary>
        Guid? RefAeCertificationTypeId { get; set; }

    }
}
