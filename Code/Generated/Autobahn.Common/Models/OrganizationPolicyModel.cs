//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPolicyModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPolicy Model
     /// </summary>
    public partial class OrganizationPolicyModel : AutobahnBase, Interfaces.IOrganizationPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? PolicyType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
