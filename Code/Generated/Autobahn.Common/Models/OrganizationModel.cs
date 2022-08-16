//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Organization Model
     /// </summary>
    public partial class OrganizationModel : AutobahnBase, Interfaces.IOrganization
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
