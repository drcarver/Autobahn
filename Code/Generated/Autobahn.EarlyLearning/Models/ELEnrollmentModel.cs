//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELEnrollmentModel.cs
//**********************************************************

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
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        public Guid? ELClassSectionId { get; set; }

        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        public System.DateTime? EnrollmentDate { get; set; }

        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        public System.Decimal? NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        public Guid? RefELFederalFundingTypeId { get; set; }

        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        public Guid? RefFoodServiceParticipationId { get; set; }

        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        public Guid? RefIDEAEnvironmentELId { get; set; }

        /// <summary>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </summary>
        public Guid? RefServiceOptionId { get; set; }

    }
}
