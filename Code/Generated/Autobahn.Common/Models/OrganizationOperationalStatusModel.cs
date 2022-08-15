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
        /// The classification of the operational condition of a local education agency (LEA) at the start of the school year.
        /// </summary>
        public Guid RefOperationalStatusId { get; set; }

    }
}
