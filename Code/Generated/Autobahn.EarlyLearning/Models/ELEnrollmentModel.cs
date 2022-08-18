//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELEnrollmentModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELEnrollment Model
     /// </summary>
    public partial class ELEnrollmentModel : AutobahnBase, Interfaces.IELEnrollment
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IELClassSection"/> model
        /// </summary>
        public Guid? ELClassSectionId { get; set; }

        /// <summary>
        /// Enrollment Date
        /// <para>
        /// The year, month and day on which a person is considered officially enrolled in the program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19324">Enrollment Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? EnrollmentDate { get; set; }

        /// <summary>
        /// Number of Days in Attendance
        /// <para>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19202">Number of Days in Attendance</a>
        /// </para>
        /// </summary>
        public System.Decimal? NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFederalFundingType"/> model
        /// </summary>
        public Guid? RefELFederalFundingTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFoodServiceParticipation"/> model
        /// </summary>
        public Guid? RefFoodServiceParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEnvironmentEL"/> model
        /// </summary>
        public Guid? RefIDEAEnvironmentELId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
        /// </summary>
        public Guid? RefServiceOptionId { get; set; }

    }
}
