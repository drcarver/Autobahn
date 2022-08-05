//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   IAeStudentAcademicRecord.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeStudentAcademicRecord
     /// </summary>
    public partial interface IAeStudentAcademicRecord : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the AeStudentAcademicRecord.DiplomaOrCredentialAwardDate non nullable property
        /// </summary>
        System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaType"/> model
        /// </summary>
        Guid? RefHighSchoolDiplomaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfessionalTechnicalCredentialType"/> model
        /// </summary>
        Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

    }
}
