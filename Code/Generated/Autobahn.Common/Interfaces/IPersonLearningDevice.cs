//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonLearningDevice.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonLearningDevice Interface
     /// </summary>
    public partial interface IPersonLearningDevice : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
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
