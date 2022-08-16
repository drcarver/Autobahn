//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIdentifierModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationIdentifier Model
     /// </summary>
    public partial class OrganizationIdentifierModel : AutobahnBase, Interfaces.IOrganizationIdentifier
    {
        /// <summary>
        /// 
        /// </summary>
        public  Identifier { get; set; }

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
        public  RefOrganizationIdentificationSystemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefOrganizationIdentifierTypeId { get; set; }

    }
}
