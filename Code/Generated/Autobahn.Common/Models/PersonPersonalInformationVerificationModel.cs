//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonPersonalInformationVerificationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonPersonalInformationVerification Model
     /// </summary>
    public partial class PersonPersonalInformationVerificationModel : AutobahnBase, Interfaces.IPersonPersonalInformationVerification
    {
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
        public  RefPersonalInformationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefPersonalInformationVerificationId { get; set; }

    }
}
