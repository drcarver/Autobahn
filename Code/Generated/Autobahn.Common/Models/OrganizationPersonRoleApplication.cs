//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationPersonRoleApplication.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPersonRoleApplication
     /// </summary>
    public partial class OrganizationPersonRoleApplication : IOrganizationPersonRoleApplication
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRoleApplication.ApplicationDate non nullable property
        /// </summary>
        public System.DateTime ApplicationDate { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRoleApplication.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRoleApplication.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
