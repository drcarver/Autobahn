//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIndicatorModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationIndicator Model
     /// </summary>
    public partial class OrganizationIndicatorModel : AutobahnBase, Interfaces.IOrganizationIndicator
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
        public Guid? RefOrganizationIndicatorId { get; set; }

    }
}
