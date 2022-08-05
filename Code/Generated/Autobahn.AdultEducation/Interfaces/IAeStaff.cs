//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   IAeStaff.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeStaff
     /// </summary>
    public partial interface IAeStaff : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the AeStaff.YearsOfPriorAeTeachingExperience nullable property
        /// </summary>
        System.Decimal? YearsOfPriorAeTeachingExperience { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffClassification"/> model
        /// </summary>
        Guid? RefAeStaffClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffEmploymentStatus"/> model
        /// </summary>
        Guid? RefAeStaffEmploymentStatusId { get; set; }

    }
}
