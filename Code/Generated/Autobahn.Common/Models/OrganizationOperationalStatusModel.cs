//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationOperationalStatusModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationOperationalStatus Model
     /// </summary>
    public partial class OrganizationOperationalStatusModel : AutobahnBase, Interfaces.IOrganizationOperationalStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public  OperationalStatusEffectiveDate { get; set; }

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
        public Guid? RefOperationalStatusId { get; set; }

    }
}
