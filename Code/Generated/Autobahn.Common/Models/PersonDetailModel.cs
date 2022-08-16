//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDetailModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDetail Model
     /// </summary>
    public partial class PersonDetailModel : AutobahnBase, Interfaces.IPersonDetail
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Birthdate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BirthdateVerification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  GenerationCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HispanicLatinoEthnicity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MiddleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Prefix { get; set; }

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
        public  RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProofOfResidencyTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSexId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefStateOfResidenceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTribalAffiliationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefUSCitizenshipStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefVisaTypeId { get; set; }

    }
}
