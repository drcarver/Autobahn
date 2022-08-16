//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationRelationshipModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationRelationship Model
     /// </summary>
    public partial class OrganizationRelationshipModel : AutobahnBase, Interfaces.IOrganizationRelationship
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
        public Guid? RefOrganizationRelationshipId { get; set; }

    }
}
