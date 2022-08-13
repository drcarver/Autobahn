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
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal FullTimeEquivalency { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

    }
}
