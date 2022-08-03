//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentAdmissionTest.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentAdmissionTest
     /// </summary>
    public partial class PsStudentAdmissionTest : IPsStudentAdmissionTest
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefStandardizedAdmissionTest"/> model
        /// </summary>
        public Guid RefStandardizedAdmissionTestId { get; set; }

        /// <summary>
        /// Defines the PsStudentAdmissionTest.StandardizedAdmissionTestScore nullable property
        /// </summary>
        public System.Decimal? StandardizedAdmissionTestScore { get; set; }

        /// <summary>
        /// Defines the PsStudentAdmissionTest.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentAdmissionTest.RecordEndDateTime nullable property
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
