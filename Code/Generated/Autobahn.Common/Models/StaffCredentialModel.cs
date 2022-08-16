//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCredentialModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffCredential Model
     /// </summary>
    public partial class StaffCredentialModel : AutobahnBase, Interfaces.IStaffCredential
    {
        /// <summary>
        /// 
        /// </summary>
        public  CardiopulmonaryResuscitationCertification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CTEInstructorIndustryCertification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FirstAidCertification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAeCertificationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefChildDevAssociateTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefParaprofessionalQualificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProgramSponsorTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTeachingCredentialBasisId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTeachingCredentialTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TechnologySkillsStandardsMet { get; set; }

    }
}
