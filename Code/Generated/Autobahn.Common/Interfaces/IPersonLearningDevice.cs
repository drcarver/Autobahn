//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonLearningDevice.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonLearningDevice
     /// </summary>
    public partial interface IPersonLearningDevice : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceAccess"/> model
        /// </summary>
        Guid? RefPrimaryLearningDeviceAccessId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceAwayFromSchool"/> model
        /// </summary>
        Guid? RefPrimaryLearningDeviceAwayFromSchoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrimaryLearningDeviceProvider"/> model
        /// </summary>
        Guid? RefPrimaryLearningDeviceProviderId { get; set; }

    }
}
