//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationLocationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationLocation Model
     /// </summary>
    public partial class OrganizationLocationModel : AutobahnBase, Interfaces.IOrganizationLocation
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
        public Guid? RefOrganizationLocationTypeId { get; set; }

    }
}
