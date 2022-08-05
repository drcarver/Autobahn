//**********************************************************
//* DomainName: Autobahn.CareerandTechnical
//* FileName:   ICteStudentAcademicRecord.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.CareerandTechnical.Interfaces
{
     /// <summary>
     /// The ICteStudentAcademicRecord
     /// </summary>
    public partial interface ICteStudentAcademicRecord : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the CteStudentAcademicRecord.CreditsAttemptedCumulative nullable property
        /// </summary>
        System.Decimal? CreditsAttemptedCumulative { get; set; }

        /// <summary>
        /// Defines the CteStudentAcademicRecord.CreditsEarnedCumulative nullable property
        /// </summary>
        System.Decimal? CreditsEarnedCumulative { get; set; }

        /// <summary>
        /// Defines the CteStudentAcademicRecord.DiplomaOrCredentialAwardDate non nullable property
        /// </summary>
        System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
        /// </summary>
        Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

    }
}
