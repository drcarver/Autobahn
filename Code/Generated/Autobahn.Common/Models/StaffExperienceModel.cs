//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffExperienceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffExperience Model
     /// </summary>
    public partial class StaffExperienceModel : AutobahnBase, Interfaces.IStaffExperience
    {
        /// <summary>
        /// The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.
        /// </summary>
        public System.Decimal? YearsOfPriorAETeachingExperience { get; set; }

        /// <summary>
        /// The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.
        /// </summary>
        public System.Decimal? YearsOfPriorTeachingExperience { get; set; }

    }
}
