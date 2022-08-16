//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonEmailAddressModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonEmailAddress Model
     /// </summary>
    public partial class PersonEmailAddressModel : AutobahnBase, Interfaces.IPersonEmailAddress
    {
        /// <summary>
        /// 
        /// </summary>
        public  DoNotPublishIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? EmailAddress { get; set; }

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
        public  RefEmailTypeId { get; set; }

    }
}
