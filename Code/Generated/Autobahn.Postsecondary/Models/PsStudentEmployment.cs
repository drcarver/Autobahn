//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentEmployment.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentEmployment
     /// </summary>
    public partial class PsStudentEmployment : IPsStudentEmployment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentEmployment.EmploymentNaicsCode non nullable property
        /// </summary>
        public System.String EmploymentNaicsCode { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
        /// </summary>
        public Guid? RefEmployedWhileEnrolledId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
        /// </summary>
        public Guid? RefEmployedAfterExitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentStatusWhileEnrolled"/> model
        /// </summary>
        public Guid? RefEmploymentStatusWhileEnrolledId { get; set; }

        /// <summary>
        /// Defines the PsStudentEmployment.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentEmployment.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}