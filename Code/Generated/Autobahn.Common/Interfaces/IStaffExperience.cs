//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffExperience.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffExperience Interface
     /// </summary>
    public partial interface IStaffExperience : IAutobahnBase
    {
        /// <summary>
        /// The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.
        /// </summary>
        System.Decimal? YearsOfPriorAETeachingExperience { get; set; }

        /// <summary>
        /// The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.
        /// </summary>
        System.Decimal? YearsOfPriorTeachingExperience { get; set; }

    }
}
