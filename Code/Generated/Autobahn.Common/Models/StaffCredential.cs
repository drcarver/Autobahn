//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffCredential.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffCredential
     /// </summary>
    public partial class StaffCredential : IStaffCredential
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonCredential"/> model
        /// </summary>
        public Guid PersonCredentialId { get; set; }

        /// <summary>
        /// Defines the StaffCredential.TechnologySkillsStandardsMet nullable property
        /// </summary>
        public System.Boolean? TechnologySkillsStandardsMet { get; set; }

        /// <summary>
        /// Defines the StaffCredential.DiplomaOrCredentialAwardDate non nullable property
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Defines the StaffCredential.CTEInstructorIndustryCertification nullable property
        /// </summary>
        public System.Boolean? CTEInstructorIndustryCertification { get; set; }

        /// <summary>
        /// Defines the StaffCredential.CardiopulmonaryResuscitationCertification nullable property
        /// </summary>
        public System.DateTime? CardiopulmonaryResuscitationCertification { get; set; }

        /// <summary>
        /// Defines the StaffCredential.FirstAidCertification nullable property
        /// </summary>
        public System.DateTime? FirstAidCertification { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialType"/> model
        /// </summary>
        public Guid? RefTeachingCredentialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        public Guid? RefTeachingCredentialBasisId { get; set; }

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
        /// Defines the StaffCredential.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the StaffCredential.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeCertificationType"/> model
        /// </summary>
        public Guid? RefAeCertificationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
