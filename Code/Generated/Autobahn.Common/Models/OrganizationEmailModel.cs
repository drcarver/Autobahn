//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmailModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationEmail Model
     /// </summary>
    public partial class OrganizationEmailModel : AutobahnBase, Interfaces.IOrganizationEmail
    {
        /// <summary>
        /// 
        /// </summary>
        public  DoNotPublishIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ElectronicMailAddress { get; set; }

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
