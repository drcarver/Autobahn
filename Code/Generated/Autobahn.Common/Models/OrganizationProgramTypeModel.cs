//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationProgramTypeModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationProgramType Model
     /// </summary>
    public partial class OrganizationProgramTypeModel : AutobahnBase, Interfaces.IOrganizationProgramType
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
        public Guid? RefProgramTypeId { get; set; }

    }
}
