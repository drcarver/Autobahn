//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentAdmissionTest.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentAdmissionTest
     /// </summary>
    public partial interface IPsStudentAdmissionTest : IAutobahnBase
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

    }
}
