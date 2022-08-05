//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   AeStudentAcademicRecord.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeStudentAcademicRecord
     /// </summary>
    public partial class AeStudentAcademicRecord : AutobahnBase, Interfaces.IAeStudentAcademicRecord
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the AeStudentAcademicRecord.DiplomaOrCredentialAwardDate non nullable property
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighSchoolDiplomaType"/> model
        /// </summary>
        public Guid? RefHighSchoolDiplomaTypeId { get; set; }

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
