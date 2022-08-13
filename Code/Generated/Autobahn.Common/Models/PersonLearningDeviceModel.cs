//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLearningDeviceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonLearningDevice Model
     /// </summary>
    public partial class PersonLearningDeviceModel : AutobahnBase, Interfaces.IPersonLearningDevice
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? RefPrimaryLearningDeviceAccessId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? RefPrimaryLearningDeviceAwayFromSchoolId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? RefPrimaryLearningDeviceProviderId { get; set; }

    }
}
