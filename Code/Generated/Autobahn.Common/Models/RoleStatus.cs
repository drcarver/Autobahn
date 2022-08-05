//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleStatus.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RoleStatus
     /// </summary>
    public partial class RoleStatus : AutobahnBase, Interfaces.IRoleStatus
    {
        /// <summary>
        /// Defines the RoleStatus.StatusStartDate non nullable property
        /// </summary>
        public System.DateTime StatusStartDate { get; set; }

        /// <summary>
        /// Defines the RoleStatus.StatusEndDate nullable property
        /// </summary>
        public System.DateTime? StatusEndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRoleStatus"/> model
        /// </summary>
        public Guid? RefRoleStatusId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
