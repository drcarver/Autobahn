//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationImageModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationImage Model
     /// </summary>
    public partial class OrganizationImageModel : AutobahnBase, Interfaces.IOrganizationImage
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
        public Guid? URL { get; set; }

    }
}
