//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationWebsiteModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationWebsite Model
     /// </summary>
    public partial class OrganizationWebsiteModel : AutobahnBase, Interfaces.IOrganizationWebsite
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
        public Guid? Website { get; set; }

    }
}
