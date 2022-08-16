//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationServiceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationService Model
     /// </summary>
    public partial class OrganizationServiceModel : AutobahnBase, Interfaces.IOrganizationService
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
        public Guid? RefStudentSupportServiceTypeId { get; set; }

    }
}
