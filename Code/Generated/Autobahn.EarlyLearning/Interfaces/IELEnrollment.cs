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
        /// Reference to an optional instance of the <see cref="IELClassSection"/> model
        /// </summary>
        Guid? ELClassSectionId { get; set; }

        /// <summary>
        /// Enrollment Date
        /// <para>
        /// The year, month and day on which a person is considered officially enrolled in the program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19324">Enrollment Date</a>
        /// </para>
        /// </summary>
        System.DateTime? EnrollmentDate { get; set; }

        /// <summary>
        /// Number of Days in Attendance
        /// <para>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19202">Number of Days in Attendance</a>
        /// </para>
        /// </summary>
        System.Decimal? NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefELFederalFundingType"/> model
        /// </summary>
        Guid? RefELFederalFundingTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFoodServiceParticipation"/> model
        /// </summary>
        Guid? RefFoodServiceParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIDEAEnvironmentEL"/> model
        /// </summary>
        Guid? RefIDEAEnvironmentELId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefServiceOption"/> model
        /// </summary>
        Guid? RefServiceOptionId { get; set; }

    }
}
