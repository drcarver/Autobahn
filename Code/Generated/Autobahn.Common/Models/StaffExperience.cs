//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffExperience.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffExperience
     /// </summary>
    public partial class StaffExperience : AutobahnBase, Interfaces.IStaffExperience
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the StaffExperience.YearsOfPriorTeachingExperience nullable property
        /// </summary>
        public System.Decimal? YearsOfPriorTeachingExperience { get; set; }

        /// <summary>
        /// Defines the StaffExperience.YearsOfPriorAETeachingExperience nullable property
        /// </summary>
        public System.Decimal? YearsOfPriorAETeachingExperience { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
