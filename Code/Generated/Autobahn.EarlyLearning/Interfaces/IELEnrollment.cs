//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELEnrollment.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELEnrollment
     /// </summary>
    public partial interface IELEnrollment : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ELEnrollment.EnrollmentDate nullable property
        /// </summary>
        System.DateTime? EnrollmentDate { get; set; }

        /// <summary>
        /// Defines the ELEnrollment.NumberOfDaysInAttendance nullable property
        /// </summary>
        System.Decimal? NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ELClassSection"/> model
        /// </summary>
        Guid? ELClassSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEnvironmentEL"/> model
        /// </summary>
        Guid? RefIDEAEnvironmentELId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFoodServiceParticipation"/> model
        /// </summary>
        Guid? RefFoodServiceParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
        /// </summary>
        Guid? RefServiceOptionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFederalFundingType"/> model
        /// </summary>
        Guid? RefELFederalFundingTypeId { get; set; }

    }
}
