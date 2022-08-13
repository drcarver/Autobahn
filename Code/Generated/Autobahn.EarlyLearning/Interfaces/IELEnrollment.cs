//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELEnrollment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELEnrollment Interface
     /// </summary>
    public partial interface IELEnrollment : IAutobahnBase
    {
        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        Guid? ELClassSectionId { get; set; }

        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        System.DateTime? EnrollmentDate { get; set; }

        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        System.Decimal? NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        Guid? RefELFederalFundingTypeId { get; set; }

        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        Guid? RefFoodServiceParticipationId { get; set; }

        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        Guid? RefIDEAEnvironmentELId { get; set; }

        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        Guid? RefServiceOptionId { get; set; }

    }
}
