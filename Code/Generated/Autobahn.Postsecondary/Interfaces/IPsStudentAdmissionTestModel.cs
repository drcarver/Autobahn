//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentAdmissionTestModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentAdmissionTestModel Interface
     /// </summary>
    public partial interface IPsStudentAdmissionTestModel : IAutobahnBase
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
