//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleFTEModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRoleFTE Model
     /// </summary>
    public partial class OrganizationPersonRoleFTEModel : AutobahnBase, Interfaces.IOrganizationPersonRoleFTE
    {
        /// <summary>
        /// 
        /// </summary>
        public  FullTimeEquivalency { get; set; }

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
