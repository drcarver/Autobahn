//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12CharterSchoolManagementOrganization.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12CharterSchoolManagementOrganization
     /// </summary>
    public partial class K12CharterSchoolManagementOrganization : IK12CharterSchoolManagementOrganization
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterSchoolManagementOrganizationType"/> model
        /// </summary>
        public Guid? RefCharterSchoolManagementOrganizationTypeId { get; set; }

        /// <summary>
        /// Defines the K12CharterSchoolManagementOrganization.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12CharterSchoolManagementOrganization.RecordEndDateTime nullable property
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
