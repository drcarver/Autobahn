//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPopulationServedModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPopulationServed Model
     /// </summary>
    public partial class OrganizationPopulationServedModel : AutobahnBase, Interfaces.IOrganizationPopulationServed
    {
        /// <summary>
        /// 
        /// </summary>
        public  OldestAgeServed { get; set; }

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
        public  RefPopulationServedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? YoungestAgeServed { get; set; }

    }
}
