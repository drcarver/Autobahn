//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELEnrollment.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELEnrollment
     /// </summary>
    public partial class ELEnrollment : AutobahnBase, Interfaces.IELEnrollment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ELEnrollment.EnrollmentDate nullable property
        /// </summary>
        public System.DateTime? EnrollmentDate { get; set; }

        /// <summary>
        /// Defines the ELEnrollment.NumberOfDaysInAttendance nullable property
        /// </summary>
        public System.Decimal? NumberOfDaysInAttendance { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ELClassSection"/> model
        /// </summary>
        public Guid? ELClassSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEnvironmentEL"/> model
        /// </summary>
        public Guid? RefIDEAEnvironmentELId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFoodServiceParticipation"/> model
        /// </summary>
        public Guid? RefFoodServiceParticipationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
        /// </summary>
        public Guid? RefServiceOptionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFederalFundingType"/> model
        /// </summary>
        public Guid? RefELFederalFundingTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
