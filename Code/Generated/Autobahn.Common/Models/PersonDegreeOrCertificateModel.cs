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
        /// 
        /// </summary>
        public Guid? AwardDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DegreeOrCertificateTitleOrSubject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NameOfInstitution { get; set; }

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
        public  RefDegreeOrCertificateTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefEducationVerificationMethodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefHigherEducationInstitutionAccreditationStatusId { get; set; }

    }
}
