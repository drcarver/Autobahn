//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffCredential.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffCredential Interface
     /// </summary>
    public partial interface IStaffCredential : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         CardiopulmonaryResuscitationCertification { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CTEInstructorIndustryCertification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FirstAidCertification { get; set; }

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
         RefAeCertificationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefChildDevAssociateTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefParaprofessionalQualificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProgramSponsorTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTeachingCredentialBasisId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTeachingCredentialTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TechnologySkillsStandardsMet { get; set; }

    }
}
