//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonLearningDevice.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonLearningDevice
     /// </summary>
    public partial class PersonLearningDevice : IPersonLearningDevice
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceAccess"/> model
        /// </summary>
        public Guid? RefPrimaryLearningDeviceAccessId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceAwayFromSchool"/> model
        /// </summary>
        public Guid? RefPrimaryLearningDeviceAwayFromSchoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceProvider"/> model
        /// </summary>
        public Guid? RefPrimaryLearningDeviceProviderId { get; set; }

        /// <summary>
        /// Defines the PersonLearningDevice.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonLearningDevice.RecordEndDateTime nullable property
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
