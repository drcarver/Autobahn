//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTelephoneModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationTelephone Model
     /// </summary>
    public partial class OrganizationTelephoneModel : AutobahnBase, Interfaces.IOrganizationTelephone
    {
        /// <summary>
        /// 
        /// </summary>
        public  DoNotPublishIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PrimaryTelephoneNumberIndicator { get; set; }

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
        public Guid? RefInstitutionTelephoneTypeId { get; set; }

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
