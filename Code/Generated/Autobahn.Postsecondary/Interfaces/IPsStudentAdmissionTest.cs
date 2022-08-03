//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentAdmissionTest.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentAdmissionTest
     /// </summary>
    public partial interface IPsStudentAdmissionTest
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefStandardizedAdmissionTest"/> model
        /// </summary>
        Guid RefStandardizedAdmissionTestId { get; set; }

        /// <summary>
        /// Defines the PsStudentAdmissionTest.StandardizedAdmissionTestScore nullable property
        /// </summary>
        System.Decimal? StandardizedAdmissionTestScore { get; set; }

        /// <summary>
        /// Defines the PsStudentAdmissionTest.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentAdmissionTest.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
