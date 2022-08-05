//**********************************************************
//* DomainName: Autobahn.CareerandTechnical
//* FileName:   CteStudentAcademicRecord.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.CareerandTechnical.Models
{
     /// <summary>
     /// The CteStudentAcademicRecord
     /// </summary>
    public partial class CteStudentAcademicRecord : AutobahnBase, Interfaces.ICteStudentAcademicRecord
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the CteStudentAcademicRecord.CreditsAttemptedCumulative nullable property
        /// </summary>
        public System.Decimal? CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// Defines the CteStudentAcademicRecord.CreditsEarnedCumulative nullable property
        /// </summary>
        public System.Decimal? CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// Defines the CteStudentAcademicRecord.DiplomaOrCredentialAwardDate non nullable property
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
        /// </summary>
        public Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
