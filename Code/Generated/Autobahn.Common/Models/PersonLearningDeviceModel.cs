//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLearningDeviceModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonLearningDevice Model
     /// </summary>
    public partial class PersonLearningDeviceModel : AutobahnBase, Interfaces.IPersonLearningDevice
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
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

    }
}
