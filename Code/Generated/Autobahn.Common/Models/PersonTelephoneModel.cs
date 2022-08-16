//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonTelephoneModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonTelephone Model
     /// </summary>
    public partial class PersonTelephoneModel : AutobahnBase, Interfaces.IPersonTelephone
    {
        /// <summary>
        /// 
        /// </summary>
        public  DoNotPublishIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? PrimaryTelephoneNumberIndicator { get; set; }

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
        public  RefPersonTelephoneNumberTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTelephoneNumberListedStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TelephoneNumber { get; set; }

    }
}
